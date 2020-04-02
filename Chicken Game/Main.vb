Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Main
    Dim radius As Integer

    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radius = 30

        Dim ellipseRadius As New Drawing2D.GraphicsPath
        ellipseRadius.StartFigure()

        ellipseRadius.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        ellipseRadius.AddLine(10, 0, ContentPanel.Width - 20, 0)

        ellipseRadius.AddArc(New Rectangle(ContentPanel.Width - radius, 0, radius, radius), -90, 90)
        ellipseRadius.AddLine(ContentPanel.Width, 20, ContentPanel.Width, ContentPanel.Height - radius)

        ellipseRadius.AddArc(New Rectangle(ContentPanel.Width - radius, ContentPanel.Height - radius, radius, radius), 0, 90)
        ellipseRadius.AddLine(ContentPanel.Width - radius, ContentPanel.Height, 20, ContentPanel.Height)

        ellipseRadius.AddArc(New Rectangle(0, ContentPanel.Height - radius, radius, radius), 90, 90)

        ellipseRadius.CloseFigure()

        ContentPanel.Region = New Region(ellipseRadius)


        Dim mainRadius As New Drawing2D.GraphicsPath
        mainRadius.StartFigure()

        mainRadius.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        mainRadius.AddLine(10, 0, Me.Width - 20, 0)

        mainRadius.AddArc(New Rectangle(Me.Width - radius, 0, radius, radius), -90, 90)
        mainRadius.AddLine(Me.Width, 20, Me.Width, Me.Height - radius)

        mainRadius.AddArc(New Rectangle(Me.Width - radius, Me.Height - radius, radius, radius), 0, 90)
        mainRadius.AddLine(Me.Width - radius, Me.Height, 20, Me.Height)

        mainRadius.AddArc(New Rectangle(0, Me.Height - radius, radius, radius), 90, 90)

        mainRadius.CloseFigure()

        Me.Region = New Region(mainRadius)

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = WindowState.Minimized

    End Sub

    Private Sub MaximizeButton_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If

        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CuRWidth) / CuRWidth

        For Each CtrL As Control In Controls
            CtrL.Width += CtrL.Width * RatioWidth
            CtrL.Left += CtrL.Left * RatioWidth
            CtrL.Top += CtrL.Top * RatioHeight
            CtrL.Height += CtrL.Height * RatioHeight
        Next

        CuRHeight = Me.Height
        CuRWidth = Me.Width

    End Sub

    Private Sub TopPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub TopPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub TopPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseUp
        draggable = False
    End Sub
End Class