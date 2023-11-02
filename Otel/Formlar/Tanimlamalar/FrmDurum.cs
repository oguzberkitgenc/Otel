using DevExpress.XtraEditors;
using Otel.Entity;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Otel.Formlar.Tanımlamalar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmDurum_Load(object sender, EventArgs e)
        {
            db.TBLDURUM.Load();
            bindingSource1.DataSource = db.TBLDURUM.Local;

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Lütfen değerleri kontrol edip giriş yapın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.RemoveCurrent();
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen değerleri kontrol et", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
