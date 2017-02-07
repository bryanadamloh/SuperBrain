Public Class MainMenu
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Add/Modify/Delete Student"
                StudentInfo.Show()
            Case "Assignning Classroom"
                AssignStudent.Show()
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Add/Modify/Delete Teacher"
                TeacherInfo.Show()
            Case "Assignning Teacher To Classroom"
                AssignTeacher.Show()
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SubjectInfo.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StaffInfo.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClassroomInfo.Show()
    End Sub
End Class