# CSharp_DataAccess_with_SQLClient

This assignment consisted of two parts

### 1: setup a SQL Server database with SQL scripts and ssms.

The database was based of Superheroes, and had the tables below

![image](https://user-images.githubusercontent.com/6428939/220162109-34390d1c-7318-4cda-add0-e94aede198e8.png)


### 2: the implementation of the Chinook database and the following features for customer in a console application

1. Read all the customers in the database, this should display their: Id, first name, last name, country, postal code,
phone number and email.
2. Read a specific customer from the database (by Id), should display everything listed in the above point.
3. Read a specific customer by name. HINT: LIKE keyword can help for partial matches.
4. Return a page of customers from the database. This should take in limit and offset as parameters and make use
of the SQL limit and offset keywords to get a subset of the customer data. The customer model from above
should be reused.
5. Add a new customer to the database. You also need to add only the fields listed above (our customer object)
6. Update an existing customer.
7. Return the number of customers in each country, ordered descending (high to low). i.e. USA: 13, ...
8. Customers who are the highest spenders (total in invoice table is the largest), ordered descending.
9. For a given customer, their most popular genre (in the case of a tie, display both). Most popular in this context
means the genre that corresponds to the most tracks from invoices associated to that customer.

## Heres a class diagram of the solution:
![image](https://user-images.githubusercontent.com/6428939/220161501-fb6fe94a-0b80-4af3-bf5a-4616f09fe052.png)
