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
		<h1>New Ninja</h1>
		<form:form action="/ninjas/post" method="post" modelAttribute="ninjaForm">
			<section>
				<form:label path="firstName">First Name</form:label>
				<form:errors path="firstName"/>
				<form:input path="firstName"/>
			</section>
			<section>
				<form:label path="lastName">Last Name</form:label>
				<form:errors path="lastName"/>
				<form:input path="lastName"/>
			</section>
			<section>
				<form:label path="age">Age</form:label>
				<form:errors path="age"/>
				<form:input path="age"/>
			</section>
			<section>
				<form:label path="dojo">Dojo Name</form:label>
				<select name="dojo" id="">
					<c:forEach var="d" items="${allDojos}">
						<option value="${d.id}">${d.name}</option>
					</c:forEach>
				</select>
			</section>
			<button>Add Sticker</button>
		</form:form>
	</main>
</body>
</html>