Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class Fm_issued_books

    Private Sub Fm_issued_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dtp_due_date.Format = DateTimePickerFormat.Custom
        Dtp_due_date.CustomFormat = "MMMM dd, yyyy"

        Dtp_due_date.Value = Date.Now.AddDays(30)

        Txt_isbn.Enabled = False

        Clear_error_msg()

        ' Transaction Series Number
        Try
            con.Open()

            ' Query to get the last transaction series and year
            sql = "SELECT MAX(transaction_series), MAX(YEAR(created_at)) FROM tbl_issued_books"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Dim currentYear As String = Date.Now.ToString("yyyy") ' Get current year
            Dim lastYear As Object = Nothing
            Dim lastNumber As Object = Nothing

            If dr.Read() Then
                lastNumber = dr(0) ' Last transaction series
                lastYear = dr(1) ' Last year
            End If
            dr.Close()

            Dim nextNumber As Integer

            ' If no records exist OR the year has changed, reset to 00001
            If IsDBNull(lastNumber) OrElse IsDBNull(lastYear) OrElse lastYear.ToString() <> currentYear Then
                nextNumber = 1 ' Reset to 00001
            Else
                nextNumber = Convert.ToInt32(lastNumber) + 1 ' Increment series
            End If

            ' Format series with leading zeros
            Lbl_transaction_series.Text = nextNumber.ToString("D5") ' Example: 00001

            ' Display formatted year & month
            Lbl_transaction_yyyy_mm.Text = "BB" & currentYear & "-" & Date.Now.ToString("MM")

            con.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            Try

                con.Open()

                sql = "SELECT * FROM tbl_books
                                WHERE isbn = '" & Txt_isbn.Text & "'
                                AND status = '" & "Available" & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    If dr("status") = "Available" Then

                        Txt_primary_book_id.Text = dr("primary_book_id")
                        Txt_book_name.Text = dr("book_name")
                        Dim Total_book_qty As Integer = dr("qty") - 1

                        dr.Close()

                        sql = "SELECT   tbl_borrower.borrower_id,
                                        tbl_books.book_name,
                                        tbl_issued_books.returned_date                        
                        
                                FROM tbl_issued_books

                                INNER JOIN tbl_borrower ON tbl_issued_books.primary_borrower_id = tbl_borrower.primary_borrower_id
                                INNER JOIN tbl_books ON tbl_issued_books.primary_book_id = tbl_books.primary_book_id

                                WHERE borrower_id = '" & Txt_borrower_id_number.Text & "'
                                AND book_name = '" & Txt_book_name.Text & "'
                                AND returned_date = '" & "" & "'"

                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader()

                        If dr.Read Then

                            MessageBox.Show("The book of " + Txt_book_name.Text + " was borrowed by " + Txt_issued_to.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Txt_isbn.Clear()

                            con.Close()

                        Else

                            dr.Close()

                            sql = "INSERT INTO tbl_issued_books (primary_borrower_id,
                                                                    transaction_yyyy_mm,
                                                                    transaction_series,
                                                                    primary_book_id,
                                                                    issued_date,
                                                                    due_date,
                                                                    created_at)
                                            VALUE ('" & Txt_primary_borrower_id.Text & "',
                                                    '" & Lbl_transaction_yyyy_mm.Text & "',
                                                    '" & Lbl_transaction_series.Text & "',
                                                    '" & Txt_primary_book_id.Text & "',
                                                    '" & Date.Now.ToString("MMMM dd, yyyy") & "',
                                                    '" & Dtp_due_date.Value.ToString("MMMM dd, yyyy") & "',
                                                    '" & Date.Now.ToString("yyyy-MM-dd") & "')"
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                            If Total_book_qty = 0 Then

                                sql = "UPDATE tbl_books SET 
                                                qty = '" & Total_book_qty & "',
                                                status = '" & "Borrowed" & "'
                                        WHERE primary_book_id = '" & Txt_primary_book_id.Text & "'"
                                cmd = New MySqlCommand(sql, con)
                                dr = cmd.ExecuteReader

                            Else

                                sql = "UPDATE tbl_books SET 
                                                qty = '" & Total_book_qty & "'
                                        WHERE primary_book_id = '" & Txt_primary_book_id.Text & "'"
                                cmd = New MySqlCommand(sql, con)
                                dr = cmd.ExecuteReader

                            End If

                            con.Close()

                            Load_returned_borrowed_books_data_table(Fm_home_page.Txt_returned_borrowed_books_search.Text)
                            Txt_isbn.Clear()

                            ' Removed this line due to Scan Mode
                            'MessageBox.Show(Txt_book_name.Text + " book has been issued to " + Txt_issued_to.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Fm_home_page.Enabled = True
                            'Me.Close()

                        End If

                    Else

                        Lbl_error_msg_1.Text = "Book is not available"
                        con.Close()

                    End If

                Else

                    Lbl_error_msg_1.Text = "Invalid Bar Code Number"
                    Txt_isbn.Clear()
                    Txt_book_name.Clear()
                    con.Close()

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

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

                Txt_primary_borrower_id.Text = dr("primary_borrower_id")
                Txt_issued_to.Text = dr("first_name") + " " + dr("last_name")

            Else

                Lbl_error_msg.Text = "Invalid ID Number"
                Txt_issued_to.Clear()
                Txt_primary_borrower_id.Clear()

            End If

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

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

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click

        Load_listed_books_data_table(Fm_home_page.Txt_listed_books_search.Text)
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
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789- " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class