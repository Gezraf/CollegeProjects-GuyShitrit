public class Action {
    private String name;

    public Action(String n) {
        this.name = n;
    }

    public String getName() {
        return this.name;
    }

    public boolean equals(Object other) {
        if (!(other instanceof Action)) {
            return false;
        }
        return this.name.equals(((Action) other).name);
    }
}
