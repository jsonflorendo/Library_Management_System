<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_penalty_description
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
        Btn_cancel = New Button()
        Btn_save = New Button()
        Txt_penalty_description = New TextBox()
        Btn_update = New Button()
        Lbl_error_msg = New Label()
        Lbl_error_msg_1 = New Label()
        Txt_penalty_amount = New TextBox()
        SuspendLayout()
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(149, 124)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(85, 25)
        Btn_cancel.TabIndex = 1
        Btn_cancel.Text = "Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(12, 124)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(85, 25)
        Btn_save.TabIndex = 0
        Btn_save.Text = "Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Txt_penalty_description
        ' 
        Txt_penalty_description.Font = New Font("Georgia", 14.25F)
        Txt_penalty_description.Location = New Point(12, 12)
        Txt_penalty_description.Name = "Txt_penalty_description"
        Txt_penalty_description.PlaceholderText = "Penalty Description"
        Txt_penalty_description.Size = New Size(222, 29)
        Txt_penalty_description.TabIndex = 2
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(12, 124)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(85, 25)
        Btn_update.TabIndex = 0
        Btn_update.Text = "Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(9, 44)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(91, 17)
        Lbl_error_msg.TabIndex = 8
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(9, 98)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(101, 17)
        Lbl_error_msg_1.TabIndex = 10
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Txt_penalty_amount
        ' 
        Txt_penalty_amount.Font = New Font("Georgia", 14.25F)
        Txt_penalty_amount.Location = New Point(12, 66)
        Txt_penalty_amount.Name = "Txt_penalty_amount"
        Txt_penalty_amount.PlaceholderText = "Amount"
        Txt_penalty_amount.Size = New Size(222, 29)
        Txt_penalty_amount.TabIndex = 9
        ' 
        ' Fm_penalty_description
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(249, 160)
        ControlBox = False
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Txt_penalty_amount)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Btn_update)
        Controls.Add(Btn_cancel)
        Controls.Add(Btn_save)
        Controls.Add(Txt_penalty_description)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_penalty_description"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Txt_penalty_description As TextBox
    Friend WithEvents Btn_update As Button
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Txt_penalty_amount As TextBox
End Class
