CREATE TABLE [Producto] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Categoria] int,
  [Id_Marca] int,
  [Id_Unida_de_Medidad] int,
  [Codigo_Barra] nvarchar(max),
  [Descripcion] nvarchar(450) NOT NULL,
  [EsPerecedero] bit NOT NULL,
  [StockMinimo] int NOT NULL,
  [Foto] nvarchar(max),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Unidad_Medida] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450) NOT NULL,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Categoria] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450) NOT NULL,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Usuario] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Permiso] int,
  [Id_Persona] nvarchar(450),
  [Nombre_Usuario] nvarchar(150) NOT NULL,
  [Contraseña] varbinary(64) NOT NULL,
  [Foto] nvarchar(max),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Permiso] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450) NOT NULL,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Persona_Base] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Cedula] nvarchar(16),
  [PrimerNombre] nvarchar(100) NOT NULL,
  [SegundoNombre] nvarchar(100),
  [PrimerApellido] nvarchar(100) NOT NULL,
  [SegundoApellido] nvarchar(100),
  [Sexo] char(1) NOT NULL,
  [Foto] nvarchar(max) NOT NULL,
  [FechaNacimiento] datetime NOT NULL,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Tipo_Direccion] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450) NOT NULL,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Direccion_Persona] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Persona] int,
  [Id_Tipo_Direccion] int,
  [Id_Usuario_Crea] int NOT NULL,
  [Direccion_Completo] nvarchar(max) NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Contacto_Persona] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Persona] int,
  [Id_Contacto] int,
  [Contacto] nvarchar(500),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Departamento] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Municipio] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Departamento] int,
  [Descripcion] nvarchar(450),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Barrio_Comunidad] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Municipio] int,
  [Id_Distrito] int,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Distrito] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Contacto] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Persona_Tipo] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Persona] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Tipo_Persona] int,
  [Id_Persona_Base] int,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Venta] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Cliente] int,
  [Id_Cajero] int,
  [Fecha] datetime,
  [Sub_Total] decimal(10,2),
  [Iva] decimal(10,2),
  [Total] decimal(10,2),
  [Id_Metodo_Pago] int,
  [TipoPago] nvarchar(20),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Detalle_Venta] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Venta] int,
  [Id_Producto] int,
  [Cantidad] int,
  [Precio] decimal(10,2),
  [Descuento] decimal(10,2),
  [Total] decimal(10,2),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Lotes_Producto] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Proveedor] int,
  [IdProducto] INT,
  [CodigoLote] VARCHAR(50),
  [FechaEntrada] DATE,
  [FechaVencimiento] DATE,
  [CantidadInicial] INT,
  [CantidadDisponible] INT,
  [PrecioCompra] DECIMAL(10,2),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [MovimientoInventario] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [IdLote] INT,
  [FechaMovimiento] DATETIME,
  [TipoMovimiento] VARCHAR(20),
  [CantidadAntes] int,
  [CantidadMovimiento] int,
  [CantidadDespues] int,
  [Descripcion] VARCHAR(255),
  [Id_Detalle_Venta] int,
  [Id_Detalle_Compra] int,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Marca] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Credito] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Persona] int,
  [MontoCredito] decimal(10,2),
  [LimiteCredito] decimal(10,2),
  [FechaInicio] datetime,
  [PlazoMeses] int,
  [TasaInteres] decimal(5,2),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Credito_Venta] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Venta] int,
  [Id_Credito] int,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Cuota] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Credito] int,
  [NumeroCuota] int NOT NULL,
  [Monto_Establecido] decimal(10,2),
  [MontoPagado] decimal(10,2) NOT NULL,
  [Id_Metodo_Pago] int,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Proveedor] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Nombre] NVARCHAR(150) NOT NULL,
  [RUC] NVARCHAR(30),
  [Telefono] NVARCHAR(30) NOT NULL,
  [Email] NVARCHAR(120),
  [Direccion] NVARCHAR(250),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Compra] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Proveedor] INT,
  [Fecha] DATETIME,
  [NumeroDocumento] NVARCHAR(60),
  [SubTotal] DECIMAL(10,2),
  [Impuesto] DECIMAL(10,2),
  [Total] DECIMAL(10,2),
  [Id_Metodo_Pago] int,
  [Observacion] NVARCHAR(250),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Detalle_Compra] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Compra] INT,
  [IdProducto] INT,
  [CodigoLote] NVARCHAR(50),
  [FechaVencimiento] DATE,
  [Cantidad] INT,
  [PrecioCosto] DECIMAL(10,2),
  [SubTotal] DECIMAL(10,2),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Cuenta_Pagar] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Compra] int,
  [Id_Proveedor] int,
  [Saldo] DECIMAL(10,2),
  [FechaVencimiento] DATE,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Pago_Proveedor] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Cuenta_Pagar] INT,
  [Id_Metodo_Pago] INT,
  [Monto] DECIMAL(10,2),
  [Fecha] DATETIME,
  [Observacion] NVARCHAR(200),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Metodo_de_Pago] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(50),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Denominacion_Billete_Moneda] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Valor] DECIMAL(10,2),
  [Tipo] NVARCHAR(10),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Caja] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [NombreCaja] nvarchar(450),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Apertura_Caja] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Caja] int,
  [Id_Cajero] int,
  [FechaHoraApertura] DATETIME2,
  [FondoInicial] DECIMAL(10,2),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Apertura_Caja_Denom] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Apertura_Caja] INT,
  [Id_Denominacion] INT,
  [Cantidad] INT,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Movimiento_Caja] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Apertura_Caja] INT,
  [Id_Tipo] int,
  [Id_Venta] INT,
  [Monto] DECIMAL(10,2),
  [Descripcion] NVARCHAR(200),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Tipo_Movimiento_Caja] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Descripcion] nvarchar(450),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Pago] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Venta] INT,
  [Id_Apertura_Caja] INT,
  [Id_Metodo_Pago] int,
  [Monto] DECIMAL(10,2),
  [MontoRecibido] DECIMAL(10,2),
  [Vuelto] DECIMAL(10,2),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Cierre_Caja] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Apertura_Caja] INT,
  [FechaHoraCierre] datetime,
  [ConteoEfectivo] DECIMAL(10,2),
  [TotalEsperado] DECIMAL(10,2),
  [Diferencia] DECIMAL(10,2),
  [Observacion] NVARCHAR(200),
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

