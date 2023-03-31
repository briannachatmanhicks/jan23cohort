package com.brianna.contact.repositories;

import java.util.List;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.brianna.contact.models.Contact;

@Repository
public interface ContactRepository extends CrudRepository<Contact, Long>{
//Model gets imported here
	List<Contact> findAll();
	
//Repo gets "exported" to ContactService
	
}
