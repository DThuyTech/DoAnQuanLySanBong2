create database QLSB
use  QLSB
create table LoaiSan(
	maloai int identity (1,1) primary key,
	tenloai nvarchar (10),
	giatien decimal(18,0)
)

create table San(
	masan int identity(1,1)  primary key,
	tensan nvarchar(10),
	trangthai bit default 0,
	maloai int references LoaiSan(maloai)
)

create table Acount(
	idtaikhoan int identity (1,1) primary key,
	username varchar(20) not null,
	pass varchar(20) not null,
)





create table KhachHang(
	makhachhang int identity(1,1) primary key,
	tenkhachhang nvarchar(35) not null,
	sdt varchar(11),
	cccd varchar(20)
)

create table HoaDon(
	mahoadon int identity(1,1) primary key,
	ngaylap date,
	giobatdau datetime,
	gioketthuc datetime,
	makhachhang int references KhachHang(makhachhang),
	tongtien decimal (18,0)
)

create table CTHD(
	mahoadon int references HoaDon(mahoadon),
	masan int references San(masan),
	tienmotsan decimal(18,0)
)

create table Phieudatsan(
	mapds int identity(1,1) primary key,
	makhachhang int references KhachHang(makhachhang),
	masan int references San(masan),
	tiencoc float,
	ngaydat datetime,
	giodat float,
	giotra float,

)
--insert into Account
insert into Acount values (N'huy1','huytrung23');

--insert into Loaisan
insert into LoaiSan values(N'5',100000);
insert into LoaiSan values(N'7',150000);
insert into LoaiSan values(N'7',150000);
insert into LoaiSan values(N'7',150000);

--insert into San
insert into San values(N'San 1',0,1)
insert into San values(N'San 2',0,1)
insert into San values(N'San 3',0,2)
insert into San values(N'San 4',0,2)
insert into San values (N'San 5',0,1)

--query
select * from Acount

select * from San

select * from LoaiSan 
delete from San where masan = '2'

select * from Acount where username	=N'huy1' and pass = N'huytrung23'

create proc USP_getsanbonglist
as select * from San
go

exec USP_getsanbonglist

create proc USP_insertsan
@Tensan nvarchar(10), @Trangthai int,@Maloai decimal
as
begin
	insert San  (tensan,trangthai,maloai)
	values (@Tensan,@Trangthai,@Maloai)
	end
	go

exec USP_insertsan N'San 6' , 0,3
--fix
alter table San
drop column giatien

alter table loaiSan
add giatien  decimal(18,0) 

alter table San 
add maloai int references (maloai)

SET IDENTITY_INSERT [dbo].[san] ON
GO

INSERT INTO [dbo].[San] ( [masan], [tensan], [trangthai] )
VALUES (  '3', 0, 1 )
GO

-- loaisan ,san, account, khachhang, phieudatsan, hoadon,cthd, insert loaisan,insert san,insert account,
create proc proc_doiMatKhau
@tendangnhap varchar(20), @matkhaucu varchar(20), @matkhaumoi varchar(20)
as 
update Acount set pass = @matkhaumoi where pass = @matkhaucu and username = @tendangnhap

exec proc_doiMatKhau N'huy1',N'huytrung23', N'1256l'

drop proc proc_doiMatKhau2

create proc proc_doiMatKhau2
@tendangnhap varchar(20), @matkhaucu varchar(20), @matkhaumoi varchar(20)
as 
begin
if not exists (select * from Acount where pass like @matkhaucu and username like @tendangnhap)
	print N'Mật khẩu hoặc tên đăng nhập chưa đúng. Vui lòng nhập lại.'
else
	update Acount set pass = @matkhaumoi where pass = @matkhaucu and username = @tendangnhap
end

drop proc proc_kiemTraTK

create proc proc_kiemTraTK
@tendangnhap varchar(20),
@matkhaucu varchar(20)
as
if exists (select * from Acount where pass = @matkhaucu and username = @tendangnhap)
	return 1
else return 0



create function func_KiemTraTK(@tendangnhap varchar(20),
@matkhaucu varchar(20))
returns int
as
begin
declare @kt int;

if exists (select * from Acount where pass = @matkhaucu and username = @tendangnhap)
	set @kt = 1
else
	set @kt = 0
return @kt
end

select * from Acount

exec proc_doiMatKhau2 N'huy1',N'qwerty', N'khacloc1'
