USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 24.10.2020 23:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserID] [nchar](20) NULL,
	[Password] [nchar](20) NULL,
	[IP] [nchar](20) NULL,
	[Date] [datetime] NULL
) ON [PRIMARY]
GO
