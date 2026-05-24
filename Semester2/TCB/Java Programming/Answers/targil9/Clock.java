public class Clock
{
    private int hour; // 0-23 שעה
    private int min; // 0-59 דקות

    public Clock(int hour, int min){
        this.hour = hour;
        this.min = min;
    }

    public int getInterval() {
        int targetTotalMinutes = 24 * 60; // 24:00 in minutes
        int currentTotalMinutes = this.hour * 60 + this.min;

        return targetTotalMinutes - currentTotalMinutes;
    }
}