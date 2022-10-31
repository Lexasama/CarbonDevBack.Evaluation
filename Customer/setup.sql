CREATE DATABASE FnacDigitalFactory;
GO

USE FnacDigitalFactory;
GO

CREATE SCHEMA fdf;
GO

CREATE TABLE fdf.Customer (
                              Id			Int IDENTITY(0,1),
                              FirstName	VARCHAR(32) NOT NULL,
                              LastName	VARCHAR(32) NOT NULL,

                              CONSTRAINT PK_customer PRIMARY KEY (Id)
);

INSERT INTO fdf.Customer(FirstName, LastName)
VALUES
    ('FirstName', 'LastName'),
    ('FirstName1', 'LastName1');

CREATE TABLE fdf.[Order](
                            Id			INT IDENTITY(0,1),
                            CustomerId	INT NOT NULL,
                            OrderNumber INT NOT NULL

                                CONSTRAINT FK_order_customerId FOREIGN KEY(CustomerId) REFERENCES fdf.Customer(Id),
                            CONSTRAINT UK_order_orderNumber UNIQUE(OrderNumber)
);
INSERT INTO fdf.[Order] (CustomerId, OrderNumber)
VALUES	(0, 0),
        (1, 1),
        (1, 2),
        (1, 3);
GO

exec getClientAndOrder @OrderId = 1;
GO

select * from fdf.[Order];

DECLARE @FoundId INT;
SET @FoundId = (SELECT CustomerId FROM fdf.[Order] WHERE Id = 1);
SELECT c.Id,
       c.FirstName,
       c.LastName,
       o.Id,
       o.CustomerId,
       o.OrderNumber
FROM fdf.Customer  c
         JOIN fdf.[Order] o on o.CustomerId = c.Id
WHERE @FoundId = c.Id;

--drop procedure if exists fdf.getClientAndOrder;