# _Pierre's Treat Shop_

#### _Epicodus C# Week 5 solo project, 3/27/2020_

#### By _Matt Taylor_

## Description

_Using a database, the user can create a stored list of treats and their flavors, modifying them and viewing their many-to-many relationship in the database._

## Behavior Driven Development
| Behavior | Input | Output |
|----|----|-----|
| Web application loads | 'dotnet run' | Page is displayed |
| User adds a new treat | click link, fill form | New treat is added to list |
| Application displays list of input treats | click link | List is shown of treats with details |
| User adds a new flavor | click link, fill form | New flavor is added to list, by flavor |
| Application displays list of input flavors by flavor | click on flavor link | flavor list is displayed |
| Application allows editing of treat and flavor entries | click link | Entry information is edited |
| Application allows removal of treat and flavor entries | click link | Entry is removed from list |

## Setup/Installation Requirements

* Open Terminal
* Type ``$ git clone https://github.com/mtaylorpdx/TreatShop.Solution``
* Navigate to the directory TreatShop.Solution/TreatShop
* type ``$ dotnet ef database update``
* Type ``$ dotnet run``
* Open your browser and enter the address ``localhost:5000``

## Support and contact details

Email [@Matt Taylor](mailto:me@email.com)

## Technologies Used

* Git
* C#
* .NET Core 2.2
* ASP.NET Razor 2.2.0
* MySql 2.2.0
* Entity Framework Core 2.2.6

### License

*Licensed under the MIT License*

Copyright (c) 2020 **_Matt Taylor_**