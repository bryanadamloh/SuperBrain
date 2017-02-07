Imports System.Data
Imports System.Data.OleDb
Public Class StaffInfo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Insert Into Staff (StaffName, StaffPassword) Values (@StaffName, @StaffPassword)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@StaffName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@StaffPassword", TextBox3.Text)
                cmd.ExecuteNonQuery()
                MsgBox("New Staff has been added!")
            End Using
            conn.Close()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Staff Where StaffID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("StaffID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Staff Where StaffName = ? AND StaffPassword = ?"
                            TextBox2.Text = reader("StaffName").ToString()
                            TextBox3.Text = reader("StaffPassword").ToString()
                        End While
                    Else
                        MsgBox("This Staff does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Update Staff Set StaffName = @StaffName, StaffPassword = @StaffPassword Where (StaffID = @StaffID)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@StaffName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@StaffPassword", TextBox3.Text)
                cmd.Parameters.AddWithValue("@StaffID", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Staff's Information has been successfully updated!")
            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Staff Where StaffID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@StaffID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim SqlString1 As String = "Delete * From Staff Where StaffID = ?"
                        Dim cmd1 As OleDbCommand = New OleDbCommand(SqlString1, conn)
                        cmd1.CommandType = CommandType.Text
                        cmd1.Parameters.AddWithValue("StaffID", TextBox1.Text)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Staff Information has been successfully deleted!")
                    Else
                        MsgBox("Staff ID does not exists!")
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