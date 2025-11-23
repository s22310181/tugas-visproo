namespace WindowsFormsApp4
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblMapel = new System.Windows.Forms.Label();
            this.lblMulai = new System.Windows.Forms.Label();
            this.lblSelesai = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtMapel = new System.Windows.Forms.TextBox();
            this.timeMulai = new System.Windows.Forms.DateTimePicker();
            this.timeSelesai = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtReminder = new System.Windows.Forms.TextBox();
            this.timerRimender = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHariBelajar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMapel
            // 
            this.lblMapel.AutoSize = true;
            this.lblMapel.Location = new System.Drawing.Point(30, 64);
            this.lblMapel.Name = "lblMapel";
            this.lblMapel.Size = new System.Drawing.Size(78, 13);
            this.lblMapel.TabIndex = 0;
            this.lblMapel.Text = "Mata Pelajaran";
            // 
            // lblMulai
            // 
            this.lblMulai.AutoSize = true;
            this.lblMulai.Location = new System.Drawing.Point(30, 120);
            this.lblMulai.Name = "lblMulai";
            this.lblMulai.Size = new System.Drawing.Size(54, 13);
            this.lblMulai.TabIndex = 1;
            this.lblMulai.Text = "Jam Mulai";
            // 
            // lblSelesai
            // 
            this.lblSelesai.AutoSize = true;
            this.lblSelesai.Location = new System.Drawing.Point(395, 120);
            this.lblSelesai.Name = "lblSelesai";
            this.lblSelesai.Size = new System.Drawing.Size(63, 13);
            this.lblSelesai.TabIndex = 2;
            this.lblSelesai.Text = "Jam Selesai";
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Location = new System.Drawing.Point(30, 192);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(52, 13);
            this.lblReminder.TabIndex = 3;
            this.lblReminder.Text = "Reminder";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(131, 259);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // txtMapel
            // 
            this.txtMapel.Location = new System.Drawing.Point(129, 57);
            this.txtMapel.Name = "txtMapel";
            this.txtMapel.Size = new System.Drawing.Size(219, 20);
            this.txtMapel.TabIndex = 5;
            // 
            // timeMulai
            // 
            this.timeMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeMulai.Location = new System.Drawing.Point(129, 113);
            this.timeMulai.Name = "timeMulai";
            this.timeMulai.ShowUpDown = true;
            this.timeMulai.Size = new System.Drawing.Size(219, 20);
            this.timeMulai.TabIndex = 7;
            // 
            // timeSelesai
            // 
            this.timeSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeSelesai.Location = new System.Drawing.Point(481, 114);
            this.timeSelesai.Name = "timeSelesai";
            this.timeSelesai.ShowUpDown = true;
            this.timeSelesai.Size = new System.Drawing.Size(200, 20);
            this.timeSelesai.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(50, 254);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(168, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(288, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(398, 254);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(512, 254);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwal.Location = new System.Drawing.Point(33, 308);
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.Size = new System.Drawing.Size(638, 117);
            this.dgvJadwal.TabIndex = 15;
            this.dgvJadwal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJadwal_CellClick);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(288, 191);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(94, 17);
            this.chkStatus.TabIndex = 16;
            this.chkStatus.Text = "Sudah Selesai";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtReminder
            // 
            this.txtReminder.Location = new System.Drawing.Point(129, 185);
            this.txtReminder.Name = "txtReminder";
            this.txtReminder.Size = new System.Drawing.Size(66, 20);
            this.txtReminder.TabIndex = 17;
            // 
            // timerRimender
            // 
            this.timerRimender.Enabled = true;
            this.timerRimender.Interval = 1000;
            this.timerRimender.Tick += new System.EventHandler(this.timerReminder_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "senin",
            "selasa",
            "rabu",
            "kamis",
            "jumat"});
            this.comboBox1.Location = new System.Drawing.Point(481, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // lblHariBelajar
            // 
            this.lblHariBelajar.AutoSize = true;
            this.lblHariBelajar.Location = new System.Drawing.Point(397, 60);
            this.lblHariBelajar.Name = "lblHariBelajar";
            this.lblHariBelajar.Size = new System.Drawing.Size(61, 13);
            this.lblHariBelajar.TabIndex = 19;
            this.lblHariBelajar.Text = "Hari Belajar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHariBelajar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtReminder);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.dgvJadwal);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.timeSelesai);
            this.Controls.Add(this.timeMulai);
            this.Controls.Add(this.txtMapel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblSelesai);
            this.Controls.Add(this.lblMulai);
            this.Controls.Add(this.lblMapel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMapel;
        private System.Windows.Forms.Label lblMulai;
        private System.Windows.Forms.Label lblSelesai;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtMapel;
        private System.Windows.Forms.DateTimePicker timeMulai;
        private System.Windows.Forms.DateTimePicker timeSelesai;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtReminder;
        private System.Windows.Forms.Timer timerRimender;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHariBelajar;
    }
}