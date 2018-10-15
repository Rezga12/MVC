USE [RMS]
GO

/****** Object:  Table [dbo].[Comments]    Script Date: 10/15/2018 11:32:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Comments](
	[Id] [int] NOT NULL,
	[text] [text] NOT NULL,
	[order_id] [int] NULL,
	[company_id] [int] NULL,
	[type_id] [int] NULL,
	[rating] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


