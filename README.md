#recipology

#####This project brings version control to recipes!

#####By Anthony J Bottemiller - 3-9-2016

##Description
This project looks to utilize Microsoft Identity and Entity Framework with SQL Server to allow users to have meaningful version control for their recipes.

##Technologies Used
* HTML
* CSS
* BOOTSTRAP
* C#
* .NET Core
* ASP.NET MVC
* Razor
* AJAX
* Microsoft .NET Identity
* Microsoft Entity Framework
* Microsoft SQL Server

##Requirements
* Modern Web Browser
* .NET CORE
* MS SQL Server
* Internet Access

##Installation
* Clone repository
* Using command line change working directory to cloned repository/src/recipology
* Execute command "dotnet restore" in order to resolve project dependencies
* Execute command "dotnet ef migrations add init" in order to generate a migration script to initialize your database
* Execute command "dotnet ef database update" to initialize your database
* Execute command "dotnet run"
* Navigate to [webserver](http://localhost:5000) using your favorite browser

##Legal
Copyright (c) 2017 Anthony J Bottemiller

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.