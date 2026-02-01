using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.Forms
{

    public partial class AppointmentsForm : Form
    {
        private static AppointmentsForm instance;

        public static AppointmentsForm getAppInstance()
        {


            if (instance == null || instance.IsDisposed)
            {
                instance = new AppointmentsForm();
            }
            return instance;

        }

        SqlConnection con = new SqlConnection(@"Data Source=WESAM\SQLEXPRESS;Initial Catalog=DentalClinic;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        DataTable tablePatients = new DataTable();
        DataTable tableDoctor = new DataTable();
        BindingSource bs = new BindingSource();
        private AppointmentsForm()
        {
            InitializeComponent();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            reff();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            getnamepatients();
            getnamedoctor();
            reff();
        }
        void reff()
        {
            /*table.Clear();

            adapter = new SqlDataAdapter("SELECT * FROM T_appointment", con);

            // يولّد تلقائيًا أوامر Insert/Update/Delete بناءً على SELECT
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);

            adapter.Fill(table);

            bs.DataSource = table;
            dataGridView1.DataSource = bs;*/
            
                table.Clear();

                adapter = new SqlDataAdapter("SELECT * FROM T_appointment", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
                adapter.Fill(table);

                bs.DataSource = table;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = bs;

                // ---- هنا نطبّق فكرة عرض الاسم بدل الـ ID ----
                AddLookupColumnsToGrid();
            

        }
        void AddLookupColumnsToGrid()
        {
            // إذا الأعمدة اتضافت قبل كذا لا تعيد إضافتها
            if (dataGridView1.Columns.Contains("colPatientName"))
                return;

            // اخفاء أعمدة الـ ID الأصلية
            if (dataGridView1.Columns.Contains("P_id"))
                dataGridView1.Columns["P_id"].Visible = false;

            if (dataGridView1.Columns.Contains("D_id"))
                dataGridView1.Columns["D_id"].Visible = false;

            // 1) عمود المريض (يعرض الاسم ويخزن id)
            DataGridViewComboBoxColumn colPatient = new DataGridViewComboBoxColumn();
            colPatient.Name = "colPatientName";
            colPatient.HeaderText = "patint";
            colPatient.DataSource = tablePatients;     // نفس الجدول اللي عبّيته في getnamepatients()
            colPatient.DisplayMember = "P_name";
            colPatient.ValueMember = "P_id";
            colPatient.DataPropertyName = "P_id";      // يربط بعمود الـ ID في جدول المواعيد
            colPatient.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing; // عشان يبان كنص مش سهم
            dataGridView1.Columns.Add(colPatient);

            // 2) عمود الدكتور (يعرض الاسم ويخزن id)
            DataGridViewComboBoxColumn colDoctor = new DataGridViewComboBoxColumn();
            colDoctor.Name = "colDoctorName";
            colDoctor.HeaderText = "Doctor";
            colDoctor.DataSource = tableDoctor;
            colDoctor.DisplayMember = "D_name";
            colDoctor.ValueMember = "D_id";
            colDoctor.DataPropertyName = "D_id";
            colDoctor.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(colDoctor);

            // خليهم أول عمودين من اليسار
            dataGridView1.Columns["colPatientName"].DisplayIndex = 0;
            dataGridView1.Columns["colDoctorName"].DisplayIndex = 1;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sql = new SqlCommand("insertappointment", con);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@P_id_proc", com_patient.SelectedValue.ToString());
            sql.Parameters.AddWithValue("@D_id_proc", com_doctor.SelectedValue.ToString());
            sql.Parameters.AddWithValue("@data", dtp.Value.ToString("yyyy-MM-dd"));
            sql.Parameters.AddWithValue("@reason", txt_reson.Text.Trim());
            sql.Parameters.AddWithValue("@cost", txtCost.Text.Trim());
            sql.ExecuteNonQuery();
            MessageBox.Show("done");
            con.Close();
            reff();
            // T_appointment (P_id,D_id,A_data,A_reason,A_cost) values (@P_id_proc,@D_id_proc,@data,@reason,@cost)
        }

        private void com_patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        void getnamepatients()
        {
            tablePatients.Clear();

            adapter = new SqlDataAdapter("getpatients", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(tablePatients);

            com_patient.DataSource = tablePatients;
            com_patient.DisplayMember = "P_name";
            com_patient.ValueMember = "P_id";
            com_patient.SelectedIndex = -1; // اختياري
        }

        
        void getnamedoctor()
        {
            tableDoctor.Clear();

            adapter = new SqlDataAdapter("getdoctor", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(tableDoctor);

            com_doctor.DataSource = tableDoctor;
            com_doctor.DisplayMember = "D_name";
            com_doctor.ValueMember = "D_id";
            com_doctor.SelectedIndex = -1; // اختياري
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(table);
            MessageBox.Show("تم التحديثاً");
            reff();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("حدد صف أولاً");
                return;
            }

            var result = MessageBox.Show("هل أنت متأكد تريد حذف هذا المريض؟",
                "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                // حذف من DataGridView (يعني من DataTable المرتبط)
                bs.RemoveCurrent();

                // حفظ الحذف في قاعدة البيانات
                adapter.Update(table);

                MessageBox.Show("تم الحذف بنجاح ✅");
                reff(); // Refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء الحذف: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            //this.Hide();
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }
    }
    }

