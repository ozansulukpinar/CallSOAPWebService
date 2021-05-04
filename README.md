# CallSOAPWebService
A web app created with C#

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Code Examples](#code-examples)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)

## General info
This is an ASP.Net Core MVC Web Application project. It posts HTTP request to the service. The service returns a message.

## Screenshots
![Page](https://user-images.githubusercontent.com/52232302/117070907-101bdc80-ad37-11eb-9c7f-e5aed543a67d.JPG)
	
## Technologies
Project is created with:
* C# version: 7.0

## Setup
These commands are run respectively to create project and add service reference to it:
```
dotnet new mvc
dotnet tool install --global dotnet-svcutil --version 2.0.3-preview1.20574.1
dotnet-svcutil http://www.learnwebservices.com/services/hello?WSDL
dotnet build
dotnet run
```

## Code Examples
```csharp
HelloEndpointClient client = new HelloEndpointClient();
var request = new helloRequest()
{
    Name = model.Name
};
var response = client.SayHelloAsync(request);

ViewData["Message"] = response.Result.Body.HelloResponse.Message;
```

## Features
List of features ready

* Post data to SOAP web service

## Status
Project is finished.

## Inspiration
This app is used a free, public SOAP web service, [Hello Web Service](http://www.learnwebservices.com/services/hello?WSDL), which was created by [@vicziani](https://github.com/vicziani).

## Contact
Created by [@ozansulukpinar](https://github.com/ozansulukpinar) - feel free to contact me!
