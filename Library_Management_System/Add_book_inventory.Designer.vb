<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_add_book_inventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Lbl_error_msg = New Label()
        Label9 = New Label()
        Btn_cancel = New Button()
        Btn_update = New Button()
        save_Txt_isbn = New TextBox()
        update_Txt_isbn = New TextBox()
        Label7 = New Label()
        Txt_book_quantity = New TextBox()
        Lbl_error_msg_1 = New Label()
        SuspendLayout()
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(166, 42)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(81, 15)
        Lbl_error_msg.TabIndex = 71
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlLight
        Label9.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(21, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 16)
        Label9.TabIndex = 63
        Label9.Text = "ISBN :"
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_cancel.Location = New Point(233, 113)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(129, 40)
        Btn_cancel.TabIndex = 58
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_update.Location = New Point(21, 113)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(129, 40)
        Btn_update.TabIndex = 48
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' save_Txt_isbn
        ' 
        save_Txt_isbn.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        save_Txt_isbn.Location = New Point(166, 18)
        save_Txt_isbn.Name = "save_Txt_isbn"
        save_Txt_isbn.PlaceholderText = "ISBN"
        save_Txt_isbn.Size = New Size(196, 21)
        save_Txt_isbn.TabIndex = 64
        ' 
        ' update_Txt_isbn
        ' 
        update_Txt_isbn.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        update_Txt_isbn.Location = New Point(166, 18)
        update_Txt_isbn.Name = "update_Txt_isbn"
        update_Txt_isbn.PlaceholderText = "ISBN"
        update_Txt_isbn.Size = New Size(196, 21)
        update_Txt_isbn.TabIndex = 60
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlLight
        Label7.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(21, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 16)
        Label7.TabIndex = 77
        Label7.Text = "Quantity:"
        ' 
        ' Txt_book_quantity
        ' 
        Txt_book_quantity.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_book_quantity.Location = New Point(166, 61)
        Txt_book_quantity.Name = "Txt_book_quantity"
        Txt_book_quantity.PlaceholderText = "Quantity"
        Txt_book_quantity.Size = New Size(196, 21)
        Txt_book_quantity.TabIndex = 76
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(166, 85)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(91, 15)
        Lbl_error_msg_1.TabIndex = 78
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Fm_add_book_inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(384, 169)
        ControlBox = False
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Label7)
        Controls.Add(Txt_book_quantity)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Label9)
        Controls.Add(Btn_cancel)
        Controls.Add(Btn_update)
        Controls.Add(save_Txt_isbn)
        Controls.Add(update_Txt_isbn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_add_book_inventory"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Btn_add_publisher As Button
    Friend WithEvents Btn_add_author As Button
    Friend WithEvents Btn_add_category As Button
    Friend WithEvents Lbl_error_msg_4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Dtp_publish_date As DateTimePicker
    Friend WithEvents Cb_book_category As ComboBox
    Friend WithEvents Txt_publisher As TextBox
    Friend WithEvents Txt_author As TextBox
    Friend WithEvents Cb_publisher As ComboBox
    Friend WithEvents Cb_author As ComboBox
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_book_name As TextBox
    Friend WithEvents Btn_update As Button
    Friend WithEvents save_Txt_isbn As TextBox
    Friend WithEvents update_Txt_isbn As TextBox
    Friend WithEvents Txt_primary_category_id As TextBox
    Friend WithEvents Txt_primary_publisher_id As TextBox
    Friend WithEvents Txt_primary_author_id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_book_quantity As TextBox
    Friend WithEvents Lbl_error_msg_3 As Label
    Friend WithEvents Lbl_error_msg_1 As Label
End Class
