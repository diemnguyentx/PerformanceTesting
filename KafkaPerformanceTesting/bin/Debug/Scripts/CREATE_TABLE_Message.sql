IF (OBJECT_ID('Message') IS NOT NULL)
BEGIN
   DROP TABLE [dbo].Message
END
CREATE TABLE Message (
    Id int NOT NULL,
    Topic int,
    BrokerList int,
	Body nvarchar(500),
	FilePath nvarchar(200),
	RunTestId int,
    PRIMARY KEY (Id),	
    FOREIGN KEY (RunTestId) REFERENCES RunTest(Id)
)