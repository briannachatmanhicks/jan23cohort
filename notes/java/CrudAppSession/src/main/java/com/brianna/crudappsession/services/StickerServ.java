package com.brianna.crudappsession.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.brianna.crudappsession.models.Sticker;
import com.brianna.crudappsession.repositories.StickerRepo;

@Service
public class StickerServ {
	@Autowired
	private StickerRepo stickRepo;
	
    // ==========================
    //        CREATE
    // ==========================
	public Sticker createOne(Sticker s) {
		return stickRepo.save(s);
	}
    // ==========================
    //        READ
    // ==========================
	public List<Sticker> getAll(){
		return stickRepo.findAll();
	}
	public Sticker getOne(Long id) {
		return stickRepo.findById(id).orElse(null);
	}
    // ==========================
    //        UPDATE
    // ==========================
	public Sticker updateOne(Sticker s) {
		return stickRepo.save(s);
	}
    // ==========================
    //        DELETE
    // ==========================
	public void deleteOne(Long id) {
		stickRepo.deleteById(id);	}
	
}
