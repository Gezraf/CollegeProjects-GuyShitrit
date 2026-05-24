public class Student {
    private String id;
    private int[] arrGradesSemesterA;
    private int[] arrGradesSemesterB;

    public boolean isImproved() {

        for (int i = 0; i < arrGradesSemesterA.length; i++) {

            if (arrGradesSemesterA[i] == -1 && arrGradesSemesterB[i] == -1)
                return false;

            if (arrGradesSemesterA[i] == -1 || arrGradesSemesterB[i] == -1)
                continue;

            if (arrGradesSemesterB[i] < arrGradesSemesterA[i])
                return false;
        }

        return true;
    }

    public static Student[] checkAllImproved(Student[] arr) {
        Student[] temp = new Student[arr.length];
        int count = 0;

        for (int i = 0; i < arr.length; i++) {
            if (arr[i].isImproved()) {
                temp[count++] = arr[i];
            }
        }

        if (count == 0)
            return null;

        Student[] res = new Student[count];
        for (int i = 0; i < count; i++) {
            res[i] = temp[i];
        }

        return res;
    }
}

