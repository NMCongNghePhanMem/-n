create procedure GetLatestSoKhachToiDaTrongPhong
as
begin
	select top 1 SoKhachToiDa from THAMSO ORDER BY THAMSO.ma DESC 
end
go


create procedure CapNhapSoKhachToiDaTrongPhong
	@SoKhach int
as
begin
	update THAMSO set SoKhachToiDa =@SoKhach 
	where Ma >= ALL(select Ma FROM THAMSO)
end
go

create procedure GetLatestTyLePhuThu
as
begin
	select top 1 THAMSO.TiSoPhuThu from THAMSO ORDER BY Ma DESC 
end
go

create procedure CapNhapTyLePhuThu
	@TyLe float
as
begin
	UPDATE THAMSO SET TiSoPhuThu =@TyLe WHERE Ma >=ALL(SELECT Ma FROM THAMSO)
end
go

select * from THAMSO
select * from LOAIKHACHHANG


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

