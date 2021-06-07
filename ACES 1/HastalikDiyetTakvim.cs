using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACES_1
{

    public abstract class DiyetYoneticisi
    {
        public int takvimGun { get; set; }
        public int anaOgunSayi{ get; set; }
        public int araOgunSayi { get; set; }
        public string ogunTip { get; set; }

        public void takvimOlustur()
        {



        }
        public void anaOgunOlustur()
        {

        }
        public void araOgunOlustur()
        {

        }


    }


    class HastalikDiyetTakvim // adi boyle kalsin diye ellemedik.
    {
    }

    public class ObezDiyetTakvim : DiyetYoneticisi, IDiyetYontem
    {

    }

    public class ColyakDiyetTakvim : DiyetYoneticisi, IDiyetYontem
    {

    }

    public class SekerDiyetTakvim : DiyetYoneticisi, IDiyetYontem
    {

    }



}
