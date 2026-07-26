using System.Security;

interface Iregister//注册接口
{
    void register();
}
class Person : Iregister
{
    public void register() { }
}
class Car : Iregister
{
    public void register() { }
}
class Hourse : Iregister
{
    public void register() { }
}

interface Ifly//飞
{
    void fly();
}
interface Iwalk//走
{
    void walk();
}
interface Iswim//游
{
    void swim();
}
class Animal
{

}
class Sparrow : Animal ,Ifly , Iwalk
{
    public void fly() { }
    public void walk() { }
}
class Swan : Animal ,Ifly , Iwalk , Iswim
{
    public void fly() { }
    public void walk() { }
    public void swim() { }
}
class Parrot : Animal, Ifly, Iwalk
{
    public void fly() { }
    public void walk() { }
}
class Ostrich : Animal , Iwalk
{
    public void walk() { }
}
class Penguin : Animal , Iswim , Iwalk
{
    public void walk() { }
    public void swim() { }
}
class Helicopter : Ifly
{
    public void fly() { }
}

interface IUSB
{
    void transfer();
}
class MP3 : IUSB
{
    public void transfer() 
    {
        Console.WriteLine("MP3传输数据");
    }
}
class SSD : IUSB
{
    public void transfer()
    {
        Console.WriteLine("移动硬盘传输数据");
    }
}
class UDisk : IUSB
{
    public void transfer()
    {
        Console.WriteLine("U盘传输数据");
    }
}
class Computer
{
    public void Read (IUSB usb)
    {
        usb.transfer();
    }
}