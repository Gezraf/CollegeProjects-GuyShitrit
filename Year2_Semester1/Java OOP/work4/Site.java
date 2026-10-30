import java.util.LinkedList;

public class Site {
    private LinkedList<HomeWork> homeWorks = new LinkedList<>();

    public void submit(HomeWork homeWork) {
        homeWorks.add(homeWork);
    }

    public HomeWork getNext() {
        return homeWorks.poll();
    }
}
