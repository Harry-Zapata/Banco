USE [master]
GO
/****** Object:  Database [BANCO]    Script Date: 29/09/2023 00:15:15 ******/
CREATE DATABASE [BANCO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BANCO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BANCO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BANCO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BANCO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BANCO] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BANCO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BANCO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BANCO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BANCO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BANCO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BANCO] SET ARITHABORT OFF 
GO
ALTER DATABASE [BANCO] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BANCO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BANCO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BANCO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BANCO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BANCO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BANCO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BANCO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BANCO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BANCO] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BANCO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BANCO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BANCO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BANCO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BANCO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BANCO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BANCO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BANCO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BANCO] SET  MULTI_USER 
GO
ALTER DATABASE [BANCO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BANCO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BANCO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BANCO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BANCO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BANCO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BANCO] SET QUERY_STORE = ON
GO
ALTER DATABASE [BANCO] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BANCO]
GO
/****** Object:  Table [dbo].[CUENTA]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUENTA](
	[nro_cta] [uniqueidentifier] NOT NULL,
	[nro_sucursal] [int] NULL,
	[cod_banco] [varchar](4) NULL,
	[cod_cli] [varchar](4) NULL,
	[saldo] [float] NULL,
	[fechaapertura] [date] NULL,
	[tipocta] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_cta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[cod_cli] [varchar](4) NOT NULL,
	[dni] [varchar](9) NULL,
	[apellidos] [varchar](50) NULL,
	[nombres] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VerCuenta]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VerCuenta]
AS
SELECT dbo.CLIENTE.cod_cli, dbo.CUENTA.nro_cta
FROM     dbo.CUENTA INNER JOIN
                  dbo.CLIENTE ON dbo.CUENTA.cod_cli = dbo.CLIENTE.cod_cli
GO
/****** Object:  Table [dbo].[BANCO]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANCO](
	[cod_banco] [varchar](4) NOT NULL,
	[nombre] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[localidad] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_banco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUCURSAL]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUCURSAL](
	[nro_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[cod_banco] [varchar](4) NULL,
	[direccion] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[telefono] [varchar](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[InfoGeneral]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[InfoGeneral]
AS
SELECT dbo.CLIENTE.cod_cli, dbo.CLIENTE.nombres, dbo.CUENTA.nro_cta, dbo.CUENTA.saldo, dbo.CUENTA.tipocta, dbo.BANCO.nombre
FROM     dbo.CLIENTE INNER JOIN
                  dbo.CUENTA ON dbo.CLIENTE.cod_cli = dbo.CUENTA.cod_cli INNER JOIN
                  dbo.BANCO ON dbo.CUENTA.cod_banco = dbo.BANCO.cod_banco INNER JOIN
                  dbo.SUCURSAL ON dbo.CUENTA.nro_sucursal = dbo.SUCURSAL.nro_sucursal AND dbo.BANCO.cod_banco = dbo.SUCURSAL.cod_banco
GO
/****** Object:  View [dbo].[BuscarUsuario]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BuscarUsuario]
AS
SELECT dbo.CUENTA.nro_cta, dbo.CLIENTE.nombres, dbo.CLIENTE.apellidos, dbo.BANCO.cod_banco, dbo.BANCO.nombre, dbo.SUCURSAL.nro_sucursal, dbo.SUCURSAL.ciudad
FROM     dbo.BANCO INNER JOIN
                  dbo.CUENTA ON dbo.BANCO.cod_banco = dbo.CUENTA.cod_banco INNER JOIN
                  dbo.CLIENTE ON dbo.CUENTA.cod_cli = dbo.CLIENTE.cod_cli INNER JOIN
                  dbo.SUCURSAL ON dbo.BANCO.cod_banco = dbo.SUCURSAL.cod_banco AND dbo.CUENTA.nro_sucursal = dbo.SUCURSAL.nro_sucursal
GO
/****** Object:  View [dbo].[VistaIngresos]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaIngresos]
AS
SELECT dbo.CUENTA.nro_cta, dbo.SUCURSAL.nro_sucursal, dbo.BANCO.cod_banco
FROM     dbo.CUENTA INNER JOIN
                  dbo.SUCURSAL ON dbo.CUENTA.nro_sucursal = dbo.SUCURSAL.nro_sucursal INNER JOIN
                  dbo.BANCO ON dbo.CUENTA.cod_banco = dbo.BANCO.cod_banco AND dbo.SUCURSAL.cod_banco = dbo.BANCO.cod_banco
GO
/****** Object:  Table [dbo].[INGRESOS]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INGRESOS](
	[nro_mov] [int] IDENTITY(1,1) NOT NULL,
	[nro_cta] [uniqueidentifier] NULL,
	[nro_sucursal] [int] NULL,
	[cod_banco] [varchar](4) NULL,
	[tipo_mov] [varchar](50) NULL,
	[fecha_mov] [date] NULL,
	[importe] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_mov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIMIENTOS]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTOS](
	[nro_mov] [int] IDENTITY(1,1) NOT NULL,
	[nro_cta_origen] [uniqueidentifier] NULL,
	[nro_cta_destino] [uniqueidentifier] NULL,
	[nro_sucursal] [int] NULL,
	[cod_banco] [varchar](4) NULL,
	[tipo_mov] [varchar](50) NULL,
	[fecha_mov] [date] NULL,
	[importe] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_mov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0001', N'Banco 1', N'Calle 1', N'Bogota')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0002', N'Banco 2', N'Calle 2', N'Medellin')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0003', N'Banco 3', N'Calle 3', N'Cali')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0004', N'Banco 4', N'Calle 4', N'Barranquilla')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0005', N'Banco 5', N'Calle 5', N'Bucaramanga')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0006', N'Banco 6', N'Calle 6', N'Cartagena')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0007', N'Banco 7', N'Calle 7', N'Barranquilla')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0008', N'Banco 8', N'Calle 8', N'Bogota')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0009', N'Banco 9', N'Calle 9', N'Cali')
INSERT [dbo].[BANCO] ([cod_banco], [nombre], [direccion], [localidad]) VALUES (N'0010', N'Banco 10', N'Calle 10', N'Barranquilla')
GO
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'2112', N'12345678', N'Zapata', N'Harry', N'Atahualpa', N'Jequetepeque', N'h@gmail.com')
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'A001', N'71890124', N'zapata', N'harry', N'atahualpa', N'jeque', N'@gmail.com')
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'A002', N'71890124', N'ZAPATA', N'SOTO', N'ATAHUALPA', N'JEQUE', N'H@GMAIL.COM')
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'A004', N'564757689', N'sfuygiu', N'tfygihu', N'rtdfyguy', N'dtrfyguyh', N'sdtfgh')
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'A005', N'71890122', N'Zapata', N'Jhans', N'La serna', N'Jeque', N'new@gmail.com')
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'A006', N'trcytui', N'trcyuy', N'ctrvybu', N'ctvybu', N'xrctfvybu', N'xrdcyvybu')
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'A007', N'7189021', N'tati', N'tantalian', N'mirando', N'nuejo', N'gear')
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'A008', N'71890124', N'Zapata Soto', N'Harry Franshesco', N'Atahualpa #265', N'Jequetepeque', N'Nuevo@gmail.com')
INSERT [dbo].[CLIENTE] ([cod_cli], [dni], [apellidos], [nombres], [direccion], [ciudad], [email]) VALUES (N'A009', N'71890124', N'Zapata Soto', N'Harry', N'Jeque', N'Jeque', N'jeque')
GO
INSERT [dbo].[CUENTA] ([nro_cta], [nro_sucursal], [cod_banco], [cod_cli], [saldo], [fechaapertura], [tipocta]) VALUES (N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'A008', 60, CAST(N'2023-09-23' AS Date), N'Cuenta Ahorro')
INSERT [dbo].[CUENTA] ([nro_cta], [nro_sucursal], [cod_banco], [cod_cli], [saldo], [fechaapertura], [tipocta]) VALUES (N'f1129257-b6b5-425b-9974-649072ee25a7', 4, N'0004', N'A009', 500, CAST(N'2023-09-23' AS Date), N'Cuenta Ahorro')
INSERT [dbo].[CUENTA] ([nro_cta], [nro_sucursal], [cod_banco], [cod_cli], [saldo], [fechaapertura], [tipocta]) VALUES (N'250f3d4a-fd71-42e6-a4eb-836bc75ada8f', 1, N'0001', N'A001', 380, CAST(N'2001-01-01' AS Date), N'corriente')
INSERT [dbo].[CUENTA] ([nro_cta], [nro_sucursal], [cod_banco], [cod_cli], [saldo], [fechaapertura], [tipocta]) VALUES (N'b56b410f-e464-4d68-8d0b-8d6044d347fd', 3, N'0003', N'A006', 260, CAST(N'2023-09-23' AS Date), N'Cuenta con Chequera')
INSERT [dbo].[CUENTA] ([nro_cta], [nro_sucursal], [cod_banco], [cod_cli], [saldo], [fechaapertura], [tipocta]) VALUES (N'01ab55af-fc0f-4324-82d1-997b5bc8e699', 2, N'0002', N'2112', 0, CAST(N'2023-09-28' AS Date), N'Cuenta Ahorro')
INSERT [dbo].[CUENTA] ([nro_cta], [nro_sucursal], [cod_banco], [cod_cli], [saldo], [fechaapertura], [tipocta]) VALUES (N'57a75d2b-c74a-4eef-96d6-d6b77caead87', 3, N'0003', N'A007', 110, CAST(N'2023-09-23' AS Date), N'Cuenta Ahorro')
GO
SET IDENTITY_INSERT [dbo].[INGRESOS] ON 

INSERT [dbo].[INGRESOS] ([nro_mov], [nro_cta], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (1, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'Pago', CAST(N'2021-01-01' AS Date), 1000)
INSERT [dbo].[INGRESOS] ([nro_mov], [nro_cta], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (3, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'Ingreso', CAST(N'2023-09-28' AS Date), 20)
INSERT [dbo].[INGRESOS] ([nro_mov], [nro_cta], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (4, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'Ingreso', CAST(N'2023-09-28' AS Date), 50)
INSERT [dbo].[INGRESOS] ([nro_mov], [nro_cta], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (5, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'Ingreso', CAST(N'2023-09-28' AS Date), 50)
INSERT [dbo].[INGRESOS] ([nro_mov], [nro_cta], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (6, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'Salida', CAST(N'2023-09-28' AS Date), 20)
INSERT [dbo].[INGRESOS] ([nro_mov], [nro_cta], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (7, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'Ingreso', CAST(N'2023-09-28' AS Date), 20)
INSERT [dbo].[INGRESOS] ([nro_mov], [nro_cta], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (8, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'Ingreso', CAST(N'2023-09-28' AS Date), 50)
INSERT [dbo].[INGRESOS] ([nro_mov], [nro_cta], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (9, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', 3, N'0003', N'Salida', CAST(N'2023-09-29' AS Date), 50)
SET IDENTITY_INSERT [dbo].[INGRESOS] OFF
GO
SET IDENTITY_INSERT [dbo].[MOVIMIENTOS] ON 

INSERT [dbo].[MOVIMIENTOS] ([nro_mov], [nro_cta_origen], [nro_cta_destino], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (1, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', N'b56b410f-e464-4d68-8d0b-8d6044d347fd', 1, N'0003', N'Transferencia', CAST(N'2000-05-10' AS Date), 50)
INSERT [dbo].[MOVIMIENTOS] ([nro_mov], [nro_cta_origen], [nro_cta_destino], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (2, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', N'57a75d2b-c74a-4eef-96d6-d6b77caead87', 3, N'0003', N'Transferencia', CAST(N'2023-09-27' AS Date), 80)
INSERT [dbo].[MOVIMIENTOS] ([nro_mov], [nro_cta_origen], [nro_cta_destino], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (3, N'c07d0fe3-1df5-43ff-86f7-210dcb6c48ad', N'57a75d2b-c74a-4eef-96d6-d6b77caead87', 3, N'0003', N'Transferencia', CAST(N'2023-09-27' AS Date), 10)
INSERT [dbo].[MOVIMIENTOS] ([nro_mov], [nro_cta_origen], [nro_cta_destino], [nro_sucursal], [cod_banco], [tipo_mov], [fecha_mov], [importe]) VALUES (4, N'57a75d2b-c74a-4eef-96d6-d6b77caead87', N'250f3d4a-fd71-42e6-a4eb-836bc75ada8f', 1, N'0001', N'Transferencia', CAST(N'2023-09-27' AS Date), 80)
SET IDENTITY_INSERT [dbo].[MOVIMIENTOS] OFF
GO
SET IDENTITY_INSERT [dbo].[SUCURSAL] ON 

INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (1, N'0001', N'Calle 1', N'Bogota', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (2, N'0002', N'Calle 2', N'Medellin', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (3, N'0003', N'Calle 3', N'Cali', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (4, N'0004', N'Calle 4', N'Barranquilla', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (5, N'0005', N'Calle 5', N'Bucaramanga', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (6, N'0006', N'Calle 6', N'Cartagena', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (7, N'0007', N'Calle 7', N'Barranquilla', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (8, N'0008', N'Calle 8', N'Bogota', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (9, N'0009', N'Calle 9', N'Cali', N'123456789')
INSERT [dbo].[SUCURSAL] ([nro_sucursal], [cod_banco], [direccion], [ciudad], [telefono]) VALUES (10, N'0010', N'Calle 10', N'Barranquilla', N'123456789')
SET IDENTITY_INSERT [dbo].[SUCURSAL] OFF
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD FOREIGN KEY([cod_banco])
REFERENCES [dbo].[BANCO] ([cod_banco])
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[CLIENTE] ([cod_cli])
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD FOREIGN KEY([nro_sucursal])
REFERENCES [dbo].[SUCURSAL] ([nro_sucursal])
GO
ALTER TABLE [dbo].[INGRESOS]  WITH CHECK ADD FOREIGN KEY([cod_banco])
REFERENCES [dbo].[BANCO] ([cod_banco])
GO
ALTER TABLE [dbo].[INGRESOS]  WITH CHECK ADD FOREIGN KEY([nro_cta])
REFERENCES [dbo].[CUENTA] ([nro_cta])
GO
ALTER TABLE [dbo].[INGRESOS]  WITH CHECK ADD FOREIGN KEY([nro_sucursal])
REFERENCES [dbo].[SUCURSAL] ([nro_sucursal])
GO
ALTER TABLE [dbo].[MOVIMIENTOS]  WITH CHECK ADD FOREIGN KEY([cod_banco])
REFERENCES [dbo].[BANCO] ([cod_banco])
GO
ALTER TABLE [dbo].[MOVIMIENTOS]  WITH CHECK ADD FOREIGN KEY([nro_cta_destino])
REFERENCES [dbo].[CUENTA] ([nro_cta])
GO
ALTER TABLE [dbo].[MOVIMIENTOS]  WITH CHECK ADD FOREIGN KEY([nro_cta_origen])
REFERENCES [dbo].[CUENTA] ([nro_cta])
GO
ALTER TABLE [dbo].[MOVIMIENTOS]  WITH CHECK ADD FOREIGN KEY([nro_sucursal])
REFERENCES [dbo].[SUCURSAL] ([nro_sucursal])
GO
ALTER TABLE [dbo].[SUCURSAL]  WITH CHECK ADD FOREIGN KEY([cod_banco])
REFERENCES [dbo].[BANCO] ([cod_banco])
GO
/****** Object:  StoredProcedure [dbo].[AgregarCliente]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarCliente]
@cod_cli VARCHAR(4),
@dni VARCHAR(9),
@apellidos VARCHAR(50),
@nombres VARCHAR(50),
@direccion VARCHAR(50),
@ciudad VARCHAR(50),
@email VARCHAR(50)
AS
BEGIN
    INSERT INTO CLIENTE(cod_cli, dni, apellidos, nombres, direccion, ciudad, email)
    VALUES(@cod_cli, @dni, @apellidos, @nombres, @direccion, @ciudad, @email)
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarIngresos]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarIngresos]
@nro_cta UNIQUEIDENTIFIER,
@nro_sucursal INT,
@cod_banco VARCHAR(4),
@tipo_mov VARCHAR(50),
@fecha_mov DATE,
@importe FLOAT
AS
BEGIN
    INSERT INTO INGRESOS VALUES(@nro_cta, @nro_sucursal, @cod_banco, @tipo_mov, @fecha_mov, @importe)
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarIngresosPrueva]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarIngresosPrueva]
@nro_cta UNIQUEIDENTIFIER,
@nro_sucursal INT,
@cod_banco VARCHAR(4),
@tipo_mov VARCHAR(50),
@fecha_mov DATE,
@importe FLOAT
AS
BEGIN
    DECLARE @NuevoRegistro TABLE (
        nro_mov INT, -- Asegúrate de que este sea el tipo de datos correcto para tu columna nro_mov
        nro_cta UNIQUEIDENTIFIER,
        nro_sucursal INT,
        cod_banco VARCHAR(4),
        tipo_mov VARCHAR(50),
        fecha_mov DATE,
        importe FLOAT
    )

    INSERT INTO INGRESOS (nro_cta, nro_sucursal, cod_banco, tipo_mov, fecha_mov, importe)
    OUTPUT INSERTED.nro_mov, INSERTED.nro_cta, INSERTED.nro_sucursal, INSERTED.cod_banco, INSERTED.tipo_mov, INSERTED.fecha_mov, INSERTED.importe
    INTO @NuevoRegistro
    VALUES (@nro_cta, @nro_sucursal, @cod_banco, @tipo_mov, @fecha_mov, @importe)

    SELECT * FROM @NuevoRegistro
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarMovimiento]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarMovimiento]
@nro_cta_origen UNIQUEIDENTIFIER,
@nro_cta_destino UNIQUEIDENTIFIER,
@nro_sucursal INT,
@cod_banco VARCHAR(4),
@tipo_mov VARCHAR(50),
@fecha_mov DATE,
@importe FLOAT
AS
BEGIN
    INSERT INTO MOVIMIENTOS(nro_cta_origen, nro_cta_destino, nro_sucursal, cod_banco, tipo_mov, fecha_mov, importe)
    VALUES(@nro_cta_origen, @nro_cta_destino, @nro_sucursal, @cod_banco, @tipo_mov, @fecha_mov, @importe)
END
GO
/****** Object:  StoredProcedure [dbo].[buscarNroCuenta]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarNroCuenta]
@cod_cli VARCHAR(4)
AS
BEGIN
    select * from VerCuenta where cod_cli=@cod_cli
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuarioPorCuenta]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarUsuarioPorCuenta]
@nro_cta UNIQUEIDENTIFIER
AS
BEGIN
    select * from buscarUsuario WHERE nro_cta = @nro_cta
END
GO
/****** Object:  StoredProcedure [dbo].[DataIngreso]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DataIngreso]
@nro_cta UNIQUEIDENTIFIER
AS
BEGIN
    select * from vistaIngresos WHERE nro_cta = @nro_cta
END
GO
/****** Object:  StoredProcedure [dbo].[Factura]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Factura]
@nro_mov int
AS
BEGIN
    select * from ingresos where nro_mov=@nro_mov
END
GO
/****** Object:  StoredProcedure [dbo].[GenerarCuenta]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenerarCuenta]
@nro_sucursal INT,
@cod_banco VARCHAR(4),
@cod_cli VARCHAR(4),
@saldo FLOAT,
@fechaapertura DATE,
@tipocta VARCHAR(50)
AS
BEGIN
    INSERT INTO CUENTA(nro_cta, nro_sucursal, cod_banco, cod_cli, saldo, fechaapertura, tipocta)
    VALUES(NEWID(), @nro_sucursal, @cod_banco, @cod_cli, @saldo, @fechaapertura, @tipocta)
END
GO
/****** Object:  StoredProcedure [dbo].[InformacionCuenta]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InformacionCuenta]
@cod_cli varchar(4)
AS
BEGIN
	select * from InfoGeneral where cod_cli=@cod_cli
end
GO
/****** Object:  StoredProcedure [dbo].[Ingresar]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ingresar]
@dni VARCHAR(9),
@cod_cli VARCHAR(4)
AS
BEGIN
    SELECT * FROM CLIENTE WHERE dni = @dni AND cod_cli = @cod_cli
END
GO
/****** Object:  StoredProcedure [dbo].[llenarBanco]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[llenarBanco]
 AS
 BEGIN
    SELECT cod_banco,nombre FROM BANCO
 END
GO
/****** Object:  StoredProcedure [dbo].[llenarSucursal]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[llenarSucursal]
 @cod_banco VARCHAR(4)
 AS
 BEGIN
    SELECT nro_sucursal,ciudad FROM SUCURSAL WHERE cod_banco = @cod_banco
 END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerHistorial]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerHistorial]
    @nro_cta UNIQUEIDENTIFIER
AS
BEGIN
    UPDATE MOVIMIENTOS
    SET tipo_mov = 
        CASE
            WHEN nro_cta_origen = @nro_cta THEN 'Transferencia'
            WHEN nro_cta_destino = @nro_cta THEN 'Depósito'
            ELSE NULL -- Puedes ajustar este valor por defecto según tus necesidades
        END
    WHERE nro_cta_origen = @nro_cta OR nro_cta_destino = @nro_cta;
	select * from MOVIMIENTOS where nro_cta_origen=@nro_cta or nro_cta_destino=@nro_cta
END;
GO
/****** Object:  StoredProcedure [dbo].[RestarSaldo]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RestarSaldo]
@nro_cta UNIQUEIDENTIFIER,
@saldo FLOAT
AS
BEGIN
    UPDATE CUENTA SET saldo = saldo - @saldo WHERE nro_cta = @nro_cta
END
GO
/****** Object:  StoredProcedure [dbo].[SumarSaldo]    Script Date: 29/09/2023 00:15:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SumarSaldo]
@nro_cta UNIQUEIDENTIFIER,
@saldo FLOAT
AS
BEGIN
    UPDATE CUENTA SET saldo = saldo + @saldo WHERE nro_cta = @nro_cta
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[50] 4[10] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "BANCO"
            Begin Extent = 
               Top = 152
               Left = 38
               Bottom = 315
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CLIENTE"
            Begin Extent = 
               Top = 162
               Left = 1009
               Bottom = 325
               Right = 1203
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CUENTA"
            Begin Extent = 
               Top = 197
               Left = 464
               Bottom = 360
               Right = 658
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SUCURSAL"
            Begin Extent = 
               Top = 0
               Left = 258
               Bottom = 163
               Right = 452
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BuscarUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BuscarUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BuscarUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[11] 2[3] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CLIENTE"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BANCO"
            Begin Extent = 
               Top = 122
               Left = 1013
               Bottom = 285
               Right = 1207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CUENTA"
            Begin Extent = 
               Top = 122
               Left = 506
               Bottom = 285
               Right = 700
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "SUCURSAL"
            Begin Extent = 
               Top = 7
               Left = 774
               Bottom = 170
               Right = 968
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'InfoGeneral'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'InfoGeneral'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'InfoGeneral'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CUENTA"
            Begin Extent = 
               Top = 47
               Left = 58
               Bottom = 210
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CLIENTE"
            Begin Extent = 
               Top = 40
               Left = 427
               Bottom = 203
               Right = 621
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1476
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VerCuenta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VerCuenta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CUENTA"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SUCURSAL"
            Begin Extent = 
               Top = 7
               Left = 532
               Bottom = 170
               Right = 726
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BANCO"
            Begin Extent = 
               Top = 7
               Left = 774
               Bottom = 170
               Right = 968
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaIngresos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaIngresos'
GO
USE [master]
GO
ALTER DATABASE [BANCO] SET  READ_WRITE 
GO
