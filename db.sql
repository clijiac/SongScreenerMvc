/*
Navicat SQL Server Data Transfer

Source Server         : localhost
Source Server Version : 110000
Source Host           : CLIJIAC-PC:1433
Source Database       : SongScreenerDB
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2012-12-22 10:59:45
*/


-- ----------------------------
-- Table structure for [Artist]
-- ----------------------------
DROP TABLE [Artist]
GO
CREATE TABLE [Artist] (
[ArtistID] varchar(50) NOT NULL ,
[ArtistName] nvarchar(255) NOT NULL ,
[ArtistGender] tinyint NOT NULL 
)


GO

-- ----------------------------
-- Records of Artist
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [Artist] ([ArtistID], [ArtistName], [ArtistGender]) VALUES (N'07b99623-146c-4d63-9ec0-91daeb2a859c', N'Bardudollantor', N'1');
INSERT INTO [Artist] ([ArtistID], [ArtistName], [ArtistGender]) VALUES (N'40bea4f1-4c3a-4057-802b-d8501bf565be', N'Grojubor', N'0');
INSERT INTO [Artist] ([ArtistID], [ArtistName], [ArtistGender]) VALUES (N'7bc19d31-0a19-4292-b3e8-3fa976da5ed0', N'Supwerpinan', N'0');
INSERT INTO [Artist] ([ArtistID], [ArtistName], [ArtistGender]) VALUES (N'c6562381-5a8b-417f-a885-f916f83bff6e', N'Supsapefin', N'1');
INSERT INTO [Artist] ([ArtistID], [ArtistName], [ArtistGender]) VALUES (N'ec03cb05-98c8-4510-94ca-8b3f9a4b9f88', N'Qwibanamazz', N'0');
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [Genre]
-- ----------------------------
DROP TABLE [Genre]
GO
CREATE TABLE [Genre] (
[GenreID] varchar(50) NOT NULL ,
[GenreName] nvarchar(255) NOT NULL 
)


GO

-- ----------------------------
-- Records of Genre
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [Genre] ([GenreID], [GenreName]) VALUES (N'0c869251-5511-4847-b271-59f5f2c17b77', N'Surnipopistor');
INSERT INTO [Genre] ([GenreID], [GenreName]) VALUES (N'1401342e-0db1-4958-ba8c-82bbf3e3f69c', N'Doperover');
INSERT INTO [Genre] ([GenreID], [GenreName]) VALUES (N'1d4e32e8-56e1-4731-9b8d-68119ac55a00', N'Barnipax');
INSERT INTO [Genre] ([GenreID], [GenreName]) VALUES (N'c3a53cd6-ef11-40cf-a7bc-52754836b777', N'Inquestamazz');
INSERT INTO [Genre] ([GenreID], [GenreName]) VALUES (N'c913e0c0-95d4-4cb7-8e98-6bbb7c2e3841', N'Froeramar');
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [Intonation]
-- ----------------------------
DROP TABLE [Intonation]
GO
CREATE TABLE [Intonation] (
[IntonationID] varchar(50) NOT NULL ,
[IntonationName] nvarchar(255) NOT NULL 
)


GO

-- ----------------------------
-- Records of Intonation
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [Intonation] ([IntonationID], [IntonationName]) VALUES (N'39717d4d-e335-4f3f-a11a-6e2a24c8667f', N'Hapvenor');
INSERT INTO [Intonation] ([IntonationID], [IntonationName]) VALUES (N'405a245c-2f77-4971-906d-f68e80249870', N'Doperex');
INSERT INTO [Intonation] ([IntonationID], [IntonationName]) VALUES (N'605e94db-9f31-414d-b73b-1a135df545fb', N'Emdimicator');
INSERT INTO [Intonation] ([IntonationID], [IntonationName]) VALUES (N'943fcf8a-6a2e-4690-9dde-84be5b5803eb', N'Barnipedgar');
INSERT INTO [Intonation] ([IntonationID], [IntonationName]) VALUES (N'c4994a7b-c6bd-4de4-a19e-7cf6de2e05c0', N'Thrubanower');
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [Language]
-- ----------------------------
DROP TABLE [Language]
GO
CREATE TABLE [Language] (
[LanguageID] varchar(50) NOT NULL ,
[LanguageName] nvarchar(255) NOT NULL 
)


