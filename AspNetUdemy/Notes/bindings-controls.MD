# Form Bindings and Controls

ASP provides some helper attributes for forms:
- `asp-for`
- `asp-controller`
- `asp-action`
- `asp-validation-*`

The `<form>` tag auto generated a hidden `Request Verif Token` to prevent 
x-site request forgery. The token is bound to `ValidateAntiForgeryToken` 
attr in action method.