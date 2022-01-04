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
    public partial class PatientLogin : Form
    {
        public int index = 0;
        DataTable dtp = new DataTable();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\covid19.mdb");
        OleDbDataAdapter adapt = new OleDbDataAdapter();
        public PatientLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Patients", con);
            da.Fill(dtp);
            con.Close();
            foreach (DataRow item in dtp.Rows)
            {
                if (txtID.Text.ToString() == item[9].ToString() && txtPas.Text.ToString() == item[12].ToString())
                {
                    
                    Main main = new Main();
                    PatientPage patPage = new PatientPage(index);
                    main.Hide();
                    patPage.Show();
                    this.Hide();
                    break;
                }
                index++;
            }
        }

        private void PatientLogin_Load(object sender, EventArgs e)
        {
            buttonDesign();
        }

        public void buttonDesign()
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}
