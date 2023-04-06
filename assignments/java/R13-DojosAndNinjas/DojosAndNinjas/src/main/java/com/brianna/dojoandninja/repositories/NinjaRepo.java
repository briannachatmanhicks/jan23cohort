package com.brianna.dojoandninja.repositories;

import java.util.List;
import java.util.Locale.Category;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.brianna.dojoandninja.models.Ninja;

@Repository
public interface NinjaRepo extends CrudRepository<Ninja, Long>{
	List<Ninja> findAll();
}
