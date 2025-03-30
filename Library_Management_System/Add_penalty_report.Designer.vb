<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_penalty_report
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
        Txt_penalty_amount = New TextBox()
        Txt_penalty_book_name = New TextBox()
        Txt_penalty_name = New TextBox()
        Txt_penalty_id_number = New TextBox()
        Cb_penalty_description = New ComboBox()
        Dtp_penalty_date = New DateTimePicker()
        Btn_update = New Button()
        Btn_cancel = New Button()
        Btn_save = New Button()
        SuspendLayout()
        ' 
        ' Txt_penalty_amount
        ' 
        Txt_penalty_amount.Font = New Font("Georgia", 14.25F)
        Txt_penalty_amount.Location = New Point(28, 169)
        Txt_penalty_amount.Name = "Txt_penalty_amount"
        Txt_penalty_amount.PlaceholderText = "Enter Penalty Amount"
        Txt_penalty_amount.Size = New Size(302, 29)
        Txt_penalty_amount.TabIndex = 9
        ' 
        ' Txt_penalty_book_name
        ' 
        Txt_penalty_book_name.Font = New Font("Georgia", 14.25F)
        Txt_penalty_book_name.Location = New Point(28, 116)
        Txt_penalty_book_name.Name = "Txt_penalty_book_name"
        Txt_penalty_book_name.PlaceholderText = "Book Name"
        Txt_penalty_book_name.Size = New Size(302, 29)
        Txt_penalty_book_name.TabIndex = 8
        ' 
        ' Txt_penalty_name
        ' 
        Txt_penalty_name.Enabled = False
        Txt_penalty_name.Font = New Font("Georgia", 14.25F)
        Txt_penalty_name.Location = New Point(28, 68)
        Txt_penalty_name.Name = "Txt_penalty_name"
        Txt_penalty_name.PlaceholderText = "Enter Name"
        Txt_penalty_name.Size = New Size(302, 29)
        Txt_penalty_name.TabIndex = 7
        ' 
        ' Txt_penalty_id_number
        ' 
        Txt_penalty_id_number.Enabled = False
        Txt_penalty_id_number.Font = New Font("Georgia", 14.25F)
        Txt_penalty_id_number.Location = New Point(28, 24)
        Txt_penalty_id_number.Name = "Txt_penalty_id_number"
        Txt_penalty_id_number.PlaceholderText = "Enter ID Number"
        Txt_penalty_id_number.Size = New Size(302, 29)
        Txt_penalty_id_number.TabIndex = 6
        ' 
        ' Cb_penalty_description
        ' 
        Cb_penalty_description.Font = New Font("Georgia", 14.25F)
        Cb_penalty_description.FormattingEnabled = True
        Cb_penalty_description.Location = New Point(28, 225)
        Cb_penalty_description.Name = "Cb_penalty_description"
        Cb_penalty_description.Size = New Size(302, 31)
        Cb_penalty_description.TabIndex = 22
        Cb_penalty_description.Text = "--Penalty Description--"
        ' 
        ' Dtp_penalty_date
        ' 
        Dtp_penalty_date.CalendarFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Dtp_penalty_date.Font = New Font("Georgia", 14.25F)
        Dtp_penalty_date.Location = New Point(28, 281)
        Dtp_penalty_date.Name = "Dtp_penalty_date"
        Dtp_penalty_date.Size = New Size(302, 29)
        Dtp_penalty_date.TabIndex = 21
        Dtp_penalty_date.Value = New Date(2024, 5, 7, 7, 41, 26, 0)
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(113, 354)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(125, 30)
        Btn_update.TabIndex = 23
        Btn_update.Text = "Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(205, 390)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(125, 30)
        Btn_cancel.TabIndex = 25
        Btn_cancel.Text = "Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(28, 390)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(125, 30)
        Btn_save.TabIndex = 24
        Btn_save.Text = "Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Fm_penalty_report
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(361, 480)
        ControlBox = False
        Controls.Add(Btn_update)
        Controls.Add(Btn_cancel)
        Controls.Add(Btn_save)
        Controls.Add(Cb_penalty_description)
        Controls.Add(Dtp_penalty_date)
        Controls.Add(Txt_penalty_amount)
        Controls.Add(Txt_penalty_book_name)
        Controls.Add(Txt_penalty_name)
        Controls.Add(Txt_penalty_id_number)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_penalty_report"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt_penalty_amount As TextBox
    Friend WithEvents Txt_penalty_book_name As TextBox
    Friend WithEvents Txt_penalty_name As TextBox
    Friend WithEvents Txt_penalty_id_number As TextBox
    Friend WithEvents Cb_penalty_description As ComboBox
    Friend WithEvents Dtp_penalty_date As DateTimePicker
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Btn_save As Button
End Class
