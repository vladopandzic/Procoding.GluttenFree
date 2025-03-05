
Apply local migration: 
Run from root: (notice: no space after local)

set ASPNETCORE_ENVIRONMENT=Development&& dotnet ef migrations add "MigrationName" --context "GluttenFreeDbContext" --project Procoding.GluttenFree.Database --startup-project Procoding.GluttenFree.ApiService

Update database:
set ASPNETCORE_ENVIRONMENT=Development&& dotnet ef database update --context "GluttenFreeDbContext" --project Procoding.GluttenFree.Database --startup-project Procoding.GluttenFree.ApiService


Local connection string:
"ConnectionStrings": {
	"MyCtbConnection": "Data Source=.;Initial Catalog=GluttenFreeDb;Trusted_Connection=True;MultipleActiveResultSets=true; Integrated Security=True; TrustServerCertificate=True"
  }
```