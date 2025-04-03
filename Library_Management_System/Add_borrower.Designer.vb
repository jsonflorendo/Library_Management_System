<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_add_borrower
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
        Label7 = New Label()
        Label6 = New Label()
        Txt_borrower_middle_name = New TextBox()
        Txt_borrower_first_name = New TextBox()
        Label5 = New Label()
        Rb_female = New RadioButton()
        Rb_male = New RadioButton()
        Txt_borrower_last_name = New TextBox()
        Txt_borrower_address = New TextBox()
        Txt_borrower_contact_no = New TextBox()
        Txt_borrower_id_number = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Btn_update = New Button()
        Btn_exit = New Button()
        Btn_save = New Button()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlLight
        Label7.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(39, 152)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 18)
        Label7.TabIndex = 56
        Label7.Text = "Middle Name :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlLight
        Label6.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(39, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 18)
        Label6.TabIndex = 55
        Label6.Text = "First Name :"
        ' 
        ' Txt_borrower_middle_name
        ' 
        Txt_borrower_middle_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_middle_name.Location = New Point(180, 152)
        Txt_borrower_middle_name.Name = "Txt_borrower_middle_name"
        Txt_borrower_middle_name.PlaceholderText = "Middle Name"
        Txt_borrower_middle_name.Size = New Size(200, 21)
        Txt_borrower_middle_name.TabIndex = 49
        ' 
        ' Txt_borrower_first_name
        ' 
        Txt_borrower_first_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_first_name.Location = New Point(180, 114)
        Txt_borrower_first_name.Name = "Txt_borrower_first_name"
        Txt_borrower_first_name.PlaceholderText = "First Name"
        Txt_borrower_first_name.Size = New Size(200, 21)
        Txt_borrower_first_name.TabIndex = 47
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLight
        Label5.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(39, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 18)
        Label5.TabIndex = 54
        Label5.Text = "Gender:"
        ' 
        ' Rb_female
        ' 
        Rb_female.AutoSize = True
        Rb_female.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Rb_female.Location = New Point(276, 188)
        Rb_female.Name = "Rb_female"
        Rb_female.Size = New Size(81, 22)
        Rb_female.TabIndex = 51
        Rb_female.TabStop = True
        Rb_female.Text = "Female"
        Rb_female.UseVisualStyleBackColor = True
        ' 
        ' Rb_male
        ' 
        Rb_male.AutoSize = True
        Rb_male.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Rb_male.Location = New Point(180, 188)
        Rb_male.Name = "Rb_male"
        Rb_male.Size = New Size(63, 22)
        Rb_male.TabIndex = 50
        Rb_male.TabStop = True
        Rb_male.Text = "Male"
        Rb_male.UseVisualStyleBackColor = True
        ' 
        ' Txt_borrower_last_name
        ' 
        Txt_borrower_last_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_last_name.Location = New Point(180, 78)
        Txt_borrower_last_name.Name = "Txt_borrower_last_name"
        Txt_borrower_last_name.PlaceholderText = "Last Name"
        Txt_borrower_last_name.Size = New Size(200, 21)
        Txt_borrower_last_name.TabIndex = 46
        ' 
        ' Txt_borrower_address
        ' 
        Txt_borrower_address.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_address.Location = New Point(180, 261)
        Txt_borrower_address.Name = "Txt_borrower_address"
        Txt_borrower_address.PlaceholderText = "Address"
        Txt_borrower_address.Size = New Size(200, 21)
        Txt_borrower_address.TabIndex = 52
        ' 
        ' Txt_borrower_contact_no
        ' 
        Txt_borrower_contact_no.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_contact_no.Location = New Point(180, 225)
        Txt_borrower_contact_no.Name = "Txt_borrower_contact_no"
        Txt_borrower_contact_no.PlaceholderText = "Contact No."
        Txt_borrower_contact_no.Size = New Size(200, 21)
        Txt_borrower_contact_no.TabIndex = 53
        ' 
        ' Txt_borrower_id_number
        ' 
        Txt_borrower_id_number.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_id_number.Location = New Point(180, 40)
        Txt_borrower_id_number.Name = "Txt_borrower_id_number"
        Txt_borrower_id_number.PlaceholderText = "ID Number"
        Txt_borrower_id_number.Size = New Size(200, 21)
        Txt_borrower_id_number.TabIndex = 44
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlLight
        Label8.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(39, 261)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 18)
        Label8.TabIndex = 48
        Label8.Text = "Address :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlLight
        Label9.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(39, 225)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 18)
        Label9.TabIndex = 45
        Label9.Text = "Contact No. :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlLight
        Label10.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(39, 78)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 18)
        Label10.TabIndex = 43
        Label10.Text = "Last Name :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ControlLight
        Label11.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(39, 40)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 18)
        Label11.TabIndex = 42
        Label11.Text = "ID Number :"
        ' 
        ' Btn_update
        ' 
        Btn_update.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_update.Location = New Point(61, 312)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(124, 44)
        Btn_update.TabIndex = 57
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_exit
        ' 
        Btn_exit.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_exit.Location = New Point(233, 312)
        Btn_exit.Name = "Btn_exit"
        Btn_exit.Size = New Size(124, 44)
        Btn_exit.TabIndex = 59
        Btn_exit.Text = "&Exit"
        Btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(61, 312)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(124, 44)
        Btn_save.TabIndex = 58
        Btn_save.Text = "&Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Fm_add_borrower
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(416, 387)
        ControlBox = False
        Controls.Add(Btn_exit)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Txt_borrower_middle_name)
        Controls.Add(Txt_borrower_first_name)
        Controls.Add(Label5)
        Controls.Add(Rb_female)
        Controls.Add(Rb_male)
        Controls.Add(Txt_borrower_last_name)
        Controls.Add(Txt_borrower_address)
        Controls.Add(Txt_borrower_contact_no)
        Controls.Add(Txt_borrower_id_number)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Btn_update)
        Controls.Add(Btn_save)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_add_borrower"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_borrower_middle_name As TextBox
    Friend WithEvents Txt_borrower_first_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Rb_female As RadioButton
    Friend WithEvents Rb_male As RadioButton
    Friend WithEvents Txt_borrower_last_name As TextBox
    Friend WithEvents Txt_borrower_address As TextBox
    Friend WithEvents Txt_borrower_contact_no As TextBox
    Friend WithEvents Txt_borrower_id_number As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_exit As Button
    Friend WithEvents Btn_save As Button
End Class
