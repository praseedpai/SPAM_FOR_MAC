
use FA;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 IF OBJECT_ID('spCreateFAGroup','P') IS NOT NULL
        DROP PROCEDURE spCreateFAGroup
GO

CREATE PROCEDURE spCreateFAGroup
    @A_CODE char(2), 
    @A_DESC char(50),
	@A_TYPE char(1),
	@A_CURRB decimal(18,3)

AS
BEGIN
     INSERT into FAGroup values ( @A_CODE , @A_DESC ,@A_TYPE ,@A_CURRB);
END
GO

IF OBJECT_ID('spDeleteFAGroup','P') IS NOT NULL
        DROP PROCEDURE spDeleteFAGroup
GO

CREATE PROCEDURE spDeleteFAGroup
    @A_CODE char(2)
	

AS
BEGIN
     Delete from FAGroup  where A_CODE = @A_CODE ;
END
GO

 IF OBJECT_ID('spUpdateFAGroup','P') IS NOT NULL
        DROP PROCEDURE spUpdateFAGroup
GO

CREATE PROCEDURE spUpdateFAGroup
    @A_CODE char(2), 
    @A_DESC char(50),
	@A_TYPE char(1),
	@A_CURRB decimal(18,3) 

AS
BEGIN
     Update  FAGroup set A_DESC= @A_DESC ,A_TYPE = @A_TYPE ,A_CURRB = @A_CURRB where A_CODE = @A_CODE ;
END
GO


IF OBJECT_ID('spListFAGroup','P') IS NOT NULL
        DROP PROCEDURE spListFAGroup
GO

CREATE PROCEDURE spListFAGroup
    
	

AS
BEGIN
     select * from FAGroup ;
END
GO
IF OBJECT_ID('spGetFAGroup','P') IS NOT NULL
        DROP PROCEDURE spGetFAGroup
GO

CREATE PROCEDURE spGetFAGroup
    @A_CODE char(2)
	

AS
BEGIN
     select * from FAGroup  where A_CODE = @A_CODE ;
END
GO




IF OBJECT_ID('spCreateFASubGroup','P') IS NOT NULL
        DROP PROCEDURE spCreateFASubGroup
GO

CREATE PROCEDURE spCreateFASubGroup
    @S_CODE char(5), 
    @S_DESC char(50),
	@S_TYPE char(2),
	@S_OPBAl decimal(18,3),
	@S_DRCR char(2),
	@S_FLAG char(1) 

AS
BEGIN
     INSERT into FASubGroup values ( @S_CODE , @S_DESC ,@S_TYPE ,@S_OPBAL,@S_DRCR,@S_FLAG);
END
GO

IF OBJECT_ID('spDeleteFASubGroup','P') IS NOT NULL
        DROP PROCEDURE spDeleteFASubGroup
GO

CREATE PROCEDURE spDeleteFASubGroup
    @S_CODE char(2)
	

AS
BEGIN
     Delete from FASubGroup  where S_CODE = @S_CODE ;
END
GO

 IF OBJECT_ID('spUpdateFASubGroup','P') IS NOT NULL
        DROP PROCEDURE spUpdateFASubGroup
GO

CREATE PROCEDURE spUpdateFASubGroup
    @S_CODE char(5), 
    @S_DESC char(50),
	@S_TYPE char(2),
	@S_OPBAl decimal(18,3),
	@S_DRCR char(2),
	@S_FLAG char(1) 

AS
BEGIN
     Update  FASubGroup set S_DESC= @S_DESC ,S_TYPE = @S_TYPE ,S_OPBAl = @S_OPBAl,S_DRCR = @S_DRCR,S_FLAG = @S_FLAG where S_CODE = @S_CODE ;
END
GO


IF OBJECT_ID('spListFASubGroup','P') IS NOT NULL
        DROP PROCEDURE spListFASubGroup
GO

CREATE PROCEDURE spListFASubGroup
    
	

AS
BEGIN
     select * from FASubGroup ;
END
GO
IF OBJECT_ID('spGetFASubGroup','P') IS NOT NULL
        DROP PROCEDURE spGetFASubGroup
GO

