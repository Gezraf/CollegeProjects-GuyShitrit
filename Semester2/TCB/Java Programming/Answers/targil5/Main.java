public class Main {
    public static void main (String[] args) {
        Point p1 = new Point(8, 0);
        Point p2 = new Point(0,10);
        System.out.println(p1.Equals(p2));
        System.out.println("Point 1: " + p1.ToString() + ", Point 2: " + p2.ToString());
        Line l = new Line(p1, p2);
        System.out.println(l.Length());
        System.out.println(l.ToString());
    }
}