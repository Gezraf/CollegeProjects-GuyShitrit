public enum AnimalType {
    CATS("Cat"),
    DOGS("Dog"),
    BIRDS("Bird");

    private final String label;

    AnimalType(String label) {
        this.label = label;
    }

    public String getLabel() {
        return label;
    }
}
