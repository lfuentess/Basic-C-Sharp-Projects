# Basic-C-Sharp-Projects
This my repository of basic projects in C-Sharp.
All code that I will can learn and create in this course.

  - Welcome Screen: It simply displays the welcome message through the console program. (WelcomeScreen)
  - A daily report for students of Academy of Learning Career College - the console program. (DailyReport)
  - Test Math operations (ConsoleApp)
  - Anonymous income - Math and Comparison Operators - the console program.(anonymous_income)
  - Basic approval program for car insurance - Boolean Logic. - the console program.(bappxcarins)
  - Package Express - Branching - the console program.(packageexpress)
    
  - Test to loop 2 statement "While", "Do...While". (ConsoleApp1)
  - String manipulate - use StringBuider, uppercase, concatenation, etc. (StringConsoleApp)
  - Manage Array and List in C#. (ConsoleArray)
  - Manage Strings and Integers on the List with try/catch (ConsoleApp2)
  - Create a class. Create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received       parameter.  (ConsoleApp3)
  - Create a console app with class that contains:(ConsoleMainMethod)
        -A mathematical operation method of integer type.
        -A mathematical operation method of double type.
        -A mathematical operation method of string type.
  - Create a console app with class that contains (ConsoleAppMethod)
        - Create a class. Create a method that takes two integers as parameters.
        - Make one of them optional. Have the method do a math operation and return an integer result.
        - Call the method in the class, passing in the one or two numbers entered.  
  - Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the           second integer to the screen. (ConsoleMethodClass)
        - Call the method in the class, passing in two numbers. 
        - Call the method in the class, specifying the parameters by name.


  - Create a class called Person and give it two properties of data type string. One called FirstName, the other         LastName. (ConsoleAppMetsObjs)
        - Give this class a void method called SayName() that takes no parameters and simply writes the person's               full name to the console in the format of: “Name: [full name]”.
        - Create another class called Employee and have it inherit from the Person class. Give the Employee class a             property called Id and have it be of data type int.
        - Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and           a last name of “Student”.
        - Call the superclass method SayName() on the Employee object.


  - A console app that includes the following: (ConsoleAppAbstractClass)
        - Create an abstract class called Person with two properties: string firstName and string lastName.
        - Give it the method SayName().
        - Create another class called Employee and have it inherit from the Person class.
        - Implement the SayName() method inside of the Employee class.
        - Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.
  - Polymorphism Assignment (ConsolePolymorphism)
        - Create an interface called IQuittable and have it define a void method called Quit().
        - Have your Employee class from the previous drill inherit that interface and implement the Quit()
          method in any way you choose.
        - Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an
          object can be of an interface type if it implements that specific interface.
  - Operators Assignment (Operatoroverload)
        - Create an Employee class with Id, FirstName and LastName properties. 
        - In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by
          comparing their Id property. Remember that comparison operators must be overloaded in pairs. 
        - In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their
          properties. Then compare the two Employee objects using the newly overloaded operators and display
          the results.
  - Create a console app that includes:  (AppParsingEnums)

        - Create an enum for the days of the week.
        - Prompt the user to enter the current day of the week.
        - Assign the value to a variable of that enum data type you just created.
        - Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
  - Struct Assignment (ConsoleAppStruct)
        - Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
        - In the Main() method, create an object of data type Number and assign an amount to it.
        - Print this amount to the console.

  - Create a console app that includes the following: (ConsoleAppLambda)
        - Create an Employee class with the following properties:
              - a. Id
              - b. First Name
              - c. Last Name

        - In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
        - Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.
        - Perform the same action again, but this time with a lambda expression.
        - Using a lambda expression, make a list of all employees with an Id number greater than 5.

  - Blackjack Game (TwentyOne)
        - TwentyOne console application

  - Input Assignment (ConsoleAppInput)
        - Asks the user for a number.
        - Logs that number to a text file.
        - Prints the text file back to the user.
  - Datetime Assignment (ConsoleAppDatetime)
        - Prints the current date and time to the console.
        - Asks the user for a number.
        - Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
  - Constructor Assignment (ConsoleAppConstructor)
        - Create a const variable.
        - Create a variable using the keyword “var.”
        - Chain two constructors together.
  - Try/Catch Assignment (ConsoleAppTryCatch)
        - Ask the user for their age.
        - Display the year the user was born.
        - Exceptions must be handled using “try/catch.”
        - Display appropriate error messages if the user enters zero or negative numbers.
        - Display a general message if an exception was caused by anything else.
    
  - ASP.NET MVC Entity Framework Assignment Part 1 (CarInsuree)
        - Add the three Entity Framework packages that were used in the TechStoreInventory tutorial.
        - Create a Model named “Insuree” with the following required properties (use your best judgment to decide the data
          types): Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, SpeedingTickets,               CoverageType, and Quote.
        - Using Entity Framework, create the Database for this project and the Controller and Views for the Insuree Model.

    - ASP.NET MVC Entity Framework Assignment Part 2 (CarInsureee)
        - In an ASP.NET MVC project like this one, your Models are just classes. Usually these classes correspond to                   objects that a user or administrator of your application can create, edit, view the details of, and delete.
        - Your Controllers are highly-specialized classes, which are responsible for the functional logic of your program.            In your InsureeController will go most of the extra functions you'll write to further refine this project (e.g.,            the function that will automatically calculate a quote from the user's other inputs rather than allowing the user           to input their own quote).
        - Your Views are just web-pages built for a specific purpose. The 5 standard MVC views (Index, Create, Edit,                  Details, Delete) often provide the bulk of the functionality that a simple database-driven website will need, but           you can also build your own Views (and Models and Controllers) for additional functionality in more complex                 applications.
        - From this point, by editing the code in your InsureeController and Insuree Views (and maybe, if you're a                    perfectionist, by adding an InsureeMetadata class to your Models, and even a CSS file for styling your                      application)

    - ASP.NET MVC Entity Framework Assignment Part 3 (CarInsureee)
        - Start with a base of $50 / month.
          - If the user is 18 or under, add $100 to the monthly total.
          - If the user is from 19 to 25, add $50 to the monthly total.
          - If the user is 26 or older, add $25 to the monthly total. Double check your code to ensure all ages are covered.
          - If the car's year is before 2000, add $25 to the monthly total.
          - If the car's year is after 2015, add $25 to the monthly total.
          - If the car's Make is a Porsche, add $25 to the price.
          - If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price. (Meaning,                 this specific car will add a total of $50 to the price.)
        - Add $10 to the monthly total for every speeding ticket the user has.
        - If the user has ever had a DUI, add 25% to the total.
        - If it's full coverage, add 50% to the total.
        - Modify the Create View so that the user does not see the “Quote” input field.
        - Add an Admin View for a site administrator to the Insuree Views. This page must show all quotes issued, along               with the user's first name, last name, and email address.

  - Challenge Assignment (ServerTime)
        - Create a new ASP.NET Core web application project.
        - Design a simple ASP.NET Core web app that displays the actual server time in the browser. 
        - Customize the CSHTML <h2> element with text of your choosing.
  - Challenge Assignment (StudentConsole)
        - Create a basic Entity Framework Code-First console application that creates a basic Student database and adds one           student.
