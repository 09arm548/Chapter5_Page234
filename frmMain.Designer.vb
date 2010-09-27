<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtNumChair = New System.Windows.Forms.TextBox()
        Me.txtNumSofa = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblNumChairs = New System.Windows.Forms.Label()
        Me.lblNumSofas = New System.Windows.Forms.Label()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(123, 338)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(100, 28)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Process Orders"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(527, 337)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Order Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(963, 337)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(100, 28)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(276, 27)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 22)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = "Grossman, Stephen"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(276, 96)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(132, 22)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Text = "123 Main Street"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(276, 169)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(132, 22)
        Me.txtCity.TabIndex = 5
        Me.txtCity.Text = "Altoona, PA 16602"
        '
        'txtNumChair
        '
        Me.txtNumChair.Location = New System.Drawing.Point(276, 241)
        Me.txtNumChair.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumChair.Name = "txtNumChair"
        Me.txtNumChair.Size = New System.Drawing.Size(51, 22)
        Me.txtNumChair.TabIndex = 6
        '
        'txtNumSofa
        '
        Me.txtNumSofa.Location = New System.Drawing.Point(276, 288)
        Me.txtNumSofa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumSofa.Name = "txtNumSofa"
        Me.txtNumSofa.Size = New System.Drawing.Size(51, 22)
        Me.txtNumSofa.TabIndex = 7
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(5, 28)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(113, 34)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Customer Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Last, First)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(9, 105)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 17)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(9, 177)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(104, 17)
        Me.lblCity.TabIndex = 11
        Me.lblCity.Text = "City, State, Zip:"
        '
        'lblNumChairs
        '
        Me.lblNumChairs.AutoSize = True
        Me.lblNumChairs.Location = New System.Drawing.Point(9, 245)
        Me.lblNumChairs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumChairs.Name = "lblNumChairs"
        Me.lblNumChairs.Size = New System.Drawing.Size(104, 34)
        Me.lblNumChairs.TabIndex = 12
        Me.lblNumChairs.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "chairs ordered:"
        '
        'lblNumSofas
        '
        Me.lblNumSofas.AutoSize = True
        Me.lblNumSofas.Location = New System.Drawing.Point(9, 297)
        Me.lblNumSofas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumSofas.Name = "lblNumSofas"
        Me.lblNumSofas.Size = New System.Drawing.Size(100, 34)
        Me.lblNumSofas.TabIndex = 13
        Me.lblNumSofas.Text = "Number of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sofas ordered:"
        '
        'lstInvoice
        '
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 16
        Me.lstInvoice.Location = New System.Drawing.Point(523, 31)
        Me.lstInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(537, 276)
        Me.lstInvoice.TabIndex = 14
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 411)
        Me.Controls.Add(Me.lstInvoice)
        Me.Controls.Add(Me.lblNumSofas)
        Me.Controls.Add(Me.lblNumChairs)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtNumSofa)
        Me.Controls.Add(Me.txtNumChair)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Furniture Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtNumChair As System.Windows.Forms.TextBox
    Friend WithEvents txtNumSofa As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblNumChairs As System.Windows.Forms.Label
    Friend WithEvents lblNumSofas As System.Windows.Forms.Label
    Friend WithEvents lstInvoice As System.Windows.Forms.ListBox

End Class
