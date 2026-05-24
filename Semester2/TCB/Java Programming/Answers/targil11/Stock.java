
public class Stock {
    private FoodItem[] stock;
    private int numOfItems;


    public Stock() {
        this.stock = new FoodItem[100];
        this.numOfItems = 0;
    }

    public int howMany(int temp) {
        int count = 0;

        for(int i = 0; i < stock.length; i++) {
            boolean valid = stock[i].getMinTemperature() <= temp && temp <= stock[i].getMaxTemperature();
            if(valid) {
                count ++;
            }
        }

        return count;
    }


    public void removeAfterDate(Date d) {
        for (int i = 0; i < numOfItems; i++) {
            if (stock[i].getExpiryDate().before(d)) {
                for (int j = i; j < numOfItems - 1; j++) {
                    stock[j] = stock[j + 1];
                }

                stock[numOfItems - 1] = null;
                numOfItems--;
                i--;
            }
        }
    }
}

