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
	profile_no int primary key  nonclustered identity,--�û��ڲ����룬��Ϊ����
	user_no int unique clustered,
	reg_time datetime,--ע������
	sex binary(1),--�Ա�
	avatar varbinary(max) ,--ͷ��
	introduction nvarchar(50) ,--���
	integral int ,--����
)
USE MyWebForum
CREATE TABLE USERACCOUNT
(
	user_no int primary key nonclustered identity,--�û��ڲ����룬��Ϊ����
	uer_name nvarchar(10) unique clustered,--�û�����,���þۼ�����
	user_nickname nvarchar(10),--�ǳ�
	reg_time datetime,--ע������
	--rank_id binary(3)--Ȩ��
)
go