package com.brianna.burgertracki.controllers;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;

import com.brianna.burgertracki.models.Burger;
import com.brianna.burgertracki.services.BurgerService;

@Controller
public class BurgerController {
	@Autowired
	BurgerService burgerServ;
	
	@GetMapping("/")
	public String home(@ModelAttribute("burger") Burger burger, Model model) {
		model.addAttribute("allBurgers", burgerServ.allBurgers());
		return "index.jsp";
	}
	
	@PostMapping("/createburg")
	public String create(@Valid @ModelAttribute("burger") Burger burger, BindingResult result, Model model) {
		if(result.hasErrors()) {
			model.addAttribute("allBurgers", burgerServ.allBurgers());
			return "index.jsp";
			
		}else {
			burgerServ.createBurger(burger);
			return "redirect:/";
		}
	}
	
	@GetMapping("/edit/{id}")
	public String editItem(@PathVariable("id") Long id, @ModelAttribute("updateForm") Burger burger, Model model) {
		model.addAttribute("burger", burgerServ.findBurger(id));
		return "show.jsp";
	}
	
	@PutMapping("/update/{id}")
	public String updateItem(@PathVariable("id") Long id, @Valid @ModelAttribute("updateForm") Burger burger, BindingResult result, Model model) {
		if(result.hasErrors()) {
			model.addAttribute("burger", burgerServ.findBurger(id)); // re-populates the original burger if validations are tripped
			return "show.jsp";
		}else {
			burgerServ.updateBurger(burger);//actually updated the burger
			return "redirect:/";
		}
	}

	
}
