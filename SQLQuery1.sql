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
	linkTrailer varchar(500),
	desText varchar(500),
	contentText varchar(2000),
	releaseFilm datetime,
	statusText nvarchar(500),
	releasedEpisodes int,
	totalEpisodes int,
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
DROP table FilmEpisode
create table FilmEpisode(
	filmEpID char(10) primary key,
	filmID char(10) references Film(filmID),	
	Episode int,
	linkEpisode varchar(500)
)
DROP table Feedback
create table Feedback (
	feedbackID char(10) primary key,
	filmID char(10) references Film(filmID),
	accountID char(10) references Account(accountID),
	cmt nvarchar(2000),
	sentDate datetime
)



-----------------------------------------------------------------
use [movie-web]


insert into Account
values (
	'ACC001',
	'tungngngn@gmail.com',
	'admin',
	1,
	'admin',
	null,
	8/4/2021,
	'admin'
)

insert into Account
values (
	'ACC002',
	'kienloaa@gmail.com',
	'adminkien',
	1,
	'adminkien',
	null,
	8/4/2021,
	'adminkien'
)

insert into Account
values (
	'ACC003',
	'hungloaaa@gmail.com',
	'adminhung',
	1,
	'adminhung',
	null,
	8/4/2021,
	'adminhung'
)

insert into Account
values (
	'ACC004',
	'tuloaaa@gmail.com',
	'admintu',
	1,
	'admintu',
	null,
	8/4/2021,
	'admintu'
)


-----------------------------------------------------------------
insert into Film
values ('F0001',
		N'QUÁI VẬT SĂN ĐÊM',
		'Sputnik',
		'https://i.vdicdn.com/ff/2021/01/13/a94f8a133ee8cc74_427d15160d7ed194_335661610530615716068.jpg',
		null,
		null,		
		'https://www.youtube.com/watch?v=Oj63U2RyVvE',
		N'Một tai nạn tàu vũ trụ xảy ra, cướp đi sinh mạng người chỉ huy. Konstantin - người phi công còn lại may mắn sống sót nhưng trong cơ thể anh có loài quái vật ngoài hành tinh đang kí sinh. Chúng phát triển mạnh mẽ, khống chế thể xác lẫn tinh thần của vật chủ. Tatyana, một nữ khoa học, nhà vật lý học tài năng được giao nhiệm vụ tách con quái vật đó ra khỏi cơ thể Konstantin. Nhưng càng đi sâu nghiên cứu, cô lại từng bước vén lên bức màn bí mật, khám phá ra nhiều âm mưu đáng sợ đằng sau sự việc này.',
		N'Quái vật săn đêm - Sputnik là bộ phim kinh dị thuộc thể loại khoa học viễn tưởng của Nga được phát hành năm 2020 do đạo diễn Egor Abramenko chịu trách nhiệm chỉ đạo, đây cũng là bộ phim đầu tay của ông. Tác phẩm có sự tham gia của diễn viên Oksana Akinshina trong vai một bác sĩ trẻ được quân đội tuyển dụng để đánh giá một phi hành gia sống sót sau một vụ tai nạn không gian bí ẩn và trở về Trái Đất với một sinh vật nguy hiểm sống bên trong anh ta. Bộ phim còn có sự tham gia của Pyotr Fyodorov và Fyodor Bondarchuk.

Sputik dự kiến sẽ có buổi ra mắt thế giới tại Liên hoan phim Tribeca vào tháng 4 năm 2020 trước khi bị hoãn lại vì dịch bệnh. Phim được phát hành theo yêu cầu tại Nga vào ngày 23 tháng 4 năm 2020 và nhận được nhiều đánh giá tích cực từ các nhà phê bình.',
		8/4/2021,
		N'Đã phát hành',
		1,
		1,
		5.9,
		'HD',
		'5/10',
		N'Nga',
		'Oksana Akinshina',
		'Egor Abramenko',
		N'Kinh Dị,  Khoa Học,  Kịch Tính',
		8/4/2021,
		'tungnaa'
)
insert into FilmEpisode 
values (
	'FE0001',
	'F0001',
	1,
	'https://scontent.ficn4-1.fna.fbcdn.net/v/t66.36240-6/10000000_283745736593465_3925803616385416825_n.mp4?_nc_cat=102&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=F44yUlLYBqwAX-YRhsg&_nc_ht=scontent.ficn4-1.fna&oh=d7094c806f515eefbf477b99cad74f6f&oe=609214D7'

)

