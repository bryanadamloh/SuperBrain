Public Class MainMenu
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Add/Modify/Delete Student"
                StudentInfo.Show()
            Case "Assignning Classroom"
                AssignClassroom.Show()
        End Select
    End Sub

End Class