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
    //private static partial instance;

    public partial class Patient : Form
    {
       
        private static Patient instance;

        public static Patient getInstance()
        {
         
           
                if (instance == null || instance.IsDisposed){
                    instance = new Patient();
                    }
                return instance;
            
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=WESAM\SQLEXPRESS;Initial Catalog=DentalClinic;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        BindingSource bs = new BindingSource();
        private Patient()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            reff();
        }
        void reff()
        {
            table.Clear();
            adapter = new SqlDataAdapter("SELECT * FROM T_patients", con);
            // يولّد تلقائيًا أوامر Insert/Update/Delete بناءً على SELECT
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);

            adapter.Fill(table);

            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sql = new SqlCommand("insertpatients", con);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@name", txt_name.Text.Trim());
            sql.Parameters.AddWithValue("@phone", txt_phone.Text.Trim());
            sql.Parameters.AddWithValue("@address", txt_address.Text.Trim());
            sql.Parameters.AddWithValue("@date", brithDate.Value.ToString("yyyy-MM-dd"));
            sql.ExecuteNonQuery();
            MessageBox.Show("done");
            con.Close();
            reff();
            //_patients (P_name,P_phone,P_address,P_date) values (@name,@phone,@address,@date)
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            adapter.Update(table);
            MessageBox.Show("تم التحديثاً");
            reff();
        }

        private void btn_del_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            reaport_form re = new reaport_form();
            CrystalReport1 r  = new CrystalReport1();
            //Cr n = new Cr();
            re.crystalReportViewer1.ReportSource = r;
            re.Show();



        }
        /*public static Patient getInstance()
{
   if(Instance == null || Instance.ISDisposed)
   {
       instance = new 
   }
}*/

    }

}
