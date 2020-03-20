using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakoparkProjekt
{
    public partial class Form1 : Form
    {
        private readonly string path = "";
        private HappyLiving hl;
        private int aktualLakoparkSzama = 0;

        public Form1()
        {
            InitializeComponent();
            //hl = new HappyLiving(path)
            hl = new HappyLiving();

            balraPictureBox.Image = Image.FromFile("Kepek/balranyil.jpg");
            jobraPictureBox.Image = Image.FromFile("Kepek/jobbnyil.jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (aktualLakoparkSzama == null)
            {
                balraPictureBox.Visible = false;
                jobraPictureBox.Visible = true;
            }
            else if (aktualLakoparkSzama == hl.Lakoparkok.Count)
            {
                balraPictureBox.Visible = true;
                jobraPictureBox.Visible = false;
            }
            else if (hl.Lakoparkok.Count == 1)
            {
                balraPictureBox.Visible = false;
                jobraPictureBox.Visible = false;
            }

            arcPictureBox.Image = Image.FromFile(
                "/Kepek/" + 
                hl.Lakoparkok.GetRange(aktualLakoparkSzama,aktualLakoparkSzama) + 
                ".jpg"
            );

            for (int i = 0; i < hl.Lakoparkok.maxH; i++)
            {

            }
        }
    }
}
