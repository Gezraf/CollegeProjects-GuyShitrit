import java.util.Random;

public class Student implements Participant {
    private int id;
    private Site site;
    private HomeWork homeWork;
    private Random random = new Random();

    public Student(int id, Site site) {
        this.id = id;
        this.site = site;
    }

    public void activate() {
        if (homeWork == null && random.nextBoolean()) {
            homeWork = new HomeWork(id);
            site.submit(homeWork);
            System.out.println("Student " + id + " submitted homework " + homeWork.getId());
        }
    }

    public void printResult() {
        System.out.println("Student " + id + ", homework " + homeWork.getId() + ", grade: " + homeWork.getGrade());
    }
}
