Imports System.ComponentModel
Imports System.Diagnostics.Eventing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Fm_add_books

    Private Sub Fm_add_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_library_cb_category()
        Load_library_cb_author()
        Load_library_cb_publisher()
        Load_library_cb_supplier()

        Dtp_acquisition_date.Format = DateTimePickerFormat.Custom
        Dtp_acquisition_date.CustomFormat = "MMMM dd, yyyy"

        Dtp_publish_date.Format = DateTimePickerFormat.Custom
        Dtp_publish_date.CustomFormat = "MMMM dd, yyyy"

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
                                WHERE supplier_full_name LIKE '%" & Txt_supplier_name.Text & "%'"
                'GROUP BY supplier_name"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                Cb_supplier_name.Items.Clear()

                If dr.Read() Then

                    Cb_supplier_name.Items.Add(dr("supplier_full_name"))
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

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_author.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz-,. " ' Change this to the desired allowed characters

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

    Private Sub Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_isbn.KeyPress

        If e.KeyChar = ChrW(13) Then

            Try

                If Txt_book_name.Text = "" Or
                    Cb_book_category.Text = "-Select Category-" Or
                    Txt_book_qty.Text = "" Or
                    Txt_author.Text = "" Or
                    Txt_publisher.Text = "" Or
                    Txt_supplier_name.Text = "" Or
                    Txt_isbn.Text = "" Then

                    MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Open()

                    sql = "SELECT * FROM tbl_library_author
                                WHERE author_name = '" & Txt_author.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        dr.Close()

                        sql = "SELECT * FROM tbl_library_supplier
                                WHERE supplier_full_name = '" & Txt_supplier_name.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader()

                        If dr.Read Then

                            dr.Close()

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
                                        VALUE ('" & Txt_isbn.Text & "',
                                                '" & Txt_book_name.Text & "',
                                                '" & Txt_primary_category_id.Text & "',                                            
                                                '" & Txt_book_qty.Text & "',
                                                '" & Txt_primary_author_id.Text & "',
                                                '" & "NULL" & "',
                                                '" & Dtp_publish_date.Value.ToString("MMMM dd, yyyy") & "',
                                                '" & Txt_primary_supplier_id.Text & "',                                            
                                                '" & Dtp_acquisition_date.Value.ToString("MMMM dd, yyyy") & "',
                                                '" & "Available" & "')"
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()



                            sql = "SELECT * FROM tbl_library_publisher
                                    WHERE publisher_name = '" & Txt_publisher.Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader()

                            If dr.Read Then

                                dr.Close()

                            Else

                                dr.Close()

                                sql = "INSERT INTO tbl_library_publisher (publisher_name)
                                              VALUE ('" & Txt_publisher.Text & "')"
                                cmd = New MySqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                            End If


                            sql = "SELECT * FROM tbl_library_publisher
                                   WHERE publisher_name = '" & Txt_publisher.Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader()

                            If dr.Read Then

                                Dim publisher_id As String = dr("primary_publisher_id")
                                dr.Close()

                                sql = "UPDATE tbl_books SET 
                                              primary_publisher_id = '" & publisher_id & "'
                                       WHERE primary_publisher_id = '" & "NULL" & "'"
                                cmd = New MySqlCommand(sql, con)
                                dr = cmd.ExecuteReader

                                dr.Close()

                            Else

                                dr.Close()

                            End If



                            con.Close()

                            Load_listed_books_data_table()
                            MessageBox.Show(Txt_book_name.Text + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Fm_home_page.Enabled = True
                            Me.Close()

                        Else

                            dr.Close()

                            MessageBox.Show("Invalid Supplier Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Txt_isbn.Clear()

                        End If

                    Else

                        dr.Close()

                        MessageBox.Show("Invalid Author Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Txt_isbn.Clear()

                    End If

                    con.Close()

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        Else

            con.Close()

        End If

    End Sub

    Private Sub update_Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles update_Txt_isbn.KeyPress

        If e.KeyChar = ChrW(13) Then

            Try

                If update_Txt_isbn.Text = "" Or
                   Txt_book_name.Text = "" Or
                   Cb_book_category.Text = "-Select Category-" Or
                   Txt_book_qty.Text = "" Or
                   Txt_author.Text = "" Or
                   Txt_publisher.Text = "" Or
                   Txt_supplier_name.Text = "" Then

                    MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Open()

                    sql = "SELECT * FROM tbl_library_author
                                    WHERE author_name = '" & Txt_author.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        dr.Close()

                        sql = "SELECT * FROM tbl_library_supplier
                                        WHERE supplier_full_name = '" & Txt_supplier_name.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader()

                        If dr.Read Then

                            dr.Close()

                            sql = "UPDATE tbl_books SET
                                            isbn = '" & update_Txt_isbn.Text & "',
                                            book_name = '" & Txt_book_name.Text & "',
                                            qty = '" & Txt_book_qty.Text & "',
                                            primary_author_id = '" & Txt_primary_author_id.Text & "',                                            
                                            publish_year = '" & Dtp_publish_date.Value.ToString("MMMM dd, yyyy") & "',
                                            primary_supplier_id = '" & Txt_primary_supplier_id.Text & "',                                            
                                            acquisition_date = '" & Dtp_acquisition_date.Value.ToString("MMMM dd, yyyy") & "'
                                    WHERE primary_book_id = '" & Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                            dr.Close()

                            If Txt_primary_category_id.Text = "" Then

                            Else

                                sql = "UPDATE tbl_books SET
                                              primary_category_id = '" & Txt_primary_category_id.Text & "'                                                
                                       WHERE primary_book_id = '" & Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                                cmd = New MySqlCommand(sql, con)
                                dr = cmd.ExecuteReader

                                dr.Close()

                            End If



                            sql = "SELECT * FROM tbl_library_publisher
                                            WHERE publisher_name = '" & Txt_publisher.Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader()

                            If dr.Read Then

                                dr.Close()

                            Else

                                dr.Close()

                                sql = "INSERT INTO tbl_library_publisher (publisher_name)
                                              VALUE ('" & Txt_publisher.Text & "')"
                                cmd = New MySqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                            End If



                            sql = "SELECT * FROM tbl_library_publisher
                                            WHERE publisher_name = '" & Txt_publisher.Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader()

                            If dr.Read Then

                                Dim publisher_id As String = dr("primary_publisher_id")
                                dr.Close()

                                sql = "UPDATE tbl_books SET 
                                              primary_publisher_id = '" & publisher_id & "'
                                       WHERE primary_book_id = '" & Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                                cmd = New MySqlCommand(sql, con)
                                dr = cmd.ExecuteReader

                                dr.Close()

                            Else

                                dr.Close()

                            End If



                            con.Close()

                            Load_listed_books_data_table()
                            Load_returned_borrowed_books_data_table()
                            Load_penalty_data_table()
                            MessageBox.Show(Txt_book_name.Text + " was updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Fm_home_page.Enabled = True
                            Me.Close()

                        Else

                            dr.Close()

                            MessageBox.Show("Invalid Supplier Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If

                    Else

                        dr.Close()

                        MessageBox.Show("Invalid Author Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If

                    con.Close()

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        Else

            con.Close()

        End If

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Try

            If update_Txt_isbn.Text = "" Or
               Txt_book_name.Text = "" Or
               Cb_book_category.Text = "-Select Category-" Or
               Txt_book_qty.Text = "" Or
               Txt_author.Text = "" Or
               Txt_publisher.Text = "" Or
               Txt_supplier_name.Text = "" Then

                MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                con.Open()

                sql = "SELECT * FROM tbl_library_author
                                WHERE author_name = '" & Txt_author.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    dr.Close()

                    sql = "SELECT * FROM tbl_library_supplier
                                    WHERE supplier_full_name = '" & Txt_supplier_name.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        dr.Close()

                        sql = "UPDATE tbl_books SET
                                        isbn = '" & update_Txt_isbn.Text & "',
                                        book_name = '" & Txt_book_name.Text & "',
                                        qty = '" & Txt_book_qty.Text & "',
                                        primary_author_id = '" & Txt_primary_author_id.Text & "',                                            
                                        publish_year = '" & Dtp_publish_date.Value.ToString("MMMM dd, yyyy") & "',
                                        primary_supplier_id = '" & Txt_primary_supplier_id.Text & "',                                            
                                        acquisition_date = '" & Dtp_acquisition_date.Value.ToString("MMMM dd, yyyy") & "'
                                WHERE primary_book_id = '" & Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        dr.Close()

                        If Txt_primary_category_id.Text = "" Then

                        Else

                            sql = "UPDATE tbl_books SET
                                          primary_category_id = '" & Txt_primary_category_id.Text & "'                                                
                                   WHERE primary_book_id = '" & Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                            dr.Close()

                        End If



                        sql = "SELECT * FROM tbl_library_publisher
                                   WHERE publisher_name = '" & Txt_publisher.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader()

                        If dr.Read Then

                            dr.Close()

                        Else

                            dr.Close()

                            sql = "INSERT INTO tbl_library_publisher (publisher_name)
                                              VALUE ('" & Txt_publisher.Text & "')"
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                        End If



                        sql = "SELECT * FROM tbl_library_publisher
                                            WHERE publisher_name = '" & Txt_publisher.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader()

                        If dr.Read Then

                            Dim publisher_id As String = dr("primary_publisher_id")
                            dr.Close()

                            sql = "UPDATE tbl_books SET 
                                          primary_publisher_id = '" & publisher_id & "'
                                   WHERE primary_book_id = '" & Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                            dr.Close()

                        Else

                            dr.Close()

                        End If



                        con.Close()

                        Load_listed_books_data_table()
                        Load_returned_borrowed_books_data_table()
                        Load_penalty_data_table()
                        MessageBox.Show(Txt_book_name.Text + " was updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Fm_home_page.Enabled = True
                        Me.Close()

                    Else

                        dr.Close()

                        MessageBox.Show("Invalid Supplier Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If

                Else

                    dr.Close()

                    MessageBox.Show("Invalid Author Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                con.Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click

        Load_listed_books_data_table()
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

End Class