if not exists (select 1 from dbo.Lists)
begin
	insert into dbo.Lists (Title)
	values ('Monday'),('Tuesday');
end 
GO
