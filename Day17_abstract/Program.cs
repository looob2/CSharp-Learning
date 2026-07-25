using System.Security;

interface Iregister
{
    void register();
}
class Person : Iregister
{
    public void register()
    {
        Console.WriteLine("人已登记!");
    }
}
class Car : Iregister
{
    public void register()
    {
        Console.WriteLine("车已登记!");
    }
}
class Hourse : Iregister
{
    public void register()
    {
        Console.WriteLine("房已登记!");
    }
}

interface Ifly
{
    void fly();
}
interface Iwalk
{
    void walk();
}
interface Iswim
{
    void swim();
}
class Animal : Ifly , Iswim , Iwalk
{
    public void walk() { }
    public void fly() { }
    public void swim() { }
}
class sparrow : Animal
{
    public void fly() { }
    public void walk() { }
}
class swan : Animal
{
    public void fly() { }
    public void walk() { }
}
class parrot : Animal
{
    public void fly() { }
    public void walk() { }
}
class ostrich : Animal
{
    public void walk() { }
}
class Helicopter : Ifly
{
    public void fly() { }
}
