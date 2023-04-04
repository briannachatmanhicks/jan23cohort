package com.brianna.burgertracki.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.brianna.burgertracki.models.Burger;
import com.brianna.burgertracki.repositories.BurgerRepo;

@Service
public class BurgerService {
	@Autowired
	BurgerRepo burgerRepo;
	
	public List<Burger> allBurgers(){
		return burgerRepo.findAll();
	}
	
	public Burger createBurger(Burger b) {
		return burgerRepo.save(b);
	}
	
	public void deleteBurger(Long id) {
		burgerRepo.deleteById(id);
	}
	
	public Burger findBurger(Long id) {
		Optional<Burger> optionalBurger = burgerRepo.findById(id);
		if(optionalBurger.isPresent()) {
			return optionalBurger.get();
		}else {
			return null;
		}
	}
	
	public Burger getBurger(Long id) {
		return burgerRepo.findById(id).orElse(null);
	}
	
//	public Burger updateBurger(Long id, String burgerName, String  restName, int rating, String notes) { 
//		Optional<Burger> optionalBurger = burgerRepo.findById(id);
//		
//		if (!optionalBurger.isPresent()) {
//			throw new RuntimeException("Book not found with id:" + id);
//		}
//		
//		Burger burger = optionalBurger.get();
//		burger.setBurgerName(burgerName);
//		burger.setRestName(restName);
//		burger.setRating(rating);
//		burger.setNotes(notes);
//		
//		return burger;
//	}
	
	//THIS ABOVE IS NO LONGER NEEDED BECAUSE OF THE BINDING RESULT IN THE CONTROLLER
	
	public Burger updateBurger(Burger b) {
		return burgerRepo.save(b);
	}
}
