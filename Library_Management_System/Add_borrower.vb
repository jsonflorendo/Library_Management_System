Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class Fm_add_borrower

    ' Mapping Code 39 characters to barcode patterns
    Dim code39Table As New Dictionary(Of Char, String) From {
        {"0"c, "101001101101"}, {"1"c, "110100101011"}, {"2"c, "101100101011"},
        {"3"c, "110110010101"}, {"4"c, "101001101011"}, {"5"c, "110100110101"},
        {"6"c, "101100110101"}, {"7"c, "101001011011"}, {"8"c, "110100101101"},
        {"9"c, "101100101101"}, {"A"c, "110101001011"}, {"B"c, "101101001011"},
        {"C"c, "110110100101"}, {"D"c, "101011001011"}, {"E"c, "110101100101"},
        {"F"c, "101101100101"}, {"G"c, "101010011011"}, {"H"c, "110101001101"},
        {"I"c, "101101001101"}, {"J"c, "101011001101"}, {"K"c, "110101010011"},
        {"L"c, "101101010011"}, {"M"c, "110110101001"}, {"N"c, "101011010011"},
        {"O"c, "110101101001"}, {"P"c, "101101101001"}, {"Q"c, "101010110011"},
        {"R"c, "110101011001"}, {"S"c, "101101011001"}, {"T"c, "101011011001"},
        {"U"c, "110010101011"}, {"V"c, "100110101011"}, {"W"c, "110011010101"},
        {"X"c, "100101101011"}, {"Y"c, "110010110101"}, {"Z"c, "100110110101"},
        {"-"c, "100101011011"}, {"."c, "110010101101"}, {" "c, "100110101101"},
        {"$"c, "100100100101"}, {"/"c, "100100101001"}, {"+"c, "100101001001"},
        {"%"c, "101001001001"}, {"*"c, "100101101101"} ' * is the start/stop character
    }

    Public Sub generate_barcode()

        Dim borrower_id_number As String = Txt_borrower_id_number.Text.ToUpper()
        Dim encoded As String = "*" & borrower_id_number & "*"

        Dim pattern As String = ""
        For Each ch As Char In encoded
            If code39Table.ContainsKey(ch) Then
                pattern &= code39Table(ch) & "0" ' add narrow space between characters
            End If
        Next

        ' Draw barcode
        Dim widthPerBar As Integer = 2
        Dim height As Integer = 100
        Dim totalWidth As Integer = pattern.Length * widthPerBar
        Dim bmp As New Bitmap(totalWidth, height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
            Dim x As Integer = 0
            For Each bit As Char In pattern
                Dim brush As Brush = If(bit = "1"c, Brushes.Black, Brushes.White)
                g.FillRectangle(brush, x, 0, widthPerBar, height)
                x += widthPerBar
            Next
        End Using

        Pb_id_no_barcode.Image = bmp

    End Sub

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

        Gender = "MALE"

    End Sub

    Private Sub Rb_female_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_female.CheckedChanged

        Gender = "FEMALE"

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

                sql = "SELECT * FROM tbl_borrower
                                WHERE borrower_id = '" & Txt_borrower_id_number.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    dr.Close()

                    Lbl_error_msg.Text = "ID Number already exists"

                Else

                    dr.Close()

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
                                        VALUE ('" & Txt_borrower_id_number.Text & "',
                                                '" & Txt_borrower_last_name.Text & "',
                                                '" & Txt_borrower_first_name.Text & "',
                                                '" & Txt_borrower_middle_name.Text & "',
                                                '" & Cb_borrower_category_type.Text & "',
                                                '" & Gender & "',
                                                '" & Txt_borrower_contact_no.Text & "',
                                                '" & Txt_borrower_email.Text & "',
                                                '" & Txt_borrower_address.Text & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        MessageBox.Show(Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Load_borrower_info_data_table(Fm_home_page.Txt_student_info_search.Text)

                        SendBorrowerEmail(
                            Txt_borrower_id_number.Text,
                            Txt_borrower_first_name.Text,
                            Txt_borrower_last_name.Text,
                            Txt_borrower_email.Text,
                            Pb_id_no_barcode.Image)

                        Fm_home_page.Enabled = True
                        Me.Close()

                    Else

                        con.Close()

                    End If

                    con.Close()

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

                con.Open()

                'to make sure ID Number not exists while in update process
                sql = "UPDATE tbl_borrower SET
                                        borrower_id = '" & "" & "'                                        
                               WHERE primary_borrower_id = '" & Fm_home_page.Lv_borrower_info.SelectedItems(0).SubItems(9).Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                dr.Close()
                '---------------------------------

                sql = "SELECT * FROM tbl_borrower
                                WHERE borrower_id = '" & Txt_borrower_id_number.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    dr.Close()

                    Lbl_error_msg.Text = "ID Number already exists"

                    'returned previous ID Number
                    con.Close()
                    con.Open()
                    sql = "UPDATE tbl_borrower SET
                                    borrower_id = '" & Fm_home_page.Lv_borrower_info.SelectedItems(0).Text & "'                                        
                            WHERE primary_borrower_id = '" & Fm_home_page.Lv_borrower_info.SelectedItems(0).SubItems(9).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    con.Close()
                    '---------------------------------

                Else

                    Dim id_numnber As String = Fm_home_page.Lv_borrower_info.SelectedItems(0).Text
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
                                        category_type = '" & Cb_borrower_category_type.Text & "',
                                        gender = '" & Gender & "',
                                        borrower_contact_no = '" & Txt_borrower_contact_no.Text & "',
                                        email = '" & Txt_borrower_email.Text & "',
                                        borrower_address = '" & Txt_borrower_address.Text & "'
                               WHERE primary_borrower_id = '" & Fm_home_page.Lv_borrower_info.SelectedItems(0).SubItems(9).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        con.Close()

                        MessageBox.Show(Txt_borrower_first_name.Text + " " + Txt_borrower_last_name.Text + " was updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Load_borrower_info_data_table(Fm_home_page.Txt_student_info_search.Text)

                        If id_numnber <> Txt_borrower_id_number.Text Then

                            SendBorrowerEmail(
                            Txt_borrower_id_number.Text,
                            Txt_borrower_first_name.Text,
                            Txt_borrower_last_name.Text,
                            Txt_borrower_email.Text,
                            Pb_id_no_barcode.Image)

                        End If

                        Fm_home_page.Enabled = True
                        Me.Close()

                    Else

                        con.Close()

                    End If

                    con.Close()

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

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click

        Load_borrower_info_data_table(Fm_home_page.Txt_student_info_search.Text)
        Fm_home_page.Enabled = True
        Me.Close()

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
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789- " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If


        If Txt_borrower_id_number.Text = "" Then

            Pb_id_no_barcode.Image = Nothing

        Else

            generate_barcode()

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
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

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
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

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
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

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
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+'<>,.?/""" ' Change this to the desired allowed characters

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
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class