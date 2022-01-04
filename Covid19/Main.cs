using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Covid19
{
    public partial class Main : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\covid19.mdb");
        OleDbDataAdapter adapt = new OleDbDataAdapter();
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonDesign();
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            DoctorLogin doclog = new DoctorLogin();
            doclog.Show();
            this.Hide();
        }

        private void btnPat_Click(object sender, EventArgs e)
        {
            PatientLogin patlog = new PatientLogin();
            patlog.Show();
            this.Hide();
        }

        public void buttonDesign()
        {
            btnDoc.FlatStyle = FlatStyle.Flat;
            btnDoc.BackColor = Color.Transparent;
            btnDoc.FlatAppearance.BorderSize = 0;
            btnDoc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDoc.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnPat.FlatStyle = FlatStyle.Flat;
            btnPat.BackColor = Color.Transparent;
            btnPat.FlatAppearance.BorderSize = 0;
            btnPat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPat.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }
    }
}
