package com.brianna.crudappsession.repositories;

import java.util.List;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.brianna.crudappsession.models.Sticker;

@Repository
public interface StickerRepo extends CrudRepository <Sticker, Long> {
	
	List<Sticker> findAll();
}
