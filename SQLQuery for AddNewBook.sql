USE [Library]
GO

/****** Object:  Table [dbo].[AddNewBook]    Script Date: 6/20/2020 10:38:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[AddNewBook](
	[bid] [int] IDENTITY(1,1) NOT NULL,
	[bName] [varchar](250) NOT NULL,
	[bAuthor] [varchar](250) NOT NULL,
	[bpub1] [varchar](250) NOT NULL,
	[bPDate] [varchar](250) NOT NULL,
	[bPrice] [bigint] NOT NULL,
	[bQuan] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


