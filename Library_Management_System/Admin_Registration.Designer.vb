<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_admin_registration
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
        Txt_firstname = New TextBox()
        Txt_email = New TextBox()
        Txt_lastname = New TextBox()
        Txt_middlename = New TextBox()
        Txt_username = New TextBox()
        Txt_password = New TextBox()
        Txt_confirmpassword = New TextBox()
        Btn_save = New Button()
        Btn_cancel = New Button()
        Txt_contact = New TextBox()
        Txt_address = New TextBox()
        Rb_male = New RadioButton()
        Rb_female = New RadioButton()
        Dtp_birthdate = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Btn_update = New Button()
        Cb_show_password = New CheckBox()
        Cb_user_type = New ComboBox()
        Txt_temp_email = New TextBox()
        Txt_temp_username = New TextBox()
        SuspendLayout()
        ' 
        ' Txt_firstname
        ' 
        Txt_firstname.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_firstname.Location = New Point(22, 59)
        Txt_firstname.Name = "Txt_firstname"
        Txt_firstname.PlaceholderText = "First Name"
        Txt_firstname.Size = New Size(199, 21)
        Txt_firstname.TabIndex = 1
        ' 
        ' Txt_email
        ' 
        Txt_email.Font = New Font("Georgia", 9F)
        Txt_email.Location = New Point(260, 104)
        Txt_email.Name = "Txt_email"
        Txt_email.PlaceholderText = "Email"
        Txt_email.Size = New Size(199, 21)
        Txt_email.TabIndex = 10
        ' 
        ' Txt_lastname
        ' 
        Txt_lastname.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_lastname.Location = New Point(22, 152)
        Txt_lastname.Name = "Txt_lastname"
        Txt_lastname.PlaceholderText = "Last Name"
        Txt_lastname.Size = New Size(199, 21)
        Txt_lastname.TabIndex = 3
        ' 
        ' Txt_middlename
        ' 
        Txt_middlename.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_middlename.Location = New Point(22, 104)
        Txt_middlename.Name = "Txt_middlename"
        Txt_middlename.PlaceholderText = "Middle Name"
        Txt_middlename.Size = New Size(199, 21)
        Txt_middlename.TabIndex = 2
        ' 
        ' Txt_username
        ' 
        Txt_username.Font = New Font("Georgia", 9F)
        Txt_username.Location = New Point(260, 59)
        Txt_username.Name = "Txt_username"
        Txt_username.PlaceholderText = "Username"
        Txt_username.Size = New Size(199, 21)
        Txt_username.TabIndex = 9
        ' 
        ' Txt_password
        ' 
        Txt_password.Font = New Font("Georgia", 9F)
        Txt_password.Location = New Point(260, 212)
        Txt_password.Name = "Txt_password"
        Txt_password.PlaceholderText = "Password"
        Txt_password.Size = New Size(199, 21)
        Txt_password.TabIndex = 13
        ' 
        ' Txt_confirmpassword
        ' 
        Txt_confirmpassword.Font = New Font("Georgia", 9F)
        Txt_confirmpassword.Location = New Point(260, 245)
        Txt_confirmpassword.Name = "Txt_confirmpassword"
        Txt_confirmpassword.PlaceholderText = "Confirm Password"
        Txt_confirmpassword.Size = New Size(199, 21)
        Txt_confirmpassword.TabIndex = 14
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(52, 340)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(119, 33)
        Btn_save.TabIndex = 0
        Btn_save.Text = "&Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Font = New Font("Georgia", 9F)
        Btn_cancel.Location = New Point(295, 340)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(117, 33)
        Btn_cancel.TabIndex = 15
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Txt_contact
        ' 
        Txt_contact.Font = New Font("Georgia", 9F)
        Txt_contact.Location = New Point(22, 266)
        Txt_contact.Name = "Txt_contact"
        Txt_contact.PlaceholderText = "Contact No."
        Txt_contact.Size = New Size(199, 21)
        Txt_contact.TabIndex = 7
        ' 
        ' Txt_address
        ' 
        Txt_address.Font = New Font("Georgia", 9F)
        Txt_address.Location = New Point(22, 304)
        Txt_address.Name = "Txt_address"
        Txt_address.PlaceholderText = "Address"
        Txt_address.Size = New Size(199, 21)
        Txt_address.TabIndex = 8
        ' 
        ' Rb_male
        ' 
        Rb_male.AutoSize = True
        Rb_male.Font = New Font("Georgia", 9F)
        Rb_male.Location = New Point(27, 185)
        Rb_male.Name = "Rb_male"
        Rb_male.Size = New Size(53, 19)
        Rb_male.TabIndex = 4
        Rb_male.TabStop = True
        Rb_male.Text = "Male"
        Rb_male.UseVisualStyleBackColor = True
        ' 
        ' Rb_female
        ' 
        Rb_female.AutoSize = True
        Rb_female.Font = New Font("Georgia", 9F)
        Rb_female.Location = New Point(97, 185)
        Rb_female.Name = "Rb_female"
        Rb_female.Size = New Size(67, 19)
        Rb_female.TabIndex = 5
        Rb_female.TabStop = True
        Rb_female.Text = "Female"
        Rb_female.UseVisualStyleBackColor = True
        ' 
        ' Dtp_birthdate
        ' 
        Dtp_birthdate.Font = New Font("Georgia", 9F)
        Dtp_birthdate.Format = DateTimePickerFormat.Short
        Dtp_birthdate.Location = New Point(22, 228)
        Dtp_birthdate.Name = "Dtp_birthdate"
        Dtp_birthdate.Size = New Size(199, 21)
        Dtp_birthdate.TabIndex = 6
        Dtp_birthdate.Value = New Date(2024, 5, 5, 13, 41, 51, 0)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 15
        Label1.Text = "Birthday"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(2, 1)
        Label2.Name = "Label2"
        Label2.Size = New Size(275, 38)
        Label2.TabIndex = 16
        Label2.Text = "User Maintenance"
        ' 
        ' Btn_update
        ' 
        Btn_update.Font = New Font("Georgia", 9F)
        Btn_update.Location = New Point(52, 340)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(119, 33)
        Btn_update.TabIndex = 0
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Cb_show_password
        ' 
        Cb_show_password.AutoSize = True
        Cb_show_password.Font = New Font("Georgia", 9F)
        Cb_show_password.Location = New Point(260, 186)
        Cb_show_password.Name = "Cb_show_password"
        Cb_show_password.Size = New Size(113, 19)
        Cb_show_password.TabIndex = 12
        Cb_show_password.Text = "&Show Password"
        Cb_show_password.UseVisualStyleBackColor = True
        ' 
        ' Cb_user_type
        ' 
        Cb_user_type.Font = New Font("Georgia", 9F)
        Cb_user_type.FormattingEnabled = True
        Cb_user_type.ItemHeight = 15
        Cb_user_type.Items.AddRange(New Object() {"ASSISTANT LIBRARIAN", "STAFF"})
        Cb_user_type.Location = New Point(260, 152)
        Cb_user_type.Name = "Cb_user_type"
        Cb_user_type.Size = New Size(199, 23)
        Cb_user_type.TabIndex = 11
        Cb_user_type.Tag = ""
        Cb_user_type.Text = "-Select User Type-"
        ' 
        ' Txt_temp_email
        ' 
        Txt_temp_email.Location = New Point(465, 103)
        Txt_temp_email.Name = "Txt_temp_email"
        Txt_temp_email.PlaceholderText = "Temp Email"
        Txt_temp_email.Size = New Size(152, 23)
        Txt_temp_email.TabIndex = 17
        ' 
        ' Txt_temp_username
        ' 
        Txt_temp_username.Location = New Point(465, 58)
        Txt_temp_username.Name = "Txt_temp_username"
        Txt_temp_username.PlaceholderText = "Temp Username"
        Txt_temp_username.Size = New Size(152, 23)
        Txt_temp_username.TabIndex = 18
        ' 
        ' Fm_admin_registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 385)
        ControlBox = False
        Controls.Add(Txt_temp_username)
        Controls.Add(Txt_temp_email)
        Controls.Add(Cb_user_type)
        Controls.Add(Cb_show_password)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Dtp_birthdate)
        Controls.Add(Rb_female)
        Controls.Add(Rb_male)
        Controls.Add(Txt_address)
        Controls.Add(Txt_contact)
        Controls.Add(Btn_cancel)
        Controls.Add(Btn_update)
        Controls.Add(Btn_save)
        Controls.Add(Txt_confirmpassword)
        Controls.Add(Txt_password)
        Controls.Add(Txt_username)
        Controls.Add(Txt_middlename)
        Controls.Add(Txt_lastname)
        Controls.Add(Txt_email)
        Controls.Add(Txt_firstname)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_admin_registration"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt_firstname As TextBox
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Txt_lastname As TextBox
    Friend WithEvents Txt_middlename As TextBox
    Friend WithEvents Txt_username As TextBox
    Friend WithEvents Txt_password As TextBox
    Friend WithEvents Txt_confirmpassword As TextBox
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Txt_contact As TextBox
    Friend WithEvents Txt_address As TextBox
    Friend WithEvents Rb_male As RadioButton
    Friend WithEvents Rb_female As RadioButton
    Friend WithEvents Dtp_birthdate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_update As Button
    Friend WithEvents Cb_show_password As CheckBox
    Friend WithEvents Cb_user_type As ComboBox
    Friend WithEvents Txt_temp_email As TextBox
    Friend WithEvents Txt_temp_username As TextBox
End Class
