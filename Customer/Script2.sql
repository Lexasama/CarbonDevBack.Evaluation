USE FnacDigitalFactory;

DROP PROCEDURE  fdf.getStats;
GO

CREATE PROCEDURE fdf.getStats (
    @OrderDate DATETIME2
)
AS
    BEGIN
        SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
        BEGIN TRAN;
            IF (@OrderDate IS NULL)
                BEGIN;
                    ROLLBACK;
                END;
                --- check month before create table 
                --- else just execute query
            USE FnacDigitalFactory;
            GO
            DROP TABLE  fdf.best_five_customers;
            GO
            create table fdf.best_five_customers 
                as (
                
                    RANK() OVER( ORDER BY ) as Rank
                );
            GO

            PRINT fdf.best_five_customers;
            IF (MONTH(@OrderDate) = '09')
                BEGIN;
                    DROP TABLE fdf.best_five_customers;
                END;
COMMIT;
    END;
GO