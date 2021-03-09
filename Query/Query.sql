use WebApi

create table Vacuna(
	id int primary key identity,
	marca varchar(60) not null, 
	cantidad int not null,
	estado int default 1
)
drop table Persona
drop table Vacuna


create table Persona(
	id int primary key identity,
	nombre varchar(50) not null, 
	apellido varchar(50) not null, 
	telefono varchar (12) not null, 
	fecha_nacimiento varchar(10) not null, 
	id_vacuna int foreign key references Vacuna(id), 
	provincia varchar(60) not null,
	fecha_vacuna1 varchar(60), 
	fecha_vacuna2 varchar(60),
	estado int default 1
)

insert into Vacuna values ('Tuberculosis', 1);

insert into Persona values ('Ernesto', 'Sanchez', '809-797-6812', '2001-11-30', 1, 'Santiago', '2021-01-03','', 1);

select * from Persona