﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoDestino
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
        Me.Bnt_add = New System.Windows.Forms.Button()
        Me.Lb_NombreDestino = New System.Windows.Forms.Label()
        Me.Txt_NombreDestino = New System.Windows.Forms.TextBox()
        Me.Lb_CodigoDestino = New System.Windows.Forms.Label()
        Me.Txt_CodigoDestino = New System.Windows.Forms.TextBox()
        Me.Dgv_ListaDestinos = New System.Windows.Forms.DataGridView()
        CType(Me.Dgv_ListaDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bnt_add
        '
        Me.Bnt_add.Location = New System.Drawing.Point(97, 190)
        Me.Bnt_add.Name = "Bnt_add"
        Me.Bnt_add.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_add.TabIndex = 0
        Me.Bnt_add.Text = "Agregar"
        Me.Bnt_add.UseVisualStyleBackColor = True
        '
        'Lb_NombreDestino
        '
        Me.Lb_NombreDestino.AutoSize = True
        Me.Lb_NombreDestino.Location = New System.Drawing.Point(29, 73)
        Me.Lb_NombreDestino.Name = "Lb_NombreDestino"
        Me.Lb_NombreDestino.Size = New System.Drawing.Size(86, 13)
        Me.Lb_NombreDestino.TabIndex = 1
        Me.Lb_NombreDestino.Text = "Nombre Destino:"
        '
        'Txt_NombreDestino
        '
        Me.Txt_NombreDestino.Location = New System.Drawing.Point(128, 70)
        Me.Txt_NombreDestino.Name = "Txt_NombreDestino"
        Me.Txt_NombreDestino.Size = New System.Drawing.Size(124, 20)
        Me.Txt_NombreDestino.TabIndex = 2
        '
        'Lb_CodigoDestino
        '
        Me.Lb_CodigoDestino.AutoSize = True
        Me.Lb_CodigoDestino.Location = New System.Drawing.Point(27, 125)
        Me.Lb_CodigoDestino.Name = "Lb_CodigoDestino"
        Me.Lb_CodigoDestino.Size = New System.Drawing.Size(82, 13)
        Me.Lb_CodigoDestino.TabIndex = 3
        Me.Lb_CodigoDestino.Text = "Codigo Destino:"
        '
        'Txt_CodigoDestino
        '
        Me.Txt_CodigoDestino.Location = New System.Drawing.Point(128, 122)
        Me.Txt_CodigoDestino.Name = "Txt_CodigoDestino"
        Me.Txt_CodigoDestino.Size = New System.Drawing.Size(124, 20)
        Me.Txt_CodigoDestino.TabIndex = 4
        '
        'Dgv_ListaDestinos
        '
        Me.Dgv_ListaDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaDestinos.Location = New System.Drawing.Point(311, 36)
        Me.Dgv_ListaDestinos.Name = "Dgv_ListaDestinos"
        Me.Dgv_ListaDestinos.Size = New System.Drawing.Size(398, 177)
        Me.Dgv_ListaDestinos.TabIndex = 5
        '
        'FrmNuevoDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 262)
        Me.Controls.Add(Me.Dgv_ListaDestinos)
        Me.Controls.Add(Me.Txt_CodigoDestino)
        Me.Controls.Add(Me.Lb_CodigoDestino)
        Me.Controls.Add(Me.Txt_NombreDestino)
        Me.Controls.Add(Me.Lb_NombreDestino)
        Me.Controls.Add(Me.Bnt_add)
        Me.Name = "FrmNuevoDestino"
        Me.Text = "FrmNuevoDestino"
        CType(Me.Dgv_ListaDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bnt_add As System.Windows.Forms.Button
    Friend WithEvents Lb_NombreDestino As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreDestino As System.Windows.Forms.TextBox
    Friend WithEvents Lb_CodigoDestino As System.Windows.Forms.Label
    Friend WithEvents Txt_CodigoDestino As System.Windows.Forms.TextBox
    Friend WithEvents Dgv_ListaDestinos As System.Windows.Forms.DataGridView
End Class
