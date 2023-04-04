//package com.brianna.booksapi.controllers;
//
//import java.util.List;
//
//import org.springframework.web.bind.annotation.PathVariable;
//import org.springframework.web.bind.annotation.RequestMapping;
//import org.springframework.web.bind.annotation.RequestMethod;
//import org.springframework.web.bind.annotation.RequestParam;
//import org.springframework.web.bind.annotation.RestController;
//
//import com.brianna.booksapi.models.Book;
//import com.brianna.booksapi.services.BookService;
////HOMEOWNER has the final say
//@RestController
//public class BooksController {
//    private final BookService bookService;
//    public BooksController(BookService bookService){
//        this.bookService = bookService;
//    }
// 
//    // ==========================
//    //        READ ALL
//    // ==========================
//    @RequestMapping("/api/books")
//    public List<Book> index() {
//        return bookService.allBooks();
//    }
//    // ==========================
//    //        CREATE
//    // ==========================
//    @RequestMapping(value="/api/books", method=RequestMethod.POST)
//    public Book create(@RequestParam(value="title") String title, @RequestParam(value="description") String desc, @RequestParam(value="language") String lang, @RequestParam(value="pages") Integer numOfPages) {
//        Book book = new Book(title, desc, lang, numOfPages);
//        return bookService.createBook(book);
//    }
//    
//    // ==========================
//    //        READ ONE
//    // ==========================
//    @RequestMapping("/api/books/{id}")
//    public Book show(@PathVariable("id") Long id) {
//        Book book = bookService.findBook(id);
//        return book;
//    }
//    
//    // ==========================
//    //        UPDATE
//    // ==========================
//    @RequestMapping(value="/api/books/{id}", method=RequestMethod.PUT)
//    public Book update(
//    		@PathVariable("id") Long id, 
//    		@RequestParam(value="title") String title, 
//    		@RequestParam(value="description") String desc, 
//    		@RequestParam(value="language") String lang,
//    		@RequestParam(value="numberOfPages") Integer numOfPages) {
//        Book book = bookService.updateBook(id, title, desc, lang, numOfPages);
//        return book;
//    }
//    
//    
//    // ==========================
//    //        DELETE
//    // ==========================
//    @RequestMapping(value="/api/books/{id}", method=RequestMethod.DELETE)
//    public void destroy(@PathVariable("id") Long id) {
//        bookService.deleteBook(id);
//    }
//}
