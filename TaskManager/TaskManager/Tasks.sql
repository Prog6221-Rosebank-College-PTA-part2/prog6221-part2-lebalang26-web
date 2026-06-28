CREATE TABLE [dbo].[Tasks]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Title] VARCHAR(100) NOT NULL, 
    [Description] VARCHAR(200) NOT NULL, 
    [ReminderDate] DATETIME NULL, 
    [Status] VARCHAR(50) NOT NULL
)
