Imports System.Data
Imports System.Data.OleDb
Public Class ClassroomInfo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Insert Into Classroom (ClassroomName, MaximumStudent) Values (@ClassroomName, @MaximumStudent)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@ClassroomName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@MaximumStudent", TextBox3.Text)
                cmd.ExecuteNonQuery()
                MsgBox("New Classroom has been added!")
            End Using
            conn.Close()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Classroom Where ClassroomID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("ClassroomID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * Classroom Where ClassroomName = ? AND MaximumStudent = ?"
                            TextBox2.Text = reader("ClassroomName").ToString
                            TextBox3.Text = reader("MaximumStudent").ToString
                        End While
                    Else
                        MsgBox("Classroom ID does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Update Classroom Set ClassroomName = @ClassroomName, MaximumStudent = @MaximumStudent Where (ClassroomID = @ClassroomID)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@ClassroomName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@MaximumStudent", TextBox3.Text)
                cmd.Parameters.AddWithValue("@ClassroomID", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Classroom's Information has been successfully updated!")
            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Classroom Where ClassroomID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@ClassroomID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim SqlString1 As String = "Delete * From Classroom Where ClassroomID = ?"
                        Dim cmd1 As OleDbCommand = New OleDbCommand(SqlString1, conn)
                        cmd1.CommandType = CommandType.Text
                        cmd1.Parameters.AddWithValue("ClassroomID", TextBox1.Text)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Classroom Information has been successfully deleted!")
                    Else
                        MsgBox("Classroom ID does not exists!")
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