package com.codingdojo.com.baristaschallenge;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import itemPkg.Drink;
import itemPkg.Food;
import itemPkg.Item;
import itemPkg.Order;

@SpringBootApplication
public class BaristasChallengeApplication {
	
	public static void main(String[] args) {
		//============= THIS IS FROM WORKING ON IT THE FIRST DAY============ //
		
		
//		// == Initial Test ==
//		Item item01 = new Item("Large Coffee", 2.75);
//		System.out.println(item01);
//		System.out.printf("\t%s %.2f\n", item01.getName(), item01.getPrice());
//		
//		item01.displayItem();
//		
//		
//		Order  = new Order ("");
//		dana.setItem(item01);
//		dana.addItem(item01);
//		dana.addItem(item01);
//		dana.displayOrder();
		
		Food bagel =  new Food("Bagel", 3.75, "Plain");
		Drink frap = new Drink("Frappuccino",5.89,"Vanilla","Large");
		
		
		bagel.addFood(bagel);
		frap.addDrink(frap);
		
		bagel.displayItem();
		
		Order sierra = new Order("Sierra");
		sierra.addItem(frap);
		frap.cold();
		bagel.warm();
		sierra.addItem(bagel);
		

		
		
		
		
		
		
		
		
		
		
		
		
		
		SpringApplication.run(BaristasChallengeApplication.class, args);
	}

}
