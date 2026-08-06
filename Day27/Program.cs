using System.Collections;

//Hashtable
static class MonsterManager
{
    static Hashtable hashtable = new Hashtable();

    public static void CreateMonter(string id , string name)//创建怪物
    {
        if ( !hashtable.ContainsKey(id))//创建时先检测键是否存在,不然会报错
        {
            hashtable.Add(id, name);
        }        
    }
    public static void RemoveMonster(string id)//移除怪物
    {
        hashtable.Remove(id);
    }
}

class Program
{
    static void Main()
    {
        //Stack stack = new Stack();

        ////增(压栈)
        //stack.Push(1);
        //stack.Push("123");
        //stack.Push(true);
        //stack.Push(1.2f);

        ////取(弹栈)后进的先弹出
        //Object o = stack.Pop();
        //Console.WriteLine(o);

        ////查
        //Console.WriteLine(stack.Peek());//只能查看栈最上面的
        //Console.WriteLine(stack.Peek());

        //Console.WriteLine(stack.Contains(1));//可以查看指定参数是否在栈内
        //Console.WriteLine(stack.Contains("2"));

        ////清空
        //stack.Clear();

        //stack.Push(1);
        //stack.Push("123");
        //stack.Push(true);
        //stack.Push(1.2f);
        ////遍历
        //foreach (Object obj in stack)//从顶向底打印
        //{
        //    Console.WriteLine(obj);
        //}

        //Object[] objects = stack.ToArray();//也可以将stack转化为Object数组打印
        //for (int i = 0; i < objects.Length; i++)
        //{
        //    Console.WriteLine(objects[i]);//也是从顶部向下打印的
        //}

        //while(stack.Count > 0)//循环弹栈
        //{
        //    Object obj = stack.Pop();
        //    Console.WriteLine(obj);//打印完就弹出
        //}

        Stack stack = new Stack();
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int i))
        {
            if (i == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (i != 0)
            {
                stack.Push(i % 2);
                i /= 2;
            }
            foreach (Object o in stack)
            {
                Console.Write(o);
            }
        }
        else
        {
            return;
        }

        Console.WriteLine();

        //Queue queue = new Queue();

        ////增
        //queue.Enqueue(12);
        //queue.Enqueue("123");
        //queue.Enqueue(1.4f);
        //queue.Enqueue(true);

        ////取(先进先出)
        //Console.WriteLine(queue.Dequeue());
        //Console.WriteLine(queue.Dequeue());

        ////查
        //Console.WriteLine(queue.Peek());//只看最先进的
        //Console.WriteLine(queue.Peek());

        //Console.WriteLine(queue.Contains(1.4f));//查看指定参数是否在queue中
        //Console.WriteLine(queue.Contains("不存在的数"));

        ////删
        //queue.Clear();

        //queue.Enqueue(12);
        //queue.Enqueue("123");
        //queue.Enqueue(1.4f);
        //queue.Enqueue(true);

        //Console.WriteLine(queue.Count);

        ////遍历
        //foreach(Object item in queue)
        //{
        //    Console.WriteLine(item);
        //}

        //Object[] array = queue.ToArray();//转为数组参与for循环打印
        //for (int i = 0; i < queue.Count; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}

        //while(queue.Count > 0)//循环出列
        //{
        //    Console.WriteLine(queue.Dequeue());
        //}
        //Console.WriteLine(queue.Count);

        Queue queue = new Queue();
        queue.Enqueue("你好");
        queue.Enqueue("很高兴认识你");
        queue.Enqueue("再见");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
            Thread.Sleep(1000);//让当前线程暂停1000ms（1s）
        }

        //Hashtable hashtable = new Hashtable();

        ////增
        //hashtable.Add(1 , "23");
        //hashtable.Add(2, "1");
        //hashtable.Add("123", "23");
        //hashtable.Add(3, "123123");

        ////删
        //hashtable.Remove(1);//只能通过键去删除
        //hashtable.Remove("1");//删除没有的键不会报错
        //hashtable.Clear();

        //hashtable.Add(1, "23");
        //hashtable.Add(2, "1");
        //hashtable.Add("123", "23");
        //hashtable.Add(3, "123123");

        ////查
        //Console.WriteLine(hashtable[1]);//通过键去查找值
        //Console.WriteLine(hashtable[11]);//找不到会返回空

        //Console.WriteLine(hashtable.Contains(1));//查找是否存在键
        //Console.WriteLine(hashtable.ContainsKey(2));//查找是否存在键
        //Console.WriteLine(hashtable.ContainsValue("23"));//查找是否存在值

        ////改
        //Console.WriteLine(hashtable[1]);//只能修改键对应的值内容,无法修改键
        //hashtable[1] = "44";
        //Console.WriteLine(hashtable[1]);

        ////遍历
        //foreach (Object i in hashtable.Keys)
        //{
        //    Console.WriteLine("{0} {1}", i , hashtable[i]);
        //}
        //foreach (Object item in hashtable.Values)
        //{
        //    Console.WriteLine(item);//不能根据值来获取键
        //}

        MonsterManager.CreateMonter("1" , "史莱姆");
        MonsterManager.CreateMonter("2", "鱼人");
        MonsterManager.RemoveMonster("2");
    }
}