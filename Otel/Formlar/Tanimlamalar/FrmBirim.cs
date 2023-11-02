using Otel.Entity;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;
namespace Otel.Formlar.Tanimlamalar
{
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmBirim_Load(object sender, EventArgs e)
        {
            db.TBLBIRIM.Load();
            bindingSource1.DataSource = db.TBLBIRIM.Local;

            repositoryItemLookUpEditDurum.DataSource = (from x in db.TBLDURUM
                                                         select new
                                                         {
                                                             x.DurumID,
                                                             x.DurumAd
                                                         }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
