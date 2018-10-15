USE [RMS]
GO

/****** Object:  Table [dbo].[Companies]    Script Date: 10/15/2018 11:34:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Companies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](40) NOT NULL,
	[type] [varchar](30) NOT NULL,
	[logo_url] [varchar](1000) NULL,
	[avg_rating] [int] NULL,
	[pricing_pct] [int] NULL,
	[register_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Companies] ADD  DEFAULT ((0)) FOR [avg_rating]
GO

ALTER TABLE [dbo].[Companies] ADD  CONSTRAINT [sys_date]  DEFAULT (getdate()) FOR [register_date]
GO


