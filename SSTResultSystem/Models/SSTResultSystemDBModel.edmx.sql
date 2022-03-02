
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/02/2022 22:23:22
-- Generated from EDMX file: C:\Users\Jahir-Spectre\source\repos\SSTResultSystem\SSTResultSystem\Models\SSTResultSystemDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SSTResultSystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__result11__studen__29572725]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[result11] DROP CONSTRAINT [FK__result11__studen__29572725];
GO
IF OBJECT_ID(N'[dbo].[FK__result12__studen__2C3393D0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[result12] DROP CONSTRAINT [FK__result12__studen__2C3393D0];
GO
IF OBJECT_ID(N'[dbo].[FK__result21__studen__2F10007B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[result21] DROP CONSTRAINT [FK__result21__studen__2F10007B];
GO
IF OBJECT_ID(N'[dbo].[FK__result22__studen__31EC6D26]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[result22] DROP CONSTRAINT [FK__result22__studen__31EC6D26];
GO
IF OBJECT_ID(N'[dbo].[FK__result31__studen__34C8D9D1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[result31] DROP CONSTRAINT [FK__result31__studen__34C8D9D1];
GO
IF OBJECT_ID(N'[dbo].[FK__result32__studen__37A5467C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[result32] DROP CONSTRAINT [FK__result32__studen__37A5467C];
GO
IF OBJECT_ID(N'[dbo].[FK__result41__studen__3A81B327]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[result41] DROP CONSTRAINT [FK__result41__studen__3A81B327];
GO
IF OBJECT_ID(N'[dbo].[FK__result42__studen__3D5E1FD2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[result42] DROP CONSTRAINT [FK__result42__studen__3D5E1FD2];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[courses];
GO
IF OBJECT_ID(N'[dbo].[result11]', 'U') IS NOT NULL
    DROP TABLE [dbo].[result11];
GO
IF OBJECT_ID(N'[dbo].[result12]', 'U') IS NOT NULL
    DROP TABLE [dbo].[result12];
GO
IF OBJECT_ID(N'[dbo].[result21]', 'U') IS NOT NULL
    DROP TABLE [dbo].[result21];
GO
IF OBJECT_ID(N'[dbo].[result22]', 'U') IS NOT NULL
    DROP TABLE [dbo].[result22];
GO
IF OBJECT_ID(N'[dbo].[result31]', 'U') IS NOT NULL
    DROP TABLE [dbo].[result31];
GO
IF OBJECT_ID(N'[dbo].[result32]', 'U') IS NOT NULL
    DROP TABLE [dbo].[result32];
GO
IF OBJECT_ID(N'[dbo].[result41]', 'U') IS NOT NULL
    DROP TABLE [dbo].[result41];
GO
IF OBJECT_ID(N'[dbo].[result42]', 'U') IS NOT NULL
    DROP TABLE [dbo].[result42];
GO
IF OBJECT_ID(N'[dbo].[students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[students];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'courses'
CREATE TABLE [dbo].[courses] (
    [code] varchar(7)  NOT NULL,
    [title] varchar(255)  NULL,
    [credit] tinyint  NULL
);
GO

-- Creating table 'result11'
CREATE TABLE [dbo].[result11] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NULL,
    [examterm] varchar(3)  NULL,
    [eng1131] float  NULL,
    [phy1132] float  NULL,
    [bus1123] float  NULL,
    [mat1134] float  NULL,
    [eee1135] float  NULL,
    [eee11p6] float  NULL,
    [cse1127] float  NULL,
    [cse11p8] float  NULL
);
GO

-- Creating table 'result12'
CREATE TABLE [dbo].[result12] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NULL,
    [examterm] varchar(3)  NULL,
    [mat1231] float  NULL,
    [hum1222] float  NULL,
    [eee1233] float  NULL,
    [eee12p4] float  NULL,
    [cse1235] float  NULL,
    [cse12p6] float  NULL,
    [cse1237] float  NULL,
    [cse12p8] float  NULL
);
GO

-- Creating table 'result21'
CREATE TABLE [dbo].[result21] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NULL,
    [examterm] varchar(3)  NULL,
    [mat2131] float  NULL,
    [che2122] float  NULL,
    [cse2133] float  NULL,
    [cse2134] float  NULL,
    [cse2135] float  NULL,
    [cse21p6] float  NULL,
    [cse2137] float  NULL,
    [cse21p8] float  NULL
);
GO

-- Creating table 'result22'
CREATE TABLE [dbo].[result22] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NULL,
    [examterm] varchar(3)  NULL,
    [eco2221] float  NULL,
    [cse2232] float  NULL,
    [cse22p3] float  NULL,
    [cse2234] float  NULL,
    [cse22p5] float  NULL,
    [cse2236] float  NULL,
    [cse22p7] float  NULL,
    [cse2238] float  NULL,
    [cse22p9] float  NULL
);
GO

-- Creating table 'result31'
CREATE TABLE [dbo].[result31] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NULL,
    [examterm] varchar(3)  NULL,
    [mat3131] float  NULL,
    [cse3122] float  NULL,
    [cse3133] float  NULL,
    [cse3134] float  NULL,
    [cse31p5] float  NULL,
    [cse3136] float  NULL,
    [cse31p7] float  NULL,
    [cse31p8] float  NULL,
    [cse31p9] float  NULL
);
GO

-- Creating table 'result32'
CREATE TABLE [dbo].[result32] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NULL,
    [examterm] varchar(3)  NULL,
    [cse3221] float  NULL,
    [cse3232] float  NULL,
    [cse3233] float  NULL,
    [cse32p4] float  NULL,
    [cse3235] float  NULL,
    [cse32p6] float  NULL,
    [cse3237] float  NULL,
    [cse32p8] float  NULL,
    [cse32p9] float  NULL
);
GO

-- Creating table 'result41'
CREATE TABLE [dbo].[result41] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NULL,
    [examterm] varchar(3)  NULL,
    [cse4121] float  NULL,
    [cse4132] float  NULL,
    [cse4133] float  NULL,
    [cse41p4] float  NULL,
    [cse4135] float  NULL,
    [cse41p6] float  NULL,
    [cse4137] float  NULL,
    [cse41p8] float  NULL
);
GO

-- Creating table 'result42'
CREATE TABLE [dbo].[result42] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NULL,
    [examterm] varchar(3)  NULL,
    [cse4231] float  NULL,
    [cse4232] float  NULL,
    [cse42p3] float  NULL,
    [cse4234] float  NULL,
    [cse42p5] float  NULL,
    [cse4246] float  NULL,
    [cse4227] float  NULL
);
GO

