package com.brianna.dojoandninja.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.brianna.dojoandninja.models.Ninja;
import com.brianna.dojoandninja.repositories.NinjaRepo;

@Service
public class NinjaServ {
	@Autowired
	private NinjaRepo ninjaRepo;
	
	public List<Ninja> getAllNinja(){
		return ninjaRepo.findAll();
	}
	
	public Ninja createNinja(Ninja n) {
		return ninjaRepo.save(n);
	}
}
