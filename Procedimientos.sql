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

