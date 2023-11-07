Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class MainPage

    Dim fname As String
    Dim lname As String
    Dim age As Integer

    Dim number1 As Integer
    Dim number2 As Integer
    Dim total As Integer






    Private Sub Button_show_Click(sender As Object, e As EventArgs) Handles Button_show.Click
        fname = TextBox_fname.Text
        lname = TextBox_lname.Text
        age = TextBox_age.Text

        ' adding string is & 
        MsgBox("Your name " & fname & " " + lname & " Aged: " & age)
    End Sub

    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        number1 = TextBox_num1.Text
        number2 = TextBox_num2.Text

        Dim addition As Integer = number1 + number2
        TextBox_Result.Text = addition
    End Sub



    Private Sub Button_minus_Click(sender As Object, e As EventArgs) Handles Button_minus.Click
        number1 = TextBox_num1.Text
        number2 = TextBox_num2.Text

        Dim minus As Integer = number1 - number2
        TextBox_Result.Text = minus
    End Sub

    Private Sub Button_multi_Click(sender As Object, e As EventArgs) Handles Button_multi.Click
        number1 = TextBox_num1.Text
        number2 = TextBox_num2.Text

        Dim multiply As Integer = number1 * number2
        TextBox_Result.Text = multiply

    End Sub

    Private Sub Button_divide_Click(sender As Object, e As EventArgs) Handles Button_divide.Click
        number1 = TextBox_num1.Text
        number2 = TextBox_num2.Text

        Dim divide As Integer = number1 / number2
        TextBox_Result.Text = divide

    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Dim f1 = Form1

        f1.Show()
        Me.Hide()



    End Sub

    Private Sub Button_and_Click(sender As Object, e As EventArgs) Handles Button_and.Click
        Dim and1 As String = "Jerome"
        Dim and2 As String = "Marco"

        If and1 = "Jerome" And and2 = "Marco" Then
            MessageBox.Show("Welcome Admin")
        Else
            MessageBox.Show("Welcome User")
        End If

    End Sub

    Private Sub Button_or_Click(sender As Object, e As EventArgs) Handles Button_or.Click
        Dim or1 As Integer = 12
        Dim or2 As Integer = 11

        If or1 = 10 Or or2 = 20 Then
            MessageBox.Show("One of the statement is correct")
        Else
            MessageBox.Show("None of the statement is correct")
        End If

    End Sub

    Private Sub Button_not_Click(sender As Object, e As EventArgs) Handles Button_not.Click
        Dim isAlive As Boolean = False

        If Not isAlive Then
            MessageBox.Show("IS ALIVE false")
        Else
            MessageBox.Show("IS ALIVE true")
        End If
    End Sub

    Private Sub Label_passdata_Click(sender As Object, e As EventArgs) Handles Label_passdata.Click





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = TextBox_id.Text
        Dim username As String = TextBox_USER.Text
        Dim pass As String = TextBox_PASS.Text

        Dim query As String = "INSERT INTO sample(id,username, pass) VALUES (@id,@username, @pass)"
        Using con As SqlConnection = New SqlConnection("Data Source=JEROMEMARCO;Initial Catalog=users;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@pass", pass)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                TextBox_id.Text = ""
                TextBox_USER.Text = ""
                TextBox_PASS.Text = ""
                data()
            End Using
        End Using

    End Sub

    Sub data()
        Dim query As String = "SELECT * FROM sample"
        Using con As SqlConnection = New SqlConnection("Data Source=JEROMEMARCO;Initial Catalog=users;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class