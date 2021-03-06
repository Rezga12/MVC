USE [RMS]
GO
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([Id], [Name], [type], [logo_url], [avg_rating], [pricing_pct], [register_date]) VALUES (0, N'Goodies', N'Veggies', N'https://i.vimeocdn.com/portrait/1274237_300x300', NULL, 30, NULL)
INSERT [dbo].[Companies] ([Id], [Name], [type], [logo_url], [avg_rating], [pricing_pct], [register_date]) VALUES (1, N'rezga', N'asdasd', N'https://i.vimeocdn.com/portrait/1274237_300x300', NULL, 123, NULL)
SET IDENTITY_INSERT [dbo].[Companies] OFF
SET IDENTITY_INSERT [dbo].[GeneralProducts] ON 

INSERT [dbo].[GeneralProducts] ([Id], [Name]) VALUES (3, N'Something hot')
INSERT [dbo].[GeneralProducts] ([Id], [Name]) VALUES (4, N'Cheese')
INSERT [dbo].[GeneralProducts] ([Id], [Name]) VALUES (5, N'Bread')
INSERT [dbo].[GeneralProducts] ([Id], [Name]) VALUES (1002, N'Eggs')
INSERT [dbo].[GeneralProducts] ([Id], [Name]) VALUES (1006, N'Butter')
SET IDENTITY_INSERT [dbo].[GeneralProducts] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([Id], [Price], [category], [cook_duration], [global_code], [company_id]) VALUES (1002, 50, N'1', 5, 3, 0)
INSERT [dbo].[Menu] ([Id], [Price], [category], [cook_duration], [global_code], [company_id]) VALUES (1003, 60, N'2', 5, 4, 0)
INSERT [dbo].[Menu] ([Id], [Price], [category], [cook_duration], [global_code], [company_id]) VALUES (1004, 12, N'3', 4, 5, 0)
INSERT [dbo].[Menu] ([Id], [Price], [category], [cook_duration], [global_code], [company_id]) VALUES (2002, 12, N'hot food', 1, 3, 1)
INSERT [dbo].[Menu] ([Id], [Price], [category], [cook_duration], [global_code], [company_id]) VALUES (2003, 14, N'cold food', 2, 4, 1)
INSERT [dbo].[Menu] ([Id], [Price], [category], [cook_duration], [global_code], [company_id]) VALUES (2004, 16, N'cold food', 3, 5, 1)
INSERT [dbo].[Menu] ([Id], [Price], [category], [cook_duration], [global_code], [company_id]) VALUES (2005, 67, N'Eggs', 4, 1002, 1)
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[OrderMeals] ON 

INSERT [dbo].[OrderMeals] ([Id], [product_id], [order_id], [quantity]) VALUES (14, 1002, 4, 3)
INSERT [dbo].[OrderMeals] ([Id], [product_id], [order_id], [quantity]) VALUES (15, 1003, 4, 1)
SET IDENTITY_INSERT [dbo].[OrderMeals] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [company_id], [total_amount], [Date], [Rating]) VALUES (3, 0, 222, CAST(N'2018-10-15T22:54:10.723' AS DateTime), 0)
INSERT [dbo].[Orders] ([Id], [company_id], [total_amount], [Date], [Rating]) VALUES (4, 0, 210, CAST(N'2018-10-15T22:54:52.710' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
