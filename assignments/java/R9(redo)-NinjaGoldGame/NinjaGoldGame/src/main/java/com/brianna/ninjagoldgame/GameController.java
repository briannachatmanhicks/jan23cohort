package com.brianna.ninjagoldgame;

import java.time.LocalDateTime;
import java.util.ArrayList;
//import java.util.Date;
import java.util.concurrent.ThreadLocalRandom;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class GameController {
	
	
	@SuppressWarnings({ "unchecked", "unused" })
	@RequestMapping("/")
	public String index(	
	HttpSession Session
	) {
		Integer gold = 0;
		ArrayList<String> activities = new ArrayList<String>();
		
		if(Session.getAttribute("gold") == null)
		{
		Session.setAttribute("gold", gold);
		Session.setAttribute("activities", activities);}

		else {
			gold = (Integer)Session.getAttribute("gold");
			activities = (ArrayList<String>) Session.getAttribute("activities");
		}
		return "index.jsp";
	}
	
	
	@SuppressWarnings({ "unchecked", "unused" })
	@PostMapping("/submitFarm")
	public String postFarm(
			
	HttpSession Session,
	@RequestParam("farm") String farm
	) {
		
		if(farm != null) {
			Integer randomNumber = ThreadLocalRandom.current().nextInt(5, 10 + 1);
			System.out.print(randomNumber);
			Integer sessionGold = (Integer)Session.getAttribute("gold");
			ArrayList<String> sessionActivities = (ArrayList<String>)Session.getAttribute("activities");
			
			
			sessionGold += randomNumber;
			LocalDateTime time = LocalDateTime.now();
			sessionActivities.add("You entered a farm and earned "+randomNumber+" gold. ("+time+")");
			Session.setAttribute("gold", sessionGold);
			Session.setAttribute("activities", sessionActivities);
		}
		return "redirect:/index.jsp";
	}
	
	
	
	@PostMapping("/submitCave")
	public String postCave(
	@RequestParam("cave") Integer cave
	){
		
		return "index.jsp"; 
	}
	
	@PostMapping("/submitHouse")
	public String postHouse() {
		return "index.jsp";
	}
	
	@PostMapping("/submitQuest")
	public String postQuest() {
		return "index.jsp";
	}
}
