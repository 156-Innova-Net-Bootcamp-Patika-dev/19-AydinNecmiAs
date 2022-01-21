USE [master]
GO

/****** Object:  Database [SiteDb]    Script Date: 21.01.2022 12:03:35 ******/
CREATE DATABASE [SiteDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SiteDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SiteDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SiteDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SiteDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SiteDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SiteDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SiteDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SiteDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SiteDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SiteDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [SiteDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [SiteDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SiteDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SiteDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SiteDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SiteDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SiteDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SiteDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SiteDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SiteDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [SiteDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SiteDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SiteDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SiteDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SiteDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SiteDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SiteDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SiteDb] SET RECOVERY FULL 
GO

ALTER DATABASE [SiteDb] SET  MULTI_USER 
GO

ALTER DATABASE [SiteDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SiteDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SiteDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SiteDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [SiteDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [SiteDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [SiteDb] SET QUERY_STORE = OFF
GO

ALTER DATABASE [SiteDb] SET  READ_WRITE 
GO
