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
        Button_say = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox_User = New TextBox()
        TextBox_Pass = New TextBox()
        Button_Login = New Button()
        Button2 = New Button()
        Button_passdata = New Button()
        TextBox_passdata = New TextBox()
        SuspendLayout()
        ' 
        ' Button_say
        ' 
        Button_say.Location = New Point(49, 38)
        Button_say.Name = "Button_say"
        Button_say.Size = New Size(167, 79)
        Button_say.TabIndex = 0
        Button_say.Text = "SAY!"
        Button_say.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(239, 38)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 79)
        Button1.TabIndex = 1
        Button1.Text = "SECONDPAGE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 263)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' TextBox_User
        ' 
        TextBox_User.Location = New Point(158, 218)
        TextBox_User.Name = "TextBox_User"
        TextBox_User.Size = New Size(100, 23)
        TextBox_User.TabIndex = 4
        ' 
        ' TextBox_Pass
        ' 
        TextBox_Pass.Location = New Point(158, 263)
        TextBox_Pass.Name = "TextBox_Pass"
        TextBox_Pass.Size = New Size(100, 23)
        TextBox_Pass.TabIndex = 5
        ' 
        ' Button_Login
        ' 
        Button_Login.Location = New Point(143, 308)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(115, 35)
        Button_Login.TabIndex = 6
        Button_Login.Text = "Login"
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(441, 38)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 79)
        Button2.TabIndex = 7
        Button2.Text = "Display" & vbCrLf & "Variables" & vbCrLf
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button_passdata
        ' 
        Button_passdata.Location = New Point(316, 241)
        Button_passdata.Name = "Button_passdata"
        Button_passdata.Size = New Size(143, 65)
        Button_passdata.TabIndex = 8
        Button_passdata.Text = "PassData to 2nd Page"
        Button_passdata.UseVisualStyleBackColor = True
        ' 
        ' TextBox_passdata
        ' 
        TextBox_passdata.Location = New Point(316, 212)
        TextBox_passdata.Name = "TextBox_passdata"
        TextBox_passdata.Size = New Size(143, 23)
        TextBox_passdata.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1019, 576)
        Controls.Add(TextBox_passdata)
        Controls.Add(Button_passdata)
        Controls.Add(Button2)
        Controls.Add(Button_Login)
        Controls.Add(TextBox_Pass)
        Controls.Add(TextBox_User)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Button_say)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_say As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_User As TextBox
    Friend WithEvents TextBox_Pass As TextBox
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button_passdata As Button
    Friend WithEvents TextBox_passdata As TextBox
End Class
