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
        private string _cestaKSouboru = @"D:\OneDrives\Školní\OneDrive - Soukromá střední škola výpočetní techniky\Maturitní ročník\PRG\MaturitaGDISloupovyGraf\MaturitaGDISloupovyGraf\text.txt";
        private string[] _pripravenaData;

        public MainForm()
        {
            InitializeComponent();
            this._pripravenaData = this.PripravenaData(_cestaKSouboru);
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

            
            int posunPoX = 20;


            NakresliCaru(e.Graphics, pero, sirkaPictureBoxu - sirkaPictureBoxu, vyskaPictureBoxu / 2, sirkaPictureBoxu, vyskaPictureBoxu / 2);
            NakresliCaru(e.Graphics, pero, sirkaPictureBoxu / 2, vyskaPictureBoxu - vyskaPictureBoxu, sirkaPictureBoxu / 2, vyskaPictureBoxu);

            for (int i = 0; i < this._pripravenaData.Length ; i++)
            {
                NakresliCaru(e.Graphics, pero, (sirkaPictureBoxu / 2) + posunPoX, (vyskaPictureBoxu / 2) - int.Parse(this._pripravenaData[i]) , (sirkaPictureBoxu / 2) + posunPoX, vyskaPictureBoxu / 2);
                e.Graphics.DrawString(this._pripravenaData[i], pismo, stetec, (sirkaPictureBoxu / 2) + posunPoX - 10, (vyskaPictureBoxu / 2) + 10);
                posunPoX += 20;
            }
        }

        private static void NakresliCaru(Graphics grafika, Pen pero, int zacatekX, int zacatekY, int konecX, int konecY)
        {
            grafika.DrawLine(pero, zacatekX, zacatekY, konecX, konecY);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportDataForm exportDataForm = new ExportDataForm();
            exportDataForm.Data = this.PripravenaData(_cestaKSouboru);
            
            if (exportDataForm.ShowDialog() == DialogResult.OK)
            {
                this._pripravenaData = exportDataForm.Data;
                this.MainPictureBox.Refresh();
            }
        }
    }
}
