# Net-Core-Postgres.-Docker
1) Open solution in VisualStudio.
2) Run application
3) On a browser, navigate to: 

http://localhost:8080/api/temperature

http://localhost:8080/api/mass

http://localhost:8080/api/length

 
Can test with these values:
http://localhost:8080/api/temperature/5/5  
 [HttpGet("{unitVal}/{UnitOfMeasure}")]

.Net application:
https://github.com/CamiKaze/Net-Core-Postgres.-Docker 

Docker:
pull Docker images by following the links below.
Images include the VS solution above, and the postgress db.
https://cloud.docker.com/u/camikaze/repository/docker/camikaze/postgres
https://cloud.docker.com/u/camikaze/repository/docker/camikaze/metr0politan

[Main C# .net core Assessment]


1. Create a Asp.net core API application for restful services.

2. API application must use Nuget.

 

[Rest of assessment]

3. API application needs to convert Metric units to Imperial units and vice versa.

4. API application must cater for at least 5 conversions including temperature (adding a conversation should be very extensible).

5. Create another application using the latest version of Angular for a front-end for your project.

6. Ensure that you have proper Unit and Integration testing on both applications.

7. The API application, Angular application and database needs to run on their own docker containers respectively.

8. Add all necessary scripts in order to deploy docker containers to Kubernetes environment.

9. Upload your project into your own GIT Repo and share the project with us.

[Optional – extra points]

10. Angular application must have a login page.

11. All user actions on the Angular frontend need to be stored in a relational database for auditing purposes (please include API’s for this purpose)

12. Properly abstract your data layer, use an ORM and PostgreSQL / MS SQL Server as your database implementation. 
