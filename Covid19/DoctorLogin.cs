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
    public partial class DoctorLogin : Form
    {
        DataTable dtc = new DataTable();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\covid19.mdb");
        OleDbDataAdapter adapt = new OleDbDataAdapter();
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void DoctorLogin_Load(object sender, EventArgs e)
        {
            buttonDesign();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Doctors", con);
            da.Fill(dtc);
            con.Close();
            foreach (DataRow item in dtc.Rows)
            {
                if (txtDoc.Text.ToString() == item[5].ToString() && txtPas.Text.ToString() == item[4].ToString())
                {
                    Main main = new Main();
                    DoctorPage docPage = new DoctorPage();

                    main.Hide();
                    docPage.Show();
                    this.Hide();
                    break;
                }
            }
        }

        public void buttonDesign()
        {
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void txtPas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
