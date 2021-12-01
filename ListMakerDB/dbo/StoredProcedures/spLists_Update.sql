CREATE PROCEDURE [dbo].[spLists_Update]
	@Id int,
	@Title nvarchar(50)
AS
BEGIN
	update dbo.Lists 
	set Title = @Title
	where Id = @Id;

END
