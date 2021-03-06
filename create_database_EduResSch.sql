/****** This is nearly a stright copy from SQL Studio export. I removed the some lines concerning the creation of the database, the contraints and FILEPATH. Then it works fine. ******/

USE [master]
GO
/****** Object:  Database [EduResSch-template1]    Script Date: 10/14/2016 4:48:36 PM ******/
CREATE DATABASE [EduResSch-template1]
GO
ALTER DATABASE [EduResSch-template1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EduResSch-template1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EduResSch-template1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EduResSch-template1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EduResSch-template1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EduResSch-template1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EduResSch-template1] SET ARITHABORT OFF 
GO
ALTER DATABASE [EduResSch-template1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EduResSch-template1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EduResSch-template1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EduResSch-template1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EduResSch-template1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EduResSch-template1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EduResSch-template1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EduResSch-template1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EduResSch-template1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EduResSch-template1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EduResSch-template1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EduResSch-template1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EduResSch-template1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EduResSch-template1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EduResSch-template1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EduResSch-template1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EduResSch-template1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EduResSch-template1] SET RECOVERY FULL 
GO
ALTER DATABASE [EduResSch-template1] SET  MULTI_USER 
GO
ALTER DATABASE [EduResSch-template1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EduResSch-template1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EduResSch-template1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EduResSch-template1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EduResSch-template1] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EduResSch-template1', N'ON'
GO
USE [EduResSch-template1]
GO
/****** Object:  Table [dbo].[buildings]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buildings](
	[dbBuildingsId] [int] IDENTITY(1,1) NOT NULL,
	[buildingName] [nvarchar](50) NOT NULL,
	[buildingNickName] [nvarchar](50) NULL,
 CONSTRAINT [PK_buildings] PRIMARY KEY CLUSTERED 
(
	[dbBuildingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[buildingsRooms]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buildingsRooms](
	[buildingsRoomsId] [int] IDENTITY(1,1) NOT NULL,
	[dbBuildingsId] [int] NOT NULL,
	[dbRoomId] [int] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[buildingsRoomsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[campus]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[campus](
	[campusId] [int] IDENTITY(1,1) NOT NULL,
	[campusName] [nvarchar](50) NOT NULL,
	[campusNickName] [nvarchar](50) NULL,
 CONSTRAINT [PK_campus] PRIMARY KEY CLUSTERED 
(
	[campusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[campusBuildings]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[campusBuildings](
	[campusBuildingsId] [int] IDENTITY(1,1) NOT NULL,
	[campusId] [int] NOT NULL,
	[dbBuildingsId] [int] NOT NULL,
 CONSTRAINT [PK_campusBuildings] PRIMARY KEY CLUSTERED 
(
	[campusBuildingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[courses]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[courses](
	[coursesId] [int] IDENTITY(1,1) NOT NULL,
	[subjectsId] [int] NULL,
	[crnNum] [int] NOT NULL,
	[courseNum] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_courses] PRIMARY KEY CLUSTERED 
(
	[coursesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dateTimeBlocks]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dateTimeBlocks](
	[dateTimeBlocksId] [int] IDENTITY(1,1) NOT NULL,
	[dbRoomId] [int] NOT NULL,
	[coursesId] [int] NOT NULL,
	[dateTimeStampStart] [datetime2](7) NOT NULL,
	[dateTimeStampStop] [datetime2](7) NOT NULL,
	[timeZone] [int] NULL,
	[dayLightSavingsActive] [bit] NULL,
 CONSTRAINT [PK_dateTimeBlocks] PRIMARY KEY CLUSTERED 
(
	[dateTimeBlocksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[encrypted_passwords]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encrypted_passwords](
	[pass_id] [int] IDENTITY(1,1) NOT NULL,
	[users_id] [int] NOT NULL,
	[threedes_encrypted_password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_encrypted_passwords] PRIMARY KEY CLUSTERED 
(
	[pass_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[featuresDescriptions]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[featuresDescriptions](
	[featureDescriptionsId] [int] IDENTITY(1,1) NOT NULL,
	[featureName] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_featuresDescriptions] PRIMARY KEY CLUSTERED 
(
	[featureDescriptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[roomFeatures]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roomFeatures](
	[featureId] [int] IDENTITY(1,1) NOT NULL,
	[roomId] [int] NOT NULL,
	[seatCapacity] [int] NOT NULL,
	[projector] [bit] NOT NULL,
	[lectureRaisedFloor] [bit] NOT NULL,
	[computers] [bit] NOT NULL,
	[computersDualMonitors] [bit] NOT NULL,
	[inRoomPrinterColor] [bit] NOT NULL,
	[inRoomPrinterGreyOnly] [bit] NOT NULL,
	[sharedHallPrinterColor] [bit] NOT NULL,
 CONSTRAINT [PK_roomFeatures] PRIMARY KEY CLUSTERED 
(
	[featureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[rooms]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rooms](
	[dbRoomId] [int] IDENTITY(1,1) NOT NULL,
	[roomNum] [nvarchar](50) NOT NULL,
	[roomNickName] [nvarchar](50) NULL,
 CONSTRAINT [PK_rooms] PRIMARY KEY CLUSTERED 
(
	[dbRoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[subjects]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subjects](
	[subjectsId] [int] IDENTITY(1,1) NOT NULL,
	[subjectsNickName] [nvarchar](50) NOT NULL,
	[subjectName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_subjects] PRIMARY KEY CLUSTERED 
(
	[subjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 10/14/2016 4:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[users_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[school_id] [nchar](25) NULL,
	[admin_user] [bit] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[users_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[buildingsRooms]  WITH CHECK ADD  CONSTRAINT [FK_buildingsRooms_buildings] FOREIGN KEY([dbBuildingsId])
REFERENCES [dbo].[buildings] ([dbBuildingsId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[buildingsRooms] CHECK CONSTRAINT [FK_buildingsRooms_buildings]
GO
ALTER TABLE [dbo].[buildingsRooms]  WITH CHECK ADD  CONSTRAINT [FK_buildingsRooms_rooms] FOREIGN KEY([dbRoomId])
REFERENCES [dbo].[rooms] ([dbRoomId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[buildingsRooms] CHECK CONSTRAINT [FK_buildingsRooms_rooms]
GO
ALTER TABLE [dbo].[campusBuildings]  WITH CHECK ADD  CONSTRAINT [FK_campusBuildings_buildings] FOREIGN KEY([dbBuildingsId])
REFERENCES [dbo].[buildings] ([dbBuildingsId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[campusBuildings] CHECK CONSTRAINT [FK_campusBuildings_buildings]
GO
ALTER TABLE [dbo].[campusBuildings]  WITH CHECK ADD  CONSTRAINT [FK_campusBuildings_campus] FOREIGN KEY([campusId])
REFERENCES [dbo].[campus] ([campusId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[campusBuildings] CHECK CONSTRAINT [FK_campusBuildings_campus]
GO
ALTER TABLE [dbo].[courses]  WITH CHECK ADD  CONSTRAINT [FK_courses_subjects] FOREIGN KEY([subjectsId])
REFERENCES [dbo].[subjects] ([subjectsId])
GO
ALTER TABLE [dbo].[courses] CHECK CONSTRAINT [FK_courses_subjects]
GO
ALTER TABLE [dbo].[dateTimeBlocks]  WITH CHECK ADD  CONSTRAINT [FK_dateTimeBlocks_courses] FOREIGN KEY([coursesId])
REFERENCES [dbo].[courses] ([coursesId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[dateTimeBlocks] CHECK CONSTRAINT [FK_dateTimeBlocks_courses]
GO
ALTER TABLE [dbo].[dateTimeBlocks]  WITH CHECK ADD  CONSTRAINT [FK_dateTimeBlocks_rooms] FOREIGN KEY([dbRoomId])
REFERENCES [dbo].[rooms] ([dbRoomId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[dateTimeBlocks] CHECK CONSTRAINT [FK_dateTimeBlocks_rooms]
GO
ALTER TABLE [dbo].[encrypted_passwords]  WITH CHECK ADD  CONSTRAINT [FK_encrypted_passwords_users] FOREIGN KEY([users_id])
REFERENCES [dbo].[users] ([users_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[encrypted_passwords] CHECK CONSTRAINT [FK_encrypted_passwords_users]
GO
ALTER TABLE [dbo].[featuresDescriptions]  WITH CHECK ADD  CONSTRAINT [FK_featuresDescriptions_roomFeatures] FOREIGN KEY([featureDescriptionsId])
REFERENCES [dbo].[roomFeatures] ([featureId])
GO
ALTER TABLE [dbo].[featuresDescriptions] CHECK CONSTRAINT [FK_featuresDescriptions_roomFeatures]
GO
ALTER TABLE [dbo].[roomFeatures]  WITH CHECK ADD  CONSTRAINT [FK_roomFeatures_rooms] FOREIGN KEY([roomId])
REFERENCES [dbo].[rooms] ([dbRoomId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[roomFeatures] CHECK CONSTRAINT [FK_roomFeatures_rooms]
GO
USE [master]
GO
ALTER DATABASE [EduResSch-template1] SET  READ_WRITE 
GO
