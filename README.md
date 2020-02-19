# Weather Forecast Microservice
## Purpose
This .Net Core application is meant to represent a REST microservice.  It will be completely independent from any consumer application to include being deployed to its own Azure App Service.
## Goals
<ul>
  <li>
    Configure APIM to provide one external facing endpoint while allowing me to make changes to the service without requiring consumers to change their endpoints.
  </li>
  <li>
    Grow the service to be something more interesting than a static weather forecaster.
  </li>
  </ul>


# Tools
## NSwag
Documentation - https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio
Purpose - Can generate Swagger UI on the API side.  Can use the NSwagStudio tool to generate code from the Swagger UI to be consumed by client applications.
