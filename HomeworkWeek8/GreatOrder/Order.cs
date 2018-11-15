using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

//1、为订单添加数据验证功能，要求
//  （1）订单号不能为空、不能重复、并且是”年月日+三位流水号”的形式。
//  （2）客户的电话号码是正确的格式。
//2、将订单导出为HTML文件，在浏览器打开并显示。（备注：使用XSLT进行转换） 
//截止时间下周四晚9:00

namespace GreatOrder
{
    [Serializable]
    public class Order
    {
        public Order() { }
        private string orderID;
        private string CilentName;
        OrderDetails[] orderDetails;
        private string CilentTelephoneNumber;
        public Order(string NextOrderID, string NextCilentName,string NextCilentTelephoneNumber, OrderDetails[] NextorderDetails)
        {
            this.orderID = NextOrderID;
            this.CilentName = NextCilentName;
            this.CilentTelephoneNumber = NextCilentTelephoneNumber;
            this.orderDetails = NextorderDetails;
        }
        public string NextCilentName
        {
            get { return CilentName; }
            set {; }
        }
        public string NextCilentTelephoneNumber
        {
            get { return CilentTelephoneNumber; }
            set {; }
        }
        public string NextOrderID
        {
            get { return orderID; }
        }
        public OrderDetails[] NextorderDetails
        {
            get { return orderDetails; }
        }
    }
    //所有商品、数量、单价
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails() { }
        private string goodName;
        private int goodNumber;
        private int goodPrice;
        public OrderDetails(string NextGoodName,int NextGoodNumber, int NextGoodPrice)
        {
            this.goodName = NextGoodName;
            this.goodNumber = NextGoodNumber;
            this.goodPrice = NextGoodPrice;
        }
        public string NextGoodName
        {
            get { return goodName; }
        }
        public int NextGoodNumber
        {
            get { return goodNumber; }
        }
        public int NextGoodprice
        {
            get { return goodPrice; }
        }
        public class OrderService
        {
            public bool deserialize = false;
            //声明一个List
            public List<Order> orders = new List<Order>();
            //打印订单
            public void DispOrder()
            {
                foreach (Order TheOrder in orders)
                {
                    int i = TheOrder.NextorderDetails.Length;
                    Console.Write(TheOrder.NextOrderID + "   " + TheOrder.NextCilentName + "   "+ TheOrder.NextCilentTelephoneNumber + "   ");
                    for (int j = 0; i > j; j++)
                    {
                        Console.WriteLine(TheOrder.NextorderDetails[j].goodNumber + "   "
                            + TheOrder.NextorderDetails[j].goodName + "    "
                            + TheOrder.NextorderDetails[j].goodPrice);
                    }
                    Console.Write("\n");
                }
            }
            // 修改订单
            public bool ChangeOrder(string changeNumber, string orderNumber, string CilentTelephoneNumber, string clientName, OrderDetails[] orderDetails)
            {
                int ChangeNumber = int.Parse(changeNumber);
                bool exit1 = false;//判断是否有该订单号的订单
                foreach (Order TheOrder in orders)
                {
                    if (TheOrder.NextOrderID == changeNumber)
                    {
                        exit1 = true;
                        orders[ChangeNumber - 1] = new Order(orderNumber, clientName,CilentTelephoneNumber, orderDetails);
                        return true;
                    }
                }
                if (exit1 == false)
                {
                    throw new MyOrderException("输入格式不正确，请重新输入"
                        , "error401");

                }
                return false;
            }
            //删除订单
            public bool DeleteOrder(string orderID)
            {
                bool exit2 = false;
                foreach (Order TheOrders in orders)
                {
                    if (TheOrders.NextOrderID == orderID)
                    {
                        exit2 = true;
                        orders.Remove(TheOrders);
                        return true;
                    }
                    //
                }
                if (exit2 == false)
                {
                    throw new MyOrderException("输入格式不正确，请重新输入"
                        , "error402");
                }
                return false;
            }
            //订单号查询
            public bool CheckOrderID(string orderID)
            {

                var n = from TheOrder in orders
                        where TheOrder.NextOrderID == orderID
                        select TheOrder;
                Console.WriteLine("查询结果：");
                //
                foreach (Order TheOrder in n)
                {
                    int i = TheOrder.NextorderDetails.Length;
                    Console.Write(TheOrder.NextOrderID + "   " + TheOrder.NextCilentName + "   " + TheOrder.NextCilentTelephoneNumber + "   ");
                    for (int j = 0; i > j; j++)
                    {
                        Console.WriteLine(TheOrder.NextorderDetails[j].goodNumber + "   "
                            + TheOrder.NextorderDetails[j].goodName + "    "
                            + TheOrder.NextorderDetails[j].goodPrice);
                    }
                    Console.Write("\n");
                }
                return true;
            }
            //商品名查询
            public bool CheckGoodName(string goodName)
            {
                bool exit4 = false;
                foreach (Order TheOrder in orders)
                {
                    int orderDetailLength = TheOrder.NextorderDetails.Length;
                    for (int kk = 0; kk < orderDetailLength; kk++)
                    {
                        if (TheOrder.NextorderDetails[kk].goodName.Equals(goodName))
                        {
                            exit4 = true;
                            Console.Write(TheOrder.NextOrderID + "   " + TheOrder.NextCilentName + "   " + TheOrder.NextCilentName + "   ");
                            Console.WriteLine(TheOrder.NextorderDetails[kk].goodName + "   "
                                + TheOrder.NextorderDetails[kk].goodNumber + "   "
                                + TheOrder.NextorderDetails[kk].goodPrice);
                        }
                    }
                    return true;
                }
                if (exit4 == false)
                {
                    throw new MyOrderException("输入格式不正确，请重新输入"
                        , "error404");
                }
                return false;
            }
            //用户名查询
            public bool CheckClient(string clientName)
            {
                var n = from TheOrder in orders
                        where TheOrder.NextCilentName == clientName
                        select TheOrder;
                Console.WriteLine("查询结果：");
                //
                foreach (Order TheOrder in n)
                {
                    int i = TheOrder.NextorderDetails.Length;
                    Console.Write(TheOrder.NextOrderID + "   " + TheOrder.NextCilentName + "   " + TheOrder.NextCilentName + "   ");
                    for (int j = 0; i > j; j++)
                    {
                        Console.WriteLine(TheOrder.NextorderDetails[j].goodNumber + "   "
                            + TheOrder.NextorderDetails[j].goodName + "    "
                            + TheOrder.NextorderDetails[j].goodPrice);
                    }
                    Console.Write("\n");
                }
                return true;
            }

