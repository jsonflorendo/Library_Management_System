Imports MySql.Data.MySqlClient

Public Class Fm_add_category

    Private Sub Fm_add_category_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        If Txt_category_name.Text = "" Then

            Lbl_error_msg.Text = "Please enter genre"

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_library_category
                                WHERE category_name = '" & Txt_category_name.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    con.Close()
                    Lbl_error_msg.Text = "Genre already exists"

                Else

                    dr.Close()

                    sql = "INSERT INTO tbl_library_category (category_name)
                                  VALUE ('" & Txt_category_name.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Genre added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If Fm_home_page.Enabled = False And Fm_add_books.Enabled = False Then

                        Load_library_category_data_table(Fm_home_page.Txt_search_category.Text)
                        Load_library_cb_category()
                        Fm_add_books.Enabled = True
                        Fm_add_books.Cb_book_category.Text = Txt_category_name.Text
                        Me.Close()

                    Else

                        Load_library_category_data_table(Fm_home_page.Txt_search_category.Text)
                        Load_library_cb_category()
                        Fm_home_page.Enabled = True
                        Me.Close()

                    End If

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

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        If Txt_category_name.Text = "" Then

            Lbl_error_msg.Text = "Please enter genre"

        Else

            Try

                con.Open()

                'to make sure Category Name not exists while in update process
                sql = "UPDATE tbl_library_category SET 
                              category_name = '" & "" & "'                                        
                       WHERE primary_category_id = '" & Fm_home_page.Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                dr.Close()
                '---------------------------------

                sql = "SELECT * FROM tbl_library_category
                                WHERE category_name = '" & Txt_category_name.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    dr.Close()

                    Lbl_error_msg.Text = "Genre already exists"

                    'returned previous Category Name
                    sql = "UPDATE tbl_library_category SET 
                                  category_name = '" & Fm_home_page.Lv_category.SelectedItems(0).Text & "'
                           WHERE primary_category_id = '" & Fm_home_page.Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()
                    '---------------------------------

                Else

                    dr.Close()

                    sql = "UPDATE tbl_library_category SET
                                  category_name = '" & Txt_category_name.Text & "'
                           WHERE primary_category_id = '" & Fm_home_page.Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show("Genre updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_category_data_table(Fm_home_page.Txt_search_category.Text)
                    Load_library_cb_category()
                    Fm_home_page.Enabled = True
                    Me.Close()

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

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        If Fm_home_page.Enabled = False And Fm_add_books.Enabled = False Then

            Fm_add_books.Enabled = True
            Me.Close()

        Else

            Fm_home_page.Enabled = True
            Load_library_category_data_table(Fm_home_page.Txt_search_category.Text) '-> To item selection On the listview
            Me.Close()

        End If

    End Sub

    Private Sub Txt_category_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_category_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_category_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class