GO

-- ----------------------------
-- Records of Language
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [Language] ([LanguageID], [LanguageName]) VALUES (N'00643cd1-21cd-4aba-995c-b751dadb6c0c', N'Inzapefax');
INSERT INTO [Language] ([LanguageID], [LanguageName]) VALUES (N'38d18477-e3b7-4bfe-8a1f-21fd2e4a6311', N'Thrunipaquar');
INSERT INTO [Language] ([LanguageID], [LanguageName]) VALUES (N'3ddf2c6e-6c31-4f5a-ae47-b54c08ef923e', N'Qwicador');
INSERT INTO [Language] ([LanguageID], [LanguageName]) VALUES (N'aa1f0a8b-1e95-4b96-893c-17565a6b42db', N'Trupebistor');
INSERT INTO [Language] ([LanguageID], [LanguageName]) VALUES (N'b6048b4f-c795-4808-a59a-b3965fe87bfe', N'Uperollan');
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [Rhythm]
-- ----------------------------
DROP TABLE [Rhythm]
GO
CREATE TABLE [Rhythm] (
[RhythmID] varchar(50) NOT NULL ,
[RhythmName] nvarchar(255) NOT NULL 
)


GO

-- ----------------------------
-- Records of Rhythm
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [Rhythm] ([RhythmID], [RhythmName]) VALUES (N'48581226-bc4e-4cbf-aaa1-2153a86441a7', N'Pardimin');
INSERT INTO [Rhythm] ([RhythmID], [RhythmName]) VALUES (N'487f5ffb-2f07-4740-bb8b-fc42ceac9920', N'Uncadicator');
INSERT INTO [Rhythm] ([RhythmID], [RhythmName]) VALUES (N'842f5286-0e8f-4e7a-b8ff-3c9798f871d4', N'Winwerover');
INSERT INTO [Rhythm] ([RhythmID], [RhythmName]) VALUES (N'8af87263-3fe3-411e-80cf-e6c469252662', N'Parwerpicator');
INSERT INTO [Rhythm] ([RhythmID], [RhythmName]) VALUES (N'f5caa70f-ee8f-4177-92c3-7c37515ed8b2', N'Truwerpin');
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [Song]
-- ----------------------------
DROP TABLE [Song]
GO
CREATE TABLE [Song] (
[SongID] varchar(50) NOT NULL ,
[SongName] nvarchar(255) NOT NULL ,
[SongArtistID] varchar(50) NOT NULL ,
[SongLanguageID] varchar(50) NOT NULL ,
[SongGenreID] varchar(50) NOT NULL ,
[SongIntonationID] varchar(50) NOT NULL ,
[SongToneID] varchar(50) NOT NULL ,
[SongRhythmID] varchar(50) NOT NULL ,
[SongPath] nvarchar(255) NOT NULL 
)


GO

