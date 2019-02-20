select * from UIDisplay where ui='frmTransferGoodsManage' order by ColOrder
UPDATE dbo.UIDisplay SET ColOrder=ColOrder+1 WHERE   id!=711 and id<443  AND ui='frmTransferGoodsManage';
UPDATE dbo.UIDisplay SET ColOrder=13 WHERE id='446' AND ui='frmTransferGoodsManage';
UPDATE dbo.UIDisplay SET ColOrder=2 WHERE id='443' AND ui='frmTransferGoodsManage';
