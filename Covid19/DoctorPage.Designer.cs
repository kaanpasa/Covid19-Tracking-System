
namespace Covid19
{
    partial class DoctorPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDiseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVac1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pVac2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pPassedCovidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pQuarantineDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pQuarantineStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covidTable = new Covid19.CovidTable();
            this.patientsTableAdapter = new Covid19.CovidTableTableAdapters.PatientsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.chkVac1 = new System.Windows.Forms.CheckBox();
            this.chkVac2 = new System.Windows.Forms.CheckBox();
            this.chkPas = new System.Windows.Forms.CheckBox();
            this.chkQua = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateQua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNameDataGridViewTextBoxColumn,
            this.pSurnameDataGridViewTextBoxColumn,
            this.pTCDataGridViewTextBoxColumn,
            this.pBirthdayDataGridViewTextBoxColumn,
            this.pGenderDataGridViewTextBoxColumn,
            this.pDiseaseDataGridViewTextBoxColumn,
            this.pVac1DataGridViewCheckBoxColumn,
            this.pVac2DataGridViewCheckBoxColumn,
            this.pPassedCovidDataGridViewCheckBoxColumn,
            this.pQuarantineDataGridViewCheckBoxColumn,
            this.pQuarantineStartDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pSurnameDataGridViewTextBoxColumn
            // 
            this.pSurnameDataGridViewTextBoxColumn.DataPropertyName = "pSurname";
            this.pSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.pSurnameDataGridViewTextBoxColumn.Name = "pSurnameDataGridViewTextBoxColumn";
            this.pSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pSurnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pTCDataGridViewTextBoxColumn
            // 
            this.pTCDataGridViewTextBoxColumn.DataPropertyName = "pTC";
            this.pTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.pTCDataGridViewTextBoxColumn.Name = "pTCDataGridViewTextBoxColumn";
            this.pTCDataGridViewTextBoxColumn.ReadOnly = true;
            this.pTCDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pBirthdayDataGridViewTextBoxColumn
            // 
            this.pBirthdayDataGridViewTextBoxColumn.DataPropertyName = "pBirthday";
            this.pBirthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.pBirthdayDataGridViewTextBoxColumn.Name = "pBirthdayDataGridViewTextBoxColumn";
            this.pBirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.pBirthdayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pGenderDataGridViewTextBoxColumn
            // 
            this.pGenderDataGridViewTextBoxColumn.DataPropertyName = "pGender";
            this.pGenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.pGenderDataGridViewTextBoxColumn.Name = "pGenderDataGridViewTextBoxColumn";
            this.pGenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.pGenderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pDiseaseDataGridViewTextBoxColumn
            // 
            this.pDiseaseDataGridViewTextBoxColumn.DataPropertyName = "pDisease";
            this.pDiseaseDataGridViewTextBoxColumn.HeaderText = "Disease";
            this.pDiseaseDataGridViewTextBoxColumn.Name = "pDiseaseDataGridViewTextBoxColumn";
            this.pDiseaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDiseaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pVac1DataGridViewCheckBoxColumn
            // 
            this.pVac1DataGridViewCheckBoxColumn.DataPropertyName = "pVac1";
            this.pVac1DataGridViewCheckBoxColumn.HeaderText = "Vac1";
            this.pVac1DataGridViewCheckBoxColumn.Name = "pVac1DataGridViewCheckBoxColumn";
            this.pVac1DataGridViewCheckBoxColumn.ReadOnly = true;
            this.pVac1DataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pVac2DataGridViewCheckBoxColumn
            // 
            this.pVac2DataGridViewCheckBoxColumn.DataPropertyName = "pVac2";
            this.pVac2DataGridViewCheckBoxColumn.HeaderText = "Vac2";
            this.pVac2DataGridViewCheckBoxColumn.Name = "pVac2DataGridViewCheckBoxColumn";
            this.pVac2DataGridViewCheckBoxColumn.ReadOnly = true;
            this.pVac2DataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pPassedCovidDataGridViewCheckBoxColumn
            // 
            this.pPassedCovidDataGridViewCheckBoxColumn.DataPropertyName = "pPassedCovid";
            this.pPassedCovidDataGridViewCheckBoxColumn.HeaderText = "PassedCovid";
            this.pPassedCovidDataGridViewCheckBoxColumn.Name = "pPassedCovidDataGridViewCheckBoxColumn";
            this.pPassedCovidDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pPassedCovidDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pQuarantineDataGridViewCheckBoxColumn
            // 
            this.pQuarantineDataGridViewCheckBoxColumn.DataPropertyName = "pQuarantine";
            this.pQuarantineDataGridViewCheckBoxColumn.HeaderText = "Quarantine";
            this.pQuarantineDataGridViewCheckBoxColumn.Name = "pQuarantineDataGridViewCheckBoxColumn";
            this.pQuarantineDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pQuarantineDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pQuarantineStartDataGridViewTextBoxColumn
            // 
            this.pQuarantineStartDataGridViewTextBoxColumn.DataPropertyName = "pQuarantineStart";
            this.pQuarantineStartDataGridViewTextBoxColumn.HeaderText = "QuarantineStart";
            this.pQuarantineStartDataGridViewTextBoxColumn.Name = "pQuarantineStartDataGridViewTextBoxColumn";
            this.pQuarantineStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.pQuarantineStartDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.covidTable;
            // 
            // covidTable
            // 
            this.covidTable.DataSetName = "CovidTable";
            this.covidTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(74, 53);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(74, 79);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TC ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(23, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender:";
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(74, 157);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(100, 20);
            this.txtDis.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Disease:";
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(305, 157);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(100, 20);
            this.txtPas.TabIndex = 12;
            this.txtPas.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(243, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(211, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Quarantine Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(237, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quarantine:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(224, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Passed Covid:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(241, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Vaccine 2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(241, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Vaccine 1:";
            // 
            // dateBD
            // 
            this.dateBD.Location = new System.Drawing.Point(75, 105);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(100, 20);
            this.dateBD.TabIndex = 4;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(74, 131);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 21);
            this.cmbGender.TabIndex = 5;
            // 
            // chkVac1
            // 
            this.chkVac1.AutoSize = true;
            this.chkVac1.Location = new System.Drawing.Point(305, 30);
            this.chkVac1.Name = "chkVac1";
            this.chkVac1.Size = new System.Drawing.Size(15, 14);
            this.chkVac1.TabIndex = 7;
            this.chkVac1.UseVisualStyleBackColor = true;
            // 
            // chkVac2
            // 
            this.chkVac2.AutoSize = true;
            this.chkVac2.Location = new System.Drawing.Point(305, 56);
            this.chkVac2.Name = "chkVac2";
            this.chkVac2.Size = new System.Drawing.Size(15, 14);
            this.chkVac2.TabIndex = 8;
            this.chkVac2.UseVisualStyleBackColor = true;
            // 
            // chkPas
            // 
            this.chkPas.AutoSize = true;
            this.chkPas.Location = new System.Drawing.Point(305, 82);
            this.chkPas.Name = "chkPas";
            this.chkPas.Size = new System.Drawing.Size(15, 14);
            this.chkPas.TabIndex = 9;
            this.chkPas.UseVisualStyleBackColor = true;
            // 
            // chkQua
            // 
            this.chkQua.AutoSize = true;
            this.chkQua.Location = new System.Drawing.Point(305, 105);
            this.chkQua.Name = "chkQua";
            this.chkQua.Size = new System.Drawing.Size(15, 14);
            this.chkQua.TabIndex = 10;
            this.chkQua.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::Covid19.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(392, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 61);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = global::Covid19.Properties.Resources.delete;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(467, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(72, 62);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Covid19.Properties.Resources.edit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(545, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 62);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateQua
            // 
            this.dateQua.Location = new System.Drawing.Point(305, 131);
            this.dateQua.Name = "dateQua";
            this.dateQua.Size = new System.Drawing.Size(100, 20);
            this.dateQua.TabIndex = 36;
            // 
            // DoctorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Covid19.Properties.Resources.doctorpage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.dateQua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkQua);
            this.Controls.Add(this.chkPas);
            this.Controls.Add(this.chkVac2);
            this.Controls.Add(this.chkVac1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dateBD);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Page";
            this.Load += new System.EventHandler(this.DoctorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CovidTable covidTable;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private CovidTableTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDiseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pVac1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pVac2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pPassedCovidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pQuarantineDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pQuarantineStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.CheckBox chkVac1;
        private System.Windows.Forms.CheckBox chkVac2;
        private System.Windows.Forms.CheckBox chkPas;
        private System.Windows.Forms.CheckBox chkQua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dateQua;
    }
}