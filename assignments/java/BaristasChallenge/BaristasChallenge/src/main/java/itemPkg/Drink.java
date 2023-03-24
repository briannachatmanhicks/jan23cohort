package itemPkg;

import Interface.Temp;

public class Drink extends Item implements Temp{
	
// =========DRINK ATTRIBUTES=========
	private String flavor;
	private String size;

	public Drink(String name, double price, String flavor, String size) {
		super(name, price);
		// TODO Auto-generated constructor stub
		this.flavor = flavor;
		this.size = size;
	}

	public String getFlavor() {
		return flavor;
	}

	public void setFlavor(String flavor) {
		this.flavor = flavor;
	}

	public String getSize() {
		return size;
	}

	public void setSize(String size) {
		this.size = size;
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

	
	
	

}
