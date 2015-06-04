use QUANLYKHACHSAN
CREATE PROCEDURE GetPhongByMaPhong
	@MaPhong varchar(10)
AS
BEGIN
	select MaPhong,PHONG.MaLoaiPhong,DonGia,TinhTrangPhong,GhiChu from PHONG join LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong where MaPhong =@MaPhong
END
go

CREATE PROCEDURE GetDanhMucPhong
as
begin
	select MaPhong,PHONG.MaLoaiPhong,DonGia,TinhTrangPhong,GhiChu from PHONG join LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
end
go


--------------------------
CREATE PROCEDURE TraCuuPhong 
	@PHONG VARCHAR(10),
	@LOAIPHONG VARCHAR(10),
	@TINHTRANG BIT,
	@MINGIA money,
	@MAXGIA money
AS
BEGIN 
	DECLARE @isRunPhg bit,
			@isRunLoaiPhong bit,
			@isRunTTrg bit
		
	SET @isRunLoaiPhong =0
	SET @isRunPhg =0
	SET @isRunTTrg =0

	IF (@PHONG != '')
	BEGIN
		SELECT MaPhong, PHONG.MaLoaiPhong, DonGia, TinhTrangPhong INTO A
		FROM PHONG JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
		WHERE MaPhong like @PHONG
		
		select * into RESULT FROM A
		drop table A
		set @isRunPhg = 1
	END
	IF(@TINHTRANG = 0 OR @TINHTRANG =1)
	BEGIN
		IF(@isRunPhg = 1)
		begin
			SELECT * INTO A
			FROM RESULT
			WHERE TinhTrangPhong = @TINHTRANG
			drop table RESULT
			select * into RESULT FROM A
			drop table A

		end
		ELSE
		begin
			SELECT MaPhong, PHONG.MaLoaiPhong, DonGia, TinhTrangPhong INTO A
			FROM PHONG JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
			WHERE TinhTrangPhong = @TINHTRANG
			select * into result from A
			drop table A
		end
		
		set @isRunTTrg = 1
	END
	
	-- LOAI PHONG
	IF(@LOAIPHONG != '')
	BEGIN
		IF(@isRunPhg = 1 OR @isRunTTrg =1)
		BEGIN
			SELECT * INTO A FROM RESULT WHERE MaLoaiPhong =@LOAIPHONG
			drop table RESULT
			select * into result from A
			drop table A
		END
		ELSE
		BEGIN
			SELECT MaPhong, PHONG.MaLoaiPhong, DonGia, TinhTrangPhong INTO A
			FROM PHONG JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
			WHERE LOAIPHONG.MaLoaiPhong = @LOAIPHONG
			SELECT * INTO RESULT FROM A
			DROP TABLE A
		END
		--drop table RESULT
		
		SET @isRunLoaiPhong =1
	END
	--DON GIA
	IF(@isRunLoaiPhong =1 OR @isRunTTrg =1 OR @isRunPhg =1)
	BEGIN
		SELECT *  FROM RESULT WHERE DonGia<=@MAXGIA AND DonGia >=@MINGIA
		DROP TABLE RESULT
	END
	ELSE
	BEGIN
		SELECT MaPhong, PHONG.MaLoaiPhong, DonGia, TinhTrangPhong 
		FROM PHONG JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
		WHERE DonGia<=@MAXGIA AND DonGia >=@MINGIA
		
	END	
END


drop table RESULT
drop table A
select* from result
select * from a


drop procedure TRACUUPHONG

create procedure GetLoaiPhongByID
	@ID varchar(10)
as
begin
	select * from LOAIPHONG where MaLoaiPhong = @ID
end
GO


create procedure GetDanhMucLoaiPhong
as
begin
	Select* from LOAIPHONG 
end
GO


create procedure GetDonGiaLonNhat
as
begin
	select DonGia From LOAIPHONG Where DonGia>= ALL (Select DonGia From LOAIPHONG )
end
GO


create procedure GetLoaiKhachById
	@ID varchar(10)
as
begin
	select* from LOAIKHACHHANG where LOAIKHACHHANG.MaLoaiKhachHang=@ID
end
GO

create procedure GetDanhMucLoaiKhachHang
as
begin
	select * from LOAIKHACHHANG
end
GO

create procedure ThemLoaiKhachHang
	@ID varchar(10) ,
	@TenLoaiKhach nvarchar(50)
as
begin
	insert into LOAIKHACHHANG VALUES(@ID,@TenLoaiKhach) 
end
GO

create procedure XoaLoaiKhachHang
	@MaLoaiKhach varchar(10)
as
begin
	DELETE FROM LOAIKHACHHANG WHERE MaLoaiKhachHang = @MaLoaiKhach
end
GO




Create PROCEDURE CapNhapLoaiKhachHang
	@MaLoaiKhach Varchar(10),
	@LoaiKhach Nvarchar(50)
as
begin
	UPDATE LOAIKHACHHANG
	SET TenLoaiKhachHang = @LoaiKhach
	where MaLoaiKhachHang = @MaLoaiKhach
end
go

drop procedure CAPNHAPLOAIKHACHHANG

CREATE PROCEDURE ThemLoaiPhong
	@MaLoaiPhong varchar(10),
	@DonGia money
as
begin
	INSERT INTO LOAIPHONG values(@MaLoaiPhong,@DonGia);
end
go
---xoa loaiphong
create procedure XoaLoaiPhong
	@MaLoaiPhong varchar(10)
as
begin
	DELETE FROM LOAIPHONG where MaLoaiPhong = @MaLoaiPhong
end
go
-- Cap nhap loai phong
CREATE PROCEDURE CapNhapDonGia
	@MaLoaiPhong varchar(10),
	@DonGia money
as
begin
	update LOAIPHONG
	SET  DonGia = @DonGia
	where MaLoaiPhong = @MaLoaiPhong
end
go


select* from PHONG join LOAIPHONG on phong.MaLoaiPhong= loaiphong.MaLoaiPhong where  phong.MALOAIPHONG = 'VIP01'

select * from loaikhachhang

select* from LOAIPHONG 
delete from LOAIPHONG where MaLoaiPhong = '01'
select * from PHONG

insert into LOAIKHACHHANG values('NoiDia1',N'Khách Nội Địa')


Alter Table LOAIPHONG 
alter column DonGia Money not null

use QUANLYKHACHSAN
select * from LOAIKHACHHANG

insert into LOAIKHACHHANG values(' DoanhNhan ','Doanh Nhan a')

select * from THAMSO

insert into THAMSO values(1.5,3,2,0.25)
insert into THAMSO values(1.5,3,4,0.25)

create procedure GetLatestSoKhachToiDaTrongPhong
as
begin
	select top 1 SoKhachToiDa from THAMSO ORDER BY STT DESC 
end
go
drop procedure GetLatestSoKhachToiDaTrongPhong
create procedure CapNhapSoKhachToiDaTrongPhong
	@SoKhach int
as
begin
	update THAMSO set SoKhachToiDa =@SoKhach 
	where STT >= ALL(select STT FROM THAMSO)
end
go

create procedure GetLatestTyLePhuThu
as
begin
	select top 1 THAMSO.TiLePhuThu from THAMSO ORDER BY STT DESC 
end
go

create procedure CapNhapTyLePhuThu
	@TyLe float
as
begin
	UPDATE THAMSO SET TiLePhuThu =@TyLe WHERE STT >=ALL(SELECT STT FROM THAMSO)
end
go

select * from THAMSO
delete from THAMSO where stt>=5