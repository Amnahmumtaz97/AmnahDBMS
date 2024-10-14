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

namespace AmnahDBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=AMNAH;Initial Catalog=project;Integrated Security=True;Trust Server Certificate=True";
           //
           SqlConnection sql= new SqlConnection(ConnectionString);
            //
            sql.Open();
            //

        }

    }
}
