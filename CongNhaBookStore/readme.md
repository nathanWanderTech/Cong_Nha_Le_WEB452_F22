# Student name: Cong Nha Le - 0761950

# Assignment 2: 

# Date: 2022-10-25

# Work flow:

- Init projects

- Changed Bootswatch theme

- Added dropdown in nav bar

- Add 3 project class CongNhaBooks.DataAccess, CongNhaBooks.Models, CongNhaBooks.Utility

- 2022-11-06 19:07: move CongNhaBooks.DataAccess, CongNhaBooks.Models, CongNhaBooks.Utility into Bookstore folder. Hope this fix .cspj not found

- 2022-11-06 19:08: delete migration folder and move Data folder into DataAccess

- 2022-11-06 19:40: Fix cannot find Error View Model

- 2022-11-06 21:10: Fix reference issues

- 2022-11-07 12:34: Add customers area

- 2022-11-07 12:34: Move Home view to customers area

- 2022-11-07 12:53: Edit layout path after moved _ViewStart into Area Customers Views

- 2022-11-11 12:56: Changed area in Home nav link but not working ??

- 2022-11-11 14:53: run add-migration AddDefaultIdentityMigration. Succeeded. File name: 20221111194841_AddDefaultIdentityMigration.cs

- 2022-11-12 09:21: create file Category.cs in Model. 

- 2022-11-12 09:34: Add Category into DBContext file. TODO: run command add-migration AddCategoryToDb and update-database

-2022-11-12 09:52: Add IRepository file

-2022-11-12 10:20: Add and modify CategoryRepository.cs

-2022-11-12 10:22: add update method in ICategoryRepository.cs

-2022-11-12 10:22: Add update method in CategoryRepository.cs

-2022-11-12 10:35: Create ISP_Call file and install Dapper package

-2022-11-12 10:35: Modified ISP_Call.cs

-2022-11-12 12:27: Modified SP_Call.cs, create IUnitOfWork and UnitOfWork

-2022-11-12 12:33: Add UnitOfWork in startup.cs config

-2022-11-12 12:52: Add Category Controller and Index view for Category

-2022-11-12 12:57: Moved link to Category to dropdown

-2022-11-12 13:06: Add category.js

-2022-11-12 13:19: Add Upsert method in Category Cotroller

-2022-11-12 13:28: Add partial view for CreateAndBacktoListButton

-2022-11-12 13:30: Add partial view for EditAndBacktoListButton

-2022-11-12 13:41: Modified Upsert cshtml to add partial Button view

-2022-11-12 13:46: Add _ValidationScriptsPartial in Upsert view

-2022-11-12 14:05: Create Upsert POST action in Category controller

-2022-11-12 14:12: Create Delete Category action in Category controller

-2022-11-12 14:15: Create Delete function in category.js

-2022-11-14 11:23: Run add-migartion AddCategoryToDb to generate file 20221114162239_AddCategoryToDb.cs

-2022-11-14 12:43: Removed all old migration file by command remove-migration and add new migration file to fix errors. 20221114173852_NewMigrationAfterRemoveOld.cs

-2022-11-14 12:43: Fix typo error scripts in category view Index

-2022-11-14 13:13: Fix _CreateAndBackToListButton.cshtml not found

-2022-11-21 13:35: START PART 3

-2022-11-21 14:36: Add Cover Type class, ICoverType, ICoverTypeRepository and added into Unit of Work

-2022-11-21 14:40: add migration 20221121193941_AfterAddCoverType

-2022-11-21 14:47: add cover type controller

-2022-11-21 14:58: Add cover type view and coverType.js

-2022-11-21 15:05: Add product model file

-2022-11-21 15:07: Add MIGRATION PRODUCT 20221121200735_AddProductToDb

-2022-11-21 15:10: Update required title, ISBN and Author in product Model

-2022-11-21 15:18:  Add MIGRATION 20221121201829_AddValidationToProduct