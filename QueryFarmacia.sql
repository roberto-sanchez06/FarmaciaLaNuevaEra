--use master 
--go
--Create Database Farmacia

Use Farmacia 
go

create table Usuario(
	IdUsuario int primary key identity(0, 1), 
	IdEmpleado int, 
	NombrePerfil varchar(30) not null, 
	Contra varchar(20) not null, 
	Rolconexion varchar(15) not null, 
)
go

create table Empleado(
	IdEmpleado int primary key identity(0, 1), 
	Nombre varchar(30) not null,
	Cargo varchar(30) not null,
	Sueldo Money not null
)
go

alter table Usuario
add foreign key(IdEmpleado)
references Empleado(IdEmpleado)
go 

create table Pedidos(
	IdPedidos int primary key identity(0, 1),
	IdLaboratorio int,
	IdEmpleado int,
	Fecha datetime not null, 
	Estado bit not null,
)
go 

create table Laboratorio(
	IdLaboratorio int primary key identity(0, 1),
	Nombre varchar(25) not null
)
go

alter table Pedidos
add foreign key(IdEmpleado)
references Empleado(IdEmpleado)
go 

alter table Pedidos
add foreign key(IdLaboratorio)
references Laboratorio(IdLaboratorio)
go 

create table Medicamento(
	IdMedicamento int primary key identity(0, 1),
	IdLaboratorio int,
	Nombre varchar(30) not null,
	PrecioCompra money not null,
	PrecioVenta money not null,
	Stock int not null,
	StockMinimo int not null
)
go


alter table Medicamento 
add foreign key(IdLaboratorio)
references Laboratorio(IdLaboratorio)
go


create table DetalleOrdenPedido(
	IdDetalleOrdenPedido int primary key identity(0, 1),
	IdPedidos int,
	IdMedicamento int, 
	CantidadPedida int not null
)
go

alter table DetalleOrdenPedido
add foreign key(IdPedidos)
references Pedidos(IdPedidos)
go

alter table DetalleOrdenPedido
add foreign key(IdMedicamento)
references Medicamento(IdMedicamento)
go

create table OrdenCompra(
	IdOrdenCompra int primary key identity(0, 1),
	IdLaboratorio int, 
	Fecha datetime not null
)
go

alter table OrdenCompra
add foreign key(IdLaboratorio)
references Laboratorio(IdLaboratorio)
go

create table DetalleOrdenCompra(
	IdDetalleOrdenCompra int primary key identity(0, 1), 
	IdOrdenCompra int, 
	IdMedicamento int,
	CantidadPedida int not null
)
go

alter table DetalleOrdenCompra
add foreign key(IdOrdenCompra)
references OrdenCompra(IdOrdenCompra)
go

alter table DetalleOrdenCompra
add foreign key(IdMedicamento)
references Medicamento(IdMedicamento)
go

create table Remito(
	IdRemito int primary key identity(0, 1),
	IdOrdenCompra int, 
	Fecha datetime not null
)
go

create table DetalleRemito(
	IdDetalleRemito int primary key identity(0, 1),
	IdRemito int, 
	IdMedicamento int, 
	CantidadRecibida int not null
)
go

alter table Remito
add foreign key(IdOrdenCompra)
references OrdenCompra(IdOrdenCompra)
go


alter table DetalleRemito
add foreign key(IdRemito)
references Remito(IdRemito)
go

alter table DetalleRemito 
add foreign key(IdMedicamento)
references Medicamento(IdMedicamento)
go

--create table Cuentas(
--	IdCuentas int primary key identity(0, 1), 
--	Nombre varchar(30) not null,
--	Valor money not null,
--	Fecha datetime not null
--)
--go

alter table Usuario 
alter column Contra varchar(150) not null

alter table Usuario 
add Estado varchar(30) not null


create table BalanceGeneral(
	IdBalanceGeneral int primary key identity(0, 1),
	Nombre varchar(Max) not null,
	Valor money,
	Tipo bit,
	Fecha datetime
)
go

create table EstadoResultado(
	IdEstadoResultado int primary key identity(0, 1),
	Nombre varchar(Max) not null,
	Valor money,
	Tipo bit,
	Fecha datetime
)
go

alter table Empleado
add Activo bit not null

alter table Empleado
drop column Nombre 

alter table Empleado
add Nombres varchar(60) not null

alter table Empleado 
add Apellidos varchar(60) not null

--alter table Empleado 
--add Nombre varchar(30) not null 

alter table Empleado
drop column Activo 

alter table Empleado
add Estado varchar(20) not null

backup database Farmacia
to disk = 'D:\BackupFarmacia.bak'