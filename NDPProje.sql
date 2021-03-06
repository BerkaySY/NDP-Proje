USE [NDPProje]
GO
/****** Object:  Table [dbo].[gider]    Script Date: 16.05.2022 23:03:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gider](
	[giderIsmi] [nvarchar](50) NOT NULL,
	[tutar] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[müşteri]    Script Date: 16.05.2022 23:03:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[müşteri](
	[tc] [nvarchar](50) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satış]    Script Date: 16.05.2022 23:03:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satış](
	[tc] [nvarchar](50) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](50) NOT NULL,
	[barkodNo] [nvarchar](50) NOT NULL,
	[ürünAdi] [nvarchar](50) NOT NULL,
	[miktar] [int] NOT NULL,
	[satisFiyati] [decimal](18, 2) NOT NULL,
	[toplamFiyat] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sipariş]    Script Date: 16.05.2022 23:03:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sipariş](
	[firmaNo] [nchar](10) NOT NULL,
	[firmaAd] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[barkodNo] [nchar](10) NOT NULL,
	[ürünAdı] [nvarchar](50) NOT NULL,
	[miktar] [int] NOT NULL,
	[alisFiyati] [decimal](18, 2) NOT NULL,
	[toplamFiyat] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stok]    Script Date: 16.05.2022 23:03:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stok](
	[barkodNo] [nvarchar](50) NOT NULL,
	[rafStogu] [int] NOT NULL,
	[depoStogu] [int] NOT NULL,
	[ürünAdi] [nvarchar](50) NOT NULL,
	[satisFiyati] [decimal](18, 2) NOT NULL,
	[alisFiyati] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tedarikçi]    Script Date: 16.05.2022 23:03:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tedarikçi](
	[firmaNo] [nvarchar](50) NOT NULL,
	[firmaAd] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
