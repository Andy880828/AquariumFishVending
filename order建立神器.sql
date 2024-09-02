-- 初始化變數
DECLARE @MaxOrderID INT;
DECLARE @MaxOrderItemID INT;
DECLARE @ProductCount INT;
DECLARE @ClientID INT, @EmployeeID INT, @ProductID INT, @ProductPrice DECIMAL(10, 0);
DECLARE @OrderDate DATETIME2, @TotalAmount DECIMAL(8, 0);
DECLARE @ProductQuantity INT, @ItemAmount DECIMAL(10, 0);

-- 取得目前的最大訂單編號
SELECT @MaxOrderID = ISNULL(MAX([訂單編號]), 0) FROM [dbo].[orders];
-- 設定訂單項目編號起始值
SET @MaxOrderItemID = 0;

-- 取得產品總數
SELECT @ProductCount = COUNT(*) FROM [dbo].[products];

-- 訂單生成邏輯
WHILE @MaxOrderID < 150 AND @MaxOrderItemID < 300
BEGIN
    SET @MaxOrderID = @MaxOrderID + 1;
    SET @TotalAmount = 0;

    -- 隨機選擇會員與員工
    SELECT TOP 1 @ClientID = [會員編號] FROM [dbo].[clients] ORDER BY NEWID();
    SELECT TOP 1 @EmployeeID = [員工編號] FROM [dbo].[employees] ORDER BY NEWID();

    -- 設定訂單時間，確保不超過合理範圍
    SET @OrderDate = DATEADD(DAY, -FLOOR(RAND() * 365), GETDATE());

    INSERT INTO [dbo].[orders] ([訂單編號], [會員編號], [員工編號], [成立時間], [總金額])
    VALUES (@MaxOrderID, @ClientID, @EmployeeID, @OrderDate, 0);

    -- 生成訂單項目
    SET @MaxOrderItemID = @MaxOrderItemID + 1;
    DECLARE @ItemCount INT = FLOOR(RAND() * 3 + 1);
    
    WHILE @ItemCount > 0 AND @MaxOrderItemID < 300
    BEGIN
        -- 隨機選擇產品
        SET @ProductID = (SELECT TOP 1 [產品編號] FROM [dbo].[products] ORDER BY NEWID());
        SELECT @ProductPrice = [產品金額] FROM [dbo].[products] WHERE [產品編號] = @ProductID;
        
        -- 隨機設置產品數量
        SET @ProductQuantity = CEILING(RAND() * 5);
        
        -- 計算項目金額
        SET @ItemAmount = @ProductPrice * @ProductQuantity;
        
        INSERT INTO [dbo].[orderitems] ([訂單編號], [訂單項目編號], [產品編號], [產品數量], [產品金額], [項目金額])
        VALUES (@MaxOrderID, @MaxOrderItemID, @ProductID, @ProductQuantity, @ProductPrice, @ItemAmount);
        
        -- 更新訂單總金額
        SET @TotalAmount = @TotalAmount + @ItemAmount;

        SET @ItemCount = @ItemCount - 1;
        SET @MaxOrderItemID = @MaxOrderItemID + 1;
    END

    -- 更新 orders 表中的總金額
    UPDATE [dbo].[orders]
    SET [總金額] = @TotalAmount
    WHERE [訂單編號] = @MaxOrderID;
END;
