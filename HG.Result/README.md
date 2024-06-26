# HG.Result NuGet Package

## Overview
The `HG.Result` package is designed to encapsulate the result of operations in .NET applications, offering a structured way to handle success and failure states with associated data or error messages. It is ideal for improving error handling and response consistency across various application layers.

## Features
- **Generic Result Type**: Facilitates strong typing of the operation outcome, accommodating any data type.
- **Error Handling**: Enables capturing multiple error messages, suitable for scenarios requiring detailed feedback.
- **HTTP Status Code Integration**: Aligns operation results with HTTP response standards, anhancing API development.
- **Implicit Conversions**: StreamLines result creation from data or errors through implicit conversion operators.

## Getting Started

### Installation
To integrate `HG.Result` into your project, install it via the NuGet package manager:

````plaintext
Install-Package HG.Result
`````

**Or through the .NET CLI**
````plaintext
dotnet add package HG.Result
````

## Usage
**Successful Result Creation**
for a successful operation, instantiate a Result object with the desired data:
````csharp
var successResult = new Result<string>("Operation successful...");
````

**Alternatively, leverage implicit conversion from data:**
````csharp
Result<string> result = "Operation successful...";
````

**Failure Result Creation**
For failures, create a Result object with an HTTP status code and error messages:
````csharp
var errorResult = new Result<string>(400, new List<string> {"Error 1", "Error 2"});
````

**Or use implicit conversion from error details**:
````csharp
Result<string> result = (400, new List<string> {"Error 1", "Error 2"});
````

**For single error messages**:
````csharp
Result<string> result = (400, "Single error message");
````

** For success using Succeed method**:
````csharp
Result<string> result = Result<string>.Succeed("Is successful");
````

** For failure using Failure method**:
- **One error message**
````csharp
Result<string> result = Result<string>.Failure(500, "Is fail");
````

- **Multiple error messages**
````csharp
Result<string> result = Result<string>.Failure(500, new List<string>() {"Is fail!", "Is not unique"}");
````

- **One error message return 500 status code**
````csharp
Result<string> result = Result<string>.Failure("Is fail"); //return 500 status code
````

- **Multiple error messages return 500 status code**
````csharp
Result<string> result = Result<string>.Failure(List<string>() {"Is fail!", "Is not unique"}"); //return 500 status code
````

## Contributing
We welcome contributions! Feel free to open an issue or submit a pull request on our Github repository for any suggestions and improvements.

## License
`HG.Result` is licensed under the MIT License. See the LICENSE file in the source repository for full details.

````rust
This Markdown formatted README provides a comprehensive guide on how to use the `HG.Result` package, suitable for your project's repository or documentation. 
````
