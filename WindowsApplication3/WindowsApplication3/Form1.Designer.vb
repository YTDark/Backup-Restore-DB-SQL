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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ch1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cod = New System.Windows.Forms.ComboBox()
        Me.dbr = New System.Windows.Forms.Button()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tet = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.BCO = New System.Windows.Forms.Button()
        Me.BC = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.BRO = New System.Windows.Forms.Button()
        Me.BR = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.BD = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(12, 9)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.RightToLeftLayout = True
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(542, 285)
        Me.TabControl2.TabIndex = 67
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.ch1)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 32)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(534, 249)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "أخذ نسخة إحتياطية"
        '
        'ch1
        '
        Me.ch1.AutoSize = True
        Me.ch1.Location = New System.Drawing.Point(448, 134)
        Me.ch1.Name = "ch1"
        Me.ch1.Size = New System.Drawing.Size(76, 27)
        Me.ch1.TabIndex = 21
        Me.ch1.Text = "نسخ تلقائي"
        Me.ch1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cod)
        Me.GroupBox1.Controls.Add(Me.dbr)
        Me.GroupBox1.Controls.Add(Me.tf)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tet)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(16, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 85)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "النسخ التلقائي"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 56)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 26)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "حفظ الإعدادات"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cod
        '
        Me.cod.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.FormattingEnabled = True
        Me.cod.Items.AddRange(New Object() {"السبت", "الأحد", "الإثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة"})
        Me.cod.Location = New System.Drawing.Point(380, 24)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(68, 31)
        Me.cod.TabIndex = 26
        '
        'dbr
        '
        Me.dbr.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbr.Location = New System.Drawing.Point(111, 27)
        Me.dbr.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dbr.Name = "dbr"
        Me.dbr.Size = New System.Drawing.Size(63, 26)
        Me.dbr.TabIndex = 22
        Me.dbr.Text = "......"
        Me.dbr.UseVisualStyleBackColor = True
        '
        'tf
        '
        Me.tf.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf.Location = New System.Drawing.Point(8, 24)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(95, 30)
        Me.tf.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 29)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "مسار الحفظ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 29)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "الساعة:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(456, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "اليوم:"
        '
        'tet
        '
        Me.tet.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tet.Location = New System.Drawing.Point(266, 24)
        Me.tet.Name = "tet"
        Me.tet.Size = New System.Drawing.Size(53, 30)
        Me.tet.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(276, 19)
        Me.Label32.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(232, 29)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "قم بتحديد مسار حفظ النسخة الاحتياطية"
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Location = New System.Drawing.Point(8, 54)
        Me.t1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.t1.Name = "t1"
        Me.t1.ReadOnly = True
        Me.t1.Size = New System.Drawing.Size(407, 26)
        Me.t1.TabIndex = 18
        '
        'BCO
        '
        Me.BCO.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCO.Location = New System.Drawing.Point(425, 54)
        Me.BCO.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BCO.Name = "BCO"
        Me.BCO.Size = New System.Drawing.Size(63, 26)
        Me.BCO.TabIndex = 17
        Me.BCO.Text = "......"
        Me.BCO.UseVisualStyleBackColor = True
        '
        'BC
        '
        Me.BC.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BC.Location = New System.Drawing.Point(8, 82)
        Me.BC.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BC.Name = "BC"
        Me.BC.Size = New System.Drawing.Size(139, 34)
        Me.BC.TabIndex = 15
        Me.BC.Text = "أخذ نسخة إحتياطية"
        Me.BC.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage5.Controls.Add(Me.Label33)
        Me.TabPage5.Controls.Add(Me.T2)
        Me.TabPage5.Controls.Add(Me.BRO)
        Me.TabPage5.Controls.Add(Me.BR)
        Me.TabPage5.Location = New System.Drawing.Point(4, 32)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(534, 249)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "إستعادة نسخة إحتياطية"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(316, 41)
        Me.Label33.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(201, 29)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "قم بتحديد مسار النسخة الاحتياطية"
        '
        'T2
        '
        Me.T2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T2.Location = New System.Drawing.Point(5, 76)
        Me.T2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.T2.Name = "T2"
        Me.T2.ReadOnly = True
        Me.T2.Size = New System.Drawing.Size(435, 26)
        Me.T2.TabIndex = 23
        '
        'BRO
        '
        Me.BRO.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRO.Location = New System.Drawing.Point(447, 76)
        Me.BRO.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BRO.Name = "BRO"
        Me.BRO.Size = New System.Drawing.Size(63, 26)
        Me.BRO.TabIndex = 22
        Me.BRO.Text = "......"
        Me.BRO.UseVisualStyleBackColor = True
        '
        'BR
        '
        Me.BR.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BR.Location = New System.Drawing.Point(5, 114)
        Me.BR.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BR.Name = "BR"
        Me.BR.Size = New System.Drawing.Size(139, 34)
        Me.BR.TabIndex = 20
        Me.BR.Text = "إستعادة النسخة الاحتياطية"
        Me.BR.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage6.Controls.Add(Me.BD)
        Me.TabPage6.Location = New System.Drawing.Point(4, 32)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(534, 249)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "تفريغ قاعدة البيانات"
        '
        'BD
        '
        Me.BD.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BD.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BD.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BD.Location = New System.Drawing.Point(188, 99)
        Me.BD.Name = "BD"
        Me.BD.Size = New System.Drawing.Size(153, 40)
        Me.BD.TabIndex = 0
        Me.BD.Text = "تفريغ القاعدة"
        Me.BD.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.BC)
        Me.GroupBox2.Controls.Add(Me.BCO)
        Me.GroupBox2.Controls.Add(Me.t1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 122)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نسخ يدوي"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(561, 297)
        Me.Controls.Add(Me.TabControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نسخ_ واستعادة قاعدة البيانات"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Private WithEvents Label32 As Label
    Private WithEvents t1 As TextBox
    Private WithEvents BCO As Button
    Private WithEvents BC As Button
    Friend WithEvents TabPage5 As TabPage
    Private WithEvents Label33 As Label
    Private WithEvents T2 As TextBox
    Private WithEvents BRO As Button
    Private WithEvents BR As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents BD As Button
    Friend WithEvents ch1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cod As System.Windows.Forms.ComboBox
    Private WithEvents dbr As System.Windows.Forms.Button
    Friend WithEvents tf As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tet As System.Windows.Forms.TextBox
    Private WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
