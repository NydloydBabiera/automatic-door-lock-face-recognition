using automatic_door_lock_face_recognition.Services;
using FastReport;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatic_door_lock_face_recognition
{
    public partial class DocumentLogsReport : Form
    {
        public DocumentLogsReport()
        {
            InitializeComponent();
        }

        private void DocumentLogsReport_Load(object sender, EventArgs e)
        {
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";

        }

        public DataTable GetProducts()
        {
            var dt = new DataTable();

            string connStr = GlobalVariables.DbConnString;

            using var conn = new NpgsqlConnection(connStr);
            using var cmd = new NpgsqlCommand(
             "WITH numbered AS \r\n(SELECT \r\ninf.student_name,       \r\nlogs.document_information_logs_id,       \r\nlogs.document_information_id,\r\ninf.course,\r\ninf.record_no,\r\ninf.row_num,\r\nlogs.time_log,\r\nROW_NUMBER() OVER (\r\n  PARTITION BY logs.document_information_id \r\n  ORDER BY time_log, document_information_logs_id) AS rn\r\nFROM document_information_logs logs\r\ninner join document_information inf on inf.document_information_id = logs.document_information_id\r\n)\r\nSELECT student_name,\r\ndocument_information_logs_id,\r\ndocument_information_id,\r\ncourse,\r\nrecord_no,\r\nrow_num,\r\ntime_log,\r\nCASE WHEN rn % 2 = 1 THEN 'out' ELSE 'in' END AS log_type,\r\n(rn + 1) / 2 AS pair_number\r\nFROM numbered ORDER BY document_information_id, rn"
             , conn
            );

            //cmd.Parameters.AddWithValue("@price", 100);

            using var adapter = new NpgsqlDataAdapter(cmd);

            conn.Open();
            adapter.Fill(dt);

            return dt;
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                // 1. Load the report file
                //report.Show();
                DateTime start = dateTimeStart.Value.Date;      // start of day
                DateTime end = dateTimeEnd.Value.Date.AddDays(1); // exclusive end

                //// 2. Set the connection string (if different from designer)
                //// Find the connection by the name you gave it in the Designer
                //var connection = report.Dictionary.Connections.FindByName("MyDatabaseConnection");
                //if (connection != null)
                //{
                //    connection.ConnectionString = "your_runtime_connection_string_here";
                //}
                MessageBox.Show($"{start}- {end}");
                report.SetParameterValue("StartDate", start);
                report.SetParameterValue("EndDate", end);

                report.Refresh();
                report.Load("Reports/DocumentLogsReport.frx");
                // 3. Prepare the report (Executes your custom SQL query)
                if (report.Prepare())
                {
                    // 4. Display the report
                    // Option A: Standalone Popup Window
                    report.Show();

                    // Option B: Embed inside your Form (if you added a PreviewControl to your UI)
                    // report.Preview = previewControl1;
                    // report.ShowPrepared();
                }
            }
        }
    }
}
