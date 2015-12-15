USE [PL_Universidad]
GO
CREATE procedure [dbo].[sp_BuscarCursosPorProfesor]
	@ID_Usuario nvarchar(128)
AS
BEGIN
	SELECT c.ID 
	  ,c.ID_Profesor
      ,c.ID_Materia
      ,c.ID_Cuatrimestre
      ,c.Estado
      ,c.ID_Dia
      ,c.Hora_Entrada
      ,c.Hora_Salida
	  ,m.Nombre FROM CURSO c INNER JOIN MATERIA m
	ON ID_Profesor = @ID_Usuario AND m.ID = c.ID_Materia
END;
GO

CREATE procedure [dbo].[sp_BuscarEstudiantesPorMatriculaPorCurso]
	@ID_Curso uniqueidentifier
AS
BEGIN
	SELECT m.ID_Estudiante, e.Nombre FROM Matricula m INNER JOIN Datos_Personales e
	ON e.ID_Usuario = m.ID_Estudiante AND m.ID_Curso = @ID_Curso
END;
GO

exec sp_Buscar

CREATE procedure [dbo].[sp_ListarRubros]
AS
BEGIN
	SELECT * FROM Rubro
END;
GO

USE [PL_Universidad]
GO
ALTER procedure [dbo].[sp_Insertar_Calificacion]
	@ID uniqueidentifier,
	@ID_Matricula uniqueidentifier,
	@ID_Rubro uniqueidentifier,
	@Nota float
AS
BEGIN
	INSERT INTO dbo.Calificacion
	(ID, ID_Matricula, ID_Rubro,Nota,Estado,FechayHoraDesbloqueo)
	VALUES
	(NEWID(), @ID_Matricula, @ID_Rubro,@Nota,0,GETDATE())
END;

USE [PL_Universidad]
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarEstudiantesPorMatriculaPorCurso]    Script Date: 14/12/2015 1:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_BuscarEstudiantesPorMatriculaPorCurso]
	@ID_Curso uniqueidentifier
AS
BEGIN
	SELECT m.ID_Estudiante, (e.Nombre + ' ' + e.Primer_Apellido) as Nombre FROM Matricula m INNER JOIN Datos_Personales e
	ON e.ID_Usuario = m.ID_Estudiante AND m.ID_Curso = @ID_Curso
END;

CREATE procedure [dbo].[sp_Modificar_Calificacion]
	@ID uniqueidentifier,
	@Nota float
AS
BEGIN
	UPDATE dbo.Calificacion
	SET 
	NOTA = @Nota,
	ESTADO = 0,
	FECHAYHORADESBLOQUEO = GETDATE()
	WHERE ID = @ID
END;

CREATE procedure [dbo].[sp_Desbloquear_Calificacion]
	@ID uniqueidentifier
AS
BEGIN
	UPDATE dbo.Calificacion
	SET
	ESTADO = 1,
	FECHAYHORADESBLOQUEO = GETDATE()
	WHERE ID = @ID
END;
GO

ALTER procedure [dbo].[sp_Buscar_Calificaciones_Por_Estudiante]
	@ID_Estudiante uniqueidentifier,
	@ID_Matricula uniqueidentifier
AS
BEGIN
	SELECT r.ID,r.Descripcion,r.Porcentaje, c.ID,c.Nota,c.Estado,c.FechayHoraDesbloqueo,m.id,m.ID_Estudiante,m.ID_Curso,mt.Nombre as Materia
    FROM Calificacion c INNER JOIN Matricula m
	ON c.ID_Matricula = m.ID AND m.ID_Estudiante = @ID_Estudiante AND c.ID_Matricula = @ID_Matricula
	INNER JOIN Curso cu
	ON m.ID_Curso = cu.ID
	INNER JOIN Materia mt
	ON mt.ID = cu.ID_Materia
	INNER JOIN Rubro r 
	ON r.ID = c.ID_Rubro
END;
GO

CREATE procedure [dbo].[sp_Buscar_Calificacion_Por_Id]
	@ID uniqueidentifier
AS
BEGIN
	SELECT r.ID,r.Descripcion,r.Porcentaje, c.ID,c.Nota,c.Estado,c.FechayHoraDesbloqueo,m.id,m.ID_Estudiante,m.ID_Curso,mt.Nombre as Materia
    FROM Calificacion c INNER JOIN Matricula m
	ON c.ID_Matricula = m.ID
	INNER JOIN Curso cu
	ON m.ID_Curso = cu.ID
	INNER JOIN Materia mt
	ON mt.ID = cu.ID_Materia
	INNER JOIN Rubro r 
	ON r.ID = c.ID_Rubro AND c.ID = @ID
END;
GO

USE [PL_Universidad]
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarCursosPorProfesor]    Script Date: 14/12/2015 8:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_BuscarCursosPorProfesor]
	@ID_Usuario nvarchar(128)
AS
BEGIN
	SELECT c.ID 
	  ,c.ID_Profesor
      ,c.ID_Materia
      ,c.ID_Cuatrimestre
      ,c.Estado
      ,c.ID_Dia
      ,c.Hora_Entrada
      ,c.Hora_Salida
	  ,m.Nombre
	  ,ml.ID as Matricula 
	  FROM CURSO c INNER JOIN MATERIA m ON m.ID = c.ID_Materia 
	  INNER JOIN MATRICULA ml ON ml.ID_Curso = c.ID 
	  AND c.ID_Profesor = @ID_Usuario
END;

USE [PL_Universidad]
GO
/****** Object:  StoredProcedure [dbo].[sp_Buscar_Datos_Personales]    Script Date: 14/12/2015 9:34:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_Buscar_Datos_Personales]
	@Id uniqueidentifier
as
begin
	select dp.Nombre, dp.Primer_Apellido, dp.Segundo_Apellido,
	dp.Numero_Identificacion, ID_Pais,
	dp.ID_Provincia, dp.ID_Canton, dp.ID_Distrito, dp.Direccion,
	dp.Telefono_Fijo, dp.Telefono_Movil, dp.Correo,
	dp.URL_Foto, g.Descripcion, ec.Descripcion
	from dbo.Datos_Personales dp, dbo.Genero g, dbo.Estado_Civil ec
	where dp.ID_Usuario = @Id
	and dp.ID_Genero = g.ID
	and dp.ID_Estado_Civil = ec.ID
end
