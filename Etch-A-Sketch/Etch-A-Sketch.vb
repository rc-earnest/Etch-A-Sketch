'Rudy Earnest  
'RCET 2265
'Spring 2025
'Etch-A-Sketch
'https://github.com/rc-earnest/Etch-A-Sketch.git
Option Explicit On
Option Strict On
Option Compare Text

Imports System.Media
Imports System.Threading.Thread


Public Class EtchASketch

    ' Class-level variables for shared resources
    Private _foreColor As Color = Color.Black
    Private _penWidth As Integer = 1
    Private _isDrawing As Boolean = False

    ' Public properties to access and modify drawing settings
    Public Property ForegroundColor() As Color
        Get
            Return _foreColor
        End Get
        Set(value As Color)
            _foreColor = value
        End Set
    End Property

    Public Property PenWidth() As Integer
        Get
            Return _penWidth
        End Get
        Set(value As Integer)
            If value > 100 Then
                _penWidth = 100
            ElseIf value > 0 Then
                _penWidth = value
            End If
        End Set
    End Property

    ' Sub to draw on the picture box
    Sub DrawOnPictureBoxMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor, PenWidth())
        g.DrawLine(pen, oldX, oldY, newX, newY)
        g.Dispose()
    End Sub

    ' Handles mouse events for drawing and displaying coordinates
    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Static oldX As Integer
        Static oldY As Integer

        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString} FG {ForegroundColor.ToString}"

        ' Only draw when the left mouse button is pressed
        If _isDrawing Then
            Dim g As Graphics = DrawingPictureBox.CreateGraphics
            DrawOnPictureBoxMouse(oldX, oldY, e.X, e.Y)
            g.Dispose()
        End If

        oldX = e.X
        oldY = e.Y
    End Sub

    ' Handles the MouseDown event to start drawing
    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        If e.Button = MouseButtons.Left Then
            _isDrawing = True
        ElseIf e.Button = MouseButtons.Middle Then
            'show color dialog on middle mouse click
            ChangeForegroundColor(sender, e)
        End If
    End Sub

    ' Handles the MouseUp event to stop drawing
    Private Sub DrawingPictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseUp
        If e.Button = MouseButtons.Left Then
            _isDrawing = False
        End If
    End Sub

    ' Handles the Color selection button and menu item clicks
    Private Sub ChangeForegroundColor(sender As Object, e As EventArgs) Handles SelectColorButton.Click, SelectColorContextMenuItem.Click, SelectColorTopMenuItem.Click
        Using colorDialog As New ColorDialog()
            Dim result As DialogResult = colorDialog.ShowDialog()
            If result = DialogResult.OK Then
                ForegroundColor = colorDialog.Color
            End If
        End Using
    End Sub

    ' Handles the Clear button and menu item clicks
    Private Sub ClearPictureBox(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearContextMenuItem.Click, ClearTopMenuItem.Click
        Dim shakiness As Integer = 100
        'https://freesound.org/
        Try
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For i = 1 To 25
            Me.Top += shakiness
            Me.Left += shakiness
            Sleep(100)
            shakiness *= -1
        Next

        DrawingPictureBox.Refresh()
        _isDrawing = False
    End Sub


    ' Handles the Exit button and menu item clicks
    Private Sub ExitApplication(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitContextMenuItem.Click, ExitTopMenuItem.Click
        Me.Close()
    End Sub
End Class