-- ----------------------------
-- Records of Song
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'0ed97610-f920-42ed-b9f5-51c5460888f6', N'Grodudower', N'40bea4f1-4c3a-4057-802b-d8501bf565be', N'38d18477-e3b7-4bfe-8a1f-21fd2e4a6311', N'1401342e-0db1-4958-ba8c-82bbf3e3f69c', N'405a245c-2f77-4971-906d-f68e80249870', N'3372137c-2d2b-47e3-8678-e4620822ef5e', N'487f5ffb-2f07-4740-bb8b-fc42ceac9920', N'P:\Program Files\SQL Data Generator\SQL Data Compare\SQL Refactor\Sales\SQL Prompt\pdqmh.txt');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'35e8df9b-cba8-4023-b1f0-60ca98ea54df', N'Suppickeficator', N'7bc19d31-0a19-4292-b3e8-3fa976da5ed0', N'3ddf2c6e-6c31-4f5a-ae47-b54c08ef923e', N'1d4e32e8-56e1-4731-9b8d-68119ac55a00', N'605e94db-9f31-414d-b73b-1a135df545fb', N'3860105e-ee9c-4cd8-a509-928b85c570b6', N'842f5286-0e8f-4e7a-b8ff-3c9798f871d4', N'N:\Program Files\Test\Red Gate\Builds\Builds\zud.pdf');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'3b9a4eb9-b958-49db-8a3e-9f5289a4826d', N'Rejuban', N'ec03cb05-98c8-4510-94ca-8b3f9a4b9f88', N'b6048b4f-c795-4808-a59a-b3965fe87bfe', N'c913e0c0-95d4-4cb7-8e98-6bbb7c2e3841', N'c4994a7b-c6bd-4de4-a19e-7cf6de2e05c0', N'f63c4f36-3b8b-49a7-8f2e-e1cff085ec2b', N'f5caa70f-ee8f-4177-92c3-7c37515ed8b2', N'Q:\Document and Settings\Temp\oua.pdf');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'511dba19-799e-4be5-9a38-d463bd05e005', N'Monkilin', N'7bc19d31-0a19-4292-b3e8-3fa976da5ed0', N'3ddf2c6e-6c31-4f5a-ae47-b54c08ef923e', N'1d4e32e8-56e1-4731-9b8d-68119ac55a00', N'605e94db-9f31-414d-b73b-1a135df545fb', N'3860105e-ee9c-4cd8-a509-928b85c570b6', N'842f5286-0e8f-4e7a-b8ff-3c9798f871d4', N'Z:\Document and Settings\SQL Refactor\Business\Builds\echw.ini');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'6db22393-23c8-4cef-8b21-afc412c02645', N'Doperupistor', N'40bea4f1-4c3a-4057-802b-d8501bf565be', N'38d18477-e3b7-4bfe-8a1f-21fd2e4a6311', N'1401342e-0db1-4958-ba8c-82bbf3e3f69c', N'405a245c-2f77-4971-906d-f68e80249870', N'3372137c-2d2b-47e3-8678-e4620822ef5e', N'487f5ffb-2f07-4740-bb8b-fc42ceac9920', N'E:\Inetpub\Business\SQL Data Generator\SQL Refactor\svr.bmp');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'8f1a20cb-1b50-42d0-af7b-600325bef54d', N'Tupmunistor', N'ec03cb05-98c8-4510-94ca-8b3f9a4b9f88', N'b6048b4f-c795-4808-a59a-b3965fe87bfe', N'c913e0c0-95d4-4cb7-8e98-6bbb7c2e3841', N'c4994a7b-c6bd-4de4-a19e-7cf6de2e05c0', N'f63c4f36-3b8b-49a7-8f2e-e1cff085ec2b', N'f5caa70f-ee8f-4177-92c3-7c37515ed8b2', N'L:\Program Files\Test\Products\SQL Prompt\yqmht.asm');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'bae66ecd-99e8-4510-bdf2-1071c9bdfab0', N'Requestommin', N'7bc19d31-0a19-4292-b3e8-3fa976da5ed0', N'3ddf2c6e-6c31-4f5a-ae47-b54c08ef923e', N'1d4e32e8-56e1-4731-9b8d-68119ac55a00', N'605e94db-9f31-414d-b73b-1a135df545fb', N'3860105e-ee9c-4cd8-a509-928b85c570b6', N'842f5286-0e8f-4e7a-b8ff-3c9798f871d4', N'N:\Windows\SQL Prompt\Temp\Builds\cltjv.asm');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'e92d0186-998a-4542-ab0e-8849ca4956b0', N'Rejubedgower', N'ec03cb05-98c8-4510-94ca-8b3f9a4b9f88', N'b6048b4f-c795-4808-a59a-b3965fe87bfe', N'c913e0c0-95d4-4cb7-8e98-6bbb7c2e3841', N'c4994a7b-c6bd-4de4-a19e-7cf6de2e05c0', N'f63c4f36-3b8b-49a7-8f2e-e1cff085ec2b', N'f5caa70f-ee8f-4177-92c3-7c37515ed8b2', N'T:\Win\SQL Data Compare\Builds\rrrfv.bmp');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'ed97a96a-2994-4e51-81bd-676ced5c421a', N'Rapdudicator', N'c6562381-5a8b-417f-a885-f916f83bff6e', N'aa1f0a8b-1e95-4b96-893c-17565a6b42db', N'c3a53cd6-ef11-40cf-a7bc-52754836b777', N'943fcf8a-6a2e-4690-9dde-84be5b5803eb', N'60b3ce83-f943-4b8d-8013-0ab0a94f2b4f', N'8af87263-3fe3-411e-80cf-e6c469252662', N'A:\Inetpub\Sales\kofau.bmp');
INSERT INTO [Song] ([SongID], [SongName], [SongArtistID], [SongLanguageID], [SongGenreID], [SongIntonationID], [SongToneID], [SongRhythmID], [SongPath]) VALUES (N'fa9ad93e-0233-4d51-b06d-1d66bee2572d', N'Admunaquax', N'c6562381-5a8b-417f-a885-f916f83bff6e', N'aa1f0a8b-1e95-4b96-893c-17565a6b42db', N'c3a53cd6-ef11-40cf-a7bc-52754836b777', N'943fcf8a-6a2e-4690-9dde-84be5b5803eb', N'60b3ce83-f943-4b8d-8013-0ab0a94f2b4f', N'8af87263-3fe3-411e-80cf-e6c469252662', N'S:\Program\Red Gate\Products\SQL Prompt\Builds\Temp\fgzw.xls');
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [sysdiagrams]
-- ----------------------------
DROP TABLE [sysdiagrams]
GO
CREATE TABLE [sysdiagrams] (
[name] sysname NOT NULL ,
[principal_id] int NOT NULL ,
[diagram_id] int NOT NULL IDENTITY(1,1) ,
[version] int NULL ,
[definition] varbinary(MAX) NULL 
)


