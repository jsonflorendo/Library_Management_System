<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_login))
        Txt_username = New TextBox()
        Txt_password = New TextBox()
        Btn_login = New Button()
        Btn_close = New Button()
        Cb_show_password = New CheckBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Txt_username
        ' 
        Txt_username.BackColor = Color.Gainsboro
        Txt_username.Font = New Font("Georgia", 18F)
        Txt_username.Location = New Point(754, 282)
        Txt_username.Name = "Txt_username"
        Txt_username.PlaceholderText = "Enter Username"
        Txt_username.Size = New Size(246, 35)
        Txt_username.TabIndex = 1
        Txt_username.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_password
        ' 
        Txt_password.BackColor = Color.Gainsboro
        Txt_password.Font = New Font("Georgia", 18F)
        Txt_password.Location = New Point(754, 349)
        Txt_password.Name = "Txt_password"
        Txt_password.PlaceholderText = "Enter Password"
        Txt_password.Size = New Size(246, 35)
        Txt_password.TabIndex = 2
        Txt_password.TextAlign = HorizontalAlignment.Center
        ' 
        ' Btn_login
        ' 
        Btn_login.BackColor = Color.Gainsboro
        Btn_login.Font = New Font("Georgia", 9F)
        Btn_login.Location = New Point(730, 464)
        Btn_login.Name = "Btn_login"
        Btn_login.Size = New Size(127, 43)
        Btn_login.TabIndex = 0
        Btn_login.Text = "&Login"
        Btn_login.UseVisualStyleBackColor = False
        ' 
        ' Btn_close
        ' 
        Btn_close.BackColor = Color.Gainsboro
        Btn_close.Font = New Font("Georgia", 9F)
        Btn_close.Location = New Point(894, 464)
        Btn_close.Name = "Btn_close"
        Btn_close.Size = New Size(127, 43)
        Btn_close.TabIndex = 4
        Btn_close.Text = "&Close"
        Btn_close.UseVisualStyleBackColor = False
        ' 
        ' Cb_show_password
        ' 
        Cb_show_password.AutoSize = True
        Cb_show_password.Font = New Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_show_password.Location = New Point(754, 405)
        Cb_show_password.Name = "Cb_show_password"
        Cb_show_password.Size = New Size(161, 27)
        Cb_show_password.TabIndex = 3
        Cb_show_password.Text = "&Show Password"
        Cb_show_password.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(730, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(295, 81)
        Label1.TabIndex = 5
        Label1.Text = "Welcome"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(602, 618)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1162, 618)
        Panel1.TabIndex = 7
        ' 
        ' Fm_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1163, 616)
        ControlBox = False
        Controls.Add(Txt_username)
        Controls.Add(Cb_show_password)
        Controls.Add(Txt_password)
        Controls.Add(Btn_login)
        Controls.Add(Btn_close)
        Controls.Add(Panel1)
        HelpButton = True
        MaximumSize = New Size(1920, 1042)
        Name = "Fm_login"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt_username As TextBox
    Friend WithEvents Txt_password As TextBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents Btn_close As Button
    Friend WithEvents Cb_show_password As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel

End Class
