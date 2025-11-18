Imports MySql.Data.MySqlClient
Public Class Form1

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=crud_demo_db"

        Try
            conn.Open()
            MessageBox.Show("Connection Successful")
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error connecting to database: " & ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click


    End Sub
End Class
