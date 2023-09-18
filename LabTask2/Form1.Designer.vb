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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OriginalItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondOriginalItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OthersItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.VScrollBar1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 613)
        Me.Panel1.TabIndex = 0
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(942, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 709)
        Me.VScrollBar1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(942, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 24)
        Me.ToolStripLabel1.Text = "Menu"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomePageToolStripMenuItem, Me.ItemListToolStripMenuItem, Me.AboutUsToolStripMenuItem, Me.SettingToolStripMenuItem, Me.HelpServiceToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'HomePageToolStripMenuItem
        '
        Me.HomePageToolStripMenuItem.Name = "HomePageToolStripMenuItem"
        Me.HomePageToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.HomePageToolStripMenuItem.Text = "Home Page"
        '
        'ItemListToolStripMenuItem
        '
        Me.ItemListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OriginalItemToolStripMenuItem, Me.SecondOriginalItemToolStripMenuItem, Me.OthersItemToolStripMenuItem})
        Me.ItemListToolStripMenuItem.Name = "ItemListToolStripMenuItem"
        Me.ItemListToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ItemListToolStripMenuItem.Text = "Item List"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'HelpServiceToolStripMenuItem
        '
        Me.HelpServiceToolStripMenuItem.Name = "HelpServiceToolStripMenuItem"
        Me.HelpServiceToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.HelpServiceToolStripMenuItem.Text = "Help Center"
        '
        'OriginalItemToolStripMenuItem
        '
        Me.OriginalItemToolStripMenuItem.Name = "OriginalItemToolStripMenuItem"
        Me.OriginalItemToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OriginalItemToolStripMenuItem.Text = "Original Item"
        '
        'SecondOriginalItemToolStripMenuItem
        '
        Me.SecondOriginalItemToolStripMenuItem.Name = "SecondOriginalItemToolStripMenuItem"
        Me.SecondOriginalItemToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SecondOriginalItemToolStripMenuItem.Text = "Second Original Item"
        '
        'OthersItemToolStripMenuItem
        '
        Me.OthersItemToolStripMenuItem.Name = "OthersItemToolStripMenuItem"
        Me.OthersItemToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OthersItemToolStripMenuItem.Text = "Others Item"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(942, 406)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 414)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(942, 295)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(365, 94)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 40)
        Me.TextBox1.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(303, 94)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(183, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 121)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "All Type of Motor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(408, 501)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 121)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Motor GenzA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(628, 501)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 121)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Motor GenzZ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "VrooMotors Official"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents HomePageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OriginalItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecondOriginalItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OthersItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
