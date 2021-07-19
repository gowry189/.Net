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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            int empno = Convert.ToInt32(listBox1.Text);
            SqlDataAdapter ad = new SqlDataAdapter("select * from emp where empno =" + empno + "", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                textBox1.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                textBox3.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                textBox4.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                textBox5.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();

            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HRUHKJGL;Initial Catalog=HRB;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select empno from emp", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++){
               listBox1.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            con.Close();
            textBox1.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            emp obj = new emp();
            obj.empno = Convert.ToInt32(textBox1.Text);
            obj.empname = textBox2.Text;
            obj.job = textBox3.Text;
            obj.deptno = Convert.ToInt32(textBox4.Text);
            obj.salary = Convert.ToInt32(textBox5.Text);
            
            SqlCommand cmd = new SqlCommand("update emp set empname=@empname,job=@job,deptno=@deptno,salary=@salary where empno=@empno",con);           cmd.Parameters.AddWithValue("@empno", obj.empno);
            cmd.Parameters.AddWithValue("@empname", obj.empname);
            cmd.Parameters.AddWithValue("@job", obj.job);
            cmd.Parameters.AddWithValue("@deptno", obj.deptno);
            cmd.Parameters.AddWithValue("@salary", obj.salary);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Database Updated");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            int empno = Convert.ToInt32(textBox6.Text);
            SqlCommand cmd = new SqlCommand("delete from emp where empno=" + empno + "", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletion Successful");
            con.Close();
        }
    }
}
