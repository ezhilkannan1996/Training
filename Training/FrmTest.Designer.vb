<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTest))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.LblSV = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtMonth = New System.Windows.Forms.TextBox()
        Me.LblSI = New System.Windows.Forms.Label()
        Me.CbMonth = New System.Windows.Forms.ComboBox()
        Me.LstMonth = New System.Windows.Forms.ListBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblCount)
        Me.GroupBox1.Controls.Add(Me.BtnRemove)
        Me.GroupBox1.Controls.Add(Me.LblSV)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.TxtMonth)
        Me.GroupBox1.Controls.Add(Me.LblSI)
        Me.GroupBox1.Controls.Add(Me.CbMonth)
        Me.GroupBox1.Controls.Add(Me.LstMonth)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.BtnOpen)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 435)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Place Your Controls. here..."
        '
        'LblCount
        '
        Me.LblCount.AutoSize = True
        Me.LblCount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCount.Location = New System.Drawing.Point(191, 314)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(60, 16)
        Me.LblCount.TabIndex = 11
        Me.LblCount.Text = "Count :"
        '
        'BtnRemove
        '
        Me.BtnRemove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.Location = New System.Drawing.Point(40, 356)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(120, 23)
        Me.BtnRemove.TabIndex = 10
        Me.BtnRemove.Text = "Re&move"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'LblSV
        '
        Me.LblSV.AutoSize = True
        Me.LblSV.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSV.Location = New System.Drawing.Point(191, 276)
        Me.LblSV.Name = "LblSV"
        Me.LblSV.Size = New System.Drawing.Size(125, 16)
        Me.LblSV.TabIndex = 9
        Me.LblSV.Text = "Selected Value :"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(166, 173)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(120, 26)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "&Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtMonth
        '
        Me.TxtMonth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMonth.Location = New System.Drawing.Point(40, 176)
        Me.TxtMonth.Name = "TxtMonth"
        Me.TxtMonth.Size = New System.Drawing.Size(120, 23)
        Me.TxtMonth.TabIndex = 7
        '
        'LblSI
        '
        Me.LblSI.AutoSize = True
        Me.LblSI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSI.Location = New System.Drawing.Point(191, 248)
        Me.LblSI.Name = "LblSI"
        Me.LblSI.Size = New System.Drawing.Size(126, 16)
        Me.LblSI.TabIndex = 6
        Me.LblSI.Text = "Selected Index :"
        '
        'CbMonth
        '
        Me.CbMonth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMonth.FormattingEnabled = True
        Me.CbMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May"})
        Me.CbMonth.Location = New System.Drawing.Point(344, 172)
        Me.CbMonth.Name = "CbMonth"
        Me.CbMonth.Size = New System.Drawing.Size(202, 24)
        Me.CbMonth.TabIndex = 5
        '
        'LstMonth
        '
        Me.LstMonth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMonth.FormattingEnabled = True
        Me.LstMonth.ItemHeight = 16
        Me.LstMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May"})
        Me.LstMonth.Location = New System.Drawing.Point(40, 202)
        Me.LstMonth.Name = "LstMonth"
        Me.LstMonth.Size = New System.Drawing.Size(118, 148)
        Me.LstMonth.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(278, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(232, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(40, 57)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(232, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "987987987"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 1
        '
        'BtnOpen
        '
        Me.BtnOpen.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpen.Location = New System.Drawing.Point(40, 92)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(120, 31)
        Me.BtnOpen.TabIndex = 0
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'FrmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 556)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training Win Forms"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnOpen As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LstMonth As ListBox
    Friend WithEvents LblCount As Label
    Friend WithEvents BtnRemove As Button
    Friend WithEvents LblSV As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtMonth As TextBox
    Friend WithEvents LblSI As Label
    Friend WithEvents CbMonth As ComboBox
End Class
