using System.Collections;
using System.Diagnostics;
//ArrayList
class Goods
{
    public Goods(string name , int price , int number)
    {
        Name = name;
        Price = price;
        Number = number;
    }

    public string Name { get; }
    public int Price { get; }
    public int Number { get; set; }
}
class Store
{
    ArrayList shelf = new ArrayList();

    public void ToStock(Goods goods)
    {
        shelf.Add(goods);
    }
    public void ShowInfo(Package package)
    {
        Console.WriteLine("=================\n商   店   界   面\n=================");
        int i = 1;
        foreach(Goods goods in shelf)
        {
            Console.WriteLine($"{i}.{goods.Name} 单个价格:{goods.Price} 剩余数量:{goods.Number}");
            i++;
        }
        Console.Write("\n请输入要购买物品的序号:");
        string? input = Console.ReadLine();
        if(int.TryParse(input , out int p))
        {
            while (true)
            {
                Console.Write("\n请输入购买数量:");
                string? input_num = Console.ReadLine();
                if (int.TryParse(input_num, out int n) && n > 0)//数量必须为int,必须大于0
                {
                    Goods goods = shelf[p - 1] as Goods;
                    if (n > goods.Number)//检测是否超出货物本身的数量
                    {
                        n = goods.Number;
                    }                    
                    if (package.icon >= goods.Price * n)//若钱够
                    {
                        package.icon -= goods.Price * n;//扣钱
                        Console.WriteLine("交易成功!剩余金额:" + package.icon);
                        goods.Number -= n;//数量扣除                       
                        Goods newgoods = new Goods(goods.Name, goods.Price, n);
                        package.Save(newgoods);//添加至背包
                        if (goods.Number == 0)//如果为0则移除
                        {
                            shelf.RemoveAt(p - 1);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("金额不足!");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("请输入正确的数字!");
                }
            }
        }
        else
        {
            Console.WriteLine("请输入正确的序号");
            return;
        }
    }
}
class Package
{
    ArrayList package = new ArrayList();
    public int icon { get; set; } = 100;

    public void Save(Goods goods)
    {
        package.Add(goods);
    }
    public void ShowInfo()
    {
        Console.WriteLine("==============\n背  包  界  面\n==============");
        int i = 1;
        foreach (Goods goods in package)
        {
            Console.WriteLine($"{i}.{goods.Name} 数量:{goods.Number}");
            i++;
        }
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int inpt) && inpt > 0 && inpt <= package.Count)
        {
            Goods goods = package[inpt - 1] as Goods;
            Console.WriteLine($"===========\n物 品 信 息\n===========\n{goods.Name}*{goods.Number}\n出售价格:{goods.Price}\n1.出售 2.返回");
            string? input_choose = Console.ReadLine();
            if (int.TryParse(input_choose , out int c) && c < 3)
            {
                switch (c)
                {
                    case 1:
                        Console.Write("请输入要卖出的数量:");
                        string? input_trade = Console.ReadLine();
                        if (int.TryParse(input_trade , out int t))
                        {
                            if (t > goods.Number)//若超出数量调至最大值
                            {
                                t = goods.Number;
                            }
                            icon += goods.Price * t;//加钱
                            Console.WriteLine("出售成功!目前金币:" + icon);
                            goods.Number -= t;//减少数量
                            if (goods.Number == 0)//为0则移除出背包
                            {
                                package.RemoveAt(inpt - 1);
                            }                           
                        }
                        else
                        {
                            Console.WriteLine("请输入正确的格式!");
                        }
                        break;
                    case 2:
                        break;
                }
            }
            else
            {
                Console.WriteLine("请输入正确的格式!");
                return;
            }
        }
        else
        {
            Console.WriteLine("请输入正确的格式!");
            return;
        }
    }
}

class Program
{
    static void Main()
    {
        //ArrayList array = new ArrayList();

        //array.Add(0);//增
        //ArrayList array2 = new ArrayList();
        //array2.Add(1);
        //array.Add(array2);
        //array.Insert(1, 13);//在指定位置插入一个元素

        //array.Remove(0);//删除指定元素
        //array.RemoveAt(0);//删除指定位置的元素
        //array.Clear();//清空

        //array.Add(12);
        //array.Add(15);
        //array.Add(42);

        //Console.WriteLine(array[0]);//查
        //Console.WriteLine(array.Contains(12));//判断元素是否存在
        //Console.WriteLine(array.IndexOf(12));//正向查找元素位置
        //Console.WriteLine(array.LastIndexOf(42));//反向查找元素位置

        //array[0] = 13;//改

        Store s = new Store();
        Package p = new Package();
        s.ToStock(new Goods("血量药水" , 50 , 5));
        s.ToStock(new Goods("史莱姆凝胶", 5, 10));
        s.ToStock(new Goods("火把", 10, 999));
        s.ToStock(new Goods("木头", 5, 999));
        p.Save(new Goods("史莱姆凝胶", 5, 10));
        p.Save(new Goods("火把", 10, 9));
        p.Save(new Goods("血量药水", 50, 3));

        while (true)
        {
            s.ShowInfo(p);
            //p.ShowInfo();
        }
        
        
    }
}

