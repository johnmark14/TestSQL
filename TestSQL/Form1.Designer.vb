<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblusername = New Label()
        txtusername = New TextBox()
        btnsave = New Button()
        listuser = New ListBox()
        btngetdata = New Button()
        SuspendLayout()
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Location = New Point(40, 41)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(65, 15)
        lblusername.TabIndex = 0
        lblusername.Text = "User Name"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(40, 71)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Username"
        txtusername.Size = New Size(259, 23)
        txtusername.TabIndex = 1
        ' 
        ' btnsave
        ' 
        btnsave.Location = New Point(305, 71)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(75, 23)
        btnsave.TabIndex = 2
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' listuser
        ' 
        listuser.FormattingEnabled = True
        listuser.ItemHeight = 15
        listuser.Location = New Point(40, 123)
        listuser.Name = "listuser"
        listuser.Size = New Size(340, 94)
        listuser.TabIndex = 3
        ' 
        ' btngetdata
        ' 
        btngetdata.Location = New Point(40, 223)
        btngetdata.Name = "btngetdata"
        btngetdata.Size = New Size(340, 23)
        btngetdata.TabIndex = 4
        btngetdata.Text = "Get Data"
        btngetdata.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 271)
        Controls.Add(btngetdata)
        Controls.Add(listuser)
        Controls.Add(btnsave)
        Controls.Add(txtusername)
        Controls.Add(lblusername)
        Name = "Form1"
        Text = "VB with MySQL"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblusername As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents listuser As ListBox
    Friend WithEvents btngetdata As Button
End Class
