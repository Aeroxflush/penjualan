<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt_nomortelp = New System.Windows.Forms.TextBox()
        Me.txt_namaPelangg = New System.Windows.Forms.TextBox()
        Me.txt_idPelangg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_tutup
        '
        Me.btn_tutup.Location = New System.Drawing.Point(364, 212)
        Me.btn_tutup.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(100, 28)
        Me.btn_tutup.TabIndex = 16
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(256, 212)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(100, 28)
        Me.btn_hapus.TabIndex = 17
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(148, 212)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(100, 28)
        Me.btn_edit.TabIndex = 18
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(40, 212)
        Me.btn_input.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(100, 28)
        Me.btn_input.TabIndex = 19
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(13, 266)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.Size = New System.Drawing.Size(774, 320)
        Me.dgv.TabIndex = 15
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(160, 157)
        Me.txt_alamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(191, 22)
        Me.txt_alamat.TabIndex = 10
        '
        'txt_nomortelp
        '
        Me.txt_nomortelp.Location = New System.Drawing.Point(160, 119)
        Me.txt_nomortelp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomortelp.Name = "txt_nomortelp"
        Me.txt_nomortelp.Size = New System.Drawing.Size(191, 22)
        Me.txt_nomortelp.TabIndex = 11
        '
        'txt_namaPelangg
        '
        Me.txt_namaPelangg.Location = New System.Drawing.Point(160, 81)
        Me.txt_namaPelangg.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_namaPelangg.Name = "txt_namaPelangg"
        Me.txt_namaPelangg.Size = New System.Drawing.Size(191, 22)
        Me.txt_namaPelangg.TabIndex = 12
        '
        'txt_idPelangg
        '
        Me.txt_idPelangg.Location = New System.Drawing.Point(160, 43)
        Me.txt_idPelangg.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_idPelangg.Name = "txt_idPelangg"
        Me.txt_idPelangg.Size = New System.Drawing.Size(191, 22)
        Me.txt_idPelangg.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 161)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nomor Telepon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID Pelanggan"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 599)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_nomortelp)
        Me.Controls.Add(Me.txt_namaPelangg)
        Me.Controls.Add(Me.txt_idPelangg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_tutup As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt_nomortelp As TextBox
    Friend WithEvents txt_namaPelangg As TextBox
    Friend WithEvents txt_idPelangg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
