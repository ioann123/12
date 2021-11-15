using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace WindowsForms66
{
    public partial class Form1 : Form
    {
        static string conStr = "Data Source=10.10.0.120;Initial Catalog=abd-41;User ID=abd31_21;Password=123456qwerty.";
        DataContext context = new DataContext(conStr);

        public Form1()
        {
            InitializeComponent();
            Table<Prod> prodykt = context.GetTable<Prod>();
            dataGridView1.DataSource = prodykt.ToList();

            Table<Pos> post = context.GetTable<Pos>();
            dataGridView2.DataSource = post.ToList();

            Table<rabot> rab = context.GetTable<rabot>();
            dataGridView3.DataSource = rab.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name_prod= context.GetTable<Prod>().Where(x => x.ProductName.Contains(textBox1.Text));
            dataGridView1.DataSource = name_prod.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name_prod = context.GetTable<Prod>().Where(x => x.ProductName.Contains(Convert.ToString(comboBox1.SelectedValue)));
            dataGridView1.DataSource = name_prod.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_abd_41DataSet1.Prodykt". При необходимости она может быть перемещена или удалена.
            this.prodyktTableAdapter.Fill(this._abd_41DataSet1.Prodykt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_abd_41DataSet.Rab". При необходимости она может быть перемещена или удалена.
            this.rabTableAdapter.Fill(this._abd_41DataSet.Rab);

        }
    }
}
