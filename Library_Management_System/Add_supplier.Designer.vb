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
        SuspendLayout()
        ' 
        ' Cb_supplier_source_type
        ' 
        Cb_supplier_source_type.Font = New Font("Georgia", 14.25F)
        Cb_supplier_source_type.FormattingEnabled = True
        Cb_supplier_source_type.Items.AddRange(New Object() {"Supplier", "Donator"})
        Cb_supplier_source_type.Location = New Point(30, 343)
        Cb_supplier_source_type.Name = "Cb_supplier_source_type"
        Cb_supplier_source_type.Size = New Size(302, 31)
        Cb_supplier_source_type.TabIndex = 9
        Cb_supplier_source_type.Text = "--Select Source Type--"
        ' 
        ' Txt_supplier_address
        ' 
        Txt_supplier_address.Font = New Font("Georgia", 14.25F)
        Txt_supplier_address.Location = New Point(30, 297)
        Txt_supplier_address.Name = "Txt_supplier_address"
        Txt_supplier_address.PlaceholderText = "Enter Address"
        Txt_supplier_address.Size = New Size(302, 29)
        Txt_supplier_address.TabIndex = 8
        ' 
        ' Txt_supplier_contact
        ' 
        Txt_supplier_contact.Font = New Font("Georgia", 14.25F)
        Txt_supplier_contact.Location = New Point(30, 252)
        Txt_supplier_contact.Name = "Txt_supplier_contact"
        Txt_supplier_contact.PlaceholderText = "Enter Contact No."
        Txt_supplier_contact.Size = New Size(302, 29)
        Txt_supplier_contact.TabIndex = 7
        ' 
        ' Txt_supplier_email_address
        ' 
        Txt_supplier_email_address.Font = New Font("Georgia", 14.25F)
        Txt_supplier_email_address.Location = New Point(30, 206)
        Txt_supplier_email_address.Name = "Txt_supplier_email_address"
        Txt_supplier_email_address.PlaceholderText = "Enter  Email Address"
        Txt_supplier_email_address.Size = New Size(302, 29)
        Txt_supplier_email_address.TabIndex = 6
        ' 
        ' Txt_supplier_lastname
        ' 
        Txt_supplier_lastname.Font = New Font("Georgia", 14.25F)
        Txt_supplier_lastname.Location = New Point(30, 158)
        Txt_supplier_lastname.Name = "Txt_supplier_lastname"
        Txt_supplier_lastname.PlaceholderText = "Enter Lastname"
        Txt_supplier_lastname.Size = New Size(302, 29)
        Txt_supplier_lastname.TabIndex = 5
        ' 
        ' Txt_supplier_firstname
        ' 
        Txt_supplier_firstname.Font = New Font("Georgia", 14.25F)
        Txt_supplier_firstname.Location = New Point(30, 114)
        Txt_supplier_firstname.Name = "Txt_supplier_firstname"
        Txt_supplier_firstname.PlaceholderText = "Enter First Name"
        Txt_supplier_firstname.Size = New Size(302, 29)
        Txt_supplier_firstname.TabIndex = 4
        ' 
        ' Txt_supplier_id
        ' 
        Txt_supplier_id.Font = New Font("Georgia", 14.25F)
        Txt_supplier_id.Location = New Point(30, 26)
        Txt_supplier_id.Name = "Txt_supplier_id"
        Txt_supplier_id.PlaceholderText = "Enter Supplier ID"
        Txt_supplier_id.Size = New Size(302, 29)
        Txt_supplier_id.TabIndex = 2
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(30, 406)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(125, 30)
        Btn_save.TabIndex = 0
        Btn_save.Text = "Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(207, 406)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(125, 30)
        Btn_cancel.TabIndex = 1
        Btn_cancel.Text = "Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(30, 406)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(125, 30)
        Btn_update.TabIndex = 0
        Btn_update.Text = "Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Txt_supplier_name
        ' 
        Txt_supplier_name.Font = New Font("Georgia", 14.25F)
        Txt_supplier_name.Location = New Point(30, 70)
        Txt_supplier_name.Name = "Txt_supplier_name"
        Txt_supplier_name.PlaceholderText = "Enter Supplier Name"
        Txt_supplier_name.Size = New Size(302, 29)
        Txt_supplier_name.TabIndex = 3
        ' 
        ' Fm_supplier_maintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(361, 454)
        ControlBox = False
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
End Class
