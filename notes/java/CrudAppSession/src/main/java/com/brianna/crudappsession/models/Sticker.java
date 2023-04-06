package com.brianna.crudappsession.models;

import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.PrePersist;
import javax.persistence.PreUpdate;
import javax.persistence.Table;
import javax.validation.constraints.NotEmpty;
import javax.validation.constraints.Size;

import org.springframework.format.annotation.DateTimeFormat;

@Entity
@Table(name="stickers")
public class Sticker {
    // ==========================
    //        ATTRIBUTES
    // ==========================
	@Id
	@GeneratedValue(strategy= GenerationType.IDENTITY)
	private Long id;
	
	@NotEmpty(message="Must have a name")
	@Size(min=5, max=200)
	private String name;
	
	@NotEmpty(message="URL is required")
	@Size(min=20)
	private String URL;
	
	
    @Column(updatable = false)
	@DateTimeFormat(pattern = "yyy-MM-dd")
	private Date createdAt;
	@DateTimeFormat(pattern = "yyy-MM-dd")
	private Date updatedAt;
	
    // ==========================
    //        RELATIONSHIPS
    // ==========================
	@ManyToOne(fetch= FetchType.LAZY)
	@JoinColumn(name="category_id")
	private Category theCat;
	

    
    // ==========================
    //        CONSTRUCTOR
    // ==========================
    public Sticker() {}
    
	public Sticker(@NotEmpty(message = "Must have a name") @Size(min = 5, max = 200) String name,
			@NotEmpty(message = "URL is required") @Size(min = 20) String uRL, Category theCat) {
		super();
		this.name = name;
		URL = uRL;
		this.theCat = theCat;
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
	public String getURL() {
		return URL;
	}
	public void setURL(String uRL) {
		URL = uRL;
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
	public Category getTheCat() {
		return theCat;
	}
	public void setTheCat(Category theCat) {
		this.theCat = theCat;
	}
    @PrePersist
    protected void onCreate() {
        this.createdAt = new Date();
    }
    @PreUpdate
    protected void onUpdate() {
        this.updatedAt = new Date();
    }

}
