
public class Date {
    private int day; // 1-31 יום
    private int month; // 1-12 חודש
    private int year; //  שנה - ארבע ספרות


    public Date(int day, int month, int year) { // פעולה בונה
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int getDay() {
        return day;
    }

    public void setDay(int day) {
        this.day = day;
    }

    public int getMonth() {
        return month;
    }

    public void setMonth(int month) {
        this.month = month;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }


    public boolean equals(Date other) {
        return (this.day == other.day &&
                this.month == other.month &&
                this.year == other.year);
    }


    public boolean before(Date other) {
        if (this.year < other.year)
            return true;

        if (this.year > other.year)
            return false;

        if (this.month < other.month)
            return true;

        if (this.month > other.month)
            return false;

        return this.day < other.day;
    }
}

