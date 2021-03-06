USE [QL_NV]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/22/2020 14:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[HOVN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GT] [bit] NULL,
	[LUONG] [int] NULL,
	[MAPHONG] [int] NULL,
	[SDT] [nchar](12) NULL,
	[EMAIL] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ADMIN]    Script Date: 12/22/2020 14:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMIN](
	[MA_ADMIN] [nchar](100) NOT NULL,
	[USERNAME] [nchar](100) NOT NULL,
	[PASSWORD] [nchar](100) NOT NULL,
	[CAPDO] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[add_dean_for2]    Script Date: 12/22/2020 14:29:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_dean_for2] @ten nvarchar(100),@diadiem nvarchar(100),@maphong int 
as
begin
	insert into DUAN (TENDUAN,DD_DA,MAPHONG) values (@ten,@diadiem,@maphong)	
end
GO
/****** Object:  StoredProcedure [dbo].[XEMLUONG]    Script Date: 12/22/2020 14:29:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XEMLUONG]( @IDPHONG int)
as
begin
declare @LUONGLN int, @LUONGNN int, @TONGLUONG int
select @LUONGLN = MAX(Luong),@LuongNn=MIN(Luong), @TongLuong = Sum(Luong)
From Nhanvien Where MAPHONG = @IDPHONG
print N'LUONG MAX ' + convert(nvarchar(100),@luongLN)
print N'Luong min '  + convert (nvarchar(100),@luongNN)
print N'Luong tong ' + convert (nvarchar(100),@Tongluong)
end
GO
/****** Object:  StoredProcedure [dbo].[add_NV]    Script Date: 12/22/2020 14:29:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_NV] @Honame nvarchar(50),@name nvarchar(50), @ngaysinh datetime, @sex bit,@address nvarchar(100) , @luong int, @manql int,@maphong int
as
begin
--use QL_NV
insert into NHANVIEN (HOVN,TENNV,NGAYSINH,GT,DIACHI,LUONG,MANQL,MAPHONG) values(@Honame,@name,@ngaysinh,@sex,@address,@luong,@manql,@maphong)
end
GO
/****** Object:  StoredProcedure [dbo].[edit_NQL_NV]    Script Date: 12/22/2020 14:29:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[edit_NQL_NV] @manql_old int ,@manql_new int
as
begin	
	update nhanvien  set Manql = @manql_new where manql = @manql_old

end
GO
