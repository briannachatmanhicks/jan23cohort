package com.brianna.caresoftinterfaces;

import java.util.ArrayList;
import java.util.Date;

public class AdminUser extends User implements HIPAAComplaintUser, HIPAAComplaintAdmin{
    
	private Integer employeeID;
    private String role;
    private ArrayList<String> securityIncidents = new ArrayList<String>();
    
    // TO DO: Implement a constructor that takes an ID and a role
    public AdminUser(Integer id, String role) {
		super(id);
		this.role = role;
		
		// TODO Auto-generated constructor stub
	}
    // TO DO: Implement HIPAACompliantUser!
    // TO DO: Implement HIPAACompliantAdmin!
    
    public void newIncident(String notes) {
        String report = String.format(
            "Datetime Submitted: %s \n,  Reported By ID: %s\n Notes: %s \n", 
            new Date(), this.id, notes
        );
        securityIncidents.add(report);
    }
    public void authIncident() {
        String report = String.format(
            "Datetime Submitted: %s \n,  ID: %s\n Notes: %s \n", 
            new Date(), this.id, "AUTHORIZATION ATTEMPT FAILED FOR THIS USER"
        );
        securityIncidents.add(report);
    }
	@Override
	public ArrayList<String> reportSecurityIncidents() {
		// TODO Auto-generated method stub
		return securityIncidents;
	}
	@Override
	public boolean assignPin(int pin) {
		// TODO Auto-generated method stub
		String checkPin = Integer.toString(pin); // convert int to string
	    if (checkPin.length() < 6) {
	        return false; // pin has to be at least 6 digits
	    }
	    for (int i = 0; i < 4; i++) {
	        if (!Character.isDigit(checkPin.charAt(i))) {
	            return false; // pin contains non-digit character(s)
	        }
	    }
	    this.setPin(pin);
		return true;
	}
	@Override
	public boolean accessAuthorized(Integer confirmedAuthID) {
		// TODO Auto-generated method stub
		
		if(this.id == confirmedAuthID) {
			return true;
		}else {
//		System.out.println("I am about to add a  string to securityIncidents");
		this.authIncident();
		return false;}
	}
    // TO DO: Setters & Getters
	public Integer getEmployeeID() {
		return employeeID;
	}

	public void setEmployeeID(Integer employeeID) {
		this.employeeID = employeeID;
	}

	public String getRole() {
		return role;
	}

	public void setRole(String role) {
		this.role = role;
	}

	public ArrayList<String> getSecurityIncidents() {
		return securityIncidents;
	}

	public void setSecurityIncidents(ArrayList<String> securityIncidents) {
		this.securityIncidents = securityIncidents;
	}
    

}
