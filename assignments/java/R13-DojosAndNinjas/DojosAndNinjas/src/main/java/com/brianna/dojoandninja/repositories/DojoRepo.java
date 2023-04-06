package com.brianna.dojoandninja.repositories;

import java.util.List;

import org.springframework.data.repository.CrudRepository;

import com.brianna.dojoandninja.models.Dojo;

public interface DojoRepo extends CrudRepository<Dojo, Long>{
	List<Dojo> findAll();
}
