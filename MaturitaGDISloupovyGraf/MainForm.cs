using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaturitaGDISloupovyGraf
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string[] PripravenaData(string cestaKSouboru)
        {
            TextFile textFile = new TextFile();
            string radek = textFile.PrvniRadek(cestaKSouboru);

            return radek.Split(';');
        }

        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen pero = new Pen(Color.Black, 5);
            Font pismo = new Font("Arial", 10);
            SolidBrush stetec = new SolidBrush(Color.Black);

            int sirkaPictureBoxu = this.MainPictureBox.Width;
            int vyskaPictureBoxu = this.MainPictureBox.Height;

            int meritko = 12;
            int meritko1 = 15;
            int meritko2 = 48;

            string cestaKSouboru = @"D:\OneDrives\Školní\OneDrive - Soukromá střední škola výpočetní techniky\Maturitní ročník\PRG\MaturitaGDISloupovyGraf\MaturitaGDISloupovyGraf\text.txt";
            string[] pripravenaData = this.PripravenaData(cestaKSouboru);
            int posunPoX = 20;


            NakresliCaru(e.Graphics, pero, sirkaPictureBoxu - sirkaPictureBoxu, vyskaPictureBoxu / 2, sirkaPictureBoxu, vyskaPictureBoxu / 2);
            NakresliCaru(e.Graphics, pero, sirkaPictureBoxu / 2, vyskaPictureBoxu - vyskaPictureBoxu, sirkaPictureBoxu / 2, vyskaPictureBoxu);

            for (int i = 0; i < pripravenaData.Length ; i++)
            {
                NakresliCaru(e.Graphics, pero, (sirkaPictureBoxu / 2) + posunPoX, (vyskaPictureBoxu / 2) - int.Parse(pripravenaData[i]) , (sirkaPictureBoxu / 2) + posunPoX, vyskaPictureBoxu / 2);
                e.Graphics.DrawString(pripravenaData[i], pismo, stetec, (sirkaPictureBoxu / 2) + posunPoX - 10, (vyskaPictureBoxu / 2) + 10);
                posunPoX += 20;
            }
        }

        private static void NakresliCaru(Graphics grafika, Pen pero, int zacatekX, int zacatekY, int konecX, int konecY)
        {
            grafika.DrawLine(pero, zacatekX, zacatekY, konecX, konecY);
        }
    }
}
