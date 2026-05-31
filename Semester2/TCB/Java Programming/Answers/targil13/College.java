public class College {
    private String name, yeshuv;
    private Major[] majors;

    public College(String name, String yeshuv) {
        this.name = name;
        this.yeshuv = yeshuv;
        this.majors = new Major[10];
    }

    public String getName() {
        return name;
    }

    public String getYeshuv() {
        return yeshuv;
    }

    public Major[] getMajors() {
        return majors;
    }
}
