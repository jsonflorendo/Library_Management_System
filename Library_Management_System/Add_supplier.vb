Imports MySql.Data.MySqlClient

Public Class Fm_supplier_maintenance

    Private Sub Fm_supplier_maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        If Fm_home_page.Enabled = False And Fm_add_books.Enabled = False Then

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

                    sql = "SELECT * FROM tbl_library_supplier
                                WHERE supplier_id = '" & Txt_supplier_id.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        con.Close()

                        Lbl_error_msg.Text = "Supplier already exists"

                    Else

                        dr.Close()

                        sql = "INSERT INTO tbl_library_supplier (supplier_id,
                                                            supplier_name,
                                                            last_name,
                                                            first_name,
                                                            email_address,
                                                            contact,
                                                            address,
                                                            source_type)
                                    VALUE ('" & Txt_supplier_id.Text & "',
                                            '" & Txt_supplier_name.Text & "',
                                            '" & Txt_supplier_lastname.Text & "',
                                            '" & Txt_supplier_firstname.Text & "',
                                            '" & Txt_supplier_email_address.Text & "',
                                            '" & Txt_supplier_contact.Text & "',
                                            '" & Txt_supplier_address.Text & "',
                                            '" & Cb_supplier_source_type.Text & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        MessageBox.Show("Supplier added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Load_library_supplier_data_table()
                        Load_library_cb_supplier()
                        Fm_add_books.Enabled = True
                        Fm_add_books.Txt_supplier_name.Text = Txt_supplier_name.Text
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

        Else

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

                    sql = "SELECT * FROM tbl_library_supplier
                                WHERE supplier_id = '" & Txt_supplier_id.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        con.Close()

                        Lbl_error_msg.Text = "Supplier already exists"

                    Else

                        dr.Close()

                        sql = "INSERT INTO tbl_library_supplier (supplier_id,
                                                            supplier_name,
                                                            last_name,
                                                            first_name,
                                                            email_address,
                                                            contact,
                                                            address,
                                                            source_type)
                                    VALUE ('" & Txt_supplier_id.Text & "',
                                            '" & Txt_supplier_name.Text & "',
                                            '" & Txt_supplier_lastname.Text & "',
                                            '" & Txt_supplier_firstname.Text & "',
                                            '" & Txt_supplier_email_address.Text & "',
                                            '" & Txt_supplier_contact.Text & "',
                                            '" & Txt_supplier_address.Text & "',
                                            '" & Cb_supplier_source_type.Text & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        MessageBox.Show("Supplier added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Load_library_supplier_data_table()
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

                'to make sure Supplier ID not exists while in update process
                sql = "UPDATE tbl_library_supplier SET 
                                    supplier_id = '" & "" & "'                                        
                        WHERE primary_supplier_id = '" & Fm_home_page.Lv_supplier.SelectedItems(0).SubItems(7).Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                dr.Close()
                '---------------------------------

                sql = "SELECT * FROM tbl_library_supplier
                                WHERE supplier_id = '" & Txt_supplier_id.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    dr.Close()

                    Lbl_error_msg.Text = "Supplier already exists"

                    'returned previous Supplier ID
                    sql = "UPDATE tbl_library_supplier SET 
                                    supplier_id = '" & Fm_home_page.Lv_supplier.SelectedItems(0).Text & "'                                        
                            WHERE primary_supplier_id = '" & Fm_home_page.Lv_supplier.SelectedItems(0).SubItems(7).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    con.Close()
                    '---------------------------------

                Else

                    dr.Close()

                    sql = "UPDATE tbl_library_supplier SET 
                                    supplier_id = '" & Txt_supplier_id.Text & "',
                                    supplier_name = '" & Txt_supplier_name.Text & "',
                                    last_name = '" & Txt_supplier_lastname.Text & "',
                                    first_name = '" & Txt_supplier_firstname.Text & "',
                                    email_address = '" & Txt_supplier_email_address.Text & "',
                                    contact = '" & Txt_supplier_contact.Text & "',
                                    address = '" & Txt_supplier_address.Text & "',
                                    source_type = '" & Cb_supplier_source_type.Text & "'
                            WHERE primary_supplier_id = '" & Fm_home_page.Lv_supplier.SelectedItems(0).SubItems(7).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show("Supplier updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_supplier_data_table()
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
            Load_library_supplier_data_table() '-> To item selection On the listview
            Me.Close()

        End If

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

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_id.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789- " ' Change this to the desired allowed characters

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

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

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

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_firstname.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

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

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_lastname.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

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
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+'<>,.?/""" ' Change this to the desired allowed characters

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

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength = 200 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_address.TextLength >= maxLength Then
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