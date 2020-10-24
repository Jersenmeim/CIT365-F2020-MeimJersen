create table scriptures(

	Scriptureid int not null primary key identity (1,1),
	Book nvarchar(100),
	ChapterSection int,
	Verses int,
	Notes nvarchar(1000),
	DateCreated Date, 
);	