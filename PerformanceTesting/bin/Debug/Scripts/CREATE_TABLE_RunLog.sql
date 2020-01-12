IF (OBJECT_ID('RunLog') IS NOT NULL)
BEGIN
   DROP TABLE [dbo].RunLog
END
CREATE TABLE RunLog (
    Id int NOT NULL,
    RunDateTime datetime,
    TotalConsumedSeconds int,
	NumberOfMessage int,
	Topic nvarchar(200),
	BrokerList nvarchar(500)
)