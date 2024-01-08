namespace LinkedList{
    public class Node(string data)
    {
        public Node next ;
        public string data=data;
    }

    public class LinkedList {
        private Node? head;
        public void Append(string data){
            // walk through the linklist and append a new node in end
            //case 1 . head is null, then just create a node
            //others , walk through the linkedlist O(n), and insert at end
            if (head == null)
            {
                Node newNode = new Node(data);
                head=newNode;
                return;
            }
            Node current = head;
            while (current.next != null){
                current = current.next;
            }
            current.next = new Node(data);
            return;

        }
        public void PreAppend(string data)
        {
            Node newNode=new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.next =head;
            head=newNode;
            return ;

        }
        // try to find the node that matches the data , and delete
        public void Delete(string data){
            Node? current=head;
            if (current?.data == data)
            {
                // need to remove head
                head = head?.next;
                return;
            }
            while (current?.next !=null ){
                if (current?.next.data ==data){
                    current.next = current.next.next;                    
                }
                current = current?.next;
            }
            return;



        }
        public void Traversal(){

            Node? current =head;
            if (current == null ){
                Console.WriteLine("No data");
                return;
            }
            while (current != null ){
                Console.WriteLine(current.data);
                current = current.next;
            }
            return;

            



        }
    }
    public class Program{
        static void Main()
        {
            
            LinkedList l=new LinkedList();
            l.Append("4");
            l.PreAppend("5");
            l.Append("7");
            Console.WriteLine("Before Delete");
            l.Traversal();
            //l.Delete("5");
            //l.Delete("8");
            //l.Delete("4");
            l.Delete("7");
            Console.WriteLine("after Delete");
            l.Traversal();

        }
    }
}


