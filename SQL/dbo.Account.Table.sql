USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 25.10.2020 23:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Benutzer] [varchar](30) NOT NULL,
	[Passwort] [varchar](30) NOT NULL,
	[Rechte] [int] NOT NULL
) ON [PRIMARY]
GO
