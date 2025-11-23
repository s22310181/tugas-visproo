using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        
        string connectionString = "server=localhost;database=study_time;uid=root;pwd=;";
        int selectedId = -1;

        DateTime reminderTime = DateTime.Parse("15:30");  

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgvJadwal.CellValueChanged += dgvJadwal_CellValueChanged;
            dgvJadwal.CurrentCellDirtyStateChanged += dgvJadwal_CurrentCellDirtyStateChanged;

            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, mapel, TIME_FORMAT(jam_mulai, '%H:%i:%s') AS jam_mulai, " +
                               "TIME_FORMAT(jam_selesai, '%H:%i:%s') AS jam_selesai, reminder, status " +
                               "FROM jadwal ORDER BY jam_mulai";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvJadwal.DataSource = dt;

                if (dgvJadwal.Columns.Contains("jam_mulai"))
                    dgvJadwal.Columns["jam_mulai"].DefaultCellStyle.Format = "HH:mm:ss";
                if (dgvJadwal.Columns.Contains("jam_selesai"))
                    dgvJadwal.Columns["jam_selesai"].DefaultCellStyle.Format = "HH:mm:ss";
            }

            dgvJadwal.ClearSelection();
            selectedId = -1;
            dgvJadwal.DataError += (s, e) => { e.ThrowException = false; };
        }

        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMapel.Text))
            {
                MessageBox.Show("Isi Mata Pelajaran terlebih dahulu!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO jadwal (mapel, jam_mulai, jam_selesai, reminder, status) " +
                               "VALUES (@mapel, @mulai, @selesai, @reminder, @status)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mapel", txtMapel.Text);
                cmd.Parameters.AddWithValue("@mulai", timeMulai.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@selesai", timeSelesai.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@reminder", txtReminder.Text);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil ditambahkan!");
            ClearForm();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data terlebih dahulu dari tabel!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE jadwal SET mapel=@mapel, jam_mulai=@mulai, jam_selesai=@selesai, " +
                               "reminder=@reminder, status=@status WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.Parameters.AddWithValue("@mapel", txtMapel.Text);
                cmd.Parameters.AddWithValue("@mulai", timeMulai.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@selesai", timeSelesai.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@reminder", txtReminder.Text);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil diperbarui!");
            ClearForm();
            LoadData();
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang ingin dihapus dari tabel!");
                return;
            }

            if (MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM jadwal WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil dihapus!");
                ClearForm();
                LoadData();
            }
        }

        private void dgvJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvJadwal.Rows[e.RowIndex].Cells["id"].Value != DBNull.Value)
            {
                DataGridViewRow row = dgvJadwal.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["id"].Value);
                txtMapel.Text = row.Cells["mapel"].Value.ToString();

                var mulaiObj = row.Cells["jam_mulai"].Value;
                var selesaiObj = row.Cells["jam_selesai"].Value;

                if (mulaiObj is TimeSpan tsMulai)
                    timeMulai.Value = DateTime.Today.Add(tsMulai);
                else if (DateTime.TryParse(mulaiObj.ToString(), out DateTime dtMulai))
                    timeMulai.Value = dtMulai;

                if (selesaiObj is TimeSpan tsSelesai)
                    timeSelesai.Value = DateTime.Today.Add(tsSelesai);
                else if (DateTime.TryParse(selesaiObj.ToString(), out DateTime dtSelesai))
                    timeSelesai.Value = dtSelesai;

                txtReminder.Text = row.Cells["reminder"].Value.ToString();
                chkStatus.Checked = Convert.ToInt32(row.Cells["status"].Value) == 1;
            }
        }

       
        private void dgvJadwal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvJadwal.Columns[e.ColumnIndex].Name == "status")
            {
                int id = Convert.ToInt32(dgvJadwal.Rows[e.RowIndex].Cells["id"].Value);
                bool isChecked = Convert.ToInt32(dgvJadwal.Rows[e.RowIndex].Cells["status"].Value) == 1;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE jadwal SET status=@status WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", isChecked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dgvJadwal_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvJadwal.IsCurrentCellDirty)
            {
                dgvJadwal.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ClearForm()
        {
            txtMapel.Clear();
            txtReminder.Clear();
            chkStatus.Checked = false;
            selectedId = -1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                dgvJadwal.EndEdit();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM jadwal", conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "jadwal");

                    CrystalReport1 report = new CrystalReport1();
                    report.SetDataSource(ds);

                    FrmPengguna frm = new FrmPengguna();
                    frm.crystalReportViewer1.ReportSource = report;
                    frm.crystalReportViewer1.Refresh();
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message);
            }
        }

        
        private void timerReminder_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("HH:mm") == reminderTime.ToString("HH:mm"))
            {
                ShowReminder();
            }
        }

      
        private void ShowReminder()
        {
            MessageBox.Show(
                "Waktunya belajar atau mengerjakan tugas!",
                "Reminder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnLogout_Click(object sender, EventArgs e) { }
        private void Form2_Load(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
