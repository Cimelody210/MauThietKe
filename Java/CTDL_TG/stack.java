class Stack(){
    private int array[];
    private int top =-1;
    Stack(int size) {array = new int[size]};
    
    void push(int n)
    {
        if (top == array.length -1){
            System.out.print("Stack is full");
        }
        else{
            array[++top] = n;
        }
    }
    void Loop()
    {
        if (top ==1){
            System.out.print("Stack is empty");
        }
        else{
            array[top--] = n;

        }
    }
    void printStack(){
        System.out.print("[");
        for (int i= 0, i< = top, i++)
        {
            System.out.print(array[i]  + ",");
        }
        System.out.print(\b + "]");
    }
}