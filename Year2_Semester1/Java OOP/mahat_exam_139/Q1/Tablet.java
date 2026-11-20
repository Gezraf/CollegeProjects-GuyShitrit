public class Tablet {
    private String name;
    private String kind;
    private char system;
    private double size;
    private double price;

    public Tablet(String name, String kind, char system, double size, double price) {
        this.name = name;
        this.kind = kind;
        this.system = system;
        this.size = size;
        this.price = price;
    }

    public String getName() { return name; }
    public String getKind() { return kind; }
    public char getSystem() { return system; }
    public double getSize() { return size; }
    public double getPrice() { return price; }
    public void setPrice(double price) { this.price = price; }

    public String toString() {
        return name + " " + kind + " " + system + " " + size + " " + price;
    }

    public boolean isSame(Tablet other) {
        return this.name.equals(other.name) && this.kind.equals(other.kind) && this.size == other.size;
    }
}
