Imports System.Data
Imports System.Data.OleDb
Public Class AssignStudent

    Private Sub btnSearchClassID_Click(sender As Object, e As EventArgs) Handles btnSearchClassID.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Class Where ClassID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("ClassID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Class Where ClassroomName = ?, TeacherName = ?, Subject = ?, PeriodDate = ?, StudentName = ?"
                            TextBox2.Text = reader("ClassroomName").ToString()
                            TextBox3.Text = reader("TeacherName").ToString()
                            TextBox4.Text = reader("Subject").ToString()
                            TextBox5.Text = reader("PeriodDate").ToShortDateString()
                            TextBox6.Text = reader("StudentName").ToString()
                        End While
                    Else
                        MsgBox("Class ID does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Update Class Set StudentName = @StudentName Where (ClassID = @ClassID)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@StudentName", TextBox6.Text)
                cmd.Parameters.AddWithValue("@ClassID", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Student names have been added into classroom!")
            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub
End Class