package itemPkg;

import java.util.ArrayList;

public class Order {

	private String name;
	private double total;
	private boolean ready;
	private ArrayList<Item> items;
	
// =========CONSTRUCTOR=========
	public Order(String name) {
		super();
		this.name = name;
		this.total = 0.0;
		this.ready = false;
		this.items = new ArrayList<>();
	
	}
	
	//# Overloading
	public Order() {
		this.name = "The user has not added the name yet";
		this.total = 0.0;
		this.ready = false;
		this.items = new ArrayList<>();
	}
// =========METHODS=========
	// Add items to list regardless of how much is being ordered
	//change total
	public Item addItem(Item newItem) {
		this.items.add(newItem);
		this.total += newItem.getPrice();
		return newItem;
	}
	// print order info with not ready if false or ready if true
	public void displayOrder() {
		String status = (this.ready ? "order is ready" : "order is in progress");
//		if(this.ready == true) {
//			status = "order is ready";
//		}else {
//			status = "order is in progress";
//		}
		System.out.printf("%s your %s%n \n Your order is:", this.name, status);
		for(Item i : this.items) {
			i.displayItem();
		}
		System.out.printf("Total: %.2f\n", this.total);
	}
// =========GETTERS & SETTERS=========
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	
	

	public double getTotal() {
		return total;
	}

	public void setTotal(double total) {
		this.total = total;
	}

	public boolean isReady() {
		return ready;
	}

	public void setReady(boolean ready) {
		this.ready = ready;
	}

	public ArrayList<Item> getItems() {
		return items;
	}

	public void setItems(ArrayList<Item> items) {
		this.items = items;
	}
	
	public Item getItem(int index) {
		return items.get(index);
	}
	public void setItem(Item item) {
		this.items.add(item);
	}
	
	
}
