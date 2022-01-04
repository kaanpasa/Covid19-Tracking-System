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
    public partial class DoctorPage : Form
    {
        DataTable dtc = new DataTable();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\covid19.mdb");
        OleDbDataAdapter adapt = new OleDbDataAdapter();
        OleDbCommand cmd;

        void ShowPatient()
        {
            con.Open();
            adapt = new OleDbDataAdapter("Select * From Patients", con);
            DataTable tablo = new DataTable();
            adapt.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
        }
        public DoctorPage()
        {
            InitializeComponent();
        }

        private void DoctorPage_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Patients", con);
            da.Fill(dtc);
            con.Close();
            dataGridView1.DataSource = dtc;
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            buttonDesign();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string add = "Insert into Patients (pName,pSurname,pBirthday,pGender,pQuarantine,pVac1,pVac2,pQuarantineStart,pTC,pDisease,pPassedCovid,pPassword) values " +
            "(@name,@surnamde,@bd,@gen,@qua,@vac1,@vac2,@quadate,@tc,@dis,@pascov,@pas)";
            cmd = new OleDbCommand(add, con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@bd", dateBD.Value.ToString("yyyy.MM.dd"));
            cmd.Parameters.AddWithValue("@gen", cmbGender.SelectedItem);
            cmd.Parameters.AddWithValue("@qua", chkQua.Checked);
            cmd.Parameters.AddWithValue("@vac1", chkVac1.Checked);
            cmd.Parameters.AddWithValue("@vac2", chkVac2.Checked);
            if (chkQua.Checked == true)
            {
                String.Format("{0:dd/MM/yyyy}", dateQua.Text);
                cmd.Parameters.AddWithValue("@quadate", dateQua.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@quadate", " ");
            }
            cmd.Parameters.AddWithValue("@tc", txtTC.Text);
            cmd.Parameters.AddWithValue("@dis", txtDis.Text);
            cmd.Parameters.AddWithValue("@pascov", chkPas.Checked);
            cmd.Parameters.AddWithValue("@pas", txtPas.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ShowPatient();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From Patients Where pTC=@tc";
            cmd = new OleDbCommand(delete, con);
            cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells[2].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ShowPatient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update = "UPDATE Patients SET pName = '" + txtName.Text + "', pSurname = '" + txtSurname.Text + "',pBirthday = '" + dateBD.Value.ToString() + "',pGender = '" + cmbGender.SelectedItem + "', pVac1 = " + chkVac1.Checked + ", pQuarantine = " + chkQua.Checked + ", pVac2 = " + chkVac2.Checked + ", pDisease = '" + txtDis.Text + "', pPassedCovid = " + chkPas.Checked + ",pQuarantineStart='"+ dateQua.Text+"' Where pTC = '" + txtTC.Text + "'";
            cmd = new OleDbCommand(update, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ShowPatient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTC.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateBD.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            cmbGender.SelectedItem = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtDis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            chkVac1.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value);
            chkVac2.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[7].Value);
            chkPas.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value);
            chkQua.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[9].Value);
            if (dataGridView1.CurrentRow.Cells[10].Value == DBNull.Value)
            {
                dateQua.Text = "";
            }
            else
            {
                String.Format("{0:dd/MM/yyyy}", dateQua.Text);
                dateQua.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
        }
        public void buttonDesign()
        {
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.BackColor = Color.Transparent;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_delete.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

    }
}
