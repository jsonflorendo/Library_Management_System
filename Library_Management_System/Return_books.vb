Imports MySql.Data.MySqlClient

Public Class Fm_returned_books

    Private Sub Fm_returned_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Txt_isbn.Enabled = False

        Clear_error_msg()

    End Sub

    Private Sub Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            Try

                con.Open()

                sql = "SELECT COUNT(*) FROM tbl_books
                                WHERE isbn = '" & Txt_isbn.Text & "'"
                cmd = New MySqlCommand(sql, con)

                Dim isbn_Count As Integer = cmd.ExecuteScalar()

                If isbn_Count > 0 Then

                    sql = "SELECT   tbl_issued_books.primary_issued_book_id,
                                    tbl_books.primary_book_id,
                                    tbl_books.book_name

                            FROM tbl_issued_books

                            INNER JOIN tbl_borrower ON tbl_issued_books.primary_borrower_id = tbl_borrower.primary_borrower_id
                            INNER JOIN tbl_books ON tbl_issued_books.primary_book_id = tbl_books.primary_book_id

                            WHERE borrower_id = '" & Txt_borrower_id_number.Text & "'
                            AND isbn = '" & Txt_isbn.Text & "'
                            AND returned_date IS NULL"

                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If Not dr.Read Then

                        MessageBox.Show("No data available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Txt_isbn.Clear()

                        con.Close()

                    Else

                        Dim primary_issued_book_id As String = dr("primary_issued_book_id").ToString()
                        Txt_primary_book_id.Text = dr("primary_book_id").ToString()
                        Txt_book_name.Text = dr("book_name").ToString()

                        dr.Close()


                        sql = "UPDATE tbl_issued_books SET 
                                        returned_date = '" & Date.Now.ToString("MMMM dd, yyyy") & "'
                                WHERE primary_issued_book_id = '" & primary_issued_book_id & "'"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()


                        sql = "SELECT * FROM tbl_book_inventory
                                        WHERE primary_book_id = '" & Txt_primary_book_id.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        Dim total_quantity As Integer

                        If dr.Read() Then
                            total_quantity = dr("quantity").ToString() + 1
                        End If
                        dr.Close()


                        sql = "UPDATE tbl_book_inventory SET
                                        quantity = '" & total_quantity & "',
                                        status = '" & "On Stock" & "'
                                WHERE primary_book_id = '" & Txt_primary_book_id.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        Txt_isbn.Clear()
                        Load_returned_borrowed_books_data_table(Fm_home_page.Txt_returned_borrowed_books_search.Text)

                        Dim dialog As DialogResult

                        dialog = MessageBox.Show("Do you want to add penalty for " + Txt_issued_to.Text + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                        If dialog = DialogResult.Yes Then

                            Fm_add_penalty.Txt_borrower_id.Text = Txt_borrower_id_number.Text
                            Fm_add_penalty.Txt_borrower_name.Text = Txt_issued_to.Text
                            Fm_add_penalty.Txt_book_name.Text = Txt_book_name.Text

                            Fm_add_penalty.Txt_primary_borrower_id.Text = Txt_primary_borrower_id.Text
                            Fm_add_penalty.Txt_primary_book_id.Text = Txt_primary_book_id.Text

                            Fm_add_penalty.Show()
                            Fm_add_penalty.Btn_update.Visible = False
                            Me.Enabled = False

                        End If

                    End If

                Else

                    Lbl_error_msg_1.Text = "Invalid Bar Code Number"
                    Txt_isbn.Clear()

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        End If

    End Sub

    Private Sub Txt_borrower_id_number_TextChanged(sender As Object, e As EventArgs) Handles Txt_borrower_id_number.TextChanged

        Clear_error_msg()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_borrower
                            WHERE borrower_id = '" & Txt_borrower_id_number.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            If dr.Read() Then

                Txt_primary_borrower_id.Text = dr("primary_borrower_id").ToString()
                Txt_issued_to.Text = dr("first_name").ToString() + " " + dr("last_name").ToString()
                Txt_isbn.Focus()

            Else

                Lbl_error_msg.Text = "Invalid ID Number"
                Txt_issued_to.Clear()
                Txt_primary_borrower_id.Clear()

            End If

            dr.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Txt_issued_to_TextChanged(sender As Object, e As EventArgs) Handles Txt_issued_to.TextChanged

        If Txt_issued_to.Text = "" Then
            Txt_isbn.Enabled = False
        Else
            Txt_isbn.Enabled = True
        End If

    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Load_returned_borrowed_books_data_table(Fm_home_page.Txt_returned_borrowed_books_search.Text)
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

    Private Sub Txt_borrower_id_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_id_number.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_id_number.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789-" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class