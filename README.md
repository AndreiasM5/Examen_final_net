To run this project:

cd Backend

dotnet ef migrations add InitialCreate

dotnet ef database update InitialCreate

dotnet run

cd Frontend

ng serve
