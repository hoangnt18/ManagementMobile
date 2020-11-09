USE [PhoneManagement]
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_UpdateAccount]
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_Login]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo3]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_InsertBillInfo3]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo2]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_InsertBillInfo2]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo1]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_InsertBillInfo1]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_InsertBillInfo]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill1]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_InsertBill1]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_InsertBill]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetNumBillByDate]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_GetNumBillByDate]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListTable]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_GetListTable]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListPhoneCatePhone]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_GetListPhoneCatePhone]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListPhoneCategory]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_GetListPhoneCategory]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListPhone]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_GetListPhone]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateAndPage]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_GetListBillByDateAndPage]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_GetListBillByDate]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetCountQuanlity]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP PROCEDURE [dbo].[USP_GetCountQuanlity]
GO
ALTER TABLE [dbo].[PhoneCategory] DROP CONSTRAINT [FK__PhoneCate__idSto__4FD1D5C8]
GO
ALTER TABLE [dbo].[Phone] DROP CONSTRAINT [FK__Phone__idPhone__54968AE5]
GO
ALTER TABLE [dbo].[BillInfo] DROP CONSTRAINT [FK__BillInfo__idItem__6B44E613]
GO
ALTER TABLE [dbo].[BillInfo] DROP CONSTRAINT [FK__BillInfo__idBill__6A50C1DA]
GO
ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [FK__Bill__status__5E1FF51F]
GO
ALTER TABLE [dbo].[StoreCategory] DROP CONSTRAINT [DF__StoreCateg__name__4C0144E4]
GO
ALTER TABLE [dbo].[PhoneCategory] DROP CONSTRAINT [DF__PhoneCateg__name__4EDDB18F]
GO
ALTER TABLE [dbo].[Phone] DROP CONSTRAINT [DF__Phone__price__53A266AC]
GO
ALTER TABLE [dbo].[Phone] DROP CONSTRAINT [DF__Phone__name__52AE4273]
GO
ALTER TABLE [dbo].[NewBill] DROP CONSTRAINT [DF__NewBill__status__4830B400]
GO
ALTER TABLE [dbo].[NewBill] DROP CONSTRAINT [DF__NewBill__name__473C8FC7]
GO
ALTER TABLE [dbo].[BillInfo] DROP CONSTRAINT [DF__BillInfo__count__695C9DA1]
GO
ALTER TABLE [dbo].[BillInfo] DROP CONSTRAINT [DF__BillInfo__idItem__68687968]
GO
ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [DF__Bill__status__5D2BD0E6]
GO
ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [DF__Bill__DateCheckI__5C37ACAD]
GO
ALTER TABLE [dbo].[Account] DROP CONSTRAINT [DF__Account__Type__267ABA7A]
GO
ALTER TABLE [dbo].[Account] DROP CONSTRAINT [DF__Account__PassWor__25869641]
GO
ALTER TABLE [dbo].[Account] DROP CONSTRAINT [DF__Account__Display__24927208]
GO
/****** Object:  Table [dbo].[StoreCategory]    Script Date: 11/9/2020 10:22:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoreCategory]') AND type in (N'U'))
DROP TABLE [dbo].[StoreCategory]
GO
/****** Object:  Table [dbo].[PhoneCategory]    Script Date: 11/9/2020 10:22:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhoneCategory]') AND type in (N'U'))
DROP TABLE [dbo].[PhoneCategory]
GO
/****** Object:  Table [dbo].[Phone]    Script Date: 11/9/2020 10:22:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Phone]') AND type in (N'U'))
DROP TABLE [dbo].[Phone]
GO
/****** Object:  Table [dbo].[NewBill]    Script Date: 11/9/2020 10:22:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NewBill]') AND type in (N'U'))
DROP TABLE [dbo].[NewBill]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 11/9/2020 10:22:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillInfo]') AND type in (N'U'))
DROP TABLE [dbo].[BillInfo]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/9/2020 10:22:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bill]') AND type in (N'U'))
DROP TABLE [dbo].[Bill]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/9/2020 10:22:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Account]') AND type in (N'U'))
DROP TABLE [dbo].[Account]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 11/9/2020 10:22:54 PM ******/
DROP FUNCTION [dbo].[fuConvertToUnsign1]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[idBill] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[idNewBill] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[idBillInfo] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idItemPhone] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBillInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewBill]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewBill](
	[idNewBill] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNewBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phone]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phone](
	[idPhone] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idItemPhone] [int] IDENTITY(1,1) NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idItemPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneCategory]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneCategory](
	[idStore] [int] NOT NULL,
	[idPhone] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StoreCategory]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StoreCategory](
	[idStore] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idStore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'admin', N'Admin', N'1', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'staff', N'Staff', N'0', 0)
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([idBill], [DateCheckIn], [idNewBill], [status], [discount], [totalPrice]) VALUES (108, CAST(N'2020-11-09' AS Date), 12, 1, 0, 2800000)
INSERT [dbo].[Bill] ([idBill], [DateCheckIn], [idNewBill], [status], [discount], [totalPrice]) VALUES (109, CAST(N'2020-11-09' AS Date), 12, 1, 0, 1000000)
INSERT [dbo].[Bill] ([idBill], [DateCheckIn], [idNewBill], [status], [discount], [totalPrice]) VALUES (110, CAST(N'2020-11-09' AS Date), 12, 1, 0, 4500000)
INSERT [dbo].[Bill] ([idBill], [DateCheckIn], [idNewBill], [status], [discount], [totalPrice]) VALUES (111, CAST(N'2020-11-09' AS Date), 12, 1, 0, 4800000)
INSERT [dbo].[Bill] ([idBill], [DateCheckIn], [idNewBill], [status], [discount], [totalPrice]) VALUES (112, CAST(N'2020-11-09' AS Date), 12, 1, 0, 25200000)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idItemPhone], [count]) VALUES (9, 108, 29, 18)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idItemPhone], [count]) VALUES (10, 108, 30, 1)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idItemPhone], [count]) VALUES (11, 109, 31, 9)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idItemPhone], [count]) VALUES (13, 110, 31, 9)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idItemPhone], [count]) VALUES (15, 112, 29, 18)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[NewBill] ON 

