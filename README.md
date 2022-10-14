# Student name: Cong Nha Le - 0761950

# Assignment 1: Product BEDS

# Date: 2022-10-13

# Work flow:

- Created Project on MAC

- Selected options: authentication and https

- Ran project with ```dotnet run``` => good

- Changed to company name Nap in my beds

- Added About Us Page. Thanks to free template https://bootstrapious.com/p/about-us-page

- Added Product Catalogue page

- Link company name to Product Catalogue page

- Installed nu packages

- Scaffold command : dotnet aspnet-codegenerator controller -name Web452Assignment1Controller -m Bed -dc Web452Assignment1Context --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

- Migrate command: dotnet ef migrations add InitialCreate --context Web452Assignment1Context

- Update database command : dotnet ef database update --context  Web452Assignment1Context

- Migration worked

- Seed data worked

- Add range 0 - 5 for customer review

- Changing product catalogue page style

- Changed product catalogue page and home page

- Changed routes Detail, Edit, Create 