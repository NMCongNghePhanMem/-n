-----------  Nhật----------------------
------------- TABLE Hóa đơn : ****

-- 1. THEM  INSERT: 
alter procedure THEMHOADON
	@MaHoaDon VARCHAR(10),
	@NgayThanhToan SMALLDATETIME,
	@TenKhachHang NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@TongChiTietThanhToan MONEY
as
begin
insert into HOADON
values (@MaHoaDon,@NgayThanhToan,@TenKhachHang,@DiaChi,@TongChiTietThanhToan)

end
go

-- 2. XOA  DELETE: 
create procedure XOAHOADON
	@MaHoaDon VARCHAR(10)
as
begin

if(not exists (select * from HoaDon where MaHoaDon = @MaHoaDon))
begin  
print N'Ma hoa don ' + @MaHoaDon + N' không tồn tại'
return -1
end

delete from HOADON
where MaHoaDon = @MaHoaDon

end
go
-- 3. SUA  UPDATE: 
create procedure CAPNHATHOADON
	@MaHoaDon VARCHAR(10),
	@NgayThanhToan SMALLDATETIME,
	@TenKhachHang NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@TongChiTietThanhToan MONEY
as
begin

if(not exists (select * from HOADON where MaHoaDon = @MaHoaDon))
begin  
print N'Ma hoa don ' + @MaHoaDon + N' không tồn tại'
return -1
end

update HOADON
set NgayThanhToan= @NgayThanhToan, TenKhachHang = @TenKhachHang,
	DiaChi = @DiaChi,TongChiTietThanhToan= @TongChiTietThanhToan
where MaHoaDon = @MaHoaDon

end
go
-- 4. TRẢ VỀ "NgayThanhToan(NGÀY LẬP HD)" ĐỂ TÍNH "SỐ NGÀY THUÊ" CHO CTHD: // cho 1 hóa đơn nhất định
create procedure NGAYTHANHTOAN
	@MaHoaDon varchar(10)
as
begin
if(not exists (select * from HoaDon where MaHoaDon = @MaHoaDon))
begin  
print N'Ma hoa don ' + @MaHoaDon + N' không tồn tại'
return -1
end

select NgayThanhToan
from HOADON
where MaHoaDon = @MaHoaDon
end
go

-- 5. Trả về hóa đơn của ngày hiện tại
create procedure LAYHOADONNGAYHIENTAI
as
begin
select * from HOADON where convert(date,NgayThanhToan,0) = convert(date,GETDATE(),0)
end
go

exec LAYHOADONNGAYHIENTAI
select  top 1 MaHoaDon from HOADON ORDER By MaHoaDon DESC
------------- TABLE DETAILBILL: ******

-- // ĐƠN GIÁ TRONG CHI TIẾT HÓA ĐƠN = ĐƠN GIÁ THUÊ TRONG PTP x HỆ SỐ TÙY THEO LOẠI KHÁCH HÀNG

-- 1. THEM  INSERT: 
create procedure THEMCHITIETHOADON
	@MaHoaDon VARCHAR(10) ,
	@MaPhieuThue VARCHAR(10) ,
	@SoNgayThue INT,
	@DonGia MONEY,
	@ThanhTien MONEY
as
begin

if(not exists (select * from HOADON where MaHoaDon = @MaHoaDon))
begin  
print N'Ma hoa don ' + @MaHoaDon + N' không tồn tại'
return -1
end

if(not exists (select * from PHIEUTHUEPHONG where MaPhieuThue = @MaPhieuThue))
begin  
print N'Ma phiếu thuê phòng ' + @MaPhieuThue + N' không tồn tại'
return -1
end

insert into CHITIETHOADON
values (@MaHoaDon,@MaPhieuThue,@SoNgayThue,@DonGia,@ThanhTien)
end
go

-- 2. XOA  DELETE: 
create procedure XOACHITIETHOADON
	@MaHoaDon VARCHAR(10) ,
	@MaPhieuThue VARCHAR(10) 
as
begin

if(not exists (select * from HOADON where MaHoaDon = @MaHoaDon))
begin  
print N'Ma hoa don ' + @MaHoaDon + N' không tồn tại'
return -1
end