go
insert into Film values ('F0002',
		N'TRÙM CUỐI SIÊU ĐẲNG',
		'Boss Level',
		'https://www.venuscinema.vn/temp/-uploaded-phim_trum%20cuoi%20sieu%20dang_cr_500x700.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=vcTNydU1T-o',
		N'Mắc kẹt trong một vòng lặp thời gian ngay đúng ngày anh ta bị giết chết, một cựu đặc vụ Roy Pulver (FrankRoy buộc lòng phải chạy đua với thời gian và truy bắt tên Colonel Ventor (Mel Gibson), đầu sỏ của dự án chính phủ này. Trong lúc đó, anh phải thoát khỏi cuộc vây bắt của những tên sát thủ tàn ác quyết tâm ngăn cản Roy tìm ra được sự thật. Liệu Roy Pulver có thể thoáđồng thời sống lại một lần nữa vào ngày mai?',
		N'Đẳng cấp Boss - Boss Level (2020) là bộ phim hành động khoa học viễn tưởng của Mỹ do Joe Carnahan đạo diễn. Bộ phim có sự tham gia của Frank Grillo trong vai một người lính đã nghỉ hưu, cố gắng thoát khỏi vòng lặp thời gian không bao giờ kết thúc dẫn đến cái chết của anh ta. Bên cạnh đó, một số diễn viên khác gồm Mel Gibson, Naomi Watts và Dương Tử Quỳnh cũng góp mặt trong bộ phim.Tác phẩm thuộc thể loại hành động có yếu tố khoa viễn tưởng, khai thác chủ đề vòng lặp thời gian khá độc đáo. Mở đầu phim với cách triển khai khá lạ, nhân vật chính là Roy Pulver (Frank Grillo) vừa thức dậy thì đã có một sát thủ tới ám sát anh. Sau đó là tên súng máy ngồi trên trực thăng xả súng thẳng vào nhà Roy, anh ta đã chạy thoát ra ngoài. Anh đã cướp được một chiếc xe nhưng vẫn bị hai nữ sát thủ khác tấn công, anh lao nhanh về phía trước nhưng lại bị y thức dậy, bị truy sát, anh tìm mọi cách để trốn thoát nhưng không thành và chết. Sự việc đã tĩnh tâm suy nghĩ về nguyên nhân thực sự phía sau',
		8/4/2021,
		N'Đã phát hành',
		1,
		1,
		5.9,
		'Fullhd',
		'8/10',
		N'Mỹ',
		'Frank Grillo',
		'Joe Carnahan',
		N'Hành Động,  Kinh Dị,  Khoa Học,  Bí Ẩn',
		'8/4/2021',
		'tungnaa'
)

insert into FilmEpisode 
values (	'FE0002',
	'F0002',
	1,
	'https://scontent.ficn4-1.fna.fbcdn.net/v/t66.36240-6/10000000_283745736593465_3925803616385416825_n.mp4?_nc_cat=102&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=F44yUlLYBqwAX-YRhsg&_nc_ht=scontent.ficn4-1.fna&oh=d7094c806f515eefbf477b99cad74f6f&oe=609214D7'
)

insert into Film values ('F0003',
		N'Học viện quái vật: Du học sinh',
		'Cranston Academy: Monster Zone',
		'https://iphim.net/wp-content/uploads/2020/09/uploaded-phim_poster_hvqv_5_final_1__cr_500x700-250x350.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=XKod7ydEhd4',
		N'Phim xoay quanh câu chuyện về Danny Dawkins, một thần đồng trẻ tuổi nhưng chưa từng một lần được công nhận. Khi bất ngờ được nhận học bổng vào Học viện Cranston, một trường nội trú bí mật danh giá dành cho các thiên tài, Danny coi đó như một nơi mà trí thông minh của mình sẽ được công nhận và là nơi cuối cùng cậu có cơ hội nhập học',
		N'Phim xoay quanh câu chuyện về Danny Dawkins, một thần đồng trẻ tuổi nhưng chưa từng một lần được công nhận. Khi bất ngờ được nhận học bổng vào Học viện Cranston, một trường nội trú bí mật danh giá dành cho các thiên tài, Danny coi đó như một nơi mà trí thông minh của mình sẽ được công nhận và là nơi cuối cùng cậu có cơ hội nhập học. Tuy nhiên, cuộc sống trong một ngôi trường toàn thiên tài thật sự rất khắc nghiệt, nơi mà nếu bạn đạt 99% số điểm cũng coi như thất bại. Trong nhiệm vụ chứng minh trí thông minh của mình với các bạn trong trường, Danny đã vô tình mở ra một cánh cổng dẫn đến một chiều không gian khác ',
		8/4/2021,
		N'Đã phát hành',
		1,
		1,
		5.9,
		'Fullhd',
		'2/10',
		N'Mỹ',
		'Leopoldo Aguilar',
		'Ruby Rose',
		N'Hoạt Hình',
		'8/4/2021',
		'tungnaa'
)

