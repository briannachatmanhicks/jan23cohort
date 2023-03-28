package com.brianna.caresoftinterfaces;

import java.util.ArrayList;
import java.util.Date;

public class Physician extends User implements HIPAAComplaintUser{
    // Inside class:    
    private ArrayList<String> patientNotes;
	
    // TO DO: Constructor that takes an ID
    public Physician(Integer id){
    		super(id);
    }
    // TO DO: Implement HIPAACompliantUser!
	
    public void newPatientNotes(String notes, String patientName, Date date) {
        String report = String.format(
            "Datetime Submitted: %s \n", date);
        report += String.format("Reported By ID: %s\n", this.id);
        report += String.format("Patient Name: %s\n", patientName);
        report += String.format("Notes: %s \n", notes);
        this.patientNotes.add(report);
    }

	@Override
	public boolean assignPin(int pin) {
		// TODO Auto-generated method stub
		String checkPin = Integer.toString(pin); // convert int to string
	    if (checkPin.length() != 4) {
	        return false; // pin is not 4 digits
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
		
		if(this.getId() == confirmedAuthID) {
			return true;
		}
		return false;
	}

	// TO DO: Setters & Getters
	public ArrayList<String> getPatientNotes() {
		return patientNotes;
	}

	public void setPatientNotes(ArrayList<String> patientNotes) {
		this.patientNotes = patientNotes;
	}
	
    
	
	
}
