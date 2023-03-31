using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnectivity;

class Program
{
    static string ConnectionString = "Data Source=CAMOUFLY;Database=db_hr_dts;Integrated Security=True;Connect Timeout=30;";

    static SqlConnection connection;
    static void Main(string[] args)
    {
        /*try {
            connection.Open();
            Console.WriteLine("Koneksi Berhasil Dibuka!");
            connection.Close();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }*/

        GetAllRegion();
        //InsertRegion("CahayaAsia");
    }

    // GETALL : REGION (Command)
    public static void GetAllRegion()
    {
        connection = new SqlConnection(ConnectionString);

        //Membuat instance untuk command
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = "SELECT * FROM region";

        //Membuka koneksi
        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows) {
            while (reader.Read()) {
                Console.WriteLine("Id: " + reader[0]);
                Console.WriteLine("Name: " + reader[1]);
                Console.WriteLine("====================");
            }
        } else {
            Console.WriteLine("Data not found!");
        }
        reader.Close();
        connection.Close();
    }

    // GETBYID : REGION (Command)

    // INSERT : REGION (Transaction)
    public static void InsertRegion(string name)
    {
        connection = new SqlConnection(ConnectionString);

        //Membuka koneksi
        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();
        try {
            //Membuat instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO region (name) VALUES (@name)";
            command.Transaction = transaction;

            //Membuat parameter
            SqlParameter pName = new SqlParameter();
            pName.ParameterName = "@name";
            pName.Value = name;
            pName.SqlDbType = SqlDbType.VarChar;

            //Menambahkan parameter ke command
            command.Parameters.Add(pName);

            //Menjalankan command
            int result = command.ExecuteNonQuery();
            transaction.Commit();

            if (result > 0) {
                Console.WriteLine("Data berhasil ditambahkan!");
            } else {
                Console.WriteLine("Data gagal ditambahkan!");
            }

            //Menutup koneksi
            connection.Close();

        } catch (Exception e) {
            Console.WriteLine(e.Message);
            try {
                transaction.Rollback();
            } catch (Exception rollback) {
                Console.WriteLine(rollback.Message);
            }
        }

    }

    // UPDATE : REGION (Transaction)

    // DELETE : REGION (Transaction)
}