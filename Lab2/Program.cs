namespace lab2;

public class Node(char data)
{
    public char Data { get; set; } = data;
    public Node? Next { get; set; } = null;
}

public class LinkedList
{
    private Node? _head = null;

    public LinkedList(Node head)
    {
        _head = head;
    }

    // Add a new node with the given data to the end of the list
    public void Add(char data)
    {
        Node? newNode = new Node(data);

        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            Node? current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }
    }

    // Print the linked list
    public void PrintList()
    {
        Node? current = _head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }

        Console.WriteLine("null");
    }
}

static class Program
{
    static void Main(string[] args)
    {
        var LList = new LinkedList(new Node('Z'));
        LList.Add('i');
        LList.Add('n');
        LList.Add('e');
        LList.Add('t');
        LList.Add('s');
        LList.PrintList();
    }
}