USE [LSI]
GO

/****** Object:  Table [dbo].[Export]    Script Date: 17.04.2020 17:29:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('dbo.Export', 'U') IS NOT NULL 
  DROP TABLE dbo.Export; 


CREATE TABLE [dbo].[Export](
	[ExportId] [int] IDENTITY(1,1) NOT NULL,
	[ExportName] [nvarchar](150) NOT NULL,
	[ExportDateTime] [datetime] NOT NULL,
	[ExportUserName] [nvarchar](256) NOT NULL,
	[ExportLocalName] [nvarchar](350) NOT NULL,
 CONSTRAINT [PK_Exports] PRIMARY KEY CLUSTERED 
(
	[ExportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Export]
           ([ExportName]
           ,[ExportDateTime]
           ,[ExportUserName]
           ,[ExportLocalName])
     VALUES
           ('Export 1'
           ,'2016-09-13 11:00:00'
           ,'AnnaK'
           ,'Test Local')
GO
INSERT INTO [dbo].[Export]
           ([ExportName]
           ,[ExportDateTime]
           ,[ExportUserName]
           ,[ExportLocalName])
     VALUES
           ('Export 2'
           ,'2014-09-13 12:00:00'
           ,'AnnaK'
           ,'2 local')
GO
INSERT INTO [dbo].[Export]
           ([ExportName]
           ,[ExportDateTime]
           ,[ExportUserName]
           ,[ExportLocalName])
     VALUES
           ('Export 3'
           ,'2020-01-13 01:00:00'
           ,'JarekP'
           ,'3 local')
GO
INSERT INTO [dbo].[Export]
           ([ExportName]
           ,[ExportDateTime]
           ,[ExportUserName]
           ,[ExportLocalName])
     VALUES
           ('Export 4'
           ,'2011-05-13 04:00:00'
           ,'testowy'
           ,'4 local')
GO
INSERT INTO [dbo].[Export]
           ([ExportName]
           ,[ExportDateTime]
           ,[ExportUserName]
           ,[ExportLocalName])
     VALUES
           ('Export 5'
           ,'2011-05-13 11:00:00'
           ,'JarekP'
           ,'7 local')
GO








