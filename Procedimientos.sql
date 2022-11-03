Use Farmacia
go

Create Trigger VentaValidacion
on [DetalleOrdenPedido]
for Insert 
as 
	Declare @cantidadMedicamentos int 
	Select @cantidadMedicamentos = Stock from Medicamento m inner join inserted on inserted.CantidadPedida = m.Stock where inserted.CantidadPedida = m.Stock
	if(@cantidadMedicamentos >= (Select CantidadPedida from inserted))
	update Medicamento set Stock = Stock - @cantidadMedicamentos
	from Medicamento m inner join inserted on inserted.IdMedicamento = m.IdMedicamento
	where m.IdMedicamento = inserted.IdMedicamento
	else 
	begin 
	update Pedidos set Estado = 0
	from Pedidos p inner join inserted on inserted.IdPedidos = p.IdPedidos
	where inserted.IdPedidos = p.IdPedidos
	end

create trigger AumentoInventario
on [DetalleRemito]
for Insert 
as 
	Update Medicamento set Stock = Stock + inserted.CantidadRecibida
	from Medicamento m inner join inserted on inserted.IdMedicamento = m.IdMedicamento
	where m.IdMedicamento = inserted.IdMedicamento


Create procedure ReposicionStock 
as
 declare @IdMedicamento int, @CantidadStock int, @CantidadMinima int, @IdLaboratorio int
 declare Medicamentos Cursor for Select IdMedicamento, Stock, StockMinimo from Medicamento
Open Medicamentos 
fetch Medicamentos into @IdMedicamento, @CantidadStock, @CantidadMinima
while(@@FETCH_STATUS = 0)
begin
	if(@CantidadStock < @CantidadMinima)
	begin 
	declare @fecha datetime
	set @fecha = GETDATE()
	Insert into OrdenCompra (IdLaboratorio, Fecha) values (@IdLaboratorio, @fecha)
	declare @IdOrdencompra int, @CantidadReposicion int 
	set @IdOrdencompra = SCOPE_IDENTITY()
	set @CantidadReposicion = @CantidadMinima - @CantidadStock
	Insert into DetalleOrdenCompra values(@IdOrdencompra, @IdLaboratorio, @CantidadReposicion)
	end
	fetch next from Medicamentos
end

close Medicamentos

Deallocate Medicamentos


create procedure Insertar_Medicamento
@IdLaboratorio int,@Nombre varchar(30),@PrecioCompra money, @precioVenta money,@Stock int, @stockMinimo int
as
begin
insert into Medicamento values(@IdLaboratorio,@Nombre,@PrecioCompra,@precioVenta,@Stock,@stockMinimo)
end

execute Insertar_Medicamento 0,'Lorazepam',222,555,2,1

select * from Medicamento

create procedure Actualizar_Medicamento
 @idMedicamento int, @IdLaboratorio int,@Nombre varchar(30),@PrecioCompra money, @precioVenta money,@Stock int, @stockMinimo int
as
update Medicamento
set Nombre=@Nombre, PrecioCompra=@PrecioCompra,PrecioVenta=@precioVenta,Stock=Stock+@Stock,StockMinimo=@stockMinimo,IdLaboratorio=@IdLaboratorio
where IdMedicamento=@idMedicamento

execute Actualizar_Medicamento 0,0,'Lorazepam',222,555,55,1

select * from Medicamento
create procedure Insertar_Laboratorio
 @Nombre varchar(30)
as
begin 
insert into Laboratorio values(@Nombre)
end

execute Insertar_Laboratorio 'Ramos'

select * from Laboratorio
 create procedure Actualizar_Laboratorio
@idLaboratorio int, @NombreCambiado varchar(30)
as
	begin
		update Laboratorio 
		set Nombre=@NombreCambiado
		where IdLaboratorio=@idLaboratorio
	end

execute Actualizar_Laboratorio 0,'Ramos S.A'

select * from Laboratorio

/*
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

*/
create Procedure Mostrar_Medicamentos
as 
begin
select	M.IdMedicamento as [Id del Medicamento], (select Nombre from Laboratorio where IdLaboratorio=M.IdLaboratorio) as Laboratorio,
M.Nombre as [Medicamento], Round(M.PrecioCompra,2) as [Precio comprado], ROUND(M.PrecioVenta,2) as [Precio a vender], M.Stock as [Cantidad en inventario], M.StockMinimo as [Cantidad minima a tener]
from Medicamento as M
end
execute Mostrar_Medicamentos

create procedure Mostrar_Laboratorios
as
begin 
select L.IdLaboratorio as [Id del Laboratorio], L.Nombre as [Laboratorio]  from Laboratorio as L
end

execute Mostrar_Laboratorios


create procedure CantidadMedicamento	
as
begin 
select count(*) as CantidadMedicamento from Medicamento 
end
execute CantidadMedicamento
/*


*/
