package com.brianna.contact.controllers;

import java.util.List;

import javax.validation.Valid;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.brianna.contact.models.Contact;
import com.brianna.contact.services.ContactService;

@Controller
public class MainController {
	// ==========================
	//  FIELD
	//==========================
		//creating accessible service
	private final ContactService contactService;
	// ==========================
	//  CONSTRUCTOR
	//==========================
	public MainController(ContactService contactService) {
		this.contactService = contactService;
	}
	
	@RequestMapping("/")
	public String index(Model model) {
		
		//getting all contacts
		List<Contact> contacts = contactService.allContacts();
		//bring info to jsp
		model.addAttribute("ViewContacts", contacts);
		
		return "index.jsp";
	}
	
	@PostMapping("/addFriend")
	public String addFriend
	(@Valid @ModelAttribute("contact") Contact contact, BindingResult result) 
	{
		if(result.hasErrors()){
			return "index.jsp";
		} else {
			contactService.createContact(contact);
			return "redirect:/";
		}
		
	}
}
