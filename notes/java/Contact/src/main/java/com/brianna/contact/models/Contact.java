package com.brianna.contact.models;

import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.PrePersist;
import javax.persistence.PreUpdate;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

import org.springframework.format.annotation.DateTimeFormat;
@Entity
@Table(name="contacts")
public class Contact {
	// ==========================
	//  ATTRIBUTES
	//==========================
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	
	@NotNull
	@Size(min = 5, max = 200)
	private String name;
	
	@NotNull
	@Size(min = 5, max = 200)
	private String bio;
	
	@NotNull
	@Size(min = 5, max = 200)
	private String address;
	
	@DateTimeFormat(pattern="yyyy-MM-dd")
	@Column(updatable=false)
	private Date createdAt;
	
	@DateTimeFormat(pattern="yyyy-MM-dd")
	private Date updatedAt;
	
	
    // ==========================
    //        CONSTRUCTOR
    // ==========================
    public Contact(@NotNull @Size(min = 5, max = 200) String name, @NotNull @Size(min = 5, max = 200) String bio,
			@NotNull @Size(min = 5, max = 200) String address) {
		super();
		this.name = name;
		this.bio = bio;
		this.address = address;
	}
    
    //EMPTY CONSTRUCTOR NEEDED
  	public Contact() {
  		
  	}
    
    // ==========================
    //     GETTERS / SETTERS
    // ==========================
	public Long getId() {
		return id;
	}


	public void setId(Long id) {
		this.id = id;
	}


	public String getName() {
		return name;
	}


	public void setName(String name) {
		this.name = name;
	}


	public String getBio() {
		return bio;
	}


	public void setBio(String bio) {
		this.bio = bio;
	}


	public String getAddress() {
		return address;
	}


	public void setAddress(String address) {
		this.address = address;
	}


	public Date getCreatedAt() {
		return createdAt;
	}


	public void setCreatedAt(Date createdAt) {
		this.createdAt = createdAt;
	}


	public Date getUpdatedAt() {
		return updatedAt;
	}


	public void setUpdatedAt(Date updatedAt) {
		this.updatedAt = updatedAt;
	}

//THIS IS NEEDED FOR CREATED AT AND UPDATED AT TO BE POSSIBLE!!
	@PrePersist
    protected void onCreate(){
        this.createdAt = new Date();
    }
    @PreUpdate
    protected void onUpdate(){
        this.updatedAt = new Date();
    }
}
