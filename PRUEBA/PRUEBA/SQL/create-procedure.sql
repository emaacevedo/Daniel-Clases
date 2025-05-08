CREATE PROCEDURE SP_LISTADO_GENERO_MUSICAL
AS
	SELECT * FROM genero_musical
GO

CREATE PROCEDURE SP_INSERTAR_GENERO_MUSICAL
@nombre varchar(100)
AS
	insert into genero_musical (nombre)
	values (@nombre)

	select 'Genero musical guardado correctamente' as mensaje
GO

CREATE PROCEDURE SP_MODIFICAR_GENERO_MUSICAL
@id int,
@nombre varchar(100)
AS
	UPDATE genero_musical
	SET
	nombre = @nombre
	WHERE id = @id

	select 'Genero musical actualizado correctamente' as mensaje
GO


CREATE PROCEDURE SP_ELIMINAR_GENERO_MUSICAL
@id int
AS
	DELETE FROM genero_musical WHERE id = @id

	select 'Genero musical eliminado correctamente' as mensaje
GO

go

CREATE PROCEDURE SP_LISTADO_ARTISTAS
AS
	SELECT 
		artistas.id,
		artistas.nombre,
		genero_musical.nombre as genero_musical
	FROM 
		artistas
		inner join genero_musical on artistas.id_genero = genero_musical.id
GO

CREATE PROCEDURE SP_INSERTAR_ARTISTAS
@nombre varchar(100),
@id_genero int
AS
	insert into artistas (nombre, id_genero)
	values (@nombre, @id_genero)

	select 'Artista guardado correctamente' as mensaje
GO

CREATE PROCEDURE SP_MODIFICAR_ARTISTAS
@id int,
@nombre varchar(100),
@id_genero int
AS
	UPDATE artistas
	SET
	nombre = @nombre,
	id_genero = @id_genero
	WHERE id = @id

	select 'Artista actualizado correctamente' as mensaje
GO


CREATE PROCEDURE SP_ELIMINAR_ARTISTAS
@id int
AS
	DELETE FROM artistas WHERE id = @id

	select 'Artista eliminado correctamente' as mensaje
GO

create procedure LISTAR_CANCIONES
AS
	SELECT 
	c.id, 
	c.nombre, 
	c.letra,
	c.duracion,
	c.lanzamiento,
	a.nombre as nombre_artista
	FROM canciones as c 
	inner join artistas as a on c.id_artista = a.id
GO

create procedure AGREGAR_CANCIONES
@nombre varchar (100),
@letra varchar(max) ,
@duracion time,
@lanzamiento date,
@id_artista int
as
	insert into canciones (nombre,letra,duracion,lanzamiento, id_artista)
	values (@nombre,@letra,@duracion,@lanzamiento,@id_artista)

	select 'cancion guardada correctamente' as mensaje
go

create procedure ACTUALIZAR_CANCIONES
@id int,
@nombre varchar (100),
@letra varchar(max) ,
@duracion time,
@lanzamiento date,
@id_artista int
as
	update canciones set 

	nombre = @nombre,
	letra = @letra,
	duracion = @duracion,
	lanzamiento = @lanzamiento,
	id_artista = @id_artista

	where id = @id

	select 'cancion actualizada correctamente' as mensaje
go

create procedure ELIMINAR_CANCIONES
@id int

as
	delete from canciones
	where id = @id

	select 'cancion eliminada correctamente' as mensaje
go