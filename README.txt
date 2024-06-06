[ISO Format]
Krutik Patel

2024-05-16

1810 UTC
completed part 1, Than started with part 2

Part2 - Add a Controller
1830 UTC

Commented the default index method which is returning to class view()
Then added new index method and changed the content to "This is my default action..."
Was running when i ran the program

https://localhost:7126/HelloWorld

1845  UTC
Added another method called welcome with the content of "This is the Welcome action method..."
Confirmed it was running

https://localhost:7126/HelloWorld/Welcome

1855 UTC

Changed the Welcome method to include two parameters(name,numtimes)
Ran the program, and it ran successfully... 

https://localhost:7126/HelloWorld/Welcome/1000?name=krutik

started with part 3
add a view
1850 UTC
created a new folder named HelloWorld

Completed with the part 3
all good.. tested...
1801

Done with part 3 and begin with part 4
1836
Created a new class named Movie.cs

Completed with part 4
tested 
1850

added a new class in models
1853

20240523184710_InitialCreate  >> Migration

Started part 7
3.32
Part 7, added search to an ASP.NET Core MVC app


13:45
Opened the MoviesController.cs file to add the search capability. Updated the Index method

13:51
Tested the search functionality by navigating to /Movies/Index and appending a query string, such as
?searchString=Ghost, to verify that the filtered movies are displayed correctly.
It worked

13:54
Updated the Views/Movies/Index.cshtml file to include a search form

13:57
Enhanced the Index method to support genre-based filtering. Added a new view model in the model.

14:05
Updated the Views/Movies/Index.cshtml file to incorporate genre filtering

14:10
Tested the application by searching for movies by genre, title, and both.
Navigated to URL to check if it worked :)

14:15
Moved with next part

05-06-2024

Started with part 8

13:45
Added a new field, Rating, to the Movie model in Movie.cs.

Updated the MoviesController.cs file to include the Rating property in the [Bind] attribute for both
the Create and Edit action methods

13.46
Updated the Views/Movies/Index.cshtml file to display the Rating field in the movie list

13:50
Updated the Views/Movies/Create.cshtml file to include a Rating field for creating new movies.

Modified the SeedData class to provide a value for the new Rating column when seeding data.

Discovered that the app wouldn't work until the database was updated to include the new field.
Encountered a SqlException due to the missing Rating column in the database table.

13:55
Used Entity Framework Code First Migrations to update the database schema. Executed the following
commands in the Package Manager Console
These commands created a migration file named "Rating" and updated the database schema to include the new Rating column.

Tested the app to ensure that movies could be created, edited, and displayed with the Rating field.



14:00
Documented the completion of Part 8 in the project documentation file (Textfile.txt) and saved all changes.
Confirmed that the new field addition and database migration were successful.

 Part 9 of the tutorial focusing on adding validation to the ASP.NET Core MVC app

 14:00
Added validation rules to the Movie model class in Models/Movie.cs
These validation attributes enforce rules such as required fields, string length constraints,
regular expression patterns, and value ranges

14:05
Explained how validation attributes work:

Required and MinimumLength attributes enforce that a property must have a value.
RegularExpression attribute limits what characters can be input.
Range attribute constrains a value to within a specified range.
StringLength attribute sets the maximum and minimum length of a string property.
Explained that value types are inherently required and don't need the [Required] attribute.
Discussed the benefits of automatic validation enforcement by ASP.NET Core, ensuring robustness and data integrity.

14:10
Explained how validation error UI is automatically generated without changing the controller or views.

Demonstrated validation error messages displayed both client-side (using JavaScript and jQuery) and server-side.
Emphasized that the validation logic and error messages are specified only in the Movie class,
ensuring consistency and adhering to the DRY principle.

14:15
Described how validation works in the Create action method:

The [HttpPost] version of the Create method checks ModelState.IsValid to determine if there are any validation errors.
If validation fails, the form is redisplayed with error messages.
If validation passes, the movie is saved to the database.
Explained that the form data isn't sent to the server until client-side validation passes.

14:20
Examined the usage of DataType attributes to provide hints for formatting and rendering data,
such as DataType.Date and DataType.Currency.

Discussed the benefits of using DataType attributes:

Enables HTML5 features like calendar control and locale-appropriate formatting.
Allows MVC to choose the right field template for rendering data.
Highlighted that neither the controller nor the view template needs to know about the
validation rules or error messages, as they are specified in the model class.

14:25
Shared additional information about combining validation attributes and using
DisplayFormat attribute for specifying date format.

Warned about the limitations of jQuery validation with certain attributes like Range and DateTime.

Reviewed the Movie class with combined validation attributes.

Prepared for the next part of the series, focusing on improving the automatically
generated Details and Delete methods.

Part 10, examine the Details and Delete methods of an ASP.NET Core app

14:30
Examined the Details method in the Movie controller (MoviesController.cs)
Explained that this method retrieves details of a movie by its id and returns a corresponding view.
It handles cases where id is null or when the specified movie is not found.

14:35
Reviewed the Delete and DeleteConfirmed methods

14:40
Documented the review of the Details, Delete, and DeleteConfirmed methods in the project
documentation file.

done with part 10

06-06-2024
15:05
Created new movies in see
Created github repositery




