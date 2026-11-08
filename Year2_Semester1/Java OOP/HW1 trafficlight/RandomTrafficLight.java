import java.util.ArrayList;

public class RandomTrafficLight extends TrafficLight {
    public RandomTrafficLight(Junction junction) {
        super(junction);
    }

    protected Road chooseNextGreen() {
        ArrayList<Road> roads = getJunction().getIncomingRoads();
        return roads.get((int) (Math.random() * roads.size()));
    }
}
