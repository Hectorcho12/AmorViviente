USE [Amor_Viviente]
GO
/****** Object:  Table [dbo].[grupos]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupos](
	[GrpCod] [int] NOT NULL,
	[GrpNom] [varchar](30) NOT NULL,
	[SecNum] [int] NOT NULL,
	[GrpMmb] [int] NULL,
	[GrpEst] [bit] NOT NULL,
	[ZonNum] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GrpCod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Grupos_disp]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Grupos_disp]
AS
SELECT        GrpCod, GrpNom
FROM            dbo.grupos
WHERE        (GrpEst = 1)

GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[BitCod] [int] NOT NULL,
	[BitDes] [varchar](500) NULL,
	[UsrNom] [varchar](20) NOT NULL,
	[BitFch] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BitCod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diezmos]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diezmos](
	[DezReg] [int] NOT NULL,
	[MbrCod] [int] NOT NULL,
	[DezMnt] [int] NOT NULL,
	[DezMes] [date] NULL,
	[UsrNom] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[DezReg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Egresos]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egresos](
	[EgrCod] [int] NOT NULL,
	[EgrDes] [varchar](50) NOT NULL,
	[EgrMon] [int] NOT NULL,
	[UsrNom] [varchar](20) NULL,
	[Egrtipo] [int] NULL,
	[Egrfch] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[EgrCod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Miembros]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Miembros](
	[MbrCod] [int] NOT NULL,
	[MbrPriNom] [varchar](20) NOT NULL,
	[MbrSegNom] [varchar](20) NULL,
	[MbrPatApe] [varchar](20) NOT NULL,
	[MbrMatApe] [varchar](20) NULL,
	[MbrGen] [bit] NOT NULL,
	[GrpCod] [int] NOT NULL,
	[MbrFch] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MbrCod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ofrendas]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ofrendas](
	[Ofr_Reg] [int] NOT NULL,
	[Grp_Cod] [int] NOT NULL,
	[Ofr_Sem1] [int] NULL,
	[Ofr_Sem2] [int] NULL,
	[Ofr_Sem3] [int] NULL,
	[Ofr_Sem4] [int] NULL,
	[Ofr_Sem5] [int] NULL,
	[Ofr_Mes] [date] NOT NULL,
 CONSTRAINT [PK_Ofrendas] PRIMARY KEY CLUSTERED 
(
	[Ofr_Reg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsrNom] [varchar](20) NOT NULL,
	[UsrCon] [varchar](20) NOT NULL,
	[UsrCrg] [int] NOT NULL,
	[UsrEst] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UsrNom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuarios] FOREIGN KEY([UsrNom])
REFERENCES [dbo].[Usuarios] ([UsrNom])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuarios]
GO
ALTER TABLE [dbo].[Diezmos]  WITH CHECK ADD  CONSTRAINT [FK_Diezmos_Miembros] FOREIGN KEY([MbrCod])
REFERENCES [dbo].[Miembros] ([MbrCod])
GO
ALTER TABLE [dbo].[Diezmos] CHECK CONSTRAINT [FK_Diezmos_Miembros]
GO
ALTER TABLE [dbo].[Diezmos]  WITH CHECK ADD  CONSTRAINT [FK_Diezmos_Usuarios] FOREIGN KEY([UsrNom])
REFERENCES [dbo].[Usuarios] ([UsrNom])
GO
ALTER TABLE [dbo].[Diezmos] CHECK CONSTRAINT [FK_Diezmos_Usuarios]
GO
ALTER TABLE [dbo].[Egresos]  WITH CHECK ADD  CONSTRAINT [FK_Egresos_Usuarios] FOREIGN KEY([UsrNom])
REFERENCES [dbo].[Usuarios] ([UsrNom])
GO
ALTER TABLE [dbo].[Egresos] CHECK CONSTRAINT [FK_Egresos_Usuarios]
GO
ALTER TABLE [dbo].[Miembros]  WITH CHECK ADD  CONSTRAINT [FK_Miembros_grupos] FOREIGN KEY([GrpCod])
REFERENCES [dbo].[grupos] ([GrpCod])
GO
ALTER TABLE [dbo].[Miembros] CHECK CONSTRAINT [FK_Miembros_grupos]
GO
ALTER TABLE [dbo].[Ofrendas]  WITH CHECK ADD  CONSTRAINT [FK_Ofrendas_grupos] FOREIGN KEY([Grp_Cod])
REFERENCES [dbo].[grupos] ([GrpCod])
GO
ALTER TABLE [dbo].[Ofrendas] CHECK CONSTRAINT [FK_Ofrendas_grupos]
GO
/****** Object:  StoredProcedure [dbo].[Bit_Mostrar]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Bit_Mostrar]

as
select BitCod as Registro, BitDes as Descripcion,UsrNom as Usuario, BitFch as Fecha from bitacora
GO
/****** Object:  StoredProcedure [dbo].[Bit_Registro]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Bit_Registro]
@descripcion varchar(500), @Usuario varchar(20), @fecha date
as

declare @cod as integer = (select count(*) from Bitacora)
declare @codigo as integer

set @cod = @cod + 1
set @codigo = @cod


insert into Bitacora
values (@codigo,@descripcion,@Usuario,@fecha)
GO
/****** Object:  StoredProcedure [dbo].[Dez_Ingreso]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Dez_Ingreso]
@miembro integer,@monto integer, @mes date, @Usuario varchar(20)
as
declare @cod as integer = (select count(*) from Diezmos)
declare @codigo as integer

set @cod = @cod + 1
set @codigo = @cod

insert into Diezmos (DezReg ,MbrCod ,DezMnt ,DezMes ,UsrNom )
values (@codigo,@miembro,@monto,@mes,@Usuario)


GO
/****** Object:  StoredProcedure [dbo].[Dez_Modificacion]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Dez_Modificacion]
@cod integer, @miembro integer, @Monto integer, @mes date, @Usuario varchar(20)
as
update Diezmos
set MbrCod = @miembro, DezMnt = @Monto, DezMes = @mes, UsrNom = @Usuario
where DezReg = @cod


GO
/****** Object:  StoredProcedure [dbo].[Dez_Registros]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Dez_Registros]
@fecha date
as
select DezReg as Registro , DezMnt as Monto, DezMes as Mes, (Miembros.MbrPriNom + '' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe + ' ' + Miembros.MbrMatApe) as Miembro, Miembros.MbrCod as [Codigo Miembro] from diezmos inner join Miembros on Diezmos.MbrCod = Miembros.MbrCod 
where dezmes = @fecha 

GO
/****** Object:  StoredProcedure [dbo].[Egr_Ingreso]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Egr_Ingreso]
@descripcion varchar(50),@monto integer,@fecha date, @Usuario varchar(20), @tipo integer
as
declare @cod as integer = (select count(*) from Egresos)
declare @codigo as integer


set @cod = @cod + 1
set @codigo = @cod


insert into Egresos
values (@codigo,@descripcion,@monto,@Usuario,@tipo,@fecha)


GO
/****** Object:  StoredProcedure [dbo].[Egr_Modificacion]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Egr_Modificacion]
@codigo integer,@descripcion varchar(50),@monto integer, @Usuario varchar(20), @tipo integer, @fecha date
as

update Egresos
set EgrDes = @descripcion, EgrMon = @monto, UsrNom = @Usuario, Egrtipo = @tipo, Egrfch = @fecha
where EgrCod = @codigo


GO
/****** Object:  StoredProcedure [dbo].[Egr_Mostrar]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Egr_Mostrar]
as
select EgrCod as Codigo, EgrDes as Descripcion, EgrMon as Monto, Egrfch as Fecha, Egrtipo from egresos
GO
/****** Object:  StoredProcedure [dbo].[Grp_Buscador-Nombre]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Grp_Buscador-Nombre]
@Nombre varchar(30)
as
select GrpCod as [Codigo], GrpNom as [Nombre], SecNum as [Sector], GrpMmb as [Cantidad de miembros] from grupos
where GrpNom Like '%' + @Nombre + '%' and GrpEst = 1


GO
/****** Object:  StoredProcedure [dbo].[Grp_Buscador-Sector]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Grp_Buscador-Sector]
@sector integer
as
select GrpCod as Codigo, GrpNom as Nombre, SecNum as Sector, GrpMmb as [Cantidad de miembros] from grupos
where SecNum  Like @sector and GrpEst = 1



GO
/****** Object:  StoredProcedure [dbo].[Grp_Codgrupo]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Grp_Codgrupo]
@Nombre varchar (30)
as
select GrpCod from grupos
where GrpNom = @Nombre 
GO
/****** Object:  StoredProcedure [dbo].[Grp_grupos]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Grp_grupos]
as
select GrpNom from grupos
GO
/****** Object:  StoredProcedure [dbo].[Grp_Ingreso]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Grp_Ingreso]
@grupo varchar(30) , @Sector integer, @Miembros integer , @estado bit, @zona int
as
declare @cod as integer = (select count(*) from grupos)
declare @codigo as integer

set @cod = @cod + 1
set @codigo = @cod

insert into grupos 
(GrpCod, GrpNom, SecNum, GrpMmb, GrpEst, ZonNum)
values (@codigo,@grupo,@Sector,@Miembros,@estado,@zona)


GO
/****** Object:  StoredProcedure [dbo].[Grp_Modificacion]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Grp_Modificacion]
@codigo integer,@grupo varchar(30) , @Sector integer, @Miembros integer , @estado bit, @zona int
as
update grupos
set GrpNom = @grupo , SecNum = @Sector, GrpMmb = @Miembros, GrpEst = @estado, ZonNum = @zona
where GrpCod = @codigo 


GO
/****** Object:  StoredProcedure [dbo].[Grp_Mostrar]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Grp_Mostrar]
as
select GrpCod as Codigo, GrpNom as Nombre, secnum as Sector, GrpMmb as [Cantidad de miembros], ZonNum as Zona from grupos
where GrpEst = 1 

GO
/****** Object:  StoredProcedure [dbo].[Ingresar]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ingresar]
@Usuario varchar(20), @contraseña varchar(20)
as

select * from Usuarios
where UsrNom = @usuario
and UsrCon = @contraseña
and UsrEst = 1

GO
/****** Object:  StoredProcedure [dbo].[Mbr_Buscador]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Mbr_Buscador]
@Nombre varchar(30)
as
select Miembros.MbrCod as Codigo, (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre ,Miembros.MbrGen As Genero, Miembros.MbrFch as [Fch Nacimiento], grupos.GrpNom as Grupo from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod 
where (MbrPriNom +' ' + MbrSegNom + ' ' +MbrPatApe + ' ' +MbrMatApe) Like '%' + @Nombre + '%'


GO
/****** Object:  StoredProcedure [dbo].[Mbr_Buscador_Modificacion]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Mbr_Buscador_Modificacion]
@Nombre varchar(30)
as
select MbrCod as Codigo, MbrPriNom as [Primer nombre], MbrSegNom as [Segundo nombre]
, MbrPatApe as [Apellido paterno], MbrMatApe as [Apellido materno], MbrGen as Genero
, MbrFch as Fecha, grupos.GrpNom as Grupo from Miembros inner join grupos on miembros.GrpCod = grupos.GrpCod 
where (MbrPriNom +' ' + MbrSegNom + ' ' +MbrPatApe + ' ' +MbrMatApe) Like '%' + @Nombre + '%'


GO
/****** Object:  StoredProcedure [dbo].[Mbr_Buscador-grupo]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Mbr_Buscador-grupo]
@grupo varchar(30)
as
select Miembros.MbrCod as Codigo, (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre ,Miembros.MbrGen As Genero, Miembros.MbrFch as [Fch Nacimiento], grupos.GrpNom as Grupo from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod 
where GrpNom Like '%' + @grupo + '%'


GO
/****** Object:  StoredProcedure [dbo].[Mbr_Buscador-Sector]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Mbr_Buscador-Sector]
@sector integer
as
select Miembros.MbrCod as Codigo, (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre ,Miembros.MbrGen As Genero, Miembros.MbrFch as [Fch Nacimiento], grupos.GrpNom as Grupo from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod 
where SecNum Like @sector 


GO
/****** Object:  StoredProcedure [dbo].[Mbr_Ingreso]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Mbr_Ingreso]
@Pnom varchar(20), @Snom varchar(20) , @Pape varchar(20), @Sape varchar(20), @gen bit, @fecha date, @gru int
as
declare @cod as integer = (select count(*) from miembros)
declare @codigo as integer


set @Cod = @Cod + 1
set @codigo = @cod


insert into Miembros (MbrCod, MbrPriNom, MbrSegNom, MbrPatApe, MbrMatApe, MbrGen, MbrFch, GrpCod)
values (@codigo,@Pnom,@Snom,@Pape,@Sape,@gen,@fecha,@gru)


GO
/****** Object:  StoredProcedure [dbo].[Mbr_Modificacion]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Mbr_Modificacion]
@cod integer, @Pnom varchar(20), @Snom varchar(20) , @Pape varchar(20), @Sape varchar(20), @gen bit, @fecha date, @gru int
as
update miembros
set MbrPriNom = @Pnom, MbrSegNom = @Snom , MbrPatApe = @Pape, MbrMatApe = @Sape, MbrGen = @gen, MbrFch = @fecha , GrpCod = @gru
where MbrCod = @cod

GO
/****** Object:  StoredProcedure [dbo].[Mbr_Mostra-Modificacion]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Mbr_Mostra-Modificacion]
as
select MbrCod as Codigo, MbrPriNom as [Primer nombre], MbrSegNom as [Segundo nombre]
, MbrPatApe as [Apellido paterno], MbrMatApe as [Apellido materno], MbrGen as Genero
, MbrFch as Fecha, grupos.GrpNom as Grupo from Miembros inner join grupos on miembros.GrpCod = grupos.GrpCod 
GO
/****** Object:  StoredProcedure [dbo].[Mbr_Mostrar]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Mbr_Mostrar]
as
select Miembros.MbrCod as Codigo, (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre ,Miembros.MbrGen As Genero, Miembros.MbrFch as [Fch Nacimiento], grupos.GrpNom as Grupo from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod 

GO
/****** Object:  StoredProcedure [dbo].[Ofr_ComprobarVal]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ofr_ComprobarVal]
@grupo integer, @fecha date
as
select Ofrendas.Ofr_Reg from Ofrendas inner join grupos on grupos.GrpCod = ofrendas.Grp_Cod
where grupos.GrpCod = @grupo and Ofrendas.Ofr_Mes = @fecha

GO
/****** Object:  StoredProcedure [dbo].[Ofr_Ingreso]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ofr_Ingreso]
@grupo integer, @sem1 integer, @sem2 integer, @sem3 integer, @sem4 integer, @sem5 integer, @mes date
as
declare @cod as integer = (select count(*) from Ofrendas)
declare @codigo as integer

set @cod = @cod + 1
set @codigo = @cod

insert into Ofrendas
values(@codigo,@grupo,@sem1,@sem2,@sem3,@sem4,@sem5,@mes)
GO
/****** Object:  StoredProcedure [dbo].[Ofr_Modificar_Sem1]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ofr_Modificar_Sem1]
@cod integer, @sem1 integer
as
update Ofrendas
set Ofr_Sem1 = @sem1
where Ofr_Reg = @cod
GO
/****** Object:  StoredProcedure [dbo].[Ofr_Modificar_Sem2]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ofr_Modificar_Sem2]
@cod integer, @sem2 integer
as
update Ofrendas
set Ofr_Sem2 = @sem2
where Ofr_Reg = @cod
GO
/****** Object:  StoredProcedure [dbo].[Ofr_Modificar_Sem3]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ofr_Modificar_Sem3]
@cod integer, @sem3 integer
as
update Ofrendas
set Ofr_Sem3 = @sem3
where Ofr_Reg = @cod
GO
/****** Object:  StoredProcedure [dbo].[Ofr_Modificar_Sem4]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ofr_Modificar_Sem4]
@cod integer, @sem4 integer
as
update Ofrendas
set Ofr_Sem4 = @sem4
where Ofr_Reg = @cod
GO
/****** Object:  StoredProcedure [dbo].[Ofr_Modificar_Sem5]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ofr_Modificar_Sem5]
@cod integer, @sem5 integer
as
update Ofrendas
set Ofr_Sem5 = @sem5
where Ofr_Reg = @cod
GO
/****** Object:  StoredProcedure [dbo].[Ofr_Mostrar]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Ofr_Mostrar]
@mes date
as
select ofr_reg as [Codigo de Registro], ofrendas.Grp_Cod, grupos.grpnom as Grupo, ofrendas.Ofr_Sem1 as [Semana 1],   
ofrendas.Ofr_Sem2 as [Semana 2], ofrendas.Ofr_Sem3 as [Semana3], ofrendas.Ofr_Sem4 as [Semana 4],
ofrendas.Ofr_Sem5 as [Semana 5], ofrendas.Ofr_Mes 
from Ofrendas inner join grupos on ofrendas.Grp_Cod = grupos.GrpCod 
where ofrendas.Ofr_Mes = @mes

GO
/****** Object:  StoredProcedure [dbo].[Reportes_Diezmos]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reportes_Diezmos]
@zona integer, @sector integer, @desde date, @hasta date
as
select (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre , grupos.ZonNum As Zona, grupos.SecNum as Sector, grupos.GrpNom as Grupo, 'X' as Cantidad from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod
inner join diezmos on Diezmos.MbrCod = Miembros.MbrCod 
where grupos.ZonNum = @zona and grupos.SecNum = @Sector
and diezmos.DezMes between @desde and @hasta

  

GO
/****** Object:  StoredProcedure [dbo].[Reportes_Diezmos_M]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reportes_Diezmos_M]
@miembro integer, @desde date, @hasta date
as
select (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre , grupos.ZonNum As Zona, grupos.SecNum as Sector, grupos.GrpNom as Grupo, 
'X' as Cantidad from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod
inner join diezmos on Diezmos.MbrCod = Miembros.MbrCod 
where Diezmos.MbrCod = @miembro
and diezmos.DezMes between @desde and @hasta

  
GO
/****** Object:  StoredProcedure [dbo].[Reportes_Diezmos_MSX]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Reportes_Diezmos_MSX]
@miembro integer, @desde date, @hasta date
as
select (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre , grupos.ZonNum As Zona, grupos.SecNum as Sector, grupos.GrpNom as Grupo, 
Diezmos.DezMnt as Cantidad from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod
inner join diezmos on Diezmos.MbrCod = Miembros.MbrCod 
where Diezmos.MbrCod = @miembro
and diezmos.DezMes between @desde and @hasta

GO
/****** Object:  StoredProcedure [dbo].[Reportes_Diezmos_Zona]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reportes_Diezmos_Zona]
@zona integer,  @desde date, @hasta date
as
select (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre , grupos.ZonNum As Zona, grupos.SecNum as Sector, grupos.GrpNom as Grupo, 'X' as Cantidad from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod
inner join diezmos on Diezmos.MbrCod = Miembros.MbrCod 
where grupos.ZonNum = @zona 
and diezmos.DezMes between @desde and @hasta

  

GO
/****** Object:  StoredProcedure [dbo].[Reportes_Diezmos_ZonaSX]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reportes_Diezmos_ZonaSX]
@zona integer,  @desde date, @hasta date
as
select (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre , grupos.ZonNum As Zona, grupos.SecNum as Sector, grupos.GrpNom as Grupo, Diezmos.DezMnt as Cantidad from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod
inner join diezmos on Diezmos.MbrCod = Miembros.MbrCod 
where grupos.ZonNum = @zona 
and diezmos.DezMes between @desde and @hasta

  

GO
/****** Object:  StoredProcedure [dbo].[Reportes_DiezmosSX]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Reportes_DiezmosSX]
@zona integer, @sector integer, @desde date, @hasta date
as
select (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre , grupos.ZonNum As Zona, grupos.SecNum as Sector, grupos.GrpNom as Grupo, Diezmos.DezMnt as Cantidad from Miembros inner join grupos on Miembros.GrpCod = grupos.GrpCod
inner join diezmos on Diezmos.MbrCod = Miembros.MbrCod 
where grupos.ZonNum = @zona and grupos.SecNum = @Sector
and diezmos.DezMes between @desde and @hasta

  

GO
/****** Object:  StoredProcedure [dbo].[Reportes_Egresos_capital]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reportes_Egresos_capital]
@desde date , @hasta date
as
select EgrDes as Descripcion3, EgrMon as Cantidad3 from Egresos
where Egrfch between @desde and @hasta
and Egrtipo = 3

GO
/****** Object:  StoredProcedure [dbo].[Reportes_Egresos_entradas]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reportes_Egresos_entradas]
@desde date , @hasta date
as
select EgrDes as Descripcion1, EgrMon as Cantidad1 from Egresos
where Egrfch between @desde and @hasta
and Egrtipo = 1

GO
/****** Object:  StoredProcedure [dbo].[Reportes_Egresos_salidas]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reportes_Egresos_salidas]
@desde date , @hasta date
as
select EgrDes as Descripcion2, EgrMon as Cantidad2 from Egresos
where Egrfch between @desde and @hasta
and Egrtipo = 2

GO
/****** Object:  StoredProcedure [dbo].[Reportes_Membresia]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Reportes_Membresia]
@miembro integer
as
select (Miembros.MbrPriNom + ' ' + Miembros.MbrSegNom + ' ' + Miembros.MbrPatApe
+ ' ' + Miembros.MbrMatApe) as Nombre , grupos.grpnom as Grupo
 from Miembros inner join grupos on miembros.GrpCod = grupos.GrpCod
 where miembros.mbrcod = @miembro 
GO
/****** Object:  StoredProcedure [dbo].[Reportes_Ofrenda]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reportes_Ofrenda]
@fecha date, @zona integer, @sector integer
as
Select grupos.GrpNom as Nombre, grupos.ZonNum as Zona, grupos.SecNum as Sector,
Ofrendas.Ofr_Sem1 as [Semana_1], Ofrendas.Ofr_Sem2 as [Semana_2], Ofrendas.Ofr_Sem3 as [Semana_3], 
Ofrendas.Ofr_Sem4 as [Semana_4], Ofrendas.Ofr_Sem5 as [Semana_5] from ofrendas inner join grupos on ofrendas.Grp_Cod = grupos.GrpCod 
where Ofr_Mes = @fecha and grupos.ZonNum = @zona and grupos.SecNum = @sector

GO
/****** Object:  StoredProcedure [dbo].[Sec_ingreso]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sec_ingreso]
@sector integer, @zona integer
as
insert into Sectores (SecNum ,ZonNum)
values (@sector ,@zona)


GO
/****** Object:  StoredProcedure [dbo].[Sec_Modificacion]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sec_Modificacion]
@sector integer, @zona integer
as
update Sectores
set ZonNum = @zona
where SecNum = @sector

GO
/****** Object:  StoredProcedure [dbo].[Sec_Mostrar_CBX]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sec_Mostrar_CBX] 
@zona integer
as
select SecNum from Sectores
where ZonNum = @zona


GO
/****** Object:  StoredProcedure [dbo].[Usr_buscador]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usr_buscador]
@user varchar(30)
as
select UsrNom as Nombre, UsrCon as Contraseña from usuarios
where usrest = 1 and UsrNom Like '%' + @user + '%'
GO
/****** Object:  StoredProcedure [dbo].[Usr_Ingreso]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Usr_Ingreso]
@ID varchar(20), @Pass varchar(20) ,@cargo integer, @estado bit
as
insert into Usuarios
(UsrNom, UsrCon, UsrCrg, UsrEst)
values (@ID,@Pass,@cargo,@estado)


GO
/****** Object:  StoredProcedure [dbo].[Usr_Modificacion]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Usr_Modificacion]
@ID varchar(20), @Pass varchar(20) ,@cargo integer, @estado bit
as
update Usuarios
set UsrCon = @Pass, UsrCrg = @cargo , UsrEst = @estado
where UsrNom = @ID



GO
/****** Object:  StoredProcedure [dbo].[Usr_Mostrar]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usr_Mostrar]
as
select UsrNom as Nombre, UsrCon as Contraseña from usuarios
where usrest = 1
GO
/****** Object:  StoredProcedure [dbo].[Zon_Ingreso]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Zon_Ingreso]
@zona integer
as
insert into Zonas (ZonNum)
values (@zona)

GO
/****** Object:  StoredProcedure [dbo].[Zon_Mostrar_CBX]    Script Date: 23/11/2019 10:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Zon_Mostrar_CBX] 
as
select ZonNum from zonas


GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "grupos"
            Begin Extent = 
               Top = 23
               Left = 198
               Bottom = 152
               Right = 407
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Grupos_disp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Grupos_disp'
GO
