public class Salary {
    public static void main(String[] args) {
        Employee[] employees = {
            new Employee(5000),
            new Manager(5000, 1.5f),
            new SalesEmployee(5000, 10),
            new SalesManager(5000, 1.5f, 10)
        };
        for (int i = 0; i < employees.length; i++) {
            System.out.println(employees[i].getName() + ": " + employees[i].ComputeSalary());
        }
    }
}
