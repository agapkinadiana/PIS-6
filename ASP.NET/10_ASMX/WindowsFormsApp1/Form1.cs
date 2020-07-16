using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Proxy - реализация по wsdl , добавлялась автоматически при добавлении ссылки в форму
        public WebService1SoapClient Service { get; set; }

        public Form1()
        {
            InitializeComponent();
            Service = new WebService1SoapClient();
            UpdateTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows[0] != null)
            {
                Service.AddDict(new Person
                {
                    LastName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    Phone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString()
                });
                UpdateTable();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        private void UpdateTable()
        {
            dataGridView1.DataSource = Service.GetDict().ToList();
        }
    }
}
