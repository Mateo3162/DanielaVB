Public Class Form1
    Dim Contador As Integer, CPC As Integer, CPI As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Contador = 0
        Label2.Text = CStr(Contador)
        RadioButton1.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Contador = Contador + 1
        Label2.Text = CStr(Contador)
        Select Case Contador
            Case 1
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\1.png")
            Case 2
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\2.png")
            Case 3
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\3.png")
            Case 4
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\4.png")
            Case 5
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\5.png")
            Case 6
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\6.png")
            Case 7
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\7.png")
            Case 8
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\8.png")
            Case 9
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\9.png")
            Case 10
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\10.png")
            Case 11
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\11.png")
            Case 12
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\12.png")
            Case 13
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\13.png")
            Case 14
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\14.png")
            Case 15
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\15.png")
            Case 16
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\16.png")
            Case 17
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\17.png")
            Case 18
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\18.png")
            Case 19
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\19.png")
            Case 20
                PictureBox1.Image = Image.FromFile("C:\Users\matel\Downloads\Daniela VB\Cuadernillo JPGs\20.png")
            Case Else
                MsgBox("No hay mas preguntas reina")
                Button1.Enabled = False
                Contador = Contador - 1
                Label2.Text = Contador
                Exit Sub
        End Select
        Button1.Enabled = False
        Button2.Enabled = True
        RadioButton1.ForeColor = Color.Black
        RadioButton2.ForeColor = Color.Black
        RadioButton3.ForeColor = Color.Black
        RadioButton4.ForeColor = Color.Black
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case Contador
            Case 1
                If RadioButton1.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton1.ForeColor = Color.Green
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 2
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label4.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton3.ForeColor = Color.Green
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 3
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton2.ForeColor = Color.Green
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 4
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton3.ForeColor = Color.Green
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 5
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton2.ForeColor = Color.Green
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 6
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton4.ForeColor = Color.Green
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 7
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton2.ForeColor = Color.Green
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 8
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton4.ForeColor = Color.Green
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 9
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton3.ForeColor = Color.Green
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 10
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton3.ForeColor = Color.Green
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 11
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton2.ForeColor = Color.Green
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 12
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton2.ForeColor = Color.Green
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 13
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton4.ForeColor = Color.Green
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 14
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton2.ForeColor = Color.Green
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 15
                If RadioButton1.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton1.ForeColor = Color.Green
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 16
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton4.ForeColor = Color.Green
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 17
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton2.ForeColor = Color.Green
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 18
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton4.ForeColor = Color.Green
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 19
                If RadioButton1.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton1.ForeColor = Color.Red
                ElseIf RadioButton2.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton2.ForeColor = Color.Green
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case 20
                If RadioButton1.Checked = True Then
                    CPC = CPC + 1
                    Label4.Text = CStr(CPC)
                    RadioButton1.ForeColor = Color.Green
                ElseIf RadioButton2.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton2.ForeColor = Color.Red
                ElseIf RadioButton3.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton3.ForeColor = Color.Red
                ElseIf RadioButton4.Checked = True Then
                    CPI = CPI + 1
                    Label5.Text = CStr(CPI)
                    RadioButton4.ForeColor = Color.Red
                Else
                    MsgBox("Debes seleccionar una opción de respuesta", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
        End Select
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub
End Class
