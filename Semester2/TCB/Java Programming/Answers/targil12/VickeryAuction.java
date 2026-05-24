public class VickeryAuction {
    private String product;
    private int realPrice;
    private Participant[] arr;
    private int current;

    VickeryAuction(String product, int realPrice, int current) {
        this.product = product;
        this.realPrice = realPrice;
        this.current = current;

        arr = new Participant[100];
    }

    public boolean append(Participant p) {
        if (current >= arr.length)
            return false;

        if (p.getPrice() <= this.realPrice / 2) {
            return false;
        }

        arr[current++] = new Participant(p);
        return true;
    }

    public Winner findWinner() {
        Participant largest = arr[0], second = arr[1];

        for (int i = 2; i < current; i++) {
            if(arr[i].getPrice() > largest.getPrice()) {
                second = largest;
                largest = arr[i];
            }

            else if (arr[i].getPrice() > second.getPrice() && arr[i].getPrice() != largest.getPrice())
                second = arr[i];
        }

        return new Winner(largest.getName(), second.getPrice());
    }
}