INSERT [dbo].[NewBill] ([idNewBill], [name], [status]) VALUES (12, N'NewBill 1', N'New Bill')
INSERT [dbo].[NewBill] ([idNewBill], [name], [status]) VALUES (13, N'NewBill 2', N'New Bill')
SET IDENTITY_INSERT [dbo].[NewBill] OFF
GO
SET IDENTITY_INSERT [dbo].[Phone] ON 

INSERT [dbo].[Phone] ([idPhone], [name], [idItemPhone], [price]) VALUES (1, N'iPhone 7 plus', 29, 1400000)
INSERT [dbo].[Phone] ([idPhone], [name], [idItemPhone], [price]) VALUES (1, N'Air-port s3', 30, 1400000)
INSERT [dbo].[Phone] ([idPhone], [name], [idItemPhone], [price]) VALUES (2, N'SamSung galaxy s7', 31, 500000)
INSERT [dbo].[Phone] ([idPhone], [name], [idItemPhone], [price]) VALUES (2, N'SamSung galaxy s9', 35, 500000)
INSERT [dbo].[Phone] ([idPhone], [name], [idItemPhone], [price]) VALUES (1, N'Air-port seri 2', 36, 1400000)
SET IDENTITY_INSERT [dbo].[Phone] OFF
GO
SET IDENTITY_INSERT [dbo].[PhoneCategory] ON 

