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
    public partial class ExportDataForm : Form
    {
        private TextFile _textak = new TextFile();
        private string _cestaKSouboru = @"D:\OneDrives\Školní\OneDrive - Soukromá střední škola výpočetní techniky\Maturitní ročník\PRG\MaturitaGDISloupovyGraf\MaturitaGDISloupovyGraf\text.txt";
        public string[] Data;

        public ExportDataForm()
        {
            InitializeComponent();

            this.TextFileTextBox.Text = this._textak.PrvniRadek(this._cestaKSouboru);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //TODO: vyresit zapisovani do textaku
            //this._textak.ZapisRadek(this._cestaKSouboru, this.TextFileTextBox.Text);
            this.Data = this.TextFileTextBox.Text.Split(';');
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
