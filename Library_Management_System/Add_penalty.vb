Imports MySql.Data.MySqlClient

Public Class Fm_add_penalty

    Private Sub Fm_add_penalty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_library_cb_penalty_description()

        Dtp_penalty_date.Format = DateTimePickerFormat.Custom
        Dtp_penalty_date.CustomFormat = "MMMM dd, yyyy | h:mm tt"

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

            End If

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Txt_borrower_id_TextChanged(sender As Object, e As EventArgs) Handles Txt_borrower_id.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_borrower
                                WHERE borrower_id = '" & Txt_borrower_id.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            If dr.Read() Then

                Txt_primary_borrower_id.Text = dr("primary_borrower_id")

            Else

                Txt_borrower_name.Clear()
                Txt_primary_borrower_id.Clear()

            End If

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Try

            If Txt_penalty_amount.Text = "" Or
               Cb_penalty_description.Text = "-Select Description-" Then

                MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                con.Open()

                Dim penalty_name = Txt_borrower_name.Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to add this penalty for " + penalty_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "INSERT INTO tbl_penalty_report (primary_borrower_id, 
                                                            primary_book_id,
                                                            penalty_amount,
                                                            primary_penalty_description_id,
                                                            penalty_date,
                                                            penalty_time)
                                          VALUE ('" & Txt_primary_borrower_id.Text & "',
                                                '" & Txt_primary_book_id.Text & "',
                                                '" & Txt_penalty_amount.Text & "',
                                                '" & Txt_primary_penalty_description_id.Text & "',
                                                '" & Dtp_penalty_date.Value.ToString("MMM-dd-yyyy") & "',
                                                '" & Dtp_penalty_date.Value.ToString("hh:mm tt") & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Load_penalty_report_data_table()
                    MessageBox.Show("Penalty for " + penalty_name + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Fm_returned_books.Enabled = True
                    Me.Close()

                Else

                    con.Close()

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Cb_penalty_description_Click(sender As Object, e As EventArgs) Handles Cb_penalty_description.Click

        Cb_penalty_description.DroppedDown = True

    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Fm_returned_books.Enabled = True
        Me.Close()

    End Sub

    Private Sub Txt_penalty_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_penalty_amount.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 10 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_penalty_amount.TextLength >= maxLength Then
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