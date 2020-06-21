USE [Library]
GO

/****** Object:  Table [dbo].[IRBook]    Script Date: 6/20/2020 10:38:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[IRBook](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[std_enroll] [varchar](250) NOT NULL,
	[std_name] [varchar](250) NOT NULL,
	[std_dep] [varchar](250) NOT NULL,
	[std_sem] [varchar](250) NOT NULL,
	[std_contact] [bigint] NOT NULL,
	[std_email] [varchar](250) NOT NULL,
	[book_name] [varchar](250) NOT NULL,
	[book_issue_date] [varchar](250) NOT NULL,
	[book_return_date] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


