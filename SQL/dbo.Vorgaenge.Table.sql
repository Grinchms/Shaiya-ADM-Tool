USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Vorgaenge]    Script Date: 25.10.2020 23:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vorgaenge](
	[GV] [int] IDENTITY(1000,1) NOT NULL,
	[UserID] [nchar](20) NULL,
	[Date] [datetime] NULL,
	[Text] [ntext] NULL,
	[Status] [nchar](20) NULL,
	[Zugewiesenan] [nchar](20) NULL,
	[Thema] [nchar](20) NULL,
	[Art] [nchar](20) NULL,
	[Type] [nchar](30) NULL,
	[Erstelltdurch] [nchar](20) NULL,
	[Letzterbearbeiter] [nchar](20) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
