SELECT * FROM clients;

-- 1. What query would you run to get the total revenue for March of 2012?
SELECT SUM(billing.amount) FROM clients
LEFT JOIN billing ON clients.client_id = billing.client_id
WHERE billing.charged_datetime >= '2012/03/01'
AND billing.charged_datetime < '2012/04/01';

-- 2. What query would you run to get total revenue collected from the client with an id of 2?
SELECT SUM(billing.amount) FROM clients
LEFT JOIN billing ON clients.client_id = billing.client_id
WHERE clients.client_id = 2;

-- 3. What query would you run to get all the sites that client with an id of 10 owns?
SELECT sites.domain_name FROM clients
LEFT JOIN sites ON clients.client_id=sites.client_id
WHERE clients.client_id = 10;

-- 4. What query would you run to get total # of sites created per month per year for the client with an id of 1? What about for client with an id of 20?
SELECT clients.client_id, COUNT(sites.domain_name) FROM clients
LEFT JOIN sites ON clients.client_id=sites.client_id
WHERE clients.client_id= 1 OR clients.client_id = 20
GROUP BY year(sites.created_datetime), month(sites.created_datetime), clients.client_id;

-- 5. What query would you run to get the total # of leads generated for each of the sites between January 1, 2011 to February 15, 2011?
SELECT sites.domain_name, COUNT(leads.leads_id) FROM clients 
LEFT JOIN sites ON clients.client_id=sites.client_id
LEFT JOIN leads on sites.site_id=leads.site_id
WHERE leads.registered_datetime <= '2011/02/15' AND leads.registered_datetime >= '2011/01/01'
GROUP BY sites.domain_name;

-- 6. What query would you run to get a list of client names and the total # of leads we've generated for each of our clients between January 1, 2011 to December 31, 2011?
SELECT clients.first_name, clients.last_name, COUNT(leads.leads_id) FROM clients
LEFT JOIN sites ON clients.client_id=sites.client_id
LEFT JOIN leads on sites.site_id=leads.site_id
WHERE leads.registered_datetime <= '2011/12/31' AND leads.registered_datetime >= '2011/01/01'
GROUP BY clients.first_name, clients.last_name;

-- 7. What query would you run to get a list of client names and the total # of leads we've generated for each client each month between months 1 - 6 of Year 2011?
SELECT clients.first_name, clients.last_name, COUNT(leads.leads_id) FROM clients
LEFT JOIN sites ON clients.client_id=sites.client_id
LEFT JOIN leads on sites.site_id=leads.site_id
WHERE leads.registered_datetime <= '2011/06/30' AND leads.registered_datetime >= '2011/01/01'
GROUP BY clients.first_name, clients.last_name;

-- 8. What query would you run to get a list of client names and the total # of leads we've generated for each of our clients' sites between January 1, 2011 to December 31, 2011? 
-- Order this query by client id.  Come up with a second query that shows all the clients, the site name(s), and the total number of leads generated from each site for all time.
SELECT clients.client_id, clients.first_name, clients.last_name, COUNT(leads.leads_id) FROM clients
LEFT JOIN sites ON clients.client_id=sites.client_id
LEFT JOIN leads on sites.site_id=leads.site_id
WHERE leads.registered_datetime <= '2011/12/31' AND leads.registered_datetime >= '2011/01/01'
GROUP BY clients.client_id
ORDER BY clients.client_id;

-- 9. Write a single query that retrieves total revenue collected from each client for each month of the year. Order it by client id.  
-- First try this with integer month, second with month name.  A SELECT subquery will be needed for the second challenge.  Look at this for a hint.
SELECT * FROM 