insert into FilmEpisode 
values (	'FE0003',
	'F0003',
	1,
	'https://scontent-ssn1-1.xx.fbcdn.net/v/t66.36240-6/10000000_740199223320236_4493143621237622272_n.mp4?_nc_cat=109&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=5D_OH0lq5OEAX-LghgO&_nc_ht=scontent-ssn1-1.xx&oh=127452b69176686dbe9af72828f0784d&oe=60902BE5'
)
insert into Film values ('F0004',
		N'BỘ ĐÔI SẤM SÉT',
		'Thunder Force',
		'https://i.imgur.com/menYyYn.jpg',
		null,
		null,
				'https://www.youtube.com/watch?v=qnx6-YLXFwg',
		N'Đôi bạn thân thời thơ ấu tái hợp trong vai trò bộ đôi siêu anh hùng chống tội phạm bất đắc dĩ khi một người phát minh ra công thức giúp người thường sở hữu siêu năng lực.',
		N'Bộ Đôi Sấm Sét - Thunder Force (2021) lấy bối cảnh thế giới ngập tràn những tên khủng bố, siêu phản diện. Lúc này, một người phụ nữ đã phát triển công nghệ siêu năng lực cùng bạn thân của cô đã tạo thành tổ hợp siêu anh hùng chống tội phạm bất đắc dĩ. Nhiệm vụ đầu tiên của họ là chiến đấu với quái nhân Miscreants, cứu thành phố Chicago khỏi nanh vuốt của thế lực phản diện. Bộ phim do Ben Falcone đạo diễn, có sự góp mặt của các ngôi sao như: Jason Bateman, Bobby Cannavale, Pom Klementieff, Melissa McCarthy, Octavia Spencer.',
		8/4/2021,
		N'Đã phát hành',
		1,
		1,
		5.9,
		N'Fullhd',
		'3/10',
		N'Mỹ',
		'Ben Falcone',
		N' Bobby Cannavale',
		N'Phiêu Lưu, Hài Hước, Viễn Tưởng',
		'8/4/2021',
		'tungnaa'
)

insert into FilmEpisode 
values (	'FE0004',
	'F0004',
	1,
	'https://scontent-ssn1-1.xx.fbcdn.net/v/t66.36240-6/10000000_286823176448763_1165967509747599807_n.mp4?_nc_cat=101&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=SKxeRDjZ2M8AX_aHgo3&_nc_ht=scontent-ssn1-1.xx&oh=7153550f681e33bc5d023b28d3d258b5&oe=6096D807'
)

-------------------------------------
insert into Film values ('F0005',
		N'TRẢI NGHIỆM MA QUÁI: MỸ LATINH',
		N'Haunted: Latin America',
		'https://i0.wp.com/image.motphim.net/poster/trai-nghiem-ma-quai-my-latinh-8844.jpg?1617780793',
		null,
		null,
		'https://www.youtube.com/watch?v=HPJ1-nBhCuY',
		N'Những chuyện kinh hoàng có thật về các sự việc rùng rợn, không thể giải thích và huyền bí – tất cả được tái hiện sống động và kịch tính trong chương trình thực tế này',
		N'Những chuyện kinh hoàng có thật về các sự việc rùng rợn, không thể giải thích và huyền bí – tất cả được tái hiện sống động và kịch tính trong chương trình thực tế này',
		8/1/2020,
		N'Đã phát hành',
		5,
		5,
		4.6,
		'Fullhd',
		'5/10',
		N'Mỹ',
		'Becn Falcbone',
		' Eobby Cannale',
		N'Kinh Dị',
		'8/4/2021',
		'tungnaa'
)


insert into FilmEpisode values ( 	'FE0005','F0005',
		1,
		'https://scontent-frt3-2.xx.fbcdn.net/v/t66.36240-6/10000000_149897447044542_7571024020535224102_n.mp4?_nc_cat=101&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=AR8l6daNA3IAX_pNKk6&_nc_ht=scontent-frt3-2.xx&oh=9c27ac7d7b8d35b4c1848ef2c70c6e74&oe=6087F936'
)

insert into FilmEpisode values (	'FE0006','F0005',
		2,
		'https://scontent-frt3-1.xx.fbcdn.net/v/t66.36240-6/10000000_469664100841246_5701284371319676765_n.mp4?_nc_cat=107&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=7R5flOEjY1gAX9HGSSZ&_nc_ht=scontent-frt3-1.xx&oh=d435d55dd948b97222c367ab46886f23&oe=608845D3')
insert into FilmEpisode values ( 	'FE0007','F0005',
		3,
		'https://scontent-frx5-1.xx.fbcdn.net/v/t66.36240-6/10000000_259903959114968_1658478770196313591_n.mp4?_nc_cat=105&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=9W5Ojh-DvHIAX_VUUSX&_nc_oc=AQlmLVxFQv8D74iWk5WMtH0066wJs2GIn89267xT3-6tTGmodaRjKQP6DXqPIQG1MS4&_nc_ht=scontent-frx5-1.xx&oh=ccceba9a59cf32108c9797a239462435&oe=608A1288'
)

insert into FilmEpisode values (	'FE0008','F0005',
		4,
		'https://scontent-frt3-1.xx.fbcdn.net/v/t66.36240-6/10000000_295907745308136_3436091957629814697_n.mp4?_nc_cat=109&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=g4ezZ8ibrS0AX91iK4B&_nc_ht=scontent-frt3-1.xx&oh=084399a6c48a88997a6a969e9717017a&oe=60883AB1')

		insert into FilmEpisode values (	'FE0009','F0005',
		5,
		'https://scontent-frt3-2.xx.fbcdn.net/v/t66.36240-6/10000000_3205875392972343_7449868695557130406_n.mp4?_nc_cat=103&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=orDf-6ftdwMAX9Ys8yI&_nc_ht=scontent-frt3-2.xx&oh=b0153db2d7a30b914151e354c7ad2c8c&oe=60882B0B')


