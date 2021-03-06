USE [ADM_Tool]
GO
/****** Object:  Table [dbo].[tickets]    Script Date: 25.10.2020 23:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tickets](
	[TicketID] [int] IDENTITY(1000,1) NOT NULL,
	[Art] [varchar](50) NOT NULL,
	[Account] [varchar](50) NOT NULL,
	[Char] [varchar](50) NOT NULL,
	[Text] [ntext] NOT NULL,
	[Datum] [datetime] NOT NULL,
	[Replay] [int] NOT NULL,
	[Bearbeiter] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tickets] ADD  CONSTRAINT [DF_tickets_Replay]  DEFAULT ((0)) FOR [Replay]
GO
