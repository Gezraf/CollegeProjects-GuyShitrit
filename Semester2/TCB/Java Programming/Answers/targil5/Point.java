public class Point {
    private int x, y;

    public Point(int X, int Y) {
        this.x = X;
        this.y = Y;
    }

    public Point(Point other) {
        this.x = other.x;
        this.y = other.y;
    }

    public int getX() {
        return this.x;
    }

    public int getY() {
        return this.y;
    }

    public void setX(int x) {
        this.x = x;
    }

    public void setY(int y) {
        this.y = y;
    }

    public boolean Equals(Point other) {
        return this.x == other.x && this.y == other.y;
    }

    public String ToString() {
        return "(" + this.x + ","  + this.y + ")";
    }
}