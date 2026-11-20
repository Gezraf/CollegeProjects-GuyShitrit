import java.util.ArrayList;
import java.util.List;

public class Doctor {
    private String id;
    private String fullName;
    private List<AnimalType> specialties;

    public Doctor(String id, String fullName) {
        this.id = id;
        this.fullName = fullName;
        this.specialties = new ArrayList<>();
    }

    public void addSpecialty(AnimalType type) {
        if (!specialties.contains(type)) {
            specialties.add(type);
        }
    }

    public boolean canTreat(AnimalType type) {
        return specialties.contains(type);
    }

    // Adds a new treatment to the animal if the doctor treats this kind of animal
    public void treat(Animal animal, String treatmentName) {
        if (canTreat(animal.getType())) {
            Treatment t = new Treatment(this, animal, treatmentName);
            animal.addTreatment(t);
        } else {
            System.out.println("Dr. " + fullName + " cannot treat " + animal.getType().getLabel().toLowerCase() + "s.");
        }
    }

    public String getId() {
        return id;
    }

    public String getFullName() {
        return fullName;
    }

    public List<AnimalType> getSpecialties() {
        return specialties;
    }

    @Override
    public String toString() {
        return "Dr. " + fullName + " (ID " + id + ")";
    }
}
