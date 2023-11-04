USE [master]
GO
/****** Object:  Database [Restaurante-Grupo22]    Script Date: 03/11/2023 21:11:06 ******/
CREATE DATABASE [Restaurante-Grupo22]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restaurante-Grupo22', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Restaurante-Grupo22.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Restaurante-Grupo22_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Restaurante-Grupo22_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Restaurante-Grupo22] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restaurante-Grupo22].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restaurante-Grupo22] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restaurante-Grupo22] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restaurante-Grupo22] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Restaurante-Grupo22] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restaurante-Grupo22] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Restaurante-Grupo22] SET  MULTI_USER 
GO
ALTER DATABASE [Restaurante-Grupo22] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Restaurante-Grupo22] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restaurante-Grupo22] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restaurante-Grupo22] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Restaurante-Grupo22] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Restaurante-Grupo22] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Restaurante-Grupo22] SET QUERY_STORE = OFF
GO
USE [Restaurante-Grupo22]
GO
/****** Object:  Table [dbo].[Insumo]    Script Date: 03/11/2023 21:11:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insumo](
	[Id_Insumo] [int] NOT NULL,
	[Nombre_Insumo] [varchar](20) NOT NULL,
	[Tipo_Insumo] [varchar](20) NOT NULL,
 CONSTRAINT [pk_Insumo] PRIMARY KEY CLUSTERED 
(
	[Id_Insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesas]    Script Date: 03/11/2023 21:11:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesas](
	[NumeroMesa_Mesa] [int] NOT NULL,
	[Id_MeseroMesa] [int] NOT NULL,
	[Capacidad_Mesa] [int] NOT NULL,
	[Estado_Mesa] [bit] NOT NULL,
	[NombreMesero_Mesa] [varchar](20) NOT NULL,
 CONSTRAINT [pk_Mesas] PRIMARY KEY CLUSTERED 
(
	[NumeroMesa_Mesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesero]    Script Date: 03/11/2023 21:11:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesero](
	[Id_M] [int] NOT NULL,
	[Dni_M] [char](8) NOT NULL,
	[MesasAsignadas_M] [int] NOT NULL,
	[Nombre_M] [varchar](20) NOT NULL,
	[Apellido_M] [varchar](20) NOT NULL,
 CONSTRAINT [pk_Mesero] PRIMARY KEY CLUSTERED 
(
	[Id_M] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 03/11/2023 21:11:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[NumeroPedido_Pe] [int] NOT NULL,
	[Horapedido_Pe] [datetime] NOT NULL,
	[NumeroMesa_Pe] [int] NOT NULL,
	[EstadoPedido_Pe] [bit] NOT NULL,
	[Comentarios_Pe] [varchar](50) NOT NULL,
	[HoraCierre_Pe] [datetime] NOT NULL,
 CONSTRAINT [pk_Pedido] PRIMARY KEY CLUSTERED 
(
	[NumeroPedido_Pe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PedidoXInsumo]    Script Date: 03/11/2023 21:11:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PedidoXInsumo](
	[NumeroPedido_PXI] [int] NOT NULL,
	[IdInsumo_PXI] [int] NOT NULL,
	[CantidadEnStock_PXI] [int] NOT NULL,
	[PrecioUnitario_PXI] [decimal](8, 2) NOT NULL,
 CONSTRAINT [pk_PedidoXInsumo] PRIMARY KEY CLUSTERED 
(
	[NumeroPedido_PXI] ASC,
	[IdInsumo_PXI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 03/11/2023 21:11:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[TipoUsuario] [int] NOT NULL,
 CONSTRAINT [pk_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Contraseña], [Usuario], [TipoUsuario]) VALUES (1, N'test', N'test', 1)
INSERT [dbo].[Usuarios] ([Id], [Contraseña], [Usuario], [TipoUsuario]) VALUES (3, N'admin', N'admin', 2)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Mesas]  WITH CHECK ADD  CONSTRAINT [fk_Mesas_Mesero] FOREIGN KEY([Id_MeseroMesa])
REFERENCES [dbo].[Mesero] ([Id_M])
GO
ALTER TABLE [dbo].[Mesas] CHECK CONSTRAINT [fk_Mesas_Mesero]
GO
ALTER TABLE [dbo].[Mesero]  WITH CHECK ADD  CONSTRAINT [fk_Mesero_Usuario] FOREIGN KEY([Id_M])
REFERENCES [dbo].[Usuarios] ([Id])
GO
ALTER TABLE [dbo].[Mesero] CHECK CONSTRAINT [fk_Mesero_Usuario]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [fk_Pedido_Mesas] FOREIGN KEY([NumeroMesa_Pe])
REFERENCES [dbo].[Mesas] ([NumeroMesa_Mesa])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [fk_Pedido_Mesas]
GO
ALTER TABLE [dbo].[PedidoXInsumo]  WITH CHECK ADD  CONSTRAINT [fk_PedidoXInsumo_Insumo] FOREIGN KEY([IdInsumo_PXI])
REFERENCES [dbo].[Insumo] ([Id_Insumo])
GO
ALTER TABLE [dbo].[PedidoXInsumo] CHECK CONSTRAINT [fk_PedidoXInsumo_Insumo]
GO
ALTER TABLE [dbo].[PedidoXInsumo]  WITH CHECK ADD  CONSTRAINT [fk_PedidoXInsumo_Pedido] FOREIGN KEY([NumeroPedido_PXI])
REFERENCES [dbo].[Pedido] ([NumeroPedido_Pe])
GO
ALTER TABLE [dbo].[PedidoXInsumo] CHECK CONSTRAINT [fk_PedidoXInsumo_Pedido]
GO
USE [master]
GO
ALTER DATABASE [Restaurante-Grupo22] SET  READ_WRITE 
GO
