CREATE TABLE [dbo].[D400_INGRESO_HISTORICO] (
    [id] bigint  NOT NULL,
    [coleccion] varchar(max)  NULL,
    [idcoleccion] varchar(max)  NULL,
    [sector] varchar(max)  NULL,
    [filtro_url] varchar(max)  NULL,
    [tema] varchar(max)  NULL,
    [contenido] varchar(max)  NULL,
    [escala] varchar(max)  NULL,
    [pais] varchar(max)  NULL,
    [territorio] varchar(max)  NULL,
    [filtro_integrado] varchar(max)  NULL,
    [muestra_temporalidad] varchar(max)  NULL,
    [temporalidad] varchar(max)  NULL,
    [unidad_medida] varchar(max)  NULL,
    [fuente] varchar(max)  NULL,
    [titulo] varchar(max)  NULL,
    [descripcion_larga] varchar(max)  NULL,
    [visualizacion] varchar(max)  NULL,
    [tag] varchar(max)  NULL,
    [url] varchar(max)  NULL,
    [suscripcion] bigint  NULL,
    [color] varchar(max)  NULL,
    [id_grafico] varchar(max)  NULL,
    [id_territorio] varchar(max)  NULL,
    [id_tema] varchar(max)  NULL,
    [id_contenido] varchar(max)  NULL,
    [id_filtro] varchar(max)  NULL,
    [id_muestra] varchar(max)  NULL
);


ALTER TABLE [dbo].[D400_INGRESO_HISTORICO]
ADD CONSTRAINT [PK_D400_INGRESO_HISTORICO]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO



--id_tema	Tema	id_tabla	titulo_box	id_filtro1	desc_filtro1	id_filtro2	desc_filtro2	Texto	URL Miniatura	URL Expandida	Activo

CREATE TABLE [dbo].[BOX_INFOTMATION] (
    [id] bigint  NOT NULL,
    [id_tema] bigint  NULL,
    [id_tabla] bigint  NULL,
    [titulo_box] varchar(max)  NULL,
    [id_filtro1] bigint  NULL,
    [desc_filtro1] varchar(max)  NULL,
    [id_filtro2] bigint  NULL,
    [desc_filtro2] varchar(max)  NULL,
    [descripcion] varchar(max)  NULL,
    [url_miniatura] varchar(max)  NULL,
    [url_expandida] varchar(max)  NULL,
    [activo] int  NULL,
    [aux] varchar(max)  NULL,
    [aux2] varchar(max)  NULL
);


ALTER TABLE [dbo].[BOX_INFOTMATION]
ADD CONSTRAINT [PK_BOX_INFOTMATION]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO





CREATE TABLE [dbo].[TABLA_SEMANARIO] (
    [id] bigint  NOT NULL,
    [nombre] varchar(max)  NULL,
    [url] varchar(max)  NULL,
    [observacion] varchar(max)  NULL,
    [detalles] varchar(max)  NULL,
    [otro] varchar(max)  NULL,
    [fecha_publicacion] varchar(max)  NULL,
    [auxiliar] varchar(max)  NULL  ,
	[tabla_padre] varchar(max)  NULL,
	[tabla_id] varchar(max)  NULL
);


ALTER TABLE [dbo].[TABLA_SEMANARIO]
ADD CONSTRAINT [PK_TABLA_SEMANARIO]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO


CREATE TABLE [dbo].[D241_REGION] (
    [id] bigint  NOT NULL,
    [coleccion] varchar(max)  NULL,
    [idcoleccion] varchar(max)  NULL,
    [sector] varchar(max)  NULL,
    [filtro_url] varchar(max)  NULL,
    [tema] varchar(max)  NULL,
    [contenido] varchar(max)  NULL,
    [escala] varchar(max)  NULL,
    [pais] varchar(max)  NULL,
    [territorio] varchar(max)  NULL,
    [filtro_integrado] varchar(max)  NULL,
    [muestra_temporalidad] varchar(max)  NULL,
    [temporalidad] varchar(max)  NULL,
    [unidad_medida] varchar(max)  NULL,
    [fuente] varchar(max)  NULL,
    [titulo] varchar(max)  NULL,
    [descripcion_larga] varchar(max)  NULL,
    [visualizacion] varchar(max)  NULL,
    [tag] varchar(max)  NULL,
    [url] varchar(max)  NULL,
    [suscripcion] bigint  NULL,
    [color] varchar(max)  NULL,
    [id_grafico] varchar(max)  NULL,
    [id_territorio] varchar(max)  NULL,
    [id_tema] varchar(max)  NULL,
    [id_contenido] varchar(max)  NULL,
    [id_filtro] varchar(max)  NULL,
    [id_muestra] varchar(max)  NULL,
	[url2] varchar(max)  NULL,
	[url3] varchar(max)  NULL,
	[url4] varchar(max)  NULL
);


ALTER TABLE [dbo].[D241_REGION]
ADD CONSTRAINT [PK_D241_REGION]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO
