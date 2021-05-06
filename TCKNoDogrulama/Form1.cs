using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCKNoDogrulama.KPSPublic;

namespace TCKNoDogrulama
{
    public partial class Form1 : Form
    {
        ITcDogrulayici _tcDogrulayici;        
        public Form1(ITcDogrulayici tcDogrulayici)
        {
            InitializeComponent();
            _tcDogrulayici = tcDogrulayici;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.YillariEkle();
        }

        private void YillariEkle()
        {
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                yilSecici.Items.Add(i);
            }
        }

        private void dogrulaBtn_Click(object sender, EventArgs e)
        {
            KimlikVerisi kimlikVerisi = new KimlikVerisi() { Ad = adKutusu.Text.ToUpper(), Soyad = soyadKutusu.Text.ToUpper(), DogumYili = int.Parse(yilSecici.Text), TcKimlik = long.Parse(tcKutusu.Text) };
            var result = _tcDogrulayici.Dogrula(kimlikVerisi);
            if (result)
            {
                MessageBox.Show(this,"TC kimlik numarası başarıyla doğrulandı.","Başarılı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "TC kimlik numarası doğrulanamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
