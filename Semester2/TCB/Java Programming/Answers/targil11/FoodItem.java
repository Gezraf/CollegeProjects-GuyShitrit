
public class FoodItem {
    private String name; // שם מוצר
    private int quantity; // כמות המוצר במלאי
    private Date productionDate;
    private Date expiryDate;
    private int minTemperature;
    private int maxTemperature;
    private double price;


    public FoodItem(String name, int quantity, Date productionDate, Date expiryDate, int minTemperature, int maxTemperature, double price) { // פעולה בונה
        this.name = name;
        this.quantity = quantity;
        this.productionDate = productionDate;
        this.expiryDate = expiryDate;
        this.minTemperature = minTemperature;
        this.maxTemperature = maxTemperature;
        this.price = price;
    }


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public Date getProductionDate() {
        return productionDate;
    }

    public Date getExpiryDate() {
        return expiryDate;
    }

    public int getMinTemperature() {
        return minTemperature;
    }

    public void setMinTemperature(int minTemperature) {
        this.minTemperature = minTemperature;
    }

    public int getMaxTemperature() {
        return maxTemperature;
    }

    public void setMaxTemperature(int maxTemperature) {
        this.maxTemperature = maxTemperature;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    // נניח ש()toString קיים כי אני לא יודע איך הפלט אמור להיראות


    public boolean isFresh(Date d) {
        return (!d.before(this.productionDate) && d.before(this.expiryDate));
    }

    public int howManyItems(int money) {
        if (money < this.price)
            return 0;

        if (money >= this.price * this.quantity)
            return this.quantity;

        return (int) (money / this.price);
    }
}

