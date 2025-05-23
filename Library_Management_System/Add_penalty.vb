﻿Imports MySql.Data.MySqlClient

Public Class Fm_add_penalty

    Private isLoading As Boolean = False

    'Dictionary to store checked items when searching
    Dim checkedItems As New Dictionary(Of String, Boolean)

    Private Sub Fm_add_penalty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

        If Txt_primary_penalty_report_id.Text = "" Then

            Load_library_penalty_data_table(Fm_home_page.Txt_search_penalty_description.Text)

        Else

            ' Display the selected penalty description in the ListView with check
            Try

                con.Open()

                Dim primary_borrower_id As String = Txt_primary_borrower_id.Text
                Dim primary_book_id As String = Txt_primary_book_id.Text
                Dim penalty_date As String = Fm_home_page.Lv_penalty.SelectedItems(0).SubItems(3).Text

                ' STEP 1: Fetch previously selected penalties
                Dim penalty_report_primary_penalty_description_id As New HashSet(Of String)

                sql = "SELECT * FROM tbl_penalty_report
                                WHERE primary_borrower_id = '" & primary_borrower_id & "'
                                AND primary_book_id = '" & primary_book_id & "'
                                AND penalty_date = '" & penalty_date & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                While dr.Read()
                    penalty_report_primary_penalty_description_id.Add(dr("primary_penalty_description_id").ToString())
                End While

                dr.Close()

                ' STEP 2: Fetch all penalties
                sql = "SELECT * FROM tbl_library_penalty                            
                                ORDER BY penalty_description ASC"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                Lv_penalty_description.Items.Clear()

                While dr.Read()

                    Dim library_penalty_primary_penalty_description_id As String = dr("primary_penalty_description_id").ToString()

                    Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                                dr("amount").ToString(),
                                                library_penalty_primary_penalty_description_id})

                    ' STEP 3: Check if this penalty was selected before
                    If penalty_report_primary_penalty_description_id.Contains(library_penalty_primary_penalty_description_id) Then
                        lv.Checked = True
                        If Not checkedItems.ContainsKey(library_penalty_primary_penalty_description_id) Then
                            checkedItems.Add(library_penalty_primary_penalty_description_id, True)
                        End If
                    End If

                    Lv_penalty_description.Items.Add(lv)

                End While

                dr.Close()

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        End If

    End Sub

    Private Sub Refresh_Lv_penalty_description_selected()

        Lv_penalty_description_selected.Items.Clear()

        For Each item As ListViewItem In Lv_penalty_description.Items
            Dim primary_penalty_description_id As String = item.SubItems(2).Text

            If checkedItems.ContainsKey(primary_penalty_description_id) Then
                ' Create a new item with Column 0 text (main item text)
                Dim newItem As New ListViewItem(item.Text)

                ' Make sure there are at least 3 columns
                While newItem.SubItems.Count < 3
                    newItem.SubItems.Add("")
                End While

                ' Set the third column (index 2) to the value from Lv_penalty_description column 2
                newItem.SubItems(1).Text = item.SubItems(1).Text ' Column 2 of source into Column 3 here

                Lv_penalty_description_selected.Items.Add(newItem)
            End If
        Next

    End Sub


    Private Sub Lv_penalty_description_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Lv_penalty_description.ItemCheck

        Dim item As ListViewItem = Lv_penalty_description.Items(e.Index)
        Dim primary_penalty_description_id As String = item.SubItems(2).Text ' Third column

        If item.Checked Then
            ' Unchecked now
            checkedItems.Remove(primary_penalty_description_id)
        Else
            ' Checked now
            If Not checkedItems.ContainsKey(primary_penalty_description_id) Then
                checkedItems.Add(primary_penalty_description_id, True)
            End If
        End If

        ' Rebuild Penalty Description Selected ListView
        Refresh_Lv_penalty_description_selected()

    End Sub

    Private Sub Txt_search_penalty_description_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_penalty_description.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty
                            WHERE penalty_description LIKE '%" & Txt_search_penalty_description.Text & "%'  
                            ORDER BY penalty_description ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Lv_penalty_description.Items.Clear()

            While dr.Read()

                Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                            dr("amount").ToString(),
                                            dr("primary_penalty_description_id").ToString()})

                'Preserve checked state even if item was previously hidden
                Dim primary_penalty_description_id As String = dr("primary_penalty_description_id").ToString()

                If checkedItems.ContainsKey(primary_penalty_description_id) AndAlso checkedItems(primary_penalty_description_id) Then
                    lv.Checked = True
                End If

                Lv_penalty_description.Items.Add(lv)

            End While

            dr.Close()

            ' Alternate row coloring
            For i As Integer = 0 To Lv_penalty_description.Items.Count - 1
                With Lv_penalty_description.Items(i)
                    .BackColor = If(i Mod 2 = 0, Color.Azure, Color.GhostWhite)
                    .ForeColor = Color.Black
                End With
            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Clear_error_msg()

        If checkedItems.Count = 0 Then

            Lbl_error_msg.Text = "Please select penalty description"

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

                    MessageBox.Show("Penalty for " + penalty_name + " added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_penalty_report_data_table(Fm_home_page.Txt_search_penalty_report.Text)
                    Fm_returned_books.Enabled = True
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

        If checkedItems.Count = 0 Then

            Lbl_error_msg.Text = "Please select penalty description"

        Else

            Try

                con.Open()

                Dim primary_borrower_id As String = Txt_primary_borrower_id.Text
                Dim primary_book_id As String = Txt_primary_book_id.Text
                Dim penalty_date As String = Fm_home_page.Lv_penalty.SelectedItems(0).SubItems(3).Text

                ' Step 1: Get existing penalty record (if any)
                sql = "SELECT * FROM tbl_penalty_report
                                WHERE primary_borrower_id = '" & primary_borrower_id & "'
                                AND primary_book_id = '" & primary_book_id & "'
                                AND penalty_date = '" & penalty_date & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                Dim primary_penalty_IDs As New List(Of String)

                While dr.Read()
                    primary_penalty_IDs.Add(dr("primary_penalty_id").ToString())
                End While

                dr.Close()


                ' STEP 1: Delete all penalties for this borrower and book
                For Each id As String In primary_penalty_IDs

                    sql = "DELETE FROM tbl_penalty_report
                                  WHERE primary_penalty_id = '" & id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                Next

                For Each primary_penalty_description_id As String In checkedItems.Keys 'Selecting checked items from checkedItems

                    sql = "INSERT INTO tbl_penalty_report (primary_borrower_id, 
                                                                primary_book_id,
                                                                primary_penalty_description_id,
                                                                penalty_date)
                                        VALUE ('" & primary_borrower_id & "',
                                                '" & primary_book_id & "',
                                                '" & primary_penalty_description_id & "',
                                                '" & penalty_date & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                Next

                con.Close()

                MessageBox.Show("Penalty for " + Txt_borrower_name.Text + " updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Load_penalty_report_data_table(Fm_home_page.Txt_search_penalty_report.Text)
                Fm_home_page.Lv_penalty_report_penalty_description.Items.Clear()
                Fm_home_page.Enabled = True
                Me.Close()

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

        If Fm_home_page.Enabled = False And Fm_returned_books.Enabled = False Then

            Fm_returned_books.Enabled = True

        Else

            Fm_home_page.Enabled = True
            Load_penalty_report_data_table(Fm_home_page.Txt_search_penalty_report.Text) '-> To item selection On the listview

        End If

        Me.Close()

    End Sub

    Private Sub Txt_search_penalty_description_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_penalty_description.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_penalty_description.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class