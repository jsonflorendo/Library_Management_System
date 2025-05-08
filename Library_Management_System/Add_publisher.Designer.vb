<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_publisher
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
        Btn_update = New Button()
        Btn_cancel = New Button()
        Btn_save = New Button()
        Txt_publisher_name = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(10, 79)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(91, 17)
        Lbl_error_msg.TabIndex = 16
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(12, 112)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(85, 25)
        Btn_update.TabIndex = 15
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(149, 112)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(85, 25)
        Btn_cancel.TabIndex = 13
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(12, 112)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(85, 25)
        Btn_save.TabIndex = 12
        Btn_save.Text = "&Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Txt_publisher_name
        ' 
        Txt_publisher_name.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_publisher_name.Location = New Point(12, 47)
        Txt_publisher_name.Name = "Txt_publisher_name"
        Txt_publisher_name.PlaceholderText = "Publisher"
        Txt_publisher_name.Size = New Size(222, 29)
        Txt_publisher_name.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(39, 9)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 25)
        Label4.TabIndex = 79
        Label4.Text = "Add Publisher"
        ' 
        ' Fm_publisher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(249, 154)
        ControlBox = False
        Controls.Add(Label4)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Btn_cancel)
        Controls.Add(Txt_publisher_name)
        Controls.Add(Btn_update)
        Controls.Add(Btn_save)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_publisher"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Txt_publisher_name As TextBox
    Friend WithEvents Label4 As Label
End Class
