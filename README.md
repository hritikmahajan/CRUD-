For the solution 
right click the solution file and build and clean the solution
right click again and go to terminal and run command dotnet run
it will load on the URL mentioned as now listening on for eg http://localhost:5000/swagger
The UI page will open and we can run the Web App in the API

For Docker initialisation
Build the app by opening the terminal in the project
"docker build -t my-app ".
After successful build, run the command 
docker run -d -p 8080:8080 -p 8081:8081 my-app
Then open http://localhost:8080
The API will open 


