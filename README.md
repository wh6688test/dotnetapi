Links :


//TO DO : Investigating using ViewModel

https://dotnetcoretutorials.com/2020/03/15/fixing-json-self-referencing-loop-exceptions/

https://www.tutorialsteacher.com/webapi/implement-put-method-in-web-api

https://www.tutorialsteacher.com/webapi/implement-get-method-in-web-api

https://stackoverflow.com/questions/54274166/how-does-ef-core-modified-entity-state-behave

https://docs.microsoft.com/en-us/ef/core/miscellaneous/async

----

https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/update-related-data?view=aspnetcore-5.0

https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-5.0

https://github.com/dotnet/AspNetCore.Docs/tree/master/aspnetcore/data/ef-mvc/intro/samples/cu-final

https://stackoverflow.com/questions/54596180/asp-net-core-web-api-ef-core-models-with-foreign-key-relationship

https://docs.microsoft.com/en-us/ef/core/querying/related-data/
https://github.com/dotnet/EntityFramework.Docs/tree/master/samples/core/Querying/RelatedData

https://github.com/dotnet/EntityFramework.Docs/blob/master/samples/core/Querying/RelatedData/BloggingContext.cs
i
https://www.learnentityframeworkcore.com/dbcontext/modifying-data

https://docs.microsoft.com/en-us/ef/core/modeling/

https://stackoverflow.com/questions/29272581/why-ef-navigation-property-return-null


1. https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio-code

generate controller codes after downloading all the templates/packages and tools 
:

   dotnet aspnet-codegenerator controller -name GroupsController -async -api -m Group  -dc GroupContext -outDir Controllers -f

(start service in watch mode : 
   (dotnet watch run : to start the server)

get dotnet packages : 

(dotnet add package : 

   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
)
https://localhost:5001/swagger/index.html


https://github.com/dotnet-architecture

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-5.0&tabs=visual-studio

https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-5.0


https://github.com/dotnet/efcore/issues/14713

---


https://www.learnentityframeworkcore.com/dbcontext/adding-data

https://docs.microsoft.com/en-us/ef/core/querying/related-data/


https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/update-related-data?view=aspnetcore-5.0

----
https://www.learnentityframeworkcore.com/configuration/data-annotation-attributes/foreignkey-attribute

https://www.learnentityframeworkcore.com/configuration/fluent-api/hasforeignkey-method
----

https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key

----


Either following naming convention or annotation in Model or override default in DBContext (Fluid)

EF Core 5 : 

https://henriquesd.medium.com/entity-framework-core-5-0-many-to-many-relationships-52c6c8b07b6e

https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0

----

Architecture : 

https://docs.microsoft.com/en-us/azure/architecture/patterns/cqrs


-----

 
2. 
https://codeburst.io/how-to-set-up-a-modern-full-stack-net-web-development-environment-on-mac-os-542dcd43a564

(do net package manager : NuGet)

  (Download .NET Core SDK  : not just the runtime)


     -- THE SDK comes with useful command line utilities that will alow use
to create a .NET Core project)

https://dotnet.microsoft.com/download

https://docs.microsoft.com/en-us/dotnet/core/dotnet-five

(.NET 5 vs .NET CORE (3.X)  VS .NET FRAMEWORK (4.X))


  (.NET SDK 5.0 101
   .NET Runtime 5.0.1

(https://stackify.com/net-core-vs-net-framework/ : different dotnet component info)

https://docs.microsoft.com/en-us/dotnet/core/tools/telemetry : 

   telemetry info :  

https://docs.microsoft.com/en-us/dotnet/core/tools/telemetry
  (how to opt it out)

https://www.michaelcrump.net/part12-aspnetcore/

trust the dev key on mac : 

dotnet dev-certs https --help

equivalent to : 

sudo security add-trusted-cert -d -r trustRoot -k /Library/Keychains/System.keychain <<certificate>>


====

Deploying and Hosting : 

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/?view=aspnetcore-5.0


3. dotnet library : 

   awesome dont net library

---

Java Springboot for comparison : 

   https://howtodoinjava.com/spring-boot2/spring-boot-crud-hibernate/



