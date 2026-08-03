void Reverse(char[] chars)
{
    int left = 0;
    int right = chars.Length - 1;
    while(left < right)
    {
        char temp = chars[left];
        chars[left] = chars[right];
        chars[right] = temp;
        left++;
        right--;
    }
}

string str = "1|2|3|4|5|6|7";
str = str.Remove(0 , 2);//移除掉前两个字符,也可以截取，如:str,Substring(2)
str += "|8";//添加字符
string[] strs = str.Split('|');//切割字符串
foreach (string s in strs)
{
    Console.WriteLine(s);
}
string? str1 = Console.ReadLine();
char[] chars = str.ToCharArray();
Reverse(chars);