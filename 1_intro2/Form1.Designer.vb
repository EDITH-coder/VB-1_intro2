<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnClickHere = New Button()
        labelSurname = New Label()
        labelName = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        profession = New Label()
        RadioButtonFemale = New RadioButton()
        RadioButtonMale = New RadioButton()
        RadioButtonOthers = New RadioButton()
        CheckBoxSubscribe = New CheckBox()
        CheckBoxSignMeUp = New CheckBox()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' btnClickHere
        ' 
        btnClickHere.Location = New Point(178, 303)
        btnClickHere.Name = "btnClickHere"
        btnClickHere.Size = New Size(75, 23)
        btnClickHere.TabIndex = 0
        btnClickHere.Text = "Click Here"
        btnClickHere.UseVisualStyleBackColor = True
        ' 
        ' labelSurname
        ' 
        labelSurname.AutoSize = True
        labelSurname.Location = New Point(102, 149)
        labelSurname.Name = "labelSurname"
        labelSurname.Size = New Size(54, 15)
        labelSurname.TabIndex = 1
        labelSurname.Text = "Surname"
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Location = New Point(102, 103)
        labelName.Name = "labelName"
        labelName.Size = New Size(39, 15)
        labelName.TabIndex = 1
        labelName.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(196, 95)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(131, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(196, 141)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(131, 23)
        TextBox2.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"AI", "BA", "DEVOPS"})
        ComboBox1.Location = New Point(196, 171)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' profession
        ' 
        profession.AutoSize = True
        profession.Location = New Point(102, 179)
        profession.Name = "profession"
        profession.Size = New Size(62, 15)
        profession.TabIndex = 5
        profession.Text = "Profession"
        ' 
        ' RadioButtonFemale
        ' 
        RadioButtonFemale.AutoSize = True
        RadioButtonFemale.Location = New Point(450, 80)
        RadioButtonFemale.Name = "RadioButtonFemale"
        RadioButtonFemale.Size = New Size(63, 19)
        RadioButtonFemale.TabIndex = 6
        RadioButtonFemale.TabStop = True
        RadioButtonFemale.Text = "Female"
        RadioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonMale
        ' 
        RadioButtonMale.AutoSize = True
        RadioButtonMale.Location = New Point(450, 124)
        RadioButtonMale.Name = "RadioButtonMale"
        RadioButtonMale.Size = New Size(51, 19)
        RadioButtonMale.TabIndex = 7
        RadioButtonMale.TabStop = True
        RadioButtonMale.Text = "Male"
        RadioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonOthers
        ' 
        RadioButtonOthers.AutoSize = True
        RadioButtonOthers.Location = New Point(450, 162)
        RadioButtonOthers.Name = "RadioButtonOthers"
        RadioButtonOthers.Size = New Size(60, 19)
        RadioButtonOthers.TabIndex = 8
        RadioButtonOthers.TabStop = True
        RadioButtonOthers.Text = "Others"
        RadioButtonOthers.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxSubscribe
        ' 
        CheckBoxSubscribe.AutoSize = True
        CheckBoxSubscribe.Location = New Point(178, 225)
        CheckBoxSubscribe.Name = "CheckBoxSubscribe"
        CheckBoxSubscribe.Size = New Size(77, 19)
        CheckBoxSubscribe.TabIndex = 9
        CheckBoxSubscribe.Text = "Subscribe"
        CheckBoxSubscribe.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxSignMeUp
        ' 
        CheckBoxSignMeUp.AutoSize = True
        CheckBoxSignMeUp.Location = New Point(178, 259)
        CheckBoxSignMeUp.Name = "CheckBoxSignMeUp"
        CheckBoxSignMeUp.Size = New Size(86, 19)
        CheckBoxSignMeUp.TabIndex = 10
        CheckBoxSignMeUp.Text = "Sign me up"
        CheckBoxSignMeUp.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Info
        TextBox3.Font = New Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(125, 12)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(376, 23)
        TextBox3.TabIndex = 11
        TextBox3.Text = "Sign Up For The Mindworx"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(CheckBoxSignMeUp)
        Controls.Add(CheckBoxSubscribe)
        Controls.Add(RadioButtonOthers)
        Controls.Add(RadioButtonMale)
        Controls.Add(RadioButtonFemale)
        Controls.Add(profession)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(labelName)
        Controls.Add(labelSurname)
        Controls.Add(btnClickHere)
        Name = "Form1"
        Text = "text"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickHere As Button
    Friend WithEvents labelSurname As Label
    Friend WithEvents labelName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents profession As Label
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents RadioButtonOthers As RadioButton
    Friend WithEvents CheckBoxSubscribe As CheckBox
    Friend WithEvents CheckBoxSignMeUp As CheckBox
    Friend WithEvents TextBox3 As TextBox
End Class
