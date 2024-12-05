# MVC Pattern

Model-View-Controller. Separation of responsibilities helps with
maintainability and scalability.

## Views

Present content via the UI.

Files use the `.cshtml` extension which allows for C# code support. The
csharp code is contained in the `@{}` block.

Designed to display data with as little logic as possible.

## Controllers

Handle requests, work with Models and ultimately select the View to render.

Invokes methods called _Actions_ which does the following:

- Performs business logic
- Collates data
- Returns a view that corresponds to url along with relevant data


## Models

A C# class that contains properties to store data needed for an operation.

Should use `ViewModel` types to contain the data to display on the given View.

Controllers leverage the Model to create ViewModels.

### Important Files

`Program.cs` is the main entry point where init occurs.

`appsettings.json` contains config. Can have files for different envs/modes.
Ex: `appsettings.Development.json`

`wwwroot` is the dir containing static resources like imgs, css, javascript
files.

`Properties/launchSettings.json` is a config file that manages profiles for
testing.


### Best Practices

- Controller names must follow format of `RouteNameController`
- View folder must exist with a name of `RouteName`
- Each action defined in `RouteNameController` should have matching view.
    - Ex: Index action must have matching `Index.cshtml` file.