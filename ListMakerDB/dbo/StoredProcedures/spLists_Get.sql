CREATE PROCEDURE [dbo].[spLists_Get]
	@Id int
AS
BEGIN
		select * from dbo.Lists
		where Id = @Id;
END