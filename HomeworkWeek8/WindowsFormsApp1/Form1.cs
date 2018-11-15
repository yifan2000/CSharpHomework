using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreatOrder;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
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
            o.Add(new Order("20181111001", "aaa","10086",orderDetail1));
            OrderDetails[] orderDetail2 = { new OrderDetails("B", 5, 7) };
            o.Add(new Order("20181111002", "aab","10085", orderDetail2));
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
            string orderTelegramNumber = "error";
            string ordername = textBox3.Text;
            string orderID = " error";
            
            //订单号匹配
            string iforderID = textBox4.Text;
            Regex ifID1 = new Regex("2018+[0]+[1-9]+[0-2]+[0-9]...");
            bool ID1 = ifID1.IsMatch(iforderID);
            Regex ifID2 = new Regex("2018+[0]+[1-9]+[3]+[0-1]...");
            bool ID2 = ifID2.IsMatch(iforderID);
            Regex ifID3 = new Regex("2018+[1]+[0-2]+[3]+[0-1]...");
            bool ID3 = ifID3.IsMatch(iforderID);
            Regex ifID4 = new Regex("2018+[1]+[0-2]+[0-2]+[0-9]...");
            bool ID4 = ifID1.IsMatch(iforderID);
            if (ID1)
            {
                orderID = textBox4.Text;
            }
            if (ID2)
            {
                orderID = textBox4.Text;
            }
            if (ID3)
            {
                orderID = textBox4.Text;
            }
            if (ID4)
            {
                orderID = textBox4.Text;
            }
            //电话号码为五位数
            string iforderTelegramNumber = textBox9.Text;
            Regex ifTG1 = new Regex("[0-9]{5}");
            Regex ifTG2 = new Regex("[0-9]{6}");
            bool TG2 = ifTG2.IsMatch(iforderTelegramNumber);

            bool TG1 = ifTG1.IsMatch(iforderTelegramNumber);
            if(TG1&&!TG2)
            {
                orderTelegramNumber = textBox9.Text;
            }
           
            string goodname = textBox5.Text;
            int goodID = int.Parse(textBox6.Text);
            int price = int.Parse(textBox7.Text);
            //增添

            OrderDetails[] orderDetail3 = { new OrderDetails(goodname, goodID, price) };
          
            this.orderBindingSource.Add(new Order(orderID, ordername, orderTelegramNumber, orderDetail3));
            this.dataGridView1.DataSource =this.orderBindingSource;

            //newForm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//删除
        {
            List<Order> oo = new List<Order>();
            string removeNumber = textBox2.Text;
            
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        //打印订单
        private void button5_Click(object sender, EventArgs e)
        {
            
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Order.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"..\..\Order.xslt");

                FileStream outFileStream = File.OpenWrite(@"..\..\Order.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);


        }
    }
}
