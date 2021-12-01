CREATE PROCEDURE [dbo].[spLists_Delete]
	@Id int
AS
BEGIN
		delete from dbo.Lists
		where Id = @Id;
END