Public Class FormLista2
    Public Sub selectedSong()
        If ListBox1.SelectedItem = "Cancion1.1" Then
            My.Computer.Audio.Play(My.Resources.Resource1.Road_Trip,
                AudioPlayMode.BackgroundLoop)
        End If
        If (ListBox1.SelectedItem = "Cancion2.2") Then
            My.Computer.Audio.Play(My.Resources.Resource1.The_Best_Time,
      AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Public Sub backSong()
        ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
        If (ListBox1.SelectedIndex < 0) Then
            ListBox1.SelectedIndex = 1

        End If
        selectedSong()
    End Sub

    Public Sub nextSong()
        If (ListBox1.SelectedItem = "Cancion1.1") Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        Else
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
        End If
        selectedSong()
    End Sub
End Class