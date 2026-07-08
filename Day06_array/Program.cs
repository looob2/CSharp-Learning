int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());
int [] array = new int[5] { a, b, c, d, e };
Console.WriteLine("\n你打输入的数组为:");
Console.Write($"{{{array[0]},");
Console.Write($"{array[1]},");
Console.Write($"{array[2]},");
Console.Write($"{array[3]},");
Console.Write($"{array[4]}}}");

Console.WriteLine("");

int n = array.Length;

int maxIndex = 0;

for (int j = maxIndex + 1; j < n; j++)
{


    if (array[j] > array[maxIndex])
    {
        maxIndex = j;
    }
}

if (array[0] != array[maxIndex])
{
    (array[0], array[maxIndex]) = (array[maxIndex], array[0]);
}

Console.WriteLine($"\n最大值为:{array[0]}");

float sum = 0;

for (int u = 0; u < n; u++)
{
    sum += array[u];//数组的每个数都会累加
}
float average = sum / n;//和直接除以数组长度
Console.WriteLine($"\n平均值为:{average}");

int p = 0;//初始偶数个数
for (int s = 0; s < n; s++)
{
    if (array[s] % 2 == 0)//检测偶数
    {
        p++;//每有偶数进入p都会+1
    }       
}
Console.WriteLine($"\n偶数的个数为:{p}");

