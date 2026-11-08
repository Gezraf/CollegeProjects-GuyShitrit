import java.util.ArrayList;

public class DrivingGame {
    private Map map;
    private ArrayList<Vehicle> vehicles;

    public DrivingGame(int junctionCount, int vehicleCount) {
        this.map = new Map(junctionCount);
        this.vehicles = new ArrayList<Vehicle>();
        for (int i = 0; i < vehicleCount; i++) {
            this.vehicles.add(new Vehicle(this.map));
        }
    }

    public Map getMap() {
        return this.map;
    }

    public ArrayList<Vehicle> getVehicles() {
        return this.vehicles;
    }

    public void play(int turns) {
        for (int turn = 1; turn <= turns; turn++) {
            System.out.println("Turn " + turn);
            for (Vehicle vehicle : this.vehicles) {
                vehicle.move();
            }
            for (Junction junction : this.map.getJunctions()) {
                if (junction.getTrafficLight() != null) {
                    junction.getTrafficLight().check();
                }
            }
        }
    }
}
