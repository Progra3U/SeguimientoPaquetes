USE [master]
GO
/****** Object:  Database [SeguimientoPaquetes]    Script Date: 6/12/2018 6:48:27 PM ******/
CREATE DATABASE [SeguimientoPaquetes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SeguimientoPaquetes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER\MSSQL\DATA\SeguimientoPaquetes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SeguimientoPaquetes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER\MSSQL\DATA\SeguimientoPaquetes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SeguimientoPaquetes] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SeguimientoPaquetes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SeguimientoPaquetes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET ARITHABORT OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SeguimientoPaquetes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SeguimientoPaquetes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SeguimientoPaquetes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SeguimientoPaquetes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET RECOVERY FULL 
GO
ALTER DATABASE [SeguimientoPaquetes] SET  MULTI_USER 
GO
ALTER DATABASE [SeguimientoPaquetes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SeguimientoPaquetes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SeguimientoPaquetes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SeguimientoPaquetes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SeguimientoPaquetes] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SeguimientoPaquetes', N'ON'
GO
ALTER DATABASE [SeguimientoPaquetes] SET QUERY_STORE = OFF
GO
USE [SeguimientoPaquetes]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [SeguimientoPaquetes]
GO
/****** Object:  Table [dbo].[DESTINO]    Script Date: 6/12/2018 6:48:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DESTINO](
	[IDDESTINO] [int] IDENTITY(50,1) NOT NULL,
	[PAIS] [nvarchar](30) NOT NULL,
	[CIUDAD] [nvarchar](30) NOT NULL,
	[IMPUESTO] [int] NOT NULL,
 CONSTRAINT [PK_DESTINO] PRIMARY KEY CLUSTERED 
(
	[IDDESTINO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ENVIO]    Script Date: 6/12/2018 6:48:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ENVIO](
	[IDENVIO] [int] IDENTITY(30,1) NOT NULL,
	[DESC_ENVIO] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_ENVIO] PRIMARY KEY CLUSTERED 
(
	[IDENVIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADO]    Script Date: 6/12/2018 6:48:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO](
	[IDESTADO] [int] IDENTITY(40,1) NOT NULL,
	[DESC_ESTADO] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_ESTADO] PRIMARY KEY CLUSTERED 
(
	[IDESTADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORIGEN]    Script Date: 6/12/2018 6:48:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORIGEN](
	[IDORIGEN] [int] IDENTITY(10,1) NOT NULL,
	[PAIS] [nvarchar](30) NOT NULL,
	[CIUDAD] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_ORIGEN] PRIMARY KEY CLUSTERED 
(
	[IDORIGEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAGO]    Script Date: 6/12/2018 6:48:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAGO](
	[IDPAGO] [int] IDENTITY(20,1) NOT NULL,
	[DESC_PAGO] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_PAGO] PRIMARY KEY CLUSTERED 
(
	[IDPAGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PEDIDOS]    Script Date: 6/12/2018 6:48:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS](
	[IDPEDIDO] [int] IDENTITY(700,1) NOT NULL,
	[IDUSUARIO] [int] NOT NULL,
	[IDORIGEN] [int] NOT NULL,
	[IDDESTINO] [int] NOT NULL,
	[IDPAGO] [int] NOT NULL,
	[IDENVIO] [int] NOT NULL,
	[IDESTADO] [int] NOT NULL,
	[TOTAL] [int] NOT NULL,
	[DESCRIPCION] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PEDIDOS] PRIMARY KEY CLUSTERED 
(
	[IDPEDIDO] ASC,
	[IDUSUARIO] ASC,
	[IDORIGEN] ASC,
	[IDDESTINO] ASC,
	[IDPAGO] ASC,
	[IDENVIO] ASC,
	[IDESTADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 6/12/2018 6:48:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[IDUSUARIO] [int] IDENTITY(60,1) NOT NULL,
	[NOMBRE] [nvarchar](30) NOT NULL,
	[ALIAS] [nvarchar](30) NOT NULL,
	[PASS] [nvarchar](30) NOT NULL,
	[TIPO_USUARIO] [nvarchar](30) NOT NULL,
	[ESTADO_USUARIO] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[IDUSUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DESTINO] ON 

INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (50, N'Alabama (AL)', N'Montgomery', 200)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (51, N'Alaska (AK)', N'Juneau', 200)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (52, N'Arizona (AZ)', N'Phoenix', 200)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (53, N'Arkansas (AR)', N'Little Rock', 200)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (54, N'California (CA)', N'Sacramento', 200)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (55, N'Carolina del Norte (NC)', N'Raleigh', 200)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (56, N'Carolina del Sur (SC)', N'Columbia', 300)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (57, N'Colorado (CO)', N'Denver', 300)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (58, N'Connecticut (CT)', N'Hartford', 300)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (59, N'Dakota del Norte (ND)', N'Bismarck', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (60, N'Dakota del Sur (SD)', N'Pierre', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (61, N'Delaware (DE)', N'Dover', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (62, N'Florida (FL)', N'Tallahassee', 250)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (63, N'Georgia (GA)', N'Atlanta', 250)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (64, N'Hawái (HI)', N'Honolulu', 250)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (65, N'Idaho (ID)', N'Boise', 350)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (66, N'Illinois (IL)', N'Springfield', 350)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (67, N'Indiana (IN)', N'Indianápolis', 350)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (68, N'Iowa (IA)', N'Des Moines', 100)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (69, N'Kansas (KS)', N'Topeka', 100)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (70, N'Kentucky (KY)', N'Frankfort', 100)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (71, N'Luisiana (LA)', N'Baton Rouge', 175)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (72, N'Maine (ME)', N'Augusta', 175)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (73, N'Maryland (MD)', N'Annapolis', 175)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (74, N'Massachusetts (MA)', N'Boston', 390)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (75, N'Míchigan (MI)', N'Lansing', 390)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (76, N'Minnesota (MN)', N'Saint Paul', 390)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (77, N'Misisipi (MS)', N'Jackson', 225)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (78, N'Misuri (MO)', N'Jefferson City', 225)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (79, N'Montana (MT)', N'Helena', 225)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (80, N'Nebraska (NE)', N'Lincoln', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (81, N'Nevada (NV)', N'Carson City', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (82, N'Nueva Jersey (NJ)', N'Trenton', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (83, N'Nueva York (NY)', N'Albany', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (84, N'Nuevo Hampshire (NH)', N'Concord', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (85, N'Nuevo México (NM)', N'Santa Fe', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (86, N'Ohio (OH)', N'Columbus', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (87, N'Oklahoma (OK)', N'Oklahoma City', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (88, N'Oregón (OR)', N'Salem', 400)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (89, N'Pensilvania (PA)', N'Harrisburg', 150)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (90, N'Rhode Island (RI)', N'Providence', 150)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (91, N'Tennessee (TN)', N'Nashville', 150)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (92, N'Texas (TX)', N'Austin', 150)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (93, N'Utah (UT)', N'Salt Lake City', 150)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (94, N'Vermont (VT)', N'Montpelier', 150)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (95, N'Virginia (VA)', N'Richmond', 225)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (96, N'Virginia Occidental (WV)', N'Charleston', 225)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (97, N'Washington (WA)', N'Olympia', 225)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (98, N'Wisconsin (WI)', N'Madison', 225)
INSERT [dbo].[DESTINO] ([IDDESTINO], [PAIS], [CIUDAD], [IMPUESTO]) VALUES (99, N'Wyoming (WY)', N'Cheyenne', 225)
SET IDENTITY_INSERT [dbo].[DESTINO] OFF
SET IDENTITY_INSERT [dbo].[ENVIO] ON 

INSERT [dbo].[ENVIO] ([IDENVIO], [DESC_ENVIO]) VALUES (30, N'TERRESTRE')
INSERT [dbo].[ENVIO] ([IDENVIO], [DESC_ENVIO]) VALUES (31, N'MARITIMO')
INSERT [dbo].[ENVIO] ([IDENVIO], [DESC_ENVIO]) VALUES (32, N'AEREO')
SET IDENTITY_INSERT [dbo].[ENVIO] OFF
SET IDENTITY_INSERT [dbo].[ESTADO] ON 

INSERT [dbo].[ESTADO] ([IDESTADO], [DESC_ESTADO]) VALUES (40, N'PROCESANDO')
INSERT [dbo].[ESTADO] ([IDESTADO], [DESC_ESTADO]) VALUES (41, N'FLETE')
INSERT [dbo].[ESTADO] ([IDESTADO], [DESC_ESTADO]) VALUES (42, N'CASI LLEGANDO')
INSERT [dbo].[ESTADO] ([IDESTADO], [DESC_ESTADO]) VALUES (43, N'EN ADUANA')
INSERT [dbo].[ESTADO] ([IDESTADO], [DESC_ESTADO]) VALUES (44, N'RUTA A LA TIENDA')
INSERT [dbo].[ESTADO] ([IDESTADO], [DESC_ESTADO]) VALUES (45, N'LISTO PARA RETIRAR')
SET IDENTITY_INSERT [dbo].[ESTADO] OFF
SET IDENTITY_INSERT [dbo].[ORIGEN] ON 

INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (10, N'Alabama (AL)', N'Montgomery')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (11, N'Alaska (AK)', N'Juneau')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (12, N'Arizona (AZ)', N'Phoenix')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (13, N'Arkansas (AR)', N'Little Rock')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (14, N'California (CA)', N'Sacramento')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (15, N'Carolina del Norte (NC)', N'Raleigh')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (16, N'Carolina del Sur (SC)', N'Columbia')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (17, N'Colorado (CO)', N'Denver')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (18, N'Connecticut (CT)', N'Hartford')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (19, N'Dakota del Norte (ND)', N'Bismarck')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (20, N'Dakota del Sur (SD)', N'Pierre')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (21, N'Delaware (DE)', N'Dover')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (22, N'Florida (FL)', N'Tallahassee')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (23, N'Georgia (GA)', N'Atlanta')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (24, N'Hawái (HI)', N'Honolulu')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (25, N'Idaho (ID)', N'Boise')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (26, N'Illinois (IL)', N'Springfield')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (27, N'Indiana (IN)', N'Indianápolis')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (28, N'Iowa (IA)', N'Des Moines')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (29, N'Kansas (KS)', N'Topeka')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (30, N'Kentucky (KY)', N'Frankfort')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (31, N'Luisiana (LA)', N'Baton Rouge')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (32, N'Maine (ME)', N'Augusta')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (33, N'Maryland (MD)', N'Annapolis')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (34, N'Massachusetts (MA)', N'Boston')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (35, N'Míchigan (MI)', N'Lansing')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (36, N'Minnesota (MN)', N'Saint Paul')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (37, N'Misisipi (MS)', N'Jackson')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (38, N'Misuri (MO)', N'Jefferson City')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (39, N'Montana (MT)', N'Helena')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (40, N'Nebraska (NE)', N'Lincoln')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (41, N'Nevada (NV)', N'Carson City')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (42, N'Nueva Jersey (NJ)', N'Trenton')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (43, N'Nueva York (NY)', N'Albany')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (44, N'Nuevo Hampshire (NH)', N'Concord')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (45, N'Nuevo México (NM)', N'Santa Fe')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (46, N'Ohio (OH)', N'Columbus')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (47, N'Oklahoma (OK)', N'Oklahoma City')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (48, N'Oregón (OR)', N'Salem')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (49, N'Pensilvania (PA)', N'Harrisburg')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (50, N'Rhode Island (RI)', N'Providence')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (51, N'Tennessee (TN)', N'Nashville')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (52, N'Texas (TX)', N'Austin')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (53, N'Utah (UT)', N'Salt Lake City')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (54, N'Vermont (VT)', N'Montpelier')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (55, N'Virginia (VA)', N'Richmond')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (56, N'Virginia Occidental (WV)', N'Charleston')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (57, N'Washington (WA)', N'Olympia')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (58, N'Wisconsin (WI)', N'Madison')
INSERT [dbo].[ORIGEN] ([IDORIGEN], [PAIS], [CIUDAD]) VALUES (59, N'Wyoming (WY)', N'Cheyenne')
SET IDENTITY_INSERT [dbo].[ORIGEN] OFF
SET IDENTITY_INSERT [dbo].[PAGO] ON 

INSERT [dbo].[PAGO] ([IDPAGO], [DESC_PAGO]) VALUES (20, N'TARJETA CREDITO')
INSERT [dbo].[PAGO] ([IDPAGO], [DESC_PAGO]) VALUES (21, N'TARJETA DEBITO')
INSERT [dbo].[PAGO] ([IDPAGO], [DESC_PAGO]) VALUES (22, N'EFECTIVO')
SET IDENTITY_INSERT [dbo].[PAGO] OFF
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 

INSERT [dbo].[USUARIOS] ([IDUSUARIO], [NOMBRE], [ALIAS], [PASS], [TIPO_USUARIO], [ESTADO_USUARIO]) VALUES (60, N'CARLOS', N'ADMINC', N'1234', N'ADMIN', N'1')
INSERT [dbo].[USUARIOS] ([IDUSUARIO], [NOMBRE], [ALIAS], [PASS], [TIPO_USUARIO], [ESTADO_USUARIO]) VALUES (61, N'PABLO', N'USERP', N'5678', N'USER', N'1')
INSERT [dbo].[USUARIOS] ([IDUSUARIO], [NOMBRE], [ALIAS], [PASS], [TIPO_USUARIO], [ESTADO_USUARIO]) VALUES (62, N'SERGIO', N'CLIENTC', N'9090', N'CLIENT', N'1')
INSERT [dbo].[USUARIOS] ([IDUSUARIO], [NOMBRE], [ALIAS], [PASS], [TIPO_USUARIO], [ESTADO_USUARIO]) VALUES (63, N'MARCELA', N'CLIENTM', N'1212', N'CLIENT', N'1')
INSERT [dbo].[USUARIOS] ([IDUSUARIO], [NOMBRE], [ALIAS], [PASS], [TIPO_USUARIO], [ESTADO_USUARIO]) VALUES (64, N'LUCIA', N'CLIENTL', N'1515', N'CLIENT', N'0')
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_DESTINO] FOREIGN KEY([IDDESTINO])
REFERENCES [dbo].[DESTINO] ([IDDESTINO])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_DESTINO]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_ENVIO] FOREIGN KEY([IDENVIO])
REFERENCES [dbo].[ENVIO] ([IDENVIO])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_ENVIO]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_ESTADO] FOREIGN KEY([IDESTADO])
REFERENCES [dbo].[ESTADO] ([IDESTADO])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_ESTADO]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_ORIGEN] FOREIGN KEY([IDORIGEN])
REFERENCES [dbo].[ORIGEN] ([IDORIGEN])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_ORIGEN]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_PAGO] FOREIGN KEY([IDPAGO])
REFERENCES [dbo].[PAGO] ([IDPAGO])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_PAGO]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_USUARIOS] FOREIGN KEY([IDUSUARIO])
REFERENCES [dbo].[USUARIOS] ([IDUSUARIO])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_USUARIOS]
GO
/****** Object:  StoredProcedure [dbo].[LOGIN]    Script Date: 6/12/2018 6:48:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[LOGIN]
@IDUSER nvarchar(30),
@PASSW nvarchar(30)
AS
SELECT * FROM USUARIOS WHERE ALIAS=@IDUSER AND PASS=@PASSW 
GO
USE [master]
GO
ALTER DATABASE [SeguimientoPaquetes] SET  READ_WRITE 
GO
