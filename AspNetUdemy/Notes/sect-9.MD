# View Models and Mappers

# View Models

Classes that abstract the data used by a `View`.

Allows you to create specific data points for a view.

Used to prevent over-posting and accidental data exposure.

# Mappers

Mappers automatically convert between complex data types like `DataModels` 
to `ViewModels`

Popular libraries:
- Automapper
- Mapster

# Validations

Model validation happens after model binding and reports errs where data 
does not conform to business rules.

Validation also occurs before the execution of a `Controller Action`

# Model State

Represents errors from model binding and model validation.

Web apps needs to inspect `ModelState.IsValid` and act accordingly.


## ViewModel Validation Rules

Declared with the `[ValidationRule]` syntax in the `ViewModel` class.

`[Required]`
`public string Name {}`

# ViewModel Display Attr

Lets you set the display value in a VM rather than in the View itself for 
reusability.

`[Display(Name = "Value Here")]`