USE [CmstStorageDB]
GO
/****** Object:  StoredProcedure [dbo].[Spec_selectByCmstInd]    Script Date: 2019/2/19 9:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




ALTER PROCEDURE [dbo].[Spec_selectByCmstInd]
    (
      @Spe_Ind_Id INT ,
      @Spe_Cmst_ID INT 
    )
AS
    BEGIN
        SELECT  Spe_ID ,
                Spe_Ind_Id ,
                Spe_Cmst_ID ,
                Spe_Name ,
                Spe_Remark ,
                Spe_IfUse ,
                Spe_IfDel ,
                ind.Ind_Name AS indName ,
                cmst.Cmst_Name AS cmstName ,
                CASE Spe_IfUse
                  WHEN '1' THEN '启用'
                  ELSE '停用'
                END AS Spe_UseStstus
        FROM    dbo.Spec spe
                LEFT JOIN dbo.Industry AS ind ON spe.Spe_Ind_Id = ind.Ind_Id
                LEFT JOIN dbo.CmstOrganization AS cmst ON spe.Spe_Cmst_ID = cmst.Cmst_ID
        WHERE   Spe_Cmst_ID = @Spe_Cmst_ID
                AND Spe_Ind_Id = @Spe_Ind_Id
                AND Spe_IfUse = '1'
                AND ( spe.Spe_IfDel = 0
                      OR spe.Spe_IfDel IS NULL
                    )
        ORDER BY Spe_Name ;
    END;


