package com.brianna.ninjagoldgame;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class GameController {
	@RequestMapping("/")
	public String index() {
		return "gameIndex.jsp";
	}
	
	@PostMapping("/submitFarm")
	public String postFarm(
	@RequestParam("farm") int farm
	) {
		return "gameIndex.jsp";
	}
	
	@PostMapping("/submitCave")
	public String postCave(
	@RequestParam("cave") Integer cave
	){
		
		return "gameIndex.jsp"; 
	}
	
	@PostMapping("/submitHouse")
	public String postHouse() {
		return "gameIndex.jsp";
	}
	
	@PostMapping("/submitQuest")
	public String postQuest() {
		return "gameIndex.jsp";
	}
}