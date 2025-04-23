Imports MySql.Data.MySqlClient

Public Class Fm_add_delivery

    Private Sub Fm_add_delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

        Txt_book_isbn.Enabled = False

    End Sub

    Private Sub Fm_add_delivery_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        If Txt_delivery_transaction_number.Text = "" Or
            Txt_delivery_delivered_by.Text = "" Or
            Txt_delivery_received_by.Text = "" Then

            Txt_book_isbn.Enabled = False

        Else

            Txt_book_isbn.Enabled = True

        End If

    End Sub

    Private Sub Txt_book_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_book_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            If Txt_delivery_transaction_number.Text = "" Or
               Txt_delivery_delivered_by.Text = "" Or
               Txt_delivery_received_by.Text = "" Then

                ' Store TextBoxes and their corresponding Labels
                Dim textBoxes = {Txt_delivery_transaction_number, Txt_delivery_delivered_by, Txt_delivery_received_by}
                Dim labels = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2}

                ' Loop through each TextBox and validate
                For i = 0 To textBoxes.Length - 1
                    If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                        labels(i).Text = "This field is required"
                    End If
                Next

            ElseIf Txt_book_isbn.Text = "" Then

                Lbl_error_msg_3.Text = "This field is required"

            Else

                Try

                    con.Open()

                    ' Search book details and display them in the TextBoxes
                    sql = "SELECT   tbl_books.isbn,
                                    tbl_books.book_name,
                                    tbl_library_category.category_name,
                                    tbl_library_author.author_name,
                                    tbl_library_publisher.publisher_name,
                                    tbl_books.publish_year,
                                    tbl_books.primary_book_id

                            FROM tbl_books

                            INNER JOIN tbl_library_category ON tbl_books.primary_category_id = tbl_library_category.primary_category_id
                            INNER JOIN tbl_library_author ON tbl_books.primary_author_id = tbl_library_author.primary_author_id
                            INNER JOIN tbl_library_publisher ON tbl_books.primary_publisher_id = tbl_library_publisher.primary_publisher_id

                            WHERE isbn = '" & Txt_book_isbn.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        Dim primary_book_id As String = dr("primary_book_id").ToString()
                        Dim isbn As String = dr("isbn").ToString()
                        Txt_book_title.Text = dr("book_name").ToString()
                        Txt_book_genre.Text = dr("category_name").ToString()
                        Txt_book_author.Text = dr("author_name").ToString()
                        Txt_book_publisher.Text = dr("publisher_name").ToString()
                        Txt_book_publish_year.Text = dr("publish_year").ToString()

                        Txt_book_isbn.Clear()

                        dr.Close()

                        ' Check if the Transaction Number, ISBN, and Date are already save on the database, if so, update quantity, if not, insert new record
                        sql = "SELECT   tbl_delivery.transaction_number,
                                        tbl_books.isbn,
                                        tbl_delivery.quantity,
                                        tbl_delivery.delivered_date

                               FROM tbl_delivery

                               INNER JOIN tbl_books ON tbl_delivery.primary_book_id = tbl_books.primary_book_id

                               WHERE    transaction_number = '" & Txt_delivery_transaction_number.Text & "' AND
                                        isbn = '" & isbn & "' AND
                                        delivery_date = '" & Date.Now.ToString("MMMM dd, yyyy") & "'"

                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader()

                        If dr.Read Then

                            Dim primary_delivery_id As String = dr("primary_delivery_id").ToString()
                            Dim total_quantity As String = dr("quantity").ToString() + 1

                            dr.Close()

                            sql = "UPDATE tbl_delivery
                                    SET quantity = '" & total_quantity & "'
                                    WHERE primary_delivery_id = '" & primary_delivery_id & "'"

                        Else

                            dr.Close()

                            sql = "INSERT INTO tbl_delivery (transaction_number,
                                                            primary_book_id,
                                                            quantity,
                                                            delivered_by,
                                                            delivery_date,
                                                            received_by)                                                            )
                                    VALUES ('" & Txt_delivery_transaction_number.Text & "',
                                            '" & primary_book_id & "',
                                            '1',
                                            '" & Txt_delivery_delivered_by.Text & "',
                                            '" & Date.Now.ToString("MMMM dd, yyyy") & "',
                                            '" & Txt_delivery_received_by.Text & "')"

                        End If

                    Else

                        con.Close()

                        Txt_book_isbn.Clear()

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



    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Load_delivery_data_table(Fm_home_page.Txt_search_delivery.Text)
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

End Class