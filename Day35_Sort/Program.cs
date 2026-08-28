int[] array = new int[] {8, 4, 2, 7, 5, 1, 3, 6 };

//插入排序
for (int i = 1; i < array.Length; i++)//从索引一的数(也就是第二个数)进行比较,因为默认第一个数在排序区中
{
    int sortIndex = i - 1;
    int noSortNum = array[i];//未排序区的第一个数

    while (sortIndex >= 0 && array[sortIndex] > noSortNum)//循环条件是要已排序区的最后一个数(也就是最大的数)大于未排序区的第一个数,还要排序区的索引大于等于零(也就是未排序区没有可比较的数的时候)
    //这里sortIndex的判断必须要在前面,不然就会先执行array[sortIndex],就会因为索引不能为零报错
    {
        array[sortIndex + 1] = array[sortIndex];
        --sortIndex;
    }
    array[sortIndex + 1] = noSortNum;
}
for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

//希尔排序
for (int step = array.Length / 2; step > 0; step /= 2)//步长为数组长的一半,每次循环开始时都会/2,步长不能小于等于0,最小为1
{
    for (int i = step; i < array.Length; i++)//这里是非排序数的第一个数,所以从array[步长]开始
    {
        int sortIndex = i - step;//这里是与非排序对应的数,他们之间相差一个步长
        int noSortNum = array[i];
        while (sortIndex >= 0 && array[sortIndex] > noSortNum)
        {
            array[sortIndex + step] = array[sortIndex];
            sortIndex -= step;
        }
        array[sortIndex + step] = noSortNum;
    }
}
for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

//并归排序
static int[] Sort(int[] left , int[] right)//排序方法
{
    int[] array = new int[left.Length + right.Length];//创建一个排序后的新数组,数组长度为两数组之和
    int leftIndex = 0;
    int rightIndex = 0;//左右数组各自的索引
    for (int i = 0; i < array.Length; i++)//要放入新数组长度个数,所以 i < array.Length
    {
        //进入时先判断索引长度是否超出数组长度,不然会报错
        //若一方先比较完.则将另一个剩下的数一次放入新数组
        if (leftIndex >= left.Length)
        {
            array[i] = right[rightIndex];
            rightIndex++;
        }
        else if (rightIndex >= right.Length)
        {
            array[i] = left[leftIndex];
            leftIndex++;
        }
        //两数组进行比较,较小的数先放入新数组中,大的数继续参与比较
        else if (left[leftIndex] > right[rightIndex])
        {
            array[i] = right[rightIndex];
            rightIndex++;
        }
        else
        {
            array[i] = left[leftIndex];
            leftIndex++;
        }
    }
    return array;
}
static int[] Marge(int[] array)//将两个数组进行拆分
{
    if (array.Length < 2)//进行判断：数组长度是否为1，不能再进行拆分
        return array;
    int mid = array.Length / 2;
    int[] left = new int[mid];
    int[] right = new int[array.Length - mid];
    for (int i = 0; i < array.Length; i++)//开始为两个数组装载数据
    {
        if (i < mid)
            left[i] = array[i];
        else
            right[i - mid] = array[i];
    }
    return Sort(Marge(left), Marge(right));
}