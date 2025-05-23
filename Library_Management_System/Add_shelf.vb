﻿Imports MySql.Data.MySqlClient

Public Class Fm_add_shelf

    Private Sub Fm_add_shelf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Clear_error_msg()

        If Txt_shelf_id.Text = "" Or
            Txt_shelf_name.Text = "" Or
            Txt_shelf_section.Text = "" Or
            Txt_shelf_floor_number.Text = "" Or
            Txt_shelf_capacity.Text = "" Or
            Txt_shelf_current_load.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_shelf_id, Txt_shelf_name, Txt_shelf_section, Txt_shelf_floor_number, Txt_shelf_capacity, Txt_shelf_current_load}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_4, Lbl_error_msg_5}

            ' Loop through each TextBox and validate
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

        Else

            Try

                con.Open()

                sql = "SELECT COUNT(*) FROM tbl_shelf
                                WHERE TRIM(shelf_id) = '" & Txt_shelf_id.Text.Trim & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_Count As Integer = cmd.ExecuteScalar()

                If duplicate_Count > 0 Then

                    Lbl_error_msg.Text = "Shelf ID already exists"

                Else

                    sql = "INSERT INTO tbl_shelf   (shelf_id,
                                                    shelf_name,
                                                    section,
                                                    floor_number,
                                                    capacity,
                                                    current_load,
                                                    created_at)
                                    VALUE ('" & Txt_shelf_id.Text.Trim & "',
                                            '" & Txt_shelf_name.Text.Trim & "',
                                            '" & Txt_shelf_section.Text.Trim & "',
                                            '" & Txt_shelf_floor_number.Text.Trim & "',
                                            '" & Txt_shelf_capacity.Text.Trim & "',
                                            '" & Txt_shelf_current_load.Text.Trim & "',
                                            '" & Date.Now.ToString("MMMM dd, yyyy") & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Shelf added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_shelf_data_table(Fm_home_page.Txt_search_shelf.Text)
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

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Clear_error_msg()

        If Txt_shelf_id.Text = "" Or
            Txt_shelf_name.Text = "" Or
            Txt_shelf_section.Text = "" Or
            Txt_shelf_floor_number.Text = "" Or
            Txt_shelf_capacity.Text = "" Or
            Txt_shelf_current_load.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_shelf_id, Txt_shelf_name, Txt_shelf_section, Txt_shelf_floor_number, Txt_shelf_capacity, Txt_shelf_current_load}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_4, Lbl_error_msg_5}

            ' Loop through each TextBox and validate
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

        Else

            Try

                con.Open()

                Dim primary_shelf_id As String = Fm_home_page.Lv_shelf.SelectedItems(0).SubItems(8).Text

                sql = "SELECT COUNT(*) FROM tbl_shelf
                                WHERE TRIM(shelf_id) = '" & Txt_shelf_id.Text.Trim & "' AND primary_shelf_id <> '" & primary_shelf_id & "'"
                cmd = New MySqlCommand(sql, con)

                Dim duplicate_Count As Integer = cmd.ExecuteScalar()

                If duplicate_Count > 0 Then

                    Lbl_error_msg.Text = "Shelf ID already exists"

                Else

                    sql = "UPDATE tbl_shelf SET 
                                    shelf_id = '" & Txt_shelf_id.Text.Trim & "',
                                    shelf_name = '" & Txt_shelf_name.Text.Trim & "',
                                    section = '" & Txt_shelf_section.Text.Trim & "',
                                    floor_number = '" & Txt_shelf_floor_number.Text.Trim & "',
                                    capacity = '" & Txt_shelf_capacity.Text.Trim & "',
                                    current_load = '" & Txt_shelf_current_load.Text.Trim & "',
                                    updated_at = '" & Date.Now.ToString("MMMM dd, yyyy") & "'                                    
                            WHERE primary_shelf_id = '" & primary_shelf_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Shelf updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_shelf_data_table(Fm_home_page.Txt_search_shelf.Text)
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

        Fm_home_page.Enabled = True
        Load_shelf_data_table(Fm_home_page.Txt_search_shelf.Text) '-> To item selection On the listview
        Me.Close()

    End Sub

    Private Sub Txt_shelf_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_shelf_id.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_shelf_id.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890-" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_shelf_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_shelf_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_shelf_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_shelf_section_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_shelf_section.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_shelf_section.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_shelf_floor_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_shelf_floor_number.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 10 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_shelf_floor_number.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_shelf_capacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_shelf_capacity.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 10 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_shelf_capacity.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Txt_shelf_current_load_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_shelf_current_load.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 10 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_shelf_current_load.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

End Class