CREATE PROCEDURE spGetFASubGroup
    @S_CODE char(2)
	

AS
BEGIN
     select * from FASubGroup  where S_CODE = @S_CODE ;
END
GO




IF OBJECT_ID('spCreateJDetail','P') IS NOT NULL
        DROP PROCEDURE spCreateJDetail
GO

CREATE PROCEDURE spCreateJDetail
    @J_ID char(10), 
    @J_CODE char(5),
	@J_DRCR char(2),
	@J_AMOUNT decimal(18,3) 

AS
BEGIN
     INSERT into JournalDetail values ( @J_ID, @J_CODE ,@J_DRCR ,@J_AMOUNT);
END
GO

IF OBJECT_ID('spDeleteJDetail','P') IS NOT NULL
        DROP PROCEDURE spDeleteJDetail
GO

CREATE PROCEDURE spDeleteJDetail
    @J_ID char(10)
	

AS
BEGIN
     Delete from JournalDetail where J_ID = @J_ID ;
END
GO

 IF OBJECT_ID('spUpdateJDetail','P') IS NOT NULL
        DROP PROCEDURE spUpdateJDetail
GO

CREATE PROCEDURE spUpdateJDetail
   @J_ID char(10), 
    @J_CODE char(5),
	@J_DRCR char(2),
	@J_AMOUNT decimal(18,3) 

AS
BEGIN
     Update  JournalDetail set J_CODE = @J_CODE ,J_DRCR = @J_DRCR ,J_AMOUNT = @J_AMOUNT where J_ID = @J_ID ;
END
GO


IF OBJECT_ID('spListJDetail','P') IS NOT NULL
        DROP PROCEDURE spListJDetail
GO

CREATE PROCEDURE spListJDetail
    
	

AS
BEGIN
     select * from JournalDetail ;
END
GO
IF OBJECT_ID('spGetJDetail','P') IS NOT NULL
        DROP PROCEDURE spGetJDetail
GO
CREATE PROCEDURE spGetJDetail
    @J_ID char(10)
	

AS
BEGIN
     select * from JournalDetail where J_ID = @J_ID ;
END
GO






IF OBJECT_ID('spCreateJMaster','P') IS NOT NULL
        DROP PROCEDURE spCreateJMaster
GO

CREATE PROCEDURE spCreateJMaster
    @J_ID char(10), 
    @J_DOC char(2),
	@J_DATE datetime,
	@J_AMOUNT decimal(18,3),
	@J_NARR nchar(100) 

AS
BEGIN
     INSERT into JournalMaster values ( @J_ID, @J_DOC ,@J_DATE ,@J_AMOUNT,@J_NARR);
END
GO

IF OBJECT_ID('spDeleteJMaster','P') IS NOT NULL
        DROP PROCEDURE spDeleteJMaster
GO

CREATE PROCEDURE spDeleteJMaster
    @J_ID char(10)
	

AS
BEGIN
     Delete from JournalMaster where J_ID = @J_ID ;
END
GO

 IF OBJECT_ID('spUpdateJMaster','P') IS NOT NULL
        DROP PROCEDURE spUpdateJMaster
GO

CREATE PROCEDURE spUpdateJMaster
   @J_ID char(10), 
    @J_DOC char(5),
	@J_DATE datetime,
	@J_AMOUNT decimal(18,3),
	@J_NARR nchar(100) 

AS
BEGIN
     Update  JournalMaster set J_DOC = @J_DOC ,J_DATE = @J_DATE ,J_AMOUNT = @J_AMOUNT , J_NARR = @J_NARR where J_ID = @J_ID ;
END
GO


IF OBJECT_ID('spListJMaster','P') IS NOT NULL
        DROP PROCEDURE spListJMaster
GO

CREATE PROCEDURE spListJMaster
    
	

AS
BEGIN
     select * from JournalMaster;
END
GO
IF OBJECT_ID('spGetJMaster','P') IS NOT NULL
        DROP PROCEDURE spGetJMaster
GO
CREATE PROCEDURE spGetJMaster
    @J_ID char(10)
	

AS
BEGIN
     select * from JournalMaster where J_ID = @J_ID ;
END
GO





