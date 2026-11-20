public class Cat extends Animal {
    private boolean nailSubscription;

    public Cat(String owner, String breed, boolean nailSubscription) {
        super(owner, breed);
        this.nailSubscription = nailSubscription;
    }

    public boolean hasNailSubscription() {
        return nailSubscription;
    }

    @Override
    public AnimalType getType() {
        return AnimalType.CATS;
    }
}
