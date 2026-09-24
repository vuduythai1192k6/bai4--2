namespace bai4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btndangki.Click += btndangky_Click;
            mtxtPhone.Mask = "(000) 000-0000";
            var khoahoc = new[]
            {
                new { Ma = "KH01", Ten = "Lap trinh C#" },
                new { Ma = "KH02", Ten = "Lap trinh Java" },
                new { Ma = "KH03", Ten = "Co so du lieu" }
            };

            cbokhoahoc.DataSource = khoahoc;
            cbokhoahoc.DisplayMember = "Ten";
            cbokhoahoc.ValueMember = "Ma";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

        }
        private void btndangky_Click(object sender, EventArgs e)
        {

            string ngaySinh = dtpBirthDate.Text;
            string soDienThoai = mtxtPhone.Text;
            string khoaHoc = cbokhoahoc.Text;

            MessageBox.Show(
                "Thong tin dang ky:\n" +
                "Ngay sinh: " + ngaySinh + "\n" +
                "So dien thoai: " + soDienThoai + "\n" +
                "Khoa hoc: " + khoaHoc,
                "Thong bao"
            );
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btndangki_Click(object sender, EventArgs e)
        {

        }
    }
}
