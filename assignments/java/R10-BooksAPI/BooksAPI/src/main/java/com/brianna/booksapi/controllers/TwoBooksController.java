package com.brianna.booksapi.controllers;

import java.util.List;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;

import com.brianna.booksapi.models.Book;
import com.brianna.booksapi.services.BookService;

@Controller
public class TwoBooksController {
	
	private final BookService bookService;
	public TwoBooksController(BookService bookService) {
		this.bookService = bookService;
	}
	//ANOTHER WAY TO DO THE ABOVE
//	@Autowired
//	BookService bookService;
	
	@GetMapping("/")
	public String home() {
		return "redirect:/books";
	}
	
	@GetMapping("/books")
	public String index(Model model) {
		
		List<Book> books = bookService.allBooks();
        model.addAttribute("books", books);
        return "index.jsp";
	}
	
	@GetMapping("/books/{id}")
	public String showOne(Model model, @PathVariable("id") Long id) {
		Book book = bookService.findBook(id);
		model.addAttribute("book", book);
		return "show.jsp";
	}
}
