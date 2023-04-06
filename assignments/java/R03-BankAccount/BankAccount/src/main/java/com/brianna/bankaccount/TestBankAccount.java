package com.brianna.bankaccount;

public class TestBankAccount {
public static void main(String[] args) {
	System.out.println("HELLO");
	BankAccount brianna = new BankAccount();
	
	brianna.setCheckingBalance(3000.5);
	brianna.setSavingsBalance(200.2);
	System.out.println("-------------------------------------");
	brianna.getCheckingBalance();
	brianna.getSavingsBalance();
	System.out.println("\n-------------------------------------");
	brianna.addCheckingBalance(50);
	brianna.addSavingBalance(40);
	brianna.getCheckingBalance();
	brianna.getSavingsBalance();
	System.out.println("\n-------------------------------------");
	brianna.withdrawSaving(3000);
	brianna.getSavingsBalance();
	brianna.withdrawSaving(100);
	brianna.getSavingsBalance();
	System.out.println("\n-------------------------------------");
	brianna.getTotalBalance();
	BankAccount.getNumberOfAccounts();
	
}
}
