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

        public void LoadDocumentLogs(DataGridView gridView)
        {
            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    string query = "WITH numbered AS (\r\n    SELECT \r\n\t\tinf.document_type,\r\n        logs.document_information_logs_id,\r\n        logs.document_information_id,\r\n        logs.time_log,\r\n        ROW_NUMBER() OVER (PARTITION BY logs.document_information_id ORDER BY time_log, document_information_logs_id) AS rn\r\n    FROM document_information_logs logs\r\n\tinner join document_information inf on inf.document_information_id = logs.document_information_id\r\n)\r\nSELECT \r\n\tdocument_type,\r\n    document_information_logs_id,\r\n    document_information_id,\r\n    time_log,\r\n    CASE WHEN rn % 2 = 1 THEN 'out' ELSE 'in' END AS log_type,\r\n    (rn + 1) / 2 AS pair_number\r\nFROM numbered\r\nORDER BY document_information_id, rn";
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

        public async Task<int> UpdateRowAsync(
          string tableName,
          string keyColumn,
          object keyValue,
          Dictionary<string, object> columnsToUpdate)
            {
                if (columnsToUpdate == null || columnsToUpdate.Count == 0)
                    throw new ArgumentException("No columns provided to update.");

                // Build SET clause dynamically: "col1 = @col1, col2 = @col2"
                var setClauses = new List<string>();
                foreach (var col in columnsToUpdate)
                {
                    setClauses.Add($"{col.Key} = @{col.Key}");
                }

                string query = $@"
                UPDATE {tableName}
                SET {string.Join(", ", setClauses)}
                WHERE {keyColumn} = @keyValue;
            ";

                await using var conn = new NpgsqlConnection(_connStr);
                await conn.OpenAsync();

                await using var cmd = new NpgsqlCommand(query, conn);

                // Add dynamic parameters
                foreach (var col in columnsToUpdate)
                {
                    if (col.Value is long)
                    {
                        cmd.Parameters.Add($"@{col.Key}", NpgsqlTypes.NpgsqlDbType.Bigint)
                                      .Value = (long)col.Value;
                    }
                    else if (col.Value is int)
                    {
                        cmd.Parameters.Add($"@{col.Key}", NpgsqlTypes.NpgsqlDbType.Integer)
                                      .Value = (int)col.Value;
                    }
                    else if (col.Value is DateTime)
                    {
                        cmd.Parameters.Add($"@{col.Key}", NpgsqlTypes.NpgsqlDbType.Timestamp)
                                      .Value = (DateTime)col.Value;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue($"@{col.Key}", col.Value ?? DBNull.Value);
                    }
            }
                // Key parameter
                cmd.Parameters.AddWithValue("@keyValue", keyValue);

                return await cmd.ExecuteNonQueryAsync(); // returns number of affected rows
        }

        public bool DeletePersonRecordsAndFiles(int personnelInfoId)
        {
            try
            {
                List<string> filePaths = new List<string>();

                using (var conn = new NpgsqlConnection(_connStr))
                {
                    conn.Open();

                    // STEP 1: Get all file paths under that personnel_information_id
                    using (var cmd = new NpgsqlCommand(
                        "SELECT image_path FROM personnel_face_records WHERE personnel_information_id = @pid",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", personnelInfoId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    filePaths.Add(reader.GetString(0));
                                }
                            }
                        }
                    }

                    // STEP 2: Delete the DB rows
                    using (var cmd = new NpgsqlCommand(
                        "DELETE FROM personnel_face_records WHERE personnel_information_id = @pid",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", personnelInfoId);
                        cmd.ExecuteNonQuery();
                    }

                    using(var cmd = new NpgsqlCommand("DELETE FROM personnel_information WHERE personnel_information_id = @pid",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", personnelInfoId);
                        cmd.ExecuteNonQuery();
                    }
                }

                if(filePaths.Count == 0)
                {
                    return true;
                }
                // STEP 3: Delete all files from disk
                foreach (var path in filePaths)
                {
                    if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete failed: " + ex.Message);
                return false;
            }
        }

        public async Task<int> DeleteRowAsync(
            string tableName,
            string keyColumn,
            object keyValue)
         {
                    if (string.IsNullOrWhiteSpace(tableName))
                        throw new ArgumentException("Table name is required.");

                    if (string.IsNullOrWhiteSpace(keyColumn))
                        throw new ArgumentException("Key column is required.");

                    string query = $@"
                DELETE FROM {tableName}
                WHERE {keyColumn} = @keyValue;
            ";

                    await using var conn = new NpgsqlConnection(_connStr);
                    await conn.OpenAsync();

                    await using var cmd = new NpgsqlCommand(query, conn);

                    // Parameter typing
                    if (keyValue is long)
                    {
                        cmd.Parameters.Add("@keyValue", NpgsqlTypes.NpgsqlDbType.Bigint).Value = keyValue;
                    }
                    else if (keyValue is int)
                    {
                        cmd.Parameters.Add("@keyValue", NpgsqlTypes.NpgsqlDbType.Integer).Value = keyValue;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@keyValue", keyValue);
                    }

                    return await cmd.ExecuteNonQueryAsync();
        }
        public async Task<int> DeleteAllRowsAsync(
            string tableName )
        {
            if (string.IsNullOrWhiteSpace(tableName))
                throw new ArgumentException("Table name is required.");

            string query = $@"
                DELETE FROM {tableName}
            ";

            await using var conn = new NpgsqlConnection(_connStr);
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(query, conn);

            return await cmd.ExecuteNonQueryAsync();
        }
        public DataTable Search(string table, string[] columns, string searchText)
        {
            using var conn = new NpgsqlConnection(_connStr);
            conn.Open();

            var dt = new DataTable();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            var whereParts = new List<string>();

            for (int i = 0; i < columns.Length; i++)
            {
                var col = columns[i];

                // Use safe param name
                var paramName = $"@p{i}";

                // If column is numeric, cast to text
                whereParts.Add($"CAST({col} AS TEXT) ILIKE {paramName}");
                cmd.Parameters.AddWithValue(paramName, "%" + searchText + "%");
            }

            cmd.CommandText = $@"
                SELECT *
                FROM {table}
                WHERE {string.Join(" OR ", whereParts)}
            ";

            using var reader = cmd.ExecuteReader();
            dt.Load(reader);

            return dt;
        }
    }

}
