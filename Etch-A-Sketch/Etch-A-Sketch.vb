'Rudy Earnest  
'RCET 2265
'Spring 2025
'Etch-A-Sketch
'https://github.com/rc-earnest/Etch-A-Sketch.git

Option Explicit On
Option Strict On
Option Compare Text

Public Class EtchASketch
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitTopMenuItem.Click, ExitContextMenuItem.Click
        Me.Close()
    End Sub


End Class
