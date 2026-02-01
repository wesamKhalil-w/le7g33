namespace DentalClinic.Forms
{
    partial class AppointmentsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.com_doctor = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lblEstimatedCost = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDentist = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.com_patient = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_reson = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 329);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(0, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Appointments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dentist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DentalClinic.Properties.Resources.tooth;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DentalClinic.Properties.Resources.appointment1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(8, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 175);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Reson";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(905, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(905, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "patian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date & Time";
            // 
            // com_doctor
            // 
            this.com_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_doctor.FormattingEnabled = true;
            this.com_doctor.Location = new System.Drawing.Point(788, 145);
            this.com_doctor.Margin = new System.Windows.Forms.Padding(4);
            this.com_doctor.Name = "com_doctor";
            this.com_doctor.Size = new System.Drawing.Size(298, 27);
            this.com_doctor.TabIndex = 3;
            this.com_doctor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(307, 288);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 41);
            this.Back.TabIndex = 20;
            this.Back.Text = "<< Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.Location = new System.Drawing.Point(925, 288);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 45);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEstimatedCost
            // 
            this.lblEstimatedCost.AutoSize = true;
            this.lblEstimatedCost.Location = new System.Drawing.Point(641, 196);
            this.lblEstimatedCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstimatedCost.Name = "lblEstimatedCost";
            this.lblEstimatedCost.Size = new System.Drawing.Size(0, 19);
            this.lblEstimatedCost.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(488, 288);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 45);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // lblDentist
            // 
            this.lblDentist.AutoSize = true;
            this.lblDentist.Location = new System.Drawing.Point(885, 105);
            this.lblDentist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDentist.Name = "lblDentist";
            this.lblDentist.Size = new System.Drawing.Size(0, 19);
            this.lblDentist.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Location = new System.Drawing.Point(699, 292);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 45);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(437, 105);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(0, 19);
            this.lblReason.TabIndex = 14;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(399, 23);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 19);
            this.lblDateTime.TabIndex = 11;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(905, 23);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(0, 19);
            this.lblPatient.TabIndex = 9;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(544, 235);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(298, 27);
            this.txtCost.TabIndex = 5;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // com_patient
            // 
            this.com_patient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_patient.FormattingEnabled = true;
            this.com_patient.Location = new System.Drawing.Point(788, 62);
            this.com_patient.Margin = new System.Windows.Forms.Padding(4);
            this.com_patient.Name = "com_patient";
            this.com_patient.Size = new System.Drawing.Size(298, 27);
            this.com_patient.TabIndex = 1;
            this.com_patient.SelectedIndexChanged += new System.EventHandler(this.com_patient_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(304, 59);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(298, 27);
            this.dtp.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 436);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_reson
            // 
            this.txt_reson.Location = new System.Drawing.Point(307, 154);
            this.txt_reson.Margin = new System.Windows.Forms.Padding(4);
            this.txt_reson.Name = "txt_reson";
            this.txt_reson.Size = new System.Drawing.Size(298, 27);
            this.txt_reson.TabIndex = 4;
            // 
            // AppointmentsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1114, 780);
            this.Controls.Add(this.txt_reson);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.com_patient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.com_doctor);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblEstimatedCost);
            this.Controls.Add(this.lblDentist);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentsForm";
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_doctor;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lblEstimatedCost;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDentist;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox com_patient;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_reson;
    }
}