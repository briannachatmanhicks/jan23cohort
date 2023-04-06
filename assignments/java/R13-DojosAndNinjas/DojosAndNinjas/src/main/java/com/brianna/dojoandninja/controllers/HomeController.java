package com.brianna.dojoandninja.controllers;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;

import com.brianna.dojoandninja.models.Dojo;
import com.brianna.dojoandninja.models.Ninja;
import com.brianna.dojoandninja.services.DojoServ;
import com.brianna.dojoandninja.services.NinjaServ;

@Controller
public class HomeController {
	@Autowired
	private DojoServ dojoServ;
	@Autowired
	private NinjaServ ninjaServ;
	
	@GetMapping("/dojos/new")
	public String newDojo(@ModelAttribute("dojoForm") Dojo dojo) {
		return "newDojo.jsp";
	}
	
	@PostMapping("/dojos/post")
	public String postDojo(@Valid @ModelAttribute("dojoForm") Dojo dojo, BindingResult result, Model model) {
		if(result.hasErrors()) {
			return "newDojo.jsp";
		}else { 
			dojoServ.createDojo(dojo);
			return "redirect:/";
		}
	}
	
	@GetMapping("/ninjas/new")
	public String newNinja(@ModelAttribute("ninjaForm") Ninja n, Model model) {
		model.addAttribute("allDojos", dojoServ.getAllDojo());
		return "newNinja.jsp";
	}
	
	@PostMapping("/ninjas/post")
	public String postNinja(@Valid @ModelAttribute("ninjaForm") Ninja n, BindingResult result, Model model) {
		if(result.hasErrors()) {
			model.addAttribute("allDojos", dojoServ.getAllDojo());
			return  "newNinja.jsp";
		}else {
			ninjaServ.createNinja(n);
			return "redirect:/";
		}
	}
		
	@GetMapping("/dojos/{id}")
	public String dojoNinjas(@PathVariable("id") Long id, @ModelAttribute("dojo") Dojo dojo, Model model) {
		model.addAttribute("viewDojo", dojoServ.getADojo(id));
		return "dojoListofNinjas.jsp";
	}
}
