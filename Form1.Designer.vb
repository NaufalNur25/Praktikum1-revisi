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
        Label1 = New Label()
        TxtTeks = New TextBox()
        Label2 = New Label()
        TxtJumlah = New TextBox()
        BProses = New Button()
        List1 = New ListView()
        BClear = New Button()
        BKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tuliskan Text: "
        ' 
        ' TxtTeks
        ' 
        TxtTeks.Location = New Point(155, 12)
        TxtTeks.Multiline = True
        TxtTeks.Name = "TxtTeks"
        TxtTeks.Size = New Size(264, 27)
        TxtTeks.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 20)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah Perulangan: "
        ' 
        ' TxtJumlah
        ' 
        TxtJumlah.Location = New Point(155, 58)
        TxtJumlah.Name = "TxtJumlah"
        TxtJumlah.Size = New Size(264, 27)
        TxtJumlah.TabIndex = 3
        ' 
        ' BProses
        ' 
        BProses.Location = New Point(12, 98)
        BProses.Name = "BProses"
        BProses.Size = New Size(407, 35)
        BProses.TabIndex = 4
        BProses.Text = "Proses"
        BProses.UseVisualStyleBackColor = True
        ' 
        ' List1
        ' 
        List1.Location = New Point(12, 139)
        List1.Name = "List1"
        List1.Size = New Size(407, 276)
        List1.TabIndex = 5
        List1.UseCompatibleStateImageBehavior = False
        List1.View = View.List
        ' 
        ' BClear
        ' 
        BClear.Location = New Point(12, 421)
        BClear.Name = "BClear"
        BClear.Size = New Size(201, 29)
        BClear.TabIndex = 6
        BClear.Text = "Clear"
        BClear.UseVisualStyleBackColor = True
        ' 
        ' BKeluar
        ' 
        BKeluar.Location = New Point(219, 421)
        BKeluar.Name = "BKeluar"
        BKeluar.Size = New Size(200, 29)
        BKeluar.TabIndex = 7
        BKeluar.Text = "Keluar"
        BKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(435, 460)
        Controls.Add(BKeluar)
        Controls.Add(BClear)
        Controls.Add(List1)
        Controls.Add(BProses)
        Controls.Add(TxtJumlah)
        Controls.Add(Label2)
        Controls.Add(TxtTeks)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Program Perulangan Text"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTeks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents BProses As Button
    Friend WithEvents List1 As ListView
    Friend WithEvents BClear As Button
    Friend WithEvents BKeluar As Button

End Class
