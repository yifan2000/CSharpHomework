using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreatOrder;
using static GreatOrder.OrderDetails;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Order> o = new List<Order>();
        public string KeyWord { get; set; }
        public Form1()
        {
            InitializeComponent();
            OrderService orderService = new OrderService();
            OrderDetails[] orderDetail1 = { new OrderDetails("A", 5, 20)
                , new OrderDetails("B", 6, 6), new OrderDetails("C", 7, 8) };
            o.Add(new Order(1, "aaa", orderDetail1));
            OrderDetails[] orderDetail2 = { new OrderDetails("A", 5, 7)
                , new OrderDetails("B", 6, 5), new OrderDetails("C", 7, 6) };
            o.Add(new Order(2, "aab", orderDetail2));
            orderBindingSource.DataSource = o;
            ////绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //studentBindingSource.DataSource =
            //   students.Where(s => s.Name == KeyWord);
            orderBindingSource.DataSource =
                o.Where(os => os.NextCilentName == KeyWord);
        }

      
    }
}
