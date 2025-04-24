Public Class Fm_add_book_inventory

    Private Sub Fm_add_book_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

    End Sub

    Private Sub save_Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles save_Txt_isbn.KeyPress



    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click



    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Load_book_inventory_data_table(Fm_home_page.Txt_book_inventory_search.Text)
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

End Class