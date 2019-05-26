CREATE DATABASE PeronasDb
GO
USE PersonasDb
GO
CREATE TABLE Personas
(
  IdUsuario int primary key identity,
  Nombre varchar(30),
  Email varchar(15),
  NomUsuario varchar(12),
  LvlUsuario varchar(4),
  Contrasena varchar(13),
  FechaIngreso datetime
  );

  CREATE TABLE CargosPersonas
(
	CargoId int primary key identity,
	Descripcion varchar(30),
);