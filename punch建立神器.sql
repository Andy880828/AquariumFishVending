-- 插入隨機選擇的員工打卡資料，考慮入職日期和上下班時間限制
DECLARE @punch_count INT = 0;
DECLARE @max_punch_count INT = 100;
DECLARE @current_max_id INT;

-- 取得當前最大的打卡編號
SELECT @current_max_id = ISNULL(MAX([打卡編號]), 0) FROM [dbo].[punch];

WHILE @punch_count < @max_punch_count
BEGIN
    DECLARE @random_employee_id INT;
    DECLARE @hire_date DATE;
    DECLARE @current_date DATE = GETDATE();
    DECLARE @punchin_time DATETIME2;
    DECLARE @punchout_time DATETIME2;
    DECLARE @days_between INT;

    -- 隨機選擇一位員工
    SELECT TOP 1 @random_employee_id = [員工編號], @hire_date = [入職日]
    FROM [dbo].[employees]
    WHERE [離職日] IS NULL -- 確保選擇的是目前在職員工
    ORDER BY NEWID();

    -- 確保打卡日期在入職日期之後
    SET @days_between = ABS(CHECKSUM(NEWID())) % (DATEDIFF(DAY, @hire_date, @current_date) + 1);
    SET @punchin_time = DATEADD(DAY, @days_between, @hire_date);

    -- 設定隨機上下班時間，確保下班時間不超過晚上9點
    SET @punchin_time = DATEADD(HOUR, 8 + ABS(CHECKSUM(NEWID())) % 3, @punchin_time);
    SET @punchout_time = DATEADD(HOUR, 8 + ABS(CHECKSUM(NEWID())) % 3, @punchin_time);
    
    IF DATEPART(HOUR, @punchout_time) > 21
    BEGIN
        SET @punchout_time = DATEADD(HOUR, -1, @punchout_time);
    END

    -- 插入打卡資料
    INSERT INTO [dbo].[punch] ([打卡編號], [員工編號], [日期], [上班時間], [下班時間])
    VALUES (@current_max_id + @punch_count + 1, @random_employee_id, CAST(@punchin_time AS DATE), @punchin_time, @punchout_time);

    SET @punch_count = @punch_count + 1;
END;
