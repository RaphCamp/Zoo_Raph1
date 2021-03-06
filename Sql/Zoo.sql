USE [master]
GO
/****** Object:  Database [ZOO_Raph]    Script Date: 10/11/2021 14:09:47 ******/
CREATE DATABASE [ZOO_Raph]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZOO_Raph', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ZOO_Raph.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ZOO_Raph_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ZOO_Raph.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ZOO_Raph] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZOO_Raph].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZOO_Raph] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [ZOO_Raph] SET ANSI_NULLS ON 
GO
ALTER DATABASE [ZOO_Raph] SET ANSI_PADDING ON 
GO
ALTER DATABASE [ZOO_Raph] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [ZOO_Raph] SET ARITHABORT ON 
GO
ALTER DATABASE [ZOO_Raph] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZOO_Raph] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZOO_Raph] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZOO_Raph] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZOO_Raph] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [ZOO_Raph] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [ZOO_Raph] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZOO_Raph] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [ZOO_Raph] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZOO_Raph] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZOO_Raph] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZOO_Raph] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZOO_Raph] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZOO_Raph] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZOO_Raph] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZOO_Raph] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZOO_Raph] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZOO_Raph] SET RECOVERY FULL 
GO
ALTER DATABASE [ZOO_Raph] SET  MULTI_USER 
GO
ALTER DATABASE [ZOO_Raph] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZOO_Raph] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZOO_Raph] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZOO_Raph] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ZOO_Raph] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ZOO_Raph] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ZOO_Raph] SET QUERY_STORE = OFF
GO
USE [ZOO_Raph]
GO
/****** Object:  Table [dbo].[Animaux]    Script Date: 10/11/2021 14:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animaux](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](50) NOT NULL,
	[Espece] [nvarchar](50) NOT NULL,
	[Sous-espece] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Sexe] [nvarchar](50) NOT NULL,
	[Statut] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especes]    Script Date: 10/11/2021 14:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especes](
	[EspeceAnimal] [nvarchar](50) NOT NULL,
	[Nombre de spécimène] [int] NULL,
	[Classe] [nvarchar](50) NOT NULL,
	[Famille] [nvarchar](50) NOT NULL,
	[Sous-famille] [nvarchar](50) NOT NULL,
	[régime] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Especes] PRIMARY KEY CLUSTERED 
(
	[EspeceAnimal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Animaux] ON 

INSERT [dbo].[Animaux] ([Id], [Nom], [Espece], [Sous-espece], [Age], [Sexe], [Statut]) VALUES (1, N'Arnold', N'Bos Taurus', N'Taureau jaune', 28, N'Mâle', N'Bonne santé')
INSERT [dbo].[Animaux] ([Id], [Nom], [Espece], [Sous-espece], [Age], [Sexe], [Statut]) VALUES (2, N'Hercule', N'Panthera Leo', N'Lion rouge', 40, N'Mâle', N'Bonne santé')
INSERT [dbo].[Animaux] ([Id], [Nom], [Espece], [Sous-espece], [Age], [Sexe], [Statut]) VALUES (3, N'Leo', N'Panthera Leo', N'Lion d''Afrique', 25, N'Non déterminé', N'Malade')
INSERT [dbo].[Animaux] ([Id], [Nom], [Espece], [Sous-espece], [Age], [Sexe], [Statut]) VALUES (4, N'Steakos', N'Bos Taurus', N'Taureau bleu', 20, N'Femelle', N'Mort')
INSERT [dbo].[Animaux] ([Id], [Nom], [Espece], [Sous-espece], [Age], [Sexe], [Statut]) VALUES (5, N'Condor', N'Falco', N'Faucon Taita', 5, N'Mâle', N'Malade')
INSERT [dbo].[Animaux] ([Id], [Nom], [Espece], [Sous-espece], [Age], [Sexe], [Statut]) VALUES (6, N'Neige', N'Falco', N'Faucon Gris', 20, N'Femelle', N'Bonne santé')
SET IDENTITY_INSERT [dbo].[Animaux] OFF
GO
INSERT [dbo].[Especes] ([EspeceAnimal], [Nombre de spécimène], [Classe], [Famille], [Sous-famille], [régime]) VALUES (N'Bos Taurus', 2, N'	Mammalia', N'Bovidae', N'Bovinae', N'Grand Ruminant')
INSERT [dbo].[Especes] ([EspeceAnimal], [Nombre de spécimène], [Classe], [Famille], [Sous-famille], [régime]) VALUES (N'Falco', 2, N'Aves', N'Falconidae', N'Falconinae', N'Petit Carnivore')
INSERT [dbo].[Especes] ([EspeceAnimal], [Nombre de spécimène], [Classe], [Famille], [Sous-famille], [régime]) VALUES (N'Panthera Leo', 2, N'Mammalia', N'Felidae', N'Pantherinae', N'Grand Carnivore')
GO
ALTER TABLE [dbo].[Animaux] ADD  DEFAULT ('inconnu') FOR [Nom]
GO
ALTER TABLE [dbo].[Animaux] ADD  DEFAULT ('inconnu') FOR [Espece]
GO
ALTER TABLE [dbo].[Animaux] ADD  DEFAULT ('inconnu') FOR [Sous-espece]
GO
ALTER TABLE [dbo].[Animaux] ADD  DEFAULT ((0)) FOR [Age]
GO
ALTER TABLE [dbo].[Animaux] ADD  DEFAULT ('inconnu') FOR [Sexe]
GO
ALTER TABLE [dbo].[Animaux] ADD  DEFAULT ('inconnu') FOR [Statut]
GO
ALTER TABLE [dbo].[Animaux]  WITH CHECK ADD  CONSTRAINT [FK_Animaux_Especes] FOREIGN KEY([Espece])
REFERENCES [dbo].[Especes] ([EspeceAnimal])
GO
ALTER TABLE [dbo].[Animaux] CHECK CONSTRAINT [FK_Animaux_Especes]
GO
USE [master]
GO
ALTER DATABASE [ZOO_Raph] SET  READ_WRITE 
GO
