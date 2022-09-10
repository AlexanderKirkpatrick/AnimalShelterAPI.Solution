# Animal Shelter API

#### By _**Alex Kirkpatrick**_

#### _An API for lists of available cats and dogs at a shelter._

## Technologies Used

* C#
* .NET 5.0
* ASP.NET Core MVC
* MySQL
* Entity Core Framework
* Identity Core Framework
* AspNet Core Web Api
* Swashbuckle

## Description

An API for lists of available cats and dogs at a shelter.

## Setup/Installation Requirements

* Make sure you have MySql Workbench installed on your computer.
* Make sure to have dotnet-ef installed too.
* Download repo to your computer using either clone or the download link.
* Open the project in VScode or your terminal/IDE of choice.
* Create an <code>appsettings.json</code> file in the root directory of the project folder: <code>AnimalShelterApi.Solution/AnimalShelterApi/</code>. And add the following code replacing anything in square brackets with the information it represents specific to the project database:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[USER-ID-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

```

Example of complete appsettings.json:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=root;pwd=strongpassword;"
  }
}

```

* Make sure to run your mysql server and open MySql workbench.
* Open MySql Workbench and login to your server.
* From your terminal navigate to the <code>AnimalShelterApi.Solution/AnimalShelterApi/</code> folder and run the command <code>dotnet ef database update</code> to create the database from migrations.
* Now using your IDE navigate into the AnimalShelterApi.Solution/AnimalShelterApi folder and use the command dotnet run to launch the program.
* The API should now be available at the server address you used in the appsettings.json folder.
* The site should be available at the server address you used in the <code>appsettings.json</code> folder.

## API Documentation
You can explore the API endpoints in Postman or your browser. Once the API is running you can also go to <code>[Your-server-addres]/swagger</code>.  
* For example <code>http://localhost:5000/swagger</code>

This is an open API so you dont need any authentication to use all CRUD functionality. 

### Endpoints
Base URL: http://localhost:5000

HTTP Request structure
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
GET /api/Animals/Search?searchString={breed}
GET /api/Animals/Random
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```

Example query
```
https://localhost:5001/api/animals/2
```

Example Response
```
{
animalId:	2
name:	"Doug"
type:	0
breed:	"Domestic Short Hair"
sex:	0
coloring:	"Brown Tabby"
age:	0.3
weight:	5.2
personality:	4
about:	"Always PURRing and PURRfect!"
adopted:	false
adoptionDate:	"0001-01-01T00:00:00"
}
```
Example Search query
```
https://localhost:5001/api/animals/Search?searchString=Calico
```

Example Response
```
{
animalId:	8
name:	"Mitsy"
type:	0
breed:	"Calico"
sex:	1
coloring:	"Black White Orange"
age:	5
weight:	15
personality:	0
about:	"Wild heart!"
adopted:	false
adoptionDate:	"0001-01-01T00:00:00"
}
```
## Known Bugs

* _No known bugs._

## Contact Me

Let me know if you run into any issues or have questions, ideas or concerns:  
alex_kirkpatrick@gmail.com

## License

MIT License

Copyright (c) _September_2022_ _Alexander Kirkpatrick_