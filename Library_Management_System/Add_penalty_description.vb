Imports MySql.Data.MySqlClient

Public Class Fm_penalty_description

    Private Sub Fm_penalty_description_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Clear_error_msg()

        If Txt_penalty_description.Text = "" Or Txt_penalty_amount.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_penalty_description, Txt_penalty_amount}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1}

            ' Loop through each TextBox and validate
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_library_penalty
                                WHERE penalty_description = '" & Txt_penalty_description.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    con.Close()
                    Lbl_error_msg.Text = "Penalty Description already exists"

                Else

                    dr.Close()

                    sql = "INSERT INTO tbl_library_penalty (penalty_description,
                                                            amount)
                                  VALUE ('" & Txt_penalty_description.Text & "',
                                         '" & Txt_penalty_amount.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Penalty Description added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_penalty_data_table()
                    Fm_home_page.Enabled = True
                    Me.Close()

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try


        End If

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Clear_error_msg()

        If Txt_penalty_description.Text = "" Or Txt_penalty_amount.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_penalty_description, Txt_penalty_amount}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1}

            ' Loop through each TextBox and validate
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

        Else

            Try

                con.Open()

                'to make sure Penalty Description not exists while in update process
                sql = "UPDATE tbl_library_penalty SET 
                              penalty_description = '" & "" & "'                                        
                       WHERE primary_penalty_description_id = '" & Fm_home_page.Lv_penalty_description.SelectedItems(0).SubItems(2).Text & "'"
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

                    Lbl_error_msg.Text = "Penalty Description already exists"

                    'returned previous Author Name
                    sql = "UPDATE tbl_library_penalty SET 
                                  penalty_description = '" & Fm_home_page.Lv_penalty_description.SelectedItems(0).Text & "'                                       
                           WHERE primary_penalty_description_id = '" & Fm_home_page.Lv_penalty_description.SelectedItems(0).SubItems(2).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()
                    '---------------------------------

                Else

                    dr.Close()

                    sql = "UPDATE tbl_library_penalty SET
                                  penalty_description = '" & Txt_penalty_description.Text & "',
                                  amount = '" & Txt_penalty_amount.Text & "'
                           WHERE primary_penalty_description_id = '" & Fm_home_page.Lv_penalty_description.SelectedItems(0).SubItems(2).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show("Penalty Description updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_penalty_data_table()
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
        Load_library_penalty_data_table() '-> To item selection On the listview
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

    Private Sub Txt_penalty_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_penalty_amount.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_penalty_description.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "0123456789,." ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class