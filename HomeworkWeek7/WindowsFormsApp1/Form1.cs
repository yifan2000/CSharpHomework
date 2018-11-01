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
            this.Load += new EventHandler(Form1_Load);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            OrderService orderService = new OrderService();
            OrderDetails[] orderDetail1 = { new OrderDetails("A", 5, 20) };
            o.Add(new Order(1, "aaa", orderDetail1));
            OrderDetails[] orderDetail2 = { new OrderDetails("B", 5, 7) };
            o.Add(new Order(2, "aab", orderDetail2));
            orderBindingSource.DataSource = o;

            
            ////绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord");
            
          


            ////修改
            //string c = Console.ReadLine();
            //int changeNumber = int.Parse(c);
            //OrderDetails[] orderDetail3 = { new OrderDetails("A", 50, 50),
            //new OrderDetails("C", 60, 60) };
            //orderService.ChangeOrder(changeNumber, 3, "aac", orderDetail3);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            

        }

        private void button1_Click(object sender, EventArgs e)//查询
        {
            orderBindingSource.DataSource =
                o.Where(os => os.NextCilentName == KeyWord);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//增添
        {


            //Form1 newForm = new Form1();
            string ordername = textBox3.Text;
            int orderID = int.Parse(textBox4.Text);
            string goodname = textBox5.Text;
            int goodID = int.Parse(textBox6.Text);
            int price = int.Parse(textBox7.Text);
            //增添

            OrderDetails[] orderDetail3 = { new OrderDetails(goodname, goodID, price) };
          
            this.orderBindingSource.Add(new Order(orderID, ordername, orderDetail3));
            this.dataGridView1.DataSource =this.orderBindingSource;

            //newForm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//删除
        {
            List<Order> oo = new List<Order>();
            int removeNumber = int.Parse(textBox2.Text);
            
            foreach (Order TheOrders in o)
            {
                if (TheOrders.NextOrderID == removeNumber)
                {
                    oo.Add(TheOrders);
                }
            }
            foreach(var oos in oo)
            {
                o.Remove(oos);
            }
            orderBindingSource.DataSource = null;
            orderBindingSource.DataSource = o;
        }

        private void button4_Click(object sender, EventArgs e)//修改
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
