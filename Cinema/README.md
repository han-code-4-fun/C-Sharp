# Project use Entity Framework to build cinema system with designed SQL Database

## Content
- Description
- Database Design (Diagram)
- Process Model
- How to run the program


### Description

##### This is a project for a cinema business. The goal is to deliver a Purchase system implements multiple forms and underlying tables that cover the function of:
##### -Membership registration
##### -Purchase movie tickets
##### -Book theater seats
##### -Purchase Snacks
##### -Add new movie information 
##### -Sales Reports (administrator function)
##### -back up database (administrator function)


The system’s users are the cinema cashier staff. And assuming that the schedule of movies each period is designed and delivered by the cinema manager. So an existing schedule table is provided. The report and back up function can only be used by administrator. Administrator users need to enter password before accessing it.<br /><br /><br />

### Database Design
![alt text](https://github.com/miaonagemide/C-Sharp/blob/master/Cinema/CinemaDB/DB.jpg)
<br /><br /><br />


### Process Model

_For ticket purchasing_
1.	Staff open Main program, click Buy Ticket button
2.	At the Buy Ticket form, user can enter customers phone number to get customer information which will give customer a discount in the end. Then user can click the movie that customer wants to watch in the data grid table, click seat map button to open seat booking form
3.	In seat booking form, choose the seats and click confirm seats button
4.	The form will return back to ticket form, then ticket form will show selected movie, number of tickets and subtotal movie prices
5.	If customer want to buy snacks (coke, popcorn, ice cream...etc.), staff click the snack button
6.	When in the snack form, choose the snack first, then click +/- to change purchase quantity, at the same time the total price will show. In the end, click process button to return back to ticket screen, then the ticket form will show subtotal price for snacks and the total prices (snacks + movies)
7.	If everything is satisfied, user will click Confirm Order button to check out

_For purely snack purchasing_
1.	Staff open Main program, click the snack button
2.	Choose the snack first, then click +/- to change purchase quantity, at the same time the total price will show. In the end, click process button to return back to ticket screen, then the ticket form will show subtotal price for snacks and the total prices Click buy button to finish.
3.	User will click Confirm Order button to check out

_For adding movie_
1.	Staff open Main program, click add movie button
2.	Enter the movie information into correct textboxes
3.	Click Add Movie button.

_For registering customer_
1.	Click Customer Registration
2.	Enter Customer information
3.	Click Register button

_For generate report_
1.	Click Switch to Administrator button, enter correct password in the popup windows (default password 1234)
2.	After entering right password, the report button will show
3.  Entering the report button, user can select 3 type of sales report: 7 days, 30 days, and all time

_For backup database_
1.	Click Switch to Administrator button, enter correct password in the popup windows (default password 1234)
2.	After entering right password, the database button will show, just click the button then the database will be saved to local hard drive<br /><br /><br />





### How to run the program
1. open CinemaSystem/CinemaCinemaSystem.sln
2. at the solution explorer, right-click the CinemaDB and choose "Set as StartUp Project"
3. click start button on top 
4. set CinemaSystem as StartUp Project and run it
