Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Main
    Dim radius As Integer
    Dim lineRadius As Integer

    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim isPlayer1Turn As Boolean = True

    Dim slot1Filled As Boolean = False
    Dim slot2Filled As Boolean = False
    Dim slot3Filled As Boolean = False
    Dim slot4Filled As Boolean = False
    Dim slot5Filled As Boolean = False
    Dim slot6Filled As Boolean = False
    Dim slot7Filled As Boolean = False
    Dim slot8Filled As Boolean = False
    Dim slot9Filled As Boolean = False


    Private Function CreateRoundObj(width As Integer, height As Integer, radius As Integer) As Drawing2D.GraphicsPath

        Dim ellipseRadius As New Drawing2D.GraphicsPath
        ellipseRadius.StartFigure()
        ellipseRadius.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        ellipseRadius.AddLine(10, 0, width - 20, 0)
        ellipseRadius.AddArc(New Rectangle(width - radius, 0, radius, radius), -90, 90)
        ellipseRadius.AddLine(width, 20, width, height - radius)
        ellipseRadius.AddArc(New Rectangle(width - radius, height - radius, radius, radius), 0, 90)
        ellipseRadius.AddLine(width - radius, height, 20, height)
        ellipseRadius.AddArc(New Rectangle(0, height - radius, radius, radius), 90, 90)
        ellipseRadius.CloseFigure()

        Return ellipseRadius
    End Function

    Private Function ClearGame()
        GameButton1.Image = Nothing
        GameButton2.Image = Nothing
        GameButton3.Image = Nothing
        GameButton4.Image = Nothing
        GameButton5.Image = Nothing
        GameButton6.Image = Nothing
        GameButton7.Image = Nothing
        GameButton8.Image = Nothing
        GameButton9.Image = Nothing

        slot1Filled = False
        slot2Filled = False
        slot3Filled = False
        slot4Filled = False
        slot5Filled = False
        slot6Filled = False
        slot7Filled = False
        slot8Filled = False
        slot9Filled = False

        isPlayer1Turn = True

    End Function


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lineRadius = 10

        Me.Region = New Region(CreateRoundObj(Me.Width, Me.Height, 30))

        ContentPanel.Region = New Region(CreateRoundObj(ContentPanel.Width, ContentPanel.Height, 30))

        Line1.Region = New Region(CreateRoundObj(Line1.Width, Line1.Height, lineRadius))
        Line2.Region = New Region(CreateRoundObj(Line2.Width, Line2.Height, lineRadius))
        Line3.Region = New Region(CreateRoundObj(Line3.Width, Line3.Height, lineRadius))
        Line4.Region = New Region(CreateRoundObj(Line4.Width, Line4.Height, lineRadius))

        ResetButton.Region = New Region(CreateRoundObj(ResetButton.Width, ResetButton.Height, 20))

        ClearGame()

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



    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearGame()
    End Sub


    Private Sub GameButton1_Click(sender As Object, e As EventArgs) Handles GameButton1.Click
        If slot1Filled = False Then
            If isPlayer1Turn = True Then
                GameButton1.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton1.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot1Filled = True
        End If
    End Sub

    Private Sub GameButton2_Click(sender As Object, e As EventArgs) Handles GameButton2.Click
        If slot2Filled = False Then
            If isPlayer1Turn = True Then
                GameButton2.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton2.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot2Filled = True
        End If
    End Sub

    Private Sub GameButton3_Click(sender As Object, e As EventArgs) Handles GameButton3.Click
        If slot3Filled = False Then
            If isPlayer1Turn = True Then
                GameButton3.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton3.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot3Filled = True
        End If
    End Sub


    Private Sub GameButton4_Click(sender As Object, e As EventArgs) Handles GameButton4.Click
        If slot4Filled = False Then
            If isPlayer1Turn = True Then
                GameButton4.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton4.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot4Filled = True
        End If
    End Sub

    Private Sub GameButton5_Click(sender As Object, e As EventArgs) Handles GameButton5.Click
        If slot5Filled = False Then
            If isPlayer1Turn = True Then
                GameButton5.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton5.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot5Filled = True
        End If
    End Sub

    Private Sub GameButton6_Click(sender As Object, e As EventArgs) Handles GameButton6.Click
        If slot6Filled = False Then
            If isPlayer1Turn = True Then
                GameButton6.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton6.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot6Filled = True
        End If
    End Sub


    Private Sub GameButton7_Click(sender As Object, e As EventArgs) Handles GameButton7.Click
        If slot7Filled = False Then
            If isPlayer1Turn = True Then
                GameButton7.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton7.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot7Filled = True
        End If
    End Sub

    Private Sub GameButton8_Click(sender As Object, e As EventArgs) Handles GameButton8.Click
        If slot8Filled = False Then
            If isPlayer1Turn = True Then
                GameButton8.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton8.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot8Filled = True
        End If
    End Sub

    Private Sub GameButton9_Click(sender As Object, e As EventArgs) Handles GameButton9.Click
        If slot9Filled = False Then
            If isPlayer1Turn = True Then
                GameButton9.Image = Chicken_Game.My.Resources.game_circle
                isPlayer1Turn = False
            Else isPlayer1Turn = False
                GameButton9.Image = Chicken_Game.My.Resources.game_x
                isPlayer1Turn = True
            End If

            slot9Filled = True
        End If
    End Sub

End Class