CREATE TABLE [dbo].[TblThread] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TblThread] PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[TblPosts] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Thread_Post_Id] INT            NULL,
    [Title]          NVARCHAR (450) NOT NULL,
    [Content]        NVARCHAR (MAX) NULL,
    [Category]       INT            NULL,
    CONSTRAINT [PK_TblPosts] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Thread_Post_Id]) REFERENCES [dbo].[TblThread] ([Id]),
    UNIQUE NONCLUSTERED ([Title] ASC)
);

CREATE TABLE [dbo].[tblUser] (
    [Id]       INT            NOT NULL,
    [Username] NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    [Email]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED ([Id] ASC)
);

