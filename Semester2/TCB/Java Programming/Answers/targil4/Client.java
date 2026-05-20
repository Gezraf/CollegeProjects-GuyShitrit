public class Client {
    private String fname, lname;
    private int age;
    private boolean gender;
    private int payMethod;
    private int days;

    public Client(String fname, String lname, int age, boolean gender, int payMethod, int days) {
        this.fname = fname;
        this.lname = lname;

        this.age = age;
        this.gender = gender;
        this.payMethod = payMethod;
        this.days = days;
    }


    int Discount() {
        int sale = 0;
        if (this.age > 40)
            sale += 50;

        if (this.payMethod == 1)  // מזומן
            sale += 20;
        else if (this.payMethod == 2) // אשראי
            sale += 10;

        return sale;
    }
    float Pay(float rate) {
        double total = (this.days * 40 * rate) * 1.18;

        if(this.age < 21)
            total *= 1.2;

        return (float) total - Discount();
    }


    String Print() {
        String gender = this.gender ? "Female" : "Male"; // אם אמת אז נקבה אחרת זכר
        return "Name: " + fname + " " + lname + "\nAge: " + age + "\nGender: " + gender;
    }
}
