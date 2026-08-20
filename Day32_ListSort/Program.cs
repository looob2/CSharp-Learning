using System.Threading;

List<Monster> list = new()
{
    new Monster(5,5,10,"史莱姆"), new Monster(6, 10, 15, "石质史莱姆"), new Monster(10, 15, 25, "铁史莱姆"),
    new Monster(10,10,5,"骷髅"), new Monster(15,7,10,"精英骷髅"), new Monster(12,10,30,"僵尸"),
    new Monster(25,21,40,"精英僵尸"), new Monster(2,3,6,"野猪"), new Monster(7,5,3,"狼"),
    new Monster(34,47,50,"海怪")
};
foreach (Monster monster in list)
{
    Console.WriteLine("{0} ATK:{1} HP:{2} DEF:{3}", monster.name, monster.attack, monster.hp, monster.defence);
}
Console.WriteLine("\n请选择排序方式:\n1.攻击排序\n2.血量排序\n3.防御排序");
string? input = Console.ReadLine();
if (int.TryParse(input, out int i) && i < 4 && i > 0)
{
    switch (i)
    {
        case 1:
            list.Sort((a, b) => { return a.attack - b.attack; });
            break;
        case 2:
            list.Sort((a, b) => { return a.hp - b.hp; });
            break;
        case 3:
            list.Sort((a, b) => { return a.defence - b.defence; });
            break;
    }
    Console.WriteLine("\n选择正序排序或者倒序排序:\n1.正序 2.倒序");
    string? _input = Console.ReadLine();
    if (int.TryParse(_input, out int _i) && _i < 3 && _i > 0)
    {
        switch (_i)
        {
            case 1:
                foreach (Monster monster in list)
                {
                    Console.WriteLine("{0} ATK:{1} HP:{2} DEF:{3}", monster.name, monster.attack, monster.hp, monster.defence);
                }
                break;
            case 2:
                for (int n = list.Count - 1; n >= 0; n--)
                {
                    Console.WriteLine("{0} ATK:{1} HP:{2} DEF:{3}", list[n].name, list[n].attack, list[n].hp, list[n].defence);
                }
                break;
        }
    }
    else
    {
        Console.WriteLine("非法操作");
    }
}
else
{
    Console.WriteLine("非法操作");
}

Console.WriteLine();

List<Item> items = new()
{
    new Item("工具", 2, "十字镐", "普通", 1), new Item("工具", 2, "斧子", "普通", 1), new Item("工具", 2, "金锄头", "优良", 2),
    new Item("杂物", 1, "种子袋", "普通", 1), new Item("杂物", 1, "小麦种子", "普通", 1), new Item("装备", 3, "皮质靴子", "普通", 1),
    new Item("装备", 3, "铁质靴子", "优良", 2), new Item("装备", 3, "钻石胸甲", "史诗", 3), new Item("武器", 4, "钻石阔剑", "史诗", 3),
    new Item("武器", 4, "破坏剑", "传说", 4)
};
items.Sort((a, b) =>
{
    int result = a.typeWeight - b.typeWeight;
    if (result == 0)
    {
        result = a.qualityWeight - b.qualityWeight;
    }
    if (result == 0)
    {
        result = a.name.Length - b.name.Length;
    }
    return result;
});
foreach (Item item in items)
{
    Console.WriteLine("[{0}] {1}     \t类型:{2}", item.quality, item.name, item.type);
}

Console.WriteLine();

Dictionary<int, string> dictionary = new() 
{
    {7, "Sunday"}, {1, "Monday"}, {3, "Wednesday"}, {6, "Saturday"},
    {2 , "Tuesday"}, {5 , "Friday"}, {4 , "Thursday"}
};
List<int> keyList = new();
foreach (int key in dictionary.Keys)
{
    keyList.Add(key);
}
keyList.Sort((a,b) => { return a - b; });
foreach (int key in keyList)
{
    Console.WriteLine(dictionary[key]);
}

class Monster
{
    public int attack;
    public int defence;
    public int hp;
    public string name;

    public Monster(int attack, int defence, int hp, string name)
    {
        this.attack = attack;
        this.defence = defence;
        this.hp = hp;
        this.name = name;
    }
}

class Item
{
    public string type;
    public string name;
    public string quality;
    public int typeWeight;
    public int qualityWeight;

    public Item(string type, int typeWeight, string name, string quality, int qualityWeight)
    {
        this.type = type;
        this.name = name;
        this.quality = quality;
        this.typeWeight = typeWeight;
        this.qualityWeight = qualityWeight;
    }
}