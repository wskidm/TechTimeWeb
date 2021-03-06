USE [TechTime]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 9/2/2018 18:22:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[EventId] [int] IDENTITY(1,1) NOT NULL,
	[EventTypeId] [int] NOT NULL,
	[EventDateTime] [datetime2](7) NOT NULL,
	[Note] [nvarchar](max) NULL,
	[EmployeeId] [int] NOT NULL,
	[JobId] [int] NOT NULL,
	[JobRevision] [int] NOT NULL,
	[LastUpdateDateTime] [datetime2](7) NOT NULL,
	[LastEditedId] [int] NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventTypes]    Script Date: 9/2/2018 18:22:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventTypes](
	[EventTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[TimeTypeId] [int] NOT NULL,
 CONSTRAINT [PK_EventTypes] PRIMARY KEY CLUSTERED 
(
	[EventTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeTypes]    Script Date: 9/2/2018 18:22:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeTypes](
	[TimeTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[TrackTypeId] [int] NOT NULL,
 CONSTRAINT [PK_TimeTypes] PRIMARY KEY CLUSTERED 
(
	[TimeTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrackType]    Script Date: 9/2/2018 18:22:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrackType](
	[TrackTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_TrackType] PRIMARY KEY CLUSTERED 
(
	[TrackTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EventTypes] ON 
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (1, N'Begin Job', N'Begin Job', 1)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (2, N'Rest Break', N'Rest Break', 6)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (3, N'Shop Maintenance', N'Shop Maintenance', 7)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (4, N'Authorization Wait', N'Authorization Wait', 8)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (5, N'Parts Wait', N'Parts Wait', 9)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (6, N'Vehicle Wait', N'Vehicle Wait', 10)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (7, N'Lunch Break', N'Lunch Break', 11)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (8, N'Extended Break', N'Extended Break', 12)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (9, N'PTO', N'Paid Time Off', 13)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (10, N'Holiday', N'Holiday', 14)
GO
INSERT [dbo].[EventTypes] ([EventTypeId], [Name], [Description], [TimeTypeId]) VALUES (11, N'End Day', N'End Day', 16)
GO
SET IDENTITY_INSERT [dbo].[EventTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[TimeTypes] ON 
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (1, N'Normal', N'Normal', 1)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (2, N'Courtesy', N'Courtesy', 1)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (3, N'PartsWarranty', N'Parts Warranty', 1)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (4, N'TechWarranty', N'Tech Warranty', 1)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (5, N'NoFaultWarranty', N'No Fault Warranty', 1)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (6, N'RestBreak', N'Rest Break', 2)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (7, N'ShopMaintenance', N'Shop Maintenance', 2)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (8, N'WaitingForAuth', N'Waiting for Authorization', 2)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (9, N'WaitingForParts', N'Waiting for Parts', 2)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (10, N'WaitingForVehicle', N'Waiting for Vehicle', 2)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (11, N'LunchBreak', N'Lunch Break', 3)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (12, N'ExtendedBreak', N'Extended Break', 3)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (13, N'PTO', N'Personal Time Off', 3)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (14, N'Holiday', N'Holiday', 3)
GO
INSERT [dbo].[TimeTypes] ([TimeTypeId], [Name], [Description], [TrackTypeId]) VALUES (16, N'EndDay', N'EndDay', 3)
GO
SET IDENTITY_INSERT [dbo].[TimeTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[TrackType] ON 
GO
INSERT [dbo].[TrackType] ([TrackTypeId], [Name], [Description]) VALUES (1, N'Actual', N'Actual')
GO
INSERT [dbo].[TrackType] ([TrackTypeId], [Name], [Description]) VALUES (2, N'OnClock', N'Idle - On the Clock')
GO
INSERT [dbo].[TrackType] ([TrackTypeId], [Name], [Description]) VALUES (3, N'OffClock', N'Idle - Off the Clock')
GO
SET IDENTITY_INSERT [dbo].[TrackType] OFF
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_EventTypes_EventTypeId] FOREIGN KEY([EventTypeId])
REFERENCES [dbo].[EventTypes] ([EventTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_EventTypes_EventTypeId]
GO
ALTER TABLE [dbo].[EventTypes]  WITH CHECK ADD  CONSTRAINT [FK_EventTypes_TimeTypes_TimeTypeId] FOREIGN KEY([TimeTypeId])
REFERENCES [dbo].[TimeTypes] ([TimeTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventTypes] CHECK CONSTRAINT [FK_EventTypes_TimeTypes_TimeTypeId]
GO
ALTER TABLE [dbo].[TimeTypes]  WITH CHECK ADD  CONSTRAINT [FK_TimeTypes_TrackType_TrackTypeId] FOREIGN KEY([TrackTypeId])
REFERENCES [dbo].[TrackType] ([TrackTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TimeTypes] CHECK CONSTRAINT [FK_TimeTypes_TrackType_TrackTypeId]
GO