GO

-- ----------------------------
-- Records of sysdiagrams
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [sysdiagrams] ON
GO
SET IDENTITY_INSERT [sysdiagrams] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for [Tone]
-- ----------------------------
DROP TABLE [Tone]
GO
CREATE TABLE [Tone] (
[ToneID] varchar(50) NOT NULL ,
[ToneName] nvarchar(255) NOT NULL 
)


GO

-- ----------------------------
-- Records of Tone
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [Tone] ([ToneID], [ToneName]) VALUES (N'1d8b13ac-98a6-4f15-8513-40a3617aa345', N'Supzapicator');
INSERT INTO [Tone] ([ToneID], [ToneName]) VALUES (N'3372137c-2d2b-47e3-8678-e4620822ef5e', N'Rapfropupax');
INSERT INTO [Tone] ([ToneID], [ToneName]) VALUES (N'3860105e-ee9c-4cd8-a509-928b85c570b6', N'Kliwerpedan');
INSERT INTO [Tone] ([ToneID], [ToneName]) VALUES (N'60b3ce83-f943-4b8d-8013-0ab0a94f2b4f', N'Suphupegin');
INSERT INTO [Tone] ([ToneID], [ToneName]) VALUES (N'f63c4f36-3b8b-49a7-8f2e-e1cff085ec2b', N'Reveninentor');
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Procedure structure for [sp_alterdiagram]
-- ----------------------------
DROP PROCEDURE [sp_alterdiagram]
GO

	CREATE PROCEDURE [sp_alterdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_creatediagram]