if(not exists (select * from PHIEUTHUEPHONG where MaPhieuThue = @MaPhieuThue))
begin  
print N'Ma phiếu thuê phòng ' + @MaPhieuThue + N' không tồn tại'
return -1
end

delete from CHITIETHOADON
where MaHoaDon = @MaHoaDon and MaPhieuThue= @MaPhieuThue
end
go

-- 3. SUA  UPDATE: 
-- dung 2 biet MaHoaDonold va Maformold de luu gia tri tu textbox cua dong can sua
-- xac dinh duoc vi tri cua dong can sua trong database, roi update tat ca lai
create procedure CAPNHATCHITIETHOADON
	@MaHoaDon VARCHAR(10) ,
	@MaPhieuThue VARCHAR(10) ,
	@SoNgayThue INT,
	@DonGia MONEY,
	@ThanhTien MONEY,
	@MaHoaDonOLD varchar(10),
	@MaPhieuThueOLD varchar(10)
as
begin

if(not exists (select * from HOADON where MaHoaDon = @MaHoaDon))
begin  
print N'Ma hoa don ' + @MaHoaDon + N' không tồn tại'
return -1
end

if(not exists (select * from PHIEUTHUEPHONG where MaPhieuThue = @MaPhieuThue))
begin  
print N'Ma phiếu thuê phòng ' + @MaPhieuThue + N' không tồn tại'
return -1
end

update CHITIETHOADON
set MaHoaDon = @MaHoaDon, MaPhieuThue = @MaPhieuThue, SoNgayThue = @SoNgayThue,DonGia = @DonGia,ThanhTien = @ThanhTien
where MaHoaDon = @MaHoaDonOLD and MaPhieuThue = @MaPhieuThueOLD
end
go

-- 4. TRẢ VỀ SỐ NGÀY THUÊ = CÁCH: LẤY NGÀY LẬP TRONG BẢNG BILL - NGÀY BẮT ĐẦU THUÊ [DATERESERVATION]

create procedure SONGAYTHUE
	@MaHoaDon varchar(10),
	@SoNgayThue int out
as
begin
declare @daybegin smalldatetime
declare @dayend smalldatetime

select @daybegin = NgayThue
from PHIEUTHUEPHONG as rrf inner join CHITIETHOADON as db
	on rrf.MaPhieuThue = db.MaPhieuThue
where db.MaHoaDon = @MaHoaDon

select @dayend = NgayThanhToan
from HOADON
where MaHoaDon = @MaHoaDon

set @SoNgayThue = convert(int,(@dayend - @daybegin),1)
end
go

declare @SoNgayThue int
exec SONGAYTHUE '1',@SoNgayThue out
print @SoNgayThue
-- 5. TRẢ VỀ ĐƠN GIÁ = CÁCH: LẤY SỐ LOẠI KHÁCH THUÊ [PHẦN 5  BẢNG PTP] --> == 2 THÌ = ĐƠN GIÁ THUÊ(TRONG BẢNG PTP) * TỶ SỐ PHỤ THU(125%)
                                                                        --> == 1 THÌ = ĐƠN GIÁ THUÊ(TRONG BẢNG PTP) * TỶ SỐ PHỤ THU(100%)
--- mới chỉnh sửa
alter procedure DONGIA
	@MaHoaDon varchar(10),
	@MaPhieuThue varchar(10),
	@DonGia money out
as
begin
select @DonGia = p.DonGia 
from CHITIETHOADON as c inner join PHIEUTHUEPHONG as p
	on c.MaPhieuThue = p.MaPhieuThue
where MaHoaDon = @MaHoaDon and c.MaPhieuThue = @MaPhieuThue
end
go

-- 6. TRẢ VỀ THÀNH TIỀN (SỐ NGÀY THUÊ[AMOUNTRESERVATION] * ĐƠN GIÁ [DonGia])
create procedure THANHTIENCTHD
	@SoNgayThue int,
	@DonGia money,
	@ThanhTien money out
as
begin
set @ThanhTien = @SoNgayThue * @DonGia
end
go

