# Skeleton-workshop

Cambiar la configuracion de "appsettings.development.json", y usar el update para crear la base de datos:

`dotnet ef database update --project .\Persistence\ --startup-project .\API\`

### Script

```SQL
use workshopdb;

insert into warehouse(Name) values ("Pristino");
insert into warehouse(Name) values ("Firma");
insert into warehouse(Name) values ("Heroes");
insert into warehouse(Name) values ("Fortis");
insert into warehouse(Name) values ("Vector");
insert into warehouse(Name) values ("Condor");

insert into product(Name, Stock, IdWarehousefk) values ("Tv",12,1);
insert into product(Name, Stock, IdWarehousefk) values ("Mobile",6,2);
insert into product(Name, Stock, IdWarehousefk) values ("Keyboard",7,4);
insert into product(Name, Stock, IdWarehousefk) values ("Mouse",15,6);
insert into product(Name, Stock, IdWarehousefk) values ("Graphic Card",23,5);
insert into product(Name, Stock, IdWarehousefk) values ("RAM",10,3);
insert into product(Name, Stock, IdWarehousefk) values ("Samsung Screen",4,2);
insert into product(Name, Stock, IdWarehousefk) values ("PS5",3,1);
```
