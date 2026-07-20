class Item
{
    
}
class Weapon : Item
{
    public Weapon(string name , int attack)
    {
        Name = name;
        Attack = attack;
    }
    public string Name { get; set; }
    public int Attack { get; set; }
}
class Potion : Item
{
    public Potion(string name , int addhp)
    {
        Name = name;
        AddHp = addhp;
    }
    public string Name { get; set; }
    public int AddHp { get; set; }
}
class Package
{
    private List<Item> items = new List<Item>();

    public void Add(Weapon weapon)
    {
        items.Add(weapon);
        Console.WriteLine($"添加武器{weapon.Name}!");
    }
    public void Add(Potion potion)
    {
        items.Add(potion);
        Console.WriteLine($"添加药水{potion.Name}!");
    }
    public void PackageInfo()
    {
        Console.WriteLine("背包信息");
        foreach (Item item in items)
        {
            if (item is Weapon weapon)
            {
                Console.WriteLine(weapon.Name);
            }
            else if (item is Potion potion)
            {
                Console.WriteLine(potion.Name);
            }
        }
    }
}
class Program
{
    public static void Main()
    {
        Package package = new Package();
        package.Add(new Weapon("木剑", 5));
        package.Add(new Potion("初级治疗药水" , 10));
        package.Add(new Potion("高级治疗药水", 50));
        package.Add(new Weapon("铁剑", 10));

        package.PackageInfo();
    }
}