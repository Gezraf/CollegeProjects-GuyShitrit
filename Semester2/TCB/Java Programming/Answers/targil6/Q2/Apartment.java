public class Apartment {
    private String name;
    private int floor;
    private double area;

    public Apartment(String name, int floor, double area) {
        this.name = name;
        this.floor = floor;
        this.area = area;
    }

    public String getName() {return name;}
    public void setName(String name) {this.name = name;}

    public int getFloor() {return floor;}
    public void setFloor(int floor) {this.floor = floor;}

    public double getArea() {return area;}
    public void setArea(double area) {this.area = area;}

    public double totalArea() {
        return area;
    }

    public String ToString() {
        return "Apartment [name=" + name + ", floor=" + floor + ", area=" + area + "]";
    }
}