-- Creating table 'students'
CREATE TABLE [dbo].[students] (
    [id] int IDENTITY(1,1) NOT NULL,
    [studentid] varchar(15)  NOT NULL,
    [fullname] varchar(100)  NULL,
    [studycenter] varchar(100)  NULL,
    [batchno] varchar(10)  NULL,
    [academicsession] varchar(10)  NULL,
    [fathername] varchar(100)  NULL,
    [mothername] varchar(100)  NULL,
    [dob] datetime  NULL,
    [mobileno] varchar(11)  NULL,
    [bloodgroup] varchar(10)  NULL,
    [address] varchar(255)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [username] varchar(100)  NULL,
    [password] varchar(100)  NULL,
    [userrole] varchar(1)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [code] in table 'courses'
ALTER TABLE [dbo].[courses]
ADD CONSTRAINT [PK_courses]
    PRIMARY KEY CLUSTERED ([code] ASC);
GO

-- Creating primary key on [id] in table 'result11'
ALTER TABLE [dbo].[result11]
ADD CONSTRAINT [PK_result11]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'result12'
ALTER TABLE [dbo].[result12]
ADD CONSTRAINT [PK_result12]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'result21'
ALTER TABLE [dbo].[result21]
ADD CONSTRAINT [PK_result21]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'result22'
ALTER TABLE [dbo].[result22]
ADD CONSTRAINT [PK_result22]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'result31'
ALTER TABLE [dbo].[result31]
ADD CONSTRAINT [PK_result31]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'result32'
ALTER TABLE [dbo].[result32]
ADD CONSTRAINT [PK_result32]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'result41'
ALTER TABLE [dbo].[result41]
ADD CONSTRAINT [PK_result41]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'result42'
ALTER TABLE [dbo].[result42]
ADD CONSTRAINT [PK_result42]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [studentid] in table 'students'
ALTER TABLE [dbo].[students]
ADD CONSTRAINT [PK_students]
    PRIMARY KEY CLUSTERED ([studentid] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [id] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [studentid] in table 'result11'
ALTER TABLE [dbo].[result11]
ADD CONSTRAINT [FK__result11__studen__29572725]
    FOREIGN KEY ([studentid])
    REFERENCES [dbo].[students]
        ([studentid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__result11__studen__29572725'
CREATE INDEX [IX_FK__result11__studen__29572725]
ON [dbo].[result11]
    ([studentid]);
GO

-- Creating foreign key on [studentid] in table 'result12'
ALTER TABLE [dbo].[result12]
ADD CONSTRAINT [FK__result12__studen__2C3393D0]
    FOREIGN KEY ([studentid])
    REFERENCES [dbo].[students]
        ([studentid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__result12__studen__2C3393D0'
CREATE INDEX [IX_FK__result12__studen__2C3393D0]
ON [dbo].[result12]
    ([studentid]);
GO

-- Creating foreign key on [studentid] in table 'result21'
ALTER TABLE [dbo].[result21]
ADD CONSTRAINT [FK__result21__studen__2F10007B]
    FOREIGN KEY ([studentid])
    REFERENCES [dbo].[students]
        ([studentid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__result21__studen__2F10007B'
CREATE INDEX [IX_FK__result21__studen__2F10007B]
ON [dbo].[result21]
    ([studentid]);
GO

-- Creating foreign key on [studentid] in table 'result22'
ALTER TABLE [dbo].[result22]
ADD CONSTRAINT [FK__result22__studen__31EC6D26]
    FOREIGN KEY ([studentid])
    REFERENCES [dbo].[students]
        ([studentid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__result22__studen__31EC6D26'
CREATE INDEX [IX_FK__result22__studen__31EC6D26]
ON [dbo].[result22]
    ([studentid]);
GO

-- Creating foreign key on [studentid] in table 'result31'
ALTER TABLE [dbo].[result31]
ADD CONSTRAINT [FK__result31__studen__34C8D9D1]
    FOREIGN KEY ([studentid])
    REFERENCES [dbo].[students]
        ([studentid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__result31__studen__34C8D9D1'
CREATE INDEX [IX_FK__result31__studen__34C8D9D1]
ON [dbo].[result31]
    ([studentid]);
GO

-- Creating foreign key on [studentid] in table 'result32'
ALTER TABLE [dbo].[result32]
ADD CONSTRAINT [FK__result32__studen__37A5467C]
    FOREIGN KEY ([studentid])
    REFERENCES [dbo].[students]
        ([studentid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__result32__studen__37A5467C'
CREATE INDEX [IX_FK__result32__studen__37A5467C]
ON [dbo].[result32]
    ([studentid]);
GO

-- Creating foreign key on [studentid] in table 'result41'
ALTER TABLE [dbo].[result41]
ADD CONSTRAINT [FK__result41__studen__3A81B327]
    FOREIGN KEY ([studentid])
    REFERENCES [dbo].[students]
        ([studentid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__result41__studen__3A81B327'
CREATE INDEX [IX_FK__result41__studen__3A81B327]
ON [dbo].[result41]
    ([studentid]);
GO

-- Creating foreign key on [studentid] in table 'result42'
ALTER TABLE [dbo].[result42]
ADD CONSTRAINT [FK__result42__studen__3D5E1FD2]
    FOREIGN KEY ([studentid])
    REFERENCES [dbo].[students]
        ([studentid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__result42__studen__3D5E1FD2'
CREATE INDEX [IX_FK__result42__studen__3D5E1FD2]
ON [dbo].[result42]
    ([studentid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------