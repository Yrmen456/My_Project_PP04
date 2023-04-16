USE [master]
GO
/****** Object:  Database [Flow]    Script Date: 23.06.2022 12:08:46 ******/
CREATE DATABASE [Flow]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Flow', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Flow.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Flow_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Flow_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Flow] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Flow].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Flow] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Flow] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Flow] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Flow] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Flow] SET ARITHABORT OFF 
GO
ALTER DATABASE [Flow] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Flow] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Flow] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Flow] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Flow] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Flow] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Flow] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Flow] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Flow] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Flow] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Flow] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Flow] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Flow] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Flow] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Flow] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Flow] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Flow] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Flow] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Flow] SET  MULTI_USER 
GO
ALTER DATABASE [Flow] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Flow] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Flow] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Flow] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Flow] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Flow] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Flow] SET QUERY_STORE = OFF
GO
USE [Flow]
GO
/****** Object:  Table [dbo].[address]    Script Date: 23.06.2022 12:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[address](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[street] [nvarchar](max) NULL,
	[house] [nvarchar](max) NULL,
	[room] [nvarchar](max) NULL,
	[porth] [nvarchar](max) NULL,
	[floor] [nvarchar](max) NULL,
 CONSTRAINT [PK_address] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 23.06.2022 12:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[scr] [nvarchar](max) NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[items]    Script Date: 23.06.2022 12:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[scr] [nvarchar](max) NULL,
	[price] [int] NULL,
	[id_categories] [int] NOT NULL,
 CONSTRAINT [PK_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[items_order]    Script Date: 23.06.2022 12:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[items_order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_items] [int] NOT NULL,
	[id_orders] [int] NOT NULL,
 CONSTRAINT [PK_items_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korzina]    Script Date: 23.06.2022 12:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korzina](
	[id_zak] [int] IDENTITY(1,1) NOT NULL,
	[id_tov] [int] NULL,
	[Cena] [int] NULL,
	[Kol] [int] NULL,
	[scr] [varchar](max) NULL,
	[Name] [varchar](200) NULL,
 CONSTRAINT [PK_Korzina] PRIMARY KEY CLUSTERED 
(
	[id_zak] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 23.06.2022 12:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[id_order] [int] NOT NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 23.06.2022 12:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[first_name] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[last_name] [nvarchar](max) NULL,
	[phone] [nvarchar](max) NULL,
	[data_of_birth] [nvarchar](max) NULL,
	[gender] [nvarchar](max) NULL,
	[roll] [nvarchar](max) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[address] ON 

INSERT [dbo].[address] ([id], [id_user], [street], [house], [room], [porth], [floor]) VALUES (1, 1, N'', N'', N'', N'', N'')
INSERT [dbo].[address] ([id], [id_user], [street], [house], [room], [porth], [floor]) VALUES (2, 2, N'', N'', N'', N'', N'')
INSERT [dbo].[address] ([id], [id_user], [street], [house], [room], [porth], [floor]) VALUES (3, 3, N'', N'', N'', N'fafaf', N'afafaf')
INSERT [dbo].[address] ([id], [id_user], [street], [house], [room], [porth], [floor]) VALUES (4, 4, N'xcnvcncv', N'nvbmbvmvbmb,', N',bn,nm,n.nm.', N'm.nm.m,.m', N'jfghghdh')
INSERT [dbo].[address] ([id], [id_user], [street], [house], [room], [porth], [floor]) VALUES (5, 5, N'fgdfgd', N'3', N'4', N'2', N'1')
INSERT [dbo].[address] ([id], [id_user], [street], [house], [room], [porth], [floor]) VALUES (6, 6, N'sada', N'1', N'1', N'1', N'1')
SET IDENTITY_INSERT [dbo].[address] OFF
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([id], [Name], [scr]) VALUES (1, N'Свежесрезанные цветы', N'73fd0442e77e3f150ed30c932a0674dd.png')
INSERT [dbo].[categories] ([id], [Name], [scr]) VALUES (2, N'Цветочные букеты', N'87218d5f931f54ca04edef1e4a6aa2e7.png')
INSERT [dbo].[categories] ([id], [Name], [scr]) VALUES (3, N'Комнатные цветы', N'aaf3739aa4e813e680679058391329a5.png')
INSERT [dbo].[categories] ([id], [Name], [scr]) VALUES (4, N'Рассада', N'b572bd8b4a0cec9f3529e3a531f07288.png')
INSERT [dbo].[categories] ([id], [Name], [scr]) VALUES (5, N'Оформление цветов', N'ef99083575cb0ca7c945fbc64570b656.jpg')
INSERT [dbo].[categories] ([id], [Name], [scr]) VALUES (6, N'Упаковка и декор', N'd16ddc0bcbe71b2a6e0d5931db82d51d.jpg')
INSERT [dbo].[categories] ([id], [Name], [scr]) VALUES (7, N'Живые бабочки', N'f28f3f3d003fe7ec4e111c26782d00e2.jpg')
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[items] ON 

INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (1, N'Роза Кения Red Ribbon', N'3bd24a6decfd7cebd13bcd73f9c6eeda.jpg', 565, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (2, N'Альстеремия Chicago', N'69e1025db01f0d941e26ae83516f5b2f.jpg', 948, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (3, N'Гипсофила Gypsophila зелень для букетов', N'0646ff5a37578c7be5e4dfea3fd87363.jpg', 959, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (4, N'Аспарагус Umbellatus аспарагус зелень для букетов', N'ef7ee613ef41eef14192deb8322495a3.jpg', 871, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (5, N'Хризантема Chrys. Zembla crem', N'db506caa302541a17121567eb543486f.jpg', 640, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (6, N'Хризантема Chrys. Reigan', N'fd616a3e83e1593d74b91f6d670dc642.jpg', 985, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (7, N'Хризантема Chrys. Optimist', N'9e735242c183a88e0e206eb135d768aa.jpg', 653, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (8, N'Хризантема Chrys. Korona', N'fdcca35d5d68cf993f7ac6aea694ad8c.jpg', 965, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (9, N'Хризантема Chrys. Feelin green', N'eb244ddce6218842d470765dfc14b0e1.jpg', 998, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (10, N'Хризантема Chrys. Dance white', N'0a57ed4de5ebe4ecaf561fb7c76883de.jpg', 948, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (11, N'Хризантема Chrys. Dance salmon', N'0a57ed4de5ebe4ecaf561fb7c76883de.jpg', 710, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (12, N'Хризантема Chrys. Сelebrate', N'f12dfcc9d45450dfacf2708d9101e7d3.jpg', 572, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (13, N'Хризантема Chrys. Toshka', N'b69c1a77d99a884a2402ed2c8802ae62.jpg', 935, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (14, N'Хризантема Chrys. Toshka Red', N'e8230cd545b029126edeeeb754557941.jpg', 674, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (15, N'Хризантема Chrys. Timman Dark', N'79d448937716931e1dd2e75d83252e75.jpg', 885, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (16, N'Хризантема Chrys. Stellini', N'b96dcf7301020ef575a3d8bfa328b22f.jpg', 768, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (17, N'Хризантема Chrys. Radost', N'8fa01307015eca9f07a5aa3e4d59d069.jpg', 502, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (18, N'Хризантема Chrys. Radost Cream', N'b1ee457931f8681efdad804ea94f40d4.jpg', 846, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (19, N'Хризантема Chrys. Pleasure', N'b1ee457931f8681efdad804ea94f40d4.jpg', 685, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (20, N'Хризантема Chrys. Merlot', N'b1ee457931f8681efdad804ea94f40d4.jpg', 815, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (21, N'Хризантема Chrys. Baltika white', N'5931605f579d5db60b55b184ccfd8d34.jpg', 598, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (22, N'Хризантема Chrys. Baltica yellow', N'5931605f579d5db60b55b184ccfd8d34.jpg', 804, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (23, N'Хризантема Chrys. Bacardi white', N'57f31eefe0160eae1101ff3a0d66afa3.jpg', 556, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (24, N'Хризантема Chrys. Artist', N'8eeaac429bb7d3c8a4bc64e6694a355d.jpg', 936, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (25, N'Лимониум Limonium зелень для букетов', N'c1b469b1236c30ca3fe67801265ca977.jpg', 703, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (26, N'Монстера Monstera зелень для букетов', N'17e08268c28c814b61ec9dc685a45caf.jpg', 923, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (27, N'Хризантема Chr. Antonov 1hd mix', N'8cfe0be93eeeee384376cd48facb8395.jpg', 612, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (28, N'Цветочная композиция 45', N'1f5d6a39c7c82498b91438d9683c1cb5.jpg', 797, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (29, N'Цветочная композиция 44', N'551c1ddb2fe4aed807af613414bc0f40.jpg', 638, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (30, N'Цветочная композиция 43', N'6409c8b2458d7c8f3ca7ae8f75aab3f1.jpg', 665, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (31, N'Цветочная композиция 42', N'ac653630d08d861ba6d3e5193f239eb6.jpg', 902, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (32, N'Цветочная композиция 41', N'6c86385b3a796053a4d8d97c04838612.jpg', 663, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (33, N'Цветочная композиция 40', N'841ebed0ecf41db69bdb93e787e2f34f.jpg', 592, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (34, N'Цветочная композиция 39', N'8873a0d4d7c3243d2791257b9281d78a.jpg', 519, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (35, N'Цветочная композиция 38', N'1feedd445fbe1dbbf6f6416f0763ae0d.jpg', 923, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (36, N'Цветочная композиция 37', N'b2a5511b1f2be3ecc1be394a8df17291.jpg', 877, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (37, N'Цветочная композиция 36', N'596416f949467662c31202372d33801f.jpg', 650, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (38, N'Цветочная композиция 35', N'7d494cf7bf18a5ec71edcbc6e0760e4b.jpg', 855, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (39, N'Цветочная композиция 34', N'fe3161ef8bdefc7a916c55218a6e25b7.jpg', 753, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (40, N'Букет сборный 67', N'd4dc47483e2ed1b72c06cca2cbaeb899.jpg', 967, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (41, N'Букет сборный 66', N'17433c30e97c68508a13d6aca1284f2c.jpg', 972, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (42, N'Букет сборный 65', N'ece21fd8918efbd16964f1ddf015e522.jpg', 732, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (43, N'Букет сборный 64', N'0cbfb3015bca5738702812e336d4d443.jpg', 524, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (44, N'Букет сборный 63', N'30b9f5620e4fff82bb91340609d3b478.jpg', 641, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (45, N'Букет сборный 62', N'884dd3252c06da7e10ecfcdeba365b7b.jpg', 883, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (46, N'Букет сборный 61', N'262c5430f5898d92e82b45de66def440.jpg', 603, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (47, N'Букет сборный 60', N'62c671f06511165a7d5f55456ff6574c.jpg', 689, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (48, N'Букет сборный 59', N'6e018e2b07c5dfba232a95b743741051.jpg', 580, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (49, N'Букет сборный 58', N'c7e6b3d75417fe9e648044c4a6670d85.jpg', 654, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (50, N'Букет сборный 57', N'426e6525f77c803d0d868eea68bcf0ec.jpg', 512, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (51, N'Букет сборный 56', N'a433717d4249844c19340c59c7247f1e.jpg', 574, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (52, N'Букет сборный 55', N'e294758327d7d347ed01aed51606decc.jpg', 988, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (53, N'Букет сборный 54', N'0a52f782d691e3f0b13a3b4531b6dcbc.jpg', 879, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (54, N'Букет сборный 52', N'0d360791408185e292fa76ed41468f59.jpg', 995, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (55, N'Букет сборный 51', N'9967d316c570bf43fccc9fb442aa3d92.jpg', 749, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (56, N'Букет сборный 50', N'1d8e1711289f747b502d61d80f2d232e.jpg', 992, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (57, N'Букет сборный 49', N'530c3172dfb1d56ed4e442ede5a626da.jpg', 831, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (58, N'Букет сборный 48', N'09430596b773a2cfa482464118a43d77.jpg', 507, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (59, N'Букет сборный 47', N'5f4ed48d3a33f47e896541e6a3d6ffcb.jpg', 968, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (60, N'Букет сборный 46', N'bc8d756f423b12e9145bd43f43a3b348.jpg', 839, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (61, N'Букет сборный 45', N'1054a0b9a7f2043af691ee6cf899b05a.jpg', 619, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (62, N'Букет сборный 44', N'f9654133d33974ef57d436e9c337ffdb.jpg', 974, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (63, N'Букет сборный 43', N'69ded987f744ca2ac03276da59d58359.jpg', 866, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (64, N'Букет сборный 42', N'8e6b8646b99d873c745b93255c62131c.jpg', 967, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (65, N'Букет сборный 41', N'20d42652b39b9fec2568422f7b319dc5.jpg', 897, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (66, N'Букет сборный 40', N'bb10c6bcc5dd8911c29ac31f8c60a962.jpg', 621, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (67, N'Букет сборный 39', N'a29d7fa19cae12001e7978c617f7248a.jpg', 905, 2)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (68, N'Спатифиллум(17)', N'b75bb2992d5f1ef8aff60bfe64591ace.jpg', 846, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (69, N'Эхинокактус Грузони микс (12)', N'bfec4449f520342b5ecc6e99dd3dd436.jpg', 905, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (70, N'Фикус рабуста 3 ствола (27/110)', N'ee2424769e886059058d0a84e453a442.jpg', 886, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (71, N'Крассула толстянка (10)', N'8a58b22d6ee48cda57a910bb3fb3ef37.jpg', 799, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (72, N'Спатифиллум (13)', N'097fb976fefccd4e70b9c286f0134185.png', 992, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (73, N'Аспарагус микс (12)', N'a5e2863228d74bba4b3e15fa156a7c5a.jpg', 819, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (74, N'Гиацинт микс (7)', N'15caa56f474135cfbb984eb9daaa4894.jpg', 552, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (75, N'Драцена Маргината 3 ствола крупномер (24)', N'26a42adebf61c862fae902d5fb69d889.jpg', 997, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (76, N'Фикус Экзотика (27\120)', N'e68dc388f99200734c8d9397277011c5.jpg', 691, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (77, N'Фикус Даниэль (21\110)', N'e557d6c9857cab9c36f8d00e6b720674.jpg', 934, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (78, N'Аглаонема микс (12)', N'e5de96e6aecb870253c97aa10fa35d47.jpg', 689, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (79, N'Кофе (12)', N'59db6a975b2b47732b52d1de7761b8e7.png', 890, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (80, N'Цикламен (10)', N'f52f93d73e20b3f0c854659d18199e7b.jpg', 960, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (81, N'Нолина (17)', N'5d6f3cf9361ec5cd8d1df01139269388.jpg', 888, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (82, N'Кипарис Вилма(12)', N'e0a0aa714152bca78c2709f65c214797.jpg', 750, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (83, N'Хлорофитум (19)', N'0b95387f36a30f260f3b506e00932fa1.jpg', 900, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (84, N'Фикус эластик микс (12)', N'e8fd7d22c0b69224de3abd44122c0c90.jpg', 673, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (85, N'Маранта (10)', N'd4bb779bae9058bcb654758661f7fd5e.jpg', 710, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (86, N'Герань грандифлора (12)', N'0791b75a85c1c15f7bcda747deaed4e8.jpg', 624, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (87, N'Гардения (13)', N'417374425316386729ebe6c586622a66.jpg', 635, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (88, N'Араукария (10)', N'36a6c5c492ce68e01af7aeac8096ac4b.JPG', 709, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (89, N'Юкка (14)', N'ab26c77b0dbe05b828d66e30bf710850.gif', 658, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (90, N'Непентес (14)', N'b9719d09c4cf6f37923d8e10428b9970.jpg', 753, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (91, N'Спатиффиллум (9)', N'63ec52e9424f2e3a3e988c8f0c6c8a04.png', 821, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (92, N'Роза Патио (13)', N'8e008ca787ad03b9d933327de2720aba.jpg', 523, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (93, N'Роза микс А2 (11)', N'cf220353e8c58958d0e7c7397e9fcd33.jpg', 568, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (94, N'Примула (9)', N'2cb3aa6cc3240059b4c5480bbc67780c.jpg', 951, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (95, N'Кампанула микс (11)', N'58287be6e028987b2654a91ac501a4bb.jpg', 628, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (96, N'Гортензия микс (13)', N'0692ad3d8ce2266cfed30bd0491dff11.jpg', 609, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (97, N'Цитрус Лимон (21\90)', N'e5828de6f12c2fce793c53955e51bc93.jpg', 599, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (98, N'Фаленопсис микс (12/60) орхидея', N'841bb1837d4bda7db03d6aa9857f3fab.jpg', 545, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (99, N'Орхидея синяя Фаленопсис (12)', N'88a4bc835fd64f48079cbfdf8aa28f5f.jpg', 639, 3)
GO
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (100, N'Эхинокактус Грузони микс (5)', N'be9dc82efdbfcd4b5b68e9cd9ee2767c.jpg', 671, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (101, N'Бегония микс (13)', N'6163cc079e2081ec84584702b0e37358.jpg', 682, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (102, N'Азалия микс (12)', N'ef99083575cb0ca7c945fbc64570b656.jpg', 720, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (103, N'Гузмания микс (12)', N'52ce6efbb07029fb551ee2a48a4284e9.jpg', 537, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (104, N'Кодиуем Экселент (13)', N'd34f482a3c5bdb855c8a1a69599fa36f.jpg', 768, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (105, N'Хризантема Зембла (13)', N'db37165e1e1801c167c82af0a0d8e852.jpg', 506, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (106, N'Антуриум Ред Кинг (14)', N'd7d392c066c19879b56176d711ef73ee.png', 814, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (107, N'Цинерария морская Сineraria maritima', N'4f0efc1c9fe4e95da9a921dd8bad46f4.jpg', 867, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (108, N'Табак крылатый nicotiana alata', N'4c29ca6358504d95f5f8e21305c710ca.jpg', 878, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (109, N'Сальвия блестящая Salvia splendens', N'e909c5186963601ceabe2f88791389bd.jpg', 701, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (110, N'Кохия веничная', N'a158fb24294902405f11d1fd88426bfb.jpg', 630, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (111, N'Колеус', N'19ff1695d125cb39c67559f81da05a7d.jpg', 633, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (112, N'Виола рогатая Viola cornuta', N'097e4c2e5d44194ea82d63a229bad177.jpg', 631, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (113, N'Хризантема Chrys. Baltica pink', N'57f31eefe0160eae1101ff3a0d66afa3.jpg', 540, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (114, N'Гузмания Остара (9)', N'c852c6279af84f10f6b2230620d2b4a6.jpg', 923, 3)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (115, N'Виола витрокка, анютины глазки', N'fbf052ceab7e1c56d3c7e9ff1191fbe7.jpg', 868, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (116, N'Вербена гибридная', N'1448eb61c30b207c222b897522c40b7e.jpg', 788, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (117, N'Астра китайкая', N'b9810b8818d5c004fe2b74da33f755f8.jpg', 541, 4)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (118, N'Топпер для букета', N'1feee69a325d18b87cc12108c117d333.jpg', 961, 5)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (119, N'Открытка к букету (записка)', N'd16ddc0bcbe71b2a6e0d5931db82d51d.jpg', 837, 5)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (120, N'Оформление в фетре', N'8785a968ce4bbcaf34fdcb45abdfe1bb.jpg', 618, 5)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (121, N'Дизайнерское комбинированное оформление (матовая пленка, бумага, и т.д.)', N'ef788a3f39f40bdbac64e499b39d3e9c.jpg', 757, 5)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (122, N'Оформление на атласную ленту', N'c0918ae8426e7aac061e16d5edf09548.jpg', 864, 5)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (123, N'Оформление в целофан', N'450bab2aaa56b7f96ba8e3335310b1d3.jpeg', 589, 5)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (124, N'Оформление в сизаль (сетка)', N'449646e3521bc4da2fc7c218f8de89d7.jpg', 760, 5)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (125, N'Оформление в крафт бумагу', N'17d3e099a59312234c9958dd28293129.png', 869, 5)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (126, N'GOL-641 Бумага премиум влагостойкая Соты Золото на синем (Корея)', N'7a3b8ff70f889b9f09883c67f806f320.jpeg', 677, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (127, N'GOL-636 Бумага премиум влагостойкая Соты сиреневый|фиолет (Корея)', N'd1cd6ba34703cb5655bf509c8d41af47.jpeg', 822, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (128, N'GOL-634 Бумага премиум влагостойкая Соты синий|голубой (Корея)', N'e4dddb6d4412ee2788539dc3112157d5.jpeg', 901, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (129, N'GOL-633 Бумага премиум влагостойкая Соты желтый|оранж (Корея)', N'3d2b8fdb03eb85ade05d6f71e32441b4.jpeg', 809, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (130, N'GOL-632 Бумага премиум влагостойкая Соты роз|сирень (Корея)', N'8a0c5b393db7bc24e2d5c78ddeb0a0db.jpeg', 778, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (131, N'GOL-1823 Бумага премиум влагостойкая Бордо Нити (Корея)', N'2524324289e5d20b410d628ad561738f.jpeg', 790, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (132, N'GOL-1819 Бумага премиум влагостойкая Желтый Нити|горох (Корея)', N'177f406ac8b579d416ca44ef378f7779.jpeg', 867, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (133, N'GOL-1818 Бумага премиум влагостойкая Фиолетовый Нити|горох (Корея)', N'1c35c8187f1f8c0c80039fc49e92b5ea.jpeg', 860, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (134, N'GOL-570 Бумага премиум влагостойкая Полосы сирен|фиолет (Корея)', N'c6ea6824213ef78f834a69d2f8d45d8a.jpeg', 679, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (135, N'GOL-569 Бумага премиум влагостойкая Полосы Синий|голубой (Корея)', N'58900fc0b452800efc26b4bb706ae961.jpeg', 884, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (136, N'GOL-567 Бумага премиум влагостойкая Полосы Роз|Сирень (Корея)', N'0794810d431a55680171711188fbc34a.jpeg', 803, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (137, N'GOL-511 Бумага премиум влагостойкая Мальчик голубая (Корея)', N'22819b98c62d2e4b17a14f40a9b60280.jpeg', 786, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (138, N'GOL-501 Бумага премиум влагостойкая Девочка розовый (Корея)', N'e584e831b8deb73cc5e27441c77292d7.jpeg', 834, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (139, N'А-21 Коробка резная Сердце', N'no_photo.png', 508, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (140, N'А-22 Коробка резная Сердце', N'no_photo.png', 657, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (141, N'Рамка дерево (1300) 10х15', N'no_photo.png', 919, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (142, N'Рамка дерево (1524) 10х15', N'no_photo.png', 708, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (143, N'Рамка дерево (1521) 15х21', N'no_photo.png', 993, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (144, N'Рамка дерево (1521) 10х15', N'no_photo.png', 639, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (145, N'Рамка дерево (1507) 10х15', N'no_photo.png', 745, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (146, N'Рамка дерево (1507) 21х30', N'no_photo.png', 869, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (147, N'Рамка дерево (1303) 10х15', N'no_photo.png', 638, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (148, N'Рамка дерево (1301) 21х30', N'no_photo.png', 553, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (149, N'Рамка дерево (1301) 15х21', N'no_photo.png', 605, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (150, N'Рамка дерево (1303) 30х40', N'no_photo.png', 912, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (151, N'Рамка дерево (1521) 21х30', N'no_photo.png', 527, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (152, N'Рамка дерево (1300) 15х21', N'no_photo.png', 794, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (153, N'Рамка дерево (1300) 21х30', N'no_photo.png', 982, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (154, N'Рамка дерево (1303) 21х30', N'no_photo.png', 866, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (155, N'Рамка дерево (1703) 21х30', N'no_photo.png', 678, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (156, N'Рамка дерево (1303) 15х21', N'no_photo.png', 768, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (157, N'Портбукетница Флора', N'no_photo.png', 878, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (158, N'Булавка для бутоньерок', N'no_photo.png', 766, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (159, N'Тейп лента коричневый', N'no_photo.png', 541, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (160, N'Тейп лента белый', N'no_photo.png', 720, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (161, N'Лоток универсальный зигзак под 2 оазиса', N'no_photo.png', 733, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (162, N'Пакет 27х28/32 лип лента', N'no_photo.png', 795, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (163, N'Бумага Эколюкс крепир. Сирень 5м 700мм в асс', N'no_photo.png', 937, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (164, N'Бумага КрафтБВК 700мм Монро тон 2-х в асс', N'no_photo.png', 938, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (165, N'Живые бабочки "Papilio Demoleus"', N'e0bd7af99a63a73ec2a6ba89fdfa7abe.jpg', 912, 7)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (166, N'Живые бабочки "Troides Rhadamantus"', N'c8e10a5178dcdfa2afcaeba4f0413fe2.jpg', 798, 7)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (167, N'Живые бабочки "Papilio Rumanzovia"', N'8594fda24aa6785c1d7ec8617416be1d.jpg', 514, 7)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (168, N'Живые бабочки "Hebomoia Glaucippe"', N'f28f3f3d003fe7ec4e111c26782d00e2.jpg', 802, 7)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (169, N'Живые бабочки "Graphium agamemnon"', N'ea6c9216983efea306c4406b630a56d3.jpg', 684, 7)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (170, N'Живые бабочки "Danaus Crisippus"', N'435e2aa267e8674e3446f46fd81403eb.jpg', 759, 7)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (171, N'Живые бабочки "Attacus atlas"', N'9aed6db8fd7688aa187b216a0f701ba8.jpg', 504, 7)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (172, N'Рамка дерево (1301) 10х15', N'no_photo.png', 764, 6)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (173, N'Роза кустовая белая', N'618899c4a7a8e605694b0f88103ace95.jpg', 957, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (174, N'Роза кустовая нежно-розовая', N'2dbae225b72143c47b643c9f9db9ed1c.jpg', 841, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (175, N'Пион', N'04044f54256e572b2b24ca70dda6180b.png', 577, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (176, N'Гортензия (MIX)', N'd823dd868766696323a2752723bcf3b0.jpg', 794, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (177, N'Статица', N'1feb1eed389225154cae9c14f36ee048.jpg', 962, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (178, N'Хлопок', N'53bd6aa6ccb3fb1d44fbd8e90f9be110.jpg', 518, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (179, N'Танацетум', N'4307d3f6d28e5fbe50c80932cd251eae.jpg', 763, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (180, N'Ромашка Голландская', N'7eafa804978956058ff78b0c7f32c28f.jpg', 858, 1)
INSERT [dbo].[items] ([id], [Name], [scr], [price], [id_categories]) VALUES (181, N'Роза кустовая спрей', N'43cd4d7bd6889747f49acec43432afa0.jpg', 753, 1)
SET IDENTITY_INSERT [dbo].[items] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [login], [password], [first_name], [name], [last_name], [phone], [data_of_birth], [gender], [roll]) VALUES (1, N'AVSHGVS', N'A1!aaaaaa', N'jha', N'asdg', N'sagd', N'+7(487) 878-78-88', N'46.46.4646', N'shy', N'0')
INSERT [dbo].[users] ([id], [login], [password], [first_name], [name], [last_name], [phone], [data_of_birth], [gender], [roll]) VALUES (2, N'zbhj@kjsbafb.akfga', N'A1!aaaaaaaa', N'sdf', N'sg', N'sdg', N'+7(564) 646-46-54', N'54.64.6465', N'woman', N'0')
INSERT [dbo].[users] ([id], [login], [password], [first_name], [name], [last_name], [phone], [data_of_birth], [gender], [roll]) VALUES (3, N'fbsjv@dadn.slkjsn', N'A1!aaaaaaaa', N'', N'', N'', N'+7(646) 464-64-64', N'  .  .', N'', N'0')
INSERT [dbo].[users] ([id], [login], [password], [first_name], [name], [last_name], [phone], [data_of_birth], [gender], [roll]) VALUES (4, N'innockentij10@gmail.com', N'A1!aaaaaa', N'ydg', N'dfgjhdghjhgk', N'hlgkklh', N'+7(546) 464-64-64', N'54.65.4646', N'shy', N'0')
INSERT [dbo].[users] ([id], [login], [password], [first_name], [name], [last_name], [phone], [data_of_birth], [gender], [roll]) VALUES (5, N'd', N'd', N'aasd', N'asd', N'asd', N'123124144', N'июн 22 2022  8:27PM', N'Мужской', N'Клиент')
INSERT [dbo].[users] ([id], [login], [password], [first_name], [name], [last_name], [phone], [data_of_birth], [gender], [roll]) VALUES (6, N'vlad', N'vlad', N'sda', N'sda', N'dsa', N'21314356', N'июн 23 2022 11:53AM', N'Мужской', N'Клиент')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[address]  WITH CHECK ADD  CONSTRAINT [FK_address_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[address] CHECK CONSTRAINT [FK_address_users]
GO
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [FK_items_categories] FOREIGN KEY([id_categories])
REFERENCES [dbo].[categories] ([id])
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [FK_items_categories]
GO
ALTER TABLE [dbo].[items_order]  WITH CHECK ADD  CONSTRAINT [FK_items_order_items] FOREIGN KEY([id_items])
REFERENCES [dbo].[items] ([id])
GO
ALTER TABLE [dbo].[items_order] CHECK CONSTRAINT [FK_items_order_items]
GO
ALTER TABLE [dbo].[items_order]  WITH CHECK ADD  CONSTRAINT [FK_items_order_order] FOREIGN KEY([id_orders])
REFERENCES [dbo].[order] ([id])
GO
ALTER TABLE [dbo].[items_order] CHECK CONSTRAINT [FK_items_order_order]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_users]
GO
USE [master]
GO
ALTER DATABASE [Flow] SET  READ_WRITE 
GO
