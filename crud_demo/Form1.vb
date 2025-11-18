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

        Dim query As String = "INSERT INTO students_tbl(name , age , email) VALUES (@name , @age ,@email)"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=crud_demo_db")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@age", TextBoxAge.Text)
                    cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Record insert Succesfully!!!")

                End Using

            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class
