Imports System.Data
Imports System.Data.OleDb
Public Class Payment

    Private Sub btnSearchClassID_Click(sender As Object, e As EventArgs) Handles btnSearchClassID.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Student Where StudentID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("StudentID", TextBox2.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Student Where StudentName = ?"
                            TextBox3.Text = reader("StudentName").ToString()
                        End While
                    Else
                        MsgBox("Student ID does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub btnPaymentID_Click(sender As Object, e As EventArgs) Handles btnPaymentID.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Payment Where PaymentID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("PaymentID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Payment Where StudentID = ?, StudentName = ?, TotalFee = ?, PaymentDate = ?"
                            TextBox2.Text = reader("StudentID").ToString()
                            TextBox3.Text = reader("StudentName").ToString()
                            TextBox5.Text = reader("TotalFee").ToString()
                            TextBox6.Text = reader("PaymentDate").ToString()
                        End While
                    Else
                        MsgBox("Payment ID does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim number As Integer
        Dim Total As Integer = 0
        number = Val(TextBox4.Text)

        Total = number * 15
        TextBox5.Text = Total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Update Payment Set StudentID = @StudentID, StudentName = @StudentName, TotalFee = @TotalFee, PaymentDate = @PaymentDate Where (PaymentID = @PaymentID)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
            End Using
        End Using
    End Sub
End Class