'
Public Class Zadatak1PB
    '
    Inherits System.Web.UI.Page
    '
    Structure tipULAZ
        '
        Dim Placa As Double, Dani As Single, Zarada As Double
        '
    End Structure
    '
    Structure tipIZLAZ
        '
        Dim Nista As Boolean, Dani As Integer, Sati As Integer
        '
    End Structure
    '
    Dim ulaz As tipULAZ, izlaz As tipIZLAZ
    '
    Public Sub Promjena()
        '
        ulaz.Placa = CDbl(Val(txtPlaca.Text))
        ulaz.Dani = CSng(Val(txtDani.Text))
        ulaz.Zarada = CDbl(Val(txtZarada.Text))
        Racun()
        lblRjesenje.Text = Ispis()
        '
    End Sub
    '
    Private Sub Racun()
        '
        Dim brojSati As Double = ulaz.Dani * 8.0#
        '
        If ulaz.Dani = 0 Then
            '
            izlaz.Nista = True
            '
        Else
            '
            izlaz.Nista = False
            Dim cijenaSata As Double = ulaz.Placa / brojSati
            Dim satiDecimalno As Double = ulaz.Zarada / cijenaSata
            '
            izlaz.Dani = Int(satiDecimalno / 8.0#)
            Dim ostaloSati As Double = satiDecimalno - izlaz.Dani * 8.0#
            izlaz.Sati = Int(ostaloSati) + 1
            '
            If izlaz.Sati = 8 Then
                '
                izlaz.Sati = 0
                izlaz.Dani = izlaz.Dani + 1
                '
            End If
            '
        End If
        '
    End Sub
    '
    Public Function Ispis() As String
        '
        Dim s As String = ""
        '
        If izlaz.Nista Then
            '
            s = ""
            '
        Else
            '
            If izlaz.Dani = 0 And izlaz.Sati = 0 Then
                '
                s = "Manje od 1 sata"
                '
            ElseIf izlaz.Dani = 0 And izlaz.Sati > 0 Then
                '
                s = Str(izlaz.Sati) & sufiksBrojSati()
                '
            ElseIf izlaz.Dani > 0 And izlaz.Sati = 0 Then
                '
                s = Str(izlaz.Dani) & " " & sufiksBrojDana()
                '
            Else
                '
                s = Str(izlaz.Dani) & " " & sufiksBrojDana()
                s = s & " i " & Str(izlaz.Sati) & sufiksBrojSati()
                '
            End If
            '
        End If
        '
        Return s
        '
    End Function
    '
    Private Function sufiksBrojSati() As String
        '
        Select Case izlaz.Sati
                '
            Case 1 : Return " sat"
            Case 2 : Return " sata"
            Case 3 : Return " sata"
            Case 4 : Return " sata"
            Case Else : Return " sati"
                '
        End Select
        '
    End Function
    '
    Private Function sufiksBrojDana() As String
        '
        If Right(Trim(Str(izlaz.Dani)), 1) = "1" Then
            '
            Return "dan"
            '
        Else
            '
            Return "dana"
            '
        End If
        '
    End Function
    '
    Private Sub Zadatak1PB_Load(sender As Object, e As EventArgs) Handles Me.PreRender
        '
        Promjena()
        '
    End Sub
    '
End Class