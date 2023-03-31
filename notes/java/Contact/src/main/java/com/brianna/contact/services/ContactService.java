package com.brianna.contact.services;

import java.util.List;

import org.springframework.stereotype.Service;

import com.brianna.contact.models.Contact;
import com.brianna.contact.repositories.ContactRepository;

@Service
public class ContactService {
	// ==========================
	//  FIELD
	//===========================
		//adding the repo dependency
	private final ContactRepository contactRepo;
	// ==========================
	//  CONSTRUCTOR
	//==========================
		//enables us to use CrudRepository library of pre-written  code
	public ContactService(ContactRepository contactRepo) {
		this.contactRepo = contactRepo;
	}
	
	// ==========================
	//  METHODS
	//==========================
	
	
	//CREATE
	public Contact createContact(Contact c) {
		return contactRepo.save(c);
	}
	//FIND ALL
	public List<Contact> allContacts() {
		return contactRepo.findAll();
	}
}
