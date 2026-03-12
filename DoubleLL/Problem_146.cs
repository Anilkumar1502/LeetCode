public class LRUCache {

    Dictionary<int,Node> cache;
    private readonly int cap;
    private Node head;
    private Node curr;
    public LRUCache(int capacity) {
        cap=capacity;
        cache=new Dictionary<int,Node>();
    }

    private void Insert(Node node){
        if(head==null){
            head=node;
            curr=head;
        }
        else{
        curr.next=node;
        node.prev=curr;
        curr=node;
        curr.next=null;
        }
    }

    private void Delete(Node node){

     //   Console.WriteLine(node.val);
        Node previous=node.prev;
        Node nxt=node.next;               
 
        if(previous!=null)
        previous.next=nxt;
        else{
        head=nxt;
        }

        if(nxt!=null)
        nxt.prev=previous;
        else{
        curr=previous;
        previous?.next=null;
        }
    }
    
    public int Get(int key) {  
        if(cache.ContainsKey(key)){            
           Delete(cache[key]);
           Insert(cache[key]);
           return cache[key].val;

        }
        return -1;
    }
    
    public void Put(int key, int value) {      
        if(cache.ContainsKey(key)){
            cache[key].val=value;
            Delete(cache[key]);
            Insert(cache[key]);
            return;
        }
        if(cache.Count>=cap)
        {               
            cache.Remove(head.key);        
            Delete(head);            
        }
        Node n=new Node(value,key);
        Insert(n);
        cache[key]=n;
    }
}

public class Node{

    public int val {get;set;}

    public int key {get;set;}
   

    public Node prev{get;set;}

    public Node next{get;set;}

   public Node(int val,int key){
      this.val=val;
      this.key=key;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
