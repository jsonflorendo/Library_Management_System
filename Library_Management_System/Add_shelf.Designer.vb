<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_add_shelf
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
        Lbl_error_msg_5 = New Label()
        Lbl_error_msg_4 = New Label()
        Lbl_error_msg_3 = New Label()
        Lbl_error_msg_2 = New Label()
        Lbl_error_msg_1 = New Label()
        Lbl_error_msg = New Label()
        Txt_shelf_name = New TextBox()
        Btn_update = New Button()
        Btn_cancel = New Button()
        Btn_save = New Button()
        Txt_shelf_current_load = New TextBox()
        Txt_shelf_capacity = New TextBox()
        Txt_shelf_floor_number = New TextBox()
        Txt_shelf_section = New TextBox()
        Txt_shelf_id = New TextBox()
        SuspendLayout()
        ' 
        ' Lbl_error_msg_5
        ' 
        Lbl_error_msg_5.AutoSize = True
        Lbl_error_msg_5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_5.ForeColor = Color.Red
        Lbl_error_msg_5.Location = New Point(28, 311)
        Lbl_error_msg_5.Name = "Lbl_error_msg_5"
        Lbl_error_msg_5.Size = New Size(93, 15)
        Lbl_error_msg_5.TabIndex = 34
        Lbl_error_msg_5.Text = "Lbl_error_msg_5"
        ' 
        ' Lbl_error_msg_4
        ' 
        Lbl_error_msg_4.AutoSize = True
        Lbl_error_msg_4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_4.ForeColor = Color.Red
        Lbl_error_msg_4.Location = New Point(28, 259)
        Lbl_error_msg_4.Name = "Lbl_error_msg_4"
        Lbl_error_msg_4.Size = New Size(93, 15)
        Lbl_error_msg_4.TabIndex = 33
        Lbl_error_msg_4.Text = "Lbl_error_msg_4"
        ' 
        ' Lbl_error_msg_3
        ' 
        Lbl_error_msg_3.AutoSize = True
        Lbl_error_msg_3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_3.ForeColor = Color.Red
        Lbl_error_msg_3.Location = New Point(28, 207)
        Lbl_error_msg_3.Name = "Lbl_error_msg_3"
        Lbl_error_msg_3.Size = New Size(93, 15)
        Lbl_error_msg_3.TabIndex = 32
        Lbl_error_msg_3.Text = "Lbl_error_msg_3"
        ' 
        ' Lbl_error_msg_2
        ' 
        Lbl_error_msg_2.AutoSize = True
        Lbl_error_msg_2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_2.ForeColor = Color.Red
        Lbl_error_msg_2.Location = New Point(28, 155)
        Lbl_error_msg_2.Name = "Lbl_error_msg_2"
        Lbl_error_msg_2.Size = New Size(93, 15)
        Lbl_error_msg_2.TabIndex = 31
        Lbl_error_msg_2.Text = "Lbl_error_msg_2"
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(28, 103)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(91, 15)
        Lbl_error_msg_1.TabIndex = 30
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(28, 51)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(81, 15)
        Lbl_error_msg.TabIndex = 29
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Txt_shelf_name
        ' 
        Txt_shelf_name.Font = New Font("Arial", 14.25F)
        Txt_shelf_name.Location = New Point(30, 71)
        Txt_shelf_name.Name = "Txt_shelf_name"
        Txt_shelf_name.PlaceholderText = "Shelf Name"
        Txt_shelf_name.Size = New Size(302, 29)
        Txt_shelf_name.TabIndex = 2
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(30, 343)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(125, 30)
        Btn_update.TabIndex = 0
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(207, 343)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(125, 30)
        Btn_cancel.TabIndex = 7
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(30, 343)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(125, 30)
        Btn_save.TabIndex = 0
        Btn_save.Text = "&Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Txt_shelf_current_load
        ' 
        Txt_shelf_current_load.Font = New Font("Arial", 14.25F)
        Txt_shelf_current_load.Location = New Point(30, 279)
        Txt_shelf_current_load.Name = "Txt_shelf_current_load"
        Txt_shelf_current_load.PlaceholderText = "Current Load"
        Txt_shelf_current_load.Size = New Size(302, 29)
        Txt_shelf_current_load.TabIndex = 6
        ' 
        ' Txt_shelf_capacity
        ' 
        Txt_shelf_capacity.Font = New Font("Arial", 14.25F)
        Txt_shelf_capacity.Location = New Point(30, 227)
        Txt_shelf_capacity.Name = "Txt_shelf_capacity"
        Txt_shelf_capacity.PlaceholderText = "Capacity"
        Txt_shelf_capacity.Size = New Size(302, 29)
        Txt_shelf_capacity.TabIndex = 5
        ' 
        ' Txt_shelf_floor_number
        ' 
        Txt_shelf_floor_number.Font = New Font("Arial", 14.25F)
        Txt_shelf_floor_number.Location = New Point(30, 175)
        Txt_shelf_floor_number.Name = "Txt_shelf_floor_number"
        Txt_shelf_floor_number.PlaceholderText = "Floor Number"
        Txt_shelf_floor_number.Size = New Size(302, 29)
        Txt_shelf_floor_number.TabIndex = 4
        ' 
        ' Txt_shelf_section
        ' 
        Txt_shelf_section.Font = New Font("Arial", 14.25F)
        Txt_shelf_section.Location = New Point(30, 123)
        Txt_shelf_section.Name = "Txt_shelf_section"
        Txt_shelf_section.PlaceholderText = "Section"
        Txt_shelf_section.Size = New Size(302, 29)
        Txt_shelf_section.TabIndex = 3
        ' 
        ' Txt_shelf_id
        ' 
        Txt_shelf_id.Font = New Font("Arial", 14.25F)
        Txt_shelf_id.Location = New Point(30, 19)
        Txt_shelf_id.Name = "Txt_shelf_id"
        Txt_shelf_id.PlaceholderText = "Shelf ID"
        Txt_shelf_id.Size = New Size(302, 29)
        Txt_shelf_id.TabIndex = 1
        ' 
        ' Fm_add_shelf
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(361, 390)
        ControlBox = False
        Controls.Add(Lbl_error_msg_5)
        Controls.Add(Lbl_error_msg_4)
        Controls.Add(Lbl_error_msg_3)
        Controls.Add(Lbl_error_msg_2)
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Txt_shelf_name)
        Controls.Add(Btn_cancel)
        Controls.Add(Txt_shelf_current_load)
        Controls.Add(Txt_shelf_capacity)
        Controls.Add(Txt_shelf_floor_number)
        Controls.Add(Txt_shelf_section)
        Controls.Add(Txt_shelf_id)
        Controls.Add(Btn_update)
        Controls.Add(Btn_save)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_add_shelf"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Lbl_error_msg_5 As Label
    Friend WithEvents Lbl_error_msg_4 As Label
    Friend WithEvents Lbl_error_msg_3 As Label
    Friend WithEvents Lbl_error_msg_2 As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Txt_shelf_name As TextBox
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Cb_supplier_source_type As ComboBox
    Friend WithEvents Txt_supplier_address As TextBox
    Friend WithEvents Txt_shelf_current_load As TextBox
    Friend WithEvents Txt_shelf_capacity As TextBox
    Friend WithEvents Txt_shelf_floor_number As TextBox
    Friend WithEvents Txt_shelf_section As TextBox
    Friend WithEvents Txt_shelf_id As TextBox
End Class