INSERT [dbo].[PhoneCategory] ([idStore], [idPhone], [name]) VALUES (1, 1, N'APPLE')
INSERT [dbo].[PhoneCategory] ([idStore], [idPhone], [name]) VALUES (1, 2, N'SAMSUNG')
INSERT [dbo].[PhoneCategory] ([idStore], [idPhone], [name]) VALUES (1, 3, N'HUAWEI')
INSERT [dbo].[PhoneCategory] ([idStore], [idPhone], [name]) VALUES (1, 4, N'XIAOMI')
INSERT [dbo].[PhoneCategory] ([idStore], [idPhone], [name]) VALUES (1, 5, N'NOKIA')
INSERT [dbo].[PhoneCategory] ([idStore], [idPhone], [name]) VALUES (1, 6, N'VIVO')
INSERT [dbo].[PhoneCategory] ([idStore], [idPhone], [name]) VALUES (1, 7, N'OPPO')
INSERT [dbo].[PhoneCategory] ([idStore], [idPhone], [name]) VALUES (1, 8, N'VSMART')
SET IDENTITY_INSERT [dbo].[PhoneCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[StoreCategory] ON 

INSERT [dbo].[StoreCategory] ([idStore], [name]) VALUES (1, N'Moblie Phone')
INSERT [dbo].[StoreCategory] ([idStore], [name]) VALUES (2, N'Accessories')
INSERT [dbo].[StoreCategory] ([idStore], [name]) VALUES (3, N'Moblie Phone')
INSERT [dbo].[StoreCategory] ([idStore], [name]) VALUES (4, N'Accessories')
INSERT [dbo].[StoreCategory] ([idStore], [name]) VALUES (5, N'Moblie Phone')
INSERT [dbo].[StoreCategory] ([idStore], [name]) VALUES (6, N'Accessories')
SET IDENTITY_INSERT [dbo].[StoreCategory] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Kter') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [idItemPhone]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[NewBill] ADD  DEFAULT (N'Bill name') FOR [name]
GO
ALTER TABLE [dbo].[NewBill] ADD  DEFAULT (N'Paying') FOR [status]
GO
ALTER TABLE [dbo].[Phone] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Phone] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[PhoneCategory] ADD  DEFAULT (N'NULL') FOR [name]
GO
ALTER TABLE [dbo].[StoreCategory] ADD  DEFAULT (N'NULL') FOR [name]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idNewBill])
REFERENCES [dbo].[NewBill] ([idNewBill])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([idBill])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idItemPhone])
REFERENCES [dbo].[Phone] ([idItemPhone])
GO
ALTER TABLE [dbo].[Phone]  WITH CHECK ADD FOREIGN KEY([idPhone])
REFERENCES [dbo].[PhoneCategory] ([idPhone])
GO
ALTER TABLE [dbo].[PhoneCategory]  WITH CHECK ADD FOREIGN KEY([idStore])
REFERENCES [dbo].[StoreCategory] ([idStore])
GO
/****** Object:  StoredProcedure [dbo].[USP_GetCountQuanlity]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetCountQuanlity]
	as
	begin 

						SELECT Phone.name ,sum(BillInfo.count) AS COUNTQUALITY, sum(phone.price) as TotalPrice FROM dbo.BillInfo
						LEFT JOIN dbo.Phone ON Phone.idItemPhone = BillInfo.idItemPhone 
						GROUP BY Phone.name ORDER BY COUNT(BillInfo.count) DESC
	end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE  proc [dbo].[USP_GetListBillByDate]
	@checkIn date
	as
	begin 
		select n.name as [NewBill 1] , b.totalPrice as [total Price] ,DateCheckIn as [Date Check In], discount  as [discount]
		from dbo.Bill as b,dbo.NewBill as n
		where dateCheckIn > = @checkIn and b.status = 1 and n.idNewBill = b.idNewBill
	end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateAndPage]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows;
	
	WITH BillShow AS( SELECT b.idBill, n.name AS [Name new bill], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.NewBill AS n
	WHERE DateCheckIn >= @checkIn  AND b.status = 1 AND n.idNewBill = b.idNewBill)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE idBill NOT IN (SELECT TOP (@exceptRows) idBill FROM BillShow)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListPhone]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListPhone]
as select * from dbo.Phone
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListPhoneCategory]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListPhoneCategory]
as select * from dbo.PhoneCategory
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListPhoneCatePhone]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListPhoneCatePhone]
as select p.idPhone, p.name, p.idItemPhone, p.price from dbo.Phone p, dbo.PhoneCategory pc where p.idPhone = pc.idPhone
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListTable]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListTable]
as select * from dbo.StatusPhone
GO
/****** Object:  StoredProcedure [dbo].[USP_GetNumBillByDate]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetNumBillByDate]
@checkIn date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.NewBill AS n
	WHERE DateCheckIn >= @checkIn  AND b.status = 1
	AND n.idNewBill = b.idNewBill
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[USP_InsertBill]
	 @idNewBill int
	 as
	 begin 
		insert dbo.Bill(DateCheckIn,idNewBill,status,discount) values(Getdate(),@idNewBill,0,0)
		
	 end 
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill1]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 ---proc
	 create proc [dbo].[USP_InsertBill1]
	
	 as
	 begin 
		insert dbo.Bill(DateCheckIn,status) values(getdate(),1)
		
	 end 
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 create proc [dbo].[USP_InsertBillInfo]
	 @idItemPhone varchar(20),  @count int
	 as
	 begin 
		insert dbo.BillInfo(idItemPhone,count) values(@idItemPhone,@count) 
	 end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo1]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 create proc [dbo].[USP_InsertBillInfo1]
	  @count int
	 as
	 begin 
		insert dbo.BillInfo(idItemPhone,count) values(N'IP7Plus',@count) 
	 end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo2]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 create proc [dbo].[USP_InsertBillInfo2]
	 @idItemPhone varchar(20),  @count int
	 as
	 begin 
		insert dbo.BillInfo1(idItemPhone,count) values(@idItemPhone,@count) 
	 end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo3]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertBillInfo3]
	 @idBill int, @idItemPhone int, @count int
	 as 
	 begin

		declare @isExitsBillInfo int;
		declare @phoneCount  int  = 1
		select @isExitsBillInfo = idBillInfo, @phoneCount = b.count  
		from dbo.BillInfo as b 
		where idBill = @idBill and idItemPhone = @idItemPhone

		if(@isExitsBillInfo > 0 )
		begin
			declare @newCount int = @phoneCount + @count 
			if(@newCount > 0 ) 
			update dbo.BillInfo set count = @phoneCount + @count where idItemPhone = @idItemPhone
			else
			delete dbo.BillInfo where idBill = @idBill and idItemPhone = @idItemPhone
		end

		else
			begin
				insert dbo.BillInfo(idBill,idItemPhone,count) values (@idBill,@idItemPhone,@count)
			end 
		end
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_Login] 
@userName nvarchar(100), @passWord nvarchar(100)
as
Begin
	Select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 11/9/2020 10:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_UpdateAccount]
	 @userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
	 as
	 begin
		declare @isRightPass int  = 0
		select @isRightPass = count(*) from dbo.Account where UserName = @userName and PassWord = @password

		if(@isRightPass = 1)
		begin
			if(@newPassword = null or @newPassword = '') 
				begin
					update dbo.Account set DisplayName = @displayName where UserName = @userName
				end
			else
				update dbo.Account set DisplayName =  @displayName, PassWord = @newpassword where UserName = @userName
		end

	 end
GO
