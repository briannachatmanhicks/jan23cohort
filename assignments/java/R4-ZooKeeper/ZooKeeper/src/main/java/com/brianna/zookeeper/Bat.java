package com.brianna.zookeeper;

public class Bat extends Mammal{
	
	public Bat() {
		this.setEnergyLevel(300);
	}
	
	public void fly() {
		int energy = this.getEnergyLevel();
		energy = energy -50;
		this.setEnergyLevel(energy);
		
		System.out.println("\nCACAWWWWW");
	}

	public void eatHumans() {
		int energy = this.getEnergyLevel();
		energy = energy + 25;
		this.setEnergyLevel(energy);
		
		System.out.println("\nDid you see that bat just eat a human?!!!");
	}
	
	public void attackTown() {
		int energy = this.getEnergyLevel();
		energy = energy -100;
		this.setEnergyLevel(energy);
		
		System.out.println("\nAHHASLKASJOFISDHKAJALKJFLK");
	}
	
	
	
}
