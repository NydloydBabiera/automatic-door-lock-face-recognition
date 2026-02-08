namespace automatic_door_lock_face_recognition
{
    partial class DocumentLogsReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadReport = new Button();
            reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            dateTimeStart = new DateTimePicker();
            dateTimeEnd = new DateTimePicker();
            SuspendLayout();
            // 
            // btnLoadReport
            // 
            btnLoadReport.Location = new Point(430, 9);
            btnLoadReport.Name = "btnLoadReport";
            btnLoadReport.Size = new Size(137, 33);
            btnLoadReport.TabIndex = 0;
            btnLoadReport.Text = "Generate Report";
            btnLoadReport.UseVisualStyleBackColor = true;
            btnLoadReport.Click += btnLoadReport_Click;
            // 
            // reportViewer2
            // 
            reportViewer2.Location = new Point(0, 0);
            reportViewer2.Name = "ReportViewer";
            reportViewer2.ServerReport.BearerToken = null;
            reportViewer2.Size = new Size(396, 246);
            reportViewer2.TabIndex = 0;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Format = DateTimePickerFormat.Short;
            dateTimeStart.Location = new Point(18, 15);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(200, 23);
            dateTimeStart.TabIndex = 1;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Format = DateTimePickerFormat.Short;
            dateTimeEnd.Location = new Point(224, 15);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(200, 23);
            dateTimeEnd.TabIndex = 2;
            // 
            // DocumentLogsReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 60);
            Controls.Add(dateTimeEnd);
            Controls.Add(dateTimeStart);
            Controls.Add(btnLoadReport);
            Name = "DocumentLogsReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocumentLogsReport";
            Load += DocumentLogsReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button btnLoadReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private DateTimePicker dateTimeStart;
        private DateTimePicker dateTimeEnd;
    }
}