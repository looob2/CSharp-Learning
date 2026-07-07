int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
while (hour > 0 || minute > 0 || second > 0)
{
    hour--;

    if(hour < 0)
    {
        hour = 0;
    }

    if (second == 0)//当小时大于1时,分与秒两个为0的时候会无法通过while,故重置为60
    {
        second = 60;
    }

    if (minute == 0)
    { 
        minute = 60;
    }

    while (minute > 0 || second > 0)//分和秒只要同时为0时就会跳出
    {
        if (second == 0)
        {
            second = 60;
        }

        minute--;

        if (minute < 0)
        {
            minute = 59;
        }

        while (second > 0)
        {                      
            second--;

            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }   
}