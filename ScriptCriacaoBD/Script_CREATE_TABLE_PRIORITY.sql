USE [academycoding2]
GO

/****** Object:  Table [dbo].[PRIORITY]    Script Date: 11/06/2021 17:38:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PRIORITY](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Days] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

use academycoding2

insert into PRIORITY (Name, Days) values ('Baixa', 8)
go
insert into PRIORITY (Name, Days) values ('Normal', 6)
go
insert into PRIORITY (Name, Days) values ('Grave', 2)
go 
insert into PRIORITY (Name, Days) values ('Critica', 1)

