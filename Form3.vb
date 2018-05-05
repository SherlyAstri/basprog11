Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BT_CARI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CARI.Click
        If cb_JANG.SelectedIndex < 9.6 Or cb_JANG.SelectedIndex > 8.6 And cb_WARNA.SelectedIndex = 1 Then
            txt.Text = "FENOLFTALEIN"
        ElseIf cb_JANG.SelectedIndex < 6.2 Or cb_JANG.SelectedIndex > 4.2 And cb_WARNA.SelectedIndex = 1 Or
            txt.Text = "METIL MERAH" Then
        ElseIf cb_JANG.SelectedIndex < 4.6 Or cb_JANG.SelectedIndex > 3.1 And cb_WARNA.SelectedIndex = 1 Or
           txt.Text = "JINGGA METIL" Then
        ElseIf cb_JANG.SelectedIndex < 7.6 Or cb_JANG.SelectedIndex > 6 And cb_WARNA.SelectedIndex = 3 Or
       txt.Text = "BROMOTIMOL BIRU" Then
        ElseIf cb_JANG.SelectedIndex < 8.4 Or cb_JANG.SelectedIndex > 6.8 And cb_WARNA.SelectedIndex = 3 Then
            txt.Text = "FENOL MERAH"

        End If
    End Sub

    Private Sub BT_BERSIH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_BERSIH.Click
        TXT_NAMA.Clear()
        cb_JANG.ResetText()
        cb_WARNA.ResetText()
        txt.Clear()

    End Sub

    Private Sub BT_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_OK.Click
        Close()
    End Sub
End Class