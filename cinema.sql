USE [master]
GO
/****** Object:  Database [CenimaDB]    Script Date: 8/24/2022 11:22:13 PM ******/
CREATE DATABASE [CenimaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CenimaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CenimaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CenimaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CenimaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CenimaDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CenimaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CenimaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CenimaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CenimaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CenimaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CenimaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CenimaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CenimaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CenimaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CenimaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CenimaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CenimaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CenimaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CenimaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CenimaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CenimaDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CenimaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CenimaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CenimaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CenimaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CenimaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CenimaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CenimaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CenimaDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CenimaDB] SET  MULTI_USER 
GO
ALTER DATABASE [CenimaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CenimaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CenimaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CenimaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CenimaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CenimaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CenimaDB', N'ON'
GO
ALTER DATABASE [CenimaDB] SET QUERY_STORE = OFF
GO
USE [CenimaDB]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 8/24/2022 11:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 8/24/2022 11:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NULL,
	[Year] [int] NULL,
	[Image] [nvarchar](255) NULL,
	[Description] [ntext] NULL,
	[GenreID] [int] NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 8/24/2022 11:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](200) NULL,
	[Gender] [nvarchar](10) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](100) NULL,
	[Type] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rates]    Script Date: 8/24/2022 11:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rates](
	[MovieID] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
	[Comment] [ntext] NULL,
	[NumericRating] [float] NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_Rates] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC,
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (1, N'Hành động')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (2, N'Tâm lý tình cảm')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (3, N'Kinh dị')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (4, N'Hoạt hình')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (5, N'Khoa học - Nghệ thuật')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (6, N'string')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (7, N'string')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (9, N'sá')
SET IDENTITY_INSERT [dbo].[Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (1, N'Bão ngầm', 2022, N'https://i.ibb.co/h7yqcS2/653a51b9a526e74ae689198120c12519.jpg', N'dasdsad', 1)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (2, N'Mặt nạ gương', 2021, N'https://i.ibb.co/fpnsD2b/Matnaguongposter.jpg', N'Demo', 1)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (4, N'Về nhà đi con', 2021, N'https://i.ibb.co/nQd4Jyn/V-nh-i-con-poster.jpg', N'Demo  ', 5)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (5, N'Ngõ nhỏ vào đời', 2022, N'https://i.ibb.co/q76rgcx/Loinhovaodoiposter.jpg', N'Demo', 2)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (6, N'Conan', 2021, N'https://i.ibb.co/89GrFzh/Harpers-Bazaar-phim-tham-tu-lung-danh-Conan-04.jpg', N'fdsf', 5)
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (1, N'Phạm Minh Hùng', N'Nam', N'user1@gmail.com', N'123', 1, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (2, N'Phạm Ngọc Minh Châu', N'Nữ', N'user2@gmail.com', N'1234', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (3, N'Hoàng Đức Hải', N'Nam', N'user3@gmail.com', N'12345', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (4, N'Quách Như Thế', N'Nam', N'user4@gmail.com', N'123456', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (5, N'Nguyễn Thùy Dương', N'Nữ', N'user5@gmail.com', N'1234567', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (6, N'Trịnh Thị Trang', N'Nữ', N'user6@gmail.com', N'12345678', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (7, N'Hoàng Tùng', N'Nam', N'user7@gmail.com', N'123456789', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (8, N'Sown', N'Nam', N'sa', N'sa', 1, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (9, N'Sown', N'Nam', N'se', N'se', 2, 1)
SET IDENTITY_INSERT [dbo].[Persons] OFF
GO
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (1, 1, N'Phim rất hay', 8.6, CAST(N'2022-10-06T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[Movies]  WITH CHECK ADD  CONSTRAINT [FK_Movies_Genres] FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genres] ([GenreID])
GO
ALTER TABLE [dbo].[Movies] CHECK CONSTRAINT [FK_Movies_Genres]
GO
ALTER TABLE [dbo].[Rates]  WITH CHECK ADD  CONSTRAINT [FK_Rates_Movies] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[Rates] CHECK CONSTRAINT [FK_Rates_Movies]
GO
ALTER TABLE [dbo].[Rates]  WITH CHECK ADD  CONSTRAINT [FK_Rates_Persons] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Persons] ([PersonID])
GO
ALTER TABLE [dbo].[Rates] CHECK CONSTRAINT [FK_Rates_Persons]
GO
USE [master]
GO
ALTER DATABASE [CenimaDB] SET  READ_WRITE 
GO
