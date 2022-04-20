--Creamos la base de datos
create database ZapateriaMartita
go

--ponemos en uso la base de datos
use ZapateriaMartita
go

--Creamos la base de datos 
create table Compradores
(
C�digo int IDENTITY(1,1),
Nombre varchar(50),
Apellidos varchar(75),
Producto varchar(15),
Tel�fono varchar(50),
Estado varchar(50) DEFAULT 'Activo'
);
go

create proc mantenimiento (@action as varchar(3),
                           @codigo as int=null,
			               @nombres as varchar(100)=null,
				           @apellidos as varchar(100)=null,
			               @producto as varchar(100)=null,
				           @telefono as varchar(15)=null,
				           @estado as varchar(15)=null
)
as

begin

    if @action='PGC'
	begin
		select 
		C�digo,
		Nombre,
		Apellidos,
		Producto,
		Tel�fono,
		Estado
	    from [dbo].[Compradores]
	end


	if @action='PGI'
	begin
		insert into [dbo].[Compradores] (Nombre, Apellidos, Producto, Tel�fono, Estado) values(@nombres, @apellidos, @producto, @telefono,  @estado)
		end


	if @action='PGA'
	begin
	  update [dbo].[Compradores]
		set	  Nombre=@nombres,
			  Apellidos=@apellidos,
			  Producto=@producto,
			  Tel�fono=@telefono,
			  Estado=@estado
		where C�digo=@codigo
	end
      
   
      else if (@action='borrar')
          begin
	    delete from Compradores where C�digo=@codigo
	end

end