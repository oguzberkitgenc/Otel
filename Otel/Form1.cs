using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDurum fr = new Formlar.Tanımlamalar.FrmDurum();
            fr.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmBirim fr = new Formlar.Tanimlamalar.FrmBirim();
            fr.Show();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmDepartman fr = new Formlar.Tanimlamalar.FrmDepartman();
            fr.Show();
        }
    }
}
