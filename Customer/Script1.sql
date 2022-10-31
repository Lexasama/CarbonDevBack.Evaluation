CREATE PROCEDURE  fdf.getClientAndOrder(
    @CustomerId INT = NULL,
    @OrderId    INT = NULL
)
AS
    BEGIN
        
        SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
        BEGIN TRAN;
            IF (@CustomerId IS NULL AND @OrderId IS NULL)
                BEGIN
                    ROLLBACK ;
                END;
            
            IF @CustomerId IS NOT NULL AND @OrderId IS NULL
                BEGIN
                      IF NOT EXISTS(
                          SELECT * FROM fdf.Customer c WHERE c.Id = @CustomerId
                        )
                    BEGIN
                        ROLLBACK;
                    END;
                END;
            ELSE
                BEGIN
                    SELECT c.Id as 'CustomerId',
                           c.FirstName,
                           c.LastName,
                           o.Id as 'OderId',
                           o.OrderNumber
                    FROM fdf.Customer  c
                        JOIN fdf.[Order] o on o.CustomerId = c.Id
                    WHERE @CustomerId = c.Id;
                END;
                    
            IF @OrderId IS NOT NULL
                BEGIN
                    DECLARE @FoundId INT;
                    SET @FoundId = (SELECT CustomerId FROM fdf.[Order] WHERE Id = @OrderId);
                    SELECT c.Id as 'CustomerId',
                           c.FirstName,
                           c.LastName,
                           o.Id as 'OrderId',
                           o.OrderNumber
                    FROM fdf.Customer  c
                             JOIN fdf.[Order] o on o.CustomerId = c.Id
                    WHERE @FoundId = c.Id;
                END;
        COMMIT;
    END;
GO;