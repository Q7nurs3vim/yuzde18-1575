namespace sayınınyuzde18inialma_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            sayi = (sayi * 18) / 100;
            txtSonuc.Text = sayi.ToString();
        }
    }
}