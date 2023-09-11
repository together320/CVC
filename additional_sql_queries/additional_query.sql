USE [CVC]
GO

IF COL_LENGTH ('dbo.Views', 'ListDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add ListDisplayId INTEGER,
	CONSTRAINT FK_Views_ListDisplayId FOREIGN KEY (ListDisplayId) REFERENCES ListDisplay(ListDisplayId);
END

IF COL_LENGTH ('dbo.ListDisplay', 'ListDisplayName') IS NULL
BEGIN
	ALTER TABLE ListDisplay
	ADD ListDisplayName varchar(50)
END

IF NOT EXISTS
   (  SELECT [name]
      FROM sys.tables
      WHERE [name] = 'FormDisplay'
   )
BEGIN
	CREATE TABLE [dbo].[FormDisplay](
		[FormDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[FormDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
		[IsCheckbox] [bit] NULL,
		[Font] [varchar](50) NULL,
		[FontColorSelected] [varchar](50) NULL,
		[FontColorUnselected] [varchar](50) NULL,
		[Activation] [int] NULL,
		[Alignment] [int] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
		[IsCollapsible] [bit] NULL
	)
END

-- Add FormDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'FormDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add FormDisplayId INTEGER,
	CONSTRAINT FK_Views_FormDisplayId FOREIGN KEY (FormDisplayId) REFERENCES FormDisplay(FormDisplayId);
END

-- Drop DisplayObjectTypes table if it exists
DROP TABLE IF EXISTS [dbo].[DisplayObjectTypes]
GO

-- Create ButtonDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ButtonDisplay' and xtype='U')
   /*(  SELECT [name]
      FROM sys.tables
      WHERE [name] = '[ButtonDisplay]'
   )*/
BEGIN
	CREATE TABLE [dbo].[ButtonDisplay] (
		[ButtonDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[ButtonDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
		[Font] [varchar](50) NULL,
		[FontColorSelected] [varchar](50) NULL,
		[FontColorUnselected] [varchar](50) NULL,
		[Activation] [int] NULL,
		[Alignment] [int] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
		[IsCollapsible] [bit] NULL
	)
END

-- Add ButtonDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'ButtonDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add ButtonDisplayId INTEGER,
	CONSTRAINT FK_Views_ButtonDisplayId FOREIGN KEY (ButtonDisplayId) REFERENCES ButtonDisplay(ButtonDisplayId);
END

-- Create RealtimeParameterDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='RealtimeParameterDisplay' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[RealtimeParameterDisplay] (
		[RealtimeParameterDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[RealtimeParameterDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
		[Font] [varchar](50) NULL,
		[FontColor] [varchar](50) NULL,
		[Alignment] [int] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
		[IsCollapsible] [bit] NULL
	)
END

-- Add RealtimeParameterDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'RealtimeParameterDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add RealtimeParameterDisplayId INTEGER,
	CONSTRAINT FK_Views_RealtimeParameterDisplayId FOREIGN KEY (RealtimeParameterDisplayId) REFERENCES RealtimeParameterDisplay(RealtimeParameterDisplayId);
END

-- Create LineChartDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='LineChartDisplay' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[LineChartDisplay] (
		[LineChartDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[LineChartDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
		[Font] [varchar](50) NULL,
		[FontColor] [varchar](50) NULL,
		[Alignment] [int] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
		[IsCollapsible] [bit] NULL
	)
END

-- Add LineChartDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'LineChartDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add LineChartDisplayId INTEGER,
	CONSTRAINT FK_Views_LineChartDisplayId FOREIGN KEY (LineChartDisplayId) REFERENCES LineChartDisplay(LineChartDisplayId);
END

-- Create PieChartDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='PieChartDisplay' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[PieChartDisplay] (
		[PieChartDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[PieChartDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
		[Font] [varchar](50) NULL,
		[FontColor] [varchar](50) NULL,
		[IsLegends] [bit] NULL,
        [LegendFontSize] [int] NULL,
        [IsShowValuesAsPercentage] [bit] NULL,
        [isShowTotal] [bit] NULL,
        [Alignment] [int] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
		[IsRealtime] [bit] NULL
	)
END

-- Add PieChartDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'PieChartDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add PieChartDisplayId INTEGER,
	CONSTRAINT FK_Views_PieChartDisplayId FOREIGN KEY (PieChartDisplayId) REFERENCES PieChartDisplay(PieChartDisplayId);
END

IF COL_LENGTH ('dbo.LineChartDisplay', 'IsLegends') IS NULL
BEGIN
	ALTER TABLE LineChartDisplay
	Add IsLegends bit NULL
END

IF COL_LENGTH ('dbo.LineChartDisplay', 'IsGridlines') IS NULL
BEGIN
	ALTER TABLE LineChartDisplay
	Add IsGridlines bit NULL
END

IF COL_LENGTH ('dbo.LineChartDisplay', 'GridlineColor') IS NULL
BEGIN
	ALTER TABLE LineChartDisplay
	Add GridlineColor VARCHAR (50) NULL
END

IF COL_LENGTH ('dbo.LineChartDisplay', 'IsRealtime') IS NULL
BEGIN
	ALTER TABLE LineChartDisplay
	Add IsRealtime bit NULL
END

IF COL_LENGTH ('dbo.LineChartDisplay', 'AxisColor') IS NULL
BEGIN
	ALTER TABLE LineChartDisplay
	Add AxisColor VARCHAR (50) NULL
END

-- Create TreeDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TreeDisplay' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[TreeDisplay] (
		[TreeDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[TreeDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
		[Font] [varchar](50) NULL,
		[FontColor] [varchar](50) NULL,
		[IsFullRowSelect] [bit] NULL,
        [LineColor] [varchar](50) NULL,
        [DefaultView] [int] NULL,
        [Alignment] [int] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
		[IsRealtime] [bit] NULL
	)
END

-- Add TreeDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'TreeDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add TreeDisplayId INTEGER,
	CONSTRAINT FK_Views_TreeDisplayId FOREIGN KEY (TreeDisplayId) REFERENCES TreeDisplay(TreeDisplayId);
END

-- Create AttachmentDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AttachmentDisplay' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[AttachmentDisplay] (
		[AttachmentDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[AttachmentDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
        [IsCheckbox] [bit] NULL,
		[Font] [varchar](50) NULL,
		[FontColorSelected] [varchar](50) NULL,
		[FontColorUnselected] [varchar](50) NULL,

        [Activation] [int] NULL,
        [IsOpenInNewWindow] [bit] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
        [Alignment] [int] NULL,
		[IsFolderBrowse] [bit] NULL,
        [IsAddAttachments] [bit] NULL,
        [IsCollapsible] [bit] NULL
	)
END

-- Add AttachmentDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'AttachmentDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add AttachmentDisplayId INTEGER,
	CONSTRAINT FK_Views_AttachmentDisplayId FOREIGN KEY (AttachmentDisplayId) REFERENCES AttachmentDisplay(AttachmentDisplayId);
END

-- Create AlarmDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AlarmDisplay' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[AlarmDisplay] (
		[AlarmDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[AlarmDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
        [IsCheckbox] [bit] NULL,
		[Font] [varchar](50) NULL,
		[FontColorSelected] [varchar](50) NULL,
		[FontColorUnselected] [varchar](50) NULL,
        [CautionColor] [varchar](50) NULL,
        [WarningColor] [varchar](50) NULL,
        [EmergencyColor] [varchar](50) NULL,

        [Activation] [int] NULL,
        [Appearance] [int] NULL,
        [IsOpenInNewWindow] [bit] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
        [Alignment] [int] NULL,
		[IsFolderBrowse] [bit] NULL,
        [IsAddAttachments] [bit] NULL,
        [IsCollapsible] [bit] NULL
	)
END

-- Add AlarmDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'AlarmDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add AlarmDisplayId INTEGER,
	CONSTRAINT FK_Views_AlarmDisplayId FOREIGN KEY (AlarmDisplayId) REFERENCES AlarmDisplay(AlarmDisplayId);
END

-- Create NotificationDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='NotificationDisplay' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[NotificationDisplay] (
		[NotificationDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[NotificationDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
		[Font] [varchar](50) NULL,
		[FontColorSelected] [varchar](50) NULL,
		[FontColorUnselected] [varchar](50) NULL,

        [Activation] [int] NULL,
        [IsOpenInNewWindow] [bit] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
        [Alignment] [int] NULL,
		[IsFolderBrowse] [bit] NULL,
        [IsAddAttachments] [bit] NULL,
        [IsCollapsible] [bit] NULL
	)
END

-- Add NotificationDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'NotificationDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add NotificationDisplayId INTEGER,
	CONSTRAINT FK_Views_NotificationDisplayId FOREIGN KEY (NotificationDisplayId) REFERENCES NotificationDisplay(NotificationDisplayId);
END

-- Create ContainerDisplay table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ContainerDisplay' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[ContainerDisplay] (
		[ContainerDisplayId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[ContainerDisplayName] [varchar](50) NULL,
		[BackgroundColor] [varchar](50) NULL,
		[BorderStyle] [int] NULL,
		[Font] [varchar](50) NULL,
		[FontColorSelected] [varchar](50) NULL,
		[FontColorUnselected] [varchar](50) NULL,

        [Activation] [int] NULL,
        [IsOpenInNewWindow] [bit] NULL,
		[IsTooltip] [bit] NULL,
		[IsHorizontalScrollBar] [bit] NULL,
		[IsVerticalScrollBar] [bit] NULL,
        [Alignment] [int] NULL,
		[IsCollapsible] [bit] NULL
	)
END

-- Add ContainerDisplayId as a foreign key in Views table
IF COL_LENGTH ('dbo.Views', 'ContainerDisplayId') IS NULL
BEGIN
	ALTER TABLE Views
	Add ContainerDisplayId INTEGER,
	CONSTRAINT FK_Views_ContainerDisplayId FOREIGN KEY (ContainerDisplayId) REFERENCES ContainerDisplay(ContainerDisplayId);
END

-- Create PrimaryRelationship table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='PrimaryRelationship' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[PrimaryRelationship] (
		[PrimaryRelationshipId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[RelationshipName] [varchar](50) Null,
		[PrimaryBE] [int] NOT NULL,
		[Description] [varchar](256) NULL,
		[Status] [int] NOT NULL,
		[CreatedBy] [int] NULL,
		[CreatedDate] [datetime] NULL,
		[UpdatedBy] [int] NULL,
		[UpdatedDate] [datetime] NULL,
		CONSTRAINT FK_PrimaryRelationship_PrimaryBE FOREIGN KEY (PrimaryBE) REFERENCES Machine(MachineId),
		CONSTRAINT FK_PrimaryRelationship_Status FOREIGN KEY (Status) REFERENCES Status(StatusId)
	)
END

-- Create SecondaryRelationship table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SecondaryRelationship' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[SecondaryRelationship] (
		[SecondaryRelationshipId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[PrimaryRelationshipId] [int] NOT NULL,
		[SecondaryBE] [int] NOT NULL,
		[Description] [varchar](256) NULL,
		[CreatedBy] [int] NULL,
		[CreatedDate] [datetime] NULL,
		[UpdatedBy] [int] NULL,
		[UpdatedDate] [datetime] NULL,
		CONSTRAINT FK_SecondaryRelationship_PrimaryRelationshipId FOREIGN KEY (PrimaryRelationshipId) REFERENCES PrimaryRelationship(PrimaryRelationshipId),
		CONSTRAINT FK_SecondaryRelationship_SecondaryBE FOREIGN KEY (SecondaryBE) REFERENCES Machine(MachineId)
	)
END

-- Add PrimaryEF as a foreign key in PrimaryRelationship table
IF COL_LENGTH ('dbo.PrimaryRelationship', 'PrimaryEF') IS NULL
BEGIN
	ALTER TABLE PrimaryRelationship
	Add PrimaryEF INTEGER,
	CONSTRAINT FK_PrimaryRelationship_PrimaryEF FOREIGN KEY (PrimaryEF) REFERENCES MachineParameter(MachineParameterId);
END

-- Add SecondaryEF as a foreign key in SecondaryRelationship table
IF COL_LENGTH ('dbo.SecondaryRelationship', 'SecondaryEF') IS NULL
BEGIN
	ALTER TABLE SecondaryRelationship
	Add SecondaryEF INTEGER,
	CONSTRAINT FK_SecondaryRelationship_SecondaryEF FOREIGN KEY (SecondaryEF) REFERENCES MachineParameter(MachineParameterId);
END

-- Create ScreenViews table if it does not exist
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ScreenViews' and xtype='U')
BEGIN
	CREATE TABLE [dbo].[ScreenViews] (
		[ScreenViewId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[ScreenViewName] [varchar](50) NOT NULL,
		[PrimaryRelationshipId] [int] NOT NULL,
		[IsNoBER] [bit] NULL,
		[StatusId] [int] NOT NULL,
		[CreatedBy] [int] NULL,
		[CreatedDate] [datetime] NULL,
		[UpdatedBy] [int] NULL,
		[UpdatedDate] [datetime] NULL,
		CONSTRAINT FK_ScreenViews_PrimaryRelationshipId FOREIGN KEY (PrimaryRelationshipId) REFERENCES PrimaryRelationship(PrimaryRelationshipId),
		CONSTRAINT FK_ScreenViews_StatusId FOREIGN KEY (StatusId) REFERENCES Status(StatusId)
	)
END