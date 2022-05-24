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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumPoints = New System.Windows.Forms.TextBox()
        Me.Prob = New System.Windows.Forms.TextBox()
        Me.Quit = New System.Windows.Forms.Button()
        Me.Simulate = New System.Windows.Forms.Button()
        Me.Graph = New System.Windows.Forms.PictureBox()
        CType(Me.Graph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 30)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Buffon Needle Problem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 446)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sample Size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 446)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Prob (Needle Crossing)"
        '
        'NumPoints
        '
        Me.NumPoints.Location = New System.Drawing.Point(37, 478)
        Me.NumPoints.Name = "NumPoints"
        Me.NumPoints.Size = New System.Drawing.Size(100, 26)
        Me.NumPoints.TabIndex = 12
        '
        'Prob
        '
        Me.Prob.Location = New System.Drawing.Point(297, 478)
        Me.Prob.Name = "Prob"
        Me.Prob.ReadOnly = True
        Me.Prob.Size = New System.Drawing.Size(100, 26)
        Me.Prob.TabIndex = 11
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Blue
        Me.Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Quit.Location = New System.Drawing.Point(436, 446)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(92, 64)
        Me.Quit.TabIndex = 10
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'Simulate
        '
        Me.Simulate.BackColor = System.Drawing.Color.Blue
        Me.Simulate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simulate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Simulate.Location = New System.Drawing.Point(153, 446)
        Me.Simulate.Name = "Simulate"
        Me.Simulate.Size = New System.Drawing.Size(94, 61)
        Me.Simulate.TabIndex = 9
        Me.Simulate.Text = "Simulate"
        Me.Simulate.UseVisualStyleBackColor = False
        '
        'Graph
        '
        Me.Graph.BackColor = System.Drawing.Color.LightCyan
        Me.Graph.Location = New System.Drawing.Point(30, 85)
        Me.Graph.Name = "Graph"
        Me.Graph.Size = New System.Drawing.Size(455, 315)
        Me.Graph.TabIndex = 8
        Me.Graph.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(540, 535)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumPoints)
        Me.Controls.Add(Me.Prob)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Simulate)
        Me.Controls.Add(Me.Graph)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Graph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumPoints As System.Windows.Forms.TextBox
    Friend WithEvents Prob As System.Windows.Forms.TextBox
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents Simulate As System.Windows.Forms.Button
    Friend WithEvents Graph As System.Windows.Forms.PictureBox

End Class
