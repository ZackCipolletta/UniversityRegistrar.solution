## How To Run This Project

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called "ToDoList". 
3. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).


Creating a Database Connection String
When we connect to our database, we must manually open a connection by creating a new instance of the MySqlConnection class from the MySqlConnector package. We'll learn exactly how to do this in upcoming lessons. What's important to know right now is that the MySqlConnection constructor expects a database connection string that contains the access details of our database: its name, the database user and password, and the database server and port. For our To Do List app, this is what our connection string will look like:

Next, let's create appsettings.json. Within the production directory of our project (ToDoList.Solution/ToDoList), create appsettings.json and add the following code to it:
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
Make sure to update the connection string with the values that you set for your username and password. As noted earlier, we'll always assume the user is 'root' and the password is epicodus.