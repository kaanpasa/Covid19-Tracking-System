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
    public partial class PatientPage : Form
    {
        DataTable dtp = new DataTable();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\covid19.mdb");
        OleDbDataAdapter adapt = new OleDbDataAdapter();
        public int c;
        public PatientPage(int index)
        {
            InitializeComponent();
            c = index;
        }

        private void PatientPage_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Patients", con);
            da.Fill(dtp);
            con.Close();
            string bd = Convert.ToDateTime(dtp.Rows[c]["pBirthday"]).ToString("dd/MM/yyyy");
            string qua = dtp.Rows[c]["pQuarantineStart"].ToString();
            lblName.Text += dtp.Rows[c]["pName"].ToString();
            lblSurname.Text += dtp.Rows[c]["pSurname"].ToString();
            lblTC.Text += dtp.Rows[c]["pTC"].ToString();
            lblBd.Text += bd;
            lblGender.Text += dtp.Rows[c]["pGender"].ToString();
            lblDis.Text += dtp.Rows[c]["pDisease"].ToString();
            chkVac1.Checked = Convert.ToBoolean(dtp.Rows[c]["pVac1"]);
            chkVac2.Checked = Convert.ToBoolean(dtp.Rows[c]["pVac2"]);
            chkPas.Checked = Convert.ToBoolean(dtp.Rows[c]["pPassedCovid"]);
            chkQua.Checked = Convert.ToBoolean(dtp.Rows[c]["pQuarantine"]);
            if (chkQua.Checked == true)
            {
                lblQua.Text += qua;
            }
            else
            {
                lblQua.Text = "";
            }
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkQua_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkVac2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkVac1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
