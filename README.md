MovieController 

-> added action for search 
-> both for page load and to get the search result


Added a view with 	

-> jQuery library
-> ajax call to search and put the results into a table when the button is clicked 
-> clear the table before each call



MovieServices 	

-> added new function GetAllMovies(1 param) 
-> this gets the movie list and searches if the title or the genere contasin the text 
-> ungly solution but it should work