--------------------------------

insert into Film values ('F0006',
		N'MADAME CLAUDE',
		'MADAME CLAUDE',
		'https://i.vdicdn.com/ff/2021/04/02/7fd532e1ac70e0e3_0d309f738fb20cfe_338541617354030816068.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=OfWDTj5uLXQ',
		N'Ở Paris những năm 1960, tầm ảnh hưởng của Madame Claude vượt ra ngoài thế giới "bướm đêm" – cho đến khi một cô gái trẻ giàu có đe dọa thay đổi tất cả.',
		N'Ở Paris những năm 1960, tầm ảnh hưởng của Madame Claude vượt ra ngoài thế giới "bướm đêm" – cho đến khi một cô gái trẻ giàu có đe dọa thay đổi tất cả.',
		8/1/2020,
		N'Đã phát hành',
		5,
		5,
		4.6,
		'Fullhd',
		'5/10',
		N'Pháp',
		'Madame Claude',
		' Eobby  Claude',
		N'Tình Cảm,  Hình Sự,  Kịch Tính',
		'8/4/2021',
		'tungnaa'
)

insert into FilmEpisode 
values (
	'FE0010',
	'F0006',
	1,
	'https://scontent.fhkg1-1.fna.fbcdn.net/v/t66.36240-6/10000000_207179120745132_2592564757521892029_n.mp4?_nc_cat=108&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=1kbsyPpPZ9wAX-1g1TJ&_nc_ht=scontent.fhkg1-1.fna&oh=0e89278172dd17705018903e0b34eeea&oe=60911BFE')

insert into Film values ('F0007',
		N'SIÊU TRỘM',
		'Way Down / The Vault',
		'https://i.vdicdn.com/ff/2021/03/26/87773950d269313c_ff296f8198da69c1_412881616736843916068.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=L41IJiageyg',
		N'Ngân hàng Tây Ban Nha là một nơi bất khả xâm phạm, không một tên trộm nào có thể bước vào. Được xem như một nơi bí ẩn bậc nhất trên thế giới, ngân hàng này không có bản thiết kế, không dữ liệu lưu lại và không một ai biết đến cấu trúc sắp đặt bên trong chiếc két sắt hơn trăm năm tuổi',
		N'Ngân hàng Tây Ban Nha là một nơi bất khả xâm phạm, không một tên trộm nào có thể bước vào. Được xem như một nơi bí ẩn bậc nhất trên thế giới, ngân hàng này không có bản thiết kế, không dữ liệu lưu lại và không một ai biết đến cấu trúc sắp đặt bên trong chiếc két sắt hơn trăm năm tuổi. Thử thách này đã khơi dậy sự tò mò của Thom (Freddie Highmore) – một kỹ sư thiên tài quyết định thử đột nhập vào sâu bên trong nơi này và lật mở bí ẩn của chiếc két sắt. Mục tiêu của phi vụ lần này là một báu vật đã thất lạc từ lâu được ký gửi tại ngân hàng Tây Ban Nha trong vòng 10 ngày tới. Được dẫn dắt bởi bậc thầy dàn dựng Walter (Liam Cunningham), Thom và các cộng sự có đúng mười ngày để chuẩn bị cho vụ trộm. Họ phải thực hiện phi vụ thế kỷ cùng lúc với trận chung kết World Cup kéo dài 105 phút, thu hút sự theo dõi của hàng vạn người hâm mộ đến trước Ngân hàng Tây Ban Nha.',
		8/1/2020,
		N'Đã phát hành',
		1,
		1,
		4.6,
		'Fullhd',
		'4/10',
		N'Mỹ',
		'Madame ',
		N'Claude',
		N'Hành Động,  Phiêu Lưu,  Kinh Dị',
		'8/4/2021',
		'tungnaa'
)
insert into FilmEpisode 
values (	'FE0011',
	'F0007',
	1,
	'https://scontent-lax3-1.xx.fbcdn.net/v/t66.36240-6/10000000_270089864684811_5001892313282559797_n.mp4?_nc_cat=100&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=uAm33TVTinoAX9KcnfM&_nc_ht=scontent-lax3-1.xx&oh=8a758a39e9c2abcb69caab8530a5269d&oe=6081BD22')


