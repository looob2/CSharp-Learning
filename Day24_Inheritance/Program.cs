class Worker
{
    public Worker(string duties , string type)
    {
        Duties = duties;
        Type = type;
    }

    public string Duties {  get; set; }
    public string Type {  get; set; }

    public virtual void Work()
    {
        Console.WriteLine($"{Type}在做{Duties}");
    }
}
class Programmer : Worker
{
    public Programmer(string duties , string type) : base(duties , type) { }
}
class Planner : Worker
{
    public Planner(string duties, string type) : base(duties , type) { }
}
class Artist : Worker
{
    public Artist(string duties, string type) : base (duties , type) { }
}

class Duck
{
    public virtual void Speak()
    {
        Console.WriteLine("嘎嘎");
    }
}
class WoodenDuck : Duck
{
    public override void Speak()
    {
        Console.WriteLine("吱吱");
    }
}
class RubberyDuck : Duck
{
    public override void Speak()
    {
        Console.WriteLine("唧唧");
    }
}

class Employee
{
    public virtual void ClockIn()
    {
        Console.WriteLine("9点打卡成功");
    }
}
class Manager : Employee
{
    public override void ClockIn()
    {
        Console.WriteLine("11点打卡成功");
    }
}
class Employee_Programmer : Employee
{
    public override void ClockIn()
    {
        Console.WriteLine("无需打卡");
    }
}

//class Geometricshapes
//{
//    public virtual double Area()
//    {
//        return 0;
//    }
//    public virtual double Perimeter()
//    {
//        return 0;
//    }
//}
//class Rectangle : Geometricshapes 
//{
//    private double h { get; set; }
//    private double l { get; set; }

//    public Rectangle(double h , double l)
//    {
//        this.h = h;
//        this.l = l;
//    }

//    public override double Area()
//    {              
//        return h * l;
//    }
//    public override double Perimeter()
//    {
//        return 2 * (h + l);
//    }
//}
//class Circle : Geometricshapes
//{
//    private double r { get; set; }

//    public Circle(double r)
//    {
//        this.r = r;
//    }

//    public override double Area()
//    {
//        return Math.PI * r * r;
//    }
//    public override double Perimeter()
//    {
//        return 2 * Math.PI * r;
//    }
//}
//class Square : Geometricshapes 
//{
//    private double l {get; set;}

//    public Square(double l)
//    {
//        this.l = l;
//    }

//    public override double Area()
//    {
//        return l * l;
//    }
//    public override double Perimeter()
//    {
//        return 4 * l;
//    }
//}

abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}
class Rectangle : Shape
{
    private double h {  get; set; }
    private double l { get; set; }
    public Rectangle(double h, double l)
    {
        this.l = l;
        this.h = h;
    }
    public override double Perimeter()
    {
        return 2 * (h + l);
    }
    public override double Area()
    {
        return h * l;
    }
}

class Program
{
    static void Main()
    {
        Duck duck = new RubberyDuck();
        duck.Speak();

        //Geometricshapes rectangle = new Rectangle(3 , 2);
        //Console.WriteLine(rectangle.Area());
        //Console.WriteLine(rectangle.Perimeter());

        //Geometricshapes circle = new Circle(3);
        //Console.WriteLine($"{circle.Area():F2}");
        //Console.WriteLine($"{circle.Perimeter():F2}");

        //Geometricshapes square = new Square(3);
        //Console.WriteLine(square.Area());
        //Console.WriteLine(square.Perimeter());
    }
}