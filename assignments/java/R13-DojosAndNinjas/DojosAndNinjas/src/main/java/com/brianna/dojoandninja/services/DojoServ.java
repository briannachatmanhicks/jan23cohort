package com.brianna.dojoandninja.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.brianna.dojoandninja.models.Dojo;
import com.brianna.dojoandninja.repositories.DojoRepo;

@Service
public class DojoServ {
	@Autowired
	private DojoRepo dojoRepo;
	
	public Dojo getADojo(Long id) {
		return dojoRepo.findById(id).orElse(null);
	}
	
	public Dojo createDojo(Dojo d) {
		return dojoRepo.save(d);
	}
	
	public List<Dojo> getAllDojo(){
		return dojoRepo.findAll();	}
}
