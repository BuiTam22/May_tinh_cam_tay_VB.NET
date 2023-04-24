Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim A As Double = 0, B As Double = 0, pheptinh As String, kq As Double = 0

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles btnoff.Click
        End
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        TextBox1.Text += "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        TextBox1.Text += "1"



    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If

        TextBox1.Text += "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If

        TextBox1.Text += "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If

        TextBox1.Text += "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If

        TextBox1.Text += "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        TextBox1.Text += "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        TextBox1.Text += "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If

        TextBox1.Text += "8"
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If TextBox2.Text.EndsWith("=") Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        TextBox1.Text += "9"
    End Sub

    Private Sub btncong_Click(sender As Object, e As EventArgs) Handles btncong.Click

        TextBox2.Text = TextBox1.Text + "+"
        A = TextBox1.Text
        TextBox1.Text = ""
        pheptinh = "+"
    End Sub

    Private Sub btntru_Click(sender As Object, e As EventArgs) Handles btntru.Click
        If TextBox1.Text <> "" Then
            TextBox2.Text = TextBox1.Text + "-"
            A = TextBox1.Text
            TextBox1.Text = ""
            pheptinh = "-"
        Else
            TextBox1.Text += "-"
        End If
    End Sub

    Private Sub btnnhan_Click(sender As Object, e As EventArgs) Handles btnnhan.Click
        TextBox2.Text = TextBox1.Text + "*"
        A = TextBox1.Text
        TextBox1.Text = ""
        pheptinh = "*"
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = (TextBox1.Text).Remove((TextBox1.Text).Length - 1, 1)
        Else
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub btnChamThan_Click(sender As Object, e As EventArgs) Handles btnChamThan.Click
        A = TextBox1.Text
        TextBox2.Text = TextBox1.Text + "!"
        kq = 1
        For i As Integer = 1 To A
            kq *= i
        Next
        TextBox1.Text = kq
    End Sub

    Private Sub btnsin_Click(sender As Object, e As EventArgs) Handles btnsin.Click
        TextBox2.Text = "sin("
        pheptinh = "sin"
        TextBox1.Text = ""
    End Sub

    Private Sub btncos_Click(sender As Object, e As EventArgs) Handles btncos.Click
        TextBox2.Text = "cos("
        pheptinh = "cos"
        TextBox1.Text = ""
    End Sub

    Private Sub btncb2_Click(sender As Object, e As EventArgs) Handles btncb2.Click
        TextBox2.Text = "sqrt("
        pheptinh = "sqrt"
        TextBox1.Text = ""
    End Sub

    Private Sub btnabs_Click(sender As Object, e As EventArgs) Handles btnabs.Click
        TextBox2.Text = "abs("
        pheptinh = "abs"
        TextBox1.Text = ""
    End Sub

    Private Sub btnMOD_Click(sender As Object, e As EventArgs) Handles btnMOD.Click

        TextBox2.Text = TextBox1.Text + " MOD "
        A = TextBox1.Text
        TextBox1.Text = ""
        pheptinh = "MOD"
    End Sub

    Private Sub btnpow_Click(sender As Object, e As EventArgs) Handles btnpow.Click
        TextBox2.Text = TextBox1.Text + "^"
        A = TextBox1.Text
        TextBox1.Text = ""
        pheptinh = "^"
    End Sub

    Private Sub btnchia_Click(sender As Object, e As EventArgs) Handles btnchia.Click
        TextBox2.Text = TextBox1.Text + "/"
        A = TextBox1.Text
        TextBox1.Text = ""
        pheptinh = "/"
    End Sub
    Private Sub btnbang_Click(sender As Object, e As EventArgs) Handles btnbang.Click
        B = TextBox1.Text
        TextBox2.Text += TextBox1.Text + "="
        If pheptinh = "+" Then
            kq = A + B
            TextBox1.Text = kq
        ElseIf pheptinh = "-" Then
            kq = A - B
            TextBox1.Text = kq
        ElseIf pheptinh = "*" Then
            kq = A * B
            TextBox1.Text = kq
        ElseIf pheptinh = "/" And B = 0 Then
            TextBox1.Text = "không chia được cho 0"
        ElseIf pheptinh = "/" And B <> 0 Then
            kq = A / B
            TextBox1.Text = kq
        ElseIf pheptinh = "MOD" Then
            kq = A Mod B
            TextBox1.Text = kq
        ElseIf pheptinh = "^" Then
            kq = A ^ B
            TextBox1.Text = kq
        ElseIf pheptinh = "sin" Then
            Dim radians As Double = B * Math.PI / 180.0
            kq = Math.Sin(radians)
            TextBox1.Text = kq
        ElseIf pheptinh = "cos" Then
            Dim radians As Double = B * Math.PI / 180.0
            kq = Math.Cos(radians)
            TextBox1.Text = kq
        ElseIf pheptinh = "sqrt" Then
            kq = Math.Sqrt(B)
            TextBox1.Text = kq
        ElseIf pheptinh = "abs" Then
            kq = Math.Abs(B)
            TextBox1.Text = kq

        End If


    End Sub

    Private Sub btnCham_Click(sender As Object, e As EventArgs) Handles btnCham.Click
        Dim check As String = True
        For i As Integer = 0 To (TextBox1.Text).Length - 1
            If (TextBox1.Text).Chars(i) = "." Then
                check = False
            End If
        Next
        If check = True Then
            TextBox1.Text += "."
        End If
    End Sub
End Class
