using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCKNoDogrulama
{
    public interface ITcDogrulayici
    {
        bool Dogrula(KimlikVerisi kimlikVerisi);
    }
}
