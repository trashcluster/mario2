Public Class Mario


    Private CoordonneesActuelles As Point

    Private Taille As Size


    Sub New(ByVal PositionOrigine As Point, ByVal TailleMario As Size)

        CoordonneesActuelles = New Point(PositionOrigine)

        Taille = New Size(TailleMario)

    End Sub


    Public Sub Right()

        CoordonneesActuelles.X = CoordonneesActuelles.X + _PasX()

    End Sub


    Public Sub Left()

        CoordonneesActuelles.X = CoordonneesActuelles.X - _PasX()

    End Sub


    Public Sub Up()

        CoordonneesActuelles.Y = CoordonneesActuelles.Y - _PasY()

    End Sub


    Public Sub Down()

        CoordonneesActuelles.Y = CoordonneesActuelles.Y + _PasY()

    End Sub


    Public Property Position() As Point

        Get

            Return CoordonneesActuelles

        End Get

        Set(ByVal value As Point)

            CoordonneesActuelles = value

        End Set

    End Property



    Private Function _PasX()

        Return Taille.Width

    End Function


    Private Function _PasY()

        Return Taille.Height

    End Function



End Class