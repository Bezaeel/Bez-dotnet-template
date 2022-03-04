 # Task Description
 This is a project template I have found suitable for my dotnet projects
 I intend for it to help save time on project especially coding challenges when interviewing
 
 Do a find for `BezTemp` and replace with `<your project name>` <br>

 Also, remember to replace or delete the Sample implementations, they are only pointers to guide the way
 
 
 ```diff
    @@ Please modify to suit your need @@
 ```
 


# Implementation
With clean architecture in mind, injecting different parts to achieve the workflow.
This approach spells `easy maintainence` from the get-go(loosely coupled parts),

- Approach with response messages
    - the service layer does the heavy lifting for this project and responses.
    `code` in the `ServiceResponse` class is to enable in-house team member tell right away what an issue is, this helps in resolving customer related issues, trust me, LOL.

## Technologies used
- C# .NET5
- Postgres
- Docker
- ORM - Entity Framework
- Automapper
- Testing  - xunit


## Checklist
- [ ] service layer <br/>
- [ ] tests for service <br/>
- [ ] endpoints <br/>
- [ ] integration tests for endpoints <br/>
- [ ] dockerize app <br/>
- [ ] setup github workflows for CI <br/>

## How to run
- [ ] configure connection strings in `appsettings.json` in API project and `test.json` in Test project
- navigate to `BezTemp.API` run `dotnet run`

- using docker

- db configuration in `docker-compose.yml` and/or `dockerfile` should correspond with connection string below
- connection string should look like: `"Host=db;Port=5432;Database=<dbname>;Username=<username>;Password=<password>"`
- Ensure `docker` and `docker-compose` is installed
- run `docker-compose up`


## Testing
- Unit testing
    - [ ] Ensure `test.json` is configured appropriately
    - Navigate to `BezTemp.Tests` run `dotnet test`
- Integration


## Improvement
Kindly send me a dm on twitter [@talabiope](https://twitter.com/talabiope) on how to improve this template.
Looking forward to it!