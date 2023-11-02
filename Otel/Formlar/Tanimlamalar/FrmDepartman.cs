﻿using DevExpress.XtraEditors;
using Otel.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.Formlar.Tanimlamalar
{
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            db.TBLDEPARTMAN.Load();
            bindingSource1.DataSource = db.TBLDEPARTMAN.Local;

            repositoryItemLookUpEditDurum.DataSource=(from x in db.TBLDURUM 
                                                      select new
                                                      {
                                                         x.DurumID,
                                                         x.DurumAd
                                                      }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Bilgiler kaydedilirken hata oluştu");
                XtraMessageBox.Show(ex.ToString());
            }
        }
    }
}
