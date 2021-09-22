CREATE DATABASE MyWebForum
ON PRIMARY
(
	NAME='MyWebForum',
	FILENAME='F:\sqlserver databases\MyWebForum\MyWebForum.mdf',
	SIZE=5MB,
	MAXSIZE=500MB,
	FILEGROWTH=10MB
)
LOG ON
(
	NAME='MyWebForum_Log',
	FILENAME='F:\sqlserver databases\MyWebForum\MyWebForum_Log.ldf',
	SIZE=2MB,
	FILEGROWTH=1MB
)

go

--GO
--USE MyWebForum;
--CREATE TABLE FORUMS
--(
--	fno int primary key,
--	title varchar(20),
--	content_no int,
--	preview varchar(20)
--	status 
--	catagroy_no,
--	section_no,
--	excellent,
--	browse_count,
--	thumbs_up_count
--	comment_count
--)
--CREATE TABLE COMMENT
--(
--	comment_no int primary key,
--	comment varchar(100),
--	user_no int
--	comment_time
--	thumbs_up_count,
--	reply_count
--)
--CREATE TABLE REPLY
--(
--	content_no int,
--	user_no int,
--	content varchar(50),
	
--)
--CREATE TABLE REPLY
USE MyWebForum
CREATE TABLE USERPROFILE
(
	profile_no int primary key  nonclustered identity,--用户内部代码，作为主键
	user_no int unique clustered,
	reg_time datetime,--注册日期
	sex binary(1),--性别
	avatar varbinary(max) ,--头像
	introduction nvarchar(50) ,--简介
	integral int ,--积分
)
USE MyWebForum
CREATE TABLE USERACCOUNT
(
	user_no int primary key nonclustered identity,--用户内部代码，作为主键
	uer_name nvarchar(10) unique clustered,--用户名称,设置聚集索引
	user_nickname nvarchar(10),--昵称
	reg_time datetime,--注册日期
	--rank_id binary(3)--权限
)
go