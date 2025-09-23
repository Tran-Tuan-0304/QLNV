Imports System.Data
Imports System.Data.SqlClient

Module thuvien
    Public cnn As SqlConnection
    Public cmd As SqlCommand
    Public sql As String

    ' Hàm kết nối
    Public Function ketnoi() As SqlConnection
        Dim connectionString As String = "Data Source=LAPTOP-IIR4D865\SQLEXPRESS01;Initial Catalog=QLNhanVien;Trusted_Connection=True"
        cnn = New SqlConnection(connectionString)
        Return cnn
    End Function

    ' Hàm lấy dữ liệu trả về DataTable
    Public Function LayDL(sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using cnn = ketnoi()
                cnn.Open()
                Dim da As New SqlDataAdapter(sql, cnn)
                da.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lấy dữ liệu: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Hàm thực hiện SQL (Insert, Update, Delete)
    Public Function ThucHienSQL(sql As String) As Boolean
        Try
            Using cnn = ketnoi()
                cnn.Open()
                cmd = New SqlCommand(sql, cnn)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thực hiện SQL: " & ex.Message)
            Return False
        End Try
    End Function
End Module
