public class Bird extends Animal {
    private String color;

    public Bird(String owner, String breed, String color) {
        super(owner, breed);
        this.color = color;
    }

    public String getColor() {
        return color;
    }

    @Override
    public AnimalType getType() {
        return AnimalType.BIRDS;
    }
}
