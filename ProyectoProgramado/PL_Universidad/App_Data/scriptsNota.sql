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
CREATE procedure [dbo].[sp_Insertar_Calificacion]
	@ID uniqueidentifier,
	@ID_Matricula uniqueidentifier,
	@ID_Rubro uniqueidentifier,
	@Nota float
AS
BEGIN
	INSERT INTO dbo.Calificacion
	(ID, ID_Matricula, ID_Rubro,Nota)
	VALUES
	(NEWID(), @ID_Matricula, @ID_Rubro,@Nota)
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
