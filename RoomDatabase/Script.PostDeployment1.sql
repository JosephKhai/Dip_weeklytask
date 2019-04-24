/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF '$(LoadTestData)' = 'true'
BEGIN

DELETE FROM Room;

INSERT INTO Room (Number, Building, Capasity) VALUES
(224, 'TD', 22),
(210, 'TD', 23),
(203, 'TC', 23),
(203, 'TD', 20);

END;
