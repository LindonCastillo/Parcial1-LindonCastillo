create database Parcial1Db
go

use Parcial1Db
go

create table Productos
(
	ProductoId int primary key identity,
	Descripcion varchar(100),
	Existencia int,
	Costo decimal
)
go

DROP DATABASE Parcial1Db
GO

select * from Productos