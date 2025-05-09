﻿Imports MySql.Data.MySqlClient

Public Class Fm_add_author

    Private Sub Fm_add_author_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        If Txt_author_name.Text = "" Then

            Lbl_error_msg.Text = "Please enter author name"

        Else

            Try

                con.Open()

                sql = "SELECT COUNT(*) FROM tbl_library_author
                                WHERE TRIM(author_name) = '" & Txt_author_name.Text.Trim & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_Count As Integer = cmd.ExecuteScalar()

                If duplicate_Count > 0 Then

                    Lbl_error_msg.Text = "Author already exists"

                Else

                    sql = "INSERT INTO tbl_library_author (author_name)
                                  VALUE ('" & Txt_author_name.Text.Trim & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Author added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If Fm_home_page.Enabled = False And Fm_add_books.Enabled = False Then

                        Load_library_cb_author()
                        Fm_add_books.Enabled = True
                        Fm_add_books.Txt_author.Text = Txt_author_name.Text

                    Else

                        Load_library_author_data_table(Fm_home_page.Txt_search_author.Text)
                        Fm_home_page.Enabled = True

                    End If

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

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        If Txt_author_name.Text = "" Then

            Lbl_error_msg.Text = "Please enter author name"

        Else

            Try

                con.Open()

                Dim primary_author_id As String = Fm_home_page.Lv_author.SelectedItems(0).SubItems(1).Text

                sql = "SELECT COUNT(*) FROM tbl_library_author
                                WHERE TRIM(author_name) = '" & Txt_author_name.Text.Trim & "' AND primary_author_id <> '" & primary_author_id & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_Count As Integer = cmd.ExecuteScalar()

                If duplicate_Count > 0 Then

                    Lbl_error_msg.Text = "Author already exists"

                Else

                    sql = "UPDATE tbl_library_author SET
                                  author_name = '" & Txt_author_name.Text.Trim & "'
                           WHERE primary_author_id = '" & primary_author_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Author updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_author_data_table(Fm_home_page.Txt_search_author.Text)
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

        Else

            Fm_home_page.Enabled = True
            Load_library_author_data_table(Fm_home_page.Txt_search_author.Text) '-> To item selection On the listview

        End If

        Me.Close()

    End Sub

    Private Sub Txt_author_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_author_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_author_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class