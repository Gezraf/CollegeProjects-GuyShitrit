public class Time {
    private int hour, minute, second;

    public Time(int hour, int minute, int second) {
        this.hour = (0 <= hour && hour <= 23) ? hour : 0;
        this.minute = (0 <= minute && minute <= 59) ? minute : 0;
        this.second = (0 <= second && second <= 59) ? second : 0;
    }

    public Time(Time other) {
        this.hour = other.hour;
        this.minute = other.minute;
        this.second = other.second;
    }

    int GetHour() {
        return this.hour;
    }

    int GetMinute() {
        return this.minute;
    }

    int GetSecond() {
        return this.second;
    }

    void SetHour(int num) {
        this.hour = (0 <= num && num <= 23) ? num : this.hour;
    }

    void SetMinute(int num) {
        this.minute = (0 <= num && num <= 59) ? num : this.minute;
    }

    void SetSecond(int num) {
        this.second = (0 <= num && num <= 59) ? num : this.second;
    }

    void PrintTime() {
        System.out.printf("%02d:%02d:%02d", this.hour, this.minute, this.second);
    }
}
