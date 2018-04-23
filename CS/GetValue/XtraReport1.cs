using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace GetValue
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void calculatedField1_GetValue(object sender, GetValueEventArgs e)
        {
            DataRowView view = e.Row as DataRowView;
            e.Value = GetCurrentColumnValue("CategoryName") + " " + view.Row["UnitPrice"];
        }

    }
}
