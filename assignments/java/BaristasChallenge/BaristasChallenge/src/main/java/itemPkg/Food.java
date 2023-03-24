package itemPkg;

import Interface.Temp;

public class Food extends Item implements Temp{
	private String flavor;
	private boolean glutenFree;
	
	
	public Food(String name, double price, String flavor) {
		super(name, price);
		// TODO Auto-generated constructor stub
		this.flavor =flavor;
		this.glutenFree = false;
	}
	// =========ATTRIBUTES=========


	public String getFlavor() {
		return flavor;
	}


	public void setFlavor(String flavor) {
		this.flavor = flavor;
	}


	public boolean isGlutenFree() {
		return glutenFree;
	}


	public void setGlutenFree(boolean glutenFree) {
		this.glutenFree = glutenFree;
	}

	public void displayItem() {
		super.displayItem();
		System.out.printf("\t%s is  %s. Gluten Free is %s." ,this.getName(), this.flavor, this.glutenFree);
	}

	@Override
	public void hot() {
		// TODO Auto-generated method stub
		System.out.printf("%s is served hot", this.getName());
		
	}


	@Override
	public void cold() {
		// TODO Auto-generated method stub
		System.out.printf("%s is served cold", this.getName());
	}


	@Override
	public void warm() {
		// TODO Auto-generated method stub
		System.out.printf("%s is served warmed", this.getName());
	}
	
	// =========CONSTRUCTOR=========
	
	// =========CONSTRUCTOR=========
	
	// =========CONSTRUCTOR=========
}
