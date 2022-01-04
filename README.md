Project setup - 

Required: 
- ASP.NET 6.0 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0) (SDK + Runtime's)
- Node.js LTS (https://nodejs.org/en/)

Recommended: 
- VSCode

Tasks 

Backend - 

We need a new endpoint that will return a combination of cat profiles.
Each cat profile needs to contain a "photo" and "name". I will also require
a limiter for the amount of cat photos returned. The cat photos are stored in 
{workplacePath}/ClientApp/public/photos. the files have random names. 

Front end - 
We need to display an infinite amount of cat photos with their names on the right. 
The cat photo should be circular. Refer to UX.jpg provided. The show more button will
call /cat/[5-15] endpoint. This will request 5-15 random cat profile photos.  


Tips:
Use best practices.
Don't worry if you dont finish every thing. 
Frontend is setup with bootstrap.



