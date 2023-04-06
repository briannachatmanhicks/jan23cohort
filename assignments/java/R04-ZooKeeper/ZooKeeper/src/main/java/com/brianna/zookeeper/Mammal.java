package com.brianna.zookeeper;

public class Mammal {
	private int energyLevel;
	
	public Mammal() {
		this.setEnergyLevel(100);
	}
	
	

	public int getEnergyLevel() {
		System.out.printf("\nThis mammal's current energy level is %d", this.energyLevel);
		return energyLevel;
	}

	public void setEnergyLevel(int energyLevel) {
		this.energyLevel = energyLevel;
	}
}
