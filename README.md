# Eau Claire's Salon

#### _A web-based application to track Claire's Salon's stylists and clients._

#### By **Sisi Vieira**

## Technologies Used

* _C#_
* _.NET 5.0.100_
* _ASP.NET Core MVC_
* _Microsoft.NET.Sdk.Web_
* _Microsoft.NET.Test.Sdk 15.0.0_
* _MSTest.TestAdapter 1.3.2_
* _MSTest.TestFramework 1.3.2_
* _Microsoft.EntityFrameworkCore 5.0.0_
* _Pomelo.EntityFrameworkCore.MySql 5.0.0-alpha.2_

## Description

This web-based application allows a user to track Her stylists and their clients. Users may create multiple stylists and associate specific clients with a stylist. Users' data is stored in a SQL database.

## Setup/Installation Requirements

### Install C#, .NET, MySQL Community Server and MySQL Workbench
* Open the terminal on your local machine
* If [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [.NET](https://docs.microsoft.com/en-us/dotnet/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net)
* If [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-and-configuring-mysql)

### Clone the project
* Navigate to the directory inside of which you wish to house this project
* Clone this project with the command `$ git clone https://github.com/cicy886/HairSalon.Solution.git`

### Import and connect the database
* Launch the MySQL server with the command `mysql -uroot -p[YOUR-PASSWORD-HERE]`
* After the server starts running, open MySQL Workbench. *If at any point you have trouble finding a referenced portion of the workbench, make sure to expand the application window to full size.
* Select the MySQL instance in the _MySQLConnections_ section.
* Select the __Navigator>Administration__ tab.
* In the Navigator>Administration window, select __Data Import/Restore__; the Data Import window will open.
* In the __Import Options__ section of the Data Import window, select __Import from Self-Contained File__.
* Click the dots at the end of the __Import from Self-Contained__ file field (three dots for windows, two dots for Mac) and a pop up box will open. In the pop up box, navigate to the sisi_vieira.sql file in the root directory of the project (HairSalon.Solution/). Once correct file is selected, click open. The pop up box will close itself.
* In the __Default Schema to be Imported To__ section of the Data Import window, there is a __Default Target Schema__ drop box. To the right of the drop box, select the __New__ button and a pop up box will appear. In the pop up box, name the schema (i.e the databasen structure) `sisi_vieira`. Click __OK__.
* Click __Start Import__ at the bottom right corner of the window (If on a Mac the __Start Import__ button will be in the same view. If on a Windows machine first change to the __Import Progress__ tab to access the __Start Import__ button).
* Once import is complete, navigate to the workbench's __Navigator>Schemas__ tab, right click within the Schemas window and select __Refresh All__; the new database will appear. 
* In your terminal, navigate to the production project directory with the command `$ cd HairSalon.Solution/HairSalon`
* In your terminal, create a file within the project in which to store your connection string for connecting the project to the database with the command `touch appsettings.json`
* In your text editor add the following code to the newly created appsettings.json file. *Note that uid and pwd may vary depending on your local MySql configurations.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=sisi_vieira;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

### Run the project
* Recreate project environment and install required dependencies with terminal command `$ dotnet restore`
* Run the program in the console with the command `$ dotnet run`

## Known Bugs

* No known bugs.

## License
[MIT](https://opensource.org/licenses/MIT)

Copyright (c) **2021 Sisi Vieira**