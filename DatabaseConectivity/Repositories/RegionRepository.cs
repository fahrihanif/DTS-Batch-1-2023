using DatabaseConnectivity.DbConnection;
using DatabaseConnectivity.Models;
using DatabaseConnectivity.Repositories.Interface;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnectivity.Repositories;
public class RegionRepository : IGeneralRepository<Region>
{
    public List<Region> GetAll()
    {
        var connection = new Context().GetConnection();
        var regions = new List<Region>();

        //Membuat instance untuk command
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = "SELECT * FROM region";

        //Membuka koneksi
        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows) {
            while (reader.Read()) {
                regions.Add(new Region(reader.GetInt32(0), reader.GetString(1)));
            }
        } else {
            regions = null;
        }
        reader.Close();
        connection.Close();

        return regions;
    }

    public Region GetById(int id)
    {
        throw new NotImplementedException();
    }

    public int Insert(Region region)
    {
        var connection = new Context().GetConnection();

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
            pName.Value = region.Name;
            pName.SqlDbType = SqlDbType.VarChar;

            //Menambahkan parameter ke command
            command.Parameters.Add(pName);

            //Menjalankan command
            int result = command.ExecuteNonQuery();

            transaction.Commit();
            //Menutup koneksi
            connection.Close();

            return result;

        } catch (Exception e) {
            try {
                transaction.Rollback();
            } catch (Exception rollback) {
                return 100;
            }
        }

        return 0;
    }

    public int Update(Region region)
    {
        throw new NotImplementedException();
    }

    public int Delete(int id)
    {
        throw new NotImplementedException();
    }
}
