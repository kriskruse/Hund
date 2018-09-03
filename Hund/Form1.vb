Public Class Form1
    'Diffinere de variables som bliver brugt i programmet
    Dim sult As Integer
    Dim energi As Integer
    Dim uge As Integer
    Dim dage As Integer
    Dim hr As Integer
    Dim min As Integer
    Dim sek As Integer
    Dim doed As String
    Dim death_time As Integer


    Private Sub Form_1Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' angiver variablernes værdier ved programstart, samt starter timeren.
        sult = 0
        energi = 100
        uge = 0
        dage = 0
        hr = 0
        min = 0
        sek = 0
        death_time = 0
        timer.Enabled = True ' timer starter
    End Sub

    Private Sub btn1time_Click(sender As Object, e As EventArgs) Handles btn1time.Click
        'Når der bliver trykket på knap med label "1 time"
        nextHour()
    End Sub

    Private Sub btnMad_Click(sender As Object, e As EventArgs) Handles btnMad.Click
        'Når der bliver trykket på knappen med label "mad"
        If sult >= 100 Then sult -= 100 Else sult = 0 'tjekker om værdien for sult er højere eller mindre end 100, for at undgå minus værdier
        energi += 50 'hunden får mere energi efter den er blevet fodret

    End Sub

    Private Sub btnGaatur_Click(sender As Object, e As EventArgs) Handles btnGaatur.Click
        'Når der bliver trykket på knappen med lable "gå tur" 
        energi = 0 'hunden har gået tur og energi bliver sat til 0
        sult += 50 'efter at have gået tur, hunden bliver lidt sulten
    End Sub

    Private Sub nextHour()
        'funktion for tid
        sek += 10 'tiden går fremad
        opdater() 'kalder funktion opdater
    End Sub

    Private Sub reform()
        'tjekker tid, omregner sek til min og min til timer m.m
        If sek >= 60 Then min += 1 'tjekker for 60 sek, og hvis rigtig giver min +1
        If sek >= 60 Then sek = 0 'Tjekker for 60 sek, og hvis rigtig resetter sek til 0
        If min >= 60 Then hr += 1
        If min >= 60 Then sult += 5
        If min >= 60 Then min = 0
        If hr >= 24 Then dage += 1 'samme  ide men med tjek efter 24 i stedet for
        If hr >= 24 Then hr = 0
        If dage >= 7 Then uge += 1 'samme ide men med tjek efter 7 i stedet for
        If dage >= 7 Then dage = 0
    End Sub


    Private Sub opdater()
        'Opdatere alle text og lables felter, så den nye værdi bliver vist til brugeren
        lblTid.Text = uge & "-" & dage & "-" & hr & ":" & min & ":" & sek 'opdatere tid
        lblSult.Text = sult 'opdatere sult
        lblEnergi.Text = energi 'opdatere energi
        doed_do()

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        'timer funktion, bliver kaldt hver 1ms
        nextHour()
        reform()
    End Sub



    Private Sub doed_do()
        'funktion som tjekker efter om hunden mærkeres som død
        If sult >= 100 Or energi >= 1000 Then 'tjekker sult og energi
            doed = "Din hund er død" 'hvis en af dem er true, sætter en text
            lbldoed.Text = doed 'opdatere en gemt tekstbox så bruger kan se besked
            timer.Enabled = False ' slukker timer
            Death.Enabled = True ' starter en ny timer
        End If
    End Sub

    Private Sub Death_Tick(sender As Object, e As EventArgs) Handles Death.Tick
        'timer som starter når hund er "død" 
        death_time += 1 'tæller, går en op hvergang der er tick
        If death_time = 100 Then 'tjekker efter 100 tick
            End 'lukker program
        End If
    End Sub
End Class
