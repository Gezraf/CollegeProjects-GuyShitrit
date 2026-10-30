public class HomeWork {
    private static int count = 0;
    private int id;
    private int studentId;
    private int lecturerId;
    private int grade;

    public HomeWork(int studentId) {
        count++;
        id = count;
        this.studentId = studentId;
    }

    public void check(int lecturerId, int grade) {
        this.lecturerId = lecturerId;
        this.grade = grade;
    }

    public int getId() {
        return id;
    }

    public int getStudentId() {
        return studentId;
    }

    public int getLecturerId() {
        return lecturerId;
    }

    public int getGrade() {
        return grade;
    }
}
