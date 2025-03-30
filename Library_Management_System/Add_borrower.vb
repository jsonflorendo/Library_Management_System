Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Fm_add_borrower

    Dim Gender As String

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click

        If Txt_temp_borrower_id_number.Text = "" Then

            Fm_home_page.Enabled = True
            Me.Close()

        Else

            'returned previous ID Number
            con.Close()
            con.Open()
            sql = "UPDATE tbl_borrower SET
                        borrower_id = '" & Txt_temp_borrower_id_number.Text & "'                                        
                WHERE primary_borrower_id = '" & Fm_home_page.Lv_borrower_info.SelectedItems(0).SubItems(7).Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            con.Close()
            '---------------------------------

            Fm_home_page.Enabled = True
            Me.Close()

        End If

    End Sub

    Private Sub Rb_male_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_male.CheckedChanged

        Gender = "MALE"

    End Sub

    Private Sub Rb_female_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_female.CheckedChanged

        Gender = "FEMALE"

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Try

            If Txt_borrower_id_number.Text = "" Or
                Txt_borrower_last_name.Text = "" Or
                Txt_borrower_first_name.Text = "" Or
                Txt_borrower_middle_name.Text = "" Or
                Gender = "" Or
                Txt_borrower_address.Text = "" Or
                Txt_borrower_contact_no.Text = "" Then

                MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                con.Open()

                sql = "SELECT * FROM tbl_borrower
                                WHERE borrower_id = '" & Txt_borrower_id_number.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    con.Close()
                    MessageBox.Show("ID Number already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    dr.Close()

                    Dim dialog As DialogResult

                    dialog = MessageBox.Show("Do you want to save " + Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If dialog = DialogResult.Yes Then

                        sql = "INSERT INTO tbl_borrower (borrower_id,
                                                        last_name,
                                                        first_name,
                                                        middle_name,
                                                        gender,
                                                        borrower_contact_no,
                                                        borrower_address)
                                        VALUE ('" & Txt_borrower_id_number.Text & "',
                                                '" & Txt_borrower_last_name.Text & "',
                                                '" & Txt_borrower_first_name.Text & "',
                                                '" & Txt_borrower_middle_name.Text & "',
                                                '" & Gender & "',
                                                '" & Txt_borrower_contact_no.Text & "',
                                                '" & Txt_borrower_address.Text & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        Load_borrower_info_data_table()
                        MessageBox.Show(Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Fm_home_page.Enabled = True
                        Me.Close()

                    Else

                        con.Close()

                    End If

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Try

            If Txt_borrower_id_number.Text = "" Or
                Txt_borrower_last_name.Text = "" Or
                Txt_borrower_first_name.Text = "" Or
                Txt_borrower_middle_name.Text = "" Or
                Gender = "" Or
                Txt_borrower_address.Text = "" Or
                Txt_borrower_contact_no.Text = "" Then

                MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                con.Open()

                'to make sure ID Number not exists while in update process
                sql = "UPDATE tbl_borrower SET
                                        borrower_id = '" & "" & "'                                        
                               WHERE primary_borrower_id = '" & Fm_home_page.Lv_borrower_info.SelectedItems(0).SubItems(7).Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                dr.Close()
                '---------------------------------

                sql = "SELECT * FROM tbl_borrower
                                WHERE borrower_id = '" & Txt_borrower_id_number.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    con.Close()

                    MessageBox.Show("ID Number already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    Dim dialog As DialogResult

                    dialog = MessageBox.Show("Do you want to update " + Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If dialog = DialogResult.Yes Then

                        dr.Close()

                        'issued_to_last_name = '" & Txt_last_name.Text + ", " + Txt_first_name.Text & "' - /* concatenate of 2 inputs and save to mysql database table into 1 column */

                        sql = "UPDATE tbl_borrower SET
                                        borrower_id = '" & Txt_borrower_id_number.Text & "',
                                        last_name = '" & Txt_borrower_last_name.Text & "',
                                        first_name = '" & Txt_borrower_first_name.Text & "',
                                        middle_name = '" & Txt_borrower_middle_name.Text & "',
                                        gender = '" & Gender & "',
                                        borrower_contact_no = '" & Txt_borrower_contact_no.Text & "',
                                        borrower_address = '" & Txt_borrower_address.Text & "'
                               WHERE primary_borrower_id = '" & Fm_home_page.Lv_borrower_info.SelectedItems(0).SubItems(7).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        con.Close()

                        Load_borrower_info_data_table()
                        Load_returned_borrowed_books_data_table()
                        Load_penalty_report_data_table()
                        MessageBox.Show(Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + " was updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Fm_home_page.Enabled = True
                        Me.Close()

                    Else

                        con.Close()

                    End If

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Txt_borrower_id_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_id_number.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_id_number.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789- " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_borrower_last_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_last_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_last_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_borrower_first_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_first_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_first_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_borrower_middle_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_middle_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_middle_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_borrower_contact_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_contact_no.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_contact_no.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Txt_borrower_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_address.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 200 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_address.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class