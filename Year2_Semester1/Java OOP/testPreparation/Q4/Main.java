public class Main {
    public static void main(String[] args) {
        Control control = new Control();

        Doctor d1 = new Doctor("111111111", "Dana Levi");
        d1.addSpecialty(AnimalType.CATS);
        d1.addSpecialty(AnimalType.DOGS);
        Doctor d2 = new Doctor("222222222", "Avi Cohen");
        d2.addSpecialty(AnimalType.BIRDS);
        control.addDoctor(d1);
        control.addDoctor(d2);

        Animal cat = new Cat("Noa", "Siamese", true);
        Animal dog = new Dog("Yossi", "Husky", false);
        Animal bird = new Bird("Maya", "Parrot", "Green");
        control.addAnimal(cat);
        control.addAnimal(dog);
        control.addAnimal(bird);

        d1.treat(cat, "Vaccination");
        d1.treat(cat, "Nail trimming");   // same animal twice - printed once
        d1.treat(dog, "Check-up");
        d1.treat(bird, "Wing check");     // not allowed
        d2.treat(bird, "Wing check");

        control.printAnimalsOfDoctor("Dana Levi");
        control.printAnimalsOfDoctor("Avi Cohen");
        control.printAnimalsOfDoctor("Nobody");
    }
}
