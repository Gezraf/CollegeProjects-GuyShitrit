import java.util.ArrayList;

public class Junction extends Point {
    private ArrayList<Road> incomingRoads;
    private ArrayList<Road> outgoingRoads;
    private TrafficLight trafficLight;

    public Junction() {
        super();
        this.incomingRoads = new ArrayList<Road>();
        this.outgoingRoads = new ArrayList<Road>();
    }

    public Junction(int x, int y) {
        super(x, y);
        this.incomingRoads = new ArrayList<Road>();
        this.outgoingRoads = new ArrayList<Road>();
    }

    public ArrayList<Road> getIncomingRoads() {
        return this.incomingRoads;
    }

    public ArrayList<Road> getOutgoingRoads() {
        return this.outgoingRoads;
    }

    public TrafficLight getTrafficLight() {
        return this.trafficLight;
    }

    public void setTrafficLight(TrafficLight trafficLight) {
        this.trafficLight = trafficLight;
    }

    public void addIncomingRoad(Road road) {
        this.incomingRoads.add(road);
    }

    public void addOutgoingRoad(Road road) {
        this.outgoingRoads.add(road);
    }
}
