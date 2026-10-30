import java.util.Random;

public class Lecturer implements Participant {
    private int id;
    private Site site;
    private int checked = 0;
    private Random random = new Random();

    public Lecturer(int id, Site site) {
        this.id = id;
        this.site = site;
    }

    public void activate() {
        HomeWork homeWork = site.getNext();
        if (homeWork != null) {
            homeWork.check(id, 20 + random.nextInt(81));
            checked++;
            System.out.println("Lecturer " + id + " checked homework " + homeWork.getId() + " of student " + homeWork.getStudentId() + ", grade: " + homeWork.getGrade());
        }
    }

    public int getChecked() {
        return checked;
    }

    public void printResult() {
    }
}
