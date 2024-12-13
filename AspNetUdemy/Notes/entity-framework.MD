# Entity Framework

ORM library with APIs for interacting with DBs.

## EF Key Components

- Database Adapter
- Database Context (class that represents DB model in code)
- Data Models (classes that represent tables)
- LINQ


### Connection Strings

Defined in `appsettings.json`.


### Creating DB Tables/Models

In the `Data` folder, create a file for your desired table/model in the form 
of a class.

To make Entity Framework aware that the class should be used as a table, you 
need to add it to the `ApplicationDbContext` file. (Or whatever your db 
context file is named) 

To do so, add the following code as a new public property to the 
`ApplicationDbContext` class.

`public DbSet<X> XTypes { get; set; }` where X is replaced with the name of 
your class.

#### Adding/Removing a Migration

Run the command `dotnet ef migrations add MigrationName` to add.

`dotnet ef migrations remove` to remove.