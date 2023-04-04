package com.brianna.burgertracki.repositories;

import java.util.List;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.brianna.burgertracki.models.Burger;
//WHAT DOES THIS CONNECT TO? CHECK BOOKSAPI ASSIGNMENT FOR INFORMATION ON THE RELATIONSHIP BETWEEN 
@Repository
public interface BurgerRepo extends CrudRepository<Burger,Long>{
	List<Burger> findAll();
}
