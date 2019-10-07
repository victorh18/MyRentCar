USE MyRentCar
GO 

CREATE TABLE TiposDocumentos(
	Id INT IDENTITY(1, 1),
	Descripcion NVARCHAR(MAX) NOT NULL

	CONSTRAINT pk_TiposDocumentos PRIMARY KEY(Id)
)
GO 

CREATE TABLE TiposVehiculos(
	Id INT IDENTITY(1, 1),
	Descripcion NVARCHAR(MAX) NOT NULL,
	Estado BIT,

	CONSTRAINT pk_TiposVehiculos PRIMARY KEY(Id)
)
GO

CREATE TABLE TiposInspecciones(
	Id INT IDENTITY(1, 1),
	Descripcion NVARCHAR(MAX) NOT NULL,
	Estado BIT,

	CONSTRAINT pk_TiposInspecciones PRIMARY KEY(Id)
)
GO

CREATE TABLE TiposCombustibles(
	Id INT IDENTITY(1, 1),
	Descripcion NVARCHAR(MAX) NOT NULL

	CONSTRAINT pk_TiposCombustibles PRIMARY KEY(Id)
)
GO

CREATE TABLE Marcas(
	Id INT IDENTITY(1, 1),
	Descripcion NVARCHAR(MAX) NOT NULL,
	Estado BIT,

	CONSTRAINT pk_Marcas PRIMARY KEY(Id)
)
GO

CREATE TABLE Modelos(
	Id INT IDENTITY(1, 1),
	Descripcion NVARCHAR(MAX) NOT NULL,
	Estado BIT,
	IdMarca INT,
	IdTipoVehiculo INT,

	CONSTRAINT pk_Modelos PRIMARY KEY(Id),
	CONSTRAINT fk_Marca_Modelos FOREIGN KEY(IdMarca) REFERENCES Marcas(Id),
	CONSTRAINT fk_TipoVehiculo_Modelos FOREIGN KEY(IdTipoVehiculo) REFERENCES TiposVehiculos(Id),
)
GO

CREATE TABLE Clientes(
	Id INT IDENTITY(1, 1),
	Nombre NVARCHAR(MAX) NOT NULL,
	NumeroDocumento NVARCHAR(MAX) NOT NULL,
	IdTipoDocumento NVARCHAR(MAX),
	NumeroTarjetaCredito NVARCHAR(MAX),
	LimiteCredito DECIMAL(18, 2),
	Estado BIT,

	CONSTRAINT pk_Clientes PRIMARY KEY(Id),
	CONSTRAINT fk_TipoDocumento_Clientes FOREIGN KEY(Id) REFERENCES TiposDocumentos(Id),
)
GO

CREATE TABLE Vehiculos(
	Id INT IDENTITY(1, 1),
	Descripcion NVARCHAR(MAX) NOT NULL,
	NumeroChasis NVARCHAR(MAX) NOT NULL,
	NumeroMotor NVARCHAR(MAX) NOT NULL,
	NumeroPlaca NVARCHAR(MAX) NOT NULL,
	IdModelo INT,
	IdCombustible INT,
	Estado BIT,

	CONSTRAINT pk_Vehiculos PRIMARY KEY(Id),
	CONSTRAINT fk_Modelo_Vehiculos FOREIGN KEY(IdModelo) REFERENCES Modelos(Id),
	CONSTRAINT fk_Combustible_Vehiculos FOREIGN KEY(IdCombustible) REFERENCES TiposCombustibles(Id)

)
GO

CREATE TABLE Empleados(
	Id INT IDENTITY(1, 1),
	Nombre NVARCHAR(MAX) NOT NULL,
	Cedula NVARCHAR(11) NOT NULL,
	TandaLaboral NVARCHAR(MAX),
	PorcientoComision DECIMAL(5, 2),
	FechaIngreso DATE NOT NULL,
	Estado BIT,

	CONSTRAINT pk_Empleados PRIMARY KEY(Id),

)
GO

CREATE TABLE EstadosRentas(
	Id INT IDENTITY(1, 1),
	Descripcion NVARCHAR(MAX),

	CONSTRAINT pk_EstadosRentas PRIMARY KEY(Id)
)
GO

CREATE TABLE Rentas(
	Id INT IDENTITY(1, 1),
	IdEmpleado INT,
	IdVehiculo INT,
	IdCliente INT,
	FechaRenta DATETIME,
	FechaDevolucion DATETIME,
	MontoDia DECIMAL(18, 2),
	Comentario NVARCHAR(MAX),
	IdEstado INT,

	CONSTRAINT pk_Rentas PRIMARY KEY(Id),
	CONSTRAINT fk_Empleado_Rentas FOREIGN KEY(IdEmpleado) REFERENCES Empleados(Id),
	CONSTRAINT fk_Vehiculo_Rentas FOREIGN KEY(IdVehiculo) REFERENCES Vehiculos(Id),
	CONSTRAINT fk_Cliente_Rentas FOREIGN KEY(IdCliente) REFERENCES Clientes(Id),
	CONSTRAINT fk_Estado_Rentas FOREIGN KEY(IdEstado) REFERENCES EstadosRentas(Id)
)
GO

CREATE TABLE Inspecciones(
	Id INT IDENTITY(1, 1),
	IdVehiculo INT,
	IdCliente INT,
	TieneRayadura BIT,
	CantidadCombustible INT,
	TieneGomaRepuesto BIT,
	TieneRoturasCristal BIT,
	GomaFronteraDerecha BIT,
	GomaFronteraIzquierda BIT,
	GomaTraseraDerecha BIT,
	GomaTraseraIzquierda BIT,
	TieneGato BIT,
	Observaciones NVARCHAR(MAX),
	Fecha DATETIME,
	IdEmpleadoInspeccion INT,
	Estado BIT,
	IdTipoInspeccion INT,
	IdRenta INT,

	CONSTRAINT pk_Inspecciones PRIMARY KEY(Id),
	CONSTRAINT fk_Vehiculo_Inspecciones FOREIGN KEY(IdVehiculo) REFERENCES Vehiculos(Id),
	CONSTRAINT fk_Cliente_Inspecciones FOREIGN KEY(IdCliente) REFERENCES Clientes(Id),
	CONSTRAINT fk_Empleado_Inspecciones FOREIGN KEY(IdEmpleadoInspeccion) REFERENCES Empleados(Id),
	CONSTRAINT fk_TipoInspeccion_Inspeccion FOREIGN KEY(IdTipoInspeccion) REFERENCES TiposInspecciones(Id)
	CONSTRAINT fk_Inspecciones_Marcas FOREIGN KEY (IdRenta) REFERENCES dbo.Rentas(Id) 
)
GO

SELECT 'lol'






