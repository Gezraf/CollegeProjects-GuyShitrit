public class Store {
    private Tablet[] tablets;
    private int[] systems;

    public Store() {
        tablets = new Tablet[1000];
        systems = new int[3];
    }

    public boolean addTablet(Tablet tab) {
        int count = systems[0] + systems[1] + systems[2];
        for (int i = 0; i < count; i++) {
            if (tablets[i].isSame(tab)) {
                if (tab.getPrice() > tablets[i].getPrice())
                    tablets[i].setPrice(tab.getPrice());
                return true;
            }
        }
        if (count == 1000)
            return false;
        tablets[count] = tab;
        if (tab.getSystem() == 'W')
            systems[0]++;
        else if (tab.getSystem() == 'A')
            systems[1]++;
        else
            systems[2]++;
        return true;
    }

    public int sortStore() {
        int count = systems[0] + systems[1] + systems[2];
        Tablet[] temp = new Tablet[1000];
        int k = 0;
        for (int i = 0; i < count; i++) {
            if (tablets[i].getSystem() == 'W') {
                temp[k] = tablets[i];
                k++;
            }
        }
        for (int i = 0; i < count; i++) {
            if (tablets[i].getSystem() == 'A') {
                temp[k] = tablets[i];
                k++;
            }
        }
        for (int i = 0; i < count; i++) {
            if (tablets[i].getSystem() == 'I') {
                temp[k] = tablets[i];
                k++;
            }
        }
        tablets = temp;
        return 1000 - count;
    }
}
