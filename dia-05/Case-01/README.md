# Sistema de hospedagem de cliente
  Coworking system for managing clients using the space. The system will record the date the client registered and also store their status, indicating whether they are currently using the space or not. In addition, the system will have options to change the status from "used to not" and to list registered users.
## Get Start 
````git
git clone https://github.com/Lukas-Souza/DELOITTE_BOOTCAMP.git
````
## Run project

````bash
cd .\dia-05\
````
````bash
cd .\Case-01\
````
<p>Do this to access the project's root directory</p>

````.NET
dotnet run 
````
# source code
````bash
    Case-01/
    | - DataVisitant.cs # Client entitie 
    | - ListService.cs # Guest list entitie
    | - GenerateID.cs # Generate the unique ID
    | - Program.cs # Main file
````
##   Flow for adding a new user to the list
`````bash
    Input data user
            |
    Create new entitie "Client"
            |
    Receive id entitite
            |
    Add client in List
`````

The project is now considered finished and completed.