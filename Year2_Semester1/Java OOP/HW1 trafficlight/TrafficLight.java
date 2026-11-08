public abstract class TrafficLight {
    private static final int MIN_DELAY = 2;
    private static final int MAX_DELAY = 4;

    private Junction junction;
    private int delay;
    private int elapsed;
    private Road currentGreen;

    public TrafficLight(Junction junction) {
        this.junction = junction;
        this.delay = MIN_DELAY + (int) (Math.random() * (MAX_DELAY - MIN_DELAY + 1));
        this.elapsed = 0;
        this.currentGreen = junction.getIncomingRoads().get(0);
    }

    protected abstract Road chooseNextGreen();

    public void check() {
        this.elapsed++;
        if (this.elapsed >= this.delay) {
            this.elapsed = 0;
            this.currentGreen = chooseNextGreen();
            System.out.println("Traffic light at " + this.junction + " switched green to road " + this.currentGreen);
        }
    }

    public Junction getJunction() {
        return this.junction;
    }

    public int getDelay() {
        return this.delay;
    }

    public Road getCurrentGreen() {
        return this.currentGreen;
    }
}
