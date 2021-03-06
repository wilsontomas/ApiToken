USE [Noticias]
GO
/****** Object:  Table [dbo].[ArticulosNoticias]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArticulosNoticias](
	[IdNoticias] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](max) NOT NULL,
	[Articulo] [varchar](max) NOT NULL,
	[Fecha] [datetime] NULL DEFAULT (getdate()),
	[CategoriaId] [int] NOT NULL,
	[PaisId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNoticias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pais](
	[IdPais] [int] IDENTITY(1,1) NOT NULL,
	[NombrePais] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](100) NULL,
	[Clave] [varchar](400) NULL,
	[NombreCompleto] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ArticulosNoticias] ON 

INSERT [dbo].[ArticulosNoticias] ([IdNoticias], [Titulo], [Articulo], [Fecha], [CategoriaId], [PaisId]) VALUES (1, N'Martínez y De Jesús ganan dos en inicio del Clasificatorio Norceca', N'Los dominicanos Oscar Martínez y Hayerling de Jesús derrotó 2-0 (21-16, 21-16) a Criforth Lobos y Daniel Dyner, de Costa Rica, en el  inicio del Clasificatorio NORCECA de Voleibol de Playa, que se escenifica hasta el próximo domingo en el litoral de Punta Cana, Higuey. En su segunda presentación de la justa dedicada al empresario Ernesto Veloz, Martínez y De Jesús, el binomio “A” de República Dominicana, dio cuenta idéntico marcador de Río Víctor y Levi Leonce, de Santa Lucía . La pareja “B” de Qusiqueya, conformada por Rayner Sarmiento y Deivy Ramírez del país tropezó con  los cubanos Noslen Díaz y Luis Reyes, quien es lo superaron fácilmente 21-8, 21-10.', CAST(N'2021-07-03 13:07:41.910' AS DateTime), 1, 1)
INSERT [dbo].[ArticulosNoticias] ([IdNoticias], [Titulo], [Articulo], [Fecha], [CategoriaId], [PaisId]) VALUES (2, N'Miderec anuncia plan de deporte', N'bla bla bla', CAST(N'2021-07-03 13:07:41.920' AS DateTime), 2, 2)
INSERT [dbo].[ArticulosNoticias] ([IdNoticias], [Titulo], [Articulo], [Fecha], [CategoriaId], [PaisId]) VALUES (6, N'Tercera', N'Prueba 3
        ', CAST(N'2021-07-07 18:03:06.440' AS DateTime), 1, 1)
INSERT [dbo].[ArticulosNoticias] ([IdNoticias], [Titulo], [Articulo], [Fecha], [CategoriaId], [PaisId]) VALUES (7, N'Arturo Zaldívar no ampliará su mandato como magistrado presidente de la Suprema Corte de Justicia de México', N'El magistrado presidente de la Suprema Corte de Justicia de México, Arturo Zaldívar, informó este viernes que desiste de ampliar su mandato por dos años adicionales, como había propuesto el presidente de México, Andrés López Obrador, en una ley que fue aprobada por el Congreso en abril. Krupskaia Alís nos explica por quéZaldívar tomó esta decisión y qué dijo al respecto el mandatario.', CAST(N'2021-08-07 18:22:44.390' AS DateTime), 6, 9)
INSERT [dbo].[ArticulosNoticias] ([IdNoticias], [Titulo], [Articulo], [Fecha], [CategoriaId], [PaisId]) VALUES (8, N'Detectan en Chiriquí el primer contagio comunitario de la variante Delta', N'La variante Delta ya circula en Panamá, confirmó este viernes el ministro de Salud, Luis Francisco Sucre.

El titular de Salud aseguró que ese primer contagio comunitario se detectó en la provincia de Chiriquí, sin precisar el lugar exacto.

Aunado a éste, en el Aeropuerto Internacional de Tocumen lograron detectar la misma variante en 17 pasajeros.', CAST(N'2021-08-07 18:24:50.247' AS DateTime), 6, 3)
INSERT [dbo].[ArticulosNoticias] ([IdNoticias], [Titulo], [Articulo], [Fecha], [CategoriaId], [PaisId]) VALUES (9, N'Crean App de celular para reportar violencia de género y recibir asistencia inmediata', N'Organizaciones feministas han creado la aplicación de celular ‘No Estás Sola’ que cuenta con un botón de pánico que podrá ser usada por mujeres que se encuentren en una situación de violencia o peligro para enviar una señal de alerta a sus contactos de confianza y así puedan ser auxiliadas. En las primeras 48 horas de lanzamientos ya cuenta con 200 descargas.', CAST(N'2021-08-07 18:26:24.147' AS DateTime), 6, 4)
SET IDENTITY_INSERT [dbo].[ArticulosNoticias] OFF
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (1, N'Deportes')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (2, N'Musica')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (3, N'Peliculas')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (4, N'Arte')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (5, N'Tecnologia')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (6, N'Politica')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
SET IDENTITY_INSERT [dbo].[Pais] ON 

INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (1, N'Rep Dominicana')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (2, N'Estados Unidos')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (3, N'Panama')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (4, N'Peru')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (5, N'Colombia')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (6, N'Argentina')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (7, N'Venezuela')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (8, N'Chile')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (9, N'Mexico')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (10, N'Suiza')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (11, N'Alemania')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (12, N'Rusia')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (13, N'Japon')
INSERT [dbo].[Pais] ([IdPais], [NombrePais]) VALUES (14, N'China')
SET IDENTITY_INSERT [dbo].[Pais] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([UsuarioId], [NombreUsuario], [Clave], [NombreCompleto]) VALUES (1, N'Wilson', N'3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2', N'Wilson Tomas')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[ArticulosNoticias]  WITH CHECK ADD FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[ArticulosNoticias]  WITH CHECK ADD FOREIGN KEY([PaisId])
REFERENCES [dbo].[Pais] ([IdPais])
GO
/****** Object:  StoredProcedure [dbo].[EditarNoticia]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarNoticia]
(@IdNoticias int,@Titulo varchar(max),@Articulo varchar(max),@CategoriaId int,@PaisId int)
as set nocount on
begin
update ArticulosNoticias set Titulo =@Titulo, Articulo=@Articulo, CategoriaId=@CategoriaId, PaisId=@PaisId where IdNoticias = @IdNoticias;
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarNoticia]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarNoticia]
(@IdNoticia int)
as set nocount on
begin
delete from ArticulosNoticias where IdNoticias = @IdNoticia
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarNoticia]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarNoticia]
(@Titulo varchar(max),@Articulo varchar(max),@CategoriaId int,@PaisId int)
as set nocount on
begin
insert into ArticulosNoticias (Titulo,Articulo,CategoriaId, PaisId) values (@Titulo, @Articulo, @CategoriaId, @PaisId)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuarios]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarUsuarios]
(@nombre varchar(100), @NombreCompleto varchar(250), @Clave varchar(400))
as begin
	set @Clave = CONVERT(VARCHAR(MAX), HASHBYTES('SHA2_512',@Clave),2)
	
	insert into Usuarios (NombreUsuario,NombreCompleto,Clave) values (@nombre,@NombreCompleto, @Clave)
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerCategoria]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ObtenerCategoria]
as set nocount on
begin
select c.IdCategoria,c.NombreCategoria from Categoria c
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNoticiaPorBusqueda]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ObtenerNoticiaPorBusqueda]
(@termino varchar(255))
as set nocount on
begin
select a.IdNoticias, a.Titulo, a.Articulo, a.Fecha,c.NombreCategoria, p.NombrePais 
from ArticulosNoticias a inner join Categoria c on a.CategoriaId=c.IdCategoria 
inner join Pais p on a.PaisId = p.IdPais where a.Titulo like '%'+@termino+'%' or a.Articulo like '%'+@termino+'%';
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNoticiaPorId]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ObtenerNoticiaPorId]
(@IdNoticia int)
as set nocount on
begin
select a.IdNoticias, a.Titulo, a.Articulo, a.Fecha,c.NombreCategoria, p.NombrePais 
from ArticulosNoticias a inner join Categoria c on a.CategoriaId=c.IdCategoria
 inner join Pais p on a.PaisId = p.IdPais where a.IdNoticias=@IdNoticia
	end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNoticias]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ObtenerNoticias]
as set nocount on
begin
 select a.IdNoticias,a.Titulo,a.Articulo,a.Fecha, a.PaisId,a.CategoriaId from ArticulosNoticias a
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNoticiasModel]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ObtenerNoticiasModel]
as set nocount on
begin
	select a.IdNoticias, a.Titulo, a.Articulo, a.Fecha,c.NombreCategoria, p.NombrePais from ArticulosNoticias a inner join Categoria c on a.CategoriaId=c.IdCategoria inner join Pais p on a.PaisId = p.IdPais
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNoticiasPorCategoria]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ObtenerNoticiasPorCategoria]
(@idcategoria int)
as set nocount on
begin
select a.IdNoticias, a.Titulo, a.Articulo, a.Fecha,c.NombreCategoria, p.NombrePais from ArticulosNoticias a inner join Categoria c on a.CategoriaId=c.IdCategoria inner join Pais p on a.PaisId = p.IdPais where a.CategoriaId=@idcategoria
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNoticiasPorPais]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ObtenerNoticiasPorPais]
(@idpais int)
as set nocount on
begin
select a.IdNoticias, a.Titulo, a.Articulo, a.Fecha,c.NombreCategoria, p.NombrePais from ArticulosNoticias a inner join Categoria c on a.CategoriaId=c.IdCategoria inner join Pais p on a.PaisId = p.IdPais where a.PaisId=@idpais

end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPais]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ObtenerPais]
as set nocount on
begin
select p.IdPais,p.NombrePais from Pais p
end
GO
/****** Object:  StoredProcedure [dbo].[validarUsuario]    Script Date: 7/8/2021 6:27:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[validarUsuario]
(@nombre varchar(100), @Clave varchar(400))
as begin
	set @Clave = CONVERT(VARCHAR(MAX), HASHBYTES('SHA2_512',@Clave),2)
	select * from Usuarios u where u.NombreUsuario =@nombre and u.Clave=@Clave 
end
GO
