Public Class Class1

    Public Sub New()

    End Sub

    Public Sub Exec()

#If NET48
        Console.WriteLine("I should not be grey.")
#End If

#If NET6_0
        Console.WriteLine("I should be grey.")
#End If

        Dependency.Class1.Write()
    End Sub

End Class
