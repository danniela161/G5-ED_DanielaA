public class ListaEnlazadas{
    private node head;
    private node til;
    private String name;

    public createList (string ListName){
        name=listName;
        head=tail=null;
    }

    public bool isListEmpty(){
        if (head==null){
            return true
        }
        
        return false;
    }

    public void InsertTailNode(int data){
        if(isListEmpty){
            head = tail = new node(data);
        }
        else{
            node n = new node(data);
            tail.next = n;
            tail=n;
        }
    }

    public int deleteHead(){
        if(isListEmpty){
            throw new emptyListException(name);
        }
        int deleteNode = head.getData;
        if(head == tail){
            head= tail = null;
        }
        else{
            head = head.getNext;
        }
        return deleteNode;
    }

    public void insertHeadNode(int data){
        node newHead = new node();

        if(isListEmpty){
            newHead.newNode(data);
            head= tail = newHead;
        }
        else{
           newHead.setData(data);
           newHead.setNext(head);
           head = newHead;

        }

    }
}