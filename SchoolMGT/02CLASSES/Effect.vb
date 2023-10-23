Module Effect
    Public Sub Fadein()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.4
            ftmdiMainForm.Opacity = fade
            ftmdiMainForm.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub fadeout()
        Dim fade As Double
        For fade = 1.1 To 0.0 Step -0.1
            ftmdiMainForm.Opacity = fade
            ftmdiMainForm.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub fadeoutlogin()
        Dim fade As Double
        For fade = 1.1 To 0.0 Step -0.1
            ftLoginForm.Opacity = fade
            ftLoginForm.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub fadeoutabout()
        Dim fade As Double
        For fade = 1.1 To 0.0 Step -0.1
            About.Opacity = fade
            About.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub Fadeinlogin()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.1
            ftLoginForm.Opacity = fade
            ftLoginForm.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    
    Public Sub fadeinabout()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.1
            About.Opacity = fade
            About.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
   
   
End Module
