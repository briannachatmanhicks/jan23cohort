<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
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
		<div>
			<h2>Your Gold: <c:out value="${gold}"/>  </h2>
		</div>
	</header>
	<main> 
		<form>
			<div>
			<form action="/submitFarm" method="post">
      			<label for="">Farm</label>
      			<p>(earns 10-20 gold)</p>
      			<input type="submit" value="Find Gold!" name="farm"></input>
      			<!-- <button>Find Gold!</button> -->
   			</form>
			</div>
		</form>
		
		
		<div>
			<c:forEach items="${activities}" var="i">
				<p>${i}</p>
			</c:forEach>
		</div>
	</main>
</body>
</html>