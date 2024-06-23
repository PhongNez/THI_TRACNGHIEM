USE [TN_CSDLPT]
GO

/****** Object:  StoredProcedure [dbo].[ReportBaiThi]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ReportBaiThi] (@masv VARCHAR(8), @lan SMALLINT, @mamh CHAR(5))
AS
BEGIN
  DECLARE @ID_BD INT,@NGAYTHI DATETIME;
    SELECT @ID_BD= ID_BD, @NGAYTHI = NGAYTHI
    FROM BANGDIEM
    WHERE BANGDIEM.MASV = @masv
          AND LAN = @lan
          AND MAMH = @mamh
  BEGIN
    SELECT stt, CAUHOI, NOIDUNG, A, B, C, D, DAP_AN, LUACHON
    FROM CHITIET_THI
    INNER JOIN BODE ON CHITIET_THI.ID_CAUHOI = BODE.CAUHOI
    WHERE CHITIET_THI.ID_BDIEM = @ID_BD
  END
END
GO

/****** Object:  StoredProcedure [dbo].[SP_DSLanThi]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DSLanThi]
@maMH nchar(5),
@maLop nchar(15)
AS 	
BEGIN
		SELECT DISTINCT  GVDK.LAN
		FROM GIAOVIEN_DANGKY GVDK, MONHOC 
		WHERE GVDK.MALOP=@maLop AND GVDK.MAMH=@maMH AND GVDK.MAMH=MONHOC.MAMH
END
GO

/****** Object:  StoredProcedure [dbo].[SP_Get_Subject_By_Class]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Script for SelectTopNRows command from SSMS  ******/
create proc [dbo].[SP_Get_Subject_By_Class] @malop nchar(15) 
as 
Select GIAOVIEN_DANGKY.MAMH,TENMH from GIAOVIEN_DANGKY,MONHOC where MALOP = @malop and GIAOVIEN_DANGKY.MAMH= MONHOC.MAMH
GO

