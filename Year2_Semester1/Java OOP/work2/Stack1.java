public class Stack1 {
    private int[] data;
    private int top1;

    public Stack1() {
        top1 = -1;
        data = new int[10];
    }

    public void push(int elem) {
        if (top1 == data.length - 1) {
            int[] temp = new int[data.length + 5];
            for (int i = 0; i < data.length; i++) {
                temp[i] = data[i];
            }
            data = temp;
        }
        top1++;
        data[top1] = elem;
    }

    public int pop() {
        if (isEmpty()) {
            return -1;
        }
        int poppedNum = data[top1];
        top1--;
        return poppedNum;
    }

    public int peek() {
        if (isEmpty()) {
            return -1;
        }
        return data[top1];
    }

    public boolean isEmpty() {
        return top1 == -1;
    }
}
