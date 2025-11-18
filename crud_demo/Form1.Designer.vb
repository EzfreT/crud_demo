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
        Me.bttnConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnConnect
        '
        Me.bttnConnect.Location = New System.Drawing.Point(12, 12)
        Me.bttnConnect.Name = "bttnConnect"
        Me.bttnConnect.Size = New System.Drawing.Size(199, 102)
        Me.bttnConnect.TabIndex = 0
        Me.bttnConnect.Text = "Connect my SQL"
        Me.bttnConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(104, 141)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(341, 20)
        Me.TextBoxName.TabIndex = 2
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(104, 178)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(341, 20)
        Me.TextBoxAge.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(104, 214)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(341, 20)
        Me.TextBoxEmail.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 38)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Emal:"
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(12, 258)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(154, 48)
        Me.ButtonInsert.TabIndex = 7
        Me.ButtonInsert.Text = "Insert Data"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 629)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonInsert As Button
End Class
