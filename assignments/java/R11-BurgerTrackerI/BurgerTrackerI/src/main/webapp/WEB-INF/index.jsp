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
	</header>
	<main>
		<h1>All Burgers</h1>
		<table>
			<thead>
				<tr>
					<th>Burger Name</th>
					<th>Resturant Name</th>
					<th>Rating</th>
					<th>Action</th>
				</tr>
			</thead>
			
			<tbody>
				<c:forEach var="b" items="${allBurgers}">
				<tr>
					<td>${b.burgerName}</td>
					<td>${b.restName}</td>
					<td>${b.rating} </td>
					<td><a href="/edit/${b.id}">edit</a></td>
				</tr>
				</c:forEach>
			</tbody>
		</table>
		
		
		<h1>Add Burger</h1>
		<form:form action="/createburg" method="post" modelAttribute="burger">
			<section>
				<form:label path="burgerName">Burger Name</form:label>
				<form:errors path="burgerName"/>
				<form:input path="burgerName"/>
			</section>
			<section>
				<form:label path="restName">Resturant Name</form:label>
				<form:errors path="restName"/>
				<form:input path="restName"/>
			</section>
			<section>
				<form:label path="rating">Rating</form:label>
				<form:errors path="rating"/>
				<form:input path="rating"/>
			</section>
			<section>
				<form:label path="notes">Notes</form:label>
				<form:errors path="notes"/>
				<form:input path="notes"/>
			</section>
			<button>Submit</button>
		</form:form>
	</main>
</body>
</html>