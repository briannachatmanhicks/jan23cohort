package com.brianna.savetravels.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.brianna.savetravels.models.Expense;
import com.brianna.savetravels.repositories.ExpenseRepo;

@Service
public class ExpenseServ {
	@Autowired
	ExpenseRepo expenseRepo;
	
	public List<Expense> allExpenses(){
		return expenseRepo.findAll();
	}
	
	public Expense oneExpense(Long id) {
		return expenseRepo.findById(id).orElse(null);
	}
	
	public Expense createExpense(Expense e) {
		return expenseRepo.save(e);
	}
	
	public Expense updateExpense(Expense e) {
		return expenseRepo.save(e);
	}
	
	public void deleteExpense(Long id) {
		expenseRepo.deleteById(id);
	}
}
