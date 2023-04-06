package com.brianna.zookeeper;

public class Gorilla extends Mammal{
//	private String name;
	
	public Gorilla() {
//		this.name = name;
	}
	
	public void throwSomething() {
		int energy = this.getEnergyLevel();
		energy = energy -5;
		this.setEnergyLevel(energy);
		
		System.out.printf("\nThis Gorilla threw something! Energy has decreased by 5 to %d",energy);
	}
	public void eatBananas() {
		int energy = this.getEnergyLevel();
		energy = energy +10;
		this.setEnergyLevel(energy);
		
		System.out.printf("\nThis Gorilla ate some bananas. Energy has increased by 10 to %d",energy);
	}
	public void climb() {
		int energy = this.getEnergyLevel();
		energy = energy -10;
		this.setEnergyLevel(energy);
		
		System.out.printf("\nThis Gorilla climbed a tree! Energy has decreased by 10 to %d",energy);
	}
}
