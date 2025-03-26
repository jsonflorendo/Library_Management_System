Imports MySql.Data.MySqlClient

Public Class Fm_add_category

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        If Txt_category_name.Text = "" Then

            MessageBox.Show("Please enter genre", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_library_category
                                WHERE category_name = '" & Txt_category_name.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    con.Close()
                    MessageBox.Show("Genre already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    dr.Close()

                    sql = "INSERT INTO tbl_library_category (category_name)
                                  VALUE ('" & Txt_category_name.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Genre added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_category_data_table()
                    Load_library_cb_category()
                    Fm_home_page.Enabled = True
                    Me.Close()

                End If

            Catch ex As Exception

                con.Close()
                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        If Txt_category_name.Text = "" Then

            MessageBox.Show("Please enter genre", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

                    MessageBox.Show("Genre already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                    Load_category_data_table()
                    Load_library_cb_category()
                    Fm_home_page.Enabled = True
                    Me.Close()

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Fm_home_page.Enabled = True
        Load_category_data_table() '-> To item selection On the listview
        Me.Close()

    End Sub

    Private Sub Txt_category_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_category_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_category_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class