create database Parcial1_LindonCastillo_Db
go

use Parcial1_LindonCastillo_Db
go

create table Productos
(
	ProductoId int primary key identity,
	Descripcion varchar(100),
	Existencia int,
	Costo decimal
)
go

DROP DATABASE Parcial1_LindonCastillo_Db
GO

select * from Productos