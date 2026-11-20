import java.util.ArrayList;
import java.util.List;

public abstract class Animal {
    private static int counter = 0;

    private int serialNumber;
    private String owner;
    private String breed;
    private List<Treatment> treatments;

    public Animal(String owner, String breed) {
        counter++;
        this.serialNumber = counter;
        this.owner = owner;
        this.breed = breed;
        this.treatments = new ArrayList<>();
    }

    // Every animal type must say which type it is (used by Doctor and Control)
    public abstract AnimalType getType();

    public void addTreatment(Treatment treatment) {
        treatments.add(treatment);
    }

    public int getSerialNumber() {
        return serialNumber;
    }

    public String getOwner() {
        return owner;
    }

    public String getBreed() {
        return breed;
    }

    public List<Treatment> getTreatments() {
        return treatments;
    }

    @Override
    public String toString() {
        return getType().getLabel() + " #" + serialNumber + " (owner: " + owner + ", breed: " + breed + ")";
    }
}
