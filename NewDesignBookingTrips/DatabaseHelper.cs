
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

public class DatabaseHelper
{
    // هنا حطينا connectionString مباشرة داخل الكلاس
    public string connectionString = "Server=.; Database=TripBookingDB;Trusted_Connection=True";

    // تقدر تخلي الكونستركتور فاضي
    public DatabaseHelper()
    {
    }

    public void Insert(string query, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null && parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void Update(string query, params SqlParameter[] parameters)
    {
        Insert(query, parameters);
    }

    public void Delete(string query, params SqlParameter[] parameters)
    {
        Insert(query, parameters);
    }

    public DataTable Query(string query, params SqlParameter[] parameters)
    {
        DataTable table = new DataTable();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null && parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
        }

        return table;
    }
    public DataTable loadData(string query)
    {

        DataTable dataTable = new DataTable();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            var dataAdapter = new SqlDataAdapter(query, conn);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;
            dataAdapter.Fill(dataTable);
        }

        return dataTable;
    }


    public List<List<string>> GetData(string query, params string[] columns)
    {
        List<List<string>> data = new List<List<string>>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (columns == null || columns.Length == 0)
                    columns = new string[] { "email", "passwordHash" };

                while (reader.Read())
                {
                    List<string> row = new List<string>();

                    foreach (var col in columns)
                    {
                        if (HasColumn(reader, col) && !reader.IsDBNull(reader.GetOrdinal(col)))
                            row.Add(reader[col].ToString());
                        else
                            row.Add(string.Empty);
                    }

                    data.Add(row);
                }
            }
        }

        return data;
    }

    private bool HasColumn(SqlDataReader reader, string columnName)
    {
        try
        {
            return reader.GetOrdinal(columnName) >= 0;
        }
        catch (IndexOutOfRangeException)
        {
            return false;
        }
    }

    public void StorePassword(string email, string hash, string salt)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Users(email, passwordHash, passwordSalt) VALUES (@em, @hash, @salt)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@hash", hash);
            cmd.Parameters.AddWithValue("@salt", salt);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static byte[] ImageToBytes(Image img)
    {
        MemoryStream ms = new MemoryStream();
        img.Save(ms, img.RawFormat);
        return ms.ToArray();
    }

    public static Image BytesToImage(byte[] bytes)
    {
        MemoryStream ms = new MemoryStream(bytes);
        return Image.FromStream(ms);
    }

}

