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
        Me.btn_load = New System.Windows.Forms.Button()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_load
        '
        Me.btn_load.Location = New System.Drawing.Point(271, 229)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(162, 53)
        Me.btn_load.TabIndex = 0
        Me.btn_load.Text = "LOAD"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(95, 12)
        Me.txtbox1.Multiline = True
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(521, 198)
        Me.txtbox1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.btn_load)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_load As Button
    Friend WithEvents txtbox1 As TextBox
End Class