insert into Film values ('F0008',
		N'PALM SPRINGS: MỞ MẮT THẤY HÔM QUA',
		' Palm Springs',
		'https://i.vdicdn.com/ff/2021/03/25/27ab3154afe0353f_6fb5877cad21aae2_521671616653912616068.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=CpBLtXduh_k',
		N'Mở Mắt Thấy Hôm Qua (tựa gốc: Palm Springs) – đúng như tên gọi, bộ phim là một vòng lặp bất tận của thời gian, với thật nhiều những rắc rối lặp đi lặp lại không có điểm dừng',
		N'Mở Mắt Thấy Hôm Qua (tựa gốc: Palm Springs) – đúng như tên gọi, bộ phim là một vòng lặp bất tận của thời gian, với thật nhiều những rắc rối lặp đi lặp lại không có điểm dừng. Anh chàng Nyles (Andy Samberg) và nàng phù dâu bất đắc dĩ Sarah (Cristin Milioti) tình cờ gặp nhau tại đám cưới ở Palm Springs, mọi thứ trở nên phức tạp khi Nyles và Sarah “mắc kẹt” mãi ở ngày vui của người khác. Trong khi Sarah điên cuồng tìm cách thoát ra thì Nyles bình thản chấp nhận sống lại ngày hôm qua thêm một lần nữa. Họ sẽ làm gì để có thể thoát khỏi nơi này, thoát khỏi những vấn đề của chính mình khi giờ đây còn “vướng” phải nhau nữa?',
		8/1/2020,
		N'Đã phát hành',
		1,
		1,
		4.6,
		'Fullhd',
		'9/10',
		N'Mỹ',
		'Cristin Milioti ',
		'Andy Samberg',
		N'Tình Cảm,  Hài Hước,  Viễn Tưởng,  Bí Ẩn',
		'8/4/2021',
		'tungnaa'
)
insert into FilmEpisode 
values (	'FE0012',
	'F0008',
	1,
	'https://scontent-lax3-1.xx.fbcdn.net/v/t66.36240-6/10000000_1092508161261519_3711152095548052722_n.mp4?_nc_cat=109&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=cy9E1xQlaSsAX-z7XEX&_nc_oc=AQm_FLdUWWr-YIxD024Qr5CxAEO8WPmV_CqcUjdjjnOL9xkL93lIm3IeJ-0FBGvXvAE&_nc_ht=scontent-lax3-1.xx&oh=9dc6d84a3e00b89c0fdba231ca7182b0&oe=6083D2AE')



insert into Film values ('F0009',
		'CHERRY',
		'CHERRY',
		'https://i.vdicdn.com/ff/2021/03/12/e16596b60ab99ee5_54ae360dba3f276a_294171615540175316068.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=H5bH6O0bErk',
		N'Cherry được lấy cảm hứng từ cuốn tiểu thuyết tự truyện cùng tên của Nico Walker kể câu chuyện của Cherry (23 tuổi, gốc Ohio - Mỹ), một chàng trai đau khổ sau khi tin rằng anh đã đánh mất tình yêu của đời mình với Emily (Ciara Bravo) nên nhập ngũ và phục vụ ở chiến trường Iraq.',
		N'Cherry được lấy cảm hứng từ cuốn tiểu thuyết tự truyện cùng tên của Nico Walker kể câu chuyện của Cherry (23 tuổi, gốc Ohio - Mỹ), một chàng trai đau khổ sau khi tin rằng anh đã đánh mất tình yêu của đời mình với Emily (Ciara Bravo) nên nhập ngũ và phục vụ ở chiến trường Iraq.
Cherry trở về nhà như một anh hùng nhưng cuộc đời anh nhanh chóng chuyển hướng khi các triệu chứng của PTSD (rối loạn căng thẳng sau chấn thương) làm mất khả năng nhận thức và anh sa vào nghiện ngập ma túy. Để có tiền thỏa mãn cơn nghiện, Cherry bắt đầu cướp ngân hàng. Bộ phim dõi theo cuộc đời của Cherry khi anh từ một sinh viên đại học thành một tên cướp ngân hàng. ',
		8/1/2020,
		N'Đã phát hành',
		1,
		1,
		4.6,
		N'Fullhd',
		'5/10',
		N'Mỹ',
		'Ciara Bravo',
		'Nico Walker',
		N'Hình Sự,  Kịch Tính',
		'8/4/2021',
		'tungnaa'
)
insert into FilmEpisode 
values (	'FE0013',
	'F0009',
	1,
	'https://scontent-lax3-1.xx.fbcdn.net/v/t66.36240-6/10000000_473325440373898_3922154281358194443_n.mp4?_nc_cat=108&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=ZKeOOkLjoIAAX9ijGOQ&_nc_ht=scontent-lax3-1.xx&oh=f5e11c68dcb38e6aa37317ba45674435&oe=6072C961')

insert into Film values ('F0010',
		N'ĐÊM NƠI THIÊN ĐƯỜNG',
		'Night in Paradise',
		'https://i.imgur.com/F1qOJ73.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=_Sm6_FK51VA',
		N'Trốn trên đảo Jeju sau một bi kịch thảm khốc, tay xã hội đen chịu bất công và bị truy đuổi tìm được sự kết nối với một người phụ nữ, và cô cũng có những mặt tối riêng.',
		N'Trốn trên đảo Jeju sau một bi kịch thảm khốc, tay xã hội đen chịu bất công và bị truy đuổi tìm được sự kết nối với một người phụ nữ, và cô cũng có những mặt tối riêng.',
		8/1/2020,
		N'Đã phát hành',
		1,
		1,
		4.6,
		'Fullhd',
		'1/10',
		N'Hàn Quốc',
		'Ciara',
		'Walker',
		N'Hình Sự,  Kịch Tính',
		'8/4/2021',
		'tungnaa'
)

