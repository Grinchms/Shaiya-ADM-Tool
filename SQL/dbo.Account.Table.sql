USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 24.10.2020 23:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Benutzer] [varchar](30) NOT NULL,
	[Passwort] [varchar](30) NOT NULL,
	[Rechte] [int] NULL
) ON [PRIMARY]
GO
