public class Dog extends Animal {
    private boolean muzzleRequired;

    public Dog(String owner, String breed, boolean muzzleRequired) {
        super(owner, breed);
        this.muzzleRequired = muzzleRequired;
    }

    public boolean isMuzzleRequired() {
        return muzzleRequired;
    }

    @Override
    public AnimalType getType() {
        return AnimalType.DOGS;
    }
}
