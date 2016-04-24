Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Weight As Integer
        Dim SD As Double
        Dim Textsd As String
        Weight = TextBox1.Text
        SD = Weight + 110
        TextBox3.Text = SD
        If SD <= 159 Then
            Textsd = "ไม่ผ่านเกณฑ์มาตรฐาน"
        ElseIf SD >= 160 Then
            Textsd = "ผ่านเกณฑ์มาตรฐาน"

        End If
        TextBox2.Text = Textsd

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mbr As MsgBoxResult
        mbr = MsgBox("ออกจากโปรแกรมหรือไม่?",
        MsgBoxStyle.OkCancel + _
        MsgBoxStyle.Question + _
        MsgBoxStyle.ApplicationModal, _
        "ออกจากโปรแกรม")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub
End Class
