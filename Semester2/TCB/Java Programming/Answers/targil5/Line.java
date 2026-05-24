public class Line {
    private Point p1, p2;

    public Line(int x1, int y1, int x2, int y2) {
        this.p1 = new Point(x1, y1);
        this.p2 = new Point(x2, y2);
    }

    public Line(Point P1, Point P2) {
        this.p1 = P1;
        this.p2 = P2;
    }

    public Point getP1() {
        return this.p1;
    }

    public Point getP2() {
        return this.p2;
    }

    public float Length() {
        return (float) Math.sqrt(Math.pow(this.p1.getX() - this.p2.getX(), 2) + Math.pow(this.p1.getY() - this.p2.getY(), 2));
    }

    public float computeA() {
        return (float) (this.p2.getY() - this.p1.getY()) / (this.p2.getX() - this.p1.getX());
    }

    public float computeB() {
        return this.p1.getY() - computeA() * this.p1.getX();
    }

    public String ToString() {
        float a = computeA(), b = computeB();

        if (b < 0) {
            return "y = " + a + "x" + " - " + -b;
        }

        return "y = " + a + "x" + " + " + b;
    }
}