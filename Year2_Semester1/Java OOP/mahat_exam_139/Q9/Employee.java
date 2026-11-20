public abstract class Employee {
    private static int counter = 0;
    private int num;
    private String name;

    public Employee(String name) {
        counter++;
        this.num = counter;
        this.name = name;
    }

    public int getNum() { return num; }
    public String getName() { return name; }
}
