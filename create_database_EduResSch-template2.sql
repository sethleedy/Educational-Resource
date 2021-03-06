/****** This is nearly a stright copy from SQL Studio export. I removed the some lines concerning the creation of the database, the contraints and FILEPATH. Then it works fine. ******/

USE [master]
GO
/****** Object:  Database [EduResSch-template2]    Script Date: 10/14/2016 8:06:10 PM ******/
CREATE DATABASE [EduResSch-template2]
GO
ALTER DATABASE [EduResSch-template2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EduResSch-template2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EduResSch-template2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EduResSch-template2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EduResSch-template2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EduResSch-template2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EduResSch-template2] SET ARITHABORT OFF 
GO
ALTER DATABASE [EduResSch-template2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EduResSch-template2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EduResSch-template2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EduResSch-template2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EduResSch-template2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EduResSch-template2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EduResSch-template2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EduResSch-template2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EduResSch-template2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EduResSch-template2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EduResSch-template2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EduResSch-template2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EduResSch-template2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EduResSch-template2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EduResSch-template2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EduResSch-template2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EduResSch-template2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EduResSch-template2] SET RECOVERY FULL 
GO
ALTER DATABASE [EduResSch-template2] SET  MULTI_USER 
GO
ALTER DATABASE [EduResSch-template2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EduResSch-template2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EduResSch-template2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EduResSch-template2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EduResSch-template2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EduResSch-template2', N'ON'
GO
USE [EduResSch-template2]
GO
/****** Object:  Table [dbo].[encrypted_passwords]    Script Date: 10/14/2016 8:06:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encrypted_passwords](
	[pass_id] [int] NOT NULL,
	[users_id] [int] NOT NULL,
	[threedes_encrypted_password] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 10/14/2016 8:06:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[users_id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[school_id] [nchar](25) NULL,
	[admin_user] [bit] NOT NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [EduResSch-template2] SET  READ_WRITE 
GO
