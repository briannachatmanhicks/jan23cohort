package com.brianna.bankaccount;

public class BankAccount {
	
	private double checkingBalance;
	private double savingsBalance;
	
	public static int numberOfAccounts = 0;
	public static double totalBalance;
	
	public BankAccount() {
		this.checkingBalance = 0.0;
		this.savingsBalance = 0.0;
		numberOfAccounts += 1;
		totalBalance = this.checkingBalance + this.savingsBalance;
	}

	public double getCheckingBalance() {
		System.out.printf("\n This account has a checking balance of %.2f" , this.checkingBalance);
		return checkingBalance;
	}

	public void setCheckingBalance(double checkingBalance) {
		this.checkingBalance = checkingBalance;
	}

	public double getSavingsBalance() {
		System.out.printf("\n This account has a savings balance of %.2f" , this.savingsBalance);
		return savingsBalance;
	}

	public void setSavingsBalance(double savingsBalance) {
		this.savingsBalance = savingsBalance;
	}
	
	public static int getNumberOfAccounts() {
		System.out.printf("\n There are %d current open accounts", numberOfAccounts);
		return numberOfAccounts;
	}

//	public static void setNumberOfAccounts(int numberOfAccounts) {
//		BankAccount.numberOfAccounts = numberOfAccounts;
//	}

	public double getTotalBalance() {
		System.out.printf("\n The totoal balance between accounts is %.2f", totalBalance);
		return totalBalance;
	}

//	public static void setTotalBalance(double totalBalance) {
//		BankAccount.totalBalance = totalBalance;
//	}
	
	
	
	public double addCheckingBalance(double deposit) {
//		double currentBal = this.checkingBalance;
		totalBalance = this.checkingBalance + this.savingsBalance + deposit;
		this.checkingBalance += deposit;
		return this.checkingBalance;
	}
	
	public double addSavingBalance(double deposit) {
		totalBalance = this.checkingBalance + this.savingsBalance + deposit;
		this.savingsBalance += deposit;
		return this.savingsBalance;
	}
	
	public double withdrawSaving(double amt) {
		if(this.savingsBalance < amt) {
			return this.savingsBalance;
		}else {
			totalBalance = this.checkingBalance + this.savingsBalance - amt;
			this.savingsBalance -= amt;
			return this.savingsBalance;
		}
	}

	
	
}









