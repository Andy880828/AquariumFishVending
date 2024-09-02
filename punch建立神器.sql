-- ���J�H����ܪ����u���d��ơA�Ҽ{�J¾����M�W�U�Z�ɶ�����
DECLARE @punch_count INT = 0;
DECLARE @max_punch_count INT = 100;
DECLARE @current_max_id INT;

-- ���o��e�̤j�����d�s��
SELECT @current_max_id = ISNULL(MAX([���d�s��]), 0) FROM [dbo].[punch];

WHILE @punch_count < @max_punch_count
BEGIN
    DECLARE @random_employee_id INT;
    DECLARE @hire_date DATE;
    DECLARE @current_date DATE = GETDATE();
    DECLARE @punchin_time DATETIME2;
    DECLARE @punchout_time DATETIME2;
    DECLARE @days_between INT;

    -- �H����ܤ@����u
    SELECT TOP 1 @random_employee_id = [���u�s��], @hire_date = [�J¾��]
    FROM [dbo].[employees]
    WHERE [��¾��] IS NULL -- �T�O��ܪ��O�ثe�b¾���u
    ORDER BY NEWID();

    -- �T�O���d����b�J¾�������
    SET @days_between = ABS(CHECKSUM(NEWID())) % (DATEDIFF(DAY, @hire_date, @current_date) + 1);
    SET @punchin_time = DATEADD(DAY, @days_between, @hire_date);

    -- �]�w�H���W�U�Z�ɶ��A�T�O�U�Z�ɶ����W�L�ߤW9�I
    SET @punchin_time = DATEADD(HOUR, 8 + ABS(CHECKSUM(NEWID())) % 3, @punchin_time);
    SET @punchout_time = DATEADD(HOUR, 8 + ABS(CHECKSUM(NEWID())) % 3, @punchin_time);
    
    IF DATEPART(HOUR, @punchout_time) > 21
    BEGIN
        SET @punchout_time = DATEADD(HOUR, -1, @punchout_time);
    END

    -- ���J���d���
    INSERT INTO [dbo].[punch] ([���d�s��], [���u�s��], [���], [�W�Z�ɶ�], [�U�Z�ɶ�])
    VALUES (@current_max_id + @punch_count + 1, @random_employee_id, CAST(@punchin_time AS DATE), @punchin_time, @punchout_time);

    SET @punch_count = @punch_count + 1;
END;
