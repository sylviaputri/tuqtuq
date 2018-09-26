Public Class Form1

    Private bSize As Integer = 15 'FRACTION OF BALL SIZE
    Private move_Size As Integer = 2 'FRACTION OF CLIENT AREA
    Private btmp As Bitmap
    Private bPositionX As Integer
    Private bPositionY As Integer
    Private bRadiusX As Integer
    Private bRadiusY As Integer
    Private bMoveX As Integer
    Private bMoveY As Integer
    Private bBitmapWidth As Integer
    Private bBitmapHeight As Integer
    Private btmpWidthMargin As Integer
    Private btmpHeightMargin As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'SET A VARIABLE TO OBTAIN THE GRAPHICS OBJECT.
        Dim grafx As Graphics = CreateGraphics()
        'DRAW THE BALL IN THE FORM.
        grafx.DrawImage(btmp,
            CInt(bPositionX - bBitmapWidth / 2),
            CInt(bPositionY - bBitmapHeight / 2),
            bBitmapWidth, bBitmapHeight)

        grafx.Dispose()

        'SET THIS TO INCREAMENT THE POSITION OF THE BALL BY ITS DISTANCE TO MOVED BOTH X AND Y AXIS.
        bPositionX += bMoveX
        bPositionY += bMoveY

        'SET THE REVERSE THE DIRECTION OF THE BALL WHEN IT HITS TO THE BOUNDARY.
        If bPositionX + bRadiusX >= ClientSize.Width _
            Or bPositionX - bRadiusX <= 0 Then
            bMoveX = -bMoveX
            Beep()
        End If

        'SET THE Y BOUNDARY TO 90 SO THAT IT WILL NOT EXCEED TO THE TITLE OF THE FORM.
        If bPositionY + bRadiusY >= ClientSize.Height _
            Or bPositionY - bRadiusY <= 90 Then
            bMoveY = -bMoveY
            Beep()
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal ev_arg As EventArgs)
        Dim grafx As Graphics = CreateGraphics()
        'CLEAR ANY DRAWINGS.
        grafx.Clear(BackColor)


        'SET A VARIBLE THAT HOLDS THE RADIUS OF THE BALL
        'AND SET THE WIDTH OR THE HIEGHT OF IT TO A FRACTION WHICHEVER IS LESS TO THE CLIENT AREA.
        Dim dbl_Radius As Double = Math.Min(ClientSize.Width / grafx.DpiX,
            ClientSize.Height / grafx.DpiY) / bSize


        'SET THE HIEGHT AND WIDTH OF THE BALL.
        bRadiusX = CInt(dbl_Radius * grafx.DpiX)
        bRadiusY = CInt(dbl_Radius * grafx.DpiY)

        grafx.Dispose()
        'SET THE DISTANCE THAT THE BALL MOVES INTO 1 PIXEL OR THE BALL SIZE WHICHEVER IS GREATER. 
        'THIS MEANS THAT THE DISTANCE OF THE BALL MOVES EACH TIME IS PROPORTIONAL TO ITS SIZE, 
        'WHICH IS ALSO PROPORTIONAL TO THE SIZE OF THE CLIENT AREA.
        'THE BALL SLOWS DOWN WHENEVER THE CLIENT AREA IS SHRUNK
        'AND THE BALL SPEEDS UP WHEN IT IS INCREASED.


        bMoveX = CInt(Math.Max(1, bRadiusX / move_Size))
        bMoveY = CInt(Math.Max(1, bRadiusY / move_Size))
        'THE VALUE OF THE BALL'S MOVEMENT SERVES AS THE MARGIN AROUND THE BALL, 
        'THAT DETERMINES THE ACTUAL SIZE OF BITMAP ON WHICH THE BALL IS DRAWN.
        'THE DISTANCE OF THE BALL MOVES IS EQUAL TO THE SIZE OF THE BITMAP, 
        'WHICH ALLOWS THE PREVIOUS BALL'S IMAGE TO BE ERASED BEFORE THE NEXT IMAGE IS DRAWN

        btmpWidthMargin = bMoveX
        btmpHeightMargin = bMoveY

        'TO FIND OUT THE ACTUAL SIZE OF THE BITMAP ON WHICH THE BALL IS DRAWN 
        'PLUS THE MARGINS TO THE BALL'S DIMENSIONS.
        bBitmapWidth = 2 * (bRadiusX + btmpWidthMargin)
        bBitmapHeight = 2 * (bRadiusY + btmpHeightMargin)

        'CREATE A NEW WIDTH AND HEIGHT OF THE BITMAP.
        btmp = New Bitmap(bBitmapWidth, bBitmapHeight)
        'OBTAIN THE GRAFIX OBJECT SHOWN BY THE BITMAP.
        grafx = Graphics.FromImage(btmp)
        'CLEAR THE EXISTING BALL AND DRAW A NEW BALL.
        With grafx
            .Clear(BackColor)
            .FillEllipse(Brushes.HotPink, New Rectangle(bMoveX,
                bMoveY, 2 * bRadiusX, 2 * bRadiusY))
            .Dispose()
        End With

        'RESET THE POSITION OF THE BALL TO THE CENTER OF THE CLIENT AREA.
        bPositionX = CInt(ClientSize.Width / 2)
        bPositionY = CInt(ClientSize.Height / 2)
    End Sub
End Class
