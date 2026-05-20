//ID: 330707761, Author: Guy Shitrit

public class Main {
    public static void main(String[] args) {
        float RATE = 3.11F;
        boolean FEMALE = true, MALE = false;
        int CASH = 1, CREDIT = 2, CHECK = 3;

        Client cli = new Client("Guy", "Shitrit", 19, MALE, CREDIT, 25);

        System.out.println("Total to pay: " + cli.Pay(RATE));
        System.out.println(cli.Print());
    }
}
