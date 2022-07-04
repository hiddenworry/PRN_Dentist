USE [master]
GO
CREATE DATABASE [DBS]
GO
USE [DBS]
GO

CREATE TABLE [dbo].[Account](
	[id] [int] NOT NULL,
	[username] [nvarchar](30) NOT NULL,
	[password] [nvarchar](30) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[gender] [bit] NOT NULL,
	[role] [decimal](1, 0) NOT NULL,
	[status] [decimal](1, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 7/4/2022 11:05:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[id] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
	[doctor_id] [int] NOT NULL,
	[time] [date] NOT NULL,
	[working_hour] [nvarchar](15) NOT NULL,
	[description] [nvarchar](max) NULL,
	[status] [decimal](1, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment_Service]    Script Date: 7/4/2022 11:05:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Service](
	[appointment_id] [int] NOT NULL,
	[service_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC,
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/4/2022 11:05:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] NOT NULL,
	[phone] [nvarchar](10) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[DOB] [date] NOT NULL,
	[gender] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 7/4/2022 11:05:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[id] [int] NOT NULL,
	[service_type_id] [int] NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[description] [nvarchar](max) NULL,
	[estimated_time] [float] NOT NULL,
	[status] [decimal](1, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service_Type]    Script Date: 7/4/2022 11:05:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service_Type](
	[id] [int] NOT NULL,
	[name] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Account] ([id])
GO
ALTER TABLE [dbo].[Appointment_Service]  WITH CHECK ADD FOREIGN KEY([appointment_id])
REFERENCES [dbo].[Appointment] ([id])
GO
ALTER TABLE [dbo].[Appointment_Service]  WITH CHECK ADD FOREIGN KEY([service_id])
REFERENCES [dbo].[Service] ([id])
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD FOREIGN KEY([service_type_id])
REFERENCES [dbo].[Service_Type] ([id])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD CHECK  (([role]>(0)))
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD CHECK  (([status]>(0)))
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD CHECK  (([status]>(0)))
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD CHECK  (([status]>(0)))
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD CHECK  (([estimated_time]>(0)))
GO
ALTER TABLE [dbo].[Service_Type]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
USE [master]
GO
ALTER DATABASE [DBS] SET  READ_WRITE 
GO
