<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fdetalles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgd = New System.Windows.Forms.DataGridView()
        Me.Modificar = New System.Windows.Forms.Button()
        CType(Me.dgd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgd
        '
        Me.dgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgd.Location = New System.Drawing.Point(59, 26)
        Me.dgd.Name = "dgd"
        Me.dgd.Size = New System.Drawing.Size(668, 312)
        Me.dgd.TabIndex = 0
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.ForeColor = System.Drawing.Color.White
        Me.Modificar.Location = New System.Drawing.Point(329, 344)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(105, 46)
        Me.Modificar.TabIndex = 15
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(795, 392)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.dgd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgd As DataGridView
    Friend WithEvents Modificar As Button
End Class