alter procedure MaPhieuThueKhongTonTaiCTHD
@MaPhong varchar(10),
@NgayThanhToan smalldatetime
as
begin
--declare @MaPhieuThue varchar(10)
--select p.MaPhieuThue
select top 1 p.MaPhieuThue
from PHIEUTHUEPHONG as p left join CHITIETHOADON as c
on p.MaPhieuThue = c.MaPhieuThue
where p.MaPhong = @MaPhong and NgayThue < @NgayThanhToan
order by NgayThue desc
end
go

set dateformat dmy

exec MaPhieuThueKhongTonTaiCTHD '07','29/5/2015'
go
---THEM moi----
--------------------------
--------------------------
create procedure LayThongTinCTHDVaPTP
@MaHoaDon varchar(10)
as
begin
select MaPhong, SoNgayThue, p.DonGia, ThanhTien, p.MaPhieuThue
from PHIEUTHUEPHONG as p inner join CHITIETHOADON as c
on p.MaPhieuThue = c.MaPhieuThue
where c.MaHoaDon = @MaHoaDon
end
go

create procedure XOATATCACHITIETHOADON
	@MaHoaDon VARCHAR(10) 
as
begin
delete from CHITIETHOADON
where MaHoaDon = @MaHoaDon
end
go
------------- TABLE REPORTMONTH:

-- 1. THEM  INSERT: 
create procedure ThemBaoCaoThang
	@MaBaoCao VARCHAR(10) ,
	@Thang int ,
	@Nam INT,
	@TongDoanhThu MONEY
as
begin

if(exists (select * from BAOCAO where MaBaoCao = @MaBaoCao))
begin  
return -1
end

insert into BAOCAO
values (@MaBaoCao,@Thang,@Nam,@TongDoanhThu)
end
go
-- 2. XOA  DELETE: 
create procedure XoaBaoCaoThang
	@MaBaoCao VARCHAR(10) 
as
begin

if(not exists (select * from BAOCAO where MaBaoCao = @MaBaoCao))
begin  
return -1
end

delete from BAOCAO
where MaBaoCao = @MaBaoCao
end
go

-- 3. Lay ma bao cao
create procedure LayMaBaoCao
	@MaBaoCao varchar(10) out,
	@Thang int,
	@Nam int
as
begin
select @MaBaoCao = MabaoCao
from BAOCAO
where Thang = @Thang and Nam = @Nam
end
go



------------- TABLE DETAILREPORT:

-- 1. THEM  INSERT: 
create procedure ThemChiTietBaocao
	@MaBaoCao varchar(10),
	@MaLoaiPhong varchar (10),
	@DoanhThu money,
	@TiLe float
as
begin

if(not exists (select * from BAOCAO where @MaBaoCao = MaBaoCao))
return -1

if(not exists (select * from LOAIPHONG where @MaLoaiPhong = MaLoaiPhong))
return -1

insert into CHITIETBAOCAO
values (@MaBaoCao, @MaLoaiPhong, @DoanhThu, @TiLe)
end
go

-- 2. XOA  Tat ca chi tiet bao cao voi ma tuong ung
create procedure XoaTatCaChiTietBaoCao
@MaBaoCao varchar(10)
as
begin
if(not exists (select * from CHITIETBAOCAO where MaBaoCao = @MaBaoCao))
return -1
delete from CHITIETBAOCAO
where MaBaoCao = @MaBaoCao
end
go 

-------- ChiTietBaoCao
create procedure ChiTietBaoCaoMaLoaiPhongVaDoanhThu
	@Thang int,
	@Nam int
as
begin
select p.MaLoaiPhong, SUM(c.ThanhTien) as DoanhThu
from ((PHONG as p inner join PHIEUTHUEPHONG as ph on p.MaPhong = ph.MaPhong)
	inner join CHITIETHOADON as c on c.MaPhieuThue = ph.MaPhieuThue) inner join HOADON as h
	on h.MaHoaDon = c.MaHoaDon
where DATEPART(month,ph.NgayThue) = @Thang and DATEPART(year, ph.NgayThue) = @Nam
group by p.MaLoaiPhong
end
go
--------------------------------------------------------
--------------------------------------------------------------
--------------- Hết phần của Nhật ----------------------




