package itemPkg;

import java.util.ArrayList;

public abstract class Item {
	
	public static ArrayList<Item> menu = new ArrayList<>();
	
	private String name;
	private double price;
	
// 	=========
//		CONSTRUCTOR
//	=========	
	public Item(String name, double price) {
		super();
		this.setName(name);
		this.setPrice(price);
	}
	
	
// 	=========
//	 	METHODS
// 	=========
	public void displayItem() {
		System.out.printf("\t%s %.2f\n", this.name, this.price);
	}
	
	
	public Item addFood(Food newFood) {
		Item.menu.add(newFood);
		return newFood;
	}
	
	public Item addDrink (Drink newDrink) {
		Item.menu.add(newDrink);
		return newDrink;
	}
	
// =========GETTERS & SETTERS=========
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}
	
	//Can I take notes in here like in VS code??
	
}
