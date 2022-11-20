use Farmacia
go

--procedimientos para usuarios
alter proc ActualizarUsuario @idUsuario int,@idEmpleado int,@nombre varchar(60), @contraseña varchar(300), @rolConexion varchar(20)
as
	if(@contraseña<>'No modificada')
		begin
			update Usuario set NombrePerfil = @nombre, Rolconexion = @rolConexion, IdEmpleado = @idEmpleado,
			Contra = ENCRYPTBYPASSPHRASE( @contraseña,  @contraseña) where IdUsuario = @idUsuario
		end
	else
		begin
			update Usuario set NombrePerfil = @nombre, Rolconexion = @rolConexion, IdEmpleado = @idEmpleado
			where IdUsuario = @idUsuario
		end

create proc MostrarUsuario
as
Select IdUsuario, (select CONCAT(Nombres,' ', Apellidos) from Empleado where IdEmpleado = Usuario.IdEmpleado) as [Nombres y apellidos del empleado],
IdEmpleado ,NombrePerfil as [Nombre del perfil], Rolconexion as Rol, Estado from Usuario

--create proc CambiarEstado @idUsuario int
--as 
--	if (select Estado from Usuario where IdUsuario = @idUsuario) = 'Habilitado' 
--		update Usuario set Estado = 'Deshabilitado' where IdUsuario = @idUsuario
--	else
--		update Usuario set Estado = 'Habilitado' where IdUsuario = @idUsuario

create proc CambiarEstado @idUsuario int
as 
	if not exists(select * from Usuario as u inner join Empleado as e on e.IdEmpleado = u.IdEmpleado
			where e.Estado = 'Inactivo' and IdUsuario = @idUsuario)
		begin
			if (select Estado from Usuario where IdUsuario = @idUsuario) = 'Habilitado' 
				update Usuario set Estado = 'Deshabilitado' where IdUsuario = @idUsuario
			else
				update Usuario set Estado = 'Habilitado' where IdUsuario = @idUsuario
		end
	--else
	--	RAISERROR('No se puede habilitar a este usuario porque el empleado asociado no esta activo',10,1)

create proc BuscarUsuario @dato varchar(200)
as
	Select IdUsuario, (select CONCAT(Nombres,' ', Apellidos) from Empleado where IdEmpleado = Usuario.IdEmpleado) as [Nombres y apellidos del empleado],
	IdEmpleado ,NombrePerfil as [Nombre del perfil], Rolconexion as Rol, Estado from Usuario
	where NombrePerfil like @dato+'%' or Rolconexion like @dato+'%' or Estado like @dato+'%'

create proc CantidadUsuarios
as
	select count(*) as CantidadUsuarios from Usuario 

--create proc CantidadAdmin
--as 
--	select count(*) as Cantidad from Usuario where Rolconexion = 'Administrador' and
--	Estado = 'Habilitado'

--procedimientos para empleados
create proc InsertarEmpleado @Nombres varchar(60), @apellidos varchar(60),@Cargo varchar(50), @sueldo money
as
	insert Empleado(Nombres, Apellidos,Cargo, Sueldo, Estado) values (@Nombres, @apellidos,@Cargo, @sueldo, 'Activo')

create proc ActualizarEmpleado @idEmpleado int,@nombres varchar(60), @apellidos varchar(60), 
@cargo varchar(60), @sueldo money
as
	update Empleado set Nombres = @nombres, Cargo = @cargo, Sueldo = @sueldo, Apellidos = @apellidos
	where IdEmpleado = @idEmpleado

create proc MostrarEmpleados
as
	select IdEmpleado, Nombres, Apellidos, Cargo, Sueldo, Estado from Empleado

