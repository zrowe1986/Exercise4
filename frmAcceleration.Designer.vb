<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAcceleration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblDistance = New Label()
        lblTime = New Label()
        txtDistance = New TextBox()
        txtTime = New TextBox()
        btnCalculate = New Button()
        btnClear = New Button()
        btnEnd = New Button()
        SuspendLayout()
        ' 
        ' lblDistance
        ' 
        lblDistance.BackColor = SystemColors.ActiveCaption
        lblDistance.Location = New Point(49, 60)
        lblDistance.Name = "lblDistance"
        lblDistance.Size = New Size(166, 64)
        lblDistance.TabIndex = 0
        lblDistance.Text = "ENTER DISTANCE (ft)"
        ' 
        ' lblTime
        ' 
        lblTime.BackColor = SystemColors.ActiveCaption
        lblTime.Location = New Point(49, 171)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(166, 64)
        lblTime.TabIndex = 1
        lblTime.Text = "ENTER TIME (seconds)"
        ' 
        ' txtDistance
        ' 
        txtDistance.Location = New Point(311, 60)
        txtDistance.Name = "txtDistance"
        txtDistance.Size = New Size(200, 39)
        txtDistance.TabIndex = 2
        ' 
        ' txtTime
        ' 
        txtTime.Location = New Point(311, 168)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(200, 39)
        txtTime.TabIndex = 3
        ' 
        ' btnCalculate
        ' 
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCalculate.Location = New Point(103, 333)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(322, 129)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Calculate Acceleration"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(492, 333)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(322, 129)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear Values"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnEnd
        ' 
        btnEnd.FlatStyle = FlatStyle.Flat
        btnEnd.Font = New Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnd.Location = New Point(311, 569)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(322, 129)
        btnEnd.TabIndex = 8
        btnEnd.Text = "Quit"
        btnEnd.UseVisualStyleBackColor = True
        ' 
        ' frmAcceleration
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(931, 726)
        Controls.Add(btnEnd)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(txtTime)
        Controls.Add(txtDistance)
        Controls.Add(lblTime)
        Controls.Add(lblDistance)
        ForeColor = Color.Black
        Name = "frmAcceleration"
        Text = "Calculate Acceleration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDistance As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnd As Button

End Class
