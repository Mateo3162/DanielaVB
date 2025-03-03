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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(17, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(638, 372)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Leelawadee", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton1.ForeColor = SystemColors.Desktop
        RadioButton1.Location = New Point(17, 407)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(49, 31)
        RadioButton1.TabIndex = 1
        RadioButton1.Text = "A"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Leelawadee", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton2.Location = New Point(72, 407)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(48, 31)
        RadioButton2.TabIndex = 2
        RadioButton2.Text = "B"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Leelawadee", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton3.Location = New Point(127, 407)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(47, 31)
        RadioButton3.TabIndex = 3
        RadioButton3.Text = "C"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Leelawadee", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton4.Location = New Point(182, 407)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(50, 31)
        RadioButton4.TabIndex = 4
        RadioButton4.Text = "D"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Leelawadee", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(661, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 20)
        Label1.TabIndex = 5
        Label1.Text = "Nro. Pregunta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Leelawadee", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(713, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 20)
        Label2.TabIndex = 6
        Label2.Text = "0"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Leelawadee", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(670, 197)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 47)
        Button2.TabIndex = 8
        Button2.Text = "Evaluar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Leelawadee", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(670, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 47)
        Button1.TabIndex = 9
        Button1.Text = "Siguiente"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(368, 412)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 24)
        Label3.TabIndex = 10
        Label3.Text = "Correctas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(473, 412)
        Label4.Name = "Label4"
        Label4.Size = New Size(22, 24)
        Label4.TabIndex = 11
        Label4.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(621, 412)
        Label5.Name = "Label5"
        Label5.Size = New Size(22, 24)
        Label5.TabIndex = 13
        Label5.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(500, 412)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 24)
        Label6.TabIndex = 12
        Label6.Text = "Incorrectas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Evaluación Tipo ICFES"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents Label2 As Label
End Class
