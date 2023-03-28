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
<body class="text-center">
	<header class="w-25">
		<h1 class="container">Send and Omikuji!</h1>
		<form action="/submitForm" method="post" class="container">
			<div class="form-group">
				<label for="">Pick any number from 5 to 25</label>
				<input type="number" min="5" max="25" name="num" class="form-control">
			</div>
			<div class="form-group">
				<label for="">Enter the name of any city</label>
				<input type="text" name="city" class="form-control">
			</div>
			<div class="form-group">
				<label for="">Enter the name of any  real person</label>
				<input type="text" name="person" class="form-control">
			</div>
			<div class="form-group">
				<label for="">Enter professional endeavor or hobby</label>
				<input type="text" name="hobby" class="form-control">
			</div>
			<div class="form-group">
				<label for="">Enter any type of living thing</label>
				<input type="text" name="livingThing" class="form-control">
			</div>
			<div class="form-group">
				<label for="">Say something nice to someone:</label>
				<input type="textarea" name="somethingNice" class="form-control">
			</div>
			<p class="font-italic">Send and show a friend</p>
			<input type="submit" value="Send" class="btn btn-success">
		</form>
	</header>
</body>
</html>