-- ----------------------------
DROP PROCEDURE [sp_creatediagram]
GO

	CREATE PROCEDURE [sp_creatediagram]
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_dropdiagram]
-- ----------------------------
DROP PROCEDURE [sp_dropdiagram]
GO

	CREATE PROCEDURE [sp_dropdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_helpdiagramdefinition]
-- ----------------------------
DROP PROCEDURE [sp_helpdiagramdefinition]
GO

	CREATE PROCEDURE [sp_helpdiagramdefinition]
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_helpdiagrams]
-- ----------------------------
DROP PROCEDURE [sp_helpdiagrams]
GO

	CREATE PROCEDURE [sp_helpdiagrams]
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_renamediagram]
-- ----------------------------
DROP PROCEDURE [sp_renamediagram]
GO

	CREATE PROCEDURE [sp_renamediagram]
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
	
GO

-- ----------------------------
-- Procedure structure for [sp_upgraddiagrams]
-- ----------------------------
DROP PROCEDURE [sp_upgraddiagrams]
GO

	CREATE PROCEDURE [sp_upgraddiagrams]
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
	
GO

-- ----------------------------
-- Function structure for [fn_diagramobjects]
-- ----------------------------
DROP FUNCTION [fn_diagramobjects]
GO

	CREATE FUNCTION [fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
	
GO

-- ----------------------------
-- Indexes structure for table Artist
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Artist]
-- ----------------------------
ALTER TABLE [Artist] ADD PRIMARY KEY ([ArtistID])
GO

-- ----------------------------
-- Indexes structure for table Genre
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Genre]
-- ----------------------------
ALTER TABLE [Genre] ADD PRIMARY KEY ([GenreID])
GO

-- ----------------------------
-- Indexes structure for table Intonation
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Intonation]
-- ----------------------------
ALTER TABLE [Intonation] ADD PRIMARY KEY ([IntonationID])
GO

-- ----------------------------
-- Indexes structure for table Language
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Language]
-- ----------------------------
ALTER TABLE [Language] ADD PRIMARY KEY ([LanguageID])
GO

-- ----------------------------
-- Indexes structure for table Rhythm
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Rhythm]
-- ----------------------------
ALTER TABLE [Rhythm] ADD PRIMARY KEY ([RhythmID])
GO

-- ----------------------------
-- Indexes structure for table Song
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Song]
-- ----------------------------
ALTER TABLE [Song] ADD PRIMARY KEY ([SongID])
GO

-- ----------------------------
-- Indexes structure for table sysdiagrams
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sysdiagrams]
-- ----------------------------
ALTER TABLE [sysdiagrams] ADD PRIMARY KEY ([diagram_id])
GO

-- ----------------------------
-- Uniques structure for table [sysdiagrams]
-- ----------------------------
ALTER TABLE [sysdiagrams] ADD UNIQUE ([principal_id] ASC, [name] ASC)
GO

-- ----------------------------
-- Indexes structure for table Tone
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [Tone]
-- ----------------------------
ALTER TABLE [Tone] ADD PRIMARY KEY ([ToneID])
GO

-- ----------------------------
-- Foreign Key structure for table [Song]
-- ----------------------------
ALTER TABLE [Song] ADD FOREIGN KEY ([SongArtistID]) REFERENCES [Artist] ([ArtistID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [Song] ADD FOREIGN KEY ([SongGenreID]) REFERENCES [Genre] ([GenreID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [Song] ADD FOREIGN KEY ([SongIntonationID]) REFERENCES [Intonation] ([IntonationID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [Song] ADD FOREIGN KEY ([SongLanguageID]) REFERENCES [Language] ([LanguageID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [Song] ADD FOREIGN KEY ([SongRhythmID]) REFERENCES [Rhythm] ([RhythmID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [Song] ADD FOREIGN KEY ([SongToneID]) REFERENCES [Tone] ([ToneID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