insert into FilmEpisode 
values (	'FE0014',
	'F0010',
	1,
	'https://scontent-mrs2-2.xx.fbcdn.net/v/t66.36240-6/10000000_1296980724032693_6753926503337682891_n.mp4?_nc_cat=107&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=ktt5Hqi5VZQAX-JXpNa&_nc_ht=scontent-mrs2-2.xx&oh=88a532a24629015f4c6e5a397491aea1&oe=6096DB84')



insert into Film values ('F0011',
		N'HAI NGƯỜI XA LẠ',
		N'Two Distant Strangers',
		'https://i.vdicdn.com/ff/2021/04/10/97f218007ba05f8e_c989bc4ee396692d_362031618035742616068.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=j-67K-KwHbA',
		N'Trong phim ngắn được đề cử giải Oscar này, người đàn ông đang cố về nhà với chú chó của mình thì kẹt trong vòng lặp thời gian của vụ đụng độ chết chóc với một cảnh sát.',
		N'Trong phim ngắn được đề cử giải Oscar này, người đàn ông đang cố về nhà với chú chó của mình thì kẹt trong vòng lặp thời gian của vụ đụng độ chết chóc với một cảnh sát.',
		8/1/2020,
		N'Đã phát hành',
		1,
		1,
		4.6,
		'HD',
		'7/10',
		N'Mỹ',
		'Carter James',
		'Rohan Sharma',
		N'Khoa Học,  Kịch Tính',
		'7/4/2021',
		'tungnaa'
)

insert into FilmEpisode 
values (	'FE0015',
	'F0011',
	1,
	'https://scontent.fuio1-1.fna.fbcdn.net/v/t66.36240-6/10000000_502453787428236_6284848234213333213_n.mp4?_nc_cat=102&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=wAdiwUrWJsUAX8ykL8l&_nc_ht=scontent.fuio1-1.fna&oh=acf39211a8ea306b949e99855aaadef4&oe=6096BB01')


insert into Film values ('F0012',
		N'Phản Đòn Phần 4',
		'Strike Back Season 4',
		'https://i3.wp.com/bilugo.com/upload/images/2015/03/phan-don-phan-4-2013.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=oHhiKeyUnnI',
		N'Trước cuộc xâm lược Iraq năm 2003 không lâu, một đơn vị đặc biệt tiến hành một chiến dịch giải cứu con tin, trong đó có trung sĩ John Porter. Khi đang làm nhiệm vụ, Porter đã chạm trán, tước vũ khí và tha mạng một cậu bé đánh bom cảm tử có tên As’ad.',
		N'Trước cuộc xâm lược Iraq năm 2003 không lâu, một đơn vị đặc biệt tiến hành một chiến dịch giải cứu con tin, trong đó có trung sĩ John Porter. Khi đang làm nhiệm vụ, Porter đã chạm trán, tước vũ khí và tha mạng một cậu bé đánh bom cảm tử có tên As’ad. Chiến dịch giải cứu con tin diễn ra thành công nhưng cái giá phải trả là 2 binh sĩ thiệt mạng, một người bị đưa vào bệnh viện và sau đó sống trong tình trạng thực vật. Các chỉ huy cao cấp tin rằng việc Porter thả As’ad là nguyên nhân chính dẫn tới chiến dịch bại lộ, Porter bị ép giải ngũ.',
		8/11/2017,
		N'Đang phát hành',
		5,
		16,
		3.6,
		'Fullhd',
		'6/10',
		N'Mỹ',
		'Michael J. Bassett',
		'Rhashan Stone',
		N'Hành Động, Tâm Lý - Tình Cảm',
		'8/4/2021',
		'tungnaa'
)


insert into FilmEpisode values ( 	'FE0016','F0012',
		1,
		'https://scontent-hel3-1.xx.fbcdn.net/v/t66.36240-6/10000000_262941245487201_5472365384328747562_n.mp4?_nc_cat=107&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=37dicdkyDFAAX9yl0jh&_nc_ht=scontent-hel3-1.xx&oh=411cb5bf84c23bbeb82d0eaf928ab8bf&oe=608912CD'
)

insert into FilmEpisode values (	'FE0017','F0012',
		2,
		'https://scontent-hel3-1.xx.fbcdn.net/v/t66.36240-6/10000000_816955339171596_6662985126896739077_n.mp4?_nc_cat=101&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZF9tdXRlZCJ9&_nc_ohc=AoTLMvoEh4kAX-3pxOJ&_nc_ht=scontent-hel3-1.xx&oh=4eb8309e77b05a41e151d2d6c7703196&oe=60888F60'
		)
