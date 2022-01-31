

create PROC [dbo].[spButtonClick]  
@ExFacId Bigint
AS   

--spButtonClick 1
BEGIN  

INSERT INTO [dbo].[tblTestTable]
           ([ID]
           ,[CoaID]
           ,[DrAmount]
           ,[CrAmount]
           ,[RealizeID])
     VALUES
           ((select Max(isnull(ID,0)) from tblTestTable)
           ,1
           ,50
           ,0
           ,@ExFacId)

		   select [RealizeID] from tblTestTable where [RealizeID]=@ExFacId

END