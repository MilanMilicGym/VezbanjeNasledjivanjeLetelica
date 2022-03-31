using System;

namespace VezbanjeNasledjivanjeLetelica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dron = new Dron( "ZORAN",1, 25.4);
            var avion = new Avion ( 50, 113.5, "Air Serbia" );
            var helikopter = new Helikopter();
            //avion.BrojSedista = 100;

            //Console.WriteLine( helikopter.GetImeObjekta ());
            Console.WriteLine(dron.BrojSedista + dron.ImeKompanije+ dron.DuzinaObjekta);
        }
    }
    class Letelica
    {
        protected string ImeObjekta { get; set; }
        public int BrojSedista { get; set; }
        public double DuzinaObjekta { get; set; }
        public string ImeKompanije { get; set; }

    }
    class Avion : Letelica
    {
        public Avion(int brojSedista, double duzinaObjekta, string imeKompanije)
            


        {
            ImeObjekta = "Avion";
            BrojSedista = brojSedista;
            DuzinaObjekta = duzinaObjekta;  
            ImeKompanije = imeKompanije;

        }
        public string GetImeObjekta()
        {
            return ImeObjekta;
        }
    }
    class Dron : Letelica
    {
        public Dron(string imeKompanije,int brojSedista, double duzinaObjekta )
        {
            ImeObjekta = "Dron";
            ImeKompanije= imeKompanije;
            BrojSedista= brojSedista;
            DuzinaObjekta= duzinaObjekta;
        }
        public string GetImeObjekta()
        {
            return ImeObjekta;
        }
    }
    class Helikopter : Letelica
    {
        public Helikopter()
        {
            ImeObjekta = "Helikopter";
        }
        public string GetImeObjekta()
        {
            return ImeObjekta;
        }

    }
}
     

