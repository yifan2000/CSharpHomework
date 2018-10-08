using System;

//声明参数类型
public class TimeEventArgs : EventArgs
{
    public int Hour { set; get; }
    public int Minute { set; get; }
    public int CurrentHour { set; get; }
    public int CurrentMinute { set; get; }
    public bool IfTimeIslegal { set; get; }
    public bool ClockRing { set; get; }
}
//声明委托类型
public delegate void AlarmEventHandler(object sender, TimeEventArgs e);

//定义事件源
public class AlarmClock
{
    public event AlarmEventHandler TheClock;

    public void Clockk(int hour, int minute)
    {
        TimeEventArgs Current = new TimeEventArgs();
        Current.Hour = hour;
        Current.Minute = minute;
        while (!Current.ClockRing)
        {
            TheClock(this, Current);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        AlarmClock clock = new AlarmClock();
        clock.TheClock += GetTime;
        clock.TheClock += CompareTime;
        clock.TheClock += CompareTime2;
        int h, m;
        Console.WriteLine("请依次输入设定闹钟的时和分（闹钟时间只能设置为今天内）：");
        //设置时间
        Console.Write("时：");
        h = Int32.Parse(Console.ReadLine());
        Console.Write("分：");
        m = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"已成功设定闹钟时间为 " + h + ":" + m);
        clock.Clockk(h, m);
        Console.WriteLine("现在是" + h + ":" + m + "  ringringring");
        Console.ReadKey();

    }
    static void GetTime(object sender, TimeEventArgs e)//取得当前时间
    {
        e.CurrentHour = Int32.Parse(DateTime.Now.Hour.ToString());
        e.CurrentMinute = Int32.Parse(DateTime.Now.Minute.ToString());
    }
    static void CompareTime(object sender, TimeEventArgs e)  //输入时间是否合法    
    {
        if (e.Hour > e.CurrentHour)
            if (e.Minute > e.CurrentMinute)
                e.IfTimeIslegal = true;
    }
    static void CompareTime2(object sender, TimeEventArgs e)   //时间是否到了  
    {
        if (e.Hour == e.CurrentHour && e.Minute == e.CurrentMinute) e.ClockRing = true;
    }
}

