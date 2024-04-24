USE [MiniGramCashDB]

/****** Object:  Table [dbo].[InstallShield]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstallShield]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstallShield](
	[ISSchema] [char](15) NULL
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLCURRENCIES]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLCURRENCIES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLCURRENCIES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBLCURRENCIES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLDELIVERY_RECEIPTS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDELIVERY_RECEIPTS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDELIVERY_RECEIPTS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReceiptBarcode] [nvarchar](50) NOT NULL,
	[RefID] [nvarchar](50) NOT NULL,
	[ReceiptTypeID] [int] NULL,
	[SupplierID] [int] NULL,
	[ReceiptDate] [datetime] NULL,
	[TotalQuantity] [int] NULL,
	[TotalDiscount] [float] NULL,
	[TotalLBP] [int] NULL,
	[TotalDollar] [float] NULL,
	[TotalTVA] [float] NULL,
	[CurrencyID] [int] NULL,
	[UserID] [int] NULL,
	[StatusID] [int] NOT NULL,
 CONSTRAINT [PK_TBLDELIVERY_RECEIPTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLDELIVERY_RECEIPTS_DETAILS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDELIVERY_RECEIPTS_DETAILS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDELIVERY_RECEIPTS_DETAILS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RID] [int] NOT NULL,
	[PID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[SellPrice] [float] NULL,
	[SecondaryPrice] [float] NULL,
	[Discount] [int] NULL,
	[Cost] [float] NULL,
	[HasTVA] [bit] NOT NULL,
	[HasDiscount] [bit] NOT NULL,
	[HasExpDate] [bit] NOT NULL,
	[ExpDate] [datetime] NULL,
	[isInSale] [bit] NOT NULL,
	[dateCreated] [datetime] NULL,
	[inStockQuantity] [int] NOT NULL,
 CONSTRAINT [PK_TBLDELIVERY_RECEIPTS_DETAILS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLEXPIREDDATES]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLEXPIREDDATES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLEXPIREDDATES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PID] [int] NOT NULL,
	[Qte] [int] NOT NULL,
	[ExpiredDate] [datetime] NULL,
	[dateCreated] [datetime] NULL,
 CONSTRAINT [PK_TBLEXPIREDDATES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLHOLDDETAILS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLHOLDDETAILS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLHOLDDETAILS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RID] [int] NULL,
	[PID] [int] NULL,
	[QTE] [int] NULL,
	[PRICE_Dollar] [float] NULL,
	[PRICE_LBP] [int] NULL,
	[TOTAL_PRICEDollar] [float] NULL,
	[TOTAL_PRICELBP] [int] NULL,
	[TotalTVA] [float] NULL,
	[TotalDiscount] [float] NULL,
	[CurrencyID] [int] NULL,
 CONSTRAINT [PK_TBLHOLDDETAILS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLITEMS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLITEMS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLITEMS](
	[IID] [int] IDENTITY(1,1) NOT NULL,
	[INAME] [nvarchar](100) NULL,
	[QTE] [int] NULL,
	[UNIT] [nvarchar](20) NULL,
	[ADD_DATE] [datetime] NULL,
	[ENABLED] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLPRODUCTS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLPRODUCTS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLPRODUCTS](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[PNAME] [nvarchar](100) NULL,
	[QTE] [int] NOT NULL,
	[PRICE] [float] NULL,
	[ADD_DATE] [datetime] NULL,
	[ENABLED] [bit] NULL,
	[HasQuantity] [bit] NULL,
	[BARCODE] [nvarchar](100) NOT NULL,
	[SID] [int] NULL,
	[HasExpiredDate] [int] NULL,
	[HasTVA] [bit] NOT NULL,
	[InitPrice] [float] NULL,
	[SecondaryPrice] [float] NULL,
	[DiscountPercentage] [int] NULL,
	[HasDiscount] [bit] NOT NULL,
	[CurrencyID] [int] NOT NULL,
	[HasUnit] [bit] NOT NULL,
	[UnitID] [int] NULL,
 CONSTRAINT [PK__TBLPRODU__C5775520C6615217] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLRECEIPTS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLRECEIPTS](
	[RID] [int] IDENTITY(1,1) NOT NULL,
	[ReceiptTypeID] [int] NOT NULL,
	[RITEM_NB] [int] NULL,
	[TOTAL_AMOUNTDollar] [float] NULL,
	[TOTAL_AMOUNTLBP] [int] NULL,
	[TotalTVA] [float] NULL,
	[TotalDiscount] [float] NULL,
	[RDATE] [datetime] NULL,
	[RBARCODE] [nvarchar](max) NOT NULL,
	[isHold] [bit] NOT NULL,
	[EmpCardNumber] [nvarchar](50) NULL,
	[restDollar] [float] NULL,
	[restLBP] [float] NULL,
	[customerDollar] [float] NULL,
	[customerLBP] [float] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK__TBLRECEI__CAFF4132BAEA3B5B] PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLRECEIPTS_DETAILS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLRECEIPTS_DETAILS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RID] [int] NULL,
	[PID] [int] NULL,
	[QTE] [int] NULL,
	[PRICE_Dollar] [float] NULL,
	[PRICE_LBP] [int] NULL,
	[TOTAL_PRICEDollar] [float] NULL,
	[TOTAL_PRICELBP] [int] NULL,
	[TotalTVA] [float] NULL,
	[TotalDiscount] [float] NULL,
	[CurrencyID] [int] NULL,
 CONSTRAINT [PK__TBLRECEI__3214EC27682BFD85] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLRECEIPTTYPES]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTTYPES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLRECEIPTTYPES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBLRECEIPTTYPES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLSTATUS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLSTATUS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLSTATUS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBLSTATUS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLSUPPLIERS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLSUPPLIERS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLSUPPLIERS](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[SNAME] [nvarchar](50) NULL,
	[SPHONE] [nvarchar](50) NULL,
	[SEMAIL] [nvarchar](50) NULL,
	[ADD_DATE] [date] NULL,
	[ENABLED] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[SID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[TBLUNITS]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLUNITS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLUNITS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](50) NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_TBLUNITS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLDELIVERY_RECEIPTS_StatusID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLDELIVERY_RECEIPTS] ADD  CONSTRAINT [DF_TBLDELIVERY_RECEIPTS_StatusID]  DEFAULT ((1)) FOR [StatusID]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLDELIVERY_RECEIPTS_DETAILS_HasTVA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLDELIVERY_RECEIPTS_DETAILS] ADD  CONSTRAINT [DF_TBLDELIVERY_RECEIPTS_DETAILS_HasTVA]  DEFAULT ((0)) FOR [HasTVA]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLDELIVERY_RECEIPTS_DETAILS_HasDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLDELIVERY_RECEIPTS_DETAILS] ADD  CONSTRAINT [DF_TBLDELIVERY_RECEIPTS_DETAILS_HasDiscount]  DEFAULT ((0)) FOR [HasDiscount]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLDELIVERY_RECEIPTS_DETAILS_HasExpDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLDELIVERY_RECEIPTS_DETAILS] ADD  CONSTRAINT [DF_TBLDELIVERY_RECEIPTS_DETAILS_HasExpDate]  DEFAULT ((0)) FOR [HasExpDate]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLDELIVERY_RECEIPTS_DETAILS_isInSale]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLDELIVERY_RECEIPTS_DETAILS] ADD  CONSTRAINT [DF_TBLDELIVERY_RECEIPTS_DETAILS_isInSale]  DEFAULT ((0)) FOR [isInSale]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLDELIVERY_RECEIPTS_DETAILS_inStockQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLDELIVERY_RECEIPTS_DETAILS] ADD  CONSTRAINT [DF_TBLDELIVERY_RECEIPTS_DETAILS_inStockQuantity]  DEFAULT ((0)) FOR [inStockQuantity]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLITEMS__QTE__15502E78]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLITEMS] ADD  DEFAULT ((0)) FOR [QTE]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLITEMS__ENABLE__164452B1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLITEMS] ADD  DEFAULT ((1)) FOR [ENABLED]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLPRODUCTS__QTE__24927208]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF__TBLPRODUCTS__QTE__24927208]  DEFAULT ((0)) FOR [QTE]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLPRODUC__PRICE__25869641]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF__TBLPRODUC__PRICE__25869641]  DEFAULT ((0.0)) FOR [PRICE]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLPRODUC__ENABL__267ABA7A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF__TBLPRODUC__ENABL__267ABA7A]  DEFAULT ((1)) FOR [ENABLED]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLPRODUCTS_HasQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF_TBLPRODUCTS_HasQuantity]  DEFAULT ((0)) FOR [HasQuantity]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLPRODUC__BARCO__5AEE82B9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF__TBLPRODUC__BARCO__5AEE82B9]  DEFAULT ((0)) FOR [BARCODE]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLPRODUCTS_HasTVA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF_TBLPRODUCTS_HasTVA]  DEFAULT ((0)) FOR [HasTVA]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLPRODUCTS_HasDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF_TBLPRODUCTS_HasDiscount]  DEFAULT ((0)) FOR [HasDiscount]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLPRODUCTS_CurrencyID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF_TBLPRODUCTS_CurrencyID]  DEFAULT ((2)) FOR [CurrencyID]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLPRODUCTS_HasUnits]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLPRODUCTS] ADD  CONSTRAINT [DF_TBLPRODUCTS_HasUnits]  DEFAULT ((0)) FOR [HasUnit]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLRECEIPTS_ReceiptTypeID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS] ADD  CONSTRAINT [DF_TBLRECEIPTS_ReceiptTypeID]  DEFAULT ((1)) FOR [ReceiptTypeID]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIP__RITEM__46E78A0C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS] ADD  CONSTRAINT [DF__TBLRECEIP__RITEM__46E78A0C]  DEFAULT ((0)) FOR [RITEM_NB]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIP__TOTAL__47DBAE45]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS] ADD  CONSTRAINT [DF__TBLRECEIP__TOTAL__47DBAE45]  DEFAULT ((0.0)) FOR [TOTAL_AMOUNTDollar]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIP__TOTAL__48CFD27E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS] ADD  CONSTRAINT [DF__TBLRECEIP__TOTAL__48CFD27E]  DEFAULT ((0)) FOR [TOTAL_AMOUNTLBP]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIP__RBARC__5BE2A6F2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS] ADD  CONSTRAINT [DF__TBLRECEIP__RBARC__5BE2A6F2]  DEFAULT ('0') FOR [RBARCODE]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLRECEIPTS_isHold]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS] ADD  CONSTRAINT [DF_TBLRECEIPTS_isHold]  DEFAULT ((0)) FOR [isHold]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIPTS__QTE__4D94879B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] ADD  CONSTRAINT [DF__TBLRECEIPTS__QTE__4D94879B]  DEFAULT ((0)) FOR [QTE]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIP__PRICE__4E88ABD4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] ADD  CONSTRAINT [DF__TBLRECEIP__PRICE__4E88ABD4]  DEFAULT ((0.0)) FOR [PRICE_Dollar]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIP__PRICE__4F7CD00D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] ADD  CONSTRAINT [DF__TBLRECEIP__PRICE__4F7CD00D]  DEFAULT ((0)) FOR [PRICE_LBP]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIP__TOTAL__5070F446]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] ADD  CONSTRAINT [DF__TBLRECEIP__TOTAL__5070F446]  DEFAULT ((0.0)) FOR [TOTAL_PRICEDollar]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__TBLRECEIP__TOTAL__5165187F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] ADD  CONSTRAINT [DF__TBLRECEIP__TOTAL__5165187F]  DEFAULT ((0)) FOR [TOTAL_PRICELBP]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_TBLUNITS_Enabled]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[TBLUNITS] ADD  CONSTRAINT [DF_TBLUNITS_Enabled]  DEFAULT ((1)) FOR [Enabled]
END

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBLEXPIREDDATES_TBLPRODUCTS1]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLEXPIREDDATES]'))
ALTER TABLE [dbo].[TBLEXPIREDDATES]  WITH CHECK ADD  CONSTRAINT [FK_TBLEXPIREDDATES_TBLPRODUCTS1] FOREIGN KEY([PID])
REFERENCES [dbo].[TBLPRODUCTS] ([PID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBLEXPIREDDATES_TBLPRODUCTS1]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLEXPIREDDATES]'))
ALTER TABLE [dbo].[TBLEXPIREDDATES] CHECK CONSTRAINT [FK_TBLEXPIREDDATES_TBLPRODUCTS1]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBLHOLDDETAILS_TBLHOLDDETAILS]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLHOLDDETAILS]'))
ALTER TABLE [dbo].[TBLHOLDDETAILS]  WITH CHECK ADD  CONSTRAINT [FK_TBLHOLDDETAILS_TBLHOLDDETAILS] FOREIGN KEY([RID])
REFERENCES [dbo].[TBLRECEIPTS] ([RID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBLHOLDDETAILS_TBLHOLDDETAILS]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLHOLDDETAILS]'))
ALTER TABLE [dbo].[TBLHOLDDETAILS] CHECK CONSTRAINT [FK_TBLHOLDDETAILS_TBLHOLDDETAILS]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBLHOLDDETAILS_TBLPRODUCTS]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLHOLDDETAILS]'))
ALTER TABLE [dbo].[TBLHOLDDETAILS]  WITH CHECK ADD  CONSTRAINT [FK_TBLHOLDDETAILS_TBLPRODUCTS] FOREIGN KEY([PID])
REFERENCES [dbo].[TBLPRODUCTS] ([PID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBLHOLDDETAILS_TBLPRODUCTS]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLHOLDDETAILS]'))
ALTER TABLE [dbo].[TBLHOLDDETAILS] CHECK CONSTRAINT [FK_TBLHOLDDETAILS_TBLPRODUCTS]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLPRODUCTS__SID__160F4887]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLPRODUCTS]'))
ALTER TABLE [dbo].[TBLPRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK__TBLPRODUCTS__SID__160F4887] FOREIGN KEY([SID])
REFERENCES [dbo].[TBLSUPPLIERS] ([SID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLPRODUCTS__SID__160F4887]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLPRODUCTS]'))
ALTER TABLE [dbo].[TBLPRODUCTS] CHECK CONSTRAINT [FK__TBLPRODUCTS__SID__160F4887]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLPRODUCTS__SID__7A3223E8]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLPRODUCTS]'))
ALTER TABLE [dbo].[TBLPRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK__TBLPRODUCTS__SID__7A3223E8] FOREIGN KEY([SID])
REFERENCES [dbo].[TBLSUPPLIERS] ([SID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLPRODUCTS__SID__7A3223E8]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLPRODUCTS]'))
ALTER TABLE [dbo].[TBLPRODUCTS] CHECK CONSTRAINT [FK__TBLPRODUCTS__SID__7A3223E8]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLRECEIPTS__PID__4CA06362]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]'))
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK__TBLRECEIPTS__PID__4CA06362] FOREIGN KEY([PID])
REFERENCES [dbo].[TBLPRODUCTS] ([PID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLRECEIPTS__PID__4CA06362]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]'))
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] CHECK CONSTRAINT [FK__TBLRECEIPTS__PID__4CA06362]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLRECEIPTS__PID__7B264821]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]'))
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK__TBLRECEIPTS__PID__7B264821] FOREIGN KEY([PID])
REFERENCES [dbo].[TBLPRODUCTS] ([PID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLRECEIPTS__PID__7B264821]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]'))
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] CHECK CONSTRAINT [FK__TBLRECEIPTS__PID__7B264821]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLRECEIPTS__RID__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]'))
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK__TBLRECEIPTS__RID__4BAC3F29] FOREIGN KEY([RID])
REFERENCES [dbo].[TBLRECEIPTS] ([RID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLRECEIPTS__RID__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]'))
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] CHECK CONSTRAINT [FK__TBLRECEIPTS__RID__4BAC3F29]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLRECEIPTS__RID__7C1A6C5A]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]'))
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK__TBLRECEIPTS__RID__7C1A6C5A] FOREIGN KEY([RID])
REFERENCES [dbo].[TBLRECEIPTS] ([RID])

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__TBLRECEIPTS__RID__7C1A6C5A]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBLRECEIPTS_DETAILS]'))
ALTER TABLE [dbo].[TBLRECEIPTS_DETAILS] CHECK CONSTRAINT [FK__TBLRECEIPTS__RID__7C1A6C5A]

/****** Object:  StoredProcedure [dbo].[sp_addNewItem]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_addNewItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_addNewItem] AS' 
END

ALTER PROCEDURE [dbo].[sp_addNewItem](@name nvarchar(100),@qte int,@unit NVARCHAR(20))
AS
BEGIN
INSERT INTO TBLITEMS(INAME,QTE,UNIT,ADD_DATE,ENABLED)VALUES(@name,@qte,@unit,GETDATE(),1)
END

/****** Object:  StoredProcedure [dbo].[sp_addNewProduct]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_addNewProduct]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_addNewProduct] AS' 
END

ALTER PROCEDURE [dbo].[sp_addNewProduct](@name nvarchar(100),@barcode nvarchar(100),@qte int,@price float,@hasQuantity BIT,@sid int,@hasExpiredDate BIT,@hasTVA BIT,@initprice FLOAT,@secondPrice FLOAT,@discountPercentage int,@hasDiscount BIT)
AS
BEGIN
INSERT INTO TBLPRODUCTS(PNAME,BARCODE,QTE,PRICE,ADD_DATE,ENABLED,HasQuantity,SID,HasExpiredDate,HasTVA,InitPrice,SecondaryPrice,DiscountPercentage,HasDiscount)VALUES(@name,@barcode,@qte,@price,GETDATE(),1,@hasQuantity,@sid,@hasExpiredDate,@hasTVA,@initprice,@secondPrice,@discountPercentage,@hasDiscount)
END

/****** Object:  StoredProcedure [dbo].[sp_addNewSupplier]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_addNewSupplier]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_addNewSupplier] AS' 
END

ALTER PROCEDURE [dbo].[sp_addNewSupplier](@name nvarchar(50),@phone nvarchar(50),@email nvarchar(50))
AS
BEGIN

	INSERT INTO TBLSUPPLIERS(SNAME,SPHONE,SEMAIL,ADD_DATE,ENABLED) VALUES (@name,@phone,@email,GETDATE(),1)

END

/****** Object:  StoredProcedure [dbo].[sp_deleteHoldReceiptDetailsByRID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_deleteHoldReceiptDetailsByRID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_deleteHoldReceiptDetailsByRID] AS' 
END

ALTER PROCEDURE [dbo].[sp_deleteHoldReceiptDetailsByRID](@rid int)
AS
BEGIN
	DELETE FROM TBLHOLDDETAILS WHERE RID = @rid
END

/****** Object:  StoredProcedure [dbo].[sp_deleteReceiptByBarcode]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_deleteReceiptByBarcode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_deleteReceiptByBarcode] AS' 
END

ALTER PROCEDURE [dbo].[sp_deleteReceiptByBarcode](@barcode nvarchar(max))
AS
BEGIN
DELETE FROM TBLRECEIPTS WHERE RBARCODE = @barcode
END

/****** Object:  StoredProcedure [dbo].[sp_deleteReceiptDetailsByRID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_deleteReceiptDetailsByRID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_deleteReceiptDetailsByRID] AS' 
END

ALTER PROCEDURE [dbo].[sp_deleteReceiptDetailsByRID](@id int)
AS
BEGIN
DELETE FROM TBLRECEIPTS_DETAILS WHERE RID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_disableItemByID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_disableItemByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_disableItemByID] AS' 
END

ALTER PROCEDURE [dbo].[sp_disableItemByID](@id int)
AS
BEGIN
UPDATE TBLITEMS SET Enabled = 0 WHERE IID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_disableProductByID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_disableProductByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_disableProductByID] AS' 
END

ALTER PROCEDURE [dbo].[sp_disableProductByID](@id int)
AS
BEGIN
UPDATE TBLPRODUCTS SET Enabled = 0 WHERE PID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_disableSupplierByID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_disableSupplierByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_disableSupplierByID] AS' 
END

ALTER PROCEDURE [dbo].[sp_disableSupplierByID](@id int)
AS
BEGIN
UPDATE TBLSUPPLIERS SET Enabled = 0 WHERE SID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_enableItemByID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_enableItemByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_enableItemByID] AS' 
END

ALTER PROCEDURE [dbo].[sp_enableItemByID](@id int)
AS
BEGIN
UPDATE TBLITEMS SET Enabled = 1 WHERE IID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_enableProductByID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_enableProductByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_enableProductByID] AS' 
END

ALTER PROCEDURE [dbo].[sp_enableProductByID](@id int)
AS
BEGIN
UPDATE TBLPRODUCTS SET Enabled = 1 WHERE PID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_enableSupplierByID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_enableSupplierByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_enableSupplierByID] AS' 
END

ALTER PROCEDURE [dbo].[sp_enableSupplierByID](@id int)
AS
BEGIN
UPDATE TBLSUPPLIERS SET Enabled = 1 WHERE SID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_getAllExpiredDateProducts]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getAllExpiredDateProducts]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getAllExpiredDateProducts] AS' 
END

ALTER PROCEDURE [dbo].[sp_getAllExpiredDateProducts]
AS
BEGIN

	SELECT
			TBLPRODUCTS.BARCODE,
		    TBLPRODUCTS.PNAME,
			TBLSUPPLIERS.SNAME,
			TBLEXPIREDDATES.Qte,
			TBLEXPIREDDATES.ExpiredDate
	FROM 
			TBLPRODUCTS INNER JOIN 
			TBLEXPIREDDATES ON TBLEXPIREDDATES.PID = TBLPRODUCTS.PID INNER JOIN 
			TBLSUPPLIERS ON TBLSUPPLIERS.SID = TBLPRODUCTS.SID
	WHERE
			CONVERT(DATE,TBLEXPIREDDATES.ExpiredDate) < CONVERT(DATE,GETDATE())
END

/****** Object:  StoredProcedure [dbo].[sp_getBestItems]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getBestItems]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getBestItems] AS' 
END

ALTER PROCEDURE [dbo].[sp_getBestItems](@date DATETIME)
AS
BEGIN

	Select	TOP 3
			TBLPRODUCTS.PNAME ,SUM(TBLRECEIPTS_DETAILS.TOTAL_PRICEDollar) AS TOTAL
	FROM  
			TBLPRODUCTS  INNER JOIN 
			TBLRECEIPTS_DETAILS ON TBLRECEIPTS_DETAILS.PID = TBLPRODUCTS.PID INNER JOIN
			TBLRECEIPTS ON TBLRECEIPTS.RID = TBLRECEIPTS_DETAILS.RID
	WHERE 
			YEAR(TBLRECEIPTS.RDATE) = YEAR(@date)

	GROUP BY 
			TBLPRODUCTS.PNAME

	ORDER BY TOTAL DESC
END

/****** Object:  StoredProcedure [dbo].[sp_getBestSuppliers]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getBestSuppliers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getBestSuppliers] AS' 
END

ALTER PROCEDURE [dbo].[sp_getBestSuppliers](@date DATETIME)
AS
BEGIN

	Select	TOP 3
			TBLSUPPLIERS.SNAME ,SUM(TBLRECEIPTS_DETAILS.TOTAL_PRICEDollar) AS TOTAL

	FROM 
			TBLSUPPLIERS INNER JOIN 
			TBLPRODUCTS ON TBLSUPPLIERS.SID = TBLPRODUCTS.SID INNER JOIN 
			TBLRECEIPTS_DETAILS ON TBLRECEIPTS_DETAILS.PID = TBLPRODUCTS.PID INNER JOIN
			TBLRECEIPTS ON TBLRECEIPTS.RID = TBLRECEIPTS_DETAILS.RID
	WHERE 
			YEAR(TBLRECEIPTS.RDATE) = YEAR(@date)

	GROUP BY 
			TBLSUPPLIERS.SNAME

	ORDER BY TOTAL DESC
END

/****** Object:  StoredProcedure [dbo].[sp_getDailyCashByDate]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getDailyCashByDate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getDailyCashByDate] AS' 
END


-- EXEC [sp_getDailyCashByDate] '2023-10-14','2023-12-14'
ALTER PROCEDURE [dbo].[sp_getDailyCashByDate](@fromDate DATETIME,@toDate DATETIME)
AS
BEGIN
	(SELECT
			TBLRECEIPTS.RBARCODE,
			TBLRECEIPTS.RITEM_NB * CASE WHEN ReceiptTypeID =1 THEN 1  WHEN ReceiptTypeID =2 THEN -1 END AS RITEM_NB,
			TBLRECEIPTS.TOTAL_AMOUNTDollar,
			TBLRECEIPTS.TOTAL_AMOUNTLBP,
			TBLRECEIPTS.RDATE,
			TBLRECEIPTS.TotalTVA,
			dbo.TBLRECEIPTS.TotalDiscount
	FROM
			TBLRECEIPTS
	WHERE
			CONVERT(DATE,TBLRECEIPTS.RDATE) BETWEEN CONVERT(DATE,@fromDate) AND CONVERT(DATE,@toDate) AND isHold = 0)

END

/****** Object:  StoredProcedure [dbo].[sp_getLastReceiptID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getLastReceiptID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getLastReceiptID] AS' 
END

ALTER PROCEDURE [dbo].[sp_getLastReceiptID]
AS
BEGIN
SELECT MAX(RID) AS MAX_RID FROM TBLRECEIPTS
END

/****** Object:  StoredProcedure [dbo].[sp_getProductByName]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getProductByName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getProductByName] AS' 
END

ALTER PROCEDURE [dbo].[sp_getProductByName](@name nvarchar(max))
AS
BEGIN
SELECT * FROM TBLPRODUCTS WHERE (PNAME like @name OR BARCODE like @name) AND ENABLED = 1
END

/****** Object:  StoredProcedure [dbo].[sp_getProductList]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getProductList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getProductList] AS' 
END

ALTER PROCEDURE [dbo].[sp_getProductList]
AS
BEGIN

	SELECT 
			TBLPRODUCTS.BARCODE,
			TBLPRODUCTS.PNAME,
			TBLSUPPLIERS.SNAME,
			TBLPRODUCTS.PRICE,
			dbo.TBLPRODUCTS.QTE,
			TBLPRODUCTS.HasQuantity,
			TBLPRODUCTS.HasExpiredDate,
			TBLPRODUCTS.HasTVA,
			TBLPRODUCTS.InitPrice,
			TBLPRODUCTS.SecondaryPrice,
			dbo.TBLPRODUCTS.DiscountPercentage,
			dbo.TBLPRODUCTS.HasDiscount,
			dbo.TBLPRODUCTS.CurrencyID,
			dbo.TBLCURRENCIES.CurrencyName
			
	FROM
			TBLPRODUCTS INNER JOIN 
			TBLSUPPLIERS ON TBLPRODUCTS.SID = TBLSUPPLIERS.SID INNER JOIN
            dbo.TBLCURRENCIES ON dbo.TBLCURRENCIES.ID = dbo.TBLPRODUCTS.CurrencyID
	WHERE
			TBLPRODUCTS.ENABLED = 1

END

/****** Object:  StoredProcedure [dbo].[sp_getProductsCount]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getProductsCount]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getProductsCount] AS' 
END

ALTER PROCEDURE [dbo].[sp_getProductsCount](@str NVARCHAR(MAX))
AS
BEGIN
IF(@str = '')
	SELECT COUNT(PID) AS Product_Number FROM TBLPRODUCTS Where Enabled = 1
ELSE
BEGIN
	DECLARE @isDigit BIT
	SELECt @isDigit = ISNUMERIC(@str)
	IF(@isDigit = 1)
		SELECT COUNT(PID) AS Product_Number FROM TBLPRODUCTS Where Enabled = 1 AND (PID LIKE '%'+@str+'%' OR BARCODE LIKE '%'+@str+'%')
	ELSE
		SELECT COUNT(PID) AS Product_Number FROM TBLPRODUCTS Where Enabled = 1 AND PNAME LIKE '%'+@str+'%'
END
END

/****** Object:  StoredProcedure [dbo].[sp_getReceiptByBarcode]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getReceiptByBarcode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getReceiptByBarcode] AS' 
END

ALTER PROCEDURE [dbo].[sp_getReceiptByBarcode](@barcode nvarchar(max))
AS
BEGIN
SELECT * FROM TBLRECEIPTS WHERE RBARCODE = @barcode
END

/****** Object:  StoredProcedure [dbo].[sp_getReceiptByID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getReceiptByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getReceiptByID] AS' 
END

ALTER PROCEDURE [dbo].[sp_getReceiptByID](@id int)
AS
BEGIN
SELECT * FROM TBLRECEIPTS WHERE RID =@id
END

/****** Object:  StoredProcedure [dbo].[sp_getSalesProductCountByDate]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getSalesProductCountByDate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getSalesProductCountByDate] AS' 
END

-- EXEC [sp_getSalesProductCountByDate] '2023-12-14','2023-12-14'
ALTER PROCEDURE [dbo].[sp_getSalesProductCountByDate](@fromDate DATETIME,@toDate Datetime)
AS
BEGIN

	SELECT 
			PROD.BARCODE,
			PROD.PNAME,
			(SELECT SUM(dbo.TBLRECEIPTS_DETAILS.QTE) FROM dbo.TBLRECEIPTS_DETAILS INNER JOIN dbo.TBLRECEIPTS ON TBLRECEIPTS.RID = TBLRECEIPTS_DETAILS.RID WHERE TBLRECEIPTS.ReceiptTypeID = 1 AND PROD.PID = dbo.TBLRECEIPTS_DETAILS.PID AND CONVERT(DATE,TBLRECEIPTS.RDATE) BETWEEN CONVERT(DATE,@fromDate) AND CONVERT(DATE,@toDate)) AS TotalSale,
			(SELECT SUM(dbo.TBLRECEIPTS_DETAILS.QTE) FROM dbo.TBLRECEIPTS_DETAILS INNER JOIN dbo.TBLRECEIPTS ON TBLRECEIPTS.RID = TBLRECEIPTS_DETAILS.RID WHERE TBLRECEIPTS.ReceiptTypeID = 2 AND PROD.PID = dbo.TBLRECEIPTS_DETAILS.PID AND CONVERT(DATE,TBLRECEIPTS.RDATE) BETWEEN CONVERT(DATE,@fromDate) AND CONVERT(DATE,@toDate)) AS TotalReturn
	FROM
			TBLPRODUCTS PROD INNER JOIN 
			TBLRECEIPTS_DETAILS ON TBLRECEIPTS_DETAILS.PID = PROD.PID INNER JOIN
			TBLRECEIPTS ON TBLRECEIPTS.RID = TBLRECEIPTS_DETAILS.RID
	WHERE
			CONVERT(DATE,TBLRECEIPTS.RDATE) BETWEEN CONVERT(DATE,@fromDate) AND CONVERT(DATE,@toDate)
	GROUP BY
	    PROD.PNAME,
		PROD.BARCODE,
		PROD.PID
	ORDER BY TotalSale DESC
END

/****** Object:  StoredProcedure [dbo].[sp_getSIDBySNAME]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getSIDBySNAME]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getSIDBySNAME] AS' 
END

ALTER PROCEDURE [dbo].[sp_getSIDBySNAME](@name nvarchar(50))
AS
BEGIN 
SELECT SID FROM TBLSUPPLIERS WHERE SNAME = @name
END

/****** Object:  StoredProcedure [dbo].[sp_getSupplierByID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getSupplierByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getSupplierByID] AS' 
END

ALTER PROCEDURE [dbo].[sp_getSupplierByID](@id int)
AS
BEGIN
SELECT * FROM TBLSUPPLIERS WHERE SID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_getSupplierByNAME]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getSupplierByNAME]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getSupplierByNAME] AS' 
END


ALTER PROCEDURE [dbo].[sp_getSupplierByNAME](@name NVARCHAR(50))
AS
BEGIN
SELECT * FROM TBLSUPPLIERS WHERE SNAME = @name
END

/****** Object:  StoredProcedure [dbo].[sp_getTotalOfExpiredDateQteByPID]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getTotalOfExpiredDateQteByPID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getTotalOfExpiredDateQteByPID] AS' 
END

ALTER PROCEDURE [dbo].[sp_getTotalOfExpiredDateQteByPID](@pid int)
AS
BEGIN
	Select SUM(Qte) AS TotalQte
	FROM TBLEXPIREDDATES 
	WHERE PID = @pid
END

/****** Object:  StoredProcedure [dbo].[sp_getTotalOfExpiredDateQteByPName]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getTotalOfExpiredDateQteByPName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getTotalOfExpiredDateQteByPName] AS' 
END

ALTER PROCEDURE [dbo].[sp_getTotalOfExpiredDateQteByPName](@pname nvarchar(max))
AS
BEGIN
	Select SUM(TBLEXPIREDDATES.Qte) as TotalQte
	FROM TBLEXPIREDDATES INNER JOIN 
		 TBLPRODUCTS ON TBLPRODUCTS.PID = TBLEXPIREDDATES.PID 
	WHERE TBLPRODUCTS.PNAME = @pname
END

/****** Object:  StoredProcedure [dbo].[sp_getUserDiscountCountByDay]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getUserDiscountCountByDay]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_getUserDiscountCountByDay] AS' 
END

ALTER PROCEDURE [dbo].[sp_getUserDiscountCountByDay](@userCardNumber NVARCHAR(50))
AS
BEGIN

SELECT COUNT(EmpCardNumber) AS num FROM dbo.TBLRECEIPTS WHERE EmpCardNumber = @userCardNumber AND CONVERT(DATE,RDATE) =CONVERT(DATE,GETDATE())

END

/****** Object:  StoredProcedure [dbo].[sp_insertNewRecipt]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_insertNewRecipt]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_insertNewRecipt] AS' 
END

ALTER PROCEDURE [dbo].[sp_insertNewRecipt](@barcode nvarchar(max),@itemnb int,@totaldollar float,@totallbp INT,@totaltva FLOAT,@totaldiscount FLOAT,@receiptTypeID int)
AS
BEGIN
INSERT INTO TBLRECEIPTS(ReceiptTypeID,RBARCODE,RITEM_NB,TOTAL_AMOUNTDollar,TOTAL_AMOUNTLBP,TotalTVA,TotalDiscount,RDATE)VALUES(@receiptTypeID,@barcode,@itemnb,@totaldollar,@totallbp,@totallbp,@totaldiscount,GETDATE())
END

/****** Object:  StoredProcedure [dbo].[sp_insertNewReciptDetail]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_insertNewReciptDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_insertNewReciptDetail] AS' 
END

ALTER PROCEDURE [dbo].[sp_insertNewReciptDetail](@rid int,@pid int,@qte int,@pricedollar float,@totaldollar float,@pricelbp int,@totallbp INT,@totaltva FLOAT,@totaldiscount FLOAT)
AS
BEGIN
INSERT INTO TBLRECEIPTS_DETAILS(RID,PID,QTE,PRICE_Dollar,PRICE_LBP,TOTAL_PRICEDollar,TOTAL_PRICELBP,TotalTVA,TotalDiscount)VALUES(@rid,@pid,@qte,@pricedollar,@pricelbp,@totaldollar,@totallbp,@totaltva,@totaldiscount)
END

/****** Object:  StoredProcedure [dbo].[sp_select_item]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_select_item]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_select_item] AS' 
END

ALTER PROCEDURE [dbo].[sp_select_item](@str NVARCHAR(MAX))
AS 
BEGIN
IF(@str = '')
	SELECT IID AS ID,INAME AS ItemName,QTE AS Quantity,Unit,ADD_DATE AS AddedDate, CASE WHEN ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status FROM TBLITEMS ORDER BY IID ASC
ELSE
BEGIN
	DECLARE @isDigit BIT
	SELECt @isDigit = ISNUMERIC(@str)
	IF(@isDigit = 1)
		SELECT IID AS ID,INAME AS ItemName,QTE AS Quantity,Unit,ADD_DATE AS AddedDate, CASE WHEN ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status FROM TBLITEMS WHERE IID LIKE '%'+@str+'%' ORDER BY IID ASC
	ELSE
		SELECT IID AS ID,INAME AS ItemName,QTE AS Quantity,Unit,ADD_DATE AS AddedDate, CASE WHEN ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status FROM TBLITEMS WHERE INAME LIKE '%'+@str+'%' ORDER BY IID ASC
END
END

/****** Object:  StoredProcedure [dbo].[sp_select_products]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_select_products]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_select_products] AS' 
END

ALTER PROCEDURE [dbo].[sp_select_products](@str NVARCHAR(MAX),@showDisabled BIT)
AS 
BEGIN
IF(@str = '')
	SELECT p.PID AS ID,p.BARCODE AS Barcode,p.PNAME AS ProductName, CASE WHEN s.SNAME IS NULL THEN '' ELSE s.SNAME END AS SupplierName,p.QTE AS Quantity,p.PRICE AS Price,p.ADD_DATE AS AddedDate, CASE WHEN p.ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status,p.InitPrice,p.SecondaryPrice,p.HasTVA,p.DiscountPercentage,p.HasDiscount FROM TBLPRODUCTS p 
	LEFT JOIN TBLSUPPLIERS s on p.SID = s.SID
	WHERE @showDisabled =1 OR (@showDisabled =0 AND p.ENABLED =1)
	ORDER BY p.PID ASC
ELSE
BEGIN
	DECLARE @isDigit BIT
	SELECt @isDigit = ISNUMERIC(@str)
	IF(@isDigit = 1)
		SELECT p.PID AS ID,p.BARCODE AS Barcode,p.PNAME AS ProductName,CASE WHEN s.SNAME IS NULL THEN '' ELSE s.SNAME END AS SupplierName,p.QTE AS Quantity,p.PRICE AS Price,p.ADD_DATE AS AddedDate, CASE WHEN p.ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status,p.InitPrice,p.SecondaryPrice,p.HasTVA,p.DiscountPercentage,p.HasDiscount FROM TBLPRODUCTS p 
	LEFT JOIN TBLSUPPLIERS s on p.SID = s.SID WHERE p.PID LIKE '%'+@str+'%' OR p.BARCODE LIKE '%'+@str+'%' AND (@showDisabled =1 OR (@showDisabled =0 AND p.ENABLED =1)) ORDER BY p.PID ASC
	ELSE
		SELECT p.PID AS ID,p.BARCODE AS Barcode,p.PNAME AS ProductName,CASE WHEN s.SNAME IS NULL THEN '' ELSE s.SNAME END AS SupplierName,p.QTE AS Quantity,p.PRICE AS Price,p.ADD_DATE AS AddedDate, CASE WHEN p.ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status,p.InitPrice,p.SecondaryPrice,p.HasTVA,p.DiscountPercentage,p.HasDiscount FROM TBLPRODUCTS p 
	LEFT JOIN TBLSUPPLIERS s on p.SID = s.SID WHERE p.PNAME LIKE '%'+@str+'%' AND (@showDisabled =1 OR (@showDisabled =0 AND p.ENABLED =1)) ORDER BY p.PID ASC
END
END

/****** Object:  StoredProcedure [dbo].[sp_select_suppliers]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_select_suppliers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_select_suppliers] AS' 
END

ALTER PROCEDURE [dbo].[sp_select_suppliers](@str NVARCHAR(MAX))
AS
BEGIN

IF(@str = '')
	SELECT SID AS ID,SNAME AS SupplierName,SPHONE AS PhoneNumber,SEMAIL AS Email,ADD_DATE AS AddedDate, CASE WHEN ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status FROM TBLSUPPLIERS ORDER BY SID ASC
ELSE
BEGIN
	DECLARE @isDigit BIT
	SELECt @isDigit = ISNUMERIC(@str)
	IF(@isDigit = 1)
		SELECT SID AS ID,SNAME AS SupplierName,SPHONE AS PhoneNumber,SEMAIL AS Email,ADD_DATE AS AddedDate, CASE WHEN ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status FROM TBLSUPPLIERS WHERE SID LIKE '%'+@str+'%' ORDER BY SID ASC
	ELSE
		SELECT SID AS ID,SNAME AS SupplierName,SPHONE AS PhoneNumber,SEMAIL AS Email,ADD_DATE AS AddedDate, CASE WHEN ENABLED = 1 THEN 'Enabled' ELSE 'Disabled' END AS Status FROM TBLSUPPLIERS WHERE SNAME LIKE '%'+@str+'%' ORDER BY SID ASC
END

END

/****** Object:  StoredProcedure [dbo].[sp_selectDeliveryReceipts]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_selectDeliveryReceipts]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_selectDeliveryReceipts] AS' 
END

ALTER PROCEDURE [dbo].[sp_selectDeliveryReceipts](@str nvarchar(max))
AS
BEGIN
SELECT 
	dbo.TBLDELIVERY_RECEIPTS.ID AS ID,
	ReceiptTypeID,
	ReceiptBarcode AS BARCODE,
	TotalQuantity AS NumberOfItem,
	TotalDollar AS TotalDolarPrice,
	TotalLBP AS TotalLBPPrice,
	TotalTVA AS TotalTVAPrice,
	TotalDiscount,
	ReceiptDate AS Date,
	CurrencyID,
	dbo.TBLCURRENCIES.CurrencyName,
	dbo.TBLDELIVERY_RECEIPTS.UserID,
	dbo.TBLDELIVERY_RECEIPTS.StatusID,
	dbo.TBLSTATUS.StatusName
FROM   
	dbo.TBLDELIVERY_RECEIPTS INNER JOIN
	dbo.TBLCURRENCIES ON TBLCURRENCIES.ID = TBLDELIVERY_RECEIPTS.CurrencyID INNER JOIN
	dbo.TBLSTATUS ON TBLSTATUS.ID = TBLDELIVERY_RECEIPTS.StatusID
WHERE  
	dbo.TBLDELIVERY_RECEIPTS.id LIKE '%'+@str+'%' OR ReceiptBarcode LIKE '%'+@str+'%'
order by 
	id DESC
END

/****** Object:  StoredProcedure [dbo].[sp_selectDeliveryReceiptsDetails]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_selectDeliveryReceiptsDetails]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_selectDeliveryReceiptsDetails] AS' 
END

ALTER PROCEDURE [dbo].[sp_selectDeliveryReceiptsDetails](@id int)
AS
BEGIN
		SELECT 
			r.ReceiptBarcode AS Barcode,	
			r.RefID,
			rd.RID AS RID,
			p.PNAME AS ProductName,
			p.PID,
			s.SNAME AS SupplierName,
			rd.Quantity,
			rd.SellPrice,
			rd.SecondaryPrice,
			rd.Discount,
			rd.Cost,
			r.TotalQuantity,
			r.TotalDiscount,
			r.TotalLBP,
			r.TotalDollar,
			r.TotalTVA

		FROM TBLDELIVERY_RECEIPTS r INNER JOIN
			 TBLDELIVERY_RECEIPTS_DETAILS rd ON r.ID = rd.RID INNER JOIN 
			 TBLPRODUCTS p ON rd.PID = p.PID LEFT JOIN 
			 TBLSUPPLIERS s on p.SID = s.SID 

		WHERE r.ID = @id 
END

/****** Object:  StoredProcedure [dbo].[sp_selectReceipts]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_selectReceipts]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_selectReceipts] AS' 
END

ALTER PROCEDURE [dbo].[sp_selectReceipts](@str nvarchar(max))
AS
BEGIN
SELECT TOP 600 
	RID AS ID,
	ReceiptTypeID,
	RBARCODE AS BARCODE,
	RITEM_NB AS NumberOfItem,
	TOTAL_AMOUNTDollar AS TotalDolarPrice,
	TOTAL_AMOUNTLBP AS TotalLBPPrice,
	TotalTVA AS TotalTVAPrice,
	TotalDiscount,
	RDATE AS Date,
	isHold,
	EmpCardNumber
FROM   
	TBLRECEIPTS 
WHERE  
	RID LIKE '%'+@str+'%' OR RBARCODE LIKE '%'+@str+'%'
order by 
	RID DESC
END

/****** Object:  StoredProcedure [dbo].[sp_selectReceiptsDetails]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_selectReceiptsDetails]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_selectReceiptsDetails] AS' 
END

ALTER PROCEDURE [dbo].[sp_selectReceiptsDetails](@id int)
AS
BEGIN
DECLARE @rtype int
SELECT @rtype = dbo.TBLRECEIPTS.ReceiptTypeID FROM dbo.TBLRECEIPTS WHERE RID = @id 

IF @rtype in (1,2,6)
	BEGIN
		SELECT r.RBARCODE AS Barcode,rd.RID AS RID,p.PNAME AS ProductName,s.SNAME AS SupplierName,rd.QTE AS Quantity,rd.PRICE_Dollar AS DollarPrice,rd.PRICE_LBP AS LBPPrice,
		rd.TOTAL_PRICEDollar AS TotalDolarPrice,rd.TOTAL_PRICELBP AS TotalLBPPrice,rd.TotalTVA,rd.TotalDiscount FROM TBLRECEIPTS r INNER JOIN TBLRECEIPTS_DETAILS rd ON r.RID = rd.RID
		INNER JOIN TBLPRODUCTS p ON rd.PID = p.PID LEFT JOIN TBLSUPPLIERS s on p.SID = s.SID WHERE r.RID = @id ORDER BY r.RID ASC
	END
ELSE IF @rtype IN (4)
	BEGIN
		SELECT r.RBARCODE AS Barcode,hd.RID AS RID,p.PNAME AS ProductName,s.SNAME AS SupplierName,hd.QTE AS Quantity,hd.PRICE_Dollar AS DollarPrice,hd.PRICE_LBP AS LBPPrice,
		hd.TOTAL_PRICEDollar AS TotalDolarPrice,hd.TOTAL_PRICELBP AS TotalLBPPrice,hd.TotalTVA,hd.TotalDiscount FROM TBLRECEIPTS r INNER JOIN dbo.TBLHOLDDETAILS hd ON r.RID = hd.RID
		INNER JOIN TBLPRODUCTS p ON hd.PID = p.PID LEFT JOIN TBLSUPPLIERS s on p.SID = s.SID WHERE r.RID = @id ORDER BY r.RID ASC
	END
END

/****** Object:  StoredProcedure [dbo].[sp_selectReceiptsDetailsForReportMini]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_selectReceiptsDetailsForReportMini]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_selectReceiptsDetailsForReportMini] AS' 
END

ALTER PROCEDURE [dbo].[sp_selectReceiptsDetailsForReportMini](@id int)
AS
BEGIN
DECLARE @rtype int
SELECT @rtype = dbo.TBLRECEIPTS.ReceiptTypeID FROM dbo.TBLRECEIPTS WHERE RID = @id 

IF @rtype in (1,2,6)
	BEGIN
		SELECT r.RBARCODE AS Barcode,rd.RID AS RID,p.PNAME AS ProductName,s.SNAME AS SupplierName,rd.QTE AS Quantity,rd.PRICE_Dollar AS DollarPrice,rd.PRICE_LBP AS LBPPrice,
		rd.TOTAL_PRICEDollar AS TotalDolarPrice,rd.TOTAL_PRICELBP AS TotalLBPPrice,rd.TotalTVA,rd.TotalDiscount FROM TBLRECEIPTS r INNER JOIN TBLRECEIPTS_DETAILS rd ON r.RID = rd.RID
		INNER JOIN TBLPRODUCTS p ON rd.PID = p.PID LEFT JOIN TBLSUPPLIERS s on p.SID = s.SID WHERE r.RID = @id ORDER BY r.RID ASC
	END
ELSE IF @rtype IN (4)
	BEGIN
		SELECT r.RBARCODE AS Barcode,hd.RID AS RID,p.PNAME AS ProductName,s.SNAME AS SupplierName,hd.QTE AS Quantity,hd.PRICE_Dollar AS DollarPrice,hd.PRICE_LBP AS LBPPrice,
		hd.TOTAL_PRICEDollar AS TotalDolarPrice,hd.TOTAL_PRICELBP AS TotalLBPPrice,hd.TotalTVA,hd.TotalDiscount FROM TBLRECEIPTS r INNER JOIN dbo.TBLHOLDDETAILS hd ON r.RID = hd.RID
		INNER JOIN TBLPRODUCTS p ON hd.PID = p.PID LEFT JOIN TBLSUPPLIERS s on p.SID = s.SID WHERE r.RID = @id ORDER BY r.RID ASC
	END
END

/****** Object:  StoredProcedure [dbo].[sp_UpdateExpiredDateQte]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateExpiredDateQte]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_UpdateExpiredDateQte] AS' 
END

ALTER PROCEDURE [dbo].[sp_UpdateExpiredDateQte](@expID int,@qte int)
AS
BEGIN
UPDATE TBLEXPIREDDATES	SET Qte = @qte WHERE ID = @expID
END

/****** Object:  StoredProcedure [dbo].[sp_UpdateItem]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_UpdateItem] AS' 
END

ALTER PROCEDURE [dbo].[sp_UpdateItem](@id int,@name nvarchar(100),@qte int,@unit nvarchar(20))
AS
BEGIN
UPDATE TBLITEMS SET INAME = @name WHERE IID = @id
UPDATE TBLITEMS SET QTE = @qte WHERE IID = @id
UPDATE TBLITEMS SET UNIT = @unit WHERE IID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_UpdateProduct]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateProduct]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_UpdateProduct] AS' 
END

ALTER PROCEDURE [dbo].[sp_UpdateProduct](@id int,@name nvarchar(100),@barcode nvarchar(100),@qte int,@price float,@hasQuantity BIT,@sid int,@hasExpiredDate BIT,@hasTVA BIT,@initprice FLOAT,@secondprice FLOAT,@discountPercentage INT,@hasDiscount BIT)
AS
BEGIN
UPDATE TBLPRODUCTS SET PNAME = @name WHERE PID = @id
UPDATE TBLPRODUCTS SET BARCODE = @barcode WHERE PID = @id
UPDATE TBLPRODUCTS SET QTE = @qte WHERE PID = @id
UPDATE TBLPRODUCTS SET PRICE = @price WHERE PID = @id
UPDATE TBLPRODUCTS SET HasQuantity = @hasQuantity WHERE PID = @id
UPDATE TBLPRODUCTS SET SID = @sid WHERE PID = @id
UPDATE TBLPRODUCTS SET HasExpiredDate = @hasExpiredDate WHERE PID = @id
UPDATE TBLPRODUCTS SET HasTVA = @hasTVA WHERE PID = @id
UPDATE dbo.TBLPRODUCTS SET InitPrice = @initprice WHERE PID = @id
UPDATE dbo.TBLPRODUCTS SET SecondaryPrice = @secondprice WHERE PID = @id
UPDATE dbo.TBLPRODUCTS SET DiscountPercentage = @discountPercentage WHERE PID = @id
UPDATE dbo.TBLPRODUCTS SET HasDiscount = @hasDiscount WHERE PID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_UpdateProductQuantity]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateProductQuantity]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_UpdateProductQuantity] AS' 
END

/****** Script for SelectTopNRows command from SSMS  ******/
ALTER PROCEDURE [dbo].[sp_UpdateProductQuantity](@id int,@qte int)
AS
BEGIN
UPDATE TBLPRODUCTS SET QTE = @qte WHERE PID = @id
END

/****** Object:  StoredProcedure [dbo].[sp_UpdateSupplier]    Script Date: 06/02/2024 10:42:21 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateSupplier]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_UpdateSupplier] AS' 
END


ALTER PROCEDURE [dbo].[sp_UpdateSupplier](@id int ,@name nvarchar(50),@phone nvarchar(50),@email nvarchar(50))
AS
BEGIN
UPDATE TBLSUPPLIERS SET SNAME = @name WHERE SID = @id
UPDATE TBLSUPPLIERS SET SPHONE = @phone WHERE SID = @id
UPDATE TBLSUPPLIERS SET SEMAIL = @email WHERE SID = @id
END

USE [master]

ALTER DATABASE [MiniGramCashDB] SET  READ_WRITE 

