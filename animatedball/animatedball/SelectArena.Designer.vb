<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectArena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectArena))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "AsgardPlace.png")
        Me.ImageList1.Images.SetKeyName(1, "AsgardName.png")
        Me.ImageList1.Images.SetKeyName(2, "WakandaPlace.png")
        Me.ImageList1.Images.SetKeyName(3, "WakandaName.png")
        Me.ImageList1.Images.SetKeyName(4, "No.png")
        Me.ImageList1.Images.SetKeyName(5, "Yes.png")
        Me.ImageList1.Images.SetKeyName(6, "Back.png")
        Me.ImageList1.Images.SetKeyName(7, "Next.png")
        Me.ImageList1.Images.SetKeyName(8, "Play.png")
        Me.ImageList1.Images.SetKeyName(9, "Select.png")
        Me.ImageList1.Images.SetKeyName(10, "Start.png")
        Me.ImageList1.Images.SetKeyName(11, "Help.png")
        Me.ImageList1.Images.SetKeyName(12, "Sound.png")
        Me.ImageList1.Images.SetKeyName(13, "ClickToStart.png")
        Me.ImageList1.Images.SetKeyName(14, "Effect.png")
        Me.ImageList1.Images.SetKeyName(15, "TuqTuq.png")
        Me.ImageList1.Images.SetKeyName(16, "Music.png")
        Me.ImageList1.Images.SetKeyName(17, "Player1.png")
        Me.ImageList1.Images.SetKeyName(18, "SelectArena.png")
        Me.ImageList1.Images.SetKeyName(19, "SelectCharacter.png")
        Me.ImageList1.Images.SetKeyName(20, "Selected.png")
        Me.ImageList1.Images.SetKeyName(21, "Player2.png")
        '
        'SelectArena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.best_air_hockey_table
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1015, 460)
        Me.Name = "SelectArena"
        Me.Text = "SelectArena"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
End Class
