public class Major {
    private int code; // מספר מקצוע
    private String majName; // שם המגמה

    public Major(int code, String majName) {
        this.code = code;
        this.majName = majName;
    }

    public int getCode() {
        return code;
    }

    public String getMajName() {
        return majName;
    }
}
