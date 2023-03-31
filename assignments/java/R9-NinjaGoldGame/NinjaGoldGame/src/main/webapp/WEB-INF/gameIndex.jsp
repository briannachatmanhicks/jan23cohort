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
		<h1>Your Gold: <%! int gold = 0; %> <%= gold %></h1>
	</header>
	
	
	<%! public int farmNum(HttpSession session) {
		int randomFarmNum = (int)(Math.random() * (20-10) + 10);
		session.setAttribute("farmNum", randomFarmNum);
		gold = gold + randomFarmNum;
		return gold;
	}%>
	<form action="/submitFarm" method="post">
      <label for="">Farm</label>
      <p>(earns 10-20 gold)</p>
      <input type="hidden" value="<%= farmNum(session) %>" name="farm"></input>
      <button>Find Gold!</button>
   </form>
		<p>The farm num is: <%= session.getAttribute("farmNum") %></p>
		
		
	<%! public int caveNum(HttpSession session) {
		int randomCaveNum = (int)(Math.random() * (10-5) + 5);
		session.setAttribute("caveNum", randomCaveNum);
		gold = gold + randomCaveNum;
		return gold;
	}%>
	<form action="/submitCave" method="post">
		<label for="">Cave</label>
		<input type="hidden" value="<%= caveNum(session) %>" name="cave"></input>
		<p>(earns 5-10 gold)</p>
		<button>Find Gold!</button>
	</form>
	<p> The cave num is: <%= session.getAttribute("caveNum") %>
</body>
</html>

<%-- <%! int day = 3; %>
<html>
   <head>
      <title>IF...ELSE Example</title>
   </head>
   <body>
      <% if (day == 1 || day == 7) { %>
         <p> Today is weekend</p>
      <% } else { %>
         <p> Today is not weekend</p>
      <% } %>
   </body>
</html>  --%>