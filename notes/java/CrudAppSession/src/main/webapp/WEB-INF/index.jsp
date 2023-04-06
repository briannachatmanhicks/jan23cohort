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
	<title>Stickers and Categories</title>
</head>



<body>
	<header>
		<h1>Our Stickers and Categories</h1>
		<nav>
			<a href="/">Home</a>
			<a href="/addsticker">Add Sticker</a>
			<a href="/addcategory">Add Category</a>
			
			<a href="/choosecat">Choose Category</a>
		</nav>
	</header>
	<main>
		<table>
			<tr>
				<th>Sticker Id</th>
				<th>Sticker Category</th>
				<th>Sticker Image</th>
			</tr>
		<c:forEach items="${allStickers}" var="s">
			<tr>
				<td>${s.id}</td>
				<td>${s.theCat.name}</td>
				<td><img src="${s.URL}"/></td>
				<td><a href="/sticker/${s.id}/view">View</a> <a href="/sticker/${s.id}/edit">Edit</a> <a href="/sticker/${s.id}/delete">Delete</a></td>
			</tr>
		</c:forEach>
		</table>
	</main>
</body>
</html>