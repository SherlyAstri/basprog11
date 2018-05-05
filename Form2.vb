Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 31
            cmbtgl.Items.Add(i)
        Next
        For i = 1 To 12
            cmbbln.Items.Add(MonthName(i))
        Next
        For i = 1956 To 2018
            cm_tahun.Items.Add(i)
        Next
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        TXT_HASIL.Text = TXT_NAMA.Text & ", Anda lahir pada " & cmbtgl.Text & " " & cmbbln.Text & "  " & cm_tahun.Text & "  " & "penilaian mu terhadap pekerjaan,>>" & txttinggi.Text & " " & " silahkan tekan nested" & " JIKA INGIN MENGETAHUI HASIL MU , penilaian anda dinilai dalam besarnya segitiga mu jika segitigamu kecil maka penilaian mu kecil jika penilaian mu besar maka segitigamu besar juga terhadap penilain mu " & "   TETAP SEMANGAT DAN TERUS BERJUANG!!"
    End Sub

    Private Sub btnnstd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnstd.Click
        Dim i, j, tinggi As Integer
        Dim output As String
        output = ""
        tinggi = txttinggi.Text

        For i = 0 To tinggi - 1
            For j = 0 To i
                output = output & " " & "*"
            Next
            output = output & vbCrLf
        Next
        MsgBox(output)

    End Sub

    Private Function Yearname(ByVal j As Integer) As Object
        Throw New NotImplementedException
    End Function

    Private Sub btnbersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbersih.Click
        TXT_HASIL.Clear()
        TXT_NAMA.Clear()
        cm_tahun.ResetText()
        cmbbln.ResetText()
        cmbtgl.ResetText()
        txttinggi.Clear()
    End Sub

    Private Sub bt_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_keluar.Click
        Close()
    End Sub

    Private Sub TXT_HASIL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_HASIL.TextChanged

    End Sub
End Class