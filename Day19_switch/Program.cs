Console.WriteLine("输入评价:");
string estimate = Console.ReadLine();
int salary = 4000;
char grade = 'E';
switch (estimate)
{
    case "很兴奋":
        grade = 'A';
        salary += 500;
        break;
    case "很充实":
        grade = 'B';
        break;
    case "还好吧":
        grade = 'C';
        salary -= 300;
        break;
    case "难理解":
        grade = 'D';
        salary -= 500;
        break;
    case "枯燥乏味":
        grade = 'E';
        salary -= 800;
        break;
}
Console.WriteLine($"评定为{grade}级,工资{salary}");

bool Switch = true;
int money = 10;
while (Switch)
{
    Console.WriteLine("请输入型号");
    string userinput = Console.ReadLine();//输入型号
    switch (userinput)
    {
        case "1":
            if (money < 5)
            {
                Console.WriteLine("钱不够,请换其它型号");
                continue;
            }
            money -= 5;
            Console.WriteLine($"小王还剩{money}元");
            Switch = false;
            break;
        case "2":
            if (money < 7)
            {
                Console.WriteLine("钱不够,请换其它型号");
                continue;
            }
            money -= 7;
            Console.WriteLine($"小王还剩{money}元");
            Switch = false;
            break;
        case "3":
            if (money < 11)
            {
                Console.WriteLine("钱不够,请换其它型号");
                continue;
            }
            money -= 11;
            Console.WriteLine($"小王还剩{money}元");
            Switch = false;
            break;
        default:
            Console.WriteLine("没有这个型号");
            break;
    }
}

Console.WriteLine("请输入成绩");
char c = 'E';
string input = Console.ReadLine();
if (int.TryParse(input, out int score) && score >= 0 && score < 101)
{
    if (score >= 90)
    {
        c = 'A';
    }
    else if (score >= 80 && score < 90)
    {
        c = 'B';
    }
    else if (score >= 70 && score < 80)
    {
        c = 'C';
    }
    else if (score >= 60 && score < 70)
    {
        c = 'D';
    }
}
else
{
    Console.WriteLine("输入的格式不合规");
}
switch (c)
{
    case 'A':
    case 'B':
    case 'C':
    case 'D':
    case 'E':
        Console.WriteLine("成绩等级为" + c);
        break;
}
//switch (score / 10)
//{
//    case 10:
//    case 9:
//        Console.WriteLine("A");
//        break;
//    case 8:
//        Console.WriteLine("B");
//        break;
//    case 7:
//        Console.WriteLine("C");
//        break;
//    case 6:
//        Console.WriteLine("D");
//        break;
//    default:
//        Console.WriteLine("E");
//        break;
//}


Console.WriteLine("输入0-9的数字");
string n = Console.ReadLine();
if (int.TryParse(n , out int number) && number >= 0 && number < 10)
{
    switch (number)
    {
        case 0:
            Console.WriteLine(Upper.零);
            break;
        case 1:
            Console.WriteLine(Upper.一);
            break;
        case 2:
            Console.WriteLine(Upper.二);
            break;
        case 3:
            Console.WriteLine(Upper.三);
            break;
        case 4:
            Console.WriteLine(Upper.四);
            break;
        case 5:
            Console.WriteLine(Upper.五);
            break;
        case 6:
            Console.WriteLine(Upper.六);
            break;
        case 7:
            Console.WriteLine(Upper.七);
            break;
        case 8:
            Console.WriteLine(Upper.八);
            break;
        case 9:
            Console.WriteLine(Upper.九);
            break;
    }
}
else
{
    Console.WriteLine("请输入0`9的数字");
}
enum Upper 
{ 
    零 , 一 , 二 , 三 , 四 , 五 , 六 , 七 , 八 , 九
}