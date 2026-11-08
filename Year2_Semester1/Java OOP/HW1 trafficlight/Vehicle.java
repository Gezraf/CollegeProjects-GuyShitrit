import java.util.ArrayList;
import java.util.Random;

public class Vehicle {
    private static final int MIN_SPEED = 30;
    private static final int MAX_SPEED = 120;
    private static final Random RANDOM = new Random();
    private static int nextId = 1;

    private int id;
    private int speed;
    private ArrayList<Road> route;
    private int roadIndex;
    private int timeOnRoad;

    public Vehicle(Map map) {
        this.id = nextId++;
        this.speed = MIN_SPEED + RANDOM.nextInt(MAX_SPEED - MIN_SPEED + 1);
        this.route = map.getRandomRoute();
        this.roadIndex = 0;
        this.timeOnRoad = 0;
    }

    public int getId() {
        return this.id;
    }

    public int getSpeed() {
        return this.speed;
    }

    public ArrayList<Road> getRoute() {
        return this.route;
    }

    private boolean isFinished() {
        return this.roadIndex >= this.route.size();
    }

    private Point currentPosition() {
        Road road = this.route.get(this.roadIndex);
        double ratio = 1;
        if (road.getLength() > 0) {
            ratio = Math.min(1, this.timeOnRoad * this.speed / road.getLength());
        }
        int x = (int) Math.round(road.getStart().getX() + (road.getEnd().getX() - road.getStart().getX()) * ratio);
        int y = (int) Math.round(road.getStart().getY() + (road.getEnd().getY() - road.getStart().getY()) * ratio);
        return new Point(x, y);
    }

    public void move() {
        if (!isFinished()) {
            this.timeOnRoad++;
            Road road = this.route.get(this.roadIndex);
            if (this.timeOnRoad * this.speed >= road.getLength()) {
                this.roadIndex++;
                this.timeOnRoad = 0;
            }
        }
        if (isFinished()) {
            System.out.println("Vehicle " + this.id + " finished its route");
        } else {
            System.out.println("Vehicle " + this.id + " (speed " + this.speed + ") on road " + this.route.get(this.roadIndex) + ", position " + currentPosition());
        }
    }
}
