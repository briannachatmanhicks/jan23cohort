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
		<form:form action="/update/${burger.id}" method="post" modelAttribute="updateForm">
		<!-- Input below is needed to the update form only -->
   		<input type="hidden" name="_method" value="put">
			<section>
				<form:label path="burgerName">Burger Name</form:label>
				<form:errors path="burgerName"/>
				<form:input path="burgerName" type="text" value="${burger.burgerName}"/>
			</section>
			<section>
				<form:label path="restName">Resturant Name</form:label>
				<form:errors path="restName"/>
				<form:input path="restName" type="text" value="${burger.restName}"/>
			</section>
			<section>
				<form:label path="rating">Rating</form:label>
				<form:errors path="rating"/>
				<form:input path="rating" type="number" value="${burger.rating}"/>
			</section>
			<section>
				<form:label path="notes">Notes</form:label>
				<form:errors path="notes"/>
				<form:input path="notes" type="text" value="${burger.notes}"/>
			</section>
			<button>Update</button>
		</form:form>
	</main>
</body>
</html>
