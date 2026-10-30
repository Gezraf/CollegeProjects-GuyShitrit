import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        int studentsCount = 10;
        Site site = new Site();
        Lecturer lecturer = new Lecturer(1, site);
        ArrayList<Participant> participants = new ArrayList<>();
        for (int i = 1; i <= studentsCount; i++) {
            participants.add(new Student(i, site));
        }
        participants.add(lecturer);

        while (lecturer.getChecked() < studentsCount) {
            for (int i = 0; i < participants.size(); i++) {
                participants.get(i).activate();
            }
        }

        for (int i = 0; i < participants.size(); i++) {
            participants.get(i).printResult();
        }
    }
}
