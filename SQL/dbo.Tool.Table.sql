USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Tool]    Script Date: 24.10.2020 23:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tool](
	[UserID] [nchar](20) NULL,
	[Tool] [nchar](20) NULL,
	[Date] [datetime] NULL
) ON [PRIMARY]
GO
