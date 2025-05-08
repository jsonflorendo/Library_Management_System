Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class Fm_add_borrower

    Private Sub Fm_add_borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

        If Txt_borrower_id_number.Text = "" Then

            Pb_id_no_barcode.Image = Nothing

        Else

            generate_barcode()

        End If

    End Sub

    Dim Gender As String

    Private Sub Rb_male_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_male.CheckedChanged

        Gender = "Male"

    End Sub

    Private Sub Rb_female_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_female.CheckedChanged

        Gender = "Female"

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Clear_error_msg()

        If Txt_borrower_id_number.Text = "" Or
            Txt_borrower_last_name.Text = "" Or
            Txt_borrower_first_name.Text = "" Or
            Txt_borrower_middle_name.Text = "" Or
            Cb_borrower_category_type.Text = "" Or
            Gender = "" Or
            Txt_borrower_contact_no.Text = "" Or
            Txt_borrower_email.Text = "" Or
            Txt_borrower_address.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_borrower_id_number, Txt_borrower_last_name, Txt_borrower_first_name, Txt_borrower_middle_name, Txt_borrower_contact_no, Txt_borrower_email, Txt_borrower_address}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_6, Lbl_error_msg_7, Lbl_error_msg_8}

            ' Validate TextBoxes
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

            ' Validate the ComboBox (Dropdown)
            If Cb_borrower_category_type.SelectedIndex = -1 Then
                Lbl_error_msg_4.Text = "This field is required"
            End If

            ' Validate the RadioButtons (Check if at least one is selected)
            If Not (Rb_male.Checked Or Rb_female.Checked) Then
                Lbl_error_msg_5.Text = "Please select a gender"
            End If

        Else

            Try

                con.Open()

                ' To display error message at the same time for ID Number and Email address if exists
                sql = "SELECT COUNT(*) FROM tbl_borrower
                                WHERE TRIM(borrower_id) = '" & Txt_borrower_id_number.Text.Trim & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_borrower_id_Count As Integer = cmd.ExecuteScalar()

                sql = "SELECT COUNT(*) FROM tbl_borrower
                                WHERE TRIM(email) = '" & Txt_borrower_email.Text.Trim & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_borrower_email_Count As Integer = cmd.ExecuteScalar()

                ' Display error messages if any
                Lbl_error_msg.Text = If(duplicate_borrower_id_Count > 0, "ID Number already exists", "")
                Lbl_error_msg_7.Text = If(duplicate_borrower_email_Count > 0, "Email address already exists", "")

                If duplicate_borrower_id_Count = 0 AndAlso duplicate_borrower_email_Count = 0 Then

                    Dim dialog As DialogResult

                    dialog = MessageBox.Show("Do you want to save " + Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If dialog = DialogResult.Yes Then

                        sql = "INSERT INTO tbl_borrower (borrower_id,
                                                        last_name,
                                                        first_name,
                                                        middle_name,
                                                        category_type,
                                                        gender,
                                                        borrower_contact_no,
                                                        email,
                                                        borrower_address)
                                        VALUE ('" & Txt_borrower_id_number.Text.Trim & "',
                                                '" & Txt_borrower_last_name.Text.Trim & "',
                                                '" & Txt_borrower_first_name.Text.Trim & "',
                                                '" & Txt_borrower_middle_name.Text.Trim & "',
                                                '" & Cb_borrower_category_type.Text & "',
                                                '" & Gender & "',
                                                '" & Txt_borrower_contact_no.Text.Trim & "',
                                                '" & Txt_borrower_email.Text.Trim & "',
                                                '" & Txt_borrower_address.Text.Trim & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        MessageBox.Show(Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Load_borrower_info_data_table(Fm_home_page.Txt_student_info_search.Text)

                        SendBorrowerEmail(
                        Txt_borrower_id_number.Text.Trim,
                        Txt_borrower_first_name.Text.Trim,
                        Txt_borrower_last_name.Text.Trim,
                        Txt_borrower_email.Text.Trim,
                        Pb_id_no_barcode.Image)

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

        Clear_error_msg()

        If Txt_borrower_id_number.Text = "" Or
            Txt_borrower_last_name.Text = "" Or
            Txt_borrower_first_name.Text = "" Or
            Txt_borrower_middle_name.Text = "" Or
            Cb_borrower_category_type.Text = "" Or
            Gender = "" Or
            Txt_borrower_contact_no.Text = "" Or
            Txt_borrower_email.Text = "" Or
            Txt_borrower_address.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_borrower_id_number, Txt_borrower_last_name, Txt_borrower_first_name, Txt_borrower_middle_name, Txt_borrower_contact_no, Txt_borrower_email, Txt_borrower_address}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_6, Lbl_error_msg_7, Lbl_error_msg_8}

            ' Validate TextBoxes
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

            ' Validate the ComboBox (Dropdown)
            If Cb_borrower_category_type.SelectedIndex = -1 Then
                Lbl_error_msg_4.Text = "This field is required"
            End If

            ' Validate the RadioButtons (Check if at least one is selected)
            If Not (Rb_male.Checked Or Rb_female.Checked) Then
                Lbl_error_msg_5.Text = "Please select a gender"
            End If

        Else

            Try

                Dim primary_borrower_id As String = Fm_home_page.Lv_borrower_info.SelectedItems(0).SubItems(9).Text

                con.Open()

                ' Check ID Number and Email address if exists
                sql = "SELECT COUNT(*) FROM tbl_borrower
                                WHERE TRIM(borrower_id) = '" & Txt_borrower_id_number.Text.Trim & "' AND primary_borrower_id <> '" & primary_borrower_id & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_borrower_id_Count As Integer = cmd.ExecuteScalar()

                sql = "SELECT COUNT(*) FROM tbl_borrower
                                WHERE TRIM(email) = '" & Txt_borrower_email.Text.Trim & "' AND primary_borrower_id <> '" & primary_borrower_id & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_borrower_email_Count As Integer = cmd.ExecuteScalar()

                ' Display error messages if any
                Lbl_error_msg.Text = If(duplicate_borrower_id_Count > 0, "ID Number already exists", "")
                Lbl_error_msg_7.Text = If(duplicate_borrower_email_Count > 0, "Email address already exists", "")

                If duplicate_borrower_id_Count = 0 AndAlso duplicate_borrower_email_Count = 0 Then

                    Dim dialog As DialogResult

                    dialog = MessageBox.Show("Do you want to update " + Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If dialog = DialogResult.Yes Then

                        'issued_to_last_name = '" & Txt_last_name.Text + ", " + Txt_first_name.Text & "' - /* concatenate of 2 inputs and save to mysql database table into 1 column */

                        sql = "UPDATE tbl_borrower SET
                                            borrower_id = '" & Txt_borrower_id_number.Text.Trim & "',
                                            last_name = '" & Txt_borrower_last_name.Text.Trim & "',
                                            first_name = '" & Txt_borrower_first_name.Text.Trim & "',
                                            middle_name = '" & Txt_borrower_middle_name.Text.Trim & "',
                                            category_type = '" & Cb_borrower_category_type.Text & "',
                                            gender = '" & Gender & "',
                                            borrower_contact_no = '" & Txt_borrower_contact_no.Text.Trim & "',
                                            email = '" & Txt_borrower_email.Text.Trim & "',
                                            borrower_address = '" & Txt_borrower_address.Text.Trim & "'
                                   WHERE primary_borrower_id = '" & primary_borrower_id & "'"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        MessageBox.Show(Txt_borrower_first_name.Text.Trim + " " + Txt_borrower_last_name.Text.Trim + " was updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim borrower_id As String = Fm_home_page.Lv_borrower_info.SelectedItems(0).Text

                        If borrower_id <> Txt_borrower_id_number.Text.Trim Then

                            SendBorrowerEmail(
                            Txt_borrower_id_number.Text.Trim,
                            Txt_borrower_first_name.Text.Trim,
                            Txt_borrower_last_name.Text.Trim,
                            Txt_borrower_email.Text.Trim,
                            Pb_id_no_barcode.Image)

                        End If

                        Load_borrower_info_data_table(Fm_home_page.Txt_student_info_search.Text)
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

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Load_borrower_info_data_table(Fm_home_page.Txt_student_info_search.Text)
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

    Private Sub Txt_borrower_id_number_TextChanged(sender As Object, e As EventArgs) Handles Txt_borrower_id_number.TextChanged

        If Txt_borrower_id_number.Text = "" Then

            Pb_id_no_barcode.Image = Nothing

        Else

            generate_barcode()

        End If

    End Sub

    Private Sub Txt_borrower_id_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_id_number.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_id_number.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789-" ' Change this to the desired allowed characters

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

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_last_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

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

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_first_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

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

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_middle_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Cb_borrower_category_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_borrower_category_type.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_borrower_category_type_Click(sender As Object, e As EventArgs) Handles Cb_borrower_category_type.Click

        Cb_borrower_category_type.DroppedDown = True

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

    Private Sub Txt_borrower_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_email.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_email.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+<>,.?/""" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_borrower_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_borrower_address.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 200 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_borrower_address.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class