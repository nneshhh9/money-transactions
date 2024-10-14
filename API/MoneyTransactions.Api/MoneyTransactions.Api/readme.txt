#обновить/создать бд
dotnet ef database update -c MoneyTransactions.Data.ApplicationDbContext --project MoneyTransactions

#добавить миграцию
dotnet ef migration add CreateCategoryTable -c MoneyTransactions.Data.ApplicationDbContext --project MoneyTransactions