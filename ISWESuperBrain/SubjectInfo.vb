Imports System.Data
Imports System.Data.OleDb

Public Class SubjectInfo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Insert into Subject (SubjectName, SubjectFee) Values (@SubjectName, @SubjectFee)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@SubjectName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@SubjectFee", TextBox3.Text)
                cmd.ExecuteNonQuery()
                MsgBox("New Subject has been added!")
            End Using
            conn.Close()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Subject Where SubjectID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("SubjectID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Subject Where SubjectName = ? AND SubjectFee = ?"
                            TextBox2.Text = reader("SubjectName").ToString()
                            TextBox3.Text = reader("SubjectFee").ToString()
                        End While
                    Else
                        MsgBox("Subject ID not found!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Update Subject Set SubjectName = @SubjectName, SubjectFee = @SubjectFee Where (SubjectID = @SubjectID)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@SubjectName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@SubjectFee", TextBox3.Text)
                cmd.Parameters.AddWithValue("@SubjectID", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Subject Information has been successfully updated!")
            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Subject Where SubjectID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("SubjectID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim SqlString1 As String = "Delete * From Subject Where SubjectID = ?"
                        Dim cmd1 As OleDbCommand = New OleDbCommand(SqlString1, conn)
                        cmd1.CommandType = CommandType.Text
                        cmd1.Parameters.AddWithValue("SubjectID", TextBox1.Text)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Subject's Information has been successfully deleted!")
                    Else
                        MsgBox("Subject ID does not exists!")
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