create proc CambiarEstadoEmpleado @idEmpleado int
as
	if (select Estado from Empleado where IdEmpleado = @idEmpleado) = 'Inactivo' 
	begin
		update Empleado set Estado = 'Activo' where IdEmpleado = @idEmpleado
		update Usuario set Estado = 'Habilitado' where IdEmpleado = @idEmpleado
	end 
	else
	begin
		update Empleado set Estado = 'Inactivo' where IdEmpleado = @idEmpleado
		update Usuario set Estado = 'Deshabilitado' where IdEmpleado = @idEmpleado
	end

create proc BuscarEmpleado @dato varchar(40) 
as
	--select * from Empleado where Nombre like '%'+@dato+'%' or Cargo like @dato+'%'
	select IdEmpleado, Nombres, Apellidos, Cargo, Sueldo, Estado
	from Empleado where Nombres like '%'+@dato+'%' or Apellidos like '%'+@dato+'%'
	or Cargo like '%'+@dato+'%' or Estado like '%'+@dato+'%'

create proc CantidadEmpleados
as
	select count(*) as CantidadEmpleados from Empleado

create proc MostrarEmpleadoPorID @idEmpleado int 
as
	select IdEmpleado, Nombres, Apellidos, Cargo, Sueldo, Estado from Empleado
	where IdEmpleado = @idEmpleado

--añadiendo empleado a administrador 
select * from Usuario
select * from Empleado

update Usuario set IdEmpleado = 1 where IdUsuario = 0

--añadiendo funcion para validar administrador

--create function VerificarAdmin(@idUsuario int)
--returns bit 
--as
--begin
--	if ((select Rolconexion from Usuario where IdUsuario = @idUsuario) = 'Administrador')
--		return 1
--	return 0
--end

create function fn_VerificarAdmin(@idUsuario int)
returns bit 
as
begin
	if ((select Rolconexion from Usuario where IdUsuario = @idUsuario) = 'Administrador'
		and (select Estado from Usuario where IdUsuario = @idUsuario) = 'Habilitado')
		and (select count(*) from Usuario where Rolconexion = 'Administrador' and Estado = 'Habilitado') = 1
	--if exists (select * from Usuario where IdUsuario = @idUsuario and Rolconexion = 'Administrador'
	--			and Estado = 'Habilitado') 
		return 1
	return 0
end

select * from Usuario
update Usuario set Estado = 'Habilitado' where IdUsuario = 4

select dbo.fn_VerificarAdmin(4)
drop proc CantidadAdmin

select * from Empleado
drop proc MostrarEmpleadoPorID

create function fn_VerificarAdminPorEmpleado(@idEmpleado int)
returns bit 
as
begin
	declare @idUsuario int, @resultado bit
	select top 1 @idUsuario = IdUsuario from Usuario as u inner join Empleado as e
	on e.IdEmpleado = u.IdEmpleado
	where e.IdEmpleado = @idEmpleado and u.Rolconexion = 'Administrador'
	select @resultado = dbo.fn_VerificarAdmin(@idUsuario)
	return @resultado
end

select * from Usuario
select * from Empleado
update Empleado set Cargo = 'Gerente' where IdEmpleado = 0
update Empleado set Apellidos = 'Gonzalez', Nombres = 'Martin' where IdEmpleado = 2
update Usuario set NombrePerfil = 'pepeadmin' where IdUsuario = 4

select dbo.fn_VerificarAdminPorEmpleado(1)

create function fn_VerificarNombreUsuario (@nombreUsuario varchar(50))
returns bit 
as
begin
	if exists(select * from Usuario where NombrePerfil = @nombreUsuario)
		return 1
	return 0
end

update Empleado set Estado = 'Activo' where IdEmpleado = 0
update Usuario set Estado = 'Habilitado' where IdUsuario = 4

--ejectuando procedimientos
exec InsertarEmpleado 'Oscar Antonio', 'Muñoz Sánchez', 'Gerente', 30000
exec Insertar_Usuario 'admin1', '123', 'Administrador', 1

delete from Usuario where IdUsuario <4
select * from Usuario

drop proc [dbo].[MostrarEmpleadoPorID]