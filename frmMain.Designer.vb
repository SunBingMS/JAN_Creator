<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJAN = New System.Windows.Forms.TextBox()
        Me.btnCONV = New System.Windows.Forms.Button()
        Me.lblJANBAR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFONT = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JAN"
        '
        'txtJAN
        '
        Me.txtJAN.Location = New System.Drawing.Point(53, 6)
        Me.txtJAN.MaxLength = 13
        Me.txtJAN.Name = "txtJAN"
        Me.txtJAN.Size = New System.Drawing.Size(100, 19)
        Me.txtJAN.TabIndex = 1
        Me.txtJAN.Text = "4902505408069"
        '
        'btnCONV
        '
        Me.btnCONV.Location = New System.Drawing.Point(207, 4)
        Me.btnCONV.Name = "btnCONV"
        Me.btnCONV.Size = New System.Drawing.Size(120, 49)
        Me.btnCONV.TabIndex = 2
        Me.btnCONV.Text = "Convert"
        Me.btnCONV.UseVisualStyleBackColor = True
        '
        'lblJANBAR
        '
        Me.lblJANBAR.Font = New System.Drawing.Font("TIS_JAN_3", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJANBAR.Location = New System.Drawing.Point(12, 69)
        Me.lblJANBAR.Name = "lblJANBAR"
        Me.lblJANBAR.Size = New System.Drawing.Size(315, 71)
        Me.lblJANBAR.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FONT"
        '
        'cmbFONT
        '
        Me.cmbFONT.FormattingEnabled = True
        Me.cmbFONT.Location = New System.Drawing.Point(53, 33)
        Me.cmbFONT.Name = "cmbFONT"
        Me.cmbFONT.Size = New System.Drawing.Size(121, 20)
        Me.cmbFONT.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 150)
        Me.Controls.Add(Me.cmbFONT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblJANBAR)
        Me.Controls.Add(Me.btnCONV)
        Me.Controls.Add(Me.txtJAN)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "JAN_Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtJAN As TextBox
    Friend WithEvents btnCONV As Button
    Friend WithEvents lblJANBAR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbFONT As ComboBox
End Class
