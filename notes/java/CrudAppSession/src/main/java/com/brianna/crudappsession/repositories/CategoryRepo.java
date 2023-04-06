package com.brianna.crudappsession.repositories;

import java.util.List;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.brianna.crudappsession.models.Category;

@Repository
public interface CategoryRepo extends CrudRepository <Category, Long>{

	List<Category> findAll();
}
