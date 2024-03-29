USE [preownedvehicle]
GO
/****** Object:  Table [dbo].[tbllogin]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbllogin](
	[loginid] [int] IDENTITY(1,1) NOT NULL,
	[roleid] [int] NULL,
	[username] [varchar](100) NULL,
	[password] [varchar](100) NULL,
	[isdeleted] [bit] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_tbllogin] PRIMARY KEY CLUSTERED 
(
	[loginid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbllogin] ON
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (1, 2, N'iamrto', N'rto', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (2, 2, N'iamrto2', N'rto2', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (3, 1, N'iamadmin', N'admin123', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (4, 3, N'iampolice', N'police', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (5, 3, N'iampolice2', N'police2', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (6, 4, N'iaminsurance', N'insurance', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (7, 5, N'iampuc', N'puc', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (8, 6, N'iamservice', N'service', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (9, 6, N'iamservice2', N'service2', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (10, 4, N'iaminsurance2', N'insurance2', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (11, 2, N'iamrto3', N'rto3', 0, 0)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (12, 2, N'iamrto4', N'rto4', 0, 1)
INSERT [dbo].[tbllogin] ([loginid], [roleid], [username], [password], [isdeleted], [status]) VALUES (13, 2, N'iamrto5', N'rto5', 0, 0)
SET IDENTITY_INSERT [dbo].[tbllogin] OFF
/****** Object:  Table [dbo].[tblfeedback]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblfeedback](
	[feedid] [int] IDENTITY(1,1) NOT NULL,
	[feedname] [varchar](100) NULL,
	[email] [varchar](200) NULL,
	[feedback] [varchar](max) NULL,
	[subject] [varchar](200) NULL,
	[isread] [bit] NULL,
 CONSTRAINT [PK_tblfeedback] PRIMARY KEY CLUSTERED 
(
	[feedid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblfeedback] ON
INSERT [dbo].[tblfeedback] ([feedid], [feedname], [email], [feedback], [subject], [isread]) VALUES (1, N'Ajmal', N'iamajmal@gmail.com', N'Good', N'About Resources', 1)
INSERT [dbo].[tblfeedback] ([feedid], [feedname], [email], [feedback], [subject], [isread]) VALUES (2, N'Amal', N'iamamal@gmail.com', N'Nice', N'About Design', 1)
INSERT [dbo].[tblfeedback] ([feedid], [feedname], [email], [feedback], [subject], [isread]) VALUES (3, N'Abin', N'iamabin@gmail.com', N'Nice Work', N'About Site', 1)
INSERT [dbo].[tblfeedback] ([feedid], [feedname], [email], [feedback], [subject], [isread]) VALUES (4, N'Mathew', N'iammathai@gmail.com', N'Good', N'About Site', 1)
INSERT [dbo].[tblfeedback] ([feedid], [feedname], [email], [feedback], [subject], [isread]) VALUES (5, N'Arun', N'iamarun@gmail.com', N'Nice Bro', N'About Resources', 0)
INSERT [dbo].[tblfeedback] ([feedid], [feedname], [email], [feedback], [subject], [isread]) VALUES (6, N'Ajith', N'iamajith@gmail.com', N'Good', N'About design', 1)
SET IDENTITY_INSERT [dbo].[tblfeedback] OFF
/****** Object:  Table [dbo].[tbldistrict]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbldistrict](
	[districtid] [int] IDENTITY(1,1) NOT NULL,
	[districtname] [varchar](100) NULL,
 CONSTRAINT [PK_tbldistrict] PRIMARY KEY CLUSTERED 
(
	[districtid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbldistrict] ON
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (1, N'Idukki')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (2, N'Ernakulam')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (3, N'Kottayam')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (4, N'Kollam')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (5, N'Kozhikodu')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (6, N'Trivandrum')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (7, N'Wayanad')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (8, N'Malapuram')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (9, N'Kannur')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (10, N'Kasargodu')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (11, N'Alapuzha')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (12, N'Pathanamthitta')
INSERT [dbo].[tbldistrict] ([districtid], [districtname]) VALUES (13, N'Palakkad')
SET IDENTITY_INSERT [dbo].[tbldistrict] OFF
/****** Object:  Table [dbo].[tblcity]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblcity](
	[cityid] [int] IDENTITY(1,1) NOT NULL,
	[districtid] [int] NULL,
	[cityname] [varchar](100) NULL,
 CONSTRAINT [PK_tblcity] PRIMARY KEY CLUSTERED 
(
	[cityid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblcity] ON
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (1, 1, N'Kattapana')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (2, 1, N'Thodupuzha')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (3, 2, N'Kochi')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (4, 2, N'Aluva')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (5, 3, N'Kilimanoor')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (6, 3, N'Ettumanoor')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (7, 4, N'Paravur')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (8, 5, N'Kinassery')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (9, 1, N'Kuttikanam')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (10, 1, N'Ramakalmedu')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (11, 1, N'Chettukuzhi')
INSERT [dbo].[tblcity] ([cityid], [districtid], [cityname]) VALUES (12, 2, N'Edappally')
SET IDENTITY_INSERT [dbo].[tblcity] OFF
/****** Object:  Table [dbo].[tblpollution]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblpollution](
	[pollutionid] [int] IDENTITY(1,1) NOT NULL,
	[loginid] [int] NULL,
	[regid] [int] NULL,
	[renewdate] [date] NULL,
 CONSTRAINT [PK_tblpollution] PRIMARY KEY CLUSTERED 
(
	[pollutionid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblpollution] ON
INSERT [dbo].[tblpollution] ([pollutionid], [loginid], [regid], [renewdate]) VALUES (1, 7, 2, CAST(0x9B3F0B00 AS Date))
INSERT [dbo].[tblpollution] ([pollutionid], [loginid], [regid], [renewdate]) VALUES (2, 7, 1, CAST(0x243F0B00 AS Date))
INSERT [dbo].[tblpollution] ([pollutionid], [loginid], [regid], [renewdate]) VALUES (3, 7, 4, CAST(0x723F0B00 AS Date))
SET IDENTITY_INSERT [dbo].[tblpollution] OFF
/****** Object:  Table [dbo].[tblpolicecomplaint]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblpolicecomplaint](
	[policecompliantid] [int] IDENTITY(1,1) NOT NULL,
	[regid] [int] NULL,
	[details] [varchar](200) NULL,
	[loginid] [int] NULL,
 CONSTRAINT [PK_tblpolicecomplaint] PRIMARY KEY CLUSTERED 
(
	[policecompliantid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblpolicecomplaint] ON
INSERT [dbo].[tblpolicecomplaint] ([policecompliantid], [regid], [details], [loginid]) VALUES (1, 1, N'Yes Police Complaints', 4)
INSERT [dbo].[tblpolicecomplaint] ([policecompliantid], [regid], [details], [loginid]) VALUES (2, 2, N'Yes Police Complaints', 5)
INSERT [dbo].[tblpolicecomplaint] ([policecompliantid], [regid], [details], [loginid]) VALUES (3, 4, N'Drunk and Drive', 5)
INSERT [dbo].[tblpolicecomplaint] ([policecompliantid], [regid], [details], [loginid]) VALUES (4, 3, N'Drunk and Drive', 4)
SET IDENTITY_INSERT [dbo].[tblpolicecomplaint] OFF
/****** Object:  Table [dbo].[tblservice]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblservice](
	[serviceid] [int] IDENTITY(1,1) NOT NULL,
	[loginid] [int] NULL,
	[regid] [int] NULL,
	[renewdate] [date] NULL,
	[details] [varchar](200) NULL,
 CONSTRAINT [PK_tblservice] PRIMARY KEY CLUSTERED 
(
	[serviceid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblservice] ON
INSERT [dbo].[tblservice] ([serviceid], [loginid], [regid], [renewdate], [details]) VALUES (1, 8, 1, CAST(0x453F0B00 AS Date), N'6th Service Completed')
INSERT [dbo].[tblservice] ([serviceid], [loginid], [regid], [renewdate], [details]) VALUES (2, 8, 2, CAST(0x813F0B00 AS Date), N'3rd Service Completed')
INSERT [dbo].[tblservice] ([serviceid], [loginid], [regid], [renewdate], [details]) VALUES (3, 8, 3, CAST(0x733F0B00 AS Date), N'4th Service Completed')
SET IDENTITY_INSERT [dbo].[tblservice] OFF
/****** Object:  Table [dbo].[tblvehiclereg]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblvehiclereg](
	[regid] [int] IDENTITY(1,1) NOT NULL,
	[loginid] [int] NULL,
	[vehicleid] [varchar](100) NULL,
	[cityid] [int] NULL,
	[briefdescription] [varchar](100) NULL,
	[dealername] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[makername] [varchar](100) NULL,
	[regownername] [varchar](100) NULL,
	[permanentaddr] [varchar](100) NULL,
	[classfvehicle] [varchar](100) NULL,
	[typeofbody] [varchar](100) NULL,
	[chassisno] [varchar](100) NULL,
	[engineno] [varchar](100) NULL,
	[fuel] [varchar](100) NULL,
	[color] [varchar](100) NULL,
	[yearofmanf] [varchar](100) NULL,
	[seatcapacity] [varchar](100) NULL,
	[tax] [varchar](100) NULL,
	[taxpaidon] [date] NULL,
	[file1] [varchar](8000) NULL,
	[mobile] [varchar](100) NULL,
 CONSTRAINT [PK_tblvehiclereg] PRIMARY KEY CLUSTERED 
(
	[regid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblvehiclereg] ON
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (1, 1, N'KL-69-A-7929', 2, N'Aprilia SR 150', N'Jey Motors', N'Kochi', N'Piaggio', N'Don Mathew', N'Thottupurathu', N'Solo', N'Fibre', N'M14TH7H', N'1234GH', N'Petrol', N'Black W Red', N'2018', N'2', N'25000', CAST(0xB83D0B00 AS Date), N'/Content/image/deadpool_fan_art_4k-3840x2160.jpg', N'9539010168')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (2, 2, N'KL-69-A-8029', 1, N'Royal Enfield', N'RE', N'Kattappana', N'Royal Enfield', N'Amal Kumar', N'SN Vilasam', N'Classic', N'Metal', N'M14TH56H', N'12334SD', N'Petrol', N'Gun Metal', N'2018', N'2', N'5000', CAST(0xB93D0B00 AS Date), N'/Content/image/bat.jpg', N'7510335296')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (3, 1, N'KL-37-B-6779', 1, N'Honda Dio', N'Dio Center', N'Kumily', N'Honda', N'Ajmal Akbar', N'Parakootathil', N'Solo', N'Fibre', N'M14TH7HJ', N'12334SDI', N'Petrol', N'Blue and White', N'2013', N'2', N'5000', CAST(0x08390B00 AS Date), N'/Content/image/gallery-11-01-2016-133912_1329035837-500x500.jpg', N'9633192646')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (4, 1, N'KL-07-A-0768', 1, N'Maruthi 800', N'Maruthi', N'Ernakulam', N'Maruthi', N'Abin Baby', N'Appicheril', N'Classic', N'Metal', N'M14TH56H', N'1234GHI', N'Petrol', N'White', N'2019', N'2', N'10000', CAST(0x2A400B00 AS Date), N'/Content/image/ADHD-Medication.jpg', N'7510335296')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (5, 1, N'KL-69-A-7920', 2, N'Royal Enfield', N'RE', N'Block xyz', N'Royal Enfield', N'Mathew Joseph', N'Ayyunickal', N'Solo', N'Metal', N'M23487HFJKS', N'128765HDHFJ', N'Petrol', N'Black', N'2013', N'2', N'5000', CAST(0x6C3F0B00 AS Date), N'/Content/image/gallery-11-01-2016-133912_1329035837-500x500.jpg', N'7510335296')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (6, 1, N'KL-69-A-1000', 1, N'Royal Enfield', N'RE', N'Kumily', N'Royal Enfield', N'Aju', N'Parakootathil', N'Solo', N'Metal', N'M14TH7HJK', N'12334SDIP', N'Petrol', N'Blue and White', N'2013', N'2', N'5000', CAST(0x713F0B00 AS Date), N'/Content/image/Aprilia-SR150-925833882s.jpg', N'7510335296')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (7, 1, N'KL-37-A-1223', 1, N'Maruthi Alto K10', N'Maruthi', N'Kattappana', N'Maruthi', N'Mathew TM', N'Thottupurathu', N'4 Wheel', N'Metal', N'M23487HFJ', N'128765HDHF', N'Petrol', N'White', N'2013', N'4', N'5000', CAST(0x903F0B00 AS Date), N'/Content/image/Aprilia-SR150-925833882s.jpg', N'9048471166')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (8, 1, N'KL-37-A-1220', 3, N'Honda Dio', N'Dio Center', N'Block xyz', N'Honda', N'Amal Reji', N'Black BJP', N'Solo', N'Fibre', N'M23487HFJPO', N'12334SDIJGF', N'Petrol', N'Blue and White', N'2018', N'2', N'5000', CAST(0x6D3D0B00 AS Date), N'/Content/image/gallery-11-01-2016-133912_1329035837-500x500.jpg', N'7510335296')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (9, 1, N'KL-37-B-6798', 1, N'Honda Dio', N'Dio Center', N'Block xyk', N'Honda', N'Raju Bhai', N'Parakootathil', N'Solo', N'Fibre', N'M14TH7HJKLP', N'128765HDHFJOP', N'Petrol', N'Blue and White', N'2013', N'2', N'5000', CAST(0x7F3F0B00 AS Date), N'/Content/image/gallery-11-01-2016-133912_1329035837-500x500.jpg', N'9633192646')
INSERT [dbo].[tblvehiclereg] ([regid], [loginid], [vehicleid], [cityid], [briefdescription], [dealername], [address], [makername], [regownername], [permanentaddr], [classfvehicle], [typeofbody], [chassisno], [engineno], [fuel], [color], [yearofmanf], [seatcapacity], [tax], [taxpaidon], [file1], [mobile]) VALUES (10, 1, N'KL-37-B-6771', 1, N'Royal', N'RE', N'Thottupurathu', N'Royal Enfield', N'Amal Re', N'Parakootathil', N'Solo', N'Metal', N'M14TH56HLL43HDGAQ', N'12334SDIJ', N'Petrol', N'White', N'2013', N'2', N'10000', CAST(0x953F0B00 AS Date), N'/Content/image/Aprilia-SR150-925833882s.jpg', N'9048471166')
SET IDENTITY_INSERT [dbo].[tblvehiclereg] OFF
/****** Object:  Table [dbo].[tblreg]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblreg](
	[regid] [int] IDENTITY(1,1) NOT NULL,
	[loginid] [int] NULL,
	[cityid] [int] NULL,
	[address] [varchar](100) NULL,
	[districtid] [int] NULL,
	[email] [varchar](100) NULL,
 CONSTRAINT [PK_tblreg] PRIMARY KEY CLUSTERED 
(
	[regid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblreg] ON
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (1, 1, 1, N'Thottupurathu', 1, N'iamamalkumarm@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (2, 2, 2, N'Appicheril', 1, N'iamamalkumarm@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (3, 4, 1, N'Parakootathil', 2, N'amalkumarm8036@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (4, 5, 3, N'Bodiveedu', 3, N'joyalshaji08@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (5, 6, 4, N'Block xy', 1, N'iaminsurance@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (6, 7, 1, N'Block abc', 1, N'iampuc@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (7, 8, 8, N'Block kj', 5, N'iamservice@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (8, 9, 8, N'block vj', 5, N'iamservice2@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (9, 10, 1, N'block x', 1, N'iaminsurance2@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (10, 11, 1, N'Block jka', 1, N'iamrto3@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (11, 12, 1, N'Block CYX', 1, N'iamrto4@gmail.com')
INSERT [dbo].[tblreg] ([regid], [loginid], [cityid], [address], [districtid], [email]) VALUES (12, 13, 11, N'Block xyz', 1, N'iamrto5@gmail.com')
SET IDENTITY_INSERT [dbo].[tblreg] OFF
/****** Object:  Table [dbo].[tblinsurance]    Script Date: 05/02/2019 11:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblinsurance](
	[insuranceid] [int] IDENTITY(1,1) NOT NULL,
	[loginid] [int] NULL,
	[regid] [int] NULL,
	[amount] [float] NULL,
	[renewdate] [date] NULL,
 CONSTRAINT [PK_tblinsurance] PRIMARY KEY CLUSTERED 
(
	[insuranceid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblinsurance] ON
INSERT [dbo].[tblinsurance] ([insuranceid], [loginid], [regid], [amount], [renewdate]) VALUES (1, 6, 1, 2900, CAST(0x463F0B00 AS Date))
INSERT [dbo].[tblinsurance] ([insuranceid], [loginid], [regid], [amount], [renewdate]) VALUES (2, 6, 2, 5000, CAST(0x253F0B00 AS Date))
INSERT [dbo].[tblinsurance] ([insuranceid], [loginid], [regid], [amount], [renewdate]) VALUES (3, 6, 4, 2900, CAST(0x713F0B00 AS Date))
INSERT [dbo].[tblinsurance] ([insuranceid], [loginid], [regid], [amount], [renewdate]) VALUES (4, 6, 3, 3000, CAST(0x713F0B00 AS Date))
INSERT [dbo].[tblinsurance] ([insuranceid], [loginid], [regid], [amount], [renewdate]) VALUES (5, 6, 7, 3000, CAST(0xB43F0B00 AS Date))
INSERT [dbo].[tblinsurance] ([insuranceid], [loginid], [regid], [amount], [renewdate]) VALUES (6, 6, 10, 3000, CAST(0x973F0B00 AS Date))
SET IDENTITY_INSERT [dbo].[tblinsurance] OFF
/****** Object:  Default [DF_tblfeedback_isread]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblfeedback] ADD  CONSTRAINT [DF_tblfeedback_isread]  DEFAULT ((0)) FOR [isread]
GO
/****** Object:  ForeignKey [FK_tblcity_tbldistrict]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblcity]  WITH CHECK ADD  CONSTRAINT [FK_tblcity_tbldistrict] FOREIGN KEY([districtid])
REFERENCES [dbo].[tbldistrict] ([districtid])
GO
ALTER TABLE [dbo].[tblcity] CHECK CONSTRAINT [FK_tblcity_tbldistrict]
GO
/****** Object:  ForeignKey [FK_tblinsurance_tbllogin]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblinsurance]  WITH CHECK ADD  CONSTRAINT [FK_tblinsurance_tbllogin] FOREIGN KEY([loginid])
REFERENCES [dbo].[tbllogin] ([loginid])
GO
ALTER TABLE [dbo].[tblinsurance] CHECK CONSTRAINT [FK_tblinsurance_tbllogin]
GO
/****** Object:  ForeignKey [FK_tblinsurance_tblvehiclereg]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblinsurance]  WITH CHECK ADD  CONSTRAINT [FK_tblinsurance_tblvehiclereg] FOREIGN KEY([regid])
REFERENCES [dbo].[tblvehiclereg] ([regid])
GO
ALTER TABLE [dbo].[tblinsurance] CHECK CONSTRAINT [FK_tblinsurance_tblvehiclereg]
GO
/****** Object:  ForeignKey [FK_tblpolicecomplaint_tbllogin]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblpolicecomplaint]  WITH CHECK ADD  CONSTRAINT [FK_tblpolicecomplaint_tbllogin] FOREIGN KEY([loginid])
REFERENCES [dbo].[tbllogin] ([loginid])
GO
ALTER TABLE [dbo].[tblpolicecomplaint] CHECK CONSTRAINT [FK_tblpolicecomplaint_tbllogin]
GO
/****** Object:  ForeignKey [FK_tblpollution_tbllogin]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblpollution]  WITH CHECK ADD  CONSTRAINT [FK_tblpollution_tbllogin] FOREIGN KEY([loginid])
REFERENCES [dbo].[tbllogin] ([loginid])
GO
ALTER TABLE [dbo].[tblpollution] CHECK CONSTRAINT [FK_tblpollution_tbllogin]
GO
/****** Object:  ForeignKey [FK_tblreg_tblcity]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblreg]  WITH CHECK ADD  CONSTRAINT [FK_tblreg_tblcity] FOREIGN KEY([cityid])
REFERENCES [dbo].[tblcity] ([cityid])
GO
ALTER TABLE [dbo].[tblreg] CHECK CONSTRAINT [FK_tblreg_tblcity]
GO
/****** Object:  ForeignKey [FK_tblreg_tbldistrict]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblreg]  WITH CHECK ADD  CONSTRAINT [FK_tblreg_tbldistrict] FOREIGN KEY([districtid])
REFERENCES [dbo].[tbldistrict] ([districtid])
GO
ALTER TABLE [dbo].[tblreg] CHECK CONSTRAINT [FK_tblreg_tbldistrict]
GO
/****** Object:  ForeignKey [FK_tblreg_tbllogin]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblreg]  WITH CHECK ADD  CONSTRAINT [FK_tblreg_tbllogin] FOREIGN KEY([loginid])
REFERENCES [dbo].[tbllogin] ([loginid])
GO
ALTER TABLE [dbo].[tblreg] CHECK CONSTRAINT [FK_tblreg_tbllogin]
GO
/****** Object:  ForeignKey [FK_tblservice_tbllogin]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblservice]  WITH CHECK ADD  CONSTRAINT [FK_tblservice_tbllogin] FOREIGN KEY([loginid])
REFERENCES [dbo].[tbllogin] ([loginid])
GO
ALTER TABLE [dbo].[tblservice] CHECK CONSTRAINT [FK_tblservice_tbllogin]
GO
/****** Object:  ForeignKey [FK_tblvehiclereg_tblcity]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblvehiclereg]  WITH CHECK ADD  CONSTRAINT [FK_tblvehiclereg_tblcity] FOREIGN KEY([cityid])
REFERENCES [dbo].[tblcity] ([cityid])
GO
ALTER TABLE [dbo].[tblvehiclereg] CHECK CONSTRAINT [FK_tblvehiclereg_tblcity]
GO
/****** Object:  ForeignKey [FK_tblvehiclereg_tbllogin]    Script Date: 05/02/2019 11:01:47 ******/
ALTER TABLE [dbo].[tblvehiclereg]  WITH CHECK ADD  CONSTRAINT [FK_tblvehiclereg_tbllogin] FOREIGN KEY([loginid])
REFERENCES [dbo].[tbllogin] ([loginid])
GO
ALTER TABLE [dbo].[tblvehiclereg] CHECK CONSTRAINT [FK_tblvehiclereg_tbllogin]
GO
