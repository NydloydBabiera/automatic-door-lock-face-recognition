using automatic_door_lock_face_recognition.Services;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace automatic_door_lock_face_recognition.Classess
{
    public class DBPostgress
    {
        private readonly string _connStr;
        private string c_Columname;
        private string c_Values;
        public DBPostgress(string connStr)
        {
            _connStr = connStr;
        }

        public void InsertSample(string name, string imagePath)
        {
            using (var conn = new NpgsqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO face_records(name, image_path) VALUES(@n, @p)", conn))
                {
                    cmd.Parameters.AddWithValue("n", name);
                    cmd.Parameters.AddWithValue("p", imagePath);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<(int id, string name, string imagePath)> GetAllSamples()
        {
            var list = new List<(int, string, string)>();
            using (var conn = new NpgsqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id, name, image_path FROM face_records ORDER BY created_at DESC", conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add((rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2)));
                    }
                }
            }
            return list;
        }

        public List<(int id, string name, string imagePath)> GetAllImages()
        {
            var list = new List<(int, string, string)>();
            using (var conn = new NpgsqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT personnel_face_records_id, name , image_path FROM personnel_face_records ORDER BY created_at DESC", conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add((rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2)));
                    }
                }
            }
            return list;
        }
        public List<(int id, string name, string imagePath)> GetAllUntrainedImage()
        {
            var list = new List<(int, string, string)>();
            using (var conn = new NpgsqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT personnel_face_records_id, name , image_path FROM personnel_face_records WHERE personnel_information_id = "+ GlobalVariables.PersonnelId + " ORDER BY created_at DESC", conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add((rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2)));
                    }
                }
            }
            return list;
        }
        public List<(int id, string name, string imagePath)> GetTableData(String tableName)
        {
            var list = new List<(int, string, string)>();
            using (var conn = new NpgsqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM face_records", conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add((rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2)));
                    }
                }
            }
            return list;
        }

        //public void AddRecord(string databaseTable)
        //{
        //    using (var conn = new NpgsqlConnection(_connStr))
        //    {
        //        conn.Open();
        //        //var cmd = new NpgsqlCommand("INSERT INTO " + databaseTable + " (" + c_Columname + ") VALUES(" + c_Values + ")", conn);
        //        //cmd.ExecuteNonQuery();
        //        using (var cmd = new NpgsqlCommand("INSERT INTO " + databaseTable + " (" + c_Columname + ") VALUES(" + c_Values + ")", conn))
        //        {
        //            cmd.Parameters.AddWithValue("n", name);
        //            cmd.Parameters.AddWithValue("p", imagePath);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        public void AddRecord(string tableName, Dictionary<string, object> data)
        {
            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    var columns = new StringBuilder();
                    var values = new StringBuilder();
                    var cmd = new NpgsqlCommand();
                    int i = 0;

                    foreach (var kvp in data)
                    {
                        string paramName = "@p" + i;

                        columns.Append(kvp.Key);
                        values.Append(paramName);

                        if (i < data.Count - 1)
                        {
                            columns.Append(", ");
                            values.Append(", ");
                        }

                        cmd.Parameters.AddWithValue(paramName, kvp.Value ?? DBNull.Value);
                        i++;
                    }

                    // ✅ Include RETURNING * to get the inserted row
                    cmd.Connection = conn;
                    cmd.CommandText = $"INSERT INTO {tableName} ({columns}) VALUES ({values}) RETURNING *;";

                    // Execute and get the inserted row
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // You can access columns by name or index
                            var insertedRow = new Dictionary<string, object>();

                            for (int j = 0; j < reader.FieldCount; j++)
                            {
                                insertedRow[reader.GetName(j)] = reader.GetValue(j);
                            }

                            MessageBox.Show("✅ Record successfully saved!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if(tableName == "personnel_information")
                            {
                                // Example: display inserted ID
                                GlobalVariables.PersonnelId = Convert.ToInt32(insertedRow["personnel_information_id"]);
                                Console.WriteLine($"Inserted ID: {GlobalVariables.PersonnelId}");
                            }
                            

                            // Optionally return the row if you want to use it outside
                            //return insertedRow;
                        }
                        else
                        {
                            MessageBox.Show("⚠️ No record was inserted.", "Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error inserting record:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void setColumn(string columnName)
        {
            if (c_Columname == string.Empty)
                c_Columname = columnName;
            else
                c_Columname = c_Columname + ", " + columnName;
        }

        public void setValues(string val)
        {
            if (c_Values == string.Empty)
            {
                if (val != "")
                {
                    if (val.Substring(0, 1) == "@")
                        c_Values = " " + val.Substring(1) + " ";
                    else
                        c_Values = "'" + val + "'";
                }


            }
            else
            {

                if (val != "")
                {
                    if (val.Substring(0, 1) == "@")
                        c_Values = c_Values + ", " + val.Substring(1);
                    else
                        c_Values = c_Values + ", '" + val + "'";
                }
                else
                {
                    Console.WriteLine("val:" + val);
                }

            }


        }

        public void LoadData(string tableName, DataGridView gridView)
        {
            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    string query = $"SELECT * FROM {tableName}";
                    using (var da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        gridView.DataSource = dt;
                        gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error loading data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool CheckIfDataExists(string tableName, string columnName, string value)
        {
            if (string.IsNullOrWhiteSpace(_connStr))
            {
                MessageBox.Show("❌ Connection string is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(columnName))
            {
                MessageBox.Show("❌ Table name or column name is null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @value";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", value ?? (object)DBNull.Value);

                        var result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                            return false;

                        int count = Convert.ToInt32(result);
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error checking data existence:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public (int id, string name, string imagePath)? GetDocumentInformation(String rfidTag)
        {
            using (var conn = new NpgsqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT document_information_id, document_rfid_tag, document_type " +
                    "FROM document_information " +
                    "WHERE document_rfid_tag = @rfidTag " +
                    "LIMIT 1", conn))
                {
                    cmd.Parameters.AddWithValue("@rfidTag", rfidTag);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return (rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2));
                        }
                    }
                }
            }
            // Return null if no row found
            return null;
        }


    }
}