/****** Object:  StoredProcedure [dbo].[SP_GetInfoClassByStudent]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_GetInfoClassByStudent]  @MASV nchar(8)
as
select LOP.MALOP ,tenlop from LOP,SINHVIEN where SINHVIEN.MASV =@MASV and LOP.MALOP = SINHVIEN.MALOP
GO

/****** Object:  StoredProcedure [dbo].[sp_KiemTra_KhoaChinh_GVDK]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_KiemTra_KhoaChinh_GVDK] @MAMH char(10),@MALOP nchar(20),@LAN INT
as
begin
--Kiểm tra ràng buộc trước
if EXISTS(select * from GIAOVIEN_DANGKY where MAMH=@MAMH AND MALOP=@MALOP AND LAN=@LAN)
return 1
else if @LAN=2 AND NOT EXISTS(select * from GIAOVIEN_DANGKY where MAMH=@MAMH AND MALOP=@MALOP AND LAN=1)
return 1
else
return 0
end
GO

/****** Object:  StoredProcedure [dbo].[sp_KiemTra_TRUOC_XOA_GVDK]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_KiemTra_TRUOC_XOA_GVDK] @malop nchar(20),@mamh char(10),@lan int
as
begin
declare @dem int
select @dem=COUNT(*) from (select MASV from BANGDIEM where MAMH=@mamh AND LAN=@lan) bd,
(select MASV from SINHVIEN where MALOP=@malop) sv 
where sv.MASV=bd.MASV
if @dem>0
return 1
else 
return 0
end
GO

/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaMonHoc]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_KiemTraMaMonHoc] @mamh char(10)
as
begin
if exists(select MAMH from MONHOC where MAMH=@mamh)
return 1;-- tồn tại trả về 1
else
return 0;--k tồn tại trả về 0
end
GO

/****** Object:  StoredProcedure [dbo].[SP_KiemTraSoLuongCau]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_KiemTraSoLuongCau] (@MaMH char(5),@trinhdo char(1),@socau int)
as
DECLARE @hientai int, @duoi int,@trinhdoduoi char(1)
select @hientai = COUNT(*) from BODE WHERE MAMH = @MaMH AND TRINHDO= @trinhdo
if(@hientai >= @socau) 
	return 1
else --hientai < cau
if (@trinhdo = 'C')
	return 0
else 
set @trinhdoduoi  =  NCHAR((SELECT ASCII(@trinhdo) +1))
	 if(@hientai >= @socau*0.7)
	 --dem
		 begin
			 select @duoi = COUNT(*) from BODE WHERE MAMH =@MaMH AND TRINHDO= @trinhdoduoi
			 if(@hientai+@duoi >= @socau)
			   return  1
			 else
				return  0 
		end
	 else
	   return 0
GO

/****** Object:  StoredProcedure [dbo].[sp_KiemTraTenMonHoc]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_KiemTraTenMonHoc] @tenmh nvarchar(100)
as
begin
if exists(select tenmh from MONHOC where TENMH=@tenmh)
return 1;
else
return 0;
end
GO

/****** Object:  StoredProcedure [dbo].[SP_KTLANTHI]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[SP_KTLANTHI]
@MASV CHAR(8), @MAMH CHAR(5), @LAN INT
AS
IF EXISTS (SELECT * FROM BANGDIEM WHERE MASV= @MASV AND MAMH =@MAMH AND LAN =@LAN)
	SELECT 1
ELSE SELECT 0
GO

/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login]
@TENLOGIN NVARCHAR( 100)
AS
DECLARE @UID INT
DECLARE @MAGV NCHAR(10)
SELECT @UID= uid , @MAGV= NAME FROM sys.sysusers 
  WHERE sid = SUSER_SID(@TENLOGIN)

SELECT MAGV= @MAGV, 
       HOTEN = (SELECT HO+ ' '+TEN FROM dbo.GIAOVIEN WHERE MAGV=@MAGV ), 
       TENNHOM=NAME
  FROM sys.sysusers
    WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
GO

/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_SV_Tu_Login]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create PROC [dbo].[SP_Lay_Thong_Tin_SV_Tu_Login]
@TENLOGIN NVARCHAR( 100)
AS
DECLARE @UID INT
DECLARE @MASV NCHAR(10)
SELECT @UID= uid , @MASV= NAME FROM sys.sysusers 
  WHERE sid = SUSER_SID(@TENLOGIN)

SELECT MASV= @MASV, 
       HOTEN = (SELECT HO+ ' '+TEN FROM dbo.SINHVIEN WHERE MASV=@MASV ), 
       TENNHOM=NAME
  FROM sys.sysusers
    WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
GO

/****** Object:  StoredProcedure [dbo].[SP_LayCauHoi_Tam]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_LayCauHoi_Tam] @MaMonHoc char(5),@MaGV char(8),@SoCau INT,@TrinhDo char(1)
as
Declare @TrinhDoDuoi char(1) = NCHAR((SELECT ASCII(@TrinhDo) +1))
declare @SoCauCo int;
declare @SoCauDuoi int;
set @SoCauCo = (select count(*) from BODE where MAMH = @MaMonHoc AND MAGV= @MAGV AND TRINHDO = @TrinhDo )
set @SoCauDuoi = (select count(*) from BODE where MAMH = @MaMonHoc AND MAGV= @MAGV AND TRINHDO = @TrinhDoDuoi )
if (@SoCauCo>=@SoCau)
	begin
	select top(@SoCau) * from BODE where MAMH = @MaMonHoc AND MAGV= @MAGV AND TRINHDO = @TrinhDo  ORDER BY NEWID()
	end
else 
	if (CAST(@SoCauCo as float)/CAST(@SoCau as float)>=0.7 and @SoCauCo+@SoCauDuoi>= @SoCau)
		begin
		  select * from 
			(select [CAUHOI] 
			 ,[MAMH]
			 ,[TRINHDO]
			 ,  CAST([NOIDUNG] AS NVARCHAR(MAX)) as [NOIDUNG]
			 , CAST([A] AS NVARCHAR(MAX)) as A
			 , CAST([B] AS NVARCHAR(MAX)) as B
			  , CAST([C] AS NVARCHAR(MAX)) as C
			  , CAST([D] AS NVARCHAR(MAX)) as D
			  ,[DAP_AN]
		      ,[MAGV] 
		  from BODE 
		  where MAMH = @MaMonHoc AND MAGV= @MAGV AND TRINHDO = @TrinhDo  
		  UNION
			select top(@SoCau-@SoCauCo)  
			[CAUHOI] 
			 ,[MAMH]
			 ,[TRINHDO]
			 ,  CAST([NOIDUNG] AS NVARCHAR(MAX)) as [NOIDUNG]
			 , CAST([A] AS NVARCHAR(MAX)) as A
			 , CAST([B] AS NVARCHAR(MAX)) as B
			  , CAST([C] AS NVARCHAR(MAX)) as C
			  , CAST([D] AS NVARCHAR(MAX)) as D
			  ,[DAP_AN]
		      ,[MAGV] 
			   from BODE
			   where MAMH = @MaMonHoc AND MAGV= @MAGV AND TRINHDO = @TrinhDoDuoi
			) as a order by NEWID()
		end
	else select 1
GO

/****** Object:  StoredProcedure [dbo].[SP_LayDeThi]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create PROC [dbo].[SP_LayDeThi] @malop nchar(15), @masv char(8), @mamh char(5), @lan smallint
AS
	DECLARE @id_bdiem int,@ngaythi datetime, @socau int, @trinhdo char(1),
	@res int, @subres int, @trinhdoduoi char(1), @cauduoi int, @cauduoi2 int, @cauCUng int
	-- res: số câu tìm được trong BODE
	SET XACT_ABORT ON
	BEGIN TRANSACTION

	BEGIN TRY
		-- lấy thông tin GIAOVIEN_DANGKY
		SELECT @ngaythi = GV_DK.NGAYTHI, @socau = GV_DK.SOCAUTHI, @trinhdo = GV_DK.TRINHDO
		FROM (SELECT MAMH, MALOP, LAN, NGAYTHI, SOCAUTHI, TRINHDO 
				FROM GIAOVIEN_DANGKY
				WHERE MAMH = @mamh AND MALOP = @malop AND LAN =@lan) GV_DK
		-- tạo BANGDIEM
		SAVE TRANSACTION _BANGDIEM		
		INSERT INTO BANGDIEM( MASV, MAMH, LAN, NGAYTHI)
		VALUES(@masv, @mamh, @lan, @ngaythi);
		SELECT @id_bdiem = SCOPE_IDENTITY() -- lay id_bdiem vua moi duoc them
		-- ramdom câu hỏi + insert CHITIET_THI
		-- trình độ C
		IF( @trinhdo = 'C')
		BEGIN
			SELECT @res = COUNT(CAUHOI)
			FROM BODE
			WHERE MAMH = @mamh and TRINHDO = @trinhdo AND MAGV IN
			(SELECT MAGV FROM GIAOVIEN WHERE MAKH IN(SELECT MAKH FROM KHOA))
			IF(@res >= @socau) -- KHOA đủ câu hỏi
			BEGIN
				INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
				SELECT TOP(@socau) @id_bdiem, BD.CAUHOI
				FROM (SELECT CAUHOI, TRINHDO, MAMH, MAGV FROM BODE) BD
				WHERE MAMH = @mamh AND TRINHDO = @trinhdo AND MAGV IN
				(SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))
				ORDER BY NEWID()
				-- trả kết quả đề thi
				SELECT ID_BDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
				FROM CHITIET_THI CT, BODE
				WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
			END
			ELSE IF(@res < @socau)
			BEGIN
				SELECT @subres = COUNT(CAUHOI)
				FROM BODE
				WHERE MAMH = @mamh AND TRINHDO = @trinhdo AND MAGV NOT IN
				(SELECT MAGV FROM GIAOVIEN WHERE MAKH NOT IN (SELECT MAKH FROM KHOA))
				IF(@subres < @socau - @res)
					BEGIN
						ROLLBACK TRANSACTION _BANGDIEM
						--RAISERROR('Số câu hỏi không đủ để tạo đề!',16,1)
						SELECT N'Số câu hỏi không đủ để tạo đề!'
					END
				ELSE IF(@subres >= @socau - @res)
				BEGIN
					INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
					SELECT TOP(@res) @id_bdiem, BD.CAUHOI
					FROM (SELECT CAUHOI, TRINHDO, MAMH, MAGV FROM BODE) BD
					WHERE MAMH = @mamh AND TRINHDO = @trinhdo AND MAGV IN
					(SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))
					ORDER BY NEWID()

					-- lấy câu hỏi của KHOA khác thêm vào
					INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
					SELECT TOP(@socau -@res) @id_bdiem, BD.CAUHOI
					FROM (SELECT CAUHOI, TRINHDO, MAMH, MAGV FROM BODE) BD
					WHERE MAMH = @mamh AND TRINHDO = @trinhdo AND MAGV NOT IN
					(SELECT MAGV FROM GIAOVIEN WHERE MAKH NOT IN (SELECT MAKH FROM KHOA))
					ORDER BY NEWID()

					-- trả về kết quả đề thi
					SELECT ID_BDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
					FROM CHITIET_THI CT, BODE
					WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
				END
			END
		END	
	-- trình độ A hoặc B
		ELSE
		set @TrinhDoDuoi  = CHAR((SELECT ASCII(@trinhdo) +1))
		BEGIN
			-- đổ toàn bộ câu hỏi trình độ trên vào bảng tạm DETHI ( A hoặc B)
			SELECT @id_bdiem AS ID_BDIEM, CAUHOI AS CAUHOI INTO #DETHI
			FROM BODE 
			WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV 
																   FROM GIAOVIEN 
																   WHERE MAKH IN (SELECT MAKH FROM KHOA))
			-- lưu số lượng câu trình độ trên
			SELECT @res = COUNT(CAUHOI)
			FROM BODE
			WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV
																   FROM GIAOVIEN
																   WHERE MAKH IN (SELECT MAKH FROM KHOA))  
			IF(@res >= @socau) -- trình độ trên >= 100%
			BEGIN
				INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
				SELECT TOP(@socau) @id_bdiem, CAUHOI
				FROM #DETHI
				ORDER BY NEWID()

				-- trả về kết quả đề thi
				SELECT ID_bDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
				FROM CHITIET_THI CT, BODE
				WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
			END
			ELSE IF(@res >= @socau*0.7) -- trình độ trên >=70%
			BEGIN
				-- lưu toàn bộ số lượng câu trình độ dưới
				INSERT INTO #DETHI(ID_BDIEM, CAUHOI)
				SELECT TOP(@socau - @res) @id_bdiem, CAUHOI
				FROM BODE
				WHERE MAMH = @maMH AND TRINHDO = @trinhdoduoi AND MAGV IN (SELECT MAGV
																		   FROM GIAOVIEN
																		   WHERE MAKH IN (SELECT MAKH FROM KHOA))
				ORDER BY NEWID()

				-- lấy số lượng câu trình độ dưới
				SELECT @cauduoi = COUNT(CAUHOI)
				FROM BODE
				WHERE MAMH = @maMH AND TRINHDO = @trinhdoduoi AND MAGV IN (SELECT MAGV
																		   FROM GIAOVIEN
																		   WHERE MAKH IN (SELECT MAKH FROM KHOA))
				IF(@cauduoi >= @socau - @res) -- trình độ dưới >= 100% - trên => đủ
				BEGIN
					INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
					SELECT TOP(@socau) @id_bdiem, CAUHOI
					FROM #DETHI
					ORDER BY NEWID()

					-- trả về kết quả đề thi
					SELECT ID_BDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
					FROM CHITIET_THI CT, BODE
					WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
				END
				ELSE
				BEGIN -- chuyển qua KHOA khác
					INSERT INTO #DETHI(ID_BDIEM, CAUHOI)
					SELECT TOP(@socau - @res) @id_bdiem, CAUHOI
					FROM BODE
					WHERE MAMH = @maMH AND TRINHDO = @trinhdo AND MAGV NOT IN (SELECT MAGV
																			   FROM GIAOVIEN
																			   WHERE MAKH IN (SELECT MAKH FROM KHOA))
					ORDER BY  NEWID()

					-- lưu số lượng câu trình độ trên 2
					SELECT @cauCUng = COUNT(CAUHOI)
					FROM BODE
					WHERE MAMH = @maMH AND TRINHDO = @trinhdo AND MAGV NOT IN (SELECT MAGV
																			   FROM GIAOVIEN
																			   WHERE MAKH IN (SELECT MAKH FROM KHOA))
					-- lưu số lượng câu trình độ dưới 2
					SELECT @cauduoi2 = COUNT(CAUHOI)
					FROM BODE
					WHERE MAMH = @maMH AND TRINHDO = @trinhdoduoi AND MAGV NOT IN (SELECT MAGV
																			   FROM GIAOVIEN
																			   WHERE MAKH IN (SELECT MAKH FROM KHOA))
					IF(@cauCUng >= @socau - @res -@cauduoi) -- trên2 >= 100% - trên - dưới
					BEGIN
						INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
						SELECT TOP(@socau) @id_bdiem, CAUHOI
						FROM #DETHI
						ORDER BY NEWID()

						-- trả về kết quả đề thi
						SELECT ID_BDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
						FROM CHITIET_THI CT, BODE
						WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
					END
					ELSE IF(@cauduoi2 >= @socau-@res-@cauCUng-@cauduoi) -- dưới 2 > 100% - trên - trên2 - dưới => đủ
					BEGIN
						-- lấy câu trình độ dưới 2
						INSERT INTO #DETHI(ID_BDIEM, CAUHOI)
						SELECT TOP(@socau - @res -@cauCUng -@cauduoi) @id_bdiem, CAUHOI
						FROM BODE
						WHERE MAMH = @maMH AND TRINHDO = @trinhdoduoi AND MAGV NOT IN (SELECT MAGV
																				   FROM GIAOVIEN
																				   WHERE MAKH IN (SELECT MAKH FROM KHOA))
						ORDER BY NEWID()
						
						-- đổ dữ liệu vào đề bài thi
						INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
						SELECT TOP(@socau) @id_bdiem, CAUHOI
						FROM #DETHI
						ORDER BY NEWID()

						-- trả về kết quả đề thi
						SELECT ID_BDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
						FROM CHITIET_THI CT, BODE
						WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
					END
					ELSE
					BEGIN
						ROLLBACK TRANSACTION _BANGDIEM
						--RAISERROR('Số câu hỏi không đủ để tạo đề!',16,1)
						SELECT N'Số câu hỏi không đủ để tạo đề!'
					END
				END
			END
			ELSE
			BEGIN -- trình độ ở trên ở khoa hiện tại <70%
				-- lưu câu trình độ trên 2
				INSERT INTO #DETHI(ID_BDIEM, CAUHOI)
				SELECT TOP(@socau - @res) @id_bdiem, CAUHOI
				FROM BODE
				WHERE MAMH = @maMH AND TRINHDO = @trinhdo AND MAGV NOT IN (SELECT MAGV
																		   FROM GIAOVIEN
																		   WHERE MAKH IN (SELECT MAKH FROM KHOA))
				ORDER BY  NEWID()
				-- lấy số lượng câu trình độ trên 2
				SELECT @cauCUng = COUNT(CAUHOI)
				FROM BODE
				WHERE MAMH = @maMH AND TRINHDO = @trinhdo AND MAGV NOT IN (SELECT MAGV
																		   FROM GIAOVIEN
																		   WHERE MAKH IN (SELECT MAKH FROM KHOA))
				IF(@cauCUng >=@socau - @res) -- trên2 >= 100% - trên
				BEGIN
					INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
					SELECT TOP(@socau) @id_bdiem, CAUHOI
					FROM #DETHI
					ORDER BY NEWID()

					-- trả về kết quả đề thi
					SELECT ID_BDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
					FROM CHITIET_THI CT, BODE
					WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
				END
				ELSE IF(@cauCUng >= @socau*0.7-@res) -- trên2 >= 70% -trên
				BEGIN
					-- lưu toàn bộ số lượng câu trình độ dưới
					INSERT INTO #DETHI(ID_BDIEM, CAUHOI)
					SELECT TOP(@socau - @res -@cauCUng) @id_bdiem, CAUHOI
					FROM BODE
					WHERE MAMH = @maMH AND TRINHDO = @trinhdoduoi AND MAGV IN (SELECT MAGV
																			   FROM GIAOVIEN
																			   WHERE MAKH IN (SELECT MAKH FROM KHOA))
					ORDER BY NEWID()

					-- lấy số lượng câu trình độ dưới
					SELECT @cauduoi = COUNT(CAUHOI)
					FROM BODE
					WHERE MAMH = @maMH AND TRINHDO = @trinhdoduoi AND MAGV IN (SELECT MAGV
																			   FROM GIAOVIEN
																			   WHERE MAKH IN (SELECT MAKH FROM KHOA))

					-- lưu số lượng câu trình độ dưới 2
					SELECT @cauduoi2 = COUNT(CAUHOI)
					FROM BODE
					WHERE MAMH = @maMH AND TRINHDO = @trinhdoduoi AND MAGV NOT IN (SELECT MAGV
																			   FROM GIAOVIEN
																			   WHERE MAKH IN (SELECT MAKH FROM KHOA))
					IF(@cauduoi >= @socau - @res -@cauCUng) -- dưới >= 100% - trên - trên2
					BEGIN
						INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
						SELECT TOP(@socau) @id_bdiem, CAUHOI
						FROM #DETHI
						ORDER BY NEWID()

						-- trả về kết quả đề thi
						SELECT ID_BDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
						FROM CHITIET_THI CT, BODE
						WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
					END
					ELSE IF(@cauduoi2 >= @socau - @res - @cauCUng -@cauduoi) -- dưới 2 >= 100% - trên - trên2- dưới
					BEGIN
						INSERT INTO #DETHI(ID_BDIEM, CAUHOI)
						SELECT TOP(@socau - @res - @cauCUng - @cauduoi) @id_bdiem, CAUHOI
						FROM BODE
						WHERE MAMH = @maMH AND TRINHDO = @trinhdoduoi AND MAGV NOT IN (SELECT MAGV
																				   FROM GIAOVIEN
																				   WHERE MAKH IN (SELECT MAKH FROM KHOA))
						ORDER BY NEWID()
						
						INSERT INTO CHITIET_THI(ID_BDIEM, ID_CAUHOI)
						SELECT TOP(@socau) @id_bdiem, CAUHOI
						FROM #DETHI
						ORDER BY NEWID()
						-- trả về kết quả đề thi
						SELECT ID_BDIEM, CT.ID_CAUHOI, NOIDUNG, A, B, C, D, DAP_AN
						FROM CHITIET_THI CT, BODE
						WHERE ID_BDIEM = @id_bdiem AND CT.ID_CAUHOI = BODE.CAUHOI
					END
					ELSE
					BEGIN
						ROLLBACK TRANSACTION _BANGDIEM
						--RAISERROR('Số câu hỏi không đủ để tạo đề!',16,1)
						SELECT N'Số câu hỏi không đủ để tạo đề!'
					END
				END
				ELSE
				BEGIN
					ROLLBACK TRANSACTION _BANGDIEM
					--RAISERROR('Số câu hỏi không đủ để tạo đề!',16,1)
					SELECT N'Số câu hỏi không đủ để tạo đề!'
				END
			END
		END -- kết thúc trình độ A hoặc B
COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK
		DECLARE @ErrMessage VARCHAR(2000)
		SELECT @ErrMessage = 'Lỗi: ' + ERROR_MESSAGE()
	    RAISERROR(@ErrMessage, 16, 1)
	END CATCH
GO

/****** Object:  StoredProcedure [dbo].[sp_LayMonDaThi]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_LayMonDaThi] @MASV CHAR(8)
as
SELECT TENMH,MAMH
FROM MONHOC
WHERE MONHOC.MAMH IN (select MAMH
FROM BANGDIEM 
WHERE MASV = @MASV)
GO

/****** Object:  StoredProcedure [dbo].[SP_LAYMONTHI]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[SP_LAYMONTHI] @MALOP nchar(15)
as
SELECT *, 
(SELECT TENMH FROM MONHOC WHERE MAMH = GIAOVIEN_DANGKY.MAMH) as TENMH
FROM GIAOVIEN_DANGKY
WHERE MALOP = @MALOP;
GO

/****** Object:  StoredProcedure [dbo].[SP_LOGIN_SV]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[SP_LOGIN_SV] @masv char(10),@password nvarchar(35)
as
declare @NHOM char(10)
if exists(select masv from SINHVIEN where MASV=@masv and password=@password)
begin
select MASV,HO + ' ' + TEN as HOTEN,NHOM='SINHVIEN',MALOP from SINHVIEN where MASV=@masv
end
else
raiserror(N'Mật khẩu không đúng hoặc mã sinh viên không tồn tại',16,1)
GO

/****** Object:  StoredProcedure [dbo].[SP_ThiThu]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ThiThu] 
	@maLop nchar(15) , @maMH nchar(5), @lan smallint

AS 
	DECLARE @soCauThi int, @trinhDo nchar(1), @maBD int, @res int, @subRes INT, @TrinhDoDuoi nchar(1),
	 @CauDuoi INT, @CauDuoi2 INT ,@CauCUng INT
	-- res: so cau tim duoc trong BO DE
	SET XACT_ABORT ON
	
	BEGIN TRY
		create table #temp1 
		(cauhoi int, noidung ntext, a ntext, b ntext, c ntext, d ntext, dap_an char(1))
		
	   -- select GIAOVIEN_DANGKI
		SELECT  @soCauThi = SOCAUTHI, @trinhDo = TRINHDO FROM GIAOVIEN_DANGKY WHERE MAMH = @maMH AND MALOP = @maLop AND LAN = @lan
	
		--Trình độ A
		IF(@trinhDo = 'A')
		BEGIN 
			SET @TrinhDoDuoi = 'B'
		END
		--Trình độ B
		ELSE IF(@trinhDo = 'B')
		BEGIN 
			SET @TrinhDoDuoi = 'C'
		END

		--Trình độ C
		IF(@trinhDo = 'C')
		BEGIN
			SELECT @res = COUNT(CAUHOI) FROM BODE 
			WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  

				IF(@res >= @soCauThi)
				BEGIN
					SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN, @maBD FROM BODE
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID()
				END
				else if(@res < @soCauThi)
				BEGIN
					SELECT @subRes = COUNT(CAUHOI) FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
				
					if(@subRes < @soCauThi - @res)
						BEGIN-- thiếu đề
							RAISERROR('Không đủ số câu để tạo đề!', 16, 1)
						END
					else if(@subRes >= @soCauThi - @res)
					BEGIN 
						INSERT INTO  #temp1 (cauhoi , noidung, a , b , c , d , dap_an  )
						SELECT TOP (@res) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN FROM BODE 
						WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						ORDER BY  NEWID()
		
						INSERT INTO  #temp1 (cauhoi , noidung, a , b , c , d , dap_an  )
						SELECT TOP (@soCauThi - @res) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN FROM BODE 
						WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						ORDER BY  NEWID()
					
						SELECT * from #temp1 
					END
				END
			END
			-- trình độ A hoặc B
			ELSE 
			BEGIN
				-- đổ câu hỏi vào bảng tạm,lấy toàn bộ trình độ A
				SELECT  CAUHOI AS CAUHOI, NOIDUNG  AS NOIDUNG, A AS A,B AS B,C  AS  C,D  AS  D,DAP_AN AS DAP_AN, @maBD AS maBD INTO #DETHI FROM BODE 
				WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  

				SELECT @res = COUNT(CAUHOI) FROM BODE --lưu Số lượng trình độ A
				WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
		
				IF(@res >= @soCauThi)--if(A>=100%)
				BEGIN
					SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN, @maBD FROM #DETHI -- lấy dữ liệu random từ bảng tạm #dethi
					ORDER BY  NEWID()
				END

				ELSE if(@res >= @soCauThi*0.7) -- if(A>=70%)
				BEGIN
					insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- Lưu B
					SELECT  TOP (@soCauThi - @res) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN, @maBD  FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID() --random

					SELECT @CauDuoi = COUNT(CAUHOI) FROM BODE -- Lấy số lượng B
					WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					
					IF(@CauDuoi >= @soCauThi - @res)-- B >= 100% - A
						BEGIN 
							SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
							ORDER BY  NEWID()--random
						END
					ELSE --chuyển cơ sở
						BEGIN
							insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD ) -- Lấy A2
							SELECT TOP (@soCauThi - @res - @CauDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
							WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
							ORDER BY  NEWID() --random

							SELECT @CauCUng = COUNT(CAUHOI) FROM BODE -- lưu số lượng câu A2
							WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							SELECT @CauDuoi2 = COUNT(CAUHOI) FROM BODE --Lưu số Lượng B2
							WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							IF(@CauCUng >= @soCauThi - @res - @CauDuoi ) --if(A2 >= 100-A-B)
							BEGIN
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random
							END

							ELSE IF(@CauDuoi2 >= @soCauThi - @res - @CauCUng - @CauDuoi)-- If( B2 >= 100 -A - A2 - B)
							BEGIN
								insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B2
								SELECT TOP (@soCauThi - @res - @CauCUng - @CauDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
								WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
								ORDER BY  NEWID() --random

								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random
							END 

							ELSE 
							BEGIN-- thiếu đề
								RAISERROR('Không đủ số câu để tạo đề!', 16, 1)
							END

						END
				END
				ELSE 
				BEGIN -- đề cùng loại ở cơ sở gốc không đủ
					insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD ) -- Lấy A2
					SELECT  TOP (@soCauThi - @res) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN, @maBD  FROM BODE 
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					ORDER BY  NEWID() --random

					SELECT @CauCUng = COUNT(CAUHOI) FROM BODE --Lưu số câu A2
					WHERE MAMH = @maMH AND TRINHDO = @trinhDo AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
					
					IF(@CauCUng >= @soCauThi - @res)-- A2 >= 100% - A
						BEGIN 
							SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
							ORDER BY  NEWID()--random
						END
					ELSE IF(@CauCUng >= @soCauThi*0.7 - @res) -- If(A2 >= 70%-A)
					BEGIN
							insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B cùng cs
							SELECT TOP (@soCauThi - @res - @CauCUng) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
							WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV  IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
							ORDER BY  NEWID() --random

							SELECT @CauDuoi = COUNT(CAUHOI) FROM BODE -- Lưu số lượng B
							WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							SELECT @CauDuoi2 = COUNT(CAUHOI) FROM BODE --Lưu số lượng B2
							WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV NOT IN (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
						
							IF(@CauDuoi >= @soCauThi - @res - @CauCUng ) --if(B >= 100-A-A2)
							BEGIN
								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random
							END

							ELSE IF(@CauDuoi2 >= @soCauThi - @res - @CauCUng - @CauDuoi)-- If( B2 >= 100 -A - A2 - B)
							BEGIN
								insert into #DETHI (cauhoi, noidung, a , b , c , d , dap_an , maBD )-- lấy B2
								SELECT TOP (@soCauThi - @res - @CauCUng - @CauDuoi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM BODE 
								WHERE MAMH = @maMH AND TRINHDO = @TrinhDoDuoi AND MAGV NOT IN  (SELECT MAGV FROM GIAOVIEN WHERE MAKH IN (SELECT MAKH FROM KHOA))  
								ORDER BY  NEWID() --random

								SELECT TOP (@soCauThi) CAUHOI, NOIDUNG, A,B,C,D,DAP_AN,@maBD FROM #DETHI 
								ORDER BY  NEWID()--random
							END 

							ELSE 
							BEGIN-- thiếu đề
								RAISERROR('Không đủ số câu để tạo đề!', 16, 1)
							END

					END
					ELSE 
					BEGIN  -- thiếu đề
						RAISERROR('Không đủ số câu để tạo đề!', 16, 1)
					END
				END
		END-- end trình độ A hoặc B
	END TRY
	BEGIN CATCH
	   DECLARE @ErrorMessage VARCHAR(2000)
	   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
	   --RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
GO

/****** Object:  StoredProcedure [dbo].[SP_THONGTINLANTHI]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_THONGTINLANTHI]
@MALOP CHAR(15), @MAMH CHAR(5), @LAN INT
AS

BEGIN
	IF EXISTS (SELECT * FROM GIAOVIEN_DANGKY WHERE MALOP=@MALOP AND MAMH=@MAMH AND LAN=@LAN )
		SELECT TRINHDO, SOCAUTHI, THOIGIAN,NGAYTHI FROM GIAOVIEN_DANGKY
		WHERE MALOP=@MALOP AND MAMH=@MAMH AND LAN=@LAN

	ELSE 
		RAISERROR ('Không tìm thấy thông tin thi',16,1)
	
END
GO

/****** Object:  StoredProcedure [dbo].[sp_timsv]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_timsv] @x char(10)
as
declare @ho nvarchar(55),@ten nvarchar(15),@malop nchar(20), @tenlop nvarchar(55),@makh nchar(10)
if exists(select MASV from SINHVIEN where MASV=@x)
begin
select @malop=MALOP,@ho=HO,@ten=TEN from SINHVIEN where MASV=@x
select @tenlop=TENLOP,@makh=MAKH from LOP where MALOP=@malop
select TENLOP=@tenlop,TENKH,HO=@ho,TEN=@ten from KHOA where MAKH=@makh
end
else
if exists(select MASV from LINK0.TN_CSDLPT.DBO.SINHVIEN where MASV=@x)
begin
select @malop=MALOP,@ho=HO,@ten=TEN from LINK0.TN_CSDLPT.DBO.SINHVIEN where MASV=@x
select @tenlop=TENLOP,@makh=MAKH from LINK0.TN_CSDLPT.DBO.LOP where MALOP=@malop
select TENLOP=@tenlop,TENKH,HO=@ho,TEN=@ten from LINK0.TN_CSDLPT.DBO.KHOA where MAKH=@makh
end
else
RAISERROR(N'Mã sinh viên không có trong DB',16,1)
GO

/****** Object:  StoredProcedure [dbo].[sp_UpdateBangDiem]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateBangDiem]
  @ID_BD INT,
  @DIEM FLOAT
AS
BEGIN TRY
  UPDATE BANGDIEM
  SET DIEM = @DIEM
  WHERE  ID_BD =@ID_BD
  SELECT 0
END TRY
BEGIN CATCH
  SELECT 1
END CATCH
GO

/****** Object:  StoredProcedure [dbo].[spUpdateChiTietThi]    Script Date: 20/06/2024 17:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateChiTietThi]
  @ID_CAUHOI INT,
  @ID_BDIEM INT,
  @STT INT,
  @LUACHON CHAR(1)
AS
begin
BEGIN TRY
  UPDATE CHITIET_THI
  SET LUACHON = @LUACHON,
  STT = @STT
  WHERE ID_BDIEM = @ID_BDIEM and
  ID_CAUHOI = @ID_CAUHOI;
  select 0
END TRY
BEGIN CATCH
  select 1
END CATCH
end
GO


