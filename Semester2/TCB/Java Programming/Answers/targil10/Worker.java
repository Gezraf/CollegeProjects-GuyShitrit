import java.util.Scanner;

public class Worker {
    private String id; // תז של עובד
    private int status; // 1- מהנדס, 2- פועל
    private int basic; // מספר שעות בסיס בחודש
    private int extra; // מספר שעות נוספות בחודש


    public Worker(String id, int status) { // פעולה בונה
        this.id = id;
        this.status = status;
        this.basic = 0;
        this.extra = 0;
    }

    public String getID() {
        return id;
    }

    public int getStatus() {
        return status;
    }

    public int getBasic() {
        return basic;
    }

    public int getExtra() {
        return extra;
    }

    public int getTotalHours() {
        return basic + extra;
    }


    public int getSalary() {
        int salary = 0;

        switch (this.status) {
            case 1:
                salary += this.basic * 50;
                break;


            case 2:
                salary += this.basic * 90;
                break;

            default:
                break;
        }


        salary += this.extra * 100;
        return salary;
    }


    public void input() {
        Scanner scan = new Scanner(System.in);
        int start, end;

        int totalHours = 0;

        for (int i = 0; i < 20; i++) {
            System.out.println("Enter start hour: ");
            start = scan.nextInt();

            System.out.println("Enter end hour: ");
            end = scan.nextInt();


            while (start < 0 || start >= 24 || end < 0 || end >= 24 ||  end < start) {
                System.out.println("Enter start hour: ");
                start = scan.nextInt();

                System.out.println("Enter end hour: ");
                end = scan.nextInt();
            }

            int hours = end - start; // בהנחה שend < start
            totalHours += hours;
        }

        if (totalHours <= 160) {
            this.basic = totalHours;
            this.extra = 0;
        } else {
            this.basic = 160;
            this.extra = totalHours - 160;
        }

    }



    public void printWorkers(Worker[] arr) {
        int totalWorkerSalary = 0, totalEngineerSalary = 0;

        for (int i = 0; i < arr.length; i++) {
            System.out.println("ID: " + arr[i].getID());
            System.out.println("Work hours: " + arr[i].getTotalHours());

            int salary = arr[i].getSalary();
            switch (arr[i].getStatus()) {
                case 1:
                    totalEngineerSalary += salary;
                    break;

                case 2:
                    totalWorkerSalary += salary;
                    break;

                default:
                    break;
            }

            System.out.println("Salary: " + salary);
        }

        System.out.println("Total Engineer Salary: " + totalEngineerSalary);
        System.out.println("Total Worker Salary: " + totalWorkerSalary);
    }

}


