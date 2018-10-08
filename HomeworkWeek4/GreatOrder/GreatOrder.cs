﻿using System;
//写一个订单管理的控制台程序，
//能够实现添加订单、删除订单、
//修改订单、查询订单（按照订单号、
//商品名称、客户等字段进行查询）功能。
//在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
//提示：需要写Order（订单）、OrderDetails（订单明细）
//，OrderService（订单服务）几个类，
//订单数据可以保存在OrderService中一个List中。


public class OrderDetails
{
    public int OrderNumber { get; set; }
    public string OrderBook { get; set; }
    public string Price { get; set; }
}

class GreatOrder
{
    static void Main(string[] args)
    {
    }
}

