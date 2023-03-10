USE [master]
GO
/****** Object:  Database [bospersonelveritabani]    Script Date: 27.02.2023 00:16:39 ******/
CREATE DATABASE [bospersonelveritabani]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bospersonelveritabani', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\bospersonelveritabani.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bospersonelveritabani_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\bospersonelveritabani_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [bospersonelveritabani] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bospersonelveritabani].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bospersonelveritabani] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET ARITHABORT OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bospersonelveritabani] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bospersonelveritabani] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bospersonelveritabani] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bospersonelveritabani] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bospersonelveritabani] SET  MULTI_USER 
GO
ALTER DATABASE [bospersonelveritabani] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bospersonelveritabani] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bospersonelveritabani] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bospersonelveritabani] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [bospersonelveritabani] SET DELAYED_DURABILITY = DISABLED 
GO
USE [bospersonelveritabani]
GO
/****** Object:  Table [dbo].[Tbl_Personel]    Script Date: 27.02.2023 00:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Personel](
	[Perid] [smallint] IDENTITY(1,1) NOT NULL,
	[Perad] [varchar](10) NULL,
	[Persoyad] [varchar](20) NULL,
	[Persehir] [varchar](13) NULL,
	[Permaas] [smallint] NULL,
	[Perdurum] [bit] NULL,
	[Permeslek] [varchar](15) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Yonetici]    Script Date: 27.02.2023 00:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Yonetici](
	[KullaniciAd] [varchar](10) NULL,
	[Sifre] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Personel] ON 

INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (1, N'Baran', N'Yucedag', N'Ankara', 2800, 1, N'Ogretmen')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (2, N'Emel', N'Cınar', N'Bursa', 2900, 0, N'Hemsire')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (3, N'Yavuz', N'Aslan', N'İstanbul', 3200, 1, N'Ogretmen')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (4, N'İsmail', N'Gemili', N'Bursa', 3300, 0, N'Doktor')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (5, N'Eylul', N'Kırmızı', N'İstanbul', 2500, 1, N'Muhendis')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (15, N'hamza', N'kracı', N'Hatay', 2600, 1, N'Att')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (16, N'fırat', N'lale', N'Konya', 3000, 0, N'Muhendis')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (8, N'arif', N'boykoz', N'Batman', 2800, 1, N'Muhendis')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (9, N'arda', N'guler', N'yalova', 2800, 1, N'Ogretmen')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (10, N'Omer', N'donmez', N'balıkesir', 2500, 0, N'Muhendis')
INSERT [dbo].[Tbl_Personel] ([Perid], [Perad], [Persoyad], [Persehir], [Permaas], [Perdurum], [Permeslek]) VALUES (13, N'mustafa', N'yorgun', N'İstanbul', 4500, 1, N'antrenor')
SET IDENTITY_INSERT [dbo].[Tbl_Personel] OFF
INSERT [dbo].[Tbl_Yonetici] ([KullaniciAd], [Sifre]) VALUES (N'admin34', N'001122')
INSERT [dbo].[Tbl_Yonetici] ([KullaniciAd], [Sifre]) VALUES (N'personel01', N'123456')
USE [master]
GO
ALTER DATABASE [bospersonelveritabani] SET  READ_WRITE 
GO
