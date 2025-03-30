Imports System.ComponentModel
Imports System.Diagnostics.Eventing
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Fm_add_books

    Private Sub Fm_add_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_library_cb_supplier()
        Load_library_cb_author()
        Load_library_cb_category()
        Load_library_cb_publisher()

        Clear_error_msg()

        Dtp_acquisition_date.Format = DateTimePickerFormat.Custom
        Dtp_acquisition_date.CustomFormat = "MMMM dd, yyyy"

        Dtp_publish_date.Format = DateTimePickerFormat.Custom
        Dtp_publish_date.CustomFormat = "MMMM dd, yyyy"

        Dim tooltip_add_category As New ToolTip()
        tooltip_add_category.SetToolTip(Btn_add_category, "Add Category")

        Dim tooltip_add_author As New ToolTip()
        tooltip_add_author.SetToolTip(Btn_add_author, "Add Author")

        Dim tooltip_add_publisher As New ToolTip()
        tooltip_add_publisher.SetToolTip(Btn_add_publisher, "Add Publisher")

        Dim tooltip_add_supplier As New ToolTip()
        tooltip_add_supplier.SetToolTip(Btn_add_supplier, "Add Supplier")

    End Sub

    Private Sub Cb_book_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_book_category.SelectedIndexChanged

        Try

            'If Cb_book_category.Text = "-Select Category-" Then

            '    Load_library_category_data_table()

            'Else

            con.Open()

            sql = "SELECT * FROM tbl_library_category
                            WHERE category_name = '" & Cb_book_category.Text & "'"
            'GROUP BY author_name"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            'Cb_book_category.Items.Clear()

            If dr.Read() Then

                Txt_primary_category_id.Text = dr("primary_category_id")

            End If

            con.Close()

            'End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Cb_book_category_TextChanged(sender As Object, e As EventArgs) Handles Cb_book_category.TextChanged

    End Sub

    Private Sub Txt_author_TextChanged(sender As Object, e As EventArgs) Handles Txt_author.TextChanged

        Try

            If Txt_author.Text = "" Then

                Load_library_cb_author()
                Cb_author.Items.Add(Txt_author.Text)
                Txt_primary_author_id.Clear()

            Else

                con.Open()

                sql = "SELECT * FROM tbl_library_author
                                WHERE author_name LIKE '%" & Txt_author.Text & "%'"
                'GROUP BY author_name"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                Cb_author.Items.Clear()

                If dr.Read() Then

                    Cb_author.Items.Add(dr("author_name"))
                    Txt_primary_author_id.Text = dr("primary_author_id")

                Else

                    Cb_author.Items.Add(Txt_author.Text)
                    Txt_primary_author_id.Clear()

                End If

                con.Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Txt_publisher_TextChanged(sender As Object, e As EventArgs) Handles Txt_publisher.TextChanged

        Try

            If Txt_publisher.Text = "" Then

                Load_library_cb_publisher()
                Cb_publisher.Items.Add(Txt_publisher.Text)
                Txt_primary_publisher_id.Clear()

            Else

                con.Open()

                sql = "SELECT * FROM tbl_library_publisher
                                WHERE publisher_name LIKE '%" & Txt_publisher.Text & "%'"
                'GROUP BY publisher_name"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                Cb_publisher.Items.Clear()

                If dr.Read() Then

                    Cb_publisher.Items.Add(dr("publisher_name"))
                    Txt_primary_publisher_id.Text = dr("primary_publisher_id")

                Else

                    Cb_publisher.Items.Add(Txt_publisher.Text)
                    Txt_primary_publisher_id.Clear()

                End If

                con.Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Txt_supplier_name_TextChanged(sender As Object, e As EventArgs) Handles Txt_supplier_name.TextChanged

        Try

            If Txt_supplier_name.Text = "" Then

                Load_library_cb_supplier()
                Cb_supplier_name.Items.Add(Txt_supplier_name.Text)
                Txt_primary_supplier_id.Clear()

            Else

                con.Open()

                sql = "SELECT * FROM tbl_library_supplier
                                WHERE supplier_name LIKE '%" & Txt_supplier_name.Text & "%'"
                'GROUP BY supplier_name"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                Cb_supplier_name.Items.Clear()

                If dr.Read() Then

                    Cb_supplier_name.Items.Add(dr("supplier_name"))
                    Txt_primary_supplier_id.Text = dr("primary_supplier_id")

                Else

                    Cb_supplier_name.Items.Add(Txt_supplier_name.Text)
                    Txt_primary_supplier_id.Clear()

                End If

                con.Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Txt_author_Click(sender As Object, e As EventArgs) Handles Txt_author.Click

        Cb_author.DroppedDown = True

    End Sub

    Private Sub Txt_publisher_Click(sender As Object, e As EventArgs) Handles Txt_publisher.Click

        Cb_publisher.DroppedDown = True

    End Sub

    Private Sub Txt_supplier_name_Click(sender As Object, e As EventArgs) Handles Txt_supplier_name.Click

        Cb_supplier_name.DroppedDown = True

    End Sub

    Private Sub Cb_book_category_Click(sender As Object, e As EventArgs) Handles Cb_book_category.Click

        Cb_book_category.DroppedDown = True

    End Sub

    Private Sub Cb_author_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_author.SelectedIndexChanged

        Txt_author.Text = Cb_author.Text

    End Sub

    Private Sub Cb_publisher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_publisher.SelectedIndexChanged

        Txt_publisher.Text = Cb_publisher.Text

    End Sub

    Private Sub Cb_supplier_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_supplier_name.SelectedIndexChanged

        Txt_supplier_name.Text = Cb_supplier_name.Text

    End Sub

    Private Sub Cb_book_category_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_book_category.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Txt_book_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_book_name.KeyPress

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
        If Txt_book_name.TextLength >= maxLength Then
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

    Private Sub Txt_book_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_book_qty.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 10 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_book_qty.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Txt_author_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_author.KeyPress

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
        If Txt_author.TextLength >= maxLength Then
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

    Private Sub Txt_publisher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_publisher.KeyPress

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
        If Txt_publisher.TextLength >= maxLength Then
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

    Private Sub Txt_supplier_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_name.KeyPress

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
        If Txt_supplier_name.TextLength >= maxLength Then
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

    Private Sub save_Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles save_Txt_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            If Txt_book_name.Text = "" Or
                Cb_book_category.Text = "-Select Category-" Or
                Txt_book_qty.Text = "" Or
                Txt_author.Text = "" Or
                Txt_publisher.Text = "" Or
                Txt_supplier_name.Text = "" Or
                save_Txt_isbn.Text = "" Then

                ' Store TextBoxes and their corresponding Labels
                Dim textBoxes As TextBox() = {Txt_book_name, Txt_book_qty, Txt_author, Txt_publisher, Txt_supplier_name, save_Txt_isbn}
                Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_4, Lbl_error_msg_5, Lbl_error_msg_6}

                ' Loop through each TextBox and validate
                For i As Integer = 0 To textBoxes.Length - 1
                    If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                        labels(i).Text = "This field is required"
                    End If
                Next

                ' Validate the ComboBox (Dropdown)
                If Cb_book_category.SelectedIndex = -1 Then
                    Lbl_error_msg_1.Text = "This field is required"
                End If

            ElseIf Txt_primary_author_id.Text = "" Or Txt_primary_supplier_id.Text = "" Then

                If Txt_primary_author_id.Text = "" Then
                    Lbl_error_msg_3.Text = "Invalid Author Name"
                End If

                If Txt_primary_supplier_id.Text = "" Then
                    Lbl_error_msg_5.Text = "Invalid Supplier Name"
                End If

            Else

                Try

                    con.Open()

                    sql = "INSERT INTO tbl_books (isbn,
                                                    book_name,
                                                    primary_category_id,                                                    
                                                    qty,
                                                    primary_author_id,
                                                    primary_publisher_id,
                                                    publish_year,
                                                    primary_supplier_id,
                                                    acquisition_date,
                                                    status)
                                    VALUE ('" & save_Txt_isbn.Text & "',
                                            '" & Txt_book_name.Text & "',
                                            '" & Txt_primary_category_id.Text & "',                                            
                                            '" & Txt_book_qty.Text & "',
                                            '" & Txt_primary_author_id.Text & "',
                                            '" & Txt_primary_publisher_id.Text & "',
                                            '" & Dtp_publish_date.Value.ToString("MMMM dd, yyyy") & "',
                                            '" & Txt_primary_supplier_id.Text & "',                                            
                                            '" & Dtp_acquisition_date.Value.ToString("MMMM dd, yyyy") & "',
                                            '" & "Available" & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Load_listed_books_data_table()
                    MessageBox.Show(Txt_book_name.Text + " added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Fm_home_page.Enabled = True
                    Me.Close()

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            End If

        End If

    End Sub

    Private Sub update_Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles update_Txt_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            If update_Txt_isbn.Text = "" Or
               Txt_book_name.Text = "" Or
               Cb_book_category.Text = "-Select Category-" Or
               Txt_book_qty.Text = "" Or
               Txt_author.Text = "" Or
               Txt_publisher.Text = "" Or
               Txt_supplier_name.Text = "" Then

                ' Store TextBoxes and their corresponding Labels
                Dim textBoxes As TextBox() = {Txt_book_name, Txt_book_qty, Txt_author, Txt_publisher, Txt_supplier_name, save_Txt_isbn}
                Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_4, Lbl_error_msg_5, Lbl_error_msg_6}

                ' Loop through each TextBox and validate
                For i As Integer = 0 To textBoxes.Length - 1
                    If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                        labels(i).Text = "This field is required"
                    End If
                Next

                ' Validate the ComboBox (Dropdown)
                If Cb_book_category.SelectedIndex = -1 Then
                    Lbl_error_msg_1.Text = "This field is required"
                End If

            ElseIf Txt_primary_author_id.Text = "" Or Txt_primary_supplier_id.Text = "" Then

                If Txt_primary_author_id.Text = "" Then
                    Lbl_error_msg_3.Text = "Invalid Author Name"
                End If

                If Txt_primary_supplier_id.Text = "" Then
                    Lbl_error_msg_5.Text = "Invalid Supplier Name"
                End If

            Else

                Try

                    con.Open()

                    sql = "UPDATE tbl_books SET
                                    isbn = '" & update_Txt_isbn.Text & "',
                                    book_name = '" & Txt_book_name.Text & "',
                                    primary_category_id = '" & Txt_primary_category_id.Text & "',
                                    qty = '" & Txt_book_qty.Text & "',
                                    primary_author_id = '" & Txt_primary_author_id.Text & "',
                                    primary_publisher_id = '" & Txt_primary_publisher_id.Text & "',
                                    publish_year = '" & Dtp_publish_date.Value.ToString("MMMM dd, yyyy") & "',
                                    primary_supplier_id = '" & Txt_primary_supplier_id.Text & "',
                                    acquisition_date = '" & Dtp_acquisition_date.Value.ToString("MMMM dd, yyyy") & "'
                            WHERE primary_book_id = '" & Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    Load_listed_books_data_table()
                    Load_returned_borrowed_books_data_table()
                    Load_penalty_report_data_table()
                    MessageBox.Show(Txt_book_name.Text + " updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Fm_home_page.Enabled = True
                    Me.Close()

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            End If

        End If

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Clear_error_msg()

        If update_Txt_isbn.Text = "" Or
           Txt_book_name.Text = "" Or
           Cb_book_category.Text = "-Select Category-" Or
           Txt_book_qty.Text = "" Or
           Txt_author.Text = "" Or
           Txt_publisher.Text = "" Or
           Txt_supplier_name.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {Txt_book_name, Txt_book_qty, Txt_author, Txt_publisher, Txt_supplier_name, save_Txt_isbn}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_4, Lbl_error_msg_5, Lbl_error_msg_6}

            ' Loop through each TextBox and validate
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

            ' Validate the ComboBox (Dropdown)
            If Cb_book_category.SelectedIndex = -1 Then
                Lbl_error_msg_1.Text = "This field is required"
            End If

        ElseIf Txt_primary_author_id.Text = "" Or Txt_primary_supplier_id.Text = "" Then

            If Txt_primary_author_id.Text = "" Then
                Lbl_error_msg_3.Text = "Invalid Author Name"
            End If

            If Txt_primary_supplier_id.Text = "" Then
                Lbl_error_msg_5.Text = "Invalid Supplier Name"
            End If

        Else

            Try

                con.Open()

                sql = "UPDATE tbl_books SET
                                isbn = '" & update_Txt_isbn.Text & "',
                                book_name = '" & Txt_book_name.Text & "',
                                primary_category_id = '" & Txt_primary_category_id.Text & "',
                                qty = '" & Txt_book_qty.Text & "',
                                primary_author_id = '" & Txt_primary_author_id.Text & "',
                                primary_publisher_id = '" & Txt_primary_publisher_id.Text & "',
                                publish_year = '" & Dtp_publish_date.Value.ToString("MMMM dd, yyyy") & "',
                                primary_supplier_id = '" & Txt_primary_supplier_id.Text & "',
                                acquisition_date = '" & Dtp_acquisition_date.Value.ToString("MMMM dd, yyyy") & "'
                        WHERE primary_book_id = '" & Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                con.Close()

                Load_listed_books_data_table()

                Load_returned_borrowed_books_data_table()
                Load_penalty_report_data_table()
                MessageBox.Show(Txt_book_name.Text + " updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Fm_home_page.Enabled = True
                Me.Close()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Btn_add_category_Click(sender As Object, e As EventArgs) Handles Btn_add_category.Click

        Fm_add_category.Show()
        Fm_add_category.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_add_author_Click(sender As Object, e As EventArgs) Handles Btn_add_author.Click

        Fm_add_author.Show()
        Fm_add_author.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_add_publisher_Click(sender As Object, e As EventArgs) Handles Btn_add_publisher.Click

        Fm_publisher.Show()
        Fm_publisher.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_add_supplier_Click(sender As Object, e As EventArgs) Handles Btn_add_supplier.Click

        Fm_supplier_maintenance.Show()
        Fm_supplier_maintenance.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click

        Load_listed_books_data_table()
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

End Class