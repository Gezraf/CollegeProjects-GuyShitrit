public class Participant {
    private String name;
    private int id;
    private int price;


    Participant(String name, int id, int price) {
        this.name = name;
        this.id = id;
        this.price = price;
    }

    Participant(Participant other) {
        this.name = other.name;
        this.id = other.id;
        this.price = other.price;
    }

    public String getName() {
        return name;
    }

    public int getId() {
        return id;
    }

    public int getPrice() {
        return price;
    }
}

