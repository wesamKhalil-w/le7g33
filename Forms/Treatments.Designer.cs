namespace DentalClinic.Forms
{
    partial class Treatments
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
            this.a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_updeate = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_descri = new System.Windows.Forms.TextBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ser = new System.Windows.Forms.Label();
            this.txt_ser = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.a);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 111);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(156, 42);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(470, 27);
            this.a.TabIndex = 0;
            this.a.Text = "Treatments and proceger Mangament";
            this.a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Treatment Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Treatment Name :";
            // 
            // btn_updeate
            // 
            this.btn_updeate.Location = new System.Drawing.Point(344, 351);
            this.btn_updeate.Name = "btn_updeate";
            this.btn_updeate.Size = new System.Drawing.Size(101, 43);
            this.btn_updeate.TabIndex = 3;
            this.btn_updeate.Text = "Update";
            this.btn_updeate.UseVisualStyleBackColor = true;
            this.btn_updeate.Click += new System.EventHandler(this.btn_updeate_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(180, 351);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(101, 43);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(522, 351);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 43);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Add";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(802, 407);
            this.dataGridView1.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(354, 117);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(270, 27);
            this.txt_name.TabIndex = 1;
            // 
            // txt_descri
            // 
            this.txt_descri.Location = new System.Drawing.Point(354, 170);
            this.txt_descri.Name = "txt_descri";
            this.txt_descri.Size = new System.Drawing.Size(270, 27);
            this.txt_descri.TabIndex = 2;
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(354, 240);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(270, 27);
            this.txt_cost.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost : ";
            // 
            // ser
            // 
            this.ser.AutoSize = true;
            this.ser.Location = new System.Drawing.Point(196, 299);
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(54, 19);
            this.ser.TabIndex = 31;
            this.ser.Text = "search";
            // 
            // txt_ser
            // 
            this.txt_ser.Location = new System.Drawing.Point(354, 291);
            this.txt_ser.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ser.Name = "txt_ser";
            this.txt_ser.Size = new System.Drawing.Size(270, 27);
            this.txt_ser.TabIndex = 29;
            this.txt_ser.TextChanged += new System.EventHandler(this.txt_ser_TextChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(404, 287);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(0, 19);
            this.lblNotes.TabIndex = 30;
            // 
            // Treatments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(802, 829);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.txt_ser);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_descri);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_updeate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Treatments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treatments";
            this.Load += new System.EventHandler(this.Treatments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_updeate;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_descri;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ser;
        private System.Windows.Forms.TextBox txt_ser;
        private System.Windows.Forms.Label lblNotes;
    }
}