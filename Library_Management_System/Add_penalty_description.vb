Imports MySql.Data.MySqlClient

Public Class Fm_penalty_description

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        If Txt_penalty_description.Text = "" Then

            MessageBox.Show("Please enter penalty description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_library_penalty
                                WHERE penalty_description = '" & Txt_penalty_description.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    con.Close()
                    MessageBox.Show("Penalty Description already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    dr.Close()

                    sql = "INSERT INTO tbl_library_penalty (penalty_description)
                                  VALUE ('" & Txt_penalty_description.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Penalty Description added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_penalty_description_data_table()
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

        If Txt_penalty_description.Text = "" Then

            MessageBox.Show("Please enter penalty description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Try

                con.Open()

                'to make sure Penalty Description not exists while in update process
                sql = "UPDATE tbl_library_penalty SET 
                              penalty_description = '" & "" & "'                                        
                       WHERE primary_penalty_description_id = '" & Fm_home_page.Lv_penalty_description.SelectedItems(0).SubItems(1).Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                dr.Close()
                '---------------------------------

                sql = "SELECT * FROM tbl_library_penalty
                                WHERE penalty_description = '" & Txt_penalty_description.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    dr.Close()

                    MessageBox.Show("Penalty Description already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'returned previous Author Name
                    sql = "UPDATE tbl_library_penalty SET 
                                  penalty_description = '" & Fm_home_page.Lv_penalty_description.SelectedItems(0).Text & "'                                       
                           WHERE primary_penalty_description_id = '" & Fm_home_page.Lv_penalty_description.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()
                    '---------------------------------

                Else

                    dr.Close()

                    sql = "UPDATE tbl_library_penalty SET
                                  penalty_description = '" & Txt_penalty_description.Text & "'
                           WHERE primary_penalty_description_id = '" & Fm_home_page.Lv_penalty_description.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show("Penalty Description updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_penalty_description_data_table()
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
        Load_penalty_description_data_table() '-> To item selection On the listview
        Me.Close()

    End Sub

    Private Sub Txt_penalty_description_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_penalty_description.KeyPress

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
        If Txt_penalty_description.TextLength >= maxLength Then
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