Imports MySql.Data.MySqlClient

Public Class Fm_add_penalty

    Private Sub Fm_add_penalty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_library_cb_penalty_description()

        Clear_error_msg()

    End Sub

    Private Sub Cb_penalty_description_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_penalty_description.SelectedIndexChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty
                            WHERE penalty_description = '" & Cb_penalty_description.SelectedItem & "'"
            'GROUP BY author_name"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            If dr.Read() Then

                Txt_primary_penalty_description_id.Text = dr("primary_penalty_description_id")
                Txt_penalty_amount.Text = dr("amount")

            End If

            con.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Cb_penalty_description_Click(sender As Object, e As EventArgs) Handles Cb_penalty_description.Click

        Cb_penalty_description.DroppedDown = True

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Clear_error_msg()

        If Cb_penalty_description.Text = "-Select Description-" Then

            Lbl_error_msg.Text = "Please select description"

        Else

            Try

                con.Open()

                Dim penalty_name = Txt_borrower_name.Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to add this penalty for " + penalty_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "INSERT INTO tbl_penalty_report (primary_borrower_id, 
                                                            primary_book_id,
                                                            primary_penalty_description_id,
                                                            penalty_date)
                                    VALUE ('" & Txt_primary_borrower_id.Text & "',
                                            '" & Txt_primary_book_id.Text & "',
                                            '" & Txt_primary_penalty_description_id.Text & "',
                                            '" & Date.Now.ToString("MMMM dd, yyyy") & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

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
                            primary_penalty_description_id = '" & Txt_primary_penalty_description_id.Text & "'
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

End Class