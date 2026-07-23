Dictionary<int, string> number = new Dictionary<int, string>()
{
    {1, "壹" },{2, "贰" },{3, "叁" },{4, "肆" },{5, "伍" },
    {6, "陆" },{7, "柒" },{8, "捌" },{9, "玖" },{0, "零" }
};
while (true)
{
    Console.WriteLine("输入一个不大于三位的数字");
    int input = int.Parse(Console.ReadLine());
    if (input > 999 || input < 0)
    {
        Console.WriteLine("\n输入的数字不符合要求!\n");
        continue;
    }
    int hundred = input / 100;//百位提取
    int n = input % 100;//十位和百位提取
    int ten = n / 10;//十位提取
    int one = n % 10;//个位提取
    Console.WriteLine($"百位:{hundred},十位:{ten},个位{one}");
    if (hundred == 0 && ten != 0)//若为两位
    {
        Console.WriteLine(number[ten] + number[one]);
    }
    else if (hundred == 0 && ten == 0)//若为个位
    {
        Console.WriteLine(number[one]);
    }
    else//若为三位
    {
        Console.WriteLine(number[hundred] + number[ten] + number[one]);
    }
    break;
}
