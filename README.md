
#### By Caroline Cerussi

#### {Hair Salon}

## Technologies Used

* C#
* Razor
* HTML
* CSS
* Bootstrap
* MySql
* Entity

## Description

This web application allows Claire, the salon owner, to access a database of her stylists and their clients. On the home page, you have the option to view your clients and your stylists. You can navigate to a particular stylist to view their specific clients, along with their name and date hired.

## Setup/Installation Requirements

* Open Git Bash or PowerShell if on Windows and Terminal if on Mac Os
* Run the command :  cd Desktop
* Run the command : git clone https://github.com/carolinecerussi/HairSalon.git
* Open directory in VSCode
* navigate to HairSolution directory in terminal
* add file appsettings.json under HairSolution directory
* copy and paste to  JSON text
  :
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]"
  }
}

* Replace [YOUR-USERNAME-HERE] with your MySQL username.
* Replace [YOUR-PASSWORD-HERE] with your MySQL password.

To Run 

* run the command dotnet build under HairSalon directory in console
* Then, run the command dotnet run


This program was built using Microsoft .NET SDK 5.0.401, and may not be compatible with other versions. Your milage may vary.


## Known Bugs

* WIP - has issues navigating to pages(linking to MySql)

## License
Copyright (c) 2022 Caroline Cerussi

