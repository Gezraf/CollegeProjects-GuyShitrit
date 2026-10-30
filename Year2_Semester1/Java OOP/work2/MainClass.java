import java.util.Stack;

public class MainClass {
    public static Stack<Integer> getReverseStack(Stack<Integer> s) {
        Stack<Integer> result = new Stack<>();
        for (int i = s.size() - 1; i >= 0; i--) {
            result.push(s.get(i));
        }
        return result;
    }

    public static Stack<Integer> getMaxStack(Stack<Integer> s) {
        Stack<Integer> result = new Stack<>();
        for (int i = 0; i < s.size(); i++) {
            int x = s.get(i);
            if (result.isEmpty() || x > result.peek()) {
                result.push(x);
            } else {
                int max = result.pop();
                result.push(x);
                result.push(max);
            }
        }
        return result;
    }

    public static Stack<Integer> getEvenStack(Stack<Integer> s) {
        Stack<Integer> result = new Stack<>();
        for (int i = 0; i < s.size(); i++) {
            if (s.get(i) % 2 == 0) {
                result.push(s.get(i));
            }
        }
        return result;
    }

    public static Stack1 getReverseStack(Stack1 s) {
        Stack1 result = new Stack1();
        Stack1 temp = new Stack1();
        while (!s.isEmpty()) {
            int x = s.pop();
            result.push(x);
            temp.push(x);
        }
        while (!temp.isEmpty()) {
            s.push(temp.pop());
        }
        return result;
    }

    public static Stack1 getMaxStack(Stack1 s) {
        Stack1 result = new Stack1();
        Stack1 temp = new Stack1();
        while (!s.isEmpty()) {
            temp.push(s.pop());
        }
        while (!temp.isEmpty()) {
            int x = temp.pop();
            s.push(x);
            if (result.isEmpty() || x > result.peek()) {
                result.push(x);
            } else {
                int max = result.pop();
                result.push(x);
                result.push(max);
            }
        }
        return result;
    }

    public static Stack1 getEvenStack(Stack1 s) {
        Stack1 result = new Stack1();
        Stack1 temp = new Stack1();
        while (!s.isEmpty()) {
            temp.push(s.pop());
        }
        while (!temp.isEmpty()) {
            int x = temp.pop();
            s.push(x);
            if (x % 2 == 0) {
                result.push(x);
            }
        }
        return result;
    }

    public static void printStack(Stack1 s) {
        Stack1 temp = new Stack1();
        while (!s.isEmpty()) {
            temp.push(s.pop());
        }
        String result = "[";
        while (!temp.isEmpty()) {
            int x = temp.pop();
            s.push(x);
            result += x;
            if (!temp.isEmpty()) {
                result += ", ";
            }
        }
        System.out.println(result + "]");
    }

    public static void main(String[] args) {
        Stack<Integer> s = new Stack<>();
        s.push(5);
        s.push(9);
        s.push(12);
        s.push(7);
        s.push(4);
        System.out.println("Stack: " + s);
        System.out.println("Peek: " + s.peek());
        System.out.println("Pop: " + s.pop());
        System.out.println("Stack: " + s);
        s.push(4);
        System.out.println("Reverse: " + getReverseStack(s));
        System.out.println("Max: " + getMaxStack(s));
        System.out.println("Even: " + getEvenStack(s));
        System.out.println("Original: " + s);

        Stack1 s1 = new Stack1();
        for (int i = 1; i <= 13; i++) {
            s1.push(i * 3);
        }
        System.out.print("Stack1: ");
        printStack(s1);
        System.out.println("Peek: " + s1.peek());
        System.out.println("Pop: " + s1.pop());
        System.out.println("Is empty: " + s1.isEmpty());
        System.out.print("Reverse: ");
        printStack(getReverseStack(s1));
        System.out.print("Max: ");
        printStack(getMaxStack(s1));
        System.out.print("Even: ");
        printStack(getEvenStack(s1));
        System.out.print("Original: ");
        printStack(s1);
    }
}
