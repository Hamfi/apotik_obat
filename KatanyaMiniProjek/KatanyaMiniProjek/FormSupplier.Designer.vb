<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Me.dgvDataSupplier = New System.Windows.Forms.DataGridView()
        Me.tbSearchSupplier = New System.Windows.Forms.TextBox()
        Me.btSearchSupplier = New System.Windows.Forms.Button()
        Me.btDeleteSupplier = New System.Windows.Forms.Button()
        Me.btUpdateSupplier = New System.Windows.Forms.Button()
        Me.btCreateSupplier = New System.Windows.Forms.Button()
        Me.gbDataSupplier = New System.Windows.Forms.GroupBox()
        Me.tbKontakSupplier = New System.Windows.Forms.TextBox()
        Me.tbNamaSupplier = New System.Windows.Forms.TextBox()
        Me.tbIdSupplier = New System.Windows.Forms.TextBox()
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
        CType(Me.dgvDataSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDataSupplier.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDataSupplier
        '
        Me.dgvDataSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataSupplier.Location = New System.Drawing.Point(107, 429)
        Me.dgvDataSupplier.Name = "dgvDataSupplier"
        Me.dgvDataSupplier.RowHeadersWidth = 51
        Me.dgvDataSupplier.RowTemplate.Height = 24
        Me.dgvDataSupplier.Size = New System.Drawing.Size(968, 296)
        Me.dgvDataSupplier.TabIndex = 41
        '
        'tbSearchSupplier
        '
        Me.tbSearchSupplier.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchSupplier.Location = New System.Drawing.Point(747, 362)
        Me.tbSearchSupplier.Multiline = True
        Me.tbSearchSupplier.Name = "tbSearchSupplier"
        Me.tbSearchSupplier.Size = New System.Drawing.Size(322, 45)
        Me.tbSearchSupplier.TabIndex = 40
        '
        'btSearchSupplier
        '
        Me.btSearchSupplier.BackColor = System.Drawing.Color.Teal
        Me.btSearchSupplier.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchSupplier.ForeColor = System.Drawing.Color.White
        Me.btSearchSupplier.Location = New System.Drawing.Point(625, 362)
        Me.btSearchSupplier.Name = "btSearchSupplier"
        Me.btSearchSupplier.Size = New System.Drawing.Size(100, 45)
        Me.btSearchSupplier.TabIndex = 39
        Me.btSearchSupplier.Text = "SEARCH"
        Me.btSearchSupplier.UseVisualStyleBackColor = False
        '
        'btDeleteSupplier
        '
        Me.btDeleteSupplier.BackColor = System.Drawing.Color.Teal
        Me.btDeleteSupplier.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDeleteSupplier.ForeColor = System.Drawing.Color.White
        Me.btDeleteSupplier.Location = New System.Drawing.Point(457, 362)
        Me.btDeleteSupplier.Name = "btDeleteSupplier"
        Me.btDeleteSupplier.Size = New System.Drawing.Size(100, 45)
        Me.btDeleteSupplier.TabIndex = 38
        Me.btDeleteSupplier.Text = "DELETE"
        Me.btDeleteSupplier.UseVisualStyleBackColor = False
        '
        'btUpdateSupplier
        '
        Me.btUpdateSupplier.BackColor = System.Drawing.Color.Teal
        Me.btUpdateSupplier.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdateSupplier.ForeColor = System.Drawing.Color.White
        Me.btUpdateSupplier.Location = New System.Drawing.Point(282, 362)
        Me.btUpdateSupplier.Name = "btUpdateSupplier"
        Me.btUpdateSupplier.Size = New System.Drawing.Size(100, 45)
        Me.btUpdateSupplier.TabIndex = 37
        Me.btUpdateSupplier.Text = "UPDATE"
        Me.btUpdateSupplier.UseVisualStyleBackColor = False
        '
        'btCreateSupplier
        '
        Me.btCreateSupplier.BackColor = System.Drawing.Color.Teal
        Me.btCreateSupplier.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCreateSupplier.ForeColor = System.Drawing.Color.White
        Me.btCreateSupplier.Location = New System.Drawing.Point(107, 362)
        Me.btCreateSupplier.Name = "btCreateSupplier"
        Me.btCreateSupplier.Size = New System.Drawing.Size(100, 45)
        Me.btCreateSupplier.TabIndex = 36
        Me.btCreateSupplier.Text = "CREATE"
        Me.btCreateSupplier.UseVisualStyleBackColor = False
        '
        'gbDataSupplier
        '
        Me.gbDataSupplier.BackColor = System.Drawing.Color.Transparent
        Me.gbDataSupplier.Controls.Add(Me.tbKontakSupplier)
        Me.gbDataSupplier.Controls.Add(Me.tbNamaSupplier)
        Me.gbDataSupplier.Controls.Add(Me.tbIdSupplier)
        Me.gbDataSupplier.Controls.Add(Me.Label5)
        Me.gbDataSupplier.Controls.Add(Me.Label4)
        Me.gbDataSupplier.Controls.Add(Me.Label3)
        Me.gbDataSupplier.ForeColor = System.Drawing.Color.White
        Me.gbDataSupplier.Location = New System.Drawing.Point(107, 156)
        Me.gbDataSupplier.Name = "gbDataSupplier"
        Me.gbDataSupplier.Size = New System.Drawing.Size(962, 185)
        Me.gbDataSupplier.TabIndex = 35
        Me.gbDataSupplier.TabStop = False
        Me.gbDataSupplier.Text = "Supplier"
        '
        'tbKontakSupplier
        '
        Me.tbKontakSupplier.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKontakSupplier.Location = New System.Drawing.Point(163, 123)
        Me.tbKontakSupplier.Name = "tbKontakSupplier"
        Me.tbKontakSupplier.Size = New System.Drawing.Size(287, 29)
        Me.tbKontakSupplier.TabIndex = 14
        '
        'tbNamaSupplier
        '
        Me.tbNamaSupplier.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaSupplier.Location = New System.Drawing.Point(163, 80)
        Me.tbNamaSupplier.Name = "tbNamaSupplier"
        Me.tbNamaSupplier.Size = New System.Drawing.Size(287, 29)
        Me.tbNamaSupplier.TabIndex = 13
        '
        'tbIdSupplier
        '
        Me.tbIdSupplier.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdSupplier.Location = New System.Drawing.Point(163, 40)
        Me.tbIdSupplier.Name = "tbIdSupplier"
        Me.tbIdSupplier.Size = New System.Drawing.Size(154, 29)
        Me.tbIdSupplier.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(50, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Kontak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(50, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(50, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dosis", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(437, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 42)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Apotek Sehat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(348, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 81)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Data Supplier"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 28)
        Me.MenuStrip1.TabIndex = 42
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
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KatanyaMiniProjek.My.Resources.Resources._8767047
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvDataSupplier)
        Me.Controls.Add(Me.tbSearchSupplier)
        Me.Controls.Add(Me.btSearchSupplier)
        Me.Controls.Add(Me.btDeleteSupplier)
        Me.Controls.Add(Me.btUpdateSupplier)
        Me.Controls.Add(Me.btCreateSupplier)
        Me.Controls.Add(Me.gbDataSupplier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSupplier"
        Me.Text = "FormSupplier"
        CType(Me.dgvDataSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDataSupplier.ResumeLayout(False)
        Me.gbDataSupplier.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDataSupplier As DataGridView
    Friend WithEvents tbSearchSupplier As TextBox
    Friend WithEvents btSearchSupplier As Button
    Friend WithEvents btDeleteSupplier As Button
    Friend WithEvents btUpdateSupplier As Button
    Friend WithEvents btCreateSupplier As Button
    Friend WithEvents gbDataSupplier As GroupBox
    Friend WithEvents tbKontakSupplier As TextBox
    Friend WithEvents tbNamaSupplier As TextBox
    Friend WithEvents tbIdSupplier As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataObatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataKustomerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem1 As ToolStripMenuItem
End Class
