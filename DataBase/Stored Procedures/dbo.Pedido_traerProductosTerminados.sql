SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Pedido_traerProductosTerminados]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
SELECT        art_id AS ID, art_descrip AS Descripcion, art_precio AS Precio, art_stock_actual AS Stock
FROM            dbo.Articulo
WHERE        (fam_id = 2)
	RETURN
GO