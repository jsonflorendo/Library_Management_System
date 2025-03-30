Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Fm_admin_registration

    Dim Gender As String

    Private Sub Fm_admin_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection()

        Clear_error_msg()

        Txt_password.UseSystemPasswordChar = True
        Txt_confirmpassword.UseSystemPasswordChar = True


        Dtp_birthdate.Format = DateTimePickerFormat.Custom
        Dtp_birthdate.CustomFormat = "MMMM dd, yyyy"

    End Sub

    Private Sub Rb_male_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_male.CheckedChanged

        Gender = "MALE"

    End Sub

    Private Sub Rb_female_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_female.CheckedChanged

        Gender = "FEMALE"

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Clear_error_msg()

        If Txt_firstname.Text = "" Or
            Txt_middlename.Text = "" Or
            Txt_lastname.Text = "" Or
            Gender = "" Or
            Txt_contact.Text = "" Or
            Txt_address.Text = "" Or
            Txt_username.Text = "" Or
            Txt_email.Text = "" Or
            Cb_user_type.Text = "-Select User Type-" Or
            Txt_password.Text = "" Or
            Txt_confirmpassword.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_firstname, Txt_middlename, Txt_lastname, Txt_contact, Txt_address, Txt_username, Txt_email, Txt_password, Txt_confirmpassword}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_5, Lbl_error_msg_6, Lbl_error_msg_7, Lbl_error_msg_8, Lbl_error_msg_10, Lbl_error_msg_11}

            ' Validate TextBoxes
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

            ' Validate the ComboBox (Dropdown)
            If Cb_user_type.SelectedIndex = -1 Then
                Lbl_error_msg_9.Text = "This field is required"
            End If

            ' Validate the RadioButtons (Check if at least one is selected)
            If Not (Rb_male.Checked Or Rb_female.Checked) Then
                Lbl_error_msg_3.Text = "Please select a gender"
            End If

        ElseIf Txt_password.Text <> Txt_confirmpassword.Text Then

            Lbl_error_msg_11.Text = "Password and Confirm Password"
            Lbl_error_msg_12.Text = "don't match"

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_admin
                                WHERE username = '" & Txt_username.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read = True Then

                    Lbl_error_msg_7.Text = "Username already exists"
                    con.Close()

                Else

                    dr.Close()

                    sql = "SELECT * FROM tbl_admin
                                    WHERE email = '" & Txt_email.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read = True Then

                        Lbl_error_msg_8.Text = "Email already exists"
                        con.Close()

                    Else

                        dr.Close()

                        sql = "INSERT INTO tbl_admin (first_name,
                                                        middle_name,
                                                        last_name,
                                                        gender,
                                                        birthday,
                                                        contact_no,
                                                        address,
                                                        username,
                                                        email,
                                                        password,
                                                        user_type)
                                        VALUE ('" & Txt_firstname.Text & "',
                                        '" & Txt_middlename.Text & "',
                                        '" & Txt_lastname.Text & "',
                                        '" & Gender & "',
                                        '" & Dtp_birthdate.Value.ToString("MMM-dd-yyyy") & "',
                                        '" & Txt_contact.Text & "',
                                        '" & Txt_address.Text & "',
                                        '" & Txt_username.Text & "',
                                        '" & Txt_email.Text & "',
                                        '" & Txt_password.Text & "',
                                        '" & Cb_user_type.Text & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        Fm_home_page.Enabled = True
                        Load_listed_accounts_data_table()
                        MessageBox.Show(Txt_firstname.Text + " " + Txt_lastname.Text + " added successfully")
                        Me.Close()

                    End If

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Clear_error_msg()

        If Txt_firstname.Text = "" Or
            Txt_middlename.Text = "" Or
            Txt_lastname.Text = "" Or
            Gender = "" Or
            Txt_contact.Text = "" Or
            Txt_address.Text = "" Or
            Txt_username.Text = "" Or
            Txt_email.Text = "" Or
            Cb_user_type.Text = "-Select User Type-" Or
            Txt_password.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_firstname, Txt_middlename, Txt_lastname, Txt_contact, Txt_address, Txt_username, Txt_email, Txt_password}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_5, Lbl_error_msg_6, Lbl_error_msg_7, Lbl_error_msg_8, Lbl_error_msg_10}

            ' Validate TextBoxes
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

            ' Validate the ComboBox (Dropdown)
            If Cb_user_type.SelectedIndex = -1 Then
                Lbl_error_msg_9.Text = "This field is required"
            End If

            ' Validate the RadioButtons (Check if at least one is selected)
            If Not (Rb_male.Checked Or Rb_female.Checked) Then
                Lbl_error_msg_3.Text = "Please select a gender"
            End If

        Else

            Try

                con.Open()

                'to make sure Username not exists while in update process
                sql = "UPDATE tbl_admin SET
                                username = '" & "" & "'
                        WHERE primary_admin_id = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(11).Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                dr.Close()
                '---------------------------------

                sql = "SELECT * FROM tbl_admin
                                WHERE username = '" & Txt_username.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    dr.Close()

                    Lbl_error_msg_7.Text = "Username already exists"

                    'returned previous Username
                    sql = "UPDATE tbl_admin SET
                                    username = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(7).Text & "'
                            WHERE primary_admin_id = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(11).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    con.Close()
                    '---------------------------------

                Else

                    dr.Close()

                    'returned previous Username
                    sql = "UPDATE tbl_admin SET
                                    username = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(7).Text & "'
                            WHERE primary_admin_id = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(11).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    dr.Close()
                    '---------------------------------

                    'to make sure Email not exists while in update process
                    sql = "UPDATE tbl_admin SET
                                email = '" & "" & "'
                        WHERE primary_admin_id = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(11).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    dr.Close()
                    '---------------------------------

                    sql = "SELECT * FROM tbl_admin
                                    WHERE email = '" & Txt_email.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        dr.Close()

                        Lbl_error_msg_8.Text = "Email already exists"

                        'returned previous Email
                        sql = "UPDATE tbl_admin SET
                                        email = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(8).Text & "'
                                WHERE primary_admin_id = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(11).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader
                        con.Close()
                        '---------------------------------

                    Else

                        dr.Close()

                        sql = "UPDATE tbl_admin SET 
                                        first_name = '" & Txt_firstname.Text & "',
                                        middle_name = '" & Txt_middlename.Text & "',
                                        last_name = '" & Txt_lastname.Text & "',
                                        gender = '" & Gender & "',
                                        birthday = '" & Dtp_birthdate.Value.ToString("MMM-dd-yyyy") & "',
                                        contact_no = '" & Txt_contact.Text & "',
                                        address = '" & Txt_address.Text & "',
                                        username = '" & Txt_username.Text & "',
                                        email = '" & Txt_email.Text & "',
                                        password = '" & Txt_password.Text & "',
                                        user_type = '" & Cb_user_type.Text & "'
                                WHERE primary_admin_id = '" & Fm_home_page.Lv_listed_accounts.SelectedItems(0).SubItems(11).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                            con.Close()

                            Load_listed_accounts_data_table()
                            MessageBox.Show(Txt_firstname.Text + " " + Txt_lastname.Text + " updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Fm_home_page.Enabled = True
                            Me.Close()

                        End If

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Fm_home_page.Enabled = True
        Load_listed_accounts_data_table() '-> To item selection On the listview
        Me.Close()

    End Sub

    Private Sub Cb_show_password_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_show_password.CheckedChanged

        If Cb_show_password.Checked = True Then

            Txt_password.UseSystemPasswordChar = False
            Txt_confirmpassword.UseSystemPasswordChar = False

        Else

            Txt_password.UseSystemPasswordChar = True
            Txt_confirmpassword.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub Cb_user_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_user_type.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_user_type_Click(sender As Object, e As EventArgs) Handles Cb_user_type.Click

        Cb_user_type.DroppedDown = True

    End Sub

    Private Sub Txt_firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_firstname.KeyPress

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
        If Txt_firstname.TextLength >= maxLength Then
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

    Private Sub Txt_middlename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_middlename.KeyPress

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
        If Txt_middlename.TextLength >= maxLength Then
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

    Private Sub Txt_lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_lastname.KeyPress

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
        If Txt_lastname.TextLength >= maxLength Then
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

    Private Sub Txt_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_contact.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_contact.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Txt_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_address.KeyPress

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
        If Txt_address.TextLength >= maxLength Then
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

    Private Sub Txt_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_username.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_username.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+'<>,.?/""" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_email.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_email.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+'<>,.?/""" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_password.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_password.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+'<>,.?/""" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_confirmpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_confirmpassword.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_confirmpassword.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+'<>,.?/""" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class