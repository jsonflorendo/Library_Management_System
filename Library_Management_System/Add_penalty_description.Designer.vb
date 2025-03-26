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
        SuspendLayout()
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(187, 133)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(85, 25)
        Btn_cancel.TabIndex = 1
        Btn_cancel.Text = "Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(50, 133)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(85, 25)
        Btn_save.TabIndex = 0
        Btn_save.Text = "Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Txt_penalty_description
        ' 
        Txt_penalty_description.Font = New Font("Georgia", 14.25F)
        Txt_penalty_description.Location = New Point(50, 46)
        Txt_penalty_description.Name = "Txt_penalty_description"
        Txt_penalty_description.PlaceholderText = "Penalty Description"
        Txt_penalty_description.Size = New Size(222, 29)
        Txt_penalty_description.TabIndex = 2
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(50, 133)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(85, 25)
        Btn_update.TabIndex = 0
        Btn_update.Text = "Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Fm_penalty_description
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(333, 208)
        ControlBox = False
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
End Class
