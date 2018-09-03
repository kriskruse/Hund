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
        Me.btn1time = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGaatur = New System.Windows.Forms.Button()
        Me.btnMad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTid = New System.Windows.Forms.Label()
        Me.lblEnergi = New System.Windows.Forms.Label()
        Me.lblSult = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldoed = New System.Windows.Forms.Label()
        Me.Death = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1time
        '
        Me.btn1time.Location = New System.Drawing.Point(623, 277)
        Me.btn1time.Name = "btn1time"
        Me.btn1time.Size = New System.Drawing.Size(89, 39)
        Me.btn1time.TabIndex = 1
        Me.btn1time.Text = "1 time"
        Me.btn1time.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 273)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnGaatur
        '
        Me.btnGaatur.Location = New System.Drawing.Point(623, 367)
        Me.btnGaatur.Name = "btnGaatur"
        Me.btnGaatur.Size = New System.Drawing.Size(89, 39)
        Me.btnGaatur.TabIndex = 2
        Me.btnGaatur.Text = "Gåtur"
        Me.btnGaatur.UseVisualStyleBackColor = True
        '
        'btnMad
        '
        Me.btnMad.Location = New System.Drawing.Point(623, 322)
        Me.btnMad.Name = "btnMad"
        Me.btnMad.Size = New System.Drawing.Size(89, 39)
        Me.btnMad.TabIndex = 3
        Me.btnMad.Text = "Mad"
        Me.btnMad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(620, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Energi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(620, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sult"
        '
        'lblTid
        '
        Me.lblTid.AutoSize = True
        Me.lblTid.Location = New System.Drawing.Point(620, 62)
        Me.lblTid.Name = "lblTid"
        Me.lblTid.Size = New System.Drawing.Size(16, 17)
        Me.lblTid.TabIndex = 7
        Me.lblTid.Tag = "Time"
        Me.lblTid.Text = "0"
        '
        'lblEnergi
        '
        Me.lblEnergi.AutoSize = True
        Me.lblEnergi.Location = New System.Drawing.Point(620, 208)
        Me.lblEnergi.Name = "lblEnergi"
        Me.lblEnergi.Size = New System.Drawing.Size(16, 17)
        Me.lblEnergi.TabIndex = 8
        Me.lblEnergi.Text = "0"
        '
        'lblSult
        '
        Me.lblSult.AutoSize = True
        Me.lblSult.Location = New System.Drawing.Point(620, 137)
        Me.lblSult.Name = "lblSult"
        Me.lblSult.Size = New System.Drawing.Size(16, 17)
        Me.lblSult.TabIndex = 9
        Me.lblSult.Text = "0"
        '
        'timer
        '
        Me.timer.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(620, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tid"
        '
        'lbldoed
        '
        Me.lbldoed.AutoSize = True
        Me.lbldoed.Location = New System.Drawing.Point(265, 61)
        Me.lbldoed.Name = "lbldoed"
        Me.lbldoed.Size = New System.Drawing.Size(12, 17)
        Me.lbldoed.TabIndex = 10
        Me.lbldoed.Text = " "
        '
        'Death
        '
        Me.Death.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbldoed)
        Me.Controls.Add(Me.lblSult)
        Me.Controls.Add(Me.lblEnergi)
        Me.Controls.Add(Me.lblTid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMad)
        Me.Controls.Add(Me.btnGaatur)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn1time)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1time As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGaatur As Button
    Friend WithEvents btnMad As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTid As Label
    Friend WithEvents lblEnergi As Label
    Friend WithEvents lblSult As Label
    Friend WithEvents timer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lbldoed As Label
    Friend WithEvents Death As Timer
End Class
