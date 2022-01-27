Public Class FormLista1
    Public Sub selectedSong()
        If ListBox1.SelectedItem = "Cancion1" Then
            My.Computer.Audio.Play(My.Resources.Resource1.LazyWalk,
                AudioPlayMode.BackgroundLoop)
        End If
        If (ListBox1.SelectedItem = "Cancion2") Then
            My.Computer.Audio.Play(My.Resources.Resource1.Make_It_Happen,
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
        If (ListBox1.SelectedItem = "Cancion1") Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        Else
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
        End If
        selectedSong()
    End Sub
End Class