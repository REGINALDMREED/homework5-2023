<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevConference
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtNumOfMemb = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radPre = New System.Windows.Forms.RadioButton()
        Me.radNew = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(136, 572)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(112, 33)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(498, 572)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 33)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Calculation Total Cost per Company For" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Developers attending the Conference" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of conference Registration per Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 283)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 4
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(294, 523)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 19)
        Me.lblCost.TabIndex = 5
        '
        'txtNumOfMemb
        '
        Me.txtNumOfMemb.Location = New System.Drawing.Point(429, 116)
        Me.txtNumOfMemb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumOfMemb.Name = "txtNumOfMemb"
        Me.txtNumOfMemb.Size = New System.Drawing.Size(148, 26)
        Me.txtNumOfMemb.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPre)
        Me.GroupBox1.Controls.Add(Me.radNew)
        Me.GroupBox1.Location = New System.Drawing.Point(230, 336)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(300, 146)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conference Types:"
        '
        'radPre
        '
        Me.radPre.AutoSize = True
        Me.radPre.Location = New System.Drawing.Point(69, 90)
        Me.radPre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radPre.Name = "radPre"
        Me.radPre.Size = New System.Drawing.Size(211, 23)
        Me.radPre.TabIndex = 1
        Me.radPre.TabStop = True
        Me.radPre.Text = "Previous Conference Attendee"
        Me.radPre.UseVisualStyleBackColor = True
        '
        'radNew
        '
        Me.radNew.AutoSize = True
        Me.radNew.Location = New System.Drawing.Point(69, 29)
        Me.radNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(192, 23)
        Me.radNew.TabIndex = 0
        Me.radNew.TabStop = True
        Me.radNew.Text = "New Conference Antendee"
        Me.radNew.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 523)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Cost Per Company:"
        '
        'frmDevConference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 709)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNumOfMemb)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmDevConference"
        Me.Text = "App Developers Conference Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtNumOfMemb As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radPre As RadioButton
    Friend WithEvents radNew As RadioButton
    Friend WithEvents Label4 As Label
End Class
