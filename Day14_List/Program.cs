using System.ComponentModel;

class Person
{
    public Person (string name , int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    public static void Main()
    {
        List<Person> people = new List<Person>();//创建List,存放Person类

        Person p1 = new Person("张三" , 18);
        people.Add(p1);//先创建后添加

        people.Add(new Person("李四", 20));//也可以在添加的同时创建

        Console.WriteLine(people[0].Name + "," + people[0].Age);
        Console.WriteLine(people[1].Name + "," + people[1].Age);

        p1 = new Person("王五" , 22);//创建了一个新对象,不会改变先前存入people的数据

        Console.WriteLine(people[0].Name + "," + people[0].Age);
    }
}
