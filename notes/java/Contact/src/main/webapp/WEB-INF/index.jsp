<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!-- for forms -->
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ taglib prefix = "fmt" uri = "http://java.sun.com/jsp/jstl/fmt" %>
<!-- for validation -->
<%@ page isErrorPage="true" %>
<!DOCTYPE html>
<html>
<head>
<!-- for Bootstrap CSS -->
<link rel="stylesheet" href="/webjars/bootstrap/css/bootstrap.min.css" />
<!-- YOUR own local CSS -->
<link rel="stylesheet" type="text/css" href="/css/style.css">
<!-- For any Bootstrap that uses JS -->
<script src="/webjars/bootstrap/js/bootstrap.min.js"></script>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<header>
		<h1>Hello</h1>
		<nav>
			<a href="/">Home</a>
			<a href="/addContact">Add New Contact</a>
		</nav>
	</header>
	
	<body>
			<c:forEach items="${ViewContacts}" var="i" >
		<p>${i.bio}</p>
		<p>${i.name}</p>
		<p>${i.address}</p>
			</c:forEach>
		<div>
			<form action="/addContact" method="POST">
				<section>
					<label for="name">Name</label>
					<input type="text" name="name">
					<form:errors path="name" />
				</section>
				<div>
					<label for="bio">Contact Bio</label>
					<input type="text" name="bio">
					<form:errors path="bio"/>
				</div>
				<div>
					<label for="address">Address</label>
					<input type="text" name="address">
					<form:errors path="address"/>
				</div>
				<button>Add Contact!</button>
			</form>
		</div>
	</body>
</body>
</html>
