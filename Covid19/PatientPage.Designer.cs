
namespace Covid19
{
    partial class PatientPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientPage));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBd = new System.Windows.Forms.Label();
            this.lblDis = new System.Windows.Forms.Label();
            this.chkVac1 = new System.Windows.Forms.CheckBox();
            this.chkVac2 = new System.Windows.Forms.CheckBox();
            this.chkPas = new System.Windows.Forms.CheckBox();
            this.chkQua = new System.Windows.Forms.CheckBox();
            this.lblQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(23, 166);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(23, 188);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname: ";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(23, 213);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(37, 20);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "TC: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(23, 260);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender: ";
            // 
            // lblBd
            // 
            this.lblBd.AutoSize = true;
            this.lblBd.BackColor = System.Drawing.Color.Transparent;
            this.lblBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBd.Location = new System.Drawing.Point(23, 235);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(75, 20);
            this.lblBd.TabIndex = 3;
            this.lblBd.Text = "Birthday: ";
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.BackColor = System.Drawing.Color.Transparent;
            this.lblDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDis.Location = new System.Drawing.Point(23, 284);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(75, 20);
            this.lblDis.TabIndex = 5;
            this.lblDis.Text = "Disease: ";
            // 
            // chkVac1
            // 
            this.chkVac1.AutoCheck = false;
            this.chkVac1.AutoSize = true;
            this.chkVac1.BackColor = System.Drawing.Color.Transparent;
            this.chkVac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkVac1.Location = new System.Drawing.Point(365, 166);
            this.chkVac1.Name = "chkVac1";
            this.chkVac1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkVac1.Size = new System.Drawing.Size(98, 24);
            this.chkVac1.TabIndex = 6;
            this.chkVac1.Text = "Vaccine 1";
            this.chkVac1.UseVisualStyleBackColor = false;
            this.chkVac1.CheckedChanged += new System.EventHandler(this.chkVac1_CheckedChanged);
            // 
            // chkVac2
            // 
            this.chkVac2.AutoCheck = false;
            this.chkVac2.AutoSize = true;
            this.chkVac2.BackColor = System.Drawing.Color.Transparent;
            this.chkVac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkVac2.Location = new System.Drawing.Point(365, 191);
            this.chkVac2.Name = "chkVac2";
            this.chkVac2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkVac2.Size = new System.Drawing.Size(98, 24);
            this.chkVac2.TabIndex = 7;
            this.chkVac2.Text = "Vaccine 2";
            this.chkVac2.UseVisualStyleBackColor = false;
            this.chkVac2.CheckedChanged += new System.EventHandler(this.chkVac2_CheckedChanged);
            // 
            // chkPas
            // 
            this.chkPas.AutoCheck = false;
            this.chkPas.AutoSize = true;
            this.chkPas.BackColor = System.Drawing.Color.Transparent;
            this.chkPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkPas.Location = new System.Drawing.Point(365, 216);
            this.chkPas.Name = "chkPas";
            this.chkPas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPas.Size = new System.Drawing.Size(124, 24);
            this.chkPas.TabIndex = 8;
            this.chkPas.Text = "Passed Covid";
            this.chkPas.UseVisualStyleBackColor = false;
            this.chkPas.CheckedChanged += new System.EventHandler(this.chkPas_CheckedChanged);
            // 
            // chkQua
            // 
            this.chkQua.AutoCheck = false;
            this.chkQua.AutoSize = true;
            this.chkQua.BackColor = System.Drawing.Color.Transparent;
            this.chkQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkQua.Location = new System.Drawing.Point(365, 238);
            this.chkQua.Name = "chkQua";
            this.chkQua.Size = new System.Drawing.Size(107, 24);
            this.chkQua.TabIndex = 9;
            this.chkQua.Text = "Quarantine";
            this.chkQua.UseVisualStyleBackColor = false;
            this.chkQua.CheckedChanged += new System.EventHandler(this.chkQua_CheckedChanged);
            // 
            // lblQua
            // 
            this.lblQua.AutoSize = true;
            this.lblQua.BackColor = System.Drawing.Color.Transparent;
            this.lblQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQua.Location = new System.Drawing.Point(362, 264);
            this.lblQua.Name = "lblQua";
            this.lblQua.Size = new System.Drawing.Size(135, 20);
            this.lblQua.TabIndex = 10;
            this.lblQua.Text = "Quarantine Start: ";
            this.lblQua.Click += new System.EventHandler(this.label1_Click);
            // 
            // PatientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Covid19.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 457);
            this.Controls.Add(this.lblQua);
            this.Controls.Add(this.chkQua);
            this.Controls.Add(this.chkPas);
            this.Controls.Add(this.chkVac2);
            this.Controls.Add(this.chkVac1);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBd);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Page";
            this.Load += new System.EventHandler(this.PatientPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBd;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.CheckBox chkVac1;
        private System.Windows.Forms.CheckBox chkVac2;
        private System.Windows.Forms.CheckBox chkPas;
        private System.Windows.Forms.CheckBox chkQua;
        private System.Windows.Forms.Label lblQua;
    }
}