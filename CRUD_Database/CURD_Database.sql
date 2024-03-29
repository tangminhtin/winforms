USE [CRUD_Database]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/10/2020 12:06:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Name], [Email], [Password], [Country]) VALUES (1, N'Tang Minh Tin', N'minhtintang@gmail.com', N'123', N'Viet Nam')
INSERT [dbo].[Users] ([ID], [Name], [Email], [Password], [Country]) VALUES (2, N'Huynh Thi Nhien', N'huynhthinhien23@gmail.com', N'123a', N'Viet Name')
INSERT [dbo].[Users] ([ID], [Name], [Email], [Password], [Country]) VALUES (4, N'kiti', N'kiti@gmail.com', N'123', N'Viet Nam')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
