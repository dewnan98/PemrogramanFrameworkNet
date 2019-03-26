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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBoxCelcius = New System.Windows.Forms.TextBox()
        Me.TextBoxFarenheit = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errorMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBoxCelcius
        '
        Me.TextBoxCelcius.Location = New System.Drawing.Point(61, 248)
        Me.TextBoxCelcius.Name = "TextBoxCelcius"
        Me.TextBoxCelcius.Size = New System.Drawing.Size(255, 26)
        Me.TextBoxCelcius.TabIndex = 1
        '
        'TextBoxFarenheit
        '
        Me.TextBoxFarenheit.Location = New System.Drawing.Point(428, 248)
        Me.TextBoxFarenheit.Name = "TextBoxFarenheit"
        Me.TextBoxFarenheit.Size = New System.Drawing.Size(255, 26)
        Me.TextBoxFarenheit.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 48)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Konver Ke Celcius"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(61, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Konvert Ke Farenheit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 59)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "KONVERSI SUHU"
        '
        'errorMessage
        '
        Me.errorMessage.AutoSize = True
        Me.errorMessage.ForeColor = System.Drawing.Color.Crimson
        Me.errorMessage.Location = New System.Drawing.Point(339, 159)
        Me.errorMessage.Name = "errorMessage"
        Me.errorMessage.Size = New System.Drawing.Size(57, 20)
        Me.errorMessage.TabIndex = 6
        Me.errorMessage.Text = "Label2"
        Me.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.errorMessage.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.errorMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxFarenheit)
        Me.Controls.Add(Me.TextBoxCelcius)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBoxCelcius As TextBox
    Friend WithEvents TextBoxFarenheit As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents errorMessage As Label
End Class
