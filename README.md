## CSharpWebApi
Here is a simple c# test for the candidates.

1. Refactor the current code, using the Solid Principles
2. Implement the following features in the Console project : 
   * Parse the response from the WebAPI to a concrete model
   * Insert the data into the only table of the database
   * Connections to the database should be closed at the end
   * Don't keep all code in the Program.cs file. 
3. Implement the following features in the WebAPI project :
   * Create repositories with a virtual database, using the models as tables.(static classes with lists just holding data)
   * Refactor the PrintersController to use the repositories you just created
4. Write tests for both Console and WebAPI projects, as well as for any projects you might create.

# Updates
- Applied the DAL architecture, creating a DAL folder in each project.
  - Easy maintenance;
  - Better management around the functions that get and post information to the DB.
- Created 2 more projects:
  - Models;
  - UnitTests;
 
### Models
- Created to be used as a unique layer for these two projects, in this way, you'll be able to use the WebAPI and Console projects with just one model.

### UniTests
- Created 2 classes to do the unit tests:
  - ConsoleTests (Testing getting the information and store it in the DB);
    - Do not forget to Run the WebAPI on another Visual Studio Instance or another Service, otherwise your tests will fail.
  - WebApiTests (Getting and storing based on a virtual db, a class instance holding data, as said in the description).

