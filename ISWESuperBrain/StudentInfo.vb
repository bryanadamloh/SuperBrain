﻿Imports System.Data
Imports System.Data.OleDb

Public Class StudentInfo

    Private Sub StudentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Insert into Student (StudentName, StudentAge, NoOfSubjects, SubjectName) Values (@StudentName, @StudentAge, @NoOfSubjects, @SubjectName)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@StudentName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@StudentAge", TextBox3.Text)
                cmd.Parameters.AddWithValue("@NoOfSubjects", TextBox4.Text)
                cmd.Parameters.AddWithValue("@SubjectName", TextBox5.Text)
                cmd.ExecuteNonQuery()
                MsgBox("New student has been added!")
            End Using
            conn.Close()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Student Where StudentID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("StudentID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Student Where StudentName = ? AND StudentAge = ? AND NoOfStudents = ? AND SubjectName = ?"
                            TextBox2.Text = reader("StudentName").ToString()
                            TextBox3.Text = reader("StudentAge").ToString()
                            TextBox4.Text = reader("NoOfSubjects").ToString()
                            TextBox5.Text = reader("SubjectName").ToString()
                        End While
                    Else
                        MsgBox("This student does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Update Student Set StudentName = @StudentName, StudentAge = @StudentAge, NoOfSubjects = @NoOfSubjects, SubjectName = @SubjectName Where (StudentID = @StudentID)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@StudentName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@StudentAge", TextBox3.Text)
                cmd.Parameters.AddWithValue("@NoOfSubjects", TextBox4.Text)
                cmd.Parameters.AddWithValue("@SubjectName", TextBox5.Text)
                cmd.Parameters.AddWithValue("@StudentID", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Student information has been updated!")
            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Student Where StudentID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("StudentID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim SqlString1 As String = "Delete * From Student Where StudentID = ?"
                        Dim cmd1 As OleDbCommand = New OleDbCommand(SqlString1, conn)
                        cmd1.CommandType = CommandType.Text
                        cmd1.Parameters.AddWithValue("StudentID", TextBox1.Text)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Student Information has been successfully deleted!")
                    Else
                        MsgBox("Student ID does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class