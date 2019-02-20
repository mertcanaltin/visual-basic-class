<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SayiTextBox1 = New System.Windows.Forms.TextBox()
        Me.UstTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HesaplaButton1 = New System.Windows.Forms.Button()
        Me.SonucTextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "sayi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Üst"
        '
        'SayiTextBox1
        '
        Me.SayiTextBox1.Location = New System.Drawing.Point(22, 44)
        Me.SayiTextBox1.Name = "SayiTextBox1"
        Me.SayiTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SayiTextBox1.TabIndex = 2
        '
        'UstTextBox2
        '
        Me.UstTextBox2.Location = New System.Drawing.Point(128, 44)
        Me.UstTextBox2.Name = "UstTextBox2"
        Me.UstTextBox2.Size = New System.Drawing.Size(35, 20)
        Me.UstTextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sonuç"
        '
        'HesaplaButton1
        '
        Me.HesaplaButton1.Location = New System.Drawing.Point(22, 70)
        Me.HesaplaButton1.Name = "HesaplaButton1"
        Me.HesaplaButton1.Size = New System.Drawing.Size(141, 49)
        Me.HesaplaButton1.TabIndex = 5
        Me.HesaplaButton1.Text = "Hesapla"
        Me.HesaplaButton1.UseVisualStyleBackColor = True
        '
        'SonucTextBox3
        '
        Me.SonucTextBox3.Location = New System.Drawing.Point(22, 138)
        Me.SonucTextBox3.Name = "SonucTextBox3"
        Me.SonucTextBox3.Size = New System.Drawing.Size(141, 20)
        Me.SonucTextBox3.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 173)
        Me.Controls.Add(Me.SonucTextBox3)
        Me.Controls.Add(Me.HesaplaButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UstTextBox2)
        Me.Controls.Add(Me.SayiTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Üst Al lan v1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SayiTextBox1 As TextBox
    Friend WithEvents UstTextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HesaplaButton1 As Button
    Friend WithEvents SonucTextBox3 As TextBox
End Class
