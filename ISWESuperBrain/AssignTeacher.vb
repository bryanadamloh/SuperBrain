Imports System.Data
Imports System.Data.OleDb
Public Class AssignTeacher
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
                            Dim SqlString1 As String = "Select * From Class Where ClassroomID = ?, ClassroomName = ?"
                            TextBox2.Text = reader("ClassroomID").ToString()
                            TextBox3.Text = reader("ClassroomName").ToString()
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
        Dim SqlString As String = "Update Class Set TeacherName = @TeacherName, PeriodDate = @PeriodDate, PeriodTime = @PeriodTime Where (ClassID = @ClassID)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@TeacherName", TextBox4.Text)
                cmd.Parameters.AddWithValue("@PeriodDate", TextBox5.Text)
                cmd.Parameters.AddWithValue("@PeriodTime", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@ClassID", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Teacher has been assigned with date and time!")
            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        End Using
    End Sub
End Class