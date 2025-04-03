<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_supplier_maintenance
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
        Cb_supplier_source_type = New ComboBox()
        Txt_supplier_address = New TextBox()
        Txt_supplier_contact = New TextBox()
        Txt_supplier_email_address = New TextBox()
        Txt_supplier_lastname = New TextBox()
        Txt_supplier_firstname = New TextBox()
        Txt_supplier_id = New TextBox()
        Btn_save = New Button()
        Btn_cancel = New Button()
        Btn_update = New Button()
        Txt_supplier_name = New TextBox()
        Lbl_error_msg = New Label()
        Lbl_error_msg_1 = New Label()
        Lbl_error_msg_2 = New Label()
        Lbl_error_msg_3 = New Label()
        Lbl_error_msg_4 = New Label()
        Lbl_error_msg_5 = New Label()
        Lbl_error_msg_6 = New Label()
        Lbl_error_msg_7 = New Label()
        SuspendLayout()
        ' 
        ' Cb_supplier_source_type
        ' 
        Cb_supplier_source_type.Font = New Font("Georgia", 14.25F)
        Cb_supplier_source_type.FormattingEnabled = True
        Cb_supplier_source_type.Items.AddRange(New Object() {"Supplier", "Donator"})
        Cb_supplier_source_type.Location = New Point(29, 376)
        Cb_supplier_source_type.Name = "Cb_supplier_source_type"
        Cb_supplier_source_type.Size = New Size(302, 31)
        Cb_supplier_source_type.TabIndex = 9
        Cb_supplier_source_type.Text = "--Select Source Type--"
        ' 
        ' Txt_supplier_address
        ' 
        Txt_supplier_address.Font = New Font("Georgia", 14.25F)
        Txt_supplier_address.Location = New Point(29, 326)
        Txt_supplier_address.Name = "Txt_supplier_address"
        Txt_supplier_address.PlaceholderText = "Enter Address"
        Txt_supplier_address.Size = New Size(302, 29)
        Txt_supplier_address.TabIndex = 8
        ' 
        ' Txt_supplier_contact
        ' 
        Txt_supplier_contact.Font = New Font("Georgia", 14.25F)
        Txt_supplier_contact.Location = New Point(29, 276)
        Txt_supplier_contact.Name = "Txt_supplier_contact"
        Txt_supplier_contact.PlaceholderText = "Enter Contact No."
        Txt_supplier_contact.Size = New Size(302, 29)
        Txt_supplier_contact.TabIndex = 7
        ' 
        ' Txt_supplier_email_address
        ' 
        Txt_supplier_email_address.Font = New Font("Georgia", 14.25F)
        Txt_supplier_email_address.Location = New Point(29, 226)
        Txt_supplier_email_address.Name = "Txt_supplier_email_address"
        Txt_supplier_email_address.PlaceholderText = "Enter  Email Address"
        Txt_supplier_email_address.Size = New Size(302, 29)
        Txt_supplier_email_address.TabIndex = 6
        ' 
        ' Txt_supplier_lastname
        ' 
        Txt_supplier_lastname.Font = New Font("Georgia", 14.25F)
        Txt_supplier_lastname.Location = New Point(29, 176)
        Txt_supplier_lastname.Name = "Txt_supplier_lastname"
        Txt_supplier_lastname.PlaceholderText = "Enter Lastname"
        Txt_supplier_lastname.Size = New Size(302, 29)
        Txt_supplier_lastname.TabIndex = 5
        ' 
        ' Txt_supplier_firstname
        ' 
        Txt_supplier_firstname.Font = New Font("Georgia", 14.25F)
        Txt_supplier_firstname.Location = New Point(29, 126)
        Txt_supplier_firstname.Name = "Txt_supplier_firstname"
        Txt_supplier_firstname.PlaceholderText = "Enter First Name"
        Txt_supplier_firstname.Size = New Size(302, 29)
        Txt_supplier_firstname.TabIndex = 4
        ' 
        ' Txt_supplier_id
        ' 
        Txt_supplier_id.Font = New Font("Georgia", 14.25F)
        Txt_supplier_id.Location = New Point(29, 26)
        Txt_supplier_id.Name = "Txt_supplier_id"
        Txt_supplier_id.PlaceholderText = "Enter Supplier ID"
        Txt_supplier_id.Size = New Size(302, 29)
        Txt_supplier_id.TabIndex = 2
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(29, 438)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(125, 30)
        Btn_save.TabIndex = 0
        Btn_save.Text = "Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(206, 438)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(125, 30)
        Btn_cancel.TabIndex = 1
        Btn_cancel.Text = "Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(29, 438)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(125, 30)
        Btn_update.TabIndex = 0
        Btn_update.Text = "Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Txt_supplier_name
        ' 
        Txt_supplier_name.Font = New Font("Georgia", 14.25F)
        Txt_supplier_name.Location = New Point(29, 76)
        Txt_supplier_name.Name = "Txt_supplier_name"
        Txt_supplier_name.PlaceholderText = "Enter Supplier Name"
        Txt_supplier_name.Size = New Size(302, 29)
        Txt_supplier_name.TabIndex = 3
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(27, 58)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(81, 15)
        Lbl_error_msg.TabIndex = 10
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(27, 108)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(91, 15)
        Lbl_error_msg_1.TabIndex = 11
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Lbl_error_msg_2
        ' 
        Lbl_error_msg_2.AutoSize = True
        Lbl_error_msg_2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_2.ForeColor = Color.Red
        Lbl_error_msg_2.Location = New Point(27, 158)
        Lbl_error_msg_2.Name = "Lbl_error_msg_2"
        Lbl_error_msg_2.Size = New Size(93, 15)
        Lbl_error_msg_2.TabIndex = 12
        Lbl_error_msg_2.Text = "Lbl_error_msg_2"
        ' 
        ' Lbl_error_msg_3
        ' 
        Lbl_error_msg_3.AutoSize = True
        Lbl_error_msg_3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_3.ForeColor = Color.Red
        Lbl_error_msg_3.Location = New Point(27, 208)
        Lbl_error_msg_3.Name = "Lbl_error_msg_3"
        Lbl_error_msg_3.Size = New Size(93, 15)
        Lbl_error_msg_3.TabIndex = 13
        Lbl_error_msg_3.Text = "Lbl_error_msg_3"
        ' 
        ' Lbl_error_msg_4
        ' 
        Lbl_error_msg_4.AutoSize = True
        Lbl_error_msg_4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_4.ForeColor = Color.Red
        Lbl_error_msg_4.Location = New Point(27, 258)
        Lbl_error_msg_4.Name = "Lbl_error_msg_4"
        Lbl_error_msg_4.Size = New Size(93, 15)
        Lbl_error_msg_4.TabIndex = 14
        Lbl_error_msg_4.Text = "Lbl_error_msg_4"
        ' 
        ' Lbl_error_msg_5
        ' 
        Lbl_error_msg_5.AutoSize = True
        Lbl_error_msg_5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_5.ForeColor = Color.Red
        Lbl_error_msg_5.Location = New Point(27, 308)
        Lbl_error_msg_5.Name = "Lbl_error_msg_5"
        Lbl_error_msg_5.Size = New Size(93, 15)
        Lbl_error_msg_5.TabIndex = 15
        Lbl_error_msg_5.Text = "Lbl_error_msg_5"
        ' 
        ' Lbl_error_msg_6
        ' 
        Lbl_error_msg_6.AutoSize = True
        Lbl_error_msg_6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_6.ForeColor = Color.Red
        Lbl_error_msg_6.Location = New Point(27, 358)
        Lbl_error_msg_6.Name = "Lbl_error_msg_6"
        Lbl_error_msg_6.Size = New Size(93, 15)
        Lbl_error_msg_6.TabIndex = 16
        Lbl_error_msg_6.Text = "Lbl_error_msg_6"
        ' 
        ' Lbl_error_msg_7
        ' 
        Lbl_error_msg_7.AutoSize = True
        Lbl_error_msg_7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_7.ForeColor = Color.Red
        Lbl_error_msg_7.Location = New Point(27, 410)
        Lbl_error_msg_7.Name = "Lbl_error_msg_7"
        Lbl_error_msg_7.Size = New Size(92, 15)
        Lbl_error_msg_7.TabIndex = 17
        Lbl_error_msg_7.Text = "Lbl_error_msg_7"
        ' 
        ' Fm_supplier_maintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(361, 480)
        ControlBox = False
        Controls.Add(Lbl_error_msg_7)
        Controls.Add(Lbl_error_msg_6)
        Controls.Add(Lbl_error_msg_5)
        Controls.Add(Lbl_error_msg_4)
        Controls.Add(Lbl_error_msg_3)
        Controls.Add(Lbl_error_msg_2)
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Txt_supplier_name)
        Controls.Add(Btn_update)
        Controls.Add(Btn_cancel)
        Controls.Add(Btn_save)
        Controls.Add(Cb_supplier_source_type)
        Controls.Add(Txt_supplier_address)
        Controls.Add(Txt_supplier_contact)
        Controls.Add(Txt_supplier_email_address)
        Controls.Add(Txt_supplier_lastname)
        Controls.Add(Txt_supplier_firstname)
        Controls.Add(Txt_supplier_id)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_supplier_maintenance"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cb_supplier_source_type As ComboBox
    Friend WithEvents Txt_supplier_address As TextBox
    Friend WithEvents Txt_supplier_contact As TextBox
    Friend WithEvents Txt_supplier_email_address As TextBox
    Friend WithEvents Txt_supplier_lastname As TextBox
    Friend WithEvents Txt_supplier_firstname As TextBox
    Friend WithEvents Txt_supplier_id As TextBox
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Btn_update As Button
    Friend WithEvents Txt_supplier_name As TextBox
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Lbl_error_msg_2 As Label
    Friend WithEvents Lbl_error_msg_3 As Label
    Friend WithEvents Lbl_error_msg_4 As Label
    Friend WithEvents Lbl_error_msg_5 As Label
    Friend WithEvents Lbl_error_msg_6 As Label
    Friend WithEvents Lbl_error_msg_7 As Label
End Class
