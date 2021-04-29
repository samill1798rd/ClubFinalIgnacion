create database ClubFinal

Use ClubFinal


create table TipoSocio(
IdTipoSocio int not null primary key identity,
Descripcion nvarchar(50)
);

Create table Socios(
Id int not null primary key identity,
IdSocio nvarchar(255) null,
IdTipoSocio int not null,
FOREIGN KEY (IdTipoSocio) REFERENCES TipoSocio(IdTipoSocio),
Nombre nvarchar(75) null,
Apellido nvarchar(75) null,
NombreCompleto nvarchar(255) null,
Sexo nvarchar(1) null,
Cedula nvarchar(15) null,
FechaIngreso datetime null,
FechaNac datetime null,
Dirreccion nvarchar(255) null,
Telefono nvarchar(15) null,
Celular nvarchar(15) null,
Email nvarchar(100) null,
Estatus int null
);


Create table Loging(
IdLogin int not null primary key identity,
Usuario nvarchar(100) not null,
Clave nvarchar(100) not null,
Nombre nvarchar(100) not null,
);

Insert into TipoSocio (Descripcion)
values ('Corporativo'),
('Diplomatico'),
('Especiales'),
('Fundador'),
('No Residentes'),
('Numeral'),
('Propietario'),
('No Residente Propietario'),
('No Residente Numeral')


select * from TipoSocio