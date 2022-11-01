Create login adminFarmacia with password = 'adminF4rmac1a$123'
create login empleadoFarmacia with password = 'empleadoF4rmac1a$123'
use Farmacia
go
sp_adduser adminFarmacia, adminFarmacia
sp_adduser empleadoFarmacia, empleadoFarmacia

-- Procedimiento almacenado para insertar usuario 
Create procedure Insertar_Usuario
@nombrePerfil varchar(50),
@contraseña varchar(max),
@rol varchar(50)
as
insert into Usuario(NombrePerfil, Contra, Rolconexion, Estado) values
(@nombrePerfil, ENCRYPTBYPASSPHRASE( @contraseña,  @contraseña), @rol, 'Habilitado')

 exec Insertar_Usuario 'Admin', 'adminFarmacia123', 'Administrador'
 select * from Usuario
 exec Insertar_Usuario 'EmpleadoJuan', 'juanEmpleado123', 'Empleado'

--Procedimiento para validar acceso
Create procedure [dbo].[Validar_Acceso]
@nombrePerfil varchar(30),
@contraseña varchar(50)
as
if exists (Select NombrePerfil from Usuario
            where  cast (DECRYPTBYPASSPHRASE(@contraseña, Contra) as Varchar(100)) = @contraseña
			 and NombrePerfil = @nombrePerfil and Estado = 'Habilitado' )
			 select 'Acceso Exitoso' as Resultado
			 else
			 Select 'Acceso Denegado' as Resultado

Execute dbo.Validar_Acceso 'Admin', 'adminFarmacia123'
Execute dbo.Validar_Acceso 'EmpleadoJuan', 'juanEmpleado123'

--agregando permisos
grant execute on Validar_Acceso to adminFarmacia