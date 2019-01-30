Public Class Form1

    'Déclaration d'un objet MonMario avec la classe Mario

    Dim MonMario As Mario


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Gestion des touches

        Me.KeyPreview = True

        'Déplacement de l'objet MonMario

        MonMario = New Mario(Me.ImageMario.Location, Me.ImageMario.Size)

    End Sub


    Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Z

                MonMario.Up()

            Case Keys.S

                MonMario.Down()

            Case Keys.Q

                MonMario.Left()

            Case Keys.D

                MonMario.Right()

        End Select

        Me.ImageMario.Location = MonMario.Position

    End Sub


    Private Sub ButtonRightFunc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRight.Click

        'On le fait avancer

        MonMario.Right()

        'On recupère la nouvelle position

        Me.ImageMario.Location = MonMario.Position

    End Sub


    Private Sub ButtonLeftFunc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLeft.Click

        'On le fait reculer

        MonMario.Left()

        'On recupère la nouvelle position

        Me.ImageMario.Location = MonMario.Position

    End Sub


    Private Sub ButtonDownFunc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDown.Click

        'On le fait descendre

        MonMario.Down()

        'On recupère la nouvelle position

        Me.ImageMario.Location = MonMario.Position

    End Sub


    Private Sub ButtonUpFunc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUp.Click

        'On le fait monter

        MonMario.Up()

        'On recupère la nouvelle position

        Me.ImageMario.Location = MonMario.Position

    End Sub


End Class