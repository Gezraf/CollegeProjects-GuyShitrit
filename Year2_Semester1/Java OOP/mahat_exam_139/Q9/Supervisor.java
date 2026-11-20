public class Supervisor extends Doctor {
    private Employee[] arr;
    private int current;

    public Supervisor(String name, String specialization) {
        super(name, specialization);
        arr = new Employee[10];
        current = 0;
    }
}
