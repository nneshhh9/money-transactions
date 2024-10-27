#обновить/создать бд
dotnet ef database update -c MoneyTransactions.Api.Data.ApplicationDbContext --project MoneyTransactions.Api

#добавить миграцию
dotnet ef migrations add CreateCategoryTable -c MoneyTransactions.Api.Data.ApplicationDbContext --project MoneyTransactions.Api
dotnet ef migration add CreateCategoryTable

#удалить миграцию
dotnet ef migrations remove