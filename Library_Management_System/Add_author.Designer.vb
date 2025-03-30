<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_add_author
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
        Txt_author_name = New TextBox()
        Btn_save = New Button()
        Btn_cancel = New Button()
        Btn_update = New Button()
        MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Lbl_error_msg = New Label()
        SuspendLayout()
        ' 
        ' Txt_author_name
        ' 
        Txt_author_name.Font = New Font("Georgia", 14.25F)
        Txt_author_name.Location = New Point(12, 12)
        Txt_author_name.Name = "Txt_author_name"
        Txt_author_name.PlaceholderText = "Author"
        Txt_author_name.Size = New Size(222, 29)
        Txt_author_name.TabIndex = 2
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(12, 77)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(85, 25)
        Btn_save.TabIndex = 0
        Btn_save.Text = "Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(149, 77)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(85, 25)
        Btn_cancel.TabIndex = 1
        Btn_cancel.Text = "Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(12, 77)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(85, 25)
        Btn_update.TabIndex = 10
        Btn_update.Text = "Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' MySqlDataAdapter1
        ' 
        MySqlDataAdapter1.DeleteCommand = Nothing
        MySqlDataAdapter1.InsertCommand = Nothing
        MySqlDataAdapter1.SelectCommand = Nothing
        MySqlDataAdapter1.UpdateCommand = Nothing
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(9, 44)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(91, 17)
        Lbl_error_msg.TabIndex = 11
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Fm_add_author
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(249, 116)
        ControlBox = False
        Controls.Add(Lbl_error_msg)
        Controls.Add(Btn_update)
        Controls.Add(Btn_cancel)
        Controls.Add(Btn_save)
        Controls.Add(Txt_author_name)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_add_author"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt_author_name As TextBox
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Btn_update As Button
    Friend WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
    Friend WithEvents Lbl_error_msg As Label
End Class
