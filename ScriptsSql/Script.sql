
CREATE DATABASE PuntoVenta;
GO

USE PuntoVenta;
GO

--Modulos

CREATE TABLE Modulos(idModulo UNIQUEIDENTIFIER PRIMARY KEY,nombre varchar(40),
descripcion varchar(80), fechayHoraAlta DATETIME);


--Operaciones Modulos

CREATE TABLE OperacionesModulos(idOperaMod UNIQUEIDENTIFIER PRIMARY KEY, nombre varchar(40),
descripcion varchar(80), idModulo UNIQUEIDENTIFIER not null,
fechayHoraAlta DATETIME);

ALTER TABLE OperacionesModulos
ADD FOREIGN KEY (idModulo) REFERENCES Modulos(idModulo);

--Operaciones Rol

CREATE TABLE RolOperacion(idRolOperacion UNIQUEIDENTIFIER
PRIMARY KEY, idRol UNIQUEIDENTIFIER,
idOperaMod UNIQUEIDENTIFIER);

ALTER TABLE RolOperacion
ADD FOREIGN KEY (idOperaMod) REFERENCES OperacionesModulos(idOperaMod);

--Roles

CREATE TABLE Roles(idRol UNIQUEIDENTIFIER PRIMARY KEY, nombre varchar(40), descripcion varchar(80),
fechayHoraAlta DATETIME);

ALTER TABLE RolOperacion
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


--Usuario y rol por defecto

INSERT INTO [dbo].[Roles]
           ([idRol]
           ,[nombre]
           ,[descripcion]
           ,[fechayHoraAlta])
     VALUES
           ('0E127AD1-EF10-4A4D-97B3-E452F4EA5397'
           ,'Admin'
           ,'n/a'
           ,GETDATE())

INSERT INTO [dbo].[Sucursales]
           ([idSucursal]
           ,[nombre]
           ,[fechayHoraAlta])
     VALUES
           ('48586AE5-ACD0-4ABF-A383-B98E305C11A7'
           ,'Sucursal11'
           ,GETDATE())

INSERT INTO [dbo].[Usuarios]
           ([idUsuario]
           ,[usuario]
           ,[contrasenia]
           ,[fechayHoraAlta]
           ,[idSucursal]
           ,[idRol])
     VALUES
           ('AB211B43-F5F1-42A0-B507-268879B8F266'
           ,'AdminPrin'
           ,'p'
           ,getdate()
           ,'48586AE5-ACD0-4ABF-A383-B98E305C11A7'
           ,'0E127AD1-EF10-4A4D-97B3-E452F4EA5397')


INSERT INTO [dbo].[Proveedores]
           ([idProveedor]
           ,[nombre]
           ,[descripcion]
           ,[fechayHoraAlta])
     VALUES
           ('00EE0050-3A09-4E5F-9410-E66BE11310A4'
           ,'Néscafe'
           ,''
           ,GETDATE())