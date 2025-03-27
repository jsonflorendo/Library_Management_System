Imports MySql.Data.MySqlClient

Public Class Fm_add_author

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        If Txt_author_name.Text = "" Then

            MessageBox.Show("Please enter author name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_library_author
                                WHERE author_name = '" & Txt_author_name.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    con.Close()
                    MessageBox.Show("Author already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    dr.Close()

                    sql = "INSERT INTO tbl_library_author (author_name)
                                  VALUE ('" & Txt_author_name.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Author added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_author_data_table()
                    Fm_home_page.Enabled = True
                    Me.Close()

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try


        End If

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        If Txt_author_name.Text = "" Then

            MessageBox.Show("Please enter author name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Try

                con.Open()

                'to make sure Author Name not exists while in update process
                sql = "UPDATE tbl_library_author SET 
                              author_name = '" & "" & "'                                        
                       WHERE primary_author_id = '" & Fm_home_page.Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                dr.Close()
                '---------------------------------

                sql = "SELECT * FROM tbl_library_author
                                WHERE author_name = '" & Txt_author_name.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    dr.Close()

                    MessageBox.Show("Author already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'returned previous Author Name
                    sql = "UPDATE tbl_library_author SET 
                                  author_name = '" & Fm_home_page.Lv_author.SelectedItems(0).Text & "'                                       
                           WHERE primary_author_id = '" & Fm_home_page.Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()
                    '---------------------------------

                Else

                    dr.Close()

                    sql = "UPDATE tbl_library_author SET
                                  author_name = '" & Txt_author_name.Text & "'
                           WHERE primary_author_id = '" & Fm_home_page.Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show("Author updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_author_data_table()
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
        Load_author_data_table() '-> To item selection On the listview
        Me.Close()

    End Sub

    Private Sub Txt_author_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_author_name.KeyPress

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
        If Txt_author_name.TextLength >= maxLength Then
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