            //xml序列化
            public bool XmlSerializerExport(string xmlName, List<Order> orderss)
            {
                XmlSerializer xmlOrders = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(xmlName, FileMode.Create))
                {
                    //foreach(Order order in orderss)
                    //{
                    //    xmlOrders.Serialize(fs, order);
                    //}
                    xmlOrders.Serialize(fs, orderss);
                    return true;
                }

            }
            //反序列化
            public object Import(string name)
            {
                XmlSerializer xmlOrders = new XmlSerializer(typeof(List<Order>));
                FileStream fs = new FileStream(name, FileMode.Open);
                object obj = xmlOrders.Deserialize(fs);
                Console.WriteLine(obj);
                fs.Close();
                Console.WriteLine("Import done!!!");
                deserialize = true;
                return obj;
            }



            //异常处理
            public class MyOrderException : ApplicationException
            {
                private string information;
                public MyOrderException(string message, string information) : base(message)
                {
                    this.information = information;
                }
                public string getInformation()
                {
                    return information;
                }
            }

        }

        class GreatOrder
        {
            static void Main(string[] args)
            {
                OrderService orderService = new OrderService();
                OrderDetails[] orderDetail1 = { new OrderDetails("A", 5, 20)
                , new OrderDetails("B", 6, 6), new OrderDetails("C", 7, 8) };
                Order order1 = new Order("1", "aaa", "10086",orderDetail1);
                orderService.orders.Add(order1);
                orderService.DispOrder();
                Console.WriteLine("Add");
                OrderDetails[] orderDetail2 = { new OrderDetails("A", 5, 7)
                , new OrderDetails("B", 6, 5), new OrderDetails("C", 7, 6) };
                Order order2 = new Order("2", "aab", "10085",orderDetail2);
                orderService.orders.Add(order2);
                orderService.DispOrder();
                //Console.WriteLine("Add");
                ////
                //OrderDetails[] orderDetail2_1 = { new OrderDetails("A", 5, 9)
                //    , new OrderDetails("B", 6, 8), new OrderDetails("C", 7,1) };
                //Order order2_1 = new Order(5, "abb", orderDetail2_1);
                //orderService.orders.Add(order2_1);
                //orderService.DispOrder();

                ////
                //Console.WriteLine("修改订单，请输入订单号 ");
                //string c = Console.ReadLine();
                //int changeNumber = int.Parse(c);
                //OrderDetails[] orderDetail3 = { new OrderDetails("A", 50, 50),
                //new OrderDetails("C", 60, 60) };
                //orderService.ChangeOrder(changeNumber, 3, "aac", orderDetail3);
                //orderService.DispOrder();
                ////
                //Console.WriteLine("删除订单，请输入订单号 ");
                //string r = Console.ReadLine();
                //int removeNumber = int.Parse(r);
                //orderService.DeleteOrder(removeNumber);
                //orderService.DispOrder();
                ////
                //Console.WriteLine("订单号查找 ");
                //string dd = Console.ReadLine();
                //int findNumber = int.Parse(dd);
                //orderService.CheckOrderID(findNumber);
                ////Console.WriteLine("商品名查询: ");
                ////OrderService.CheckGoodName("A");
                //Console.WriteLine("客户名查询 ");
                //string ddd = Console.ReadLine();
                //orderService.CheckClient(ddd);


                //XMl序列化
                XmlSerializer xmlser = new XmlSerializer(typeof(Order[]));
                String xmlFileName = "xmlOrder.xml";
                orderService.XmlSerializerExport(xmlFileName, orderService.orders);

                object obj = orderService.Import(xmlFileName);
                //xml文本显示
                string xml = File.ReadAllText(xmlFileName);
                Console.WriteLine(xml);
            }
        }
    }
}