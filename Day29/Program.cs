//MyLinkedList list = new MyLinkedList();
//list.Add(23);
//list.Add(30);
//list.Add(40);
//list.Print();
//Console.WriteLine("************************");
//list.Insert(1 , 99);
//list.Print();
//Console.WriteLine("************************");
//list.Insert(0, 86);
//list.Print();
//Console.WriteLine("************************");
//list.Insert(3 , 57);
//list.Print();
//Console.WriteLine("************************");
//list.RemoveAt(3);
//list.Print();
//Console.WriteLine("************************");
//list.RemoveAt(0);
//list.Print();

//class Node//创建节点,存储数据与下一个节点的位置
//{
//    public int data;
//    public Node next;
//}
//class MyLinkedList
//{
//    private Node head;//头节点,相当于入口,添加新的数据或者打印数组都需要通过这里进入
//    public void Add(int value)
//    {
//        Node newnode = new Node();//需要添加的新节点,存储新的数据与下一个节点的位置
//        newnode.data = value;
//        if (head == null)//如果头节点为null,说明链表内部没有节点,需要新创建一个
//        {
//            head = newnode;//让新的节点为头节点
//        }
//        else
//        {
//            Node current = head;//现节点,相当于一个指针,说明现在到了哪个节点
//            while (current.next != null)//根据每个节点的next指向寻找下一个节点,这里需要添加一个新的节点,所以需要找到下一个节点为null的节点来添加到原数组的末端
//            {
//                current = current.next;//指针向后移动
//            }
//            current.next = newnode;
//        }
//    }

//    public void Insert(int index , int value)//输入索引与数据
//    {
//        Node current = head;//后指针
//        Node currentBefore = head;//前指针
//        Node newNode = new Node();
//        newNode.data = value;
//        if (index > 0)//若索引大于0,即节点不做头节点时,插入两节点之中,即使前节点的next等于新节点,新节点的next等于后节点
//        {
//            for (int i = 0; i < index; i++)
//            {
//                currentBefore = current;
//                current = current.next;
//            }
//            currentBefore.next = newNode;
//            newNode.next = current;
//        }
//        else if (index == 0)//若索引为零,则做头节点
//        {
//            newNode.next = head;
//            head = newNode;
//        }
//    }

//    public void RemoveAt(int index)
//    {
//        Node previous = head;
//        Node current = head;
//        if (index > 0)//若索引大于零,即不用删除头节点,只需要将前节点的next改为被删除节点的next
//        {
//            for (int i = 0; i < index; i++)
//            {
//                previous = current;
//                current = current.next;
//            }
//            previous.next = current.next;
//        }
//        else if (index == 0)//若索引等于零,即删除头节点,让head指向原头节点的下一节点
//        {
//            head = head.next;
//        }
//    }

//    public void Print()
//    {
//        Node current = head;
//        while (current != null)//遍历打印数组中的每个数据,所以要遍历每个节点本身
//        { 
//            Console.WriteLine(current.data);
//            current = current.next;
//        }
//    }
//}
MyLinkedList<int> list = new();
list.Add(11);
list.Add(22);
list.Add(33);
list.Print();
list.Count();
list.Remove(33);
list.Print();
list.Add(88);
list.Print();

class Node<T>
{
    public T data;
    public Node<T> next;
}
class MyLinkedList<T>
{
    private Node<T> head;
    private Node<T> last;

    public void Add(T value)
    {
        Node<T> newnode = new();
        newnode.data = value;
        if (head == null)
        {
            head = newnode;
            last = newnode;
        }
        else
        {
            last.next = newnode;
            last = newnode;
        }
    }

    public void Count()
    {
        Node<T> current = head;
        int i = 0;
        while (current != null)
        {
            i++;
            current = current.next;
        }
        Console.WriteLine(i);
    }

    public void Print()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }

    public void Remove(T value)
    {
        Node<T> current = head;
        if (head.data.Equals(value))
        {
            head = head.next;
            return;
        }
        while (current.next != null)
        {
            if (current.next.data.Equals(value))
            {
                if (value.Equals(last.data))
                {
                    last = current;
                }
                current.next = current.next.next;
                return;
            }
            current = current.next;
        }
    }
}