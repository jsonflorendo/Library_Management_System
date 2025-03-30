Imports MySql.Data.MySqlClient

Public Class Fm_returned_books

    Private Sub Fm_returned_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Txt_isbn.Enabled = False

    End Sub

    Private Sub Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_isbn.KeyPress

        If e.KeyChar = ChrW(13) Then

            con.Open()

            sql = "SELECT   tbl_issued_books.primary_issued_book_id,
                            tbl_borrower.last_name,
                            tbl_borrower.first_name,
                            tbl_books.primary_book_id,
                            tbl_books.isbn,
                            tbl_books.book_name

                    FROM tbl_issued_books

                    INNER JOIN tbl_borrower ON tbl_issued_books.primary_borrower_id = tbl_borrower.primary_borrower_id
                    INNER JOIN tbl_books ON tbl_issued_books.primary_book_id = tbl_books.primary_book_id

                    WHERE borrower_id = '" & Txt_borrower_id_number.Text & "'
                    AND isbn = '" & Txt_isbn.Text & "'
                    AND returned_date = '" & "" & "'"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            If dr.Read Then

                Txt_primary_issued_book_id.Text = dr("primary_issued_book_id")
                Txt_primary_book_id.Text = dr("primary_book_id")
                Txt_book_name.Text = dr("book_name")

                dr.Close()

                Try

                    sql = "UPDATE tbl_issued_books SET 
                                    returned_date = '" & Date.Now.ToString("MMMM dd, yyyy") & "'
                            WHERE primary_issued_book_id = '" & Txt_primary_issued_book_id.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    dr.Close()


                    sql = "SELECT * FROM tbl_books
                                    WHERE primary_book_id = '" & Txt_primary_book_id.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    dr.Read()

                    Dim book_qty As Integer = dr("qty")

                    dr.Close()

                    If book_qty = 0 Then

                        sql = "UPDATE tbl_books SET
                                        qty = '" & book_qty + 1 & "',
                                        status = '" & "Available" & "'
                               WHERE primary_book_id = '" & Txt_primary_book_id.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        con.Close()

                        Txt_isbn.Clear()
                        Load_listed_books_data_table()
                        Load_returned_borrowed_books_data_table()

                    Else

                        sql = "UPDATE tbl_books SET
                                        qty = '" & book_qty + 1 & "'
                               WHERE primary_book_id = '" & Txt_primary_book_id.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        con.Close()

                        Txt_isbn.Clear()
                        Load_listed_books_data_table()
                        Load_returned_borrowed_books_data_table()

                    End If

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Else

                MessageBox.Show("No data available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Txt_isbn.Clear()
                con.Close()

            End If

        Else

            con.Close()

        End If

    End Sub

    Private Sub Txt_borrower_id_number_TextChanged(sender As Object, e As EventArgs) Handles Txt_borrower_id_number.TextChanged

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

                Txt_issued_to.Clear()
                Txt_primary_borrower_id.Clear()

            End If

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Txt_issued_to_TextChanged(sender As Object, e As EventArgs) Handles Txt_issued_to.TextChanged

        If Txt_issued_to.Text = "" Then

            Txt_isbn.Enabled = False

        Else

            Txt_isbn.Enabled = True

        End If

    End Sub

    Private Sub Btn_penalty_Click(sender As Object, e As EventArgs) Handles Btn_penalty.Click

        Fm_add_penalty.Txt_borrower_id.Text = Txt_borrower_id_number.Text
        Fm_add_penalty.Txt_borrower_name.Text = Txt_issued_to.Text
        Fm_add_penalty.Txt_book_name.Text = Txt_book_name.Text

        Fm_add_penalty.Txt_primary_book_id.Text = Fm_home_page.Lv_returned_borrowed_books.SelectedItems(0).SubItems(7).Text

        Fm_add_penalty.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click

        Load_returned_borrowed_books_data_table()
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

End Class