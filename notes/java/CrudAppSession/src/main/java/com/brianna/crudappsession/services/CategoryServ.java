package com.brianna.crudappsession.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.brianna.crudappsession.models.Category;
import com.brianna.crudappsession.repositories.CategoryRepo;

@Service
public class CategoryServ {
	@Autowired
	private CategoryRepo catRepo;
	
    // ==========================
    //        CREATE
    // ==========================
	public Category createOne(Category c) {
		return catRepo.save(c);
	}
    // ==========================
    //        READ
    // ==========================
	public List<Category> getAll(){
		return catRepo.findAll();
	}
	public Category getOne(Long id) {
		return catRepo.findById(id).orElse(null);
	}
    // ==========================
    //        UPDATE
    // ==========================
	public Category updateOne(Category c) {
		return catRepo.save(c);
	}
    // ==========================
    //        DELETE
    // ==========================
	public void deleteOne(Long id) {
		catRepo.deleteById(id);	}
	
}
