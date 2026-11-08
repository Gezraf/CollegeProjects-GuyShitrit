import java.util.Random;

public class Point {
    private static final int MAX_X = 800;
    private static final int MAX_Y = 600;
    private static final Random RANDOM = new Random();

    private int x;
    private int y;

    public Point() {
        this.x = randomX();
        this.y = randomY();
    }

    public Point(int x, int y) {
        if (isValidX(x)) {
            this.x = x;
        } else {
            this.x = randomX();
        }
        if (isValidY(y)) {
            this.y = y;
        } else {
            this.y = randomY();
        }
    }

    private static int randomX() {
        return RANDOM.nextInt(MAX_X + 1);
    }

    private static int randomY() {
        return RANDOM.nextInt(MAX_Y + 1);
    }

    private static boolean isValidX(int x) {
        return x >= 0 && x <= MAX_X;
    }

    private static boolean isValidY(int y) {
        return y >= 0 && y <= MAX_Y;
    }

    public int getX() {
        return this.x;
    }

    public int getY() {
        return this.y;
    }

    public double calcDistance(Point other) {
        double dx = this.x - other.x;
        double dy = this.y - other.y;
        return Math.sqrt(dx * dx + dy * dy);
    }

    public String toString() {
        return "(" + this.x + ", " + this.y + ")";
    }
}
