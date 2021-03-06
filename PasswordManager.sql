USE [master]
GO
/****** Object:  Database [PasswordManager]    Script Date: 27.05.2022 18:19:23 ******/
CREATE DATABASE [PasswordManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PasswordManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PasswordManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PasswordManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PasswordManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PasswordManager] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PasswordManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PasswordManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PasswordManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PasswordManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PasswordManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PasswordManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [PasswordManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PasswordManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PasswordManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PasswordManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PasswordManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PasswordManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PasswordManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PasswordManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PasswordManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PasswordManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PasswordManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PasswordManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PasswordManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PasswordManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PasswordManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PasswordManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PasswordManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PasswordManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PasswordManager] SET  MULTI_USER 
GO
ALTER DATABASE [PasswordManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PasswordManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PasswordManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PasswordManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PasswordManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PasswordManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PasswordManager] SET QUERY_STORE = OFF
GO
USE [PasswordManager]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 27.05.2022 18:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[service_id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](500) NOT NULL,
	[url] [nvarchar](max) NOT NULL,
	[is_deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServicePassword]    Script Date: 27.05.2022 18:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicePassword](
	[service_password_id] [uniqueidentifier] NOT NULL,
	[service_id] [uniqueidentifier] NOT NULL,
	[user_id] [uniqueidentifier] NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[user_name] [nvarchar](254) NOT NULL,
	[note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ServicePassword] PRIMARY KEY CLUSTERED 
(
	[service_password_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 27.05.2022 18:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [uniqueidentifier] NOT NULL,
	[login] [nvarchar](32) NOT NULL,
	[salted_hash] [varbinary](max) NULL,
	[salt] [varbinary](max) NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[birthdate] [date] NOT NULL,
	[email] [nvarchar](254) NOT NULL,
	[is_deleted] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Service] ([service_id], [name], [url], [is_deleted]) VALUES (N'08c37d20-5321-4c77-a7f5-51e56568691a', N'Facebook', N'https://www.facebook.com/', 0)
INSERT [dbo].[Service] ([service_id], [name], [url], [is_deleted]) VALUES (N'3ca651ff-0859-4bb4-87f3-6afa92177103', N'Instagram', N'https://www.instagram.com', 0)
INSERT [dbo].[Service] ([service_id], [name], [url], [is_deleted]) VALUES (N'789fdb1b-a0fc-4cca-bb86-8ddd28962290', N'ВКонтакте', N'https://www.vk.com', 0)
INSERT [dbo].[Service] ([service_id], [name], [url], [is_deleted]) VALUES (N'39964125-eeac-419e-b175-c89711e0b6f7', N'Twitter', N'https://www.twitter.com', 0)
GO
INSERT [dbo].[ServicePassword] ([service_password_id], [service_id], [user_id], [password], [user_name], [note]) VALUES (N'c7951b33-6dfb-40f3-8f7b-d282e2a7f005', N'789fdb1b-a0fc-4cca-bb86-8ddd28962290', N'780ce932-aaa5-4ea0-a494-da23db1f5275', N'something', N'login', N'Примечание!')
INSERT [dbo].[ServicePassword] ([service_password_id], [service_id], [user_id], [password], [user_name], [note]) VALUES (N'6662942c-45a3-422d-9821-d8eec5b097f8', N'3ca651ff-0859-4bb4-87f3-6afa92177103', N'780ce932-aaa5-4ea0-a494-da23db1f5275', N'eQf9KHTvbDw!24p$S', N'instalogin', N'примечание')
GO
INSERT [dbo].[User] ([user_id], [login], [salted_hash], [salt], [first_name], [last_name], [birthdate], [email], [is_deleted]) VALUES (N'780ce932-aaa5-4ea0-a494-da23db1f5275', N'admin', 0xF5282F1B5029F7AD32E712EBE6781C8CEA1E4E84B25BF4C37EF3475CDB9BDE71, 0x3325E0B5878C33F6EC19827D1F389AAF, N'admin', N'admin', CAST(N'2001-01-01' AS Date), N'admin@example.com', 0)
GO
ALTER TABLE [dbo].[Service] ADD  CONSTRAINT [DF_Service_service_id]  DEFAULT (newid()) FOR [service_id]
GO
ALTER TABLE [dbo].[Service] ADD  CONSTRAINT [DF_Service_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[ServicePassword] ADD  CONSTRAINT [DF_ServicePassword_service_password_id]  DEFAULT (newid()) FOR [service_password_id]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_user_id]  DEFAULT (newid()) FOR [user_id]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[ServicePassword]  WITH CHECK ADD  CONSTRAINT [FK_ServicePassword_Service] FOREIGN KEY([service_id])
REFERENCES [dbo].[Service] ([service_id])
GO
ALTER TABLE [dbo].[ServicePassword] CHECK CONSTRAINT [FK_ServicePassword_Service]
GO
ALTER TABLE [dbo].[ServicePassword]  WITH CHECK ADD  CONSTRAINT [FK_ServicePassword_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[ServicePassword] CHECK CONSTRAINT [FK_ServicePassword_User]
GO
USE [master]
GO
ALTER DATABASE [PasswordManager] SET  READ_WRITE 
GO
