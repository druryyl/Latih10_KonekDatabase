namespace Latih10_KonekDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListData();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewSiswa();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveData();
            ListData();
        }

        public void ListData()
        {
            using var db = new SekolahKuDbContext();
            var listSiswa = db.Siswa.ToList();
            dataGridView1.DataSource = listSiswa;
            tabControl1.SelectedIndex = 0;
        }
        public void NewSiswa()
        {
            var newSiswa = new SiswaModel();
            using var db = new SekolahKuDbContext();
            db.Siswa.Add(newSiswa);
            db.SaveChanges();

            ShowInput(newSiswa);
        }
        public void ShowInput(SiswaModel siswa)
        {
            SiswaIdText.Text = siswa.SiswaId.ToString();
            SiswaNameText.Text = siswa.SiswaName;
            NisText.Text = siswa.Nis;
            TempatLahirText.Text = siswa.TempatLahir;
            TglLahirPicker.Value = siswa.TglLahir;
            AlamatText.Text = siswa.Alamat;
            KotaText.Text = siswa.Kota;
            tabControl1.SelectedIndex = 1;
        }
        public void SaveData()
        {
            using var db = new SekolahKuDbContext();
            var siswa = db.Siswa.Find(int.Parse(SiswaIdText.Text));

            siswa.SiswaName = SiswaNameText.Text;
            siswa.Nis = NisText.Text;
            siswa.TempatLahir = TempatLahirText.Text;
            siswa.TglLahir = TglLahirPicker.Value;
            siswa.Alamat = AlamatText.Text;
            siswa.Kota = KotaText.Text;

            db.SaveChanges();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var siswaId = dataGridView1.CurrentRow.Cells["SiswaId"].Value.ToString();
            if (siswaId is null)
                return;

            using var db = new SekolahKuDbContext();
            var siswa = db.Siswa.Find(int.Parse(siswaId));
            ShowInput(siswa); //asdfasdfasdfv sdfgfdgsdfg
        }

    }
}
