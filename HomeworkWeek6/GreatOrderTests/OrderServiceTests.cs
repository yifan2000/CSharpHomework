using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreatOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static GreatOrder.OrderDetails;


        

namespace GreatOrder.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
       

        [TestMethod()]
        public void CheckOrderIDTest()
        {
            OrderDetails[] orderDetail1 = { new OrderDetails("A", 5, 20)
                , new OrderDetails("B", 6, 6), new OrderDetails("C", 7, 8) };
            Order order1 = new Order(1, "aaa", orderDetail1);
            OrderDetails[] orderDetail2 = { new OrderDetails("A", 5, 7)
                , new OrderDetails("B", 6, 5), new OrderDetails("C", 7, 6) };
            Order order2 = new Order(2, "aab", orderDetail2);
            OrderService orderservice1 = new OrderService();
            OrderService orderservice2 = new OrderService();
            bool exist = orderservice1.CheckOrderID(1);
            Assert.AreEqual(exist, true);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderDetails[] orderDetail1 = { new OrderDetails("A", 5, 20)
                , new OrderDetails("B", 6, 6), new OrderDetails("C", 7, 8) };
            Order order1 = new Order(1, "aaa", orderDetail1);
            OrderDetails[] orderDetail2 = { new OrderDetails("A", 5, 7)
                , new OrderDetails("B", 6, 5), new OrderDetails("C", 7, 6) };
            Order order2 = new Order(2, "aab", orderDetail2);
            OrderService orderservice1 = new OrderService();
            OrderService orderservice2 = new OrderService();
            orderservice1.orders.Add(order1);
            orderservice1.orders.Add(order2);
            orderservice1.orders.Add(order1);
            orderservice1.orders.Add(order2);
            orderservice2.orders.Add(order2);
            orderservice1.DeleteOrder(1);
            Assert.AreEqual(orderservice1.orders[0].NextCilentName, orderservice2.orders[0].NextCilentName);
        }
        [TestMethod()]
        public void XmlSerializerExportTest()
        {
            OrderDetails[] orderDetail1 = { new OrderDetails("A", 5, 20)
                , new OrderDetails("B", 6, 6), new OrderDetails("C", 7, 8) };
            Order order1 = new Order(1, "aaa", orderDetail1);
            OrderDetails[] orderDetail2 = { new OrderDetails("A", 5, 7)
                , new OrderDetails("B", 6, 5), new OrderDetails("C", 7, 6) };
            Order order2 = new Order(2, "aab", orderDetail2);
            OrderService orderservice1 = new OrderService();
            orderservice1.orders.Add(order1);
            orderservice1.orders.Add(order2);
            string xmlFileName = "ordersXml.xml";
            bool success = orderservice1.XmlSerializerExport(xmlFileName, orderservice1.orders);
            Assert.AreEqual(success, true);
        }

        
        [TestMethod()]

        //反序列化（正确输入）

        public void ImportTestT()
        {
            OrderDetails[] orderDetail1 = { new OrderDetails("A", 5, 20)
                , new OrderDetails("B", 6, 6), new OrderDetails("C", 7, 8) };
            Order order1 = new Order(1, "aaa", orderDetail1);
            OrderDetails[] orderDetail2 = { new OrderDetails("A", 5, 7)
                , new OrderDetails("B", 6, 5), new OrderDetails("C", 7, 6) };
            Order order2 = new Order(2, "aab", orderDetail2);
            OrderService orderservice1 = new OrderService();
            orderservice1.orders.Add(order1);
            orderservice1.orders.Add(order2);
            string xmlFileName = "ordersXml.xml";
            orderservice1.XmlSerializerExport(xmlFileName, orderservice1.orders);
            object obj = orderservice1.Import(xmlFileName);
            Assert.AreEqual(orderservice1.deserialize, true);
        }
    }
}