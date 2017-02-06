Imports System.Data
Imports System.Data.OleDb

Public Class TeacherInfo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Insert into Teacher (TeacherName, SubjectTeach) Values (@TeacherName, @SubjectTeach)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@TeacherName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@SubjectTeach", TextBox3.Text)
                cmd.ExecuteNonQuery()
                MsgBox("New Teacher has been added!")
            End Using
            conn.Close()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Teacher Where TeacherID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("TeacherID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Teacher Where TeacherName = ? AND SubjectTeach = ?"
                            TextBox2.Text = reader("TeacherName").ToString()
                            TextBox3.Text = reader("SubjectTeach").ToString()
                        End While
                    Else
                        MsgBox("Teacher ID does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Update Teacher Set TeacherName = @TeacherName, SubjectTeach = @SubjectTeach Where (TeacherID = @TeacherID)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@TeacherName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@SubjectTeach", TextBox3.Text)
                cmd.Parameters.AddWithValue("@TeacherID", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Teacher's Information has been updated!")
            End Using
            conn.Open()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Teacher Where TeacherID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("TeacherID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim SqlString1 As String = "Delete * From Teacher Where TeacherID = ?"
                        Dim cmd1 As OleDbCommand = New OleDbCommand(SqlString1, conn)
                        cmd1.CommandType = CommandType.Text
                        cmd1.Parameters.AddWithValue("TeacherID", TextBox1.Text)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Teacher's Information has been successfully deleted!")
                    Else
                        MsgBox("Teacher ID does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class