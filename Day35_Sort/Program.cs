int[] array = new int[] {8, 4, 2, 7, 5, 1, 3, 6 };
//for (int i = 1; i < array.Length; i++)//从索引一的数(也就是第二个数)进行比较,因为默认第一个数在排序区中
//{
//    int sortIndex = i - 1;
//    int noSortNum = array[i];//未排序区的第一个数

//    while (sortIndex >= 0 && array[sortIndex] > noSortNum)//循环条件是要已排序区的最后一个数(也就是最大的数)大于未排序区的第一个数,还要排序区的索引大于等于零(也就是未排序区没有可比较的数的时候)
//    //这里sortIndex的判断必须要在前面,不然就会先执行array[sortIndex],就会因为索引不能为零报错
//    {
//        array[sortIndex + 1] = array[sortIndex];
//        --sortIndex;
//    }
//    array[sortIndex + 1] = noSortNum;
//}
//for (int i = 0; i < array.Length; i++)
//    Console.WriteLine(array[i]);

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