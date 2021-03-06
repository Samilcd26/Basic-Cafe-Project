USE [master]
GO
/****** Object:  Database [BilgiKafeVT]    Script Date: 18.10.2021 09:17:08 ******/
CREATE DATABASE [BilgiKafeVT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BilgiKafeVT', FILENAME = N'C:\BilgiKafe\VT\BilgiKafeVT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BilgiKafeVT_log', FILENAME = N'C:\BilgiKafe\VT\BilgiKafeVT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BilgiKafeVT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BilgiKafeVT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET ARITHABORT OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BilgiKafeVT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BilgiKafeVT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BilgiKafeVT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BilgiKafeVT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BilgiKafeVT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BilgiKafeVT] SET  MULTI_USER 
GO
ALTER DATABASE [BilgiKafeVT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BilgiKafeVT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BilgiKafeVT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BilgiKafeVT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BilgiKafeVT] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BilgiKafeVT]
GO
/****** Object:  Table [dbo].[AdisyonDetayTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdisyonDetayTablosu](
	[AdisyonDetayNo] [bigint] IDENTITY(1,1) NOT NULL,
	[AdisyonNo] [int] NOT NULL,
	[MenuNo] [uniqueidentifier] NOT NULL,
	[Adet] [smallint] NOT NULL,
	[Fiyat] [money] NOT NULL,
	[Aciklama] [nvarchar](200) NULL,
 CONSTRAINT [PK_AdisyonDetayTablosu] PRIMARY KEY CLUSTERED 
(
	[AdisyonDetayNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdisyonTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdisyonTablosu](
	[AdisyonNo] [int] IDENTITY(1,1) NOT NULL,
	[MasaKayitNo] [int] NOT NULL,
	[TarihSaat] [datetime] NOT NULL,
	[PersonelNo] [int] NOT NULL,
	[Aciklama] [nvarchar](200) NULL,
 CONSTRAINT [PK_AdisyonTablosu] PRIMARY KEY CLUSTERED 
(
	[AdisyonNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KasaTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KasaTablosu](
	[AdisyonNo] [int] NOT NULL,
	[FisNo] [nvarchar](15) NULL,
	[TarihSaat] [datetime] NOT NULL,
	[ToplamTutar] [money] NOT NULL,
	[indirim] [money] NULL,
	[OdemeSekli] [nvarchar](20) NOT NULL,
	[PersonelNo] [int] NULL,
 CONSTRAINT [PK_KasaTablosu] PRIMARY KEY CLUSTERED 
(
	[AdisyonNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KategoriTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KategoriTablosu](
	[KategoriNo] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_KategoriTablosu] PRIMARY KEY CLUSTERED 
(
	[KategoriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MasaMekanTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasaMekanTablosu](
	[MasaMekanNo] [int] IDENTITY(1,1) NOT NULL,
	[MasaMekanAdi] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_MasaMekanTablosu] PRIMARY KEY CLUSTERED 
(
	[MasaMekanNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MasaTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasaTablosu](
	[MasaKayitNo] [int] IDENTITY(1,1) NOT NULL,
	[MasaNo] [smallint] NOT NULL,
	[MasaMekanNo] [int] NOT NULL,
 CONSTRAINT [PK_MasaTablosu] PRIMARY KEY CLUSTERED 
(
	[MasaKayitNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuTablosu](
	[MenuNo] [uniqueidentifier] NOT NULL,
	[UrunAdi] [nvarchar](200) NOT NULL,
	[icindekiler] [nvarchar](max) NULL,
	[Fiyat] [money] NOT NULL,
	[KategoriNo] [int] NOT NULL,
	[Resim] [image] NULL,
	[GuncellemeTarihi] [datetime] NOT NULL,
 CONSTRAINT [PK_MenuTablosu] PRIMARY KEY CLUSTERED 
(
	[MenuNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaketServisTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaketServisTablosu](
	[AdisyonNo] [int] NOT NULL,
	[Adi] [nvarchar](53) NOT NULL,
	[Soyadi] [nvarchar](25) NULL,
	[Telefon] [nvarchar](12) NOT NULL,
	[TarihSaat] [datetime] NOT NULL,
	[Adres] [nvarchar](250) NOT NULL,
	[Aciklama] [nvarchar](200) NULL,
 CONSTRAINT [PK_PaketServisTablosu] PRIMARY KEY CLUSTERED 
(
	[AdisyonNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelTablosu](
	[PersonelNo] [int] IDENTITY(1,1) NOT NULL,
	[TCKimlikNo] [nvarchar](11) NULL,
	[Adi] [nvarchar](30) NOT NULL,
	[Soyadi] [nvarchar](25) NOT NULL,
	[Telefon] [nvarchar](12) NULL,
	[Adres] [nvarchar](250) NULL,
	[Gorevi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PersonelTablosu] PRIMARY KEY CLUSTERED 
(
	[PersonelNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RezervasyonTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RezervasyonTablosu](
	[RezervasyonNo] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](30) NOT NULL,
	[Soyadi] [nvarchar](25) NULL,
	[Telefon] [nchar](10) NULL,
	[KisiSayisi] [smallint] NOT NULL,
	[TarihSaat] [datetime] NOT NULL,
	[MasaKayitNo] [int] NOT NULL,
 CONSTRAINT [PK_RezervasyonTablosu] PRIMARY KEY CLUSTERED 
(
	[RezervasyonNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunlerTablosu]    Script Date: 18.10.2021 09:17:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunlerTablosu](
	[UrunNo] [bigint] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](75) NOT NULL,
	[BirimTuru] [int] NOT NULL,
	[AlisAdet] [decimal](14, 4) NOT NULL,
	[AlisFiyati] [money] NOT NULL,
	[AlisTarihi] [datetime] NOT NULL,
	[SonKullanmaTarihi] [datetime] NULL,
	[CikisAdet] [decimal](14, 4) NULL,
 CONSTRAINT [PK_UrunlerTablosu] PRIMARY KEY CLUSTERED 
(
	[UrunNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MenuTablosu] ADD  CONSTRAINT [DF_MenuTablosu_MenuNo]  DEFAULT (newid()) FOR [MenuNo]
GO
ALTER TABLE [dbo].[AdisyonDetayTablosu]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonDetayTablosu_AdisyonTablosu] FOREIGN KEY([AdisyonNo])
REFERENCES [dbo].[AdisyonTablosu] ([AdisyonNo])
GO
ALTER TABLE [dbo].[AdisyonDetayTablosu] CHECK CONSTRAINT [FK_AdisyonDetayTablosu_AdisyonTablosu]
GO
ALTER TABLE [dbo].[AdisyonDetayTablosu]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonDetayTablosu_MenuTablosu] FOREIGN KEY([MenuNo])
REFERENCES [dbo].[MenuTablosu] ([MenuNo])
GO
ALTER TABLE [dbo].[AdisyonDetayTablosu] CHECK CONSTRAINT [FK_AdisyonDetayTablosu_MenuTablosu]
GO
ALTER TABLE [dbo].[AdisyonTablosu]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonTablosu_KasaTablosu] FOREIGN KEY([AdisyonNo])
REFERENCES [dbo].[KasaTablosu] ([AdisyonNo])
GO
ALTER TABLE [dbo].[AdisyonTablosu] CHECK CONSTRAINT [FK_AdisyonTablosu_KasaTablosu]
GO
ALTER TABLE [dbo].[AdisyonTablosu]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonTablosu_MasaTablosu] FOREIGN KEY([MasaKayitNo])
REFERENCES [dbo].[MasaTablosu] ([MasaKayitNo])
GO
ALTER TABLE [dbo].[AdisyonTablosu] CHECK CONSTRAINT [FK_AdisyonTablosu_MasaTablosu]
GO
ALTER TABLE [dbo].[AdisyonTablosu]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonTablosu_PaketServisTablosu] FOREIGN KEY([AdisyonNo])
REFERENCES [dbo].[PaketServisTablosu] ([AdisyonNo])
GO
ALTER TABLE [dbo].[AdisyonTablosu] CHECK CONSTRAINT [FK_AdisyonTablosu_PaketServisTablosu]
GO
ALTER TABLE [dbo].[AdisyonTablosu]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonTablosu_PersonelTablosu] FOREIGN KEY([PersonelNo])
REFERENCES [dbo].[PersonelTablosu] ([PersonelNo])
GO
ALTER TABLE [dbo].[AdisyonTablosu] CHECK CONSTRAINT [FK_AdisyonTablosu_PersonelTablosu]
GO
ALTER TABLE [dbo].[KasaTablosu]  WITH CHECK ADD  CONSTRAINT [FK_KasaTablosu_PersonelTablosu] FOREIGN KEY([PersonelNo])
REFERENCES [dbo].[PersonelTablosu] ([PersonelNo])
GO
ALTER TABLE [dbo].[KasaTablosu] CHECK CONSTRAINT [FK_KasaTablosu_PersonelTablosu]
GO
ALTER TABLE [dbo].[MasaTablosu]  WITH CHECK ADD  CONSTRAINT [FK_MasaTablosu_MasaMekanTablosu] FOREIGN KEY([MasaMekanNo])
REFERENCES [dbo].[MasaMekanTablosu] ([MasaMekanNo])
GO
ALTER TABLE [dbo].[MasaTablosu] CHECK CONSTRAINT [FK_MasaTablosu_MasaMekanTablosu]
GO
ALTER TABLE [dbo].[MenuTablosu]  WITH CHECK ADD  CONSTRAINT [FK_MenuTablosu_KategoriTablosu] FOREIGN KEY([KategoriNo])
REFERENCES [dbo].[KategoriTablosu] ([KategoriNo])
GO
ALTER TABLE [dbo].[MenuTablosu] CHECK CONSTRAINT [FK_MenuTablosu_KategoriTablosu]
GO
ALTER TABLE [dbo].[RezervasyonTablosu]  WITH CHECK ADD  CONSTRAINT [FK_RezervasyonTablosu_MasaTablosu] FOREIGN KEY([MasaKayitNo])
REFERENCES [dbo].[MasaTablosu] ([MasaKayitNo])
GO
ALTER TABLE [dbo].[RezervasyonTablosu] CHECK CONSTRAINT [FK_RezervasyonTablosu_MasaTablosu]
GO
USE [master]
GO
ALTER DATABASE [BilgiKafeVT] SET  READ_WRITE 
GO
