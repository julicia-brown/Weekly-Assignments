<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurger))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picPrime = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.btnPrime = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(236, 48)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(486, 52)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picPrime
        '
        Me.picPrime.Image = CType(resources.GetObject("picPrime.Image"), System.Drawing.Image)
        Me.picPrime.Location = New System.Drawing.Point(109, 176)
        Me.picPrime.Name = "picPrime"
        Me.picPrime.Size = New System.Drawing.Size(260, 250)
        Me.picPrime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPrime.TabIndex = 1
        Me.picPrime.TabStop = False
        Me.picPrime.Visible = False
        '
        'picVeggie
        '
        Me.picVeggie.Image = CType(resources.GetObject("picVeggie.Image"), System.Drawing.Image)
        Me.picVeggie.Location = New System.Drawing.Point(595, 176)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(260, 250)
        Me.picVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeggie.TabIndex = 2
        Me.picVeggie.TabStop = False
        Me.picVeggie.Visible = False
        '
        'btnPrime
        '
        Me.btnPrime.BackColor = System.Drawing.Color.Wheat
        Me.btnPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrime.Location = New System.Drawing.Point(154, 513)
        Me.btnPrime.Name = "btnPrime"
        Me.btnPrime.Size = New System.Drawing.Size(152, 49)
        Me.btnPrime.TabIndex = 3
        Me.btnPrime.Text = "Prime Beef"
        Me.btnPrime.UseVisualStyleBackColor = False
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.BackColor = System.Drawing.Color.Wheat
        Me.btnSelectMeal.Enabled = False
        Me.btnSelectMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectMeal.Location = New System.Drawing.Point(417, 513)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(152, 49)
        Me.btnSelectMeal.TabIndex = 4
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = False
        '
        'btnVeggie
        '
        Me.btnVeggie.BackColor = System.Drawing.Color.Wheat
        Me.btnVeggie.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeggie.Location = New System.Drawing.Point(654, 513)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(152, 49)
        Me.btnVeggie.TabIndex = 5
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(266, 659)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(456, 29)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a burger and then click the Select"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(340, 724)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(283, 29)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your burger special"
        Me.lblConfirmation.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.No
        Me.btnExit.Enabled = False
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(417, 810)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 49)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmBurger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1026, 904)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnPrime)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picPrime)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Name = "frmBurger"
        Me.Text = "Burger Specials"
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnPrime As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
