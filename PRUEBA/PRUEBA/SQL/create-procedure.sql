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
	SELECT * FROM artistas
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