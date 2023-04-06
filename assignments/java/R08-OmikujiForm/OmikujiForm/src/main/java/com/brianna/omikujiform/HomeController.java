package com.brianna.omikujiform;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HomeController {
	@RequestMapping("")
	public String index() {
		return "index.jsp";
	}
	
	@PostMapping("/submitForm")
	public String post(
		@RequestParam("num") Integer num,
		@RequestParam("city") String city,
		@RequestParam("person") String person,
		@RequestParam("hobby") String hobby,
		@RequestParam("livingThing") String livingThing,
		@RequestParam("somethingNice") String somethingNice,
		HttpSession session
		){
		
		session.setAttribute("n", num);
		session.setAttribute("c", city);
		session.setAttribute("p", person);
		session.setAttribute("h", hobby);
		session.setAttribute("lT", livingThing);
		session.setAttribute("sN", somethingNice);
		return "redirect:/show";
	}
	
	@RequestMapping("/show")
	public String showForm() {
		return "show.jsp";
	}
}
