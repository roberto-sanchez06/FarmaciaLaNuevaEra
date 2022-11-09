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


create procedure Venta_Validacion @IdPedido int 
as 
begin 
	declare @IdMedicamento int, @CantidadPedida int, @CantidadMedicamento int
	declare detalleOrdenPedido Cursor for Select IdMedicamento, CantidadPedida from DetalleOrdenPedido where @IdPedido = DetalleOrdenPedido.IdPedidos
	Open detalleOrdenPedido 
	fetch detalleOrdenPedido into @IdMedicamento, @CantidadPedida
	while(@@FETCH_STATUS = 0)
	begin 
		select @CantidadMedicamento = Medicamento.Stock from Medicamento where @IdMedicamento = Medicamento.IdMedicamento
		if(@CantidadPedida > @CantidadMedicamento)
		begin
		update Pedidos set Estado = 0
		break
		end
	end
end


create procedure Mostrar_Pedidos @Mes int, @Ano int
as 
begin
Select p.IdPedidos as [Id del Pedido], p.IdEmpleado as [Id del Empleado],
	p.Fecha as [Fecha], p.Estado as [Estado del pedido]
from Pedidos p
where MONTH(p.Fecha) = @Mes and YEAR(p.Fecha) = @Ano
end

create procedure Crear_Pedidos @IdEmpleado int
as 
declare @fecha datetime, @IdPedido int
set @fecha = GETDATE()
Insert into Pedidos values(@IdEmpleado, @fecha, 1)

create procedure Crear_Detalle_Pedidos @IdPedido int, @IdMedicamento int, @CantidadPedida int
as
begin
Insert into DetalleOrdenPedido values (@IdPedido, @IdMedicamento, @CantidadPedida)
end

Insert into Empleado values('Kevin', 'Admin', '0')

create procedure Ultimo_Pedido
as 
begin
	Select Top 1 IdPedidos as [Id]
	from Pedidos
	order by IdPedidos desc
end

create procedure Ventas_Mensuales @Mes int, @Ano int
as 
begin 
	Select Day(p.Fecha) as Fecha, Sum(m.PrecioVenta * op.CantidadPedida) as [Cantidad Vendida]
	from DetalleOrdenPedido op inner join Medicamento m on m.IdMedicamento = op.IdMedicamento inner join 
	Pedidos p on p.IdPedidos = op.IdPedidos
    where @Mes = MONTH(p.Fecha) and @Ano = YEAR(p.Fecha)
	group by Day(p.Fecha) 
end

create procedure Ventas_Estado @Mes int, @Ano int, @Estado int
as 
begin
	Select Sum(m.PrecioVenta * op.CantidadPedida) as [Cantidad Vendida]
	from DetalleOrdenPedido op inner join Medicamento m on m.IdMedicamento = op.IdMedicamento inner join 
	Pedidos p on p.IdPedidos = op.IdPedidos
    where @Mes = MONTH(p.Fecha) and @Ano = YEAR(p.Fecha) and p.Estado = @Estado
end

create procedure [dbo].[Donaciones] @monto money 
as
begin 
declare @monto_anterior  money
declare @monto_total money
set @monto_anterior = (select valor from BalanceGeneral where IdBalanceGeneral = 2)
set @monto_total = @monto+@monto_anterior

update BalanceGeneral
set Valor = @monto_total
where IdBalanceGeneral = 2

declare @monto_anterior1  money
declare @monto_total1 money
set @monto_anterior1 = (select valor from BalanceGeneral where IdBalanceGeneral = 3)
set @monto_total1 = @monto+@monto_anterior1

update BalanceGeneral
set Valor = @monto_total1
where IdBalanceGeneral = 3
end

create procedure [dbo].[ingresar_dinero] @monto money
as
begin
declare @monto_anterior  money
declare @monto_total money
set @monto_anterior = (select valor from BalanceGeneral where IdBalanceGeneral = 1)
set @monto_total = @monto+@monto_anterior

update BalanceGeneral
set Valor = @monto_total
where IdBalanceGeneral = 1

