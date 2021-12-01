CREATE PROCEDURE [dbo].[spLists_Insert]
	@Title nvarchar(50)
AS
BEGIN
		insert into dbo.Lists (Title)
		values (@Title);
END
