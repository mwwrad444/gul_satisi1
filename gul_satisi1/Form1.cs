using System;
using System.Windows.Forms;

namespace gul_satisi1
{
    public partial class Form1 : Form
    {
        // Toplam qazanılan pulu saxlamaq üçün qutu
        double toplam = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Xanalardan məlumatı oxuyuruq
            string gulAdi = textBox1.Text;
            string sayText = textBox2.Text;
            string qiymetText = textBox3.Text;

            // 2. Boş yer olub-olmadığını yoxlayırıq
            if (gulAdi == "" || sayText == "" || qiymetText == "")
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!");
                return;
            }

            // 3. Rəqəmə çeviririk
            int say = Convert.ToInt32(sayText);
            double qiymet = Convert.ToDouble(qiymetText);

            // 4. Ümumi qiyməti hesablayırıq (Say * Qiymət)
            double yekun = say * qiymet;

            // 5. Cədvəfə sətir əlavə edirik
            dataGridView1.Rows.Add(gulAdi, say, qiymet, yekun);

            // 6. Ümumi gəliri artırırıq və ekrana yazırıq
            toplam = toplam + yekun;
            label3.Text = "Toplam gəlir: " + toplam + " AZN";

            // 7. Xanaları təmizləyirik ki, yenisini yazmaq olsun
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Proqramdan çıxış
            Application.Exit();
        }
    }
}