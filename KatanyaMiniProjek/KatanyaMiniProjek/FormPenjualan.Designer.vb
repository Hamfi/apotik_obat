<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.dgvDataPenjualan = New System.Windows.Forms.DataGridView()
        Me.tbSearchPenjualan = New System.Windows.Forms.TextBox()
        Me.btSearchPenjualan = New System.Windows.Forms.Button()
        Me.btDeletePenjualan = New System.Windows.Forms.Button()
        Me.btUpdatePenjualan = New System.Windows.Forms.Button()
        Me.btCreatePenjualan = New System.Windows.Forms.Button()
        Me.gbDataPenjualan = New System.Windows.Forms.GroupBox()
        Me.tbTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpTanggalPenjualan = New System.Windows.Forms.DateTimePicker()
        Me.tbJumlahObat = New System.Windows.Forms.TextBox()
        Me.tbHargaObat = New System.Windows.Forms.TextBox()
        Me.tbIdKustomer = New System.Windows.Forms.TextBox()
        Me.tbIdObat = New System.Windows.Forms.TextBox()
        Me.tbIdPenjualan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataObatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvDataPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDataPenjualan.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDataPenjualan
        '
        Me.dgvDataPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataPenjualan.Location = New System.Drawing.Point(104, 421)
        Me.dgvDataPenjualan.Name = "dgvDataPenjualan"
        Me.dgvDataPenjualan.RowHeadersWidth = 51
        Me.dgvDataPenjualan.RowTemplate.Height = 24
        Me.dgvDataPenjualan.Size = New System.Drawing.Size(968, 296)
        Me.dgvDataPenjualan.TabIndex = 32
        '
        'tbSearchPenjualan
        '
        Me.tbSearchPenjualan.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchPenjualan.Location = New System.Drawing.Point(744, 361)
        Me.tbSearchPenjualan.Multiline = True
        Me.tbSearchPenjualan.Name = "tbSearchPenjualan"
        Me.tbSearchPenjualan.Size = New System.Drawing.Size(322, 45)
        Me.tbSearchPenjualan.TabIndex = 31
        '
        'btSearchPenjualan
        '
        Me.btSearchPenjualan.BackColor = System.Drawing.Color.Teal
        Me.btSearchPenjualan.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchPenjualan.ForeColor = System.Drawing.Color.White
        Me.btSearchPenjualan.Location = New System.Drawing.Point(622, 361)
        Me.btSearchPenjualan.Name = "btSearchPenjualan"
        Me.btSearchPenjualan.Size = New System.Drawing.Size(100, 45)
        Me.btSearchPenjualan.TabIndex = 30
        Me.btSearchPenjualan.Text = "SEARCH"
        Me.btSearchPenjualan.UseVisualStyleBackColor = False
        '
        'btDeletePenjualan
        '
        Me.btDeletePenjualan.BackColor = System.Drawing.Color.Teal
        Me.btDeletePenjualan.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDeletePenjualan.ForeColor = System.Drawing.Color.White
        Me.btDeletePenjualan.Location = New System.Drawing.Point(454, 361)
        Me.btDeletePenjualan.Name = "btDeletePenjualan"
        Me.btDeletePenjualan.Size = New System.Drawing.Size(100, 45)
        Me.btDeletePenjualan.TabIndex = 29
        Me.btDeletePenjualan.Text = "DELETE"
        Me.btDeletePenjualan.UseVisualStyleBackColor = False
        '
        'btUpdatePenjualan
        '
        Me.btUpdatePenjualan.BackColor = System.Drawing.Color.Teal
        Me.btUpdatePenjualan.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdatePenjualan.ForeColor = System.Drawing.Color.White
        Me.btUpdatePenjualan.Location = New System.Drawing.Point(279, 361)
        Me.btUpdatePenjualan.Name = "btUpdatePenjualan"
        Me.btUpdatePenjualan.Size = New System.Drawing.Size(100, 45)
        Me.btUpdatePenjualan.TabIndex = 28
        Me.btUpdatePenjualan.Text = "UPDATE"
        Me.btUpdatePenjualan.UseVisualStyleBackColor = False
        '
        'btCreatePenjualan
        '
        Me.btCreatePenjualan.BackColor = System.Drawing.Color.Teal
        Me.btCreatePenjualan.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCreatePenjualan.ForeColor = System.Drawing.Color.White
        Me.btCreatePenjualan.Location = New System.Drawing.Point(104, 361)
        Me.btCreatePenjualan.Name = "btCreatePenjualan"
        Me.btCreatePenjualan.Size = New System.Drawing.Size(100, 45)
        Me.btCreatePenjualan.TabIndex = 27
        Me.btCreatePenjualan.Text = "CREATE"
        Me.btCreatePenjualan.UseVisualStyleBackColor = False
        '
        'gbDataPenjualan
        '
        Me.gbDataPenjualan.BackColor = System.Drawing.Color.Transparent
        Me.gbDataPenjualan.Controls.Add(Me.tbTotalHarga)
        Me.gbDataPenjualan.Controls.Add(Me.Label6)
        Me.gbDataPenjualan.Controls.Add(Me.dtpTanggalPenjualan)
        Me.gbDataPenjualan.Controls.Add(Me.tbJumlahObat)
        Me.gbDataPenjualan.Controls.Add(Me.tbHargaObat)
        Me.gbDataPenjualan.Controls.Add(Me.tbIdKustomer)
        Me.gbDataPenjualan.Controls.Add(Me.tbIdObat)
        Me.gbDataPenjualan.Controls.Add(Me.tbIdPenjualan)
        Me.gbDataPenjualan.Controls.Add(Me.Label10)
        Me.gbDataPenjualan.Controls.Add(Me.Label8)
        Me.gbDataPenjualan.Controls.Add(Me.Label7)
        Me.gbDataPenjualan.Controls.Add(Me.Label5)
        Me.gbDataPenjualan.Controls.Add(Me.Label4)
        Me.gbDataPenjualan.Controls.Add(Me.Label3)
        Me.gbDataPenjualan.ForeColor = System.Drawing.Color.White
        Me.gbDataPenjualan.Location = New System.Drawing.Point(104, 142)
        Me.gbDataPenjualan.Name = "gbDataPenjualan"
        Me.gbDataPenjualan.Size = New System.Drawing.Size(962, 207)
        Me.gbDataPenjualan.TabIndex = 26
        Me.gbDataPenjualan.TabStop = False
        Me.gbDataPenjualan.Text = "Penjualan"
        '
        'tbTotalHarga
        '
        Me.tbTotalHarga.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalHarga.Location = New System.Drawing.Point(640, 111)
        Me.tbTotalHarga.Name = "tbTotalHarga"
        Me.tbTotalHarga.Size = New System.Drawing.Size(154, 29)
        Me.tbTotalHarga.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(522, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Total Harga"
        '
        'dtpTanggalPenjualan
        '
        Me.dtpTanggalPenjualan.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggalPenjualan.Location = New System.Drawing.Point(163, 152)
        Me.dtpTanggalPenjualan.Name = "dtpTanggalPenjualan"
        Me.dtpTanggalPenjualan.Size = New System.Drawing.Size(287, 29)
        Me.dtpTanggalPenjualan.TabIndex = 20
        '
        'tbJumlahObat
        '
        Me.tbJumlahObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlahObat.Location = New System.Drawing.Point(640, 26)
        Me.tbJumlahObat.Name = "tbJumlahObat"
        Me.tbJumlahObat.Size = New System.Drawing.Size(154, 29)
        Me.tbJumlahObat.TabIndex = 19
        '
        'tbHargaObat
        '
        Me.tbHargaObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHargaObat.Location = New System.Drawing.Point(640, 68)
        Me.tbHargaObat.Name = "tbHargaObat"
        Me.tbHargaObat.Size = New System.Drawing.Size(154, 29)
        Me.tbHargaObat.TabIndex = 18
        '
        'tbIdKustomer
        '
        Me.tbIdKustomer.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdKustomer.Location = New System.Drawing.Point(163, 110)
        Me.tbIdKustomer.Name = "tbIdKustomer"
        Me.tbIdKustomer.Size = New System.Drawing.Size(287, 29)
        Me.tbIdKustomer.TabIndex = 14
        '
        'tbIdObat
        '
        Me.tbIdObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdObat.Location = New System.Drawing.Point(163, 67)
        Me.tbIdObat.Name = "tbIdObat"
        Me.tbIdObat.Size = New System.Drawing.Size(287, 29)
        Me.tbIdObat.TabIndex = 13
        '
        'tbIdPenjualan
        '
        Me.tbIdPenjualan.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdPenjualan.Location = New System.Drawing.Point(163, 27)
        Me.tbIdPenjualan.Name = "tbIdPenjualan"
        Me.tbIdPenjualan.Size = New System.Drawing.Size(154, 29)
        Me.tbIdPenjualan.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(522, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(522, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(50, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(50, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ID Kustomer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(50, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(50, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Penjualan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dosis", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(476, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 42)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Apotek Sehat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(345, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(570, 81)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Data Penjualan"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 28)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataObatToolStripMenuItem1, Me.DataKustomerToolStripMenuItem1, Me.DataPenjualanToolStripMenuItem1, Me.DataSupplierToolStripMenuItem1})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Dosis", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENUToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'DataObatToolStripMenuItem1
        '
        Me.DataObatToolStripMenuItem1.Name = "DataObatToolStripMenuItem1"
        Me.DataObatToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DataObatToolStripMenuItem1.Text = "Data Obat"
        '
        'DataKustomerToolStripMenuItem1
        '
        Me.DataKustomerToolStripMenuItem1.Name = "DataKustomerToolStripMenuItem1"
        Me.DataKustomerToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DataKustomerToolStripMenuItem1.Text = "Data Kustomer"
        '
        'DataPenjualanToolStripMenuItem1
        '
        Me.DataPenjualanToolStripMenuItem1.Name = "DataPenjualanToolStripMenuItem1"
        Me.DataPenjualanToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DataPenjualanToolStripMenuItem1.Text = "Data Penjualan"
        '
        'DataSupplierToolStripMenuItem1
        '
        Me.DataSupplierToolStripMenuItem1.Name = "DataSupplierToolStripMenuItem1"
        Me.DataSupplierToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DataSupplierToolStripMenuItem1.Text = "Data Supplier"
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KatanyaMiniProjek.My.Resources.Resources._8767047
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvDataPenjualan)
        Me.Controls.Add(Me.tbSearchPenjualan)
        Me.Controls.Add(Me.btSearchPenjualan)
        Me.Controls.Add(Me.btDeletePenjualan)
        Me.Controls.Add(Me.btUpdatePenjualan)
        Me.Controls.Add(Me.btCreatePenjualan)
        Me.Controls.Add(Me.gbDataPenjualan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        CType(Me.dgvDataPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDataPenjualan.ResumeLayout(False)
        Me.gbDataPenjualan.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDataPenjualan As DataGridView
    Friend WithEvents tbSearchPenjualan As TextBox
    Friend WithEvents btSearchPenjualan As Button
    Friend WithEvents btDeletePenjualan As Button
    Friend WithEvents btUpdatePenjualan As Button
    Friend WithEvents btCreatePenjualan As Button
    Friend WithEvents gbDataPenjualan As GroupBox
    Friend WithEvents dtpTanggalPenjualan As DateTimePicker
    Friend WithEvents tbJumlahObat As TextBox
    Friend WithEvents tbHargaObat As TextBox
    Friend WithEvents tbIdKustomer As TextBox
    Friend WithEvents tbIdObat As TextBox
    Friend WithEvents tbIdPenjualan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTotalHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataObatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataKustomerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem1 As ToolStripMenuItem
End Class
