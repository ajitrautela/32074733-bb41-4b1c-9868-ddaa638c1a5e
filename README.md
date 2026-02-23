# Code test
The solution implements a simple .NET 8.0 service to generate longest sub sequences in a given string of numbers (separated by single whitespace).

The solution implements following projects
- Console application
- Service library
- Tests project

The solution also demonstrates the use of following tech
- Dependency Injection
- Containers - Docker windows image
- CI/CD using GitHub Actions to configure workflow to build and execute tests to output code coverage report
- YAML file configures the test execution (no deployment)
- Code Linting to display code formatting warning in GitHub workflow using .editorconfig file
  
The test results can be verified in following ways 
- GitHub Actions workflow
- Running tests by opening solution in Visual Studio
