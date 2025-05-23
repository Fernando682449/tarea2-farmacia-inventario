USE [master]
GO
/****** Object:  Database [FarmaciaDB]    Script Date: 18/5/2025 18:35:07 ******/
CREATE DATABASE [FarmaciaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FarmaciaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ALBORNOZ\MSSQL\DATA\FarmaciaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FarmaciaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ALBORNOZ\MSSQL\DATA\FarmaciaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FarmaciaDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FarmaciaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FarmaciaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FarmaciaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FarmaciaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FarmaciaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FarmaciaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FarmaciaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FarmaciaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FarmaciaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FarmaciaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FarmaciaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FarmaciaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FarmaciaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FarmaciaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FarmaciaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FarmaciaDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FarmaciaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FarmaciaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FarmaciaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FarmaciaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FarmaciaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FarmaciaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FarmaciaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FarmaciaDB] SET RECOVERY FULL 
GO
ALTER DATABASE [FarmaciaDB] SET  MULTI_USER 
GO
ALTER DATABASE [FarmaciaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FarmaciaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FarmaciaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FarmaciaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FarmaciaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FarmaciaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FarmaciaDB', N'ON'
GO
ALTER DATABASE [FarmaciaDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [FarmaciaDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FarmaciaDB]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 18/5/2025 18:35:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[FechaCaducidad] [date] NULL,
	[Stock] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 18/5/2025 18:35:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Clave] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [FarmaciaDB] SET  READ_WRITE 
GO