CREATE TABLE [Cierre_Caja_Denom] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Id_Cierre_Caja] INT,
  [Id_Denominacion] INT,
  [Cantidad] INT,
  [Id_Usuario_Crea] int NOT NULL,
  [Fecha_Registro] datetimeoffset DEFAULT 'GETDATE()',
  [Id_Usuario_Modifica] int,
  [Fecha_Modifica] datetimeoffset DEFAULT 'GETDATE()',
  [Estado] bit DEFAULT (1)
)
GO

ALTER TABLE [Producto] ADD FOREIGN KEY ([Id_Categoria]) REFERENCES [Categoria] ([Id])
GO

ALTER TABLE [Persona] ADD FOREIGN KEY ([Id_Persona_Base]) REFERENCES [Persona_Base] ([Id])
GO

ALTER TABLE [Persona] ADD FOREIGN KEY ([Id_Tipo_Persona]) REFERENCES [Persona_Tipo] ([Id])
GO

ALTER TABLE [Venta] ADD FOREIGN KEY ([Id_Cliente]) REFERENCES [Persona] ([Id])
GO

ALTER TABLE [Venta] ADD FOREIGN KEY ([Id_Cajero]) REFERENCES [Persona] ([Id])
GO

ALTER TABLE [Detalle_Venta] ADD FOREIGN KEY ([Id_Venta]) REFERENCES [Venta] ([Id])
GO

ALTER TABLE [Detalle_Venta] ADD FOREIGN KEY ([Id_Producto]) REFERENCES [Producto] ([Id])
GO

ALTER TABLE [Lotes_Producto] ADD FOREIGN KEY ([IdProducto]) REFERENCES [Producto] ([Id])
GO

ALTER TABLE [MovimientoInventario] ADD FOREIGN KEY ([IdLote]) REFERENCES [Lotes_Producto] ([Id])
GO

ALTER TABLE [Producto] ADD FOREIGN KEY ([Id_Marca]) REFERENCES [Marca] ([Id])
GO

ALTER TABLE [MovimientoInventario] ADD FOREIGN KEY ([Id_Detalle_Venta]) REFERENCES [Detalle_Venta] ([Id])
GO

ALTER TABLE [Cuota] ADD FOREIGN KEY ([Id_Credito]) REFERENCES [Credito] ([Id])
GO

ALTER TABLE [Compra] ADD FOREIGN KEY ([Id_Proveedor]) REFERENCES [Proveedor] ([Id])
GO

ALTER TABLE [Detalle_Compra] ADD FOREIGN KEY ([IdProducto]) REFERENCES [Producto] ([Id])
GO

ALTER TABLE [Detalle_Compra] ADD FOREIGN KEY ([Id_Compra]) REFERENCES [Compra] ([Id])
GO

ALTER TABLE [MovimientoInventario] ADD FOREIGN KEY ([Id_Detalle_Compra]) REFERENCES [Compra] ([Id])
GO

ALTER TABLE [Cuenta_Pagar] ADD FOREIGN KEY ([Id_Proveedor]) REFERENCES [Proveedor] ([Id])
GO

ALTER TABLE [Pago_Proveedor] ADD FOREIGN KEY ([Id_Cuenta_Pagar]) REFERENCES [Cuenta_Pagar] ([Id])
GO

ALTER TABLE [Cuenta_Pagar] ADD FOREIGN KEY ([Id_Compra]) REFERENCES [Compra] ([Id])
GO

