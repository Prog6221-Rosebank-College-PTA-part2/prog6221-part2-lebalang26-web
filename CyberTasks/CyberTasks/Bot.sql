CREATE TABLE [dbo].[Bot]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Tilte] NVARCHAR(100) NULL, 
    [Decsription] NVARCHAR(500) NULL, 
    [ReminderDate] DATETIME NULL, 
    [Status ] NVARCHAR(20) NOT NULL DEFAULT 'Pending'
)
