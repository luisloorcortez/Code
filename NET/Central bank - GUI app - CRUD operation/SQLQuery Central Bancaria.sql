--Creamos la base de datos.
create database CentralBancaria
go

--Ponemos en uso la base de datos creada.
use CentralBancaria
go

--Creamos la base de datos 
create table clientes
(
Código varchar(10),
Cédula varchar(10),
Nombre varchar(50),
Apellidos varchar(75),
Edad int,
Cuenta varchar(75),
Tarjeta varchar(75),
Teléfono varchar(75),
Dirección varchar(75),
Estado varchar(75) DEFAULT 'Activo'
);
go

--Creamos procedimiento de busqueda
create proc [dbo].[sp_buscar_clientes]
@nombre varchar(50)
as
select Código,Cédula,Nombre,Apellidos,Edad,Cuenta,Tarjeta,Teléfono,Dirección, Estado from clientes where nombre like @nombre + '%'
go

--Cremos procedimiento listar clientes
create proc [dbo].[sp_listar_clientes]
as
select * from clientes order by Código
go


--realizamos la asignación de alias para cada elemento en la tabala de la base de datso a utilizar. 
create proc [dbo].[sp_mantenimiento_clientes]
@codigo varchar(10),
@cedula varchar(10),
@nombre varchar(50),
@apellidos varchar(75),
@edad int,
@cuenta varchar(15),
@tarjeta varchar(50),
@telefono varchar(75),
@direccion varchar(75),
@estado varchar(50),
@accion varchar(50) output
as


--Creamos las condiciones para generar un nuevo cógido tamanfo como referencia el anterior para realizar un incremento. 
if (@accion='crear')
begin
	declare @codnuevo varchar(10), @codmax varchar(10)
	set @codmax = (select max(Código) from clientes)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into clientes(Código,Cédula,Nombre,Apellidos,Edad,Cuenta,Tarjeta,Teléfono,Dirección)
	values(@codnuevo,@cedula,@nombre,@apellidos,@edad,@cuenta,@tarjeta,@telefono,@direccion)
	set @accion='Perfecto! registraste a ' +@nombre +' con el código ' +@codnuevo --Mensaje de verificación. 
end


--Preparamos la parte del proc que actualizará las tablas.
else if (@accion='actualizar')
begin
	update clientes set Cédula=@cedula, 
	                    Nombre=@nombre, 
						Apellidos=@apellidos, 
						Edad=@edad, Cuenta=@cuenta, 
						Tarjeta=@tarjeta, 
						Teléfono=@telefono, 
						Dirección=@direccion, 
						Estado=@estado 
					where Código=@codigo
	                set @accion='Perfecto! Actualízaste ' +@nombre --Mensaje de verificación.
end


----Preparamos la parte del proc que actualizará las tablas.
else if (@accion='borrar')
begin
	delete from clientes where Código=@codigo
	set @accion='Perfecto! borraste a ' +@nombre --Mensaje de verificación.
end