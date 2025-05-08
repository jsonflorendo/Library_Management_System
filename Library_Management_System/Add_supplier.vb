Imports MySql.Data.MySqlClient

Public Class Fm_supplier_maintenance

    Private Sub Fm_supplier_maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Clear_error_msg()

        If Txt_supplier_id.Text = "" Or
           Txt_supplier_name.Text = "" Or
           Txt_supplier_firstname.Text = "" Or
           Txt_supplier_lastname.Text = "" Or
           Txt_supplier_email_address.Text = "" Or
           Txt_supplier_contact.Text = "" Or
           Txt_supplier_address.Text = "" Or
           Cb_supplier_source_type.Text = "--Select Source Type--" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_supplier_id, Txt_supplier_name, Txt_supplier_firstname, Txt_supplier_lastname, Txt_supplier_email_address, Txt_supplier_contact, Txt_supplier_address}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_4, Lbl_error_msg_5, Lbl_error_msg_6}

            ' Loop through each TextBox and validate
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

            ' Validate the ComboBox (Dropdown)
            If Cb_supplier_source_type.SelectedIndex = -1 Then
                Lbl_error_msg_7.Text = "This field is required"
            End If

        Else

            Try

                con.Open()

                sql = "SELECT COUNT(*) FROM tbl_library_supplier
                                WHERE TRIM(supplier_id) = '" & Txt_supplier_id.Text.Trim & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_Count As Integer = cmd.ExecuteScalar()

                If duplicate_Count > 0 Then

                    Lbl_error_msg.Text = "Supplier already exists"

                Else

                    sql = "INSERT INTO tbl_library_supplier (supplier_id,
                                                            supplier_name,
                                                            last_name,
                                                            first_name,
                                                            email_address,
                                                            contact,
                                                            address,
                                                            source_type)
                                    VALUE ('" & Txt_supplier_id.Text.Trim & "',
                                            '" & Txt_supplier_name.Text.Trim & "',
                                            '" & Txt_supplier_lastname.Text.Trim & "',
                                            '" & Txt_supplier_firstname.Text.Trim & "',
                                            '" & Txt_supplier_email_address.Text.Trim & "',
                                            '" & Txt_supplier_contact.Text.Trim & "',
                                            '" & Txt_supplier_address.Text.Trim & "',
                                            '" & Cb_supplier_source_type.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Supplier added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If Fm_home_page.Enabled = False And Fm_add_delivery.Enabled = False Then

                        Load_library_cb_purchase_supplier()
                        Load_library_cb_donate_supplier()
                        Fm_add_delivery.Enabled = True

                        If Fm_add_delivery.Panel_purchase.Visible = True Then
                            Fm_add_delivery.Cb_purchase_supplier.Text = Txt_supplier_name.Text
                        Else
                            Fm_add_delivery.Cb_donate_supplier.Text = Txt_supplier_name.Text
                        End If

                    Else

                        Load_library_supplier_data_table(Fm_home_page.Txt_search_supplier.Text)
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

        Clear_error_msg()

        If Txt_supplier_id.Text = "" Or
            Txt_supplier_name.Text = "" Or
            Txt_supplier_firstname.Text = "" Or
            Txt_supplier_lastname.Text = "" Or
            Txt_supplier_email_address.Text = "" Or
            Txt_supplier_contact.Text = "" Or
            Txt_supplier_address.Text = "" Or
            Cb_supplier_source_type.Text = "--Select Source Type--" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_supplier_id, Txt_supplier_name, Txt_supplier_firstname, Txt_supplier_lastname, Txt_supplier_email_address, Txt_supplier_contact, Txt_supplier_address}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_4, Lbl_error_msg_5, Lbl_error_msg_6}

            ' Loop through each TextBox and validate
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

            ' Validate the ComboBox (Dropdown)
            If Cb_supplier_source_type.SelectedIndex = -1 Then
                Lbl_error_msg_7.Text = "This field is required"
            End If

        Else

            Try

                con.Open()

                Dim primary_supplier_id As String = Fm_home_page.Lv_supplier.SelectedItems(0).SubItems(7).Text

                sql = "SELECT COUNT(*) FROM tbl_library_supplier
                                WHERE TRIM(supplier_id) = '" & Txt_supplier_id.Text.Trim & "' AND primary_supplier_id <> '" & primary_supplier_id & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_Count As Integer = cmd.ExecuteScalar()

                If duplicate_Count > 0 Then

                    Lbl_error_msg.Text = "Supplier already exists"

                Else

                    sql = "UPDATE tbl_library_supplier SET 
                                    supplier_id = '" & Txt_supplier_id.Text.Trim & "',
                                    supplier_name = '" & Txt_supplier_name.Text.Trim & "',
                                    last_name = '" & Txt_supplier_lastname.Text.Trim & "',
                                    first_name = '" & Txt_supplier_firstname.Text.Trim & "',
                                    email_address = '" & Txt_supplier_email_address.Text.Trim & "',
                                    contact = '" & Txt_supplier_contact.Text.Trim & "',
                                    address = '" & Txt_supplier_address.Text.Trim & "',
                                    source_type = '" & Cb_supplier_source_type.Text & "'
                            WHERE primary_supplier_id = '" & primary_supplier_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Supplier updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_supplier_data_table(Fm_home_page.Txt_search_supplier.Text)
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

        If Fm_home_page.Enabled = False And Fm_add_delivery.Enabled = False Then

            Fm_add_delivery.Enabled = True

        Else

            Fm_home_page.Enabled = True
            Load_library_supplier_data_table(Fm_home_page.Txt_search_supplier.Text) '-> To item selection On the listview

        End If

        Me.Close()

    End Sub

    Private Sub Cb_supplier_source_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_supplier_source_type.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_supplier_source_type_Click(sender As Object, e As EventArgs) Handles Cb_supplier_source_type.Click

        Cb_supplier_source_type.DroppedDown = True

    End Sub

    Private Sub Txt_supplier_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_id.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_id.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789-" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_supplier_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_name.TextLength >= maxLength Then
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

    Private Sub Txt_supplier_firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_firstname.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_firstname.TextLength >= maxLength Then
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

    Private Sub Txt_supplier_lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_lastname.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_lastname.TextLength >= maxLength Then
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

    Private Sub Txt_supplier_email_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_email_address.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_email_address.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+<>,.?/""" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_supplier_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_contact.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_contact.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Txt_supplier_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_address.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 200 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_address.TextLength >= maxLength Then
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