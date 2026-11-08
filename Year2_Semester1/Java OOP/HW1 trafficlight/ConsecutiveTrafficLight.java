import java.util.ArrayList;

public class ConsecutiveTrafficLight extends TrafficLight {
    private int currentIndex;

    public ConsecutiveTrafficLight(Junction junction) {
        super(junction);
        this.currentIndex = 0;
    }

    protected Road chooseNextGreen() {
        ArrayList<Road> roads = getJunction().getIncomingRoads();
        this.currentIndex = (this.currentIndex + 1) % roads.size();
        return roads.get(this.currentIndex);
    }
}
