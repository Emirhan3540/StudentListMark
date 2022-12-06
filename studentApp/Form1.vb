Public Class Form1

    Dim St_Name(10) As String
    Dim St_Surname(10) As String
    Dim St_Num(10) As Single
    Dim St_Mid(10) As Single
    Dim St_Fin(10) As Single
    Dim I As Integer = 0
    Dim passNum As Integer
    Dim failNum As Integer
    Dim average(10) As Single
    Dim result(10) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For I = 0 To I - 1
            If (average(I) >= 50) Then
                result(I) = "Student Passed"
                passNum += 1
                TextBox6.Text = passNum
            Else
                failNum += 1
                TextBox7.Text = failNum
                result(I) = "Student Failed"

            End If
        Next
        Studentlist.Items.Clear()
        For I = 0 To I - 1
            Studentlist.Items.Add(St_Num(I) & vbTab & St_Name(I) & vbTab & St_Surname(I) & vbTab & result(I))
        Next





    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        St_Name(I) = TextBox5.Text
        St_Surname(I) = TextBox4.Text
        St_Num(I) = TextBox1.Text
        St_Mid(I) = TextBox2.Text
        St_Fin(I) = TextBox3.Text
        average(I) = St_Mid(I) * 0.4 + St_Fin(I) * 0.6
        I += 1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Studentlist.Items.Clear()
        For I = 0 To I - 1
            Studentlist.Items.Add(St_Num(I) & vbTab & St_Name(I) & vbTab & St_Surname(I) & vbTab & St_Mid(I) & vbTab & St_Fin(I))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Studentlist.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For I = 0 To I - 1
            Studentlist.Items.Add(St_Num(I) & vbTab & St_Name(I) & vbTab & St_Surname(I))
        Next
    End Sub
End Class
