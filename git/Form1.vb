Public Class Form1
    ' can use public or dim
    Dim name As String = "Jerome"

    Public fname As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Hello")


    End Sub

    Private Sub Button_say_Click(sender As Object, e As EventArgs) Handles Button_say.Click
        ' can use messagebox or msgbox 
        MessageBox.Show("Hello")
        MsgBox(name)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim page1 = MainPage




        ' THis me is the form itself
        Me.Hide()

        page1.Show()











    End Sub

    Private Sub TextBox_User_TextChanged(sender As Object, e As EventArgs) Handles TextBox_User.TextChanged

    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim page1 = MainPage
        Dim user As String = "Jerome"
        Dim Pass As String = "123"
        Dim enteredUsername As String = TextBox_User.Text
        Dim enteredPassword As String = TextBox_Pass.Text

        ' if else statement AndALso means &&
        If enteredUsername = user AndAlso enteredPassword = Pass Then
            Me.Hide()
            MessageBox.Show("Welcome")
            MainPage.Show()
        Else
            MessageBox.Show("Error")
            TextBox_User.Text = ""
            TextBox_Pass.Text = ""
        End If

        Console.WriteLine("Completed")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim isAlive As Boolean = True
        Dim Number1 As Integer = 22
        Dim Name As String = "Jerome"
        Dim Number2 As Double = 22.22
        Dim Today As Date = #10/24/2023#
        ' NEWLINE or nextline /n
        MessageBox.Show("String: " & Name & vbNewLine &
                        "Integer: " & Number1 & vbNewLine &
                        "Boolean: " & isAlive & vbNewLine &
                        "Date: " & Today & vbNewLine &
                        "Double" & Number2 & vbNewLine)






    End Sub

    Private Sub Button_passdata_Click(sender As Object, e As EventArgs) Handles Button_passdata.Click
        fname = TextBox_passdata.Text

        Dim mp = MainPage

        mp.Label_passdata.Text = fname

        MsgBox(fname)

        Me.Hide()
        MainPage.Show()





    End Sub

    Private Sub TextBox_passdata_TextChanged(sender As Object, e As EventArgs) Handles TextBox_passdata.TextChanged

    End Sub
End Class