insert into FilmEpisode values (	'FE0018','F0012',
		3,
		'https://scontent-hel3-1.xx.fbcdn.net/v/t66.36240-6/10000000_141698777870971_8535536113557567204_n.mp4?_nc_cat=103&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=UTZMXMEDK2UAX-5Alcj&_nc_ht=scontent-hel3-1.xx&oh=98209db82a843ca459163410a5f23596&oe=608723F8'
)

insert into FilmEpisode values (	'FE0019','F0012',
		4,
		'https://scontent-hel3-1.xx.fbcdn.net/v/t66.36240-6/10000000_1346855159015211_5471943970704921914_n.mp4?_nc_cat=101&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=MqiKDw1MyzwAX9y2Ouz&_nc_oc=AQnOJE8xrWhyriHkUVnIPuJ9sJkNO2lQ2bhBMwGl74H5_TWTsVBwhbWEJt-WQmtcBsc&_nc_ht=scontent-hel3-1.xx&oh=84446c2967f85a63ec6a808952647cae&oe=6088AC53'
		)

insert into FilmEpisode values (	'FE0020','F0012',
		5,
		'https://scontent-hel3-1.xx.fbcdn.net/v/t66.36240-6/10000000_878244752969831_4193077302525968046_n.mp4?_nc_cat=109&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZF9tdXRlZCJ9&_nc_ohc=7eEIpoTXehUAX9G-ttM&_nc_ht=scontent-hel3-1.xx&oh=96db6f557a06cdc10166f7dec22ca5cc&oe=6088FD57'
		)
------------------------------------

insert into Film values ('F0013',
		N'Pacific Rim: Vùng Tối',
		'Pacific Rim: The Black',
		'https://i3.wp.com/bilugo.com/upload/images/2021/03/pacific-rim-vung-toi-2021_1617025871.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=umtOGzti-XQ',
		N'Sau khi Kaiju tàn phá nước Úc, hai anh em điều khiển một Jaeger để tìm kiếm cha mẹ, đồng thời bắt gặp những sinh vật mới, các nhân vật bất hảo và đồng minh tình cờ.',
		N'Sau khi Kaiju tàn phá nước Úc, hai anh em điều khiển một Jaeger để tìm kiếm cha mẹ, đồng thời bắt gặp những sinh vật mới, các nhân vật bất hảo và đồng minh tình cờ.',
		8/11/2021,
		N'Đang phát hành',
		4,
		7,
		7.6,
		N'Fullhd',
		'6/10',
		N'Mỹ',
		'Cole Keriazakos',
		'Leonardo',
		N'Viễn Tưởng, Phiêu Lưu',
		'8/4/2021',
		'tungnaa'
)


insert into FilmEpisode values (	'FE0021','F0013',
		1,
		'https://scontent-hel3-1.xx.fbcdn.net/v/t66.36240-6/10000000_122079523224039_5624902442204601079_n.mp4?_nc_cat=109&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=y5GNYIX03qcAX_l6lCg&_nc_ht=scontent-hel3-1.xx&oh=cd42241b6a70284cf0500a0662d11a42&oe=608863F6'
)

insert into FilmEpisode values ('FE0022','F0013',
		2,
		'https://scontent.fhel5-1.fna.fbcdn.net/v/t66.36240-6/10000000_273661710902006_8121327044851632562_n.mp4?_nc_cat=106&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZF9tdXRlZCJ9&_nc_ohc=atvAadTUiKoAX_xpoqZ&_nc_ht=scontent.fhel5-1.fna&oh=6a34a16582beba6fa5a4f4e22fd206bf&oe=608CBCBF'
		)
insert into FilmEpisode values ('FE0023','F0013',
		3,
		'https://scontent-hel3-1.xx.fbcdn.net/v/t66.36240-6/10000000_2957582897807254_818957294948435994_n.mp4?_nc_cat=105&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZF9tdXRlZCJ9&_nc_ohc=2DrOTaj-R4UAX-tfw8F&_nc_ht=scontent-hel3-1.xx&oh=9cef2b23f43192e188331779fcb8891a&oe=6089B0CC'
)

insert into FilmEpisode values ('FE0024','F0013',
		4,
		'https://scontent-hel3-1.xx.fbcdn.net/v/t66.36240-6/10000000_1346855159015211_5471943970704921914_n.mp4?_nc_cat=101&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=MqiKDw1MyzwAX9y2Ouz&_nc_oc=AQnOJE8xrWhyriHkUVnIPuJ9sJkNO2lQ2bhBMwGl74H5_TWTsVBwhbWEJt-WQmtcBsc&_nc_ht=scontent-hel3-1.xx&oh=84446c2967f85a63ec6a808952647cae&oe=6088AC53'
		)

------------------------------------

