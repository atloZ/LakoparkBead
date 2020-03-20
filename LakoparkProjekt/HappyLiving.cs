using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    class HappyLiving
    {
        private List<Lakopark> lakoparkok;

        internal List<Lakopark> Lakoparkok { get => lakoparkok; set => lakoparkok = value; }

        public HappyLiving(string fileneve)
        {
            using (StreamReader file = new StreamReader(fileneve))
            {
                while (!file.EndOfStream)
                {
                    string sor = file.ReadLine();
                    Lakopark lp = new Lakopark(new int[,] { {1, 2} },2,"név",3); // adatok beolvasása valami szerint nem vágom
                    lakoparkok.Add(lp);
                }
                file.Close();
            }
        }

        public HappyLiving()
        {
            Lakopark lp = new Lakopark(new int[,] { { 1, 2 } }, 2, "Puskás Ferenc", 3);
            lakoparkok.Add(lp);
            Lakopark lp2 = new Lakopark(new int[,] { { 10, 20 } }, 20, "Van Gogh", 30);
            lakoparkok.Add(lp2);
        }
    }
}
