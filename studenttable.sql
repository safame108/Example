USE [StudentPortal]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 6/6/2020 8:52:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[Reg_no] [varchar](5) NOT NULL,
	[FirstName] [varchar](10) NULL,
	[LastName] [varchar](10) NULL,
	[Depart] [varchar](4) NULL,
	[Semester] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Reg_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

