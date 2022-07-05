<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIDJual = New System.Windows.Forms.Label()
        Me.lblIDKasir = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblNamaKasir = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblJumlahMenu = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.LVPenjualan = New System.Windows.Forms.ListView()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNamaMenu = New System.Windows.Forms.TextBox()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCariMenu = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Jual :"
        '
        'lblIDJual
        '
        Me.lblIDJual.AutoSize = True
        Me.lblIDJual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIDJual.Location = New System.Drawing.Point(65, 46)
        Me.lblIDJual.Name = "lblIDJual"
        Me.lblIDJual.Size = New System.Drawing.Size(14, 15)
        Me.lblIDJual.TabIndex = 9
        Me.lblIDJual.Text = "x"
        '
        'lblIDKasir
        '
        Me.lblIDKasir.AutoSize = True
        Me.lblIDKasir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIDKasir.Location = New System.Drawing.Point(203, 46)
        Me.lblIDKasir.Name = "lblIDKasir"
        Me.lblIDKasir.Size = New System.Drawing.Size(14, 15)
        Me.lblIDKasir.TabIndex = 11
        Me.lblIDKasir.Text = "x"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(150, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "ID Kasir :"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTanggal.Location = New System.Drawing.Point(310, 9)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(14, 15)
        Me.lblTanggal.TabIndex = 13
        Me.lblTanggal.Text = "x"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(223, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Hari/Tanggal :"
        '
        'lblNamaKasir
        '
        Me.lblNamaKasir.AutoSize = True
        Me.lblNamaKasir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNamaKasir.Location = New System.Drawing.Point(223, 81)
        Me.lblNamaKasir.Name = "lblNamaKasir"
        Me.lblNamaKasir.Size = New System.Drawing.Size(14, 15)
        Me.lblNamaKasir.TabIndex = 15
        Me.lblNamaKasir.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(150, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama Kasir"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(342, 55)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(25, 31)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "x"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(256, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 31)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.txtKembali)
        Me.GroupBox1.Controls.Add(Me.txtBayar)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lblJumlahMenu)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.LVPenjualan)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtNamaMenu)
        Me.GroupBox1.Controls.Add(Me.txtIDMenu)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCariMenu)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 304)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputkan Pesanan"
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(228, 269)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(83, 23)
        Me.txtKembali.TabIndex = 34
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(228, 240)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(83, 23)
        Me.txtBayar.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(156, 269)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 18)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Kembali"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(156, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 18)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Bayar"
        '
        'lblJumlahMenu
        '
        Me.lblJumlahMenu.AutoSize = True
        Me.lblJumlahMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblJumlahMenu.Location = New System.Drawing.Point(124, 223)
        Me.lblJumlahMenu.Name = "lblJumlahMenu"
        Me.lblJumlahMenu.Size = New System.Drawing.Size(14, 15)
        Me.lblJumlahMenu.TabIndex = 30
        Me.lblJumlahMenu.Text = "x"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(37, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Jumlah Menu :"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnHapus.BackgroundImage = CType(resources.GetObject("btnHapus.BackgroundImage"), System.Drawing.Image)
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(333, 164)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(45, 43)
        Me.btnHapus.TabIndex = 28
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnTambah.BackgroundImage = CType(resources.GetObject("btnTambah.BackgroundImage"), System.Drawing.Image)
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(333, 115)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(45, 43)
        Me.btnTambah.TabIndex = 27
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'LVPenjualan
        '
        Me.LVPenjualan.Location = New System.Drawing.Point(6, 115)
        Me.LVPenjualan.Name = "LVPenjualan"
        Me.LVPenjualan.Size = New System.Drawing.Size(321, 92)
        Me.LVPenjualan.TabIndex = 26
        Me.LVPenjualan.UseCompatibleStateImageBehavior = False
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(90, 86)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(83, 23)
        Me.txtJumlah.TabIndex = 25
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(90, 57)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(83, 23)
        Me.txtHarga.TabIndex = 24
        '
        'txtNamaMenu
        '
        Me.txtNamaMenu.Location = New System.Drawing.Point(179, 28)
        Me.txtNamaMenu.Name = "txtNamaMenu"
        Me.txtNamaMenu.Size = New System.Drawing.Size(162, 23)
        Me.txtNamaMenu.TabIndex = 23
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(90, 28)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(83, 23)
        Me.txtIDMenu.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(6, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Harga"
        '
        'btnCariMenu
        '
        Me.btnCariMenu.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCariMenu.FlatAppearance.BorderSize = 0
        Me.btnCariMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCariMenu.Location = New System.Drawing.Point(6, 22)
        Me.btnCariMenu.Name = "btnCariMenu"
        Me.btnCariMenu.Size = New System.Drawing.Size(75, 32)
        Me.btnCariMenu.TabIndex = 19
        Me.btnCariMenu.Text = "Cari Menu"
        Me.btnCariMenu.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSimpan.BackgroundImage = CType(resources.GetObject("btnSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Location = New System.Drawing.Point(330, 249)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(45, 43)
        Me.btnSimpan.TabIndex = 35
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 425)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNamaKasir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblIDKasir)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblIDJual)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Penjualan"
        Me.Text = "Form Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblIDJual As Label
    Friend WithEvents lblIDKasir As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblNamaKasir As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LVPenjualan As ListView
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNamaMenu As TextBox
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCariMenu As Button
    Friend WithEvents lblJumlahMenu As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSimpan As Button
End Class
