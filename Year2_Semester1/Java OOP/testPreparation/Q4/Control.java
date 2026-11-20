import java.util.ArrayList;
import java.util.LinkedHashSet;
import java.util.List;
import java.util.Set;

public class Control {
    private List<Doctor> doctors;
    private List<Animal> animals;

    public Control() {
        doctors = new ArrayList<>();
        animals = new ArrayList<>();
    }

    public void addDoctor(Doctor d) {
        doctors.add(d);
    }

    public void addAnimal(Animal a) {
        animals.add(a);
    }

    // Prints every animal that was treated by the given doctor, each animal only once
    public void printAnimalsOfDoctor(String doctorName) {
        Set<Animal> treated = new LinkedHashSet<>();
        for (Animal a : animals) {
            for (Treatment t : a.getTreatments()) {
                if (t.getDoctor().getFullName().equals(doctorName)) {
                    treated.add(a);
                }
            }
        }

        System.out.println("Animals treated by " + doctorName + ":");
        if (treated.isEmpty()) {
            System.out.println("  (none)");
        }
        for (Animal a : treated) {
            System.out.println("  " + a.getType().getLabel() + ", serial number: " + a.getSerialNumber());
        }
    }
}
