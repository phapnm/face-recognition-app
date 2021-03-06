USE [FaceRec_2]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/16/2019 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[empcode] [varchar](20) NULL,
	[empname] [nvarchar](50) NULL,
	[checkin] [datetime] NULL,
	[checkout] [datetime] NULL,
	[imagee] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[train]    Script Date: 10/16/2019 12:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[train](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[empcode] [varchar](20) NULL,
	[empname] [nvarchar](50) NULL,
	[date] [datetime] NULL,
	[imagee] [varbinary](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
