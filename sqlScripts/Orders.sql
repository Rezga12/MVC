USE [RMS]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 10/15/2018 11:35:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NOT NULL,
	[total_amount] [int] NOT NULL,
	[Date] [datetime] NULL,
	[Rating] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Orders] ADD  DEFAULT (sysdatetime()) FOR [Date]
GO


