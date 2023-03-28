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
		<h1>Here's Your Omikuji!</h1>
	</header>
	<div>
		<h2>
		In <%= session.getAttribute("n") %> years, you will live in <%= session.getAttribute("c") %> with <%= session.getAttribute("p") %> as your roommate, <%= session.getAttribute("h") %> for a living. They next time you see a <%= session.getAttribute("lT") %>, you will have good luck. Also, <%= session.getAttribute("sN") %> 
		</h2>
	</div>
</body>
</html>