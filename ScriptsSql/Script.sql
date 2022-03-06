CREATE DATABASE PuntoVenta;
GO

USE PuntoVenta;
GO

--Modulos

CREATE TABLE Modulos(idModulo UNIQUEIDENTIFIER PRIMARY KEY,nombre varchar(40),
descripcion varchar(80), fechayHoraAlta DATETIME);


--Acciones Modulos

CREATE TABLE AccionesModulos(idAccionMod UNIQUEIDENTIFIER PRIMARY KEY, nombre varchar(40),
descripcion varchar(80), idModulo UNIQUEIDENTIFIER not null, idRol UNIQUEIDENTIFIER not null,
fechayHoraAlta DATETIME);

ALTER TABLE AccionesModulos
ADD FOREIGN KEY (idModulo) REFERENCES Modulos(idModulo);


--Roles

CREATE TABLE Roles(idRol UNIQUEIDENTIFIER PRIMARY KEY, nombre varchar(40), descripcion varchar(80),
fechayHoraAlta DATETIME);

ALTER TABLE AccionesModulos
ADD FOREIGN KEY (idRol) REFERENCES Roles(idRol);

--Usuarios

CREATE TABLE Usuarios(idUsuario UNIQUEIDENTIFIER PRIMARY KEY,
usuario varchar(40) not null, contrasenia varchar(40),
fechayHoraAlta DATETIME not null, idSucursal UNIQUEIDENTIFIER not null,
idRol UNIQUEIDENTIFIER not null);

ALTER TABLE Usuarios
ADD FOREIGN KEY (idRol) REFERENCES Roles(idRol);


--Ventas

CREATE TABLE Ventas(idVenta UNIQUEIDENTIFIER PRIMARY KEY, folioVenta varchar(40),
totalVenta money, subtotalVenta money, fechayHoraVenta DATETIME,
idSucursal UNIQUEIDENTIFIER not null, idUsuario UNIQUEIDENTIFIER not null,
idCliente UNIQUEIDENTIFIER);

ALTER TABLE Ventas
ADD FOREIGN KEY (idUsuario) REFERENCES Usuarios(idUsuario);

--Sucursales
CREATE TABLE Sucursales(idSucursal UNIQUEIDENTIFIER PRIMARY KEY,
nombre varchar(40), fechayHoraAlta DATETIME);

ALTER TABLE Usuarios
ADD FOREIGN KEY (idSucursal) REFERENCES Sucursales(idSucursal);

ALTER TABLE Ventas
ADD FOREIGN KEY (idSucursal) REFERENCES Sucursales(idSucursal);

--Clientes

CREATE TABLE Clientes(idCliente UNIQUEIDENTIFIER PRIMARY KEY,
nombre varchar(40),
fechayHoraAlta DATETIME);

ALTER TABLE Ventas
ADD FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente);

--DetalleVentas

CREATE TABLE DetalleVentasProductos(idDetalleVentasProductos UNIQUEIDENTIFIER
PRIMARY KEY,idProducto UNIQUEIDENTIFIER,
idVenta UNIQUEIDENTIFIER, cantidad int, total money);

ALTER TABLE DetalleVentasProductos
ADD FOREIGN KEY (idVenta) REFERENCES Ventas(idVenta);

--Productos

CREATE TABLE Productos(idProducto UNIQUEIDENTIFIER
PRIMARY KEY,stock int,
nombre varchar(40), descripcion varchar(40), precio money,idInventario UNIQUEIDENTIFIER,
idProveedor UNIQUEIDENTIFIER);

ALTER TABLE DetalleVentasProductos
ADD FOREIGN KEY (idProducto) REFERENCES Productos(idProducto);

--Inventarios

CREATE TABLE Inventarios(idInventario UNIQUEIDENTIFIER
PRIMARY KEY,
nombre varchar(40), 
idSucursal UNIQUEIDENTIFIER);


ALTER TABLE Inventarios
ADD FOREIGN KEY (idSucursal) REFERENCES Sucursales(idSucursal);



--Proveedores

CREATE TABLE Proveedores(idProveedor UNIQUEIDENTIFIER
PRIMARY KEY,
nombre varchar(40),
descripcion varchar(80),
fechayHoraAlta DATETIME);


ALTER TABLE Productos
ADD FOREIGN KEY (idInventario) REFERENCES Inventarios(idInventario);


ALTER TABLE Productos
ADD FOREIGN KEY (idProveedor) REFERENCES Proveedores(idProveedor);


CREATE OR ALTER PROCEDURE ConsultarProductos(@buscar varchar(60))
as

begin

If @buscar = ''
	select * from Productos;
else
	select * from Productos where nombre like '%'+@buscar+'%'; 


end


EXECUTE ConsultarProductos 'Ca'


CREATE OR ALTER PROCEDURE ConsultarProductosTotal(@buscar varchar(60),@total int output)
as

begin

If @buscar = ''
	select @total = count(*) from Productos;
else
	select @total = count(*) from Productos where nombre like '%'+@buscar+'%'; 


end

DECLARE @totalRg int

EXECUTE ConsultarProductosTotal 'Ca',@total = @totalRg out

PRINT @totalRg