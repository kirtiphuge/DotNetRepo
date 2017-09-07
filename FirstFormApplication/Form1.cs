using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            String name = textBox2.Text;
            int Sal = int.Parse(textBox3.Text);

            using (var db = new EmpEntities())
            {
                var emp = new EmpTable()
                {
                    Empid = id,
                    EmpName = name,
                    Salary = Sal

                };

                db.EmpTables.Add(emp);
                db.SaveChanges();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                MessageBox.Show("Record Added Successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new EmpEntities())
            {
                var query = from b in db.EmpTables select b;
                DataTable d = new DataTable();

                d.Columns.Add("EmpID", typeof(int));
                d.Columns.Add("EmpName", typeof(string));
                d.Columns.Add("Salary", typeof(int));

                foreach (EmpTable item in query)
                {
                    d.Rows.Add(item.Empid, item.EmpName, item.Salary); 
                }
                dataGridView1.DataSource = d;
            }
        }
    }
    }

