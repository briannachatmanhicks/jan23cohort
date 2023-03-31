package com.brianna.booksapi.services;

import java.util.List;
import java.util.Optional;

import org.springframework.stereotype.Service;

import com.brianna.booksapi.models.Book;
import com.brianna.booksapi.repositories.BookRepository;
//MANAGER/COMMUNICATOR goes between repo and controller
@Service
public class BookService {
    // adding the book repository as a dependency
    private final BookRepository bookRepository;
    
    public BookService(BookRepository bookRepository) {
        this.bookRepository = bookRepository;
    }
    // returns all the books
    public List<Book> allBooks() {
        return bookRepository.findAll();
    }
    // creates a book
    public Book createBook(Book b) {
        return bookRepository.save(b);
    }
    //deletes a book
    public void deleteBook(Long id) {
    	bookRepository.deleteById(id);
    }
    // retrieves a book
    public Book findBook(Long id) {
        Optional<Book> optionalBook = bookRepository.findById(id);
        if(optionalBook.isPresent()) {
            return optionalBook.get();
        } else {
            return null;
        }
    }
    //updates a book
    public Book updateBook(Long id, String title, String description, String language, Integer numOfPages) {
        Optional<Book> optionalBook = bookRepository.findById(id);

        if (!optionalBook.isPresent()) {
            throw new RuntimeException("Book not found with id: " + id);
        }

        Book book = optionalBook.get();
        book.setTitle(title);
        book.setDescription(description);
        book.setLanguage(language);
        book.setNumberOfPages(numOfPages);

        bookRepository.save(book);

        return book;
    }
}
