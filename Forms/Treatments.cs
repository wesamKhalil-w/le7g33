using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DentalClinic.Forms
{
    
    public partial class Treatments : Form
    {
        SqlConnection cont = new SqlConnection(@"Data Source=WESAM\SQLEXPRESS;Initial Catalog=DentalClinic;Integrated Security=True");
        SqlDataAdapter adaptert;
        DataTable tablet = new DataTable();
        BindingSource bst = new BindingSource();
        public Treatments()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cont.Open();
            SqlCommand sql = new SqlCommand("inserttreatments", cont);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@name", txt_name.Text.Trim());
            sql.Parameters.AddWithValue("@description", txt_descri.Text.Trim());
            sql.Parameters.AddWithValue("@cost", txt_cost.Text.Trim());
            sql.ExecuteNonQuery();
            MessageBox.Show("done");
            cont.Close();
            reff();
            //T_treatments (T_name,T_description,T_cost) values (@name,@description,@cost)
        }

        private void Treatments_Load(object sender, EventArgs e)
        {
            reff();
        }
        void reff()
        {
            tablet.Clear();

            adaptert = new SqlDataAdapter("SELECT * FROM T_treatments", cont);

            // يولّد تلقائيًا أوامر Insert/Update/Delete بناءً على SELECT
            SqlCommandBuilder cb = new SqlCommandBuilder(adaptert);

            adaptert.Fill(tablet);

            bst.DataSource = tablet;
            dataGridView1.DataSource = bst;
        }

        private void btn_updeate_Click(object sender, EventArgs e)
        {
            adaptert.Update(tablet);
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
                bst.RemoveCurrent();

                // حفظ الحذف في قاعدة البيانات
                adaptert.Update(tablet);

                MessageBox.Show("تم الحذف بنجاح ✅");
                reff(); // Refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء الحذف: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
        }

        private void txt_ser_TextChanged(object sender, EventArgs e)
        {
            bst.Filter = $"T_name like '%{txt_ser.Text}%' ";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
