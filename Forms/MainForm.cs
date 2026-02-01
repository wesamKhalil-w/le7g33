using System;
using DentalClinic.Models;
using DentalClinic.Services;
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
    
    public partial class MainForm : Form
    {
        private User currentUser;
        private PatientService patientService;
        private AppointmentService appointmentService;
        SqlConnection con = new SqlConnection(@"Data Source=WESAM\SQLEXPRESS;Initial Catalog=DentalClinic;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        BindingSource bs = new BindingSource();
        DataTable tablePatients = new DataTable();
        DataTable tableDoctor = new DataTable();
        DataTable tableidpa = new DataTable();

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            patientService = new PatientService();
            appointmentService = new AppointmentService();
            
            lblWelcome.Text = $"Welcome, { user.FullName} ({ user.Role})";
            LoadDashboardData();

        }
        public MainForm() : this(new User { FullName = "Guest", Role = "Guest" }) { }

        private void LoadDashboardData()
        {
            var patients = patientService.GetAllPatients();
            var appointments = appointmentService.GetAllAppointments();

            lbl_patitents.Text = patients.Count.ToString();
            lblTotalAppointments.Text = appointments.Count.ToString();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*patientsForm.ShowDialog();
            LoadDashboardData();
            this.Hide();*/
            Patient p = Patient.getInstance();
            p.Show();
            //this.Close();
            //Patient.Instance.BringToFront();
            //LoadDashboardData();
            //this.Hide();


        }

        private void dvgAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            getnamedoctor();
            getnamepatients();
            reff();
            //LoadPatientsCount_Adapter();
            //LoadPatientsCount();

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentsForm a = AppointmentsForm.getAppInstance();
            a.Show();
            /*AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.ShowDialog();
            LoadDashboardData();*/

        }

        private void treatmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treatments t = new Treatments();
            t.ShowDialog();
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports feature will be implemented here.");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void getnamedoctor()
        {
            tableDoctor.Clear();

            adapter = new SqlDataAdapter("getdoctor", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(tableDoctor);
        }
        void getnamepatients()
        {
            tablePatients.Clear();

            adapter = new SqlDataAdapter("getpatients", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(tablePatients);
        }
        void countidp()
        {
            tablePatients.Clear();

            adapter = new SqlDataAdapter("countpat", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            //adapter.Fill(tableidpa);
        }

        private void lbl_patitents_Click(object sender, EventArgs e)
        {
            
        }
      


    }
}
