<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DGMenu = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Menu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Menu"
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(95, 9)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(179, 23)
        Me.txtIDMenu.TabIndex = 4
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(222, 38)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(52, 23)
        Me.txtKategori.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(95, 67)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(179, 23)
        Me.txtNama.TabIndex = 6
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(95, 96)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(179, 23)
        Me.txtHarga.TabIndex = 7
        '
        'cmbKategori
        '
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(95, 38)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(121, 23)
        Me.cmbKategori.TabIndex = 8
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnHapus.BackgroundImage = CType(resources.GetObject("btnHapus.BackgroundImage"), System.Drawing.Image)
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(297, 206)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(45, 43)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnBatal.BackgroundImage = CType(resources.GetObject("btnBatal.BackgroundImage"), System.Drawing.Image)
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Location = New System.Drawing.Point(297, 157)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(45, 43)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSimpan.BackgroundImage = CType(resources.GetObject("btnSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Location = New System.Drawing.Point(297, 108)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(45, 43)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUbah.BackgroundImage = CType(resources.GetObject("btnUbah.BackgroundImage"), System.Drawing.Image)
        Me.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUbah.FlatAppearance.BorderSize = 0
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Location = New System.Drawing.Point(297, 59)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(45, 43)
        Me.btnUbah.TabIndex = 10
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnTambah.BackgroundImage = CType(resources.GetObject("btnTambah.BackgroundImage"), System.Drawing.Image)
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(297, 9)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(45, 43)
        Me.btnTambah.TabIndex = 9
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 59)
        Me.GroupBox1.TabIndex = 14
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
        'DGMenu
        '
        Me.DGMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMenu.Location = New System.Drawing.Point(12, 212)
        Me.DGMenu.Name = "DGMenu"
        Me.DGMenu.RowTemplate.Height = 25
        Me.DGMenu.Size = New System.Drawing.Size(262, 110)
        Me.DGMenu.TabIndex = 15
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 333)
        Me.Controls.Add(Me.DGMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cmbKategori)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.txtIDMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Menu"
        Me.Text = "Form Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents DGMenu As DataGridView
End Class
