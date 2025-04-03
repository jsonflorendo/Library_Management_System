Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Fm_add_penalty

    Private Sub Fm_add_penalty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_library_penalty_data_table()

        Clear_error_msg()

    End Sub


    'Dictionary to store checked items when searching
    Dim checkedItems As New Dictionary(Of String, Boolean)

    Private Sub Txt_search_penalty_description_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_penalty_description.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty
                            WHERE penalty_description LIKE '%" & Txt_search_penalty_description.Text & "%'  
                            ORDER BY penalty_description ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Lv_penalty_description.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                            dr("amount").ToString(),
                                            dr("primary_penalty_description_id").ToString()})

                'Preserve checked state even if item was previously hidden
                Dim primary_penalty_description_id As String = dr("primary_penalty_description_id").ToString()

                If checkedItems.ContainsKey(primary_penalty_description_id) AndAlso checkedItems(primary_penalty_description_id) Then
                    lv.Checked = True
                End If

                Lv_penalty_description.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_penalty_description.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_penalty_description.Items(i).BackColor = Color.Azure
                    Lv_penalty_description.Items(i).ForeColor = Color.Black

                Else

                    Lv_penalty_description.Items(i).BackColor = Color.GhostWhite
                    Lv_penalty_description.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Lv_penalty_description_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Lv_penalty_description.ItemCheck

        'Store checked items even if they are temporarily hidden
        Dim primary_penalty_description_id As String = Lv_penalty_description.Items(e.Index).SubItems(2).Text 'Third column
        If e.NewValue = CheckState.Checked Then
            checkedItems(primary_penalty_description_id) = True
        Else
            'Remove from dictionary if unchecked
            checkedItems.Remove(primary_penalty_description_id)
        End If

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Clear_error_msg()

        If checkedItems.Count = 0 Then

            Lbl_error_msg.Text = "Please select description"

        Else

            Try

                con.Open()

                Dim penalty_name = Txt_borrower_name.Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to add this penalty for " + penalty_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    For Each primary_penalty_description_id As String In checkedItems.Keys 'Selecting checked items from checkedItems

                        sql = "INSERT INTO tbl_penalty_report (primary_borrower_id, 
                                                                primary_book_id,
                                                                primary_penalty_description_id,
                                                                penalty_date)
                                        VALUE ('" & Txt_primary_borrower_id.Text & "',
                                                '" & Txt_primary_book_id.Text & "',
                                                '" & primary_penalty_description_id & "',
                                                '" & Date.Now.ToString("MMMM dd, yyyy") & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                    Next

                    con.Close()

                    Load_penalty_report_data_table()
                    MessageBox.Show("Penalty for " + penalty_name + " added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Fm_returned_books.Enabled = True
                    Me.Close()

                Else

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

        Try

            con.Open()

            sql = "UPDATE tbl_penalty_report SET
                            primary_penalty_description_id = '" & Lv_penalty_description.SelectedItems(0).SubItems(0).Text & "'
                    WHERE primary_penalty_id = '" & Fm_home_page.Lv_penalty.SelectedItems(0).SubItems(9).Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            con.Close()

            MessageBox.Show("Penalty for " + Txt_borrower_name.Text + " updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Fm_home_page.Enabled = True
            Load_penalty_report_data_table() '-> To item selection On the listview
            Me.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        If Fm_home_page.Enabled = False And Fm_returned_books.Enabled = False Then

            Fm_returned_books.Enabled = True
            Me.Close()

        Else

            Fm_home_page.Enabled = True
            Load_penalty_report_data_table() '-> To item selection On the listview
            Me.Close()

        End If

    End Sub

    Private Sub Txt_search_penalty_description_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_penalty_description.KeyPress

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
        If Txt_search_penalty_description.TextLength >= maxLength Then
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