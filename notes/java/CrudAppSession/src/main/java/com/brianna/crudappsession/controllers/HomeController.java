package com.brianna.crudappsession.controllers;

import javax.servlet.http.HttpSession;
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

import com.brianna.crudappsession.models.Category;
import com.brianna.crudappsession.models.Sticker;
import com.brianna.crudappsession.services.CategoryServ;
import com.brianna.crudappsession.services.StickerServ;

@Controller
public class HomeController {
	@Autowired
	private CategoryServ catServ;
	@Autowired
	private StickerServ stickServ;
	
    // ==========================
    //        Main Routes
    // ==========================
	@GetMapping("/")
	public String index(@ModelAttribute("sticker") Sticker sticker,Model model) {
		model.addAttribute("allStickers", stickServ.getAll());
		return "index.jsp";
	}
	
	@GetMapping("/dashboard")
	public String dashboard(HttpSession session, Model model) {
		if(session.getAttribute("catId") == null) {
			return "redirect:/";
		}else {
			model.addAttribute("aCat", catServ.getOne((Long)session.getAttribute("catId")));
			return "dashboard.jsp";
		}
	}
	
    // ==========================
    //        Category Routes
    // ==========================
	@GetMapping("/addcategory")
	public String addCat(@ModelAttribute("catForm") Category cat) {
		return "addCat.jsp";
	}
	
	@PostMapping("/createcategory")
	public String createCat(@Valid  @ModelAttribute("catForm") Category newCat, BindingResult result, Model model, HttpSession session) {
		if(result.hasErrors()) {
			return "addCat.jsp";
		}else {
			catServ.createOne(newCat);
			session.setAttribute("catId", newCat.getId());
			return "redirect:/dashboard";
		}
	}
    // ==========================
    //        Sticker Routes
    // ==========================
	@GetMapping("/addsticker")
	public String addSticker(@ModelAttribute("stickerForm") Sticker sticker, Model model) {
		model.addAttribute("allCats", catServ.getAll());
		return "addStick.jsp";
	}
	
	@PostMapping("/createsticker")
	public String creatStick(@Valid @ModelAttribute("stickerForm") Sticker newSticker, BindingResult result, Model model) {
		if(result.hasErrors()) {
			model.addAttribute("allCats", catServ.getAll());
			return "addStick.jsp";
		}else {
			stickServ.createOne(newSticker);
			return "redirect:/dashboard";
		}
	}
	
	@GetMapping("/sticker/{id}/edit")
	public String editStick(@PathVariable("id") Long id, @ModelAttribute("editStickForm") Sticker sticker, Model model) {
		model.addAttribute("s", stickServ.getOne(id));
		model.addAttribute("allCats", catServ.getAll());
		return "editStick.jsp";
	}
	
	@PutMapping("/sticker/{id}/update")
	public String updateStick(@PathVariable("id") Long id, @Valid @ModelAttribute("editStickForm") Sticker editSticker, BindingResult result, Model model) {
		model.addAttribute("allCats", catServ.getAll());
		if(result.hasErrors()) {
			model.addAttribute("s", stickServ.getOne(id));
			return "editStick.jsp";
		}else {
			stickServ.updateOne(editSticker);
			return "redirect:/";
		}
	}
	
	@GetMapping("/sticker/{id}/delete")
	public String deleteStick(@PathVariable("id") Long id) {
		stickServ.deleteOne(id);
		return "redirect:/";
	}
	
	
	
	
}
