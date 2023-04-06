package com.brianna.cafebusinesslogic;

import java.util.ArrayList;
import java.util.Scanner;

public class CafeUtil {
	public void testing() {
		System.out.println("testing!! we are connected to the file now");
	}
	public int getStreakGoal(int numWeeks) {
		int total = 0;
		for (int i = 1; i <= numWeeks; i++) {
//			System.out.println(i);
			total += i;
		}
		
		return total;
	}
	
	public double getOrderTotal(double[] prices) {
		double total= 0.0;
		//enhanced for loop method
		for(double price : prices) {
			total += price;
		}	
		return total;
	}
	
	public void displayMenu(ArrayList<String> menuItems) {
		for(int i=0; i<menuItems.size(); i++) {
//			System.out.println(i);
			System.out.printf("%s %s \n" , i, menuItems.get(i));
		}
	}
	
	public void addCustomer(ArrayList<String> customers) {
		System.out.println("Please enter your name: ");
//		String userName = System.console().readLine();
		Scanner s = new Scanner(System.in);
		String userInput = s.next(); //prompts user for an input
		customers.add(userInput);
		
	}
}
