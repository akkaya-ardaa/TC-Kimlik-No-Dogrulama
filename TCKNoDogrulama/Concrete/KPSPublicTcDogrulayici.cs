using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCKNoDogrulama.KPSPublic;
namespace TCKNoDogrulama
{
    public class KPSPublicTcDogrulayici : ITcDogrulayici
    {
        public bool Dogrula(KimlikVerisi kimlikVerisi)
        {
            try
            {
                using (KPSPublicSoapClient client = new KPSPublicSoapClient())
                {
                    return client.TCKimlikNoDogrula(kimlikVerisi.TcKimlik, kimlikVerisi.Ad, kimlikVerisi.Soyad, kimlikVerisi.DogumYili);
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
