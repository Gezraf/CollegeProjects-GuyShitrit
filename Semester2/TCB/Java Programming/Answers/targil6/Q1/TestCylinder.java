public class TestCylinder {
    public static void main(String[] args) {

        // Declare and allocate a new instance of Cylinder
        // with default color, radius, and height
        Cylinder c1 = new Cylinder();

        System.out.println("Cylinder:"
                + " radius=" + c1.getRadius()
                + " height=" + c1.getHeight()
                + " base area=" + c1.getArea()
                + " volume=" + c1.getVolume());

        // Declare and allocate a new instance of Cylinder
        // specifying height, with default color and radius
        Cylinder c2 = new Cylinder(10.0);

        System.out.println("Cylinder:"
                + " radius=" + c2.getRadius()
                + " height=" + c2.getHeight()
                + " base area=" + c2.getArea()
                + " volume=" + c2.getVolume());
    }
}