create database QuanLyQuanCafe
go
--drop database QuanLyQuanCafe
use QuanLyQuanCafe
go

--Table NhanVien
create table nhanvien
(
	manv varchar(50) primary key not null,
	tennv nvarchar(50) not null,
	gioitinh nvarchar(10) not null,
	macv varchar(10) not null,
	ngayvaolam Date default getdate(),
	diachi nvarchar(1000) not null,
	sdt varchar(10) not null,
	phanquyen tinyint default 0 not null, --2:quanly, 1:admin, 0:staf
	matkhau nvarchar(1000) default N'cfcd208495d565ef66e7dff9f98764da' not null --mặc định mật khẩu ban đầu=0;
)
go
--drop table nhanvien

--Table KhachHang
create table khachhang
(
	makh int identity primary key not null,
	malkh varchar(50) not null,
	tenkh nvarchar(50) not null,
	diachikh nvarchar(200) not null default N'chưa có thông tin',
	sdt varchar(10) not null,
	diemtl int not null,
)
go
--drop table khachhang

--Table LoaiKhachHang
create table loaikhachhang
(
	malkh varchar(50) primary key not null,
	tenlkh nvarchar(50) not null,
	giamgia int not null,
)
go
--drop table loaikhachhang

--Table Ban
create table ban
(
	maban int identity primary key not null,
	tenban nvarchar(100) not null default N'chưa đặt tên',
	trangthai nvarchar(100) not null default N'trống',
)
go
--drop table ban

--Table HangHoa
create table hanghoa
(
	mahh varchar(50) primary key not null,
	tenhh nvarchar(150) not null default N'chưa đặt tên',
	malh varchar(50) not null,
	giasp int not null
)
go
--drop table hanghoa

--Table LoaiHangHoa
create table loaihanghoa
(
	malh varchar(50) primary key not null,
	tenlh nvarchar(150) not null default N'chưa đặt tên',
	mota nvarchar(150) not null
)
go
--drop table loaihanghoa

--Table CalamViec
create table calamviec
(
	maclv varchar(50) primary key not null,
	tenclv nvarchar(50) not null,
	giobd time(0) not null,
	giokt time(0) not null,
	sotien int not null
)
go
--drop table calamviec

--Table HoaDonBanHang
create table hoadon
(
	mahd int identity primary key not null,
	manv varchar(50) not null,
	maban int not null,
	ngayhd datetime not null default getdate(),
	ngaytt datetime default getdate(),
	trangthai int not null,
	makh int,
	tongthanhtien decimal default 0 not null
)
go
--drop table hoadon

--Table chitiethoadon
create table chitiethoadon
(
	macthd int identity primary key not null,
	mahd int not null,
	mahh varchar(50) not null,
	soluong int not null
)
go
--drop table chitiethoadon

--Table chitietluong
create table chitietluong
(
	maclv varchar(50) not null,
	manv varchar(50) not null,
	ngaylam datetime not null default getdate(),
	thanhtien int not null
)
go
--drop table chitietluong
create table chucvu
(
	macv varchar(10) primary key not null,
	tencv nvarchar(100) not null
)
go


--Khóa ngoại
-- table khach hang
alter table khachhang add constraint fk_khachhang_loaikhachhang foreign key (malkh) references loaikhachhang(malkh)
--table hang hoa
alter table hanghoa add constraint fk_hanghoa_loaihanghoa foreign key (malh) references loaihanghoa(malh)
--table hoa don
alter table hoadon add constraint fk_hoadon_nhanvien foreign key (manv) references nhanvien(manv)
alter table hoadon add constraint fk_hoadon_ban foreign key (maban) references ban(maban)
alter table hoadon add constraint fk_hoadon_khachhang foreign key (makh) references khachhang(makh)
--table chi tiet hoa don
 alter table chitiethoadon add constraint fk_chitiethoadon_hoadon foreign key (mahd) references hoadon(mahd)
 alter table chitiethoadon add constraint fk_chitiethoadon_hanghoa foreign key (mahh) references hanghoa(mahh)
--table chi tiet luong
alter table chitietluong add mactluong int identity not null
alter table chitietluong add constraint chitietluong_pk primary key (mactluong)
alter table chitietluong add constraint fk_chitietluong_nhanvien foreign key (manv) references nhanvien(manv)
alter table chitietluong add constraint fk_chitietluong_calamviec foreign key (maclv) references calamviec(maclv)
 --table nhan vien
alter table nhanvien add constraint fk_nhanvien_chucvu foreign key (macv) references chucvu(macv)
go
create proc usp_doiban
@maban1 int,@maban2 int ,@manv varchar(50)
as begin
	declare @mahd1 int
	declare @mahd2 int

	select @mahd1=mahd from hoadon where maban=@maban1 and trangthai=0
	select @mahd2=mahd from hoadon where maban=@maban2 and trangthai=0
	 
	 if(@mahd1 is null)
	 begin
		insert into hoadon(manv,maban,ngayhd,ngaytt,trangthai) values(@manv,@maban1,getdate(),null,0)
		update ban set trangthai=N'Có người' where maban=@maban1
		select @mahd1= max(mahd)from hoadon where maban=@maban1 and trangthai=0
	 end
	 if(@mahd2 is null)
	 begin
		insert into hoadon(manv,maban,ngayhd,ngaytt,trangthai) values(@manv,@maban2,getdate(),null,0)
		update ban set trangthai=N'Có người' where maban=@maban2
		select @mahd2= max(mahd)from hoadon where maban=@maban2 and trangthai=0
	 end

	select macthd into bangmacthoadon from chitiethoadon where mahd= @mahd1 
	
	update chitiethoadon set mahd = @mahd2 where mahd =@mahd1
	update chitiethoadon set mahd= @mahd2 where macthd in (select * from bangmacthoadon)
	 
	drop table bangmacthoadon
end
go

USE master;
ALTER DATABASE QuanLyQuanCafe
SET RECOVERY FULL;