declare @monto_anterior1  money
declare @monto_total1 money
set @monto_anterior1 = (select valor from BalanceGeneral where IdBalanceGeneral = 3)
set @monto_total1 = @monto+@monto_anterior1

update BalanceGeneral
set Valor = @monto_total1
where IdBalanceGeneral = 3
end


create procedure [dbo].[insertar_detalleCompra] @idcompra int , @idmedicamento int , @cantidad int 
as
begin
insert into DetalleOrdenCompra(IdOrdenCompra, IdMedicamento, CantidadPedida) values (@idcompra, @idmedicamento, @cantidad)
----------------------------------------------------------------------------------------------------------------------------------
declare @montocompra money 
declare @precio_compra money
declare @monto_anterior  money
declare @monto_total money
set @monto_anterior = (select valor from BalanceGeneral where IdBalanceGeneral = 2)
set @precio_compra = (select PrecioCompra from Medicamento where IdMedicamento=@idmedicamento)
set @montocompra = @precio_compra*@cantidad

set @monto_total = @monto_anterior-@montocompra

update BalanceGeneral
set Valor = @monto_total
where IdBalanceGeneral = 3
----------------------------------------------------------------------------
declare @stock_anterior int 
declare @stock_total int
set @stock_anterior = (select Stock from Medicamento where IdMedicamento=@idmedicamento)
set @stock_total = @stock_anterior+@cantidad

update Medicamento
set Stock = @stock_total
where IdMedicamento = @idmedicamento
------------------------------------------------------------------------------------------------
declare @monto_anteriorcompra  money
declare @monto_totalcompra money
set @monto_anteriorcompra = (select valor from EstadoResultado where IdEstadoResultado = 2)
set @monto_totalcompra = @monto_anterior+@montocompra

update EstadoResultado
set Valor = @monto_totalcompra
where IdEstadoResultado = 2
end


create procedure [dbo].[insertar_ordencompra] @idlab int
as
begin
insert into OrdenCompra(IdLaboratorio, Fecha)
values(@idlab, sysdatetime())
end


create procedure [dbo].[mostrar_laboratorio_activo] 
as
begin
select *
from Laboratorio
where Estado =1
end


create procedure [dbo].[ultimo_idcompra] 
as
begin
select top 1 IdOrdenCompra
from OrdenCompra
order by IdOrdenCompra desc
end

--create procedure [dbo].[Validar_Acceso]
--@nombrePerfil varchar(30),
--@contraseña varchar(50)
--as
--if exists (Select NombrePerfil from Usuario
--            where  cast (DECRYPTBYPASSPHRASE(@contraseña, Contra) as Varchar(100)) = @contraseña
--			 and NombrePerfil = @nombrePerfil and Estado = 'Habilitado' )
--			 select 'Acceso Exitoso' as Resultado,
--			 (Select Rolconexion from Usuario
--              where  cast (DECRYPTBYPASSPHRASE(@contraseña, Contra) as Varchar(100)) = @contraseña
--			 and NombrePerfil = @nombrePerfil and Estado = 'Habilitado') as Rol
--			 (Select IdUsuario from Usuario
--              where  cast (DECRYPTBYPASSPHRASE(@contraseña, Contra) as Varchar(100)) = @contraseña
--			 and NombrePerfil = @nombrePerfil and Estado = 'Habilitado') as IdUsuario
--			 else
--			 Select 'Acceso Denegado' as Resultado

--create procedure Insertar_Usuario
--@nombrePerfil varchar(50),
--@contraseña varchar(max),
--@rol varchar(50),
--@idEmpleado int
--as
--insert into Usuario(NombrePerfil, Contra, Rolconexion, Estado, idEmpleado) values
--(@nombrePerfil, ENCRYPTBYPASSPHRASE( @contraseña,  @contraseña), @rol, 'Habilitado', @idEmpleado)


create procedure [dbo].[verificar_efectivo] @monto_total money
as
declare @efectivo money
set @efectivo = (select valor from BalanceGeneral where IdBalanceGeneral = 3)
if @efectivo<@monto_total
select 'invalido'
else 
select 'valido'