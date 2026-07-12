class Program
{   
    public static int Divide(int a , int b , out int remainder)//out不需要初始值,可以先定义再运算余数结果
    {
        remainder = a % b;//计算余数,由于out没有初始值,所以进来后必须赋值
        return a / b;//返回相除结果
    }
    public static int Add(params int[] nums)//params可以将输入的多个数自动排为数组
    {
        int sum = 0;
        foreach (int n in nums)
        {
            sum += n;
        }
        return sum;
    }
    static void Main()
    {
        //创建一个Person类型的数组persons
        Person[] persons =
        {
        new Person() {Age = 10},
        new Person() {Age = 20},
        new Person() {Age = 30}
        };

        foreach (Person p in persons)//遍历,将数组中每个Age都加五
        {
            p.Age += 5;
        }

        for (int i = 0; i < persons.Length; i++)//从第0位开始打印数组persons中的每一个Age
        {
            Console.WriteLine(persons[i].Age);
        }

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());//输入a与b
        Console.WriteLine(Divide(a, b, out int remainder));//打印相除结果
        Console.WriteLine(remainder);//打印余数
    }
}
class Person
{
    public int Age;
}