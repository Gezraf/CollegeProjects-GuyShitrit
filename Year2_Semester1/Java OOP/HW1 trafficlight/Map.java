import java.util.ArrayList;
import java.util.Random;

public class Map {
    private static final int MAX_ROUTE_LENGTH = 4;
    private static final int MAX_OUTGOING_ROADS = 3;
    private static final double TRAFFIC_LIGHT_PROBABILITY = 0.25;
    private static final Random RANDOM = new Random();

    private ArrayList<Junction> junctions;
    private ArrayList<Road> roads;

    public Map(int junctionCount) {
        this.junctions = new ArrayList<Junction>();
        this.roads = new ArrayList<Road>();
        for (int i = 0; i < junctionCount; i++) {
            this.junctions.add(new Junction());
        }
        for (Junction from : this.junctions) {
            int outgoing = RANDOM.nextInt(MAX_OUTGOING_ROADS + 1);
            for (int i = 0; i < outgoing; i++) {
                Junction to = this.junctions.get(RANDOM.nextInt(this.junctions.size()));
                if (to != from) {
                    this.roads.add(new Road(from, to));
                }
            }
        }
        addTrafficLights();
    }

    public Map(ArrayList<Junction> junctions, ArrayList<Road> roads) {
        this.junctions = junctions;
        this.roads = roads;
        addTrafficLights();
    }

    private void addTrafficLights() {
        for (Junction junction : this.junctions) {
            if (!junction.getIncomingRoads().isEmpty() && RANDOM.nextDouble() < TRAFFIC_LIGHT_PROBABILITY) {
                if (RANDOM.nextBoolean()) {
                    junction.setTrafficLight(new RandomTrafficLight(junction));
                } else {
                    junction.setTrafficLight(new ConsecutiveTrafficLight(junction));
                }
            }
        }
    }

    public ArrayList<Junction> getJunctions() {
        return this.junctions;
    }

    public ArrayList<Road> getRoads() {
        return this.roads;
    }

    public ArrayList<Road> getRandomRoute() {
        ArrayList<Road> route = new ArrayList<Road>();
        ArrayList<Junction> candidates = new ArrayList<Junction>();
        for (Junction junction : this.junctions) {
            if (!junction.getOutgoingRoads().isEmpty()) {
                candidates.add(junction);
            }
        }
        if (candidates.isEmpty()) {
            return route;
        }
        Junction current = candidates.get(RANDOM.nextInt(candidates.size()));
        while (route.size() < MAX_ROUTE_LENGTH && !current.getOutgoingRoads().isEmpty()) {
            ArrayList<Road> options = current.getOutgoingRoads();
            Road next = options.get(RANDOM.nextInt(options.size()));
            route.add(next);
            current = next.getEnd();
        }
        return route;
    }
}
