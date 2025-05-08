Imports MySql.Data.MySqlClient

Public Class Fm_add_book_inventory

    Private Sub Fm_add_book_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

    End Sub

    Private Sub save_Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles save_Txt_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            If save_Txt_isbn.Text = "" Or Txt_book_quantity.Text = "" Then

                ' Store TextBoxes and their corresponding Labels
                Dim textBoxes = {save_Txt_isbn, Txt_book_quantity}
                Dim labels = {Lbl_error_msg, Lbl_error_msg_1}

                ' Loop through each TextBox and validate
                For i = 0 To textBoxes.Length - 1
                    If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                        labels(i).Text = "This field is required"
                    End If
                Next

            Else

                Try

                    con.Open()

                    ' Check book details on the books table
                    sql = "SELECT * FROM tbl_books
                                    WHERE isbn = '" & save_Txt_isbn.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    Dim primary_book_id As String = ""
                    Dim isbn As String = ""

                    If dr.Read() Then
                        primary_book_id = dr("primary_book_id").ToString()
                        isbn = dr("isbn").ToString()
                    End If
                    dr.Close()

                    If save_Txt_isbn.Text = isbn Then

                        Dim quantity As Integer = Txt_book_quantity.Text

                        ' Check book details exists on the database, if so, update quantity, else add new data on the book inventory
                        sql = "SELECT * FROM tbl_book_inventory
                                WHERE primary_book_id = '" & primary_book_id & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader()

                        Dim primary_book_inventory_id As String = ""
                        Dim total_quantity As Integer

                        If dr.Read() Then
                            primary_book_inventory_id = dr("primary_book_inventory_id").ToString()
                            total_quantity = dr("quantity") + quantity
                        End If
                        dr.Close()

                        If primary_book_inventory_id = "" Then

                            sql = "INSERT INTO tbl_book_inventory (primary_book_id,
                                                                    quantity,
                                                                    status)
                                    VALUE  ('" & primary_book_id & "',
                                            '" & quantity & "',
                                            'On Stock')"

                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                        Else

                            sql = "UPDATE tbl_book_inventory
                                    SET quantity = '" & total_quantity & "',
                                        status = 'On Stock'
                                    WHERE primary_book_id = '" & primary_book_id & "'"
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                        End If

                        con.Close()

                        save_Txt_isbn.Clear()
                        Txt_book_quantity.Clear()
                        Load_book_inventory_data_table(Fm_home_page.Txt_book_inventory_search.Text)

                    Else

                        con.Close()

                        save_Txt_isbn.Clear()

                        MessageBox.Show("Book details not found, click OK to add new book details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Enabled = False
                        Fm_add_books.Show()
                        Fm_add_books.Btn_update.Visible = False

                    End If

                Catch ex As Exception

                    MsgBox("Error: " & ex.Message)

                Finally

                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If

                End Try

            End If

        End If

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Clear_error_msg()

        If Txt_book_quantity.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes = {Txt_book_quantity}
            Dim labels = {Lbl_error_msg_1}

            ' Loop through each TextBox and validate
            For i = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

        ElseIf Txt_book_quantity.Text = 0 Then

            Lbl_error_msg_1.Text = "Please enter the value greater then 0"

        Else

            Try

                con.Open()

                Dim primary_book_id As String = Fm_home_page.Lv_book_inventory.SelectedItems(0).SubItems(9).Text
                Dim quantity As Integer = Txt_book_quantity.Text

                sql = "UPDATE tbl_book_inventory
                        SET quantity = '" & quantity & "',
                            status = 'On Stock'
                        WHERE primary_book_id = '" & primary_book_id & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Book's quantity updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Load_book_inventory_data_table(Fm_home_page.Txt_book_inventory_search.Text)
                Fm_home_page.Enabled = True
                Me.Close()

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        End If

    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Load_book_inventory_data_table(Fm_home_page.Txt_book_inventory_search.Text)
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

    Private Sub Txt_book_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_book_quantity.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_book_quantity.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

End Class