ALTER TABLE [Pago_Proveedor] ADD FOREIGN KEY ([Id_Metodo_Pago]) REFERENCES [Metodo_de_Pago] ([Id])
GO

ALTER TABLE [Cuota] ADD FOREIGN KEY ([Id_Metodo_Pago]) REFERENCES [Metodo_de_Pago] ([Id])
GO

ALTER TABLE [Venta] ADD FOREIGN KEY ([Id_Metodo_Pago]) REFERENCES [Metodo_de_Pago] ([Id])
GO

ALTER TABLE [Compra] ADD FOREIGN KEY ([Id_Metodo_Pago]) REFERENCES [Metodo_de_Pago] ([Id])
GO

ALTER TABLE dbo.Usuario ALTER  COLUMN Id_Persona int

ALTER TABLE [Usuario] ADD FOREIGN KEY ([Id_Persona]) REFERENCES [Persona] ([Id])
GO

ALTER TABLE [Usuario] ADD FOREIGN KEY ([Id_Permiso]) REFERENCES [Permiso] ([Id])
GO

ALTER TABLE [Movimiento_Caja] ADD FOREIGN KEY ([Id_Tipo]) REFERENCES [Tipo_Movimiento_Caja] ([Id])
GO

ALTER TABLE [Apertura_Caja] ADD FOREIGN KEY ([Id_Caja]) REFERENCES [Caja] ([Id])
GO

ALTER TABLE [Movimiento_Caja] ADD FOREIGN KEY ([Id_Apertura_Caja]) REFERENCES [Apertura_Caja] ([Id])
GO

ALTER TABLE [Pago] ADD FOREIGN KEY ([Id_Apertura_Caja]) REFERENCES [Apertura_Caja] ([Id])
GO

ALTER TABLE [Cierre_Caja] ADD FOREIGN KEY ([Id_Apertura_Caja]) REFERENCES [Apertura_Caja] ([Id])
GO

ALTER TABLE [Cierre_Caja_Denom] ADD FOREIGN KEY ([Id_Cierre_Caja]) REFERENCES [Cierre_Caja] ([Id])
GO

ALTER TABLE [Cierre_Caja_Denom] ADD FOREIGN KEY ([Id_Denominacion]) REFERENCES [Denominacion_Billete_Moneda] ([Id])
GO

ALTER TABLE [Apertura_Caja] ADD FOREIGN KEY ([Id_Cajero]) REFERENCES [Persona] ([Id])
GO

ALTER TABLE [Apertura_Caja_Denom] ADD FOREIGN KEY ([Id_Apertura_Caja]) REFERENCES [Apertura_Caja] ([Id])
GO

ALTER TABLE [Apertura_Caja_Denom] ADD FOREIGN KEY ([Id_Denominacion]) REFERENCES [Denominacion_Billete_Moneda] ([Id])
GO

ALTER TABLE [Producto] ADD FOREIGN KEY ([Id_Unida_de_Medidad]) REFERENCES [Unidad_Medida] ([Id])
GO

ALTER TABLE [Movimiento_Caja] ADD FOREIGN KEY ([Id_Venta]) REFERENCES [Venta] ([Id])
GO

ALTER TABLE [Pago] ADD FOREIGN KEY ([Id_Venta]) REFERENCES [Venta] ([Id])
GO

ALTER TABLE [Pago] ADD FOREIGN KEY ([Id_Metodo_Pago]) REFERENCES [Metodo_de_Pago] ([Id])
GO

ALTER TABLE [Credito] ADD FOREIGN KEY ([Id_Persona]) REFERENCES [Persona] ([Id])
GO

ALTER TABLE [Credito_Venta] ADD FOREIGN KEY ([Id_Venta]) REFERENCES [Venta] ([Id])
GO

ALTER TABLE [Credito_Venta] ADD FOREIGN KEY ([Id_Credito]) REFERENCES [Credito] ([Id])
GO

ALTER TABLE [Contacto_Persona] ADD FOREIGN KEY ([Id_Persona]) REFERENCES [Persona_Base] ([Id])
GO

ALTER TABLE [Contacto_Persona] ADD FOREIGN KEY ([Id_Contacto]) REFERENCES [Contacto] ([Id])
GO


ALTER TABLE [Municipio] ADD FOREIGN KEY ([Id_Departamento]) REFERENCES [Departamento] ([Id])
GO

ALTER TABLE [Barrio_Comunidad] ADD FOREIGN KEY ([Id]) REFERENCES [Municipio] ([Id])
GO

ALTER TABLE [Barrio_Comunidad] ADD FOREIGN KEY ([Id_Distrito]) REFERENCES [Distrito] ([Id])
GO

ALTER TABLE [Direccion_Persona] ADD FOREIGN KEY ([Id_Persona]) REFERENCES [Persona] ([Id])
GO

ALTER TABLE [Direccion_Persona] ADD FOREIGN KEY ([Id_Tipo_Direccion]) REFERENCES [Tipo_Direccion] ([Id])
GO
