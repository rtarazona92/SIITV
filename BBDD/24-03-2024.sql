USE [master]
GO
/****** Object:  Database [siitv]    Script Date: 24/03/2024 09:10:25 ******/
CREATE DATABASE [siitv]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'siitv', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\siitv.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'siitv_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\siitv_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [siitv] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [siitv].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [siitv] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [siitv] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [siitv] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [siitv] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [siitv] SET ARITHABORT OFF 
GO
ALTER DATABASE [siitv] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [siitv] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [siitv] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [siitv] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [siitv] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [siitv] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [siitv] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [siitv] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [siitv] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [siitv] SET  DISABLE_BROKER 
GO
ALTER DATABASE [siitv] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [siitv] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [siitv] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [siitv] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [siitv] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [siitv] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [siitv] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [siitv] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [siitv] SET  MULTI_USER 
GO
ALTER DATABASE [siitv] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [siitv] SET DB_CHAINING OFF 
GO
ALTER DATABASE [siitv] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [siitv] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [siitv] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [siitv] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [siitv] SET QUERY_STORE = ON
GO
ALTER DATABASE [siitv] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [siitv]
GO
/****** Object:  Table [dbo].[CARROCERIA]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARROCERIA](
	[codigo_carr] [int] IDENTITY(1,1) NOT NULL,
	[sigla_carr] [varchar](3) NULL,
	[nombre_carr] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_carr] [datetime] NOT NULL,
 CONSTRAINT [PK_CARROCERIA] PRIMARY KEY CLUSTERED 
(
	[codigo_carr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[codigo_ca] [int] IDENTITY(1,1) NOT NULL,
	[nombre_ca] [varchar](2) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_ca] [datetime] NOT NULL,
 CONSTRAINT [PK_TB_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[codigo_ca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLASE_COMBINACION]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLASE_COMBINACION](
	[codigo_cla_comb] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cla_comb] [varchar](2) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_cla_comb] [datetime] NOT NULL,
 CONSTRAINT [PK_CLASE_COMBINACION] PRIMARY KEY CLUSTERED 
(
	[codigo_cla_comb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLASIFICACION_VEHICULAR]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLASIFICACION_VEHICULAR](
	[codigo_cla_ve] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_cla_ve] [nchar](500) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_cla_ve] [datetime] NOT NULL,
	[codigo_ca] [int] NOT NULL,
	[codigo_cla_comb] [int] NOT NULL,
 CONSTRAINT [PK_CLASIFICACION_VEHICULAR] PRIMARY KEY CLUSTERED 
(
	[codigo_cla_ve] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[codigo_cli] [int] IDENTITY(1,1) NOT NULL,
	[num_documento_cli] [varchar](11) NOT NULL,
	[nombre_completo_cli] [varchar](200) NOT NULL,
	[telefono_cli] [varchar](9) NULL,
	[email_cli] [varchar](100) NULL,
	[codigo_dir] [int] NOT NULL,
 CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED 
(
	[codigo_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COLOR]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COLOR](
	[codigo_co] [int] IDENTITY(1,1) NOT NULL,
	[sigla_co] [varchar](3) NULL,
	[nombre_co] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_co] [datetime] NOT NULL,
 CONSTRAINT [PK_COLOR] PRIMARY KEY CLUSTERED 
(
	[codigo_co] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEPARTAMENTO]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTAMENTO](
	[codigo_dep] [int] IDENTITY(1,1) NOT NULL,
	[nombre_dep] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_dep] [datetime] NOT NULL,
 CONSTRAINT [PK_DEPARTAMENTO] PRIMARY KEY CLUSTERED 
(
	[codigo_dep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIRECCION]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIRECCION](
	[codigo_dir] [int] IDENTITY(1,1) NOT NULL,
	[nombre_direccion] [varchar](200) NULL,
	[nombre_referencia] [varchar](150) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_dir] [datetime] NOT NULL,
	[codigo_dep] [int] NOT NULL,
	[codigo_prov] [int] NOT NULL,
	[codigo_dist] [int] NOT NULL,
 CONSTRAINT [PK_DIRECCION] PRIMARY KEY CLUSTERED 
(
	[codigo_dir] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DISTRITO]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DISTRITO](
	[codigo_dist] [int] IDENTITY(1,1) NOT NULL,
	[nombre_dist] [varchar](100) NULL,
	[estado] [int] NOT NULL,
	[fecha_registro_dist] [datetime] NOT NULL,
 CONSTRAINT [PK_DISTRITO] PRIMARY KEY CLUSTERED 
(
	[codigo_dist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCA]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCA](
	[codigo_ma] [int] IDENTITY(1,1) NOT NULL,
	[nombre_ma] [varchar](100) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_ma] [datetime] NOT NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[codigo_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MODELO]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODELO](
	[codigo_mo] [int] NOT NULL,
	[nombre_mo] [varchar](100) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_mo] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVINCIA]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVINCIA](
	[codigo_prov] [int] IDENTITY(1,1) NOT NULL,
	[nombre_prov] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_prov] [datetime] NOT NULL,
 CONSTRAINT [PK_PROVINCIA] PRIMARY KEY CLUSTERED 
(
	[codigo_prov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_CARROCERIA]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_CARROCERIA](
	[codigo_tip_carr] [int] IDENTITY(1,1) NOT NULL,
	[definicion_tip_carr] [varchar](500) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_tip_carr] [datetime] NOT NULL,
	[codigo_carr] [int] NOT NULL,
	[codigo_ca] [int] NOT NULL,
 CONSTRAINT [PK_TIPO_CARROCERIA] PRIMARY KEY CLUSTERED 
(
	[codigo_tip_carr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_COMBUSTIBLE]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_COMBUSTIBLE](
	[codigo_tc] [int] IDENTITY(1,1) NOT NULL,
	[sigla_tc] [varchar](3) NULL,
	[nombre_tc] [varchar](50) NULL,
	[definicion_tc] [varchar](1000) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_tc] [datetime] NOT NULL,
 CONSTRAINT [PK_COMBUSTIBLE] PRIMARY KEY CLUSTERED 
(
	[codigo_tc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_TRANSMISION]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_TRANSMISION](
	[codigo_tip_transmi] [int] IDENTITY(1,1) NOT NULL,
	[definicion_tip_transmi] [varchar](500) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_tip_transmi] [datetime] NOT NULL,
	[codigo_transmi] [int] NOT NULL,
 CONSTRAINT [PK_TIPO_TRANSMISION] PRIMARY KEY CLUSTERED 
(
	[codigo_tip_transmi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANSMISION]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANSMISION](
	[codigo_transmi] [int] IDENTITY(1,1) NOT NULL,
	[sigla_transmi] [varchar](3) NULL,
	[nombre_transmi] [varchar](20) NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro_transmi] [datetime] NOT NULL,
 CONSTRAINT [PK_TRANSMISION] PRIMARY KEY CLUSTERED 
(
	[codigo_transmi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE_DIRECCION] FOREIGN KEY([codigo_dir])
REFERENCES [dbo].[DIRECCION] ([codigo_dir])
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [FK_CLIENTE_DIRECCION]
GO
ALTER TABLE [dbo].[DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_DIRECCION_DEPARTAMENTO] FOREIGN KEY([codigo_dep])
REFERENCES [dbo].[DEPARTAMENTO] ([codigo_dep])
GO
ALTER TABLE [dbo].[DIRECCION] CHECK CONSTRAINT [FK_DIRECCION_DEPARTAMENTO]
GO
ALTER TABLE [dbo].[DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_DIRECCION_DISTRITO] FOREIGN KEY([codigo_dist])
REFERENCES [dbo].[DISTRITO] ([codigo_dist])
GO
ALTER TABLE [dbo].[DIRECCION] CHECK CONSTRAINT [FK_DIRECCION_DISTRITO]
GO
ALTER TABLE [dbo].[DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_DIRECCION_PROVINCIA] FOREIGN KEY([codigo_prov])
REFERENCES [dbo].[PROVINCIA] ([codigo_prov])
GO
ALTER TABLE [dbo].[DIRECCION] CHECK CONSTRAINT [FK_DIRECCION_PROVINCIA]
GO
ALTER TABLE [dbo].[TIPO_TRANSMISION]  WITH CHECK ADD  CONSTRAINT [FK_TIPO_TRANSMISION_TRANSMISION] FOREIGN KEY([codigo_transmi])
REFERENCES [dbo].[TRANSMISION] ([codigo_transmi])
GO
ALTER TABLE [dbo].[TIPO_TRANSMISION] CHECK CONSTRAINT [FK_TIPO_TRANSMISION_TRANSMISION]
GO
/****** Object:  StoredProcedure [dbo].[USP_Eliminar_carr]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Eliminar_carr]
@nCodigo_carr int=0
as
update CARROCERIA set estado=0 where codigo_carr=@nCodigo_carr;
GO
/****** Object:  StoredProcedure [dbo].[USP_Eliminar_co]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Eliminar_co]
@nCodigo_co int=0
as
update COLOR set estado=0 where codigo_co=@nCodigo_co;
GO
/****** Object:  StoredProcedure [dbo].[USP_Eliminar_tc]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Eliminar_tc]
@nCodigo_tc int=0
as
update TIPO_COMBUSTIBLE set estado=0 where codigo_tc=@nCodigo_tc;
GO
/****** Object:  StoredProcedure [dbo].[USP_Guardar_carr]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Guardar_carr]
@nOpcion int=0,
@nCodigo_carr int=0,
@cSigla_carr varchar(3)='',
@cNombre_carr varchar(50)=''
as
if @nOpcion=1 -- Nuevo Registro
begin
	insert into CARROCERIA(nombre_carr,sigla_carr, fecha_registro_carr,estado) values(@cNombre_carr,@cSigla_carr, GETDATE(),1);
end;
else -- Actualizar Registro
begin
	update CARROCERIA set nombre_carr=@cNombre_carr, sigla_carr=@cSigla_carr, fecha_registro_carr=GETDATE() where codigo_carr=@nCodigo_carr;
end;
GO
/****** Object:  StoredProcedure [dbo].[USP_Guardar_co]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Guardar_co]
@nOpcion int=0,
@nCodigo_co int=0,
@cSigla_co varchar(3)='',
@cNombre_co varchar(50)=''
as
if @nOpcion=1 -- Nuevo Registro
begin
	insert into COLOR(nombre_co,sigla_co,fecha_registro_co,estado) values(@cNombre_co,@cSigla_co, GETDATE(),1);
end;
else -- Actualizar Registro
begin
	update COLOR set nombre_co=@cNombre_co, sigla_co=@cSigla_co, fecha_registro_co=GETDATE() where codigo_co=@nCodigo_co;
end;
GO
/****** Object:  StoredProcedure [dbo].[USP_Guardar_tc]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Guardar_tc]
@nOpcion int=0,
@nCodigo_tc int=0,
@cSigla_tc varchar(3)='',
@cNombre_tc varchar(50)='',
@cDefinicion_tc varchar(1000)=''
as
if @nOpcion=1 -- Nuevo Registro
begin
	insert into TIPO_COMBUSTIBLE(sigla_tc,nombre_tc,definicion_tc, fecha_registro_tc,estado)
	values(@cSigla_tc,@cNombre_tc,@cDefinicion_tc, GETDATE(),1);
end;
else -- Actualizar Registro
begin
	update TIPO_COMBUSTIBLE set sigla_tc=@cSigla_tc, nombre_tc=@cNombre_tc, definicion_tc=@cDefinicion_tc, fecha_registro_tc=GETDATE()
	where codigo_tc=@nCodigo_tc;
end;
GO
/****** Object:  StoredProcedure [dbo].[USP_Listado_carr]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_Listado_carr]
@cTexto varchar(50)=''
as
	select codigo_carr, sigla_carr, nombre_carr
	from CARROCERIA
	where estado=1 and
	upper(trim(cast(codigo_carr as char))+trim(sigla_carr)+trim(nombre_carr)) like '%'+upper(trim(@cTexto))+'%';
GO
/****** Object:  StoredProcedure [dbo].[USP_Listado_co]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_Listado_co]
@cTexto varchar(50)=''
as
	select codigo_co, sigla_co, nombre_co
	from COLOR
	where estado=1 and
	upper(trim(cast(codigo_co as char))+trim(sigla_co)+trim(nombre_co)) like '%'+upper(trim(@cTexto))+'%';
GO
/****** Object:  StoredProcedure [dbo].[USP_Listado_tc]    Script Date: 24/03/2024 09:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_Listado_tc]
@cTexto varchar(50)=''
as
	select codigo_tc, sigla_tc, nombre_tc, definicion_tc
	from TIPO_COMBUSTIBLE
	where estado=1 and
	upper(trim(cast(codigo_tc as char))+trim(sigla_tc)+trim(nombre_tc)+trim(definicion_tc)) like '%'+upper(trim(@cTexto))+'%';
GO
USE [master]
GO
ALTER DATABASE [siitv] SET  READ_WRITE 
GO
