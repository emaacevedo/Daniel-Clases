create table genero_musical
(
	id int identity(1,1) primary key not null,
	nombre varchar(100) not null
)

go

create table artistas
( 
	id int identity(1,1) primary key not null,
	nombre varchar(100) not null,
	id_genero int foreign key references genero_musical(id)
)