using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(t0.Text);
            string name = t1.Text;
            string address = t2.Text;
            string email = t3.Text;
            string cellno = t4.Text;
            string city = t5.Text;

            try
            {
                string con = "Server=DESKTOP-NCKVTGK\\SQLEXPRESS; Database=CRUD; Integrated Security = true;";
                SqlConnection cont = new SqlConnection(con);
                string q = "INSERT INTO Travel(id,name,address,cellno,email,city)VALUES("+id+",'" + name + "','" + address + "','" + cellno + "','" + email + "','" + city + "')";

                SqlCommand com = new SqlCommand(q, cont);
                cont.Open();
                int t = com.ExecuteNonQuery();
                if (t == 1) MessageBox.Show("Saved Successfully!");
                else MessageBox.Show("Not Saved!");
                cont.Close();
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Server=DESKTOP-NCKVTGK\\SQLEXPRESS; Database=CRUD; Integrated Security = true;";
                SqlConnection cont = new SqlConnection(con); string q = "select * from Travel";
                SqlCommand com = new SqlCommand(q, cont);
                cont.Open();
                SqlDataAdapter adp = new SqlDataAdapter(com);
                DataTable tab = new DataTable();
                adp.Fill(tab);
                Grid.DataSource = tab;
                cont.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(id1.Text);
                string con = "Server=DESKTOP-NCKVTGK\\SQLEXPRESS; Database=CRUD; Integrated Security = true;";
                SqlConnection cont = new SqlConnection(con);
                string q = "delete from Travel where id =" + id;
                SqlCommand com = new SqlCommand(q, cont);
                cont.Open();
                int t = com.ExecuteNonQuery();
                if (t == 1) MessageBox.Show("Deleted Successfully");
                else MessageBox.Show("Could Not Deleted!");
                cont.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}