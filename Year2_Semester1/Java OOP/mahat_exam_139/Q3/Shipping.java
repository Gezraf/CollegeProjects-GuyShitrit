public class Shipping {
    private String address;
    private Object[] arr;

    public double sum() {
        double total = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] instanceof Clothes) {
                Clothes c = (Clothes) arr[i];
                total = total + c.getPrice();
            }
            else if (arr[i] instanceof Book) {
                Book b = (Book) arr[i];
                total = total + b.getPrice();
            }
        }
        return total;
    }
}
