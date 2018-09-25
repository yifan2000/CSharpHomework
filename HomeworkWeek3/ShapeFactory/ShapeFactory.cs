using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleOfTeachingMateial
{
    public abstract class Shape
    {
        private string myId;
        public Shape(string s)
        {
            Id = s;
        }
        public string Id
        {
            get
            {
                return myId;
            }
            set
            {
                myId = value;
            }
        }


        public abstract double Area//面积，抽象属性
        {
            get;
        }
        public virtual void Draw()//绘制，虚方法
        {
            Console.WriteLine("Draw Shape Icon");
        }
        public override string ToString()//覆盖object的虚方法
        {
            return Id + "Area=" + string.Format("{0:F2}", Area);
        }
    }


    //正方形
    public class Square : Shape
    {
        private int mySide;//边长
        public Square(int side, string id) : base(id)
        {
            mySide = side;
        }
        public override double Area//实现面积
        {
            get
            {
                return mySide * mySide;
            }
        }
        public override void Draw()//覆盖绘制方法
        {
            Console.WriteLine("Draw 4 side:" + mySide);
        }
    }

    //圆
    public class Circle : Shape
    {
        private float myRadius;//半径
        public Circle(float Radius, string id) : base(id)
        {
            myRadius = Radius;
        }
        public override double Area//实现面积
        {
            get
            {
                double s = myRadius * myRadius;
                double ss = s * 3.14;
                return ss;
            }
        }
        public override void Draw()//覆盖绘制方法
        {
          
            Console.WriteLine("Draw Circle:" + myRadius);
        }
    }

    //矩形
    public class Rectangle : Shape
    {
        private int myWidth;
        private int myHeight;
        public Rectangle(int width, int height, string id) : base(id)
        {
            myWidth = width;
            myHeight = height;
        }
        public override double Area//实现面积
        {
            get
            {
                return myWidth * myHeight;
            }
        }
        public override void Draw()//覆盖绘制方法
        {
            Console.WriteLine("Draw Rectangle:");
        }
    }

    //三角形
    public class Triangle : Shape
    {
        private int myWidth;
        private int myHeight;
        public Triangle(int width, int height, string id) : base(id)
        {
            myWidth = width;
            myHeight = height;
        }
        public override double Area
        {
            get
            {
                return myWidth * myHeight / 2;
            }
        }
        public override void Draw()//覆盖绘制方法
        {
            Console.WriteLine("Draw Triangle:" + myWidth + "*" + myHeight);
        }
    }

    //建立静态工厂方法 
    class FactoryShape
    {
        public static Shape getShape(String arg)
        {
            Shape shape = null;

            //方
            if (arg.Equals("Square"))
            {
                Console.Out.WriteLine("请输入正方形边长：");
                string myside = Console.In.ReadLine();
                int side = int.Parse(myside);
                shape = new Square(side, "Square");
            }

            //圆
            else if (arg.Equals("Circle"))
            {
                Console.Out.WriteLine("请输入半径：");
                string myside = Console.In.ReadLine();
                int radius = int.Parse(myside);
                shape = new Circle(radius, "Circle");
            }

            //矩
            else if (arg.Equals("Rectangle"))
            {
                Console.Out.WriteLine("请输入矩形长：");
                string bian = Console.In.ReadLine();
                int width = int.Parse(bian);
                Console.Out.WriteLine("输入矩形宽：");
                string kuan = Console.In.ReadLine();
                int height = int.Parse(kuan);
                shape = new Rectangle(width, height, "Rectangle");
            }

        //三角
            else if (arg.Equals("Triangle"))
            {
                Console.Out.WriteLine("请输入三角形底长：");
                string mywidth= Console.In.ReadLine();
                int width = int.Parse(mywidth);
                Console.Out.WriteLine("请输入三角形高：");
                string myheight = Console.In.ReadLine();
                int height = int.Parse(myheight);
                shape = new Triangle(width, height, "Rectangle");
            }
            return shape;
        }
    }

    //测试
    public class TestClass
    {
        public static void Main()
        {
            Shape shape1 = null;
            shape1 = FactoryShape.getShape("Square");
            shape1.Draw();
            System.Console.WriteLine(shape1);
            Shape shape2 = null;
            shape2 = FactoryShape.getShape("Circle");
            shape2.Draw();
            System.Console.WriteLine(shape2);
            Shape shape3 = null;
            shape3 = FactoryShape.getShape("Rectangle");
            shape3.Draw();
            System.Console.WriteLine(shape3);
            Shape shape4 = null;
            shape4 = FactoryShape.getShape("Triangle");
            shape4.Draw();
            System.Console.WriteLine(shape4);
        }
    }
}
