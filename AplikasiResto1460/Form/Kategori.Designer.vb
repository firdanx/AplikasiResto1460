<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kategori
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kategori))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDKategori = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DGKategori = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Kategori"
        '
        'txtIDKategori
        '
        Me.txtIDKategori.Location = New System.Drawing.Point(126, 11)
        Me.txtIDKategori.Name = "txtIDKategori"
        Me.txtIDKategori.Size = New System.Drawing.Size(147, 23)
        Me.txtIDKategori.TabIndex = 2
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(126, 56)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(147, 23)
        Me.txtNama.TabIndex = 3
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnTambah.BackgroundImage = CType(resources.GetObject("btnTambah.BackgroundImage"), System.Drawing.Image)
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(349, 10)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(45, 43)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUbah.BackgroundImage = CType(resources.GetObject("btnUbah.BackgroundImage"), System.Drawing.Image)
        Me.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUbah.FlatAppearance.BorderSize = 0
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Location = New System.Drawing.Point(349, 60)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(45, 43)
        Me.btnUbah.TabIndex = 5
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSimpan.BackgroundImage = CType(resources.GetObject("btnSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Location = New System.Drawing.Point(349, 109)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(45, 43)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnBatal.BackgroundImage = CType(resources.GetObject("btnBatal.BackgroundImage"), System.Drawing.Image)
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Location = New System.Drawing.Point(349, 158)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(45, 43)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnHapus.BackgroundImage = CType(resources.GetObject("btnHapus.BackgroundImage"), System.Drawing.Image)
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(349, 207)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(45, 43)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 59)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan Nama Kategori yang di cari"
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCari.BackgroundImage = CType(resources.GetObject("btnCari.BackgroundImage"), System.Drawing.Image)
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Location = New System.Drawing.Point(194, 22)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(30, 31)
        Me.btnCari.TabIndex = 11
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(6, 27)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(182, 23)
        Me.txtCari.TabIndex = 10
        '
        'DGKategori
        '
        Me.DGKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKategori.Location = New System.Drawing.Point(12, 174)
        Me.DGKategori.Name = "DGKategori"
        Me.DGKategori.RowTemplate.Height = 25
        Me.DGKategori.Size = New System.Drawing.Size(307, 108)
        Me.DGKategori.TabIndex = 10
        '
        'Kategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(407, 293)
        Me.Controls.Add(Me.DGKategori)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtIDKategori)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Kategori"
        Me.Text = "Form Kategori"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDKategori As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents DGKategori As DataGridView
End Class
