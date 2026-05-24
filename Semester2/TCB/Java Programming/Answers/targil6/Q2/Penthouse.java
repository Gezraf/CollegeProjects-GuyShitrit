public class Penthouse extends Apartment {
    private int numRooms;
    private double balconyArea;

    public Penthouse(String name, int floor, double area, int numRooms, double balconyArea) {
        super(name, floor, area);
        this.numRooms = numRooms;
        this.balconyArea = balconyArea;
    }

    public int getNumRooms() {return numRooms;}
    public void setNumRooms(int numRooms) {this.numRooms = numRooms;}

    public double getBalconyArea() {return balconyArea;}
    public void setBalconyArea(double balconyArea) {this.balconyArea = balconyArea;}

    public double totalArea() {return getArea() + balconyArea;}

    @Override
    public String ToString() {
        return "Penthouse [" + super.toString() + ", rooms=" + numRooms + ", balcony=" + balconyArea + "]";
    }
}