insert into Film values ('F0014',
		N'CAO BỒI ĐÔ THỊ',
		'Concrete Cowboy',
		'https://i.imgur.com/KXByY07.jpg',
		null,
		null,
		'https://www.youtube.com/watch?v=WZ3dgHqaw8U',
		N'Cao Bồi Đô Thị - Concrete Cowboy (2020) là bộ phim chính kịch do Ricky Staub đạo diễn, với phần kịch bản được chắp bút bởi Dan Walser và Staub dựa trên tiểu thuyết Ghetto Cowboy của Greg Neri.',
		N'Cao Bồi Đô Thị - Concrete Cowboy (2020) là bộ phim chính kịch do Ricky Staub đạo diễn, với phần kịch bản được chắp bút bởi Dan Walser và Staub dựa trên tiểu thuyết Ghetto Cowboy của Greg Neri. Nội dung phim xoay quanh một cậu bé 15 tuổi đến từ Detroit, cậu được gửi đến sống với người cha lạnh nhạt ucar mình ở Philadelphia. Cũng từ đây cậu nhóc nhiệt huyết bắt đầu tìm hiểu về văn hóa cưỡi ngựa và các cao bồi thành thị ở nơi cậu sống.',
		8/11/2021,
		N'Đã phát hành',
		1,
		1,
		9.6,
		'HD',
		'7/10',
		N'Mỹ',
		N'Lee Daniels',
		'Ricky Staub',
		N'Tâm Lý',
		'7/4/2021',
		'tungnaa'
)

insert into FilmEpisode 
values ('FE0026',
	'F0014',
	1,
	'https://scontent.fbkk7-3.fna.fbcdn.net/v/t66.36240-6/10000000_445840783190510_4498946339316857473_n.mp4?_nc_cat=100&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=R1h8jHr-qO8AX86JjFq&_nc_ht=scontent.fbkk7-3.fna&oh=ccf158401e338c48256543e7b389fda9&oe=60905183')


	insert into Film values ('F0015',
		N'THAM VỌNG THẾ GIỚI NGẦM',
		'Sky High',
		'https://i0.wp.com/image.motphim.net/poster/tham-vong-the-gioi-ngam-8847.jpg?1617781417',
		null,
		null,
		'https://www.youtube.com/watch?v=rG6AVqZ52c0',
		N'Tham Vọng Thế Giới Ngầm là một bộ phim hành động - tội phạm của Tây Ban Nha, do Daniel Calparsoro đạo diễn',
		N'Tham Vọng Thế Giới Ngầm là một bộ phim hành động - tội phạm của Tây Ban Nha, do Daniel Calparsoro đạo diễn. Câu chuyện bắt đầu sau khi người thợ cơ khí ở vùng ngoại ô Madrid Ángel phải lòng Estrella, và lao vào thế giới của những vụ trộm cắp. Đồng thời trở thành mục tiêu truy lùng của một thanh tra thám tử.',
		8/11/2020,
		N'Đã phát hành',
		1,
		1,
		8.6,
		'HD',
		'5/10',
		N'Mỹ',
		'Daniel Calparsoro',
		'Asia Ortega',
		N'Hành Động, Phiêu lưu',
		'7/4/2021',
		'tungnaa'
)

insert into FilmEpisode 
values ('FE0025',
	'F0015',
	1,
	'https://scontent-sjc3-1.xx.fbcdn.net/v/t66.36240-6/10000000_126904596067894_5532621075895636609_n.mp4?_nc_cat=105&ccb=1-3&_nc_sid=985c63&efg=eyJ2ZW5jb2RlX3RhZyI6Im9lcF9oZCJ9&_nc_ohc=6zWIbrD-jzoAX8fyF-x&_nc_ht=scontent-sjc3-1.xx&oh=49e1a5423b27b9b1788f5434a2e56767&oe=608B1D8D')


insert into Feedback 
values 
(
	'FB0001',
	'F0001',
	'ACC001',
	'chupamimonhanhooooooooooo',
	8/11/2020
)

insert into Feedback 
values 
(
	'FB0002',
	'F0001',
	'ACC001',
	'yamateeeeeeeeeeeeeeeeeeeeeeee',
	18/11/2020
)

insert into Feedback 
values 
(	'FB0003',
	'F0001',
	'ACC001',
	'ynokooaaeeeeeeeeeeeeeeeee',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0004',
	'F0002',
	'ACC002',
	'kimonhanhooooooooooo',
	18/11/2020
)

insert into Feedback 
values 
(	'FB0005',
	'F0005',
	'ACC004',
	'makiiaanhooooooooooo',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0006',
	'F0011',
	'ACC001',
	'skanawwacc',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0007',
	'F0012',
	'ACC002',
	'skrrrrrrrrrrrrrrrrr',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0008',
	'F0015',
	'ACC003',
	'lolaaaaaaaaaaa',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0009',
	'F0011',
	'ACC001',
	'hay qua',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0010',
	'F0005',
	'ACC003',
	'ko hay',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0011',
	'F0007',
	'ACC003',
	'qua da',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0012',
	'F0011',
	'ACC002',
	'chu choa',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0013',
	'F0005',
	'ACC003',
	'cha ra gi',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0014',
	'F0004',
	'ACC001',
	'chat',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0015',
	'F0009',
	'ACC003',
	'cka cha',
	8/11/2020
)

insert into Feedback 
values 
(	'FB0016',
	'F0013',
	'ACC003',
	'lolaaaaaaaaaaa',
	8/11/2020
)

