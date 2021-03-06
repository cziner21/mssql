USE [beadando]
GO
/****** Object:  Table [dbo].[isk_szak]    Script Date: 04/27/2014 18:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[isk_szak](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[neve] [nchar](255) NULL,
	[felevek_szama] [int] NULL,
 CONSTRAINT [PK_isk_szak] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[isk_nyelvizsga]    Script Date: 04/27/2014 18:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[isk_nyelvizsga](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[szint] [nchar](255) NULL,
	[tipus] [nchar](255) NULL,
	[nyelv] [nchar](255) NULL,
	[iskola] [nchar](255) NULL,
 CONSTRAINT [PK_isk_nyelvizsga] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[isk_varos]    Script Date: 04/27/2014 18:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[isk_varos](
	[id] [nchar](10) NOT NULL,
	[nev] [nchar](255) NULL,
	[megye] [nchar](255) NULL,
	[orszag] [nchar](255) NULL,
 CONSTRAINT [PK_isk_varos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[isk_delvaros]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[isk_delvaros]
    @ID varchar(10)
AS
BEGIN
    delete from isk_varos
    where isk_varos.id = @ID
    
END
GO
/****** Object:  StoredProcedure [dbo].[isk_delszak]    Script Date: 04/27/2014 18:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[isk_delszak]
    @ID int
AS
BEGIN
    delete from isk_szak
    where isk_szak.id = @ID
    
END
GO
/****** Object:  StoredProcedure [dbo].[isk_delnyelvizsga]    Script Date: 04/27/2014 18:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[isk_delnyelvizsga]
    @ID int
AS
BEGIN
    delete from isk_nyelvizsga
    where isk_nyelvizsga.id = @ID
    
END
GO
/****** Object:  StoredProcedure [dbo].[isk_upvaros]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[isk_upvaros]
    @nev varchar(255),
    @megye varchar(255),
    @orszag varchar(255),
    @varos_id varchar(10)
AS
BEGIN
    update isk_varos set nev = @nev, megye = @megye, orszag = @orszag
    where id = @varos_id
END
GO
/****** Object:  StoredProcedure [dbo].[isk_upszak]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[isk_upszak]
	@neve varchar(255),
	@felevek_szama int,
	@szak_id int
AS 
BEGIN 
	update isk_szak set neve = @neve, felevek_szama = @felevek_szama
	where id = @szak_id
END
GO
/****** Object:  StoredProcedure [dbo].[isk_upnyelvizsga]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[isk_upnyelvizsga]
	@szint varchar(255),
	@tipus varchar(255),
	@nyelv varchar(255),
	@iskola varchar(255),
	@nyelvizsga_id int
AS 
BEGIN 
	update isk_nyelvizsga set szint = @szint, tipus = @tipus, nyelv = @nyelv, iskola = @iskola
	where id = @nyelvizsga_id
END
GO
/****** Object:  Table [dbo].[isk_diak2]    Script Date: 04/27/2014 18:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[isk_diak2](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [nchar](255) NULL,
	[cim] [nchar](255) NULL,
	[tel_szam] [nchar](100) NULL,
	[anyja_neve] [nchar](255) NULL,
	[zsebpenz] [int] NULL,
	[varos_id] [nchar](10) NULL,
 CONSTRAINT [PK_isk_diak2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[isk_insszak]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[isk_insszak](
	@neve varchar(255),
	@felevek_szama int)
	
AS 
BEGIN 
	insert into isk_szak values (@neve, @felevek_szama)
	
END
GO
/****** Object:  StoredProcedure [dbo].[isk_insvaros]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[isk_insvaros](
	@varos_id varchar(10),
    @nev varchar(255),
    @megye varchar(255),
    @orszag varchar(255)
    )
AS
BEGIN
    insert into isk_varos values (@varos_id,@nev, @megye, @orszag)
    
END
GO
/****** Object:  StoredProcedure [dbo].[isk_insnyelvizsga]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[isk_insnyelvizsga](
	@szint varchar(255),
	@tipus varchar(255),
	@nyelv varchar(255),
	@iskola varchar(255))
AS 
BEGIN 
	insert into isk_nyelvizsga values (@szint, @tipus, @nyelv, @iskola)
	
END
GO
/****** Object:  StoredProcedure [dbo].[isk_insdiak2]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[isk_insdiak2](
	@nev varchar(255),
	@cim varchar(255),
	@tel_szam varchar(100),
	@anyja_neve varchar(255),
	@zsebpenz int,
	@varos_id varchar(10))
AS 
BEGIN 
	insert into isk_diak2 values (@nev, @cim, @tel_szam, @anyja_neve, @zsebpenz, @varos_id)
	
END
GO
/****** Object:  StoredProcedure [dbo].[isk_getalldiak]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[isk_getalldiak]
    
AS
BEGIN
    select * from isk_diak2
    
END
GO
/****** Object:  Table [dbo].[isk_diak_szak]    Script Date: 04/27/2014 18:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[isk_diak_szak](
	[diak_id] [int] NULL,
	[szak_id] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_isk_diak-szak] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[isk_diak_nyelvizsga]    Script Date: 04/27/2014 18:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[isk_diak_nyelvizsga](
	[diak_id] [int] NULL,
	[nyelvizsga_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[isk_updiak2]    Script Date: 04/27/2014 18:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[isk_updiak2]
	@nev varchar(255),
	@cim varchar(255),
	@tel_szam varchar(100),
	@anyja_neve varchar(255),
	@zsebpenz int,
	@varos_id varchar(10),
	@diak_id int
AS 
BEGIN 
	update isk_diak2 set nev = @nev, cim = @cim, tel_szam = @tel_szam, anyja_neve = @anyja_neve, zsebpenz = @zsebpenz, varos_id = @varos_id
	where id = @diak_id
END
GO
/****** Object:  StoredProcedure [dbo].[isk_deldiak2]    Script Date: 04/27/2014 18:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[isk_deldiak2]
    @ID int
AS
BEGIN
    delete from isk_diak2
    where isk_diak2.id = @ID
    
END
GO
/****** Object:  StoredProcedure [dbo].[ins_diak_nyelvizsga]    Script Date: 04/27/2014 18:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ins_diak_nyelvizsga]
    @diak_id int,
    @nyelvizsga_id int
AS
BEGIN
    insert into isk_diak_nyelvizsga values(@diak_id, @nyelvizsga_id)
END
GO
/****** Object:  ForeignKey [FK_isk_diak-nyelvizsga_isk_diak2]    Script Date: 04/27/2014 18:42:28 ******/
ALTER TABLE [dbo].[isk_diak_nyelvizsga]  WITH CHECK ADD  CONSTRAINT [FK_isk_diak-nyelvizsga_isk_diak2] FOREIGN KEY([diak_id])
REFERENCES [dbo].[isk_diak2] ([id])
GO
ALTER TABLE [dbo].[isk_diak_nyelvizsga] CHECK CONSTRAINT [FK_isk_diak-nyelvizsga_isk_diak2]
GO
/****** Object:  ForeignKey [FK_isk_diak-nyelvizsga_isk_nyelvizsga]    Script Date: 04/27/2014 18:42:28 ******/
ALTER TABLE [dbo].[isk_diak_nyelvizsga]  WITH CHECK ADD  CONSTRAINT [FK_isk_diak-nyelvizsga_isk_nyelvizsga] FOREIGN KEY([nyelvizsga_id])
REFERENCES [dbo].[isk_nyelvizsga] ([id])
GO
ALTER TABLE [dbo].[isk_diak_nyelvizsga] CHECK CONSTRAINT [FK_isk_diak-nyelvizsga_isk_nyelvizsga]
GO
/****** Object:  ForeignKey [FK_isk_diak-szak_isk_diak2]    Script Date: 04/27/2014 18:42:28 ******/
ALTER TABLE [dbo].[isk_diak_szak]  WITH CHECK ADD  CONSTRAINT [FK_isk_diak-szak_isk_diak2] FOREIGN KEY([diak_id])
REFERENCES [dbo].[isk_diak2] ([id])
GO
ALTER TABLE [dbo].[isk_diak_szak] CHECK CONSTRAINT [FK_isk_diak-szak_isk_diak2]
GO
/****** Object:  ForeignKey [FK_isk_diak-szak_isk_diak21]    Script Date: 04/27/2014 18:42:28 ******/
ALTER TABLE [dbo].[isk_diak_szak]  WITH CHECK ADD  CONSTRAINT [FK_isk_diak-szak_isk_diak21] FOREIGN KEY([id])
REFERENCES [dbo].[isk_diak2] ([id])
GO
ALTER TABLE [dbo].[isk_diak_szak] CHECK CONSTRAINT [FK_isk_diak-szak_isk_diak21]
GO
/****** Object:  ForeignKey [FK_isk_diak-szak_isk_diak-szak]    Script Date: 04/27/2014 18:42:28 ******/
ALTER TABLE [dbo].[isk_diak_szak]  WITH CHECK ADD  CONSTRAINT [FK_isk_diak-szak_isk_diak-szak] FOREIGN KEY([id])
REFERENCES [dbo].[isk_diak_szak] ([id])
GO
ALTER TABLE [dbo].[isk_diak_szak] CHECK CONSTRAINT [FK_isk_diak-szak_isk_diak-szak]
GO
/****** Object:  ForeignKey [FK_isk_diak-szak_isk_szak]    Script Date: 04/27/2014 18:42:28 ******/
ALTER TABLE [dbo].[isk_diak_szak]  WITH CHECK ADD  CONSTRAINT [FK_isk_diak-szak_isk_szak] FOREIGN KEY([szak_id])
REFERENCES [dbo].[isk_szak] ([id])
GO
ALTER TABLE [dbo].[isk_diak_szak] CHECK CONSTRAINT [FK_isk_diak-szak_isk_szak]
GO
/****** Object:  ForeignKey [FK_isk_diak2_isk_varos]    Script Date: 04/27/2014 18:42:28 ******/
ALTER TABLE [dbo].[isk_diak2]  WITH CHECK ADD  CONSTRAINT [FK_isk_diak2_isk_varos] FOREIGN KEY([varos_id])
REFERENCES [dbo].[isk_varos] ([id])
GO
ALTER TABLE [dbo].[isk_diak2] CHECK CONSTRAINT [FK_isk_diak2_isk_varos]
GO
