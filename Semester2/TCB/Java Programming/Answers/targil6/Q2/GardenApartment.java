public class GardenApartment extends Apartment {
    private int numRooms;
    private double gardenArea;
    private boolean privateEntrance;

    public GardenApartment(String name, int floor, double area, int numRooms, double gardenArea, boolean privateEntrance) {
        super(name, floor, area);
        this.numRooms = numRooms;
        this.gardenArea = gardenArea;
        this.privateEntrance = privateEntrance;
    }

    public int getNumRooms() {return numRooms;}
    public void setNumRooms(int numRooms) {this.numRooms = numRooms;}

    public double getGardenArea() {return gardenArea;}
    public void setGardenArea(double gardenArea) {this.gardenArea = gardenArea;}

    public boolean isPrivateEntrance() {return privateEntrance;}
    public void setPrivateEntrance(boolean privateEntrance) {this.privateEntrance = privateEntrance;}

    public double totalArea() {return getArea() + gardenArea;}

    @Override
    public String ToString() {
        return "GardenApartment [" + super.toString() + ", rooms=" + numRooms + ", garden=" + gardenArea + ", privateEntrance=" + privateEntrance + "]";
    }
}