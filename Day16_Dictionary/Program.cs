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
Console.WriteLine();

Dictionary<char, string> dictionary = new Dictionary<char, string>()
{
    {'1', "壹" },{'2', "贰" },{'3', "叁" },{'4', "肆" },{'5', "伍" },
    {'6', "陆" },{'7', "柒" },{'8', "捌" },{'9', "玖" },{'0', "零" }
};
while (true)
{
    Console.Write("请输入不超过三位的数字:");
    string? input = Console.ReadLine();//输入字符串
    Console.WriteLine();

    if (input.Length > 3)//判断格式是否正确
    {
        Console.WriteLine("输入的格式不正确!\n");
        continue;
    }

    bool shouldSkip = false;

    foreach (char c in input)//遍历字符串中的每一个字符并打印出来
    {
        if (!dictionary.ContainsKey(c))
        {
            shouldSkip = true;
            Console.WriteLine("输入的格式不正确!\n");
            break;
        }        
        Console.Write(dictionary[c]);
    }

    if (shouldSkip)
    {
        continue;
    }

    break;
}

Console.WriteLine();

Dictionary <char , int> word = new Dictionary<char , int>();
while (true)
{
    Console.Write("\n请输入一段话:");
    string? input = Console.ReadLine();//输入字符串
    input = input.ToLower();//全部转化为小写字母

    foreach (char c in input)//遍历输入字符串中的每一个字符
    {
        if (c == ' ')//跳过空格,不算入计数中
        {
            continue;
        }
        if(word.TryGetValue(c, out int value))//是否有值
        {
            word[c]++;//有则自增
        }
        else
        {
            word.Add(c,1);//没有则创建一个,出现过一次所以为1          
        }
    }

    foreach (var item in word)//遍历数组打印结果
    {
        Console.WriteLine($"{item.Key}出现了{item.Value}次");
    }

    break;
}