USE [Library]
GO

/****** Object:  Table [dbo].[NewStudent]    Script Date: 6/20/2020 10:39:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[NewStudent](
	[stuid] [int] IDENTITY(1,1) NOT NULL,
	[sname] [varchar](250) NOT NULL,
	[enroll] [varchar](250) NOT NULL,
	[dep] [varchar](250) NOT NULL,
	[sem] [varchar](250) NOT NULL,
	[contact] [bigint] NOT NULL,
	[email] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[stuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


