use [movie-web]

create table Account(
	accountID char(10) primary key,
	email varchar(100),
	passwordAcc varchar(100),
	roleAcc bit, 
	username nvarchar(100),
	avartar varchar(100),
	createDate datetime,
	createBy nvarchar(100)
)

create table Film(
	filmID char(10) primary key,
	nameFilm nvarchar(100),
	nameEngFilm varchar(100),
	linkImgAvt varchar(500),
	linkImgDes varchar(500),
	linkBgImage varchar(500),
	linkFilm varchar(500),
	linkTrailer varchar(500),
	desText varchar(500),
	contentText varchar(2000),
	releaseFilm datetime,
	imdb float,
	quality nvarchar(100),
	star varchar(10),
	nation nvarchar(500),
	actor nvarchar(500),
	director nvarchar(500),
	genre nvarchar(500),
	createDate datetime,
	createBy nvarchar(100)
)

create table FilmStatus(
	filmID char(10) references Film(filmID),
	statusText nvarchar(500),
	releasedEpisodes int,
	totalEpisodes int
)

create table Feedback (
	filmID char(10) references Film(filmID),
	accountID char(10) references Account(accountID),
	cmt nvarchar(2000),
	sentDate datetime
)
