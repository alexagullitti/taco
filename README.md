# taco
Forms and sql application for creating, searching and updating deliveries 

--set up--
i added a microsoft word doc with some pictures to get everything set up!
gettingSetUp.docx

--intro--
I spent around 5 hours to complete this project. Between research(1hr), coding(3hr) and uploading/documenting(30min). I had never worked with JSON before and I felt it would be faster for me to use some tools I was familar with. I used c# and connected a sql database to the forms application. Hopefully this is in line with the skills you wanted to evaluate. Plus SQL was on the job application so felt like a good thing to use(Even though there is only one table in this database lol-promise I've worked in a real database before)!

--how to use--

When you run the application a windows form will appear. If you click on the 'search all' button you will see all the current rows of delivery data.

To add a delivery-
Enter the data into the form and click add. You must have unique first name, that is the primary key. Obviously in a real taco delivery truck situation that would not be realistic, but for the pourpose of the exercise it made it easier! 
If you enter a non unique first name it will not add the delivery. Regardless a window will appear to tell you if the row is added or not. To verify the entry is there, click the 'search all' button and it will refresh the table.

To Delete a delivery-
Enter data into any or all of the fields and it will delete the rows containing that data. If you enter Smith into last name, it will delete all rows with the last name of Smith. If you enter last name smith and address 123 it will only delete rows that match both those conditions. To verify the entry is removed, click the 'search all' button and it will refresh the table.

To update a delivery-
Enter data, you must enter a first name and it will update that row. To verify the entry is updated, click the 'search all' button and it will refresh the table.

To search a delivery-
Enter data into any or all fields and it will return the rows that match.



