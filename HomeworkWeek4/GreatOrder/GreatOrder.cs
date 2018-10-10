using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//写一个订单管理的控制台程序，
//能够实现添加订单、删除订单、
//修改订单、查询订单（按照订单号、
//商品名称、客户等字段进行查询）功能。
//在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
//提示：需要写Order（订单）、OrderDetails（订单明细）
//，OrderService（订单服务）几个类，
//订单数据可以保存在OrderService中一个List中。

//商品号，用户名，订单明细
class Order
{
    public int orderID;
    public string clientName;
    public OrderDetails[] orderDetails;
    public Order(int NextOrderID,string NextClientName, OrderDetails[] NextorderDetails)
    {
        this.orderID = NextOrderID;
        this.clientName = NextClientName;
        this.orderDetails = NextorderDetails;
    }
}
//所有商品、数量、单价
class OrderDetails
{
    public string goodName;
    public int goodNumber;
    public int goodPrice;
    public OrderDetails(string NextGoodName, int NextGoodNumber, int NextGoodPrice)
    {
        this.goodName = NextGoodName;
        this.goodNumber = NextGoodNumber;
        this.goodPrice = NextGoodPrice;
    }
}
class OrderService
{
    //声明一个List
    public static List<Order> orders = new List<Order>();
    //打印订单
    public static void DispOrder()
    {
        foreach (Order TheOrder in orders)
        {
            int i = TheOrder.orderDetails.Length;
            Console.Write(TheOrder.orderID + "   " + TheOrder.clientName + "   ");
            for (int j = 0; i > j; j++)
            {
                Console.WriteLine(TheOrder.orderDetails[j].goodNumber + "   "
                    + TheOrder.orderDetails[j].goodName + "    "
                    + TheOrder.orderDetails[j].goodPrice);
            }
            Console.Write("\n");
        }
    }
    // 修改订单
    public static void ChangeOrder(int changeNumber, int orderNumber, string clientName, OrderDetails[] orderDetails)
    {
        bool exit1 = false;//判断是否有该订单号的订单
        foreach (Order TheOrder in orders)
        {
            if (TheOrder.orderID == changeNumber)
            {
                exit1 = true;
                orders[changeNumber - 1] = new Order(orderNumber, clientName, orderDetails);
                break;
            }
        }
        if (exit1 == false)
        {
            throw new MyOrderException("输入格式不正确，请重新输入"
                , "error401");
        }
    }
    //删除订单
    public static void DeleteOrder(int orderID)
    {
        bool exit2 = false;
        foreach (Order TheOrders in orders)
        {
            if (TheOrders.orderID == orderID)
            {
                exit2 = true;
                orders.Remove(TheOrders);
                break;
            }
            //
        }
        if (exit2 == false)
        {
            throw new MyOrderException("输入格式不正确，请重新输入"
                , "error402");
        }
    }
    //订单号查询
    public static void CheckOrderID(int orderID)
    {
        bool exit3 = false;
        foreach (Order TheOrder in orders)
        {
            if (TheOrder.orderID == orderID)
            {
                exit3 = true;
                int orderDetailLength = TheOrder.orderDetails.Length;
                Console.Write(TheOrder.orderID + "   " + TheOrder.clientName);
                for (int jj = 0; jj < orderDetailLength; jj++)
                {
                    Console.WriteLine(TheOrder.orderDetails[jj].goodName + "   "
                        + TheOrder.orderDetails[jj].goodNumber + "   "
                        + TheOrder.orderDetails[jj].goodPrice);
                }
                break;
            }
        }
        if (exit3 == false)
        {
            throw new MyOrderException("输入格式不正确，请重新输入"
                , "error403");
        }
    }
    //商品名查询
    public static void CheckGoodName(string goodName)
    {
        bool exit4 = false;
        foreach (Order TheOrder in orders)
        {
            int orderDetailLength = TheOrder.orderDetails.Length;
            for (int kk = 0; kk < orderDetailLength; kk++)
            {
                if (TheOrder.orderDetails[kk].goodName.Equals(goodName))
                {
                    exit4 = true;
                    Console.Write(TheOrder.orderID + "   " + TheOrder.clientName + "   ");
                    Console.WriteLine(TheOrder.orderDetails[kk].goodName + "   "
                        + TheOrder.orderDetails[kk].goodNumber + "   "
                        + TheOrder.orderDetails[kk].goodPrice);
                }
            }
        }
        if (exit4 == false)
        {
            throw new MyOrderException("输入格式不正确，请重新输入"
                , "error404");
        }
    }
    //用户名查询
    public static void CheckClient(string clientName)
    {
        bool exit5 = false;
        foreach (Order TheOrder in orders)
        {
            if (TheOrder.clientName.Equals(clientName))
            {
                exit5 = true;
                int orderDetailLength = TheOrder.orderDetails.Length;
                Console.Write(TheOrder.orderID + "   " + TheOrder.clientName);
                for (int jj = 0; jj < orderDetailLength; jj++)
                {
                    Console.WriteLine(TheOrder.orderDetails[jj].goodName + "   "
                        + TheOrder.orderDetails[jj].goodNumber + "   "
                        + TheOrder.orderDetails[jj].goodPrice);
                }
                break;
            }
        }
        if (exit5 == false)
        {
            throw new MyOrderException("输入格式不正确，请重新输入"
                , "error405");
        }
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
        OrderDetails[] orderDetail1 = { new OrderDetails("A", 5, 20)
                , new OrderDetails("B", 6, 6), new OrderDetails("C", 7, 8) };
        Order order1 = new Order(1, "aaa", orderDetail1);
        OrderService.orders.Add(order1);
        OrderService.DispOrder();
        Console.WriteLine("Add");
        OrderDetails[] orderDetail2 = { new OrderDetails("A", 5, 7)
                , new OrderDetails("B", 6, 5), new OrderDetails("C", 7, 6) };
        Order order2 = new Order(2, "aab", orderDetail2);
        OrderService.orders.Add(order2);
        OrderService.DispOrder();
        Console.WriteLine("Add");
        //
        Console.WriteLine("修改订单，请输入订单号 ");
        string c = Console.ReadLine();
        int changeNumber = int.Parse(c);
        OrderDetails[] orderDetail3 = { new OrderDetails("A", 50, 50),
            new OrderDetails("C", 60, 60) };
        OrderService.ChangeOrder(changeNumber, 3, "aac", orderDetail3);
        OrderService.DispOrder();
        //
        Console.WriteLine("删除订单，请输入订单号 ");
        string r = Console.ReadLine();
        int removeNumber = int.Parse(r);
        OrderService.DeleteOrder(removeNumber);
        OrderService.DispOrder();
        //
        Console.WriteLine("订单号查找 ");
        string dd = Console.ReadLine();
        int findNumber = int.Parse(dd);
        OrderService.CheckOrderID(findNumber);
        Console.WriteLine("商品名查询: ");
        OrderService.CheckGoodName("A");
        Console.WriteLine("客户名查询 ");
        string ddd = Console.ReadLine();
        OrderService.CheckClient(ddd);
        Console.Write("Done!!!");



    }
}

