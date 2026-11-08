public class Road {
    private Junction start;
    private Junction end;
    private double length;

    public Road(Junction start, Junction end) {
        this.start = start;
        if (start == end) {
            this.end = new Junction();
        } else {
            this.end = end;
        }
        this.length = start.calcDistance(this.end);
        this.start.addOutgoingRoad(this);
        this.end.addIncomingRoad(this);
    }

    public Junction getStart() {
        return this.start;
    }

    public Junction getEnd() {
        return this.end;
    }

    public double getLength() {
        return this.length;
    }

    public String toString() {
        return this.start + " -> " + this.end;
    }
}
