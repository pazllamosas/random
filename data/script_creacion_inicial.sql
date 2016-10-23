USE [GD2C2016]
GO


-- DROP TABLAS 

IF OBJECT_ID('RANDOM.CANCELACION') IS NOT NULL
DROP TABLE RANDOM.CANCELACION
IF OBJECT_ID('RANDOM.TIPO_CANCELACION') IS NOT NULL
DROP TABLE RANDOM.TIPO_CANCELACION
IF OBJECT_ID('RANDOM.RESULTADO_TURNO') IS NOT NULL
DROP TABLE RANDOM.RESULTADO_TURNO
IF OBJECT_ID('RANDOM.TURNO') IS NOT NULL
DROP TABLE RANDOM.TURNO
IF OBJECT_ID('RANDOM.AGENDA_HORARIO_DISPONIBLE') IS NOT NULL
DROP TABLE RANDOM.AGENDA_HORARIO_DISPONIBLE
IF OBJECT_ID('RANDOM.BONO') IS NOT NULL
DROP TABLE RANDOM.BONO
IF OBJECT_ID('RANDOM.COMPRA_BONO') IS NOT NULL
DROP TABLE RANDOM.COMPRA_BONO
IF OBJECT_ID('RANDOM.ESPECIALIDAD_POR_PROFESIONAL') IS NOT NULL
DROP TABLE RANDOM.ESPECIALIDAD_POR_PROFESIONAL
IF OBJECT_ID('RANDOM.ESPECIALIDAD') IS NOT NULL
DROP TABLE RANDOM.ESPECIALIDAD
IF OBJECT_ID('RANDOM.TIPO_ESPECIALIDAD') IS NOT NULL
DROP TABLE RANDOM.TIPO_ESPECIALIDAD
IF OBJECT_ID('RANDOM.PROFESIONAL') IS NOT NULL
DROP TABLE RANDOM.PROFESIONAL
IF OBJECT_ID('RANDOM.HISTORIAL_PLAN') IS NOT NULL
DROP TABLE RANDOM.HISTORIAL_PLAN
IF OBJECT_ID('RANDOM.AFILIADO') IS NOT NULL
DROP TABLE RANDOM.AFILIADO
IF OBJECT_ID('RANDOM.PERSONA') IS NOT NULL
DROP TABLE RANDOM.PERSONA
IF OBJECT_ID('RANDOM.PLANES') IS NOT NULL
DROP TABLE RANDOM.PLANES
IF OBJECT_ID('RANDOM.ESTADO_CIVIL') IS NOT NULL
DROP TABLE RANDOM.ESTADO_CIVIL
IF OBJECT_ID('RANDOM.USUARIO_POR_ROL') IS NOT NULL
DROP TABLE RANDOM.USUARIO_POR_ROL
IF OBJECT_ID('RANDOM.USUARIO') IS NOT NULL
DROP TABLE RANDOM.USUARIO
IF OBJECT_ID('RANDOM.ROL_POR_FUNCIONALIDADES') IS NOT NULL
DROP TABLE RANDOM.ROL_POR_FUNCIONALIDADES
IF OBJECT_ID('RANDOM.FUNCIONALIDADES') IS NOT NULL
DROP TABLE RANDOM.FUNCIONALIDADES
IF OBJECT_ID('RANDOM.ROL') IS NOT NULL
DROP TABLE RANDOM.ROL
IF OBJECT_ID('RANDOM.TIPOS_DOCUMENTOS') IS NOT NULL
DROP TABLE RANDOM.TIPOS_DOCUMENTOS


-- DROP PROCEDURES Y FUNCTIONS 

IF OBJECT_ID('RANDOM.GET_ID_USUARIO') IS NOT NULL
DROP FUNCTION RANDOM.GET_ID_USUARIO
IF OBJECT_ID('RANDOM.GET_ID_ROL') IS NOT NULL
DROP FUNCTION RANDOM.GET_ID_ROL
IF OBJECT_ID('RANDOM.EXISTE_USUARIO') IS NOT NULL
DROP FUNCTION RANDOM.EXISTE_USUARIO
IF OBJECT_ID('RANDOM.PASSWORD_CORRECTA') IS NOT NULL
DROP FUNCTION RANDOM.PASSWORD_CORRECTA
IF OBJECT_ID('RANDOM.ROL_HABILITADO') IS NOT NULL
DROP FUNCTION RANDOM.ROL_HABILITADO
IF OBJECT_ID('RANDOM.EXISTE_USUARIO_ROL') IS NOT NULL
DROP FUNCTION RANDOM.EXISTE_USUARIO_ROL
IF OBJECT_ID('RANDOM.EXISTE_FUNCIONALIDAD_ROL') IS NOT NULL
DROP FUNCTION RANDOM.EXISTE_FUNCIONALIDAD_ROL
IF OBJECT_ID('RANDOM.EXISTE_ROL') IS NOT NULL
DROP FUNCTION RANDOM.EXISTE_ROL


IF OBJECT_ID('RANDOM.GET_PLANES') IS NOT NULL
DROP PROCEDURE RANDOM.GET_PLANES
IF OBJECT_ID('RANDOM.GET_ESTADO_CIVIL') IS NOT NULL
DROP PROCEDURE RANDOM.GET_ESTADO_CIVIL
IF OBJECT_ID('RANDOM.GET_TIPO_DOCUMENTO') IS NOT NULL
DROP PROCEDURE RANDOM.GET_TIPO_DOCUMENTO
IF OBJECT_ID('RANDOM.GET_AFILIADOS') IS NOT NULL
DROP PROCEDURE RANDOM.GET_AFILIADOS
IF OBJECT_ID('RANDOM.GET_USUARIOS') IS NOT NULL
DROP PROCEDURE RANDOM.GET_USUARIOS
IF OBJECT_ID('RANDOM.ACTIVAR_ROL') IS NOT NULL
DROP PROCEDURE RANDOM.ACTIVAR_ROL
IF OBJECT_ID('RANDOM.BAJA_ROL') IS NOT NULL
DROP PROCEDURE RANDOM.BAJA_ROL
IF OBJECT_ID('RANDOM.BAJA_USUARIO') IS NOT NULL
DROP PROCEDURE RANDOM.BAJA_USUARIO
IF OBJECT_ID('RANDOM.HABILITAR_USUARIO') IS NOT NULL
DROP PROCEDURE RANDOM.HABILITAR_USUARIO
IF OBJECT_ID('RANDOM.INTENTO_LOGIN') IS NOT NULL
DROP PROCEDURE RANDOM.INTENTO_LOGIN
IF OBJECT_ID('RANDOM.ELIMINAR_FUNCIONALIDAD_DEL_ROL') IS NOT NULL
DROP PROCEDURE RANDOM.ELIMINAR_FUNCIONALIDAD_DEL_ROL
IF OBJECT_ID('RANDOM.MODIFICAR_NOMBRE_ROL') IS NOT NULL
DROP PROCEDURE RANDOM.MODIFICAR_NOMBRE_ROL
IF OBJECT_ID('RANDOM.ASIGNAR_FUNCIONALIDAD') IS NOT NULL
DROP PROCEDURE RANDOM.ASIGNAR_FUNCIONALIDAD
IF OBJECT_ID('RANDOM.ASIGNAR_ROL') IS NOT NULL
DROP PROCEDURE RANDOM.ASIGNAR_ROL
IF OBJECT_ID('RANDOM.CREAR_ROL') IS NOT NULL
DROP PROCEDURE RANDOM.CREAR_ROL
IF OBJECT_ID('RANDOM.top5EspecialidadesConMasConsultasUtilizadas') IS NOT NULL
DROP PROCEDURE RANDOM.top5EspecialidadesConMasConsultasUtilizadas
IF OBJECT_ID('RANDOM.top5AfiliadosConMayorCantBonosComprados') IS NOT NULL
DROP PROCEDURE RANDOM.top5AfiliadosConMayorCantBonosComprados
/*IF OBJECT_ID('RANDOM.top5ProfesionalesConMenosHorasTrabajadas') IS NOT NULL
DROP PROCEDURE RANDOM.top5ProfesionalesConMenosHorasTrabajadas*/
IF OBJECT_ID('RANDOM.top5ProfesionalesMasConsultadosPorPlan') IS NOT NULL
DROP PROCEDURE RANDOM.top5ProfesionalesMasConsultadosPorPlan
IF OBJECT_ID('RANDOM.top5EspecialidadesConMasCancelacionesDeTurno') IS NOT NULL
DROP PROCEDURE RANDOM.top5EspecialidadesConMasCancelacionesDeTurno
IF OBJECT_ID('RANDOM.TURNO_CONCRETADO') IS NOT NULL
DROP PROCEDURE RANDOM.TURNO_CONCRETADO
IF OBJECT_ID('RANDOM.TURNO_SIN_CONCRETAR') IS NOT NULL
DROP PROCEDURE RANDOM.TURNO_SIN_CONCRETAR 



-- DROP TRIGGERS

IF OBJECT_ID('RANDOM.AFTER_LOGIN') IS NOT NULL
DROP TRIGGER RANDOM.AFTER_LOGIN

-- DROP INDIXES

-- DROP SCHEMA

IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'RANDOM')
DROP SCHEMA [RANDOM]
GO

-- CREATE SCHEMA

CREATE SCHEMA [RANDOM] AUTHORIZATION [dbo]
GO

-- CREATE TABLAS
CREATE TABLE RANDOM.ROL(
	IdRol int PRIMARY KEY IDENTITY(1,1),
	Estado bit DEFAULT 1, -- 1 activo
	Descripcion nvarchar(255) UNIQUE
	)

CREATE TABLE RANDOM.FUNCIONALIDADES(
	IdFuncionalidad int PRIMARY KEY IDENTITY (1,1),
	DescripcionFunc nvarchar(255) UNIQUE
)

CREATE TABLE RANDOM.ROL_POR_FUNCIONALIDADES(
	IdFuncionalidad int,
	IdRol int,
	Habilitada bit DEFAULT 1	--para que en el menu se vean las de cada rol
	)

CREATE TABLE RANDOM.USUARIO(
	IdUsuario int PRIMARY KEY IDENTITY(1,1),
	Username nvarchar(255) NOT NULL UNIQUE,
	Pass nvarchar(255) NOT NULL,
	FechaCreacion datetime,
	UltimaModificacion datetime,
	IntentosFallidos int NOT NULL DEFAULT 0,
	Acceso bit, --1 ACCESO CORRECTO
	Habilitada bit DEFAULT 1
)
CREATE TABLE RANDOM.USUARIO_POR_ROL(
	IdUsuario int,
	IdRol int,
	Habilitada bit DEFAULT 1 --para dar de baja un usuario por rol
)

CREATE TABLE RANDOM.PERSONA(
	IdPersona int PRIMARY KEY IDENTITY(1,1),
	Nombre nvarchar(255),
	Apellido nvarchar(255),
	Sexo nvarchar(255) CHECK (Sexo IN ('Femenino', 'MACULINO')),
	IdTipoDocumento int DEFAULT '1', 
	Dni numeric(18,0),
	Direccion nvarchar(255),
	Telefono numeric(18, 0),
	Mail nvarchar(255),
	Fecha_Nac datetime,
	IdUsuario int
)

CREATE TABLE RANDOM.TIPOS_DOCUMENTOS(
	IdTipoDocumento int PRIMARY KEY IDENTITY(1,1),
	Descripcion nvarchar(250)
)

CREATE TABLE RANDOM.AFILIADO(
	IdPersona int PRIMARY KEY,
	IdEstadoCivil int DEFAULT 1,
	CantidadACargo int DEFAULT '0',
	IdPlan int,
	NumeroAfiliadoRaiz int IDENTITY(1,1),
	NumeroAfiliadoExt nvarchar(255) DEFAULT '00',
	Estado bit DEFAULT 1--, 1 ACTIVO 0 BAJA
	--NumeroUltimoBono int
)

CREATE TABLE RANDOM.PLANES(
	IdPlan int PRIMARY KEY IDENTITY(1,1),
	Codigo numeric(18),
	Nombre nvarchar(255),
	Abono int, 
	MontoConsulta numeric(18),
	MontoExpendio numeric(18)
)

CREATE TABLE RANDOM.HISTORIAL_PLAN(
	IdHistorialPlan int PRIMARY KEY IDENTITY(1,1),
	IdAfiliado int,
	Fecha datetime,
	Motivo nvarchar(255) DEFAULT 'Inscripcion'
)

CREATE TABLE.RANDOM.ESTADO_CIVIL(
	IdEstadoCivil int PRIMARY KEY IDENTITY (1,1),
	Descripcion nvarchar(255)
)

CREATE TABLE RANDOM.PROFESIONAL(
	IdProfesional int PRIMARY KEY --es la matricula del profesional
	
)
CREATE TABLE RANDOM.TIPO_ESPECIALIDAD(
	IdTipoEspecialidad int PRIMARY KEY IDENTITY(1,1),
	Codigo numeric(18),
	Descripcion nvarchar(255)
)

CREATE TABLE RANDOM.ESPECIALIDAD(
	IdEspecialidad int PRIMARY KEY IDENTITY(1,1),
	Codigo numeric(18),
	Descripcion nvarchar(255),
	IdTipoEspecialidad int
)

CREATE TABLE RANDOM.ESPECIALIDAD_POR_PROFESIONAL(
	IdProfesional int, -- puse persona en vez de profesional porque me acortaba mucho en un query, igual no cambia en nada por suerte
	IdEspecialidad int,
	PRIMARY KEY(IdProfesional, IdEspecialidad)
)

CREATE TABLE RANDOM.COMPRA_BONO(
	IdCompra int PRIMARY KEY IDENTITY (1,1),
	IdAfiliado int,
	Fecha datetime,
	MontoTotal int,
	Cantidad int
)

CREATE TABLE RANDOM.BONO(
	IdBono int PRIMARY KEY IDENTITY (1,1), -- No es el numero de bono porque sino tendria que cambiar el tipo de datos en muchos lugares
	IdCompra int,
	Usado bit default 1, -- 1 si esta usado
	Precio int,
	IdPlan int,
	CompraBonoFecha datetime,
	ConsultaNumero numeric(18), --numero de bono
	Habilitado bit DEFAULT 1 -- para el cambio de plan
)

CREATE TABLE RANDOM.AGENDA_HORARIO_DISPONIBLE(
	IdAgenda int PRIMARY KEY IDENTITY (1,1),
	IdProfesional int,
	FechaYHoraDesde datetime,
	FechaYHoraHasta datetime,
	IdEspecialidad int,
)

CREATE TABLE RANDOM.TURNO(
	IdTurno int PRIMARY KEY IDENTITY (1,1),
	IdAgenda int,
	IdAfiliado int,
	FechaYHoraAltaTurno datetime, --es la fecha y hora en la que se saca el turno
	FechaYHoraTurno datetime,
	Habilitado bit DEFAULT 1
)

CREATE TABLE RANDOM.RESULTADO_TURNO(
	IdResultadoTurno int PRIMARY KEY IDENTITY(1,1),
	IdTurno int,
	IdBono int,
	Sintomas nvarchar(255),
	Enfermedades nvarchar(255),
	Fecha datetime -- es la fecha y hora en la que se hace la consulta dado un turno que sacaste antes
)

CREATE TABLE RANDOM.CANCELACION(
	IdCancelacion int PRIMARY KEY IDENTITY(1,1),
	IdTipoCancelacion int,
	IdTurno int,
	Motivo nvarchar(255)
 )

CREATE TABLE RANDOM.TIPO_CANCELACION(
	IdTipoCancelacion int PRIMARY KEY IDENTITY(1,1),
	Descripcion nvarchar(255)
)
--FOREIGN KEY 

--ALTER TABLE RANDOM.PERSONA ADD FOREIGN KEY (IdUsuario) REFERENCES RANDOM.USUARIO
ALTER TABLE RANDOM.ROL_POR_FUNCIONALIDADES ADD FOREIGN KEY (IdFuncionalidad) REFERENCES RANDOM.FUNCIONALIDADES
ALTER TABLE RANDOM.ROL_POR_FUNCIONALIDADES ADD FOREIGN KEY (IdRol) REFERENCES RANDOM.ROL
ALTER TABLE RANDOM.USUARIO_POR_ROL ADD FOREIGN KEY (IdUsuario) REFERENCES RANDOM.USUARIO
ALTER TABLE RANDOM.USUARIO_POR_ROL ADD FOREIGN KEY (IdRol) REFERENCES RANDOM.ROL
ALTER TABLE RANDOM.AFILIADO ADD FOREIGN KEY (IdPersona) REFERENCES RANDOM.PERSONA
ALTER TABLE RANDOM.AFILIADO ADD FOREIGN KEY (IdEstadoCivil) REFERENCES RANDOM.ESTADO_CIVIL
ALTER TABLE RANDOM.AFILIADO ADD FOREIGN KEY (IdPlan) REFERENCES RANDOM.PLANES
ALTER TABLE RANDOM.HISTORIAL_PLAN ADD FOREIGN KEY (IdAfiliado) REFERENCES RANDOM.AFILIADO
ALTER TABLE RANDOM.PROFESIONAL ADD FOREIGN KEY (IdProfesional) REFERENCES RANDOM.PERSONA
ALTER TABLE RANDOM.ESPECIALIDAD ADD FOREIGN KEY (IdTipoEspecialidad) REFERENCES RANDOM.TIPO_ESPECIALIDAD
ALTER TABLE RANDOM.ESPECIALIDAD_POR_PROFESIONAL ADD FOREIGN KEY (IdProfesional) REFERENCES RANDOM.PROFESIONAL
ALTER TABLE RANDOM.ESPECIALIDAD_POR_PROFESIONAL ADD FOREIGN KEY (IdEspecialidad) REFERENCES RANDOM.ESPECIALIDAD
ALTER TABLE RANDOM.COMPRA_BONO ADD FOREIGN KEY (IdAfiliado) REFERENCES RANDOM.AFILIADO
ALTER TABLE RANDOM.BONO ADD FOREIGN KEY (IdCompra) REFERENCES RANDOM.COMPRA_BONO
ALTER TABLE RANDOM.BONO ADD FOREIGN KEY (IdPlan) REFERENCES RANDOM.PlANES
ALTER TABLE RANDOM.AGENDA_HORARIO_DISPONIBLE ADD FOREIGN KEY (IdProfesional) REFERENCES RANDOM.PROFESIONAL
ALTER TABLE RANDOM.AGENDA_HORARIO_DISPONIBLE ADD FOREIGN KEY (IdEspecialidad) REFERENCES RANDOM.ESPECIALIDAD
ALTER TABLE RANDOM.TURNO ADD FOREIGN KEY (IdAgenda) REFERENCES RANDOM.AGENDA_HORARIO_DISPONIBLE
ALTER TABLE RANDOM.RESULTADO_TURNO ADD FOREIGN KEY (IdBono) REFERENCES RANDOM.BONO
ALTER TABLE RANDOM.RESULTADO_TURNO ADD FOREIGN KEY (IdTurno) REFERENCES RANDOM.TURNO
ALTER TABLE RANDOM.CANCELACION ADD FOREIGN KEY (IdTipoCancelacion) REFERENCES RANDOM.TIPO_CANCELACION
ALTER TABLE RANDOM.CANCELACION ADD FOREIGN KEY (IdTurno) REFERENCES RANDOM.TURNO
ALTER TABLE RANDOM.PERSONA ADD FOREIGN KEY (IdTipoDocumento) REFERENCES RANDOM.TIPOS_DOCUMENTOS
ALTER TABLE RANDOM.PERSONA ADD FOREIGN KEY (IdUsuario) REFERENCES RANDOM.Usuario
ALTER TABLE RANDOM.TURNO ADD FOREIGN KEY (IdAfiliado) REFERENCES RANDOM.AFILIADO

-- CREATE INDIXES

------------------------  MIGRACION  ------------------------------

/*ROL*/
INSERT INTO RANDOM.ROL(Descripcion)
VALUES ('Administrador')
INSERT INTO RANDOM.ROL(Descripcion)
VALUES ('Afiliado')
INSERT INTO RANDOM.ROL(Descripcion)
VALUES ('Profesional')

/*FUNCIONALIDADES*/
SET IDENTITY_INSERT RANDOM.FUNCIONALIDADES ON
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (0,'Alta Afiliado')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (1,'Modificar Afiliado')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (2,'Baja Afiliado')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (3,'Alta Profesional')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (4,'Modificar Profesional')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (5,'Baja Profesional')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (6,'Generar Agenda')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (7,'Comprar Bono')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (8,'Registrar Llegada a la Atención')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (9,'Solicitar Turno')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (10,'Cancelar Turno')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (11,'Registrar Diagnóstico')
INSERT INTO RANDOM.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (12,'Consulta TOP 5')
SET IDENTITY_INSERT RANDOM.FUNCIONALIDADES OFF

/*ROL_POR_FUNCIONALIDADES*/
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(0,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(1,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(2,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(3,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(4,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(5,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(6,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(7,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(7,2,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(8,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(9,2,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(10,1,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(11,3,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(12,2,1)

/*USUARIO  Y   USUARIO POR ROL  */
INSERT INTO RANDOM.USUARIO(Username,Pass, FechaCreacion, UltimaModificacion)
VALUES('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', GETDATE(), GETDATE())
INSERT INTO RANDOM.USUARIO(Username,Pass, FechaCreacion, UltimaModificacion)
VALUES('ana','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', GETDATE(), GETDATE())
INSERT INTO RANDOM.USUARIO(Username,Pass, FechaCreacion, UltimaModificacion)
VALUES('maria','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', GETDATE(), GETDATE())
INSERT INTO RANDOM.USUARIO(Username,Pass, FechaCreacion, UltimaModificacion)
VALUES('jose','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', GETDATE(), GETDATE())

INSERT INTO RANDOM.USUARIO_POR_ROL(IdUsuario,IdRol)
SELECT U.IdUsuario, 1
FROM RANDOM.USUARIO U, RANDOM.ROL R
WHERE R.Descripcion = 'Administrador'

INSERT INTO RANDOM.USUARIO (Username, Pass, FechaCreacion, UltimaModificacion)
SELECT DISTINCT M.Paciente_Dni, 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', GETDATE(), GETDATE()
FROM gd_esquema.Maestra M

INSERT INTO RANDOM.USUARIO_POR_ROL(IdUsuario,IdRol)
SELECT U.IdUsuario, 2
FROM RANDOM.USUARIO U, RANDOM.ROL R
WHERE R.Descripcion = 'Afiliado'

INSERT INTO RANDOM.USUARIO (Username, Pass, FechaCreacion, UltimaModificacion)
SELECT DISTINCT M.Medico_Dni, 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', GETDATE(), GETDATE()
FROM gd_esquema.Maestra M
WHERE M.Medico_Mail IS NOT NULL


INSERT INTO RANDOM.USUARIO_POR_ROL(IdUsuario,IdRol)
SELECT U.IdUsuario, 3
FROM RANDOM.USUARIO U, RANDOM.ROL R
WHERE R.Descripcion = 'Profesional'



	
/*ESTADO CIVIL*/
INSERT INTO RANDOM.ESTADO_CIVIL(Descripcion)
VALUES('Soltero\a')
INSERT INTO RANDOM.ESTADO_CIVIL(Descripcion)
VALUES('Casado\a')
INSERT INTO RANDOM.ESTADO_CIVIL(Descripcion)
VALUES('Viudo\a')
INSERT INTO RANDOM.ESTADO_CIVIL(Descripcion)
VALUES('Divorciado\a')
INSERT INTO RANDOM.ESTADO_CIVIL(Descripcion)
VALUES('Concubinato')

/*TIPO DE CANCELACION*/
INSERT INTO RANDOM.TIPO_CANCELACION(Descripcion)
VALUES ('Repentina')
INSERT INTO RANDOM.TIPO_CANCELACION(Descripcion)
VALUES ('Viaje Programado')
INSERT INTO RANDOM.TIPO_CANCELACION(Descripcion)
VALUES ('Fuerza Mayor')
INSERT INTO RANDOM.TIPO_CANCELACION(Descripcion)
VALUES ('Superposición de horarios')
INSERT INTO RANDOM.TIPO_CANCELACION(Descripcion)
VALUES ('Enfermedad')
INSERT INTO RANDOM.TIPO_CANCELACION(Descripcion)
VALUES ('Urgencia')
INSERT INTO RANDOM.TIPO_CANCELACION(Descripcion)
VALUES ('Otros')

/*TIPO DE DOCUMENTOS*/
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('D.N.I.')
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('Libreta de enrolamiento')
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('Libreta Civica')
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('Cédula de Identidad')
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('Pasaporte')


/*PERSONA*/ -- agregamos los afiliados nada mas aca
INSERT INTO RANDOM.PERSONA(Nombre, Apellido, Dni, Direccion, Telefono, Mail, Fecha_Nac, IdUsuario) 
SELECT DISTINCT M.Paciente_Nombre, M.Paciente_Apellido, M.Paciente_Dni, M.Paciente_Direccion, M.Paciente_Telefono, M.Paciente_Mail, M.Paciente_Fecha_Nac,2
FROM gd_esquema.Maestra M


/*PERSONA*/ -- agregamos los medicos nada mas aca
INSERT INTO RANDOM.PERSONA(Nombre, Apellido, Dni, Direccion, Telefono, Mail, Fecha_Nac, IdUsuario) 
SELECT DISTINCT M.Medico_Nombre, M.Medico_Apellido, M.Medico_Dni, M.Medico_Direccion, M.Medico_Telefono, M.Medico_Mail, M.Medico_Fecha_Nac, 3
FROM gd_esquema.Maestra M

/*PLANES*/
INSERT INTO RANDOM.PLANES(Codigo,Nombre, MontoConsulta, MontoExpendio)
SELECT DISTINCT M.Plan_Med_Codigo, M.Plan_Med_Descripcion, M.Plan_Med_Precio_Bono_Consulta, M.Plan_Med_Precio_Bono_Farmacia
FROM gd_esquema.Maestra M

/*Bonos de los planes seteo*/
UPDATE RANDOM.PLANES
SET Abono = 150
WHERE IdPlan = 1;
UPDATE RANDOM.PLANES
SET Abono = 110
WHERE IdPlan = 2;
UPDATE RANDOM.PLANES
SET Abono = 130
WHERE IdPlan = 3;
UPDATE RANDOM.PLANES
SET Abono = 120
WHERE IdPlan = 4;
UPDATE RANDOM.PLANES
SET Abono = 140
WHERE IdPlan = 5;

/*AFILIADO*/
INSERT INTO RANDOM.AFILIADO(IdPersona, IdPlan)
SELECT DISTINCT P.IdPersona, PL.IdPlan
FROM gd_esquema.Maestra M
JOIN RANDOM.PERSONA P ON M.Paciente_Nombre = P.Nombre AND M.Paciente_Apellido = P.Apellido AND M.Paciente_Dni = P.Dni
JOIN RANDOM.PLANES PL ON M.Plan_Med_Codigo = PL.Codigo
--FALTAN numero ultimo bono que no me acuerdo de nuevo para que era. Cubi.  /  seteo de estado civil?

/*TIPO_ESPECIALIDAD*/
INSERT INTO RANDOM.TIPO_ESPECIALIDAD(Codigo,Descripcion)
SELECT DISTINCT M.Tipo_Especialidad_Codigo, M.Tipo_Especialidad_Descripcion
FROM gd_esquema.Maestra M
where M.Tipo_Especialidad_Codigo IS NOT NULL

/*ESPECIALIDAD*/
INSERT INTO RANDOM.ESPECIALIDAD(Codigo,Descripcion, IdTipoEspecialidad)
SELECT DISTINCT M.Especialidad_Codigo, M.Especialidad_Descripcion, E.IdTipoEspecialidad
FROM gd_esquema.Maestra M
JOIN RANDOM.TIPO_ESPECIALIDAD E ON M.Tipo_Especialidad_Codigo = E.Codigo 

/*PROFESIONAL*/ 
INSERT INTO RANDOM.PROFESIONAL(IdProfesional)
SELECT DISTINCT P.IdPersona
FROM gd_esquema.Maestra M
JOIN RANDOM.PERSONA P ON M.Medico_Nombre =P.Nombre AND M.Medico_Apellido = P.Apellido AND M.Medico_Dni = P.Dni

/*HISTORIAL_PLAN*/ -- inserto el primer plan de todas las personas de la base
-- y si ponemos la fecha de nacimiento en vez de esa fecha?? 
INSERT INTO RANDOM.HISTORIAL_PLAN(IdAfiliado, Fecha)
SELECT DISTINCT A.IdPersona, '1957-10-24 00:00:00.000'
FROM RANDOM.AFILIADO A

/*ESPECIALIDAD_POR_PROFESIONAL*/
INSERT RANDOM.ESPECIALIDAD_POR_PROFESIONAL (IdProfesional, IdEspecialidad)
SELECT DISTINCT P.IdPersona, E.IdEspecialidad
FROM RANDOM.PERSONA P, gd_esquema.Maestra M, RANDOM.ESPECIALIDAD E
WHERE M.Medico_Dni = P.Dni and  E.Codigo = M.Especialidad_Codigo

/*COMPRA_BONO*/
INSERT RANDOM.COMPRA_BONO (IdAfiliado, Fecha)
SELECT DISTINCT P.IdPersona, M.Compra_Bono_Fecha
FROM RANDOM.PERSONA P 
JOIN gd_esquema.Maestra M on P.Dni = M.Paciente_Dni AND M.Compra_Bono_Fecha IS NOT NULL


/*BONO*/
INSERT RANDOM.BONO (IdCompra, Precio, IdPlan, CompraBonoFecha, ConsultaNumero)
SELECT DISTINCT C.IdCompra, PL.MontoConsulta, PL.IdPlan, M.Compra_Bono_Fecha,M.Bono_Consulta_Numero
FROM RANDOM.PERSONA P 
JOIN gd_esquema.Maestra M on P.Dni = M.Paciente_Dni
JOIN RANDOM.COMPRA_BONO C ON  M.Compra_Bono_Fecha = C.Fecha AND C.IdAfiliado = P.IdPersona
JOIN RANDOM.AFILIADO A ON P.IdPersona = A.IdPersona
JOIN RANDOM.PLANES PL ON A.IdPlan = PL.IdPlan
where M.Bono_Consulta_Fecha_Impresion IS NOT NULL
AND  M.Bono_Consulta_Numero IS NOT NULL

/*Inserto precio de las compras teniendo el precio en la tabla bonos ahora*/
SELECT B.IdCompra as ID, SUM (B.Precio) AS PRECIO
INTO #TEMPORALPRECIOS
FROM RANDOM.COMPRA_BONO CB, RANDOM.BONO b
WHERE B.IdCompra = CB.IdCompra
GROUP BY B.IdCompra

update RANDOM.COMPRA_BONO 
set MontoTotal = T.PRECIO
FROM #TEMPORALPRECIOS T, RANDOM.COMPRA_BONO CB
where T.ID = CB.IdCompra

DROP TABLE #TEMPORALPRECIOS

--UPDATE de las cantidades de las compras para la migracion
UPDATE RANDOM.COMPRA_BONO
SET   Cantidad = joinBonoCompra.CANTIDAD
FROM (SELECT B.IdCompra , COUNT (B.IdBONO) AS 'CANTIDAD'
		FROM RANDOM.BONO B, RANDOM.COMPRA_BONO C
		WHERE B.IdCompra = C.IdCompra
		GROUP BY B.IdCompra) AS joinBonoCompra
WHERE joinBonoCompra.IdCompra = RANDOM.COMPRA_BONO.IdCompra


/*AGENDA_HORARIO_DISPONIBLE*/



/*TURNO*/
SET IDENTITY_INSERT RANDOM.TURNO ON
INSERT INTO RANDOM.TURNO (IdTurno, FechaYHoraAltaTurno, IdAfiliado, FechaYHoraTurno)
SELECT DISTINCT M.Turno_Numero, M.Turno_Fecha, P.IdPersona, m.Bono_Consulta_Fecha_Impresion
FROM gd_esquema.Maestra M, RANDOM.PERSONA P
where M.Turno_Numero IS NOT NULL 
	AND M.Turno_Fecha IS NOT NULL
	AND M.Bono_Consulta_Fecha_Impresion IS NOT NULL
	AND P.Dni = M.Paciente_Dni

/*RESULTADO_TURNO*/
INSERT INTO RANDOM.RESULTADO_TURNO(IdTurno, IdBono, Sintomas, Enfermedades, Fecha)
SELECT DISTINCT M.Turno_Numero, B.IdBono, M.Consulta_Sintomas, M.Consulta_Enfermedades, M.Bono_Consulta_Fecha_Impresion
FROM RANDOM.BONO B, gd_esquema.Maestra M
WHERE M.Bono_Consulta_Numero = B.ConsultaNumero
	AND M.Turno_Numero IS NOT NULL
	AND M.Consulta_Sintomas IS NOT NULL
	AND M.Consulta_Enfermedades IS NOT NULL
	SET IDENTITY_INSERT RANDOM.TURNO OFF
	

---------------FUNCIONES-----------

/* USUARIO */

GO
	CREATE FUNCTION RANDOM.EXISTE_USUARIO(@USUARIO VARCHAR(255)) 
	RETURNS int
	AS
	BEGIN
		DECLARE @CANTIDAD INT
		
		SELECT @CANTIDAD = COUNT(Username) FROM RANDOM.USUARIO
		WHERE Username = @USUARIO AND
			  Habilitada = 1
		
		RETURN @CANTIDAD
	END
GO


CREATE FUNCTION RANDOM.PASSWORD_CORRECTA(@USUARIO VARCHAR(255),@PASSWORD VARCHAR(64)) 
RETURNS int
AS
BEGIN
	DECLARE @HASH_PASS NVARCHAR(255), @CANTIDAD INT
	SET @HASH_PASS =  @PASSWORD
	SELECT @CANTIDAD = COUNT(Username) FROM RANDOM.USUARIO
	WHERE Habilitada = 1 AND
		  Username = @USUARIO AND
		  Pass = @HASH_PASS
	RETURN @CANTIDAD
END
GO

CREATE TRIGGER RANDOM.AFTER_LOGIN ON RANDOM.USUARIO AFTER INSERT AS
BEGIN
	DECLARE @ACCESO INT, @IDUSUARIO INT, @HABILITADA INT, @INTENTOS_FALLIDOS_ACTUAL INT
	SELECT @ACCESO = ACCESO, @IDUSUARIO = IdUsuario FROM INSERTED
	
	SELECT @HABILITADA = Habilitada, @INTENTOS_FALLIDOS_ACTUAL = IntentosFallidos FROM RANDOM.USUARIO
	WHERE IdUsuario = @IDUSUARIO
	
	IF @ACCESO = 1
	BEGIN
		UPDATE RANDOM.USUARIO SET 
			IntentosFallidos = 0
		WHERE IdUsuario = @IDUSUARIO
	END
	ELSE
	BEGIN
		IF @INTENTOS_FALLIDOS_ACTUAL = 2
		UPDATE RANDOM.USUARIO SET
			IntentosFallidos = IntentosFallidos + 1,
			Habilitada = 0
		WHERE IdUsuario = @IDUSUARIO
		ELSE
		UPDATE RANDOM.USUARIO SET
			IntentosFallidos = IntentosFallidos + 1,
			Habilitada = @HABILITADA
		WHERE IdUsuario = @IDUSUARIO
	END
END 
GO

CREATE PROCEDURE RANDOM.INTENTO_LOGIN(@USUARIO VARCHAR(255),@ACCESO INT) AS
BEGIN 
	UPDATE RANDOM.USUARIO SET
		Acceso = @ACCESO
	WHERE Username = @USUARIO
END 
GO

CREATE PROCEDURE RANDOM.BAJA_USUARIO(@ID INT) AS
BEGIN
	UPDATE RANDOM.USUARIO SET
		Habilitada = 0
	WHERE IdUsuario = @ID
END
GO

CREATE PROCEDURE RANDOM.HABILITAR_USUARIO(@USERNAME VARCHAR(255)) AS
BEGIN
	UPDATE RANDOM.USUARIO SET
		Habilitada = 1
	WHERE USERNAME = @USERNAME
END
GO



/*  ROL */


CREATE PROCEDURE RANDOM.BAJA_ROL(@ROL  INT) AS
BEGIN 
	UPDATE RANDOM.ROL SET
		Estado = 0
	WHERE IdRol = @ROL
	UPDATE RANDOM.USUARIO_POR_ROL SET
		Habilitada = 0
	WHERE IdRol = @ROL
	UPDATE RANDOM.USUARIO SET
		Habilitada = 0
	FROM RANDOM.USUARIO_POR_ROL UPR, RANDOM.USUARIO U
	WHERE U.IdUsuario = UPR.IdUsuario
		AND UPR.IdRol = @ROL
END 
GO

CREATE PROCEDURE RANDOM.ACTIVAR_ROL(@NOMBRE VARCHAR(50)) AS
BEGIN 
	UPDATE RANDOM.ROL SET
		Estado = 1
	WHERE Descripcion = @NOMBRE
END 
GO

GO
CREATE FUNCTION RANDOM.ROL_HABILITADO(@NOMBRE NVARCHAR(255)) 
	RETURNS int
	AS
	BEGIN
		DECLARE @CANTIDAD INT
		
		SELECT @CANTIDAD = COUNT(Descripcion) FROM RANDOM.ROL
		WHERE Descripcion = @NOMBRE AND
			  ESTADO = 1
		RETURN @CANTIDAD
	END
GO

GO 
CREATE PROCEDURE RANDOM.CREAR_ROL ( @NOMBRE VARCHAR (255)) AS 
BEGIN 
IF (( NOT EXISTS ( SELECT * FROM RANDOM.ROL WHERE Descripcion = @NOMBRE )))
	INSERT INTO RANDOM.ROL (Estado, Descripcion)
	VALUES (1, @NOMBRE) 
ELSE
	 RAISERROR ('El Rol ya existe', 16, 217) WITH SETERROR
 END 
GO

CREATE PROCEDURE RANDOM.ASIGNAR_ROL(@USUARIO int, @ROL int)
AS BEGIN
	INSERT INTO RANDOM.USUARIO_POR_ROL(IdUsuario, IdRol)
	VALUES (@USUARIO, @ROL)
END
GO


CREATE PROCEDURE RANDOM.ASIGNAR_FUNCIONALIDAD(@FUNCIONALIDAD int, @ROL int)
AS BEGIN
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES (IdFuncionalidad, IdRol)
VALUES (@FUNCIONALIDAD, @ROL)
END
GO


CREATE PROCEDURE RANDOM.MODIFICAR_NOMBRE_ROL(@NOMBRE VARCHAR(255), @ROL INT) AS
BEGIN 
IF (( NOT EXISTS ( SELECT * FROM RANDOM.ROL WHERE Descripcion = @NOMBRE )))
	UPDATE RANDOM.ROL SET
		Descripcion = @NOMBRE
	WHERE IdRol = @ROL
ELSE
	 RAISERROR ('El Rol ya existe', 16, 217) WITH SETERROR
END
GO

CREATE PROCEDURE RANDOM.ELIMINAR_FUNCIONALIDAD_DEL_ROL (@FUNCIONALIDAD INT, @ROL INT) AS
BEGIN
	DELETE FROM RANDOM.ROL_POR_FUNCIONALIDADES
	WHERE IdFuncionalidad = @FUNCIONALIDAD 
		AND IdRol = @ROL
END
GO

GO
CREATE FUNCTION RANDOM.EXISTE_ROL(@NOMBRE NVARCHAR(255)) 
	RETURNS int
	AS
	BEGIN
		DECLARE @CANTIDAD INT
		
		SELECT @CANTIDAD = COUNT(Descripcion) FROM RANDOM.ROL
		WHERE Descripcion = @NOMBRE 		
		RETURN @CANTIDAD
	END
GO

GO
CREATE FUNCTION RANDOM.EXISTE_FUNCIONALIDAD_ROL(@FUNC INT, @ROL INT) 
	RETURNS int
	AS
	BEGIN
		DECLARE @CANTIDAD INT
		
		SELECT @CANTIDAD = COUNT(IdFuncionalidad) FROM RANDOM.ROL_POR_FUNCIONALIDADES
		WHERE IdFuncionalidad = @FUNC AND
			  IdRol = @ROL
		RETURN @CANTIDAD
	END
GO

GO
CREATE FUNCTION RANDOM.EXISTE_USUARIO_ROL(@USU INT, @ROL INT) 
	RETURNS int
	AS
	BEGIN
		DECLARE @CANTIDAD INT
		
		SELECT @CANTIDAD = COUNT(IdUsuario) FROM RANDOM.USUARIO_POR_ROL
		WHERE IdUsuario = @USU AND
			  IdRol = @ROL
		RETURN @CANTIDAD
	END
GO

GO
CREATE FUNCTION RANDOM.GET_ID_ROL(@NOMBRE NVARCHAR(255))
RETURNS INT
AS BEGIN
	DECLARE @IDROL INT
	
	SELECT @IDROL = IdRol FROM RANDOM.ROL
	WHERE Descripcion = @NOMBRE
	
	RETURN @IDROL
END

GO
CREATE PROCEDURE RANDOM.GET_USUARIOS AS
BEGIN
	SELECT * FROM RANDOM.USUARIO
END
GO

GO
CREATE FUNCTION RANDOM.GET_ID_USUARIO(@NOMBRE NVARCHAR(255))
RETURNS INT
AS BEGIN
	DECLARE @IDUSUARIO INT
	
	SELECT @IDUSUARIO = IdUsuario FROM RANDOM.USUARIO
	WHERE Username = @NOMBRE
	
	RETURN @IDUSUARIO
END
GO

--------------AFILIADO--------------


GO
CREATE PROCEDURE RANDOM.GET_AFILIADOS(@DNI NUMERIC(18,0))AS
BEGIN
	SELECT P.Apellido, P.Nombre, P.Dni, P.Fecha_Nac, A.NumeroAfiliadoRaiz
	FROM RANDOM.AFILIADO A, RANDOM.PERSONA P
	WHERE P.Dni = @DNI
		AND P.IdPersona = A.IdPersona

END
GO

GO
CREATE PROCEDURE RANDOM.GET_ESTADO_CIVIL AS
BEGIN
	SELECT * FROM RANDOM.ESTADO_CIVIL
END
GO

GO
CREATE PROCEDURE RANDOM.GET_PLANES AS
BEGIN
	SELECT * FROM RANDOM.PLANES
END
GO

GO
CREATE PROCEDURE RANDOM.GET_TIPO_DOCUMENTO AS
BEGIN
	SELECT * FROM RANDOM.TIPOS_DOCUMENTOS
END
GO

--------------TOP 5-----------------  
GO
CREATE PROCEDURE RANDOM.top5EspecialidadesConMasCancelacionesDeTurno (@fechaFrom nvarchar(50), @fechaTo nvarchar(50))
AS BEGIN
select top 5 E.Descripcion AS 'Especialidad', count(C.IdCancelacion) AS 'Cantidad'
from RANDOM.CANCELACION C
JOIN RANDOM.TURNO T ON C.IdTurno = T.IdTurno
JOIN RANDOM.AGENDA_HORARIO_DISPONIBLE HD ON T.IdAgenda = HD.IdAgenda
JOIN RANDOM.ESPECIALIDAD E ON HD.IdEspecialidad = E.IdEspecialidad
WHERE T.FechaYHoraTurno between convert(datetime, @fechaFrom,109) and convert(datetime, @fechaTo,109)
group by E.Descripcion 
order by 2 desc
END
GO

--------------------- 
--hacer que me busque el top de cada especialidad directamkente, sin que de a elegir

GO
CREATE PROCEDURE RANDOM.top5ProfesionalesMasConsultadosPorPlan(@fechaFrom varchar(50), @fechaTo varchar(50), @IdPlan int)
AS BEGIN
select top 5 E.Descripcion AS 'Especialidad', count(RT.IdResultadoTurno) AS 'Cantidad'
from RANDOM.RESULTADO_TURNO RT 
JOIN RANDOM.BONO B ON RT.IdBono = B.IdBono
JOIN RANDOM.TURNO T ON RT.IdTurno = T.IdTurno
JOIN RANDOM.AGENDA_HORARIO_DISPONIBLE HD ON T.IdAgenda = HD.IdAgenda
JOIN RANDOM.ESPECIALIDAD E ON HD.IdEspecialidad = E.IdEspecialidad
WHERE T.FechaYHoraTurno between convert(datetime, @fechaFrom,109) and convert(datetime, @fechaTo,109)
AND @IdPlan = B.IdPlan
group by E.Descripcion 
order by 2 desc
END
GO

---------------------

/*GO
CREATE PROCEDURE RANDOM.top5ProfesionalesMenosHorasTrabajadas(@fechaFrom varchar(50), @fechaTo varchar(50))
AS BEGIN
select top 5
from
order by  desc
END
GO
*/

---------------------
-- agregarke de alguna manera las fechas. Podria hacer un procedure adentro de otro para hacer eso, y no insertar directo en la tabla temporal. Pero tal vex pueda hacer todo en un solo SP.
create table #TEMPORAL(
IdPersona int,
Cantidad int
)
--Primero aca busco el id de la persona, y en el procedure que le sigue busco el numero raiz y extension, para mostrar eso
INSERT #TEMPORAL(IdPersona,Cantidad)
select P.IdPersona AS 'Persona', sum(CB.Cantidad) AS 'Cantidad'
from RANDOM.COMPRA_BONO CB
JOIN RANDOM.AFILIADO A ON A.IdPersona = CB.IdAfiliado
JOIN RANDOM.PERSONA P ON P.IdPersona = A.IdPersona
group by P.IdPersona 
order by 2 desc
GO

GO
CREATE PROCEDURE RANDOM.top5AfiliadosConMayorCantBonosComprados(@fechaFrom varchar(50), @fechaTo varchar(50))
AS BEGIN
SELECT top 5 CAST (A.NumeroAfiliadoRaiz AS VARCHAR) + CAST (a.NumeroAfiliadoExt AS VARCHAR), T.Cantidad, 
				CASE WHEN a.NumeroAfiliadoExt != '00' THEN 'Si'
                   WHEN a.CantidadACargo > 0 THEN 'Si'
                   ELSE 'No'
				END AS "Pertenece a grupo familiar"
FROM #TEMPORAL T
JOIN RANDOM.AFILIADO A ON A.IdPersona = T.IdPersona
order by 2 desc
END
GO

drop table #TEMPORAL

--------------------- hasta que no este agenda horario disponible no va a andar
GO
CREATE PROCEDURE RANDOM.top5EspecialidadesConMasConsultasUtilizadas(@fechaFrom varchar(50), @fechaTo varchar(50))
AS BEGIN
select top 5 E.Descripcion AS 'Especialidad', count(RT.IdResultadoTurno) AS 'Cantidad'
from RANDOM.RESULTADO_TURNO RT 
JOIN RANDOM.BONO B ON RT.IdBono = B.IdBono
JOIN RANDOM.TURNO T ON RT.IdTurno = T.IdTurno
JOIN RANDOM.AGENDA_HORARIO_DISPONIBLE HD ON T.IdAgenda = HD.IdAgenda
JOIN RANDOM.ESPECIALIDAD E ON HD.IdEspecialidad = E.IdEspecialidad
WHERE T.FechaYHoraTurno between convert(datetime, @fechaFrom,109) and convert(datetime, @fechaTo,109)
group by E.Descripcion 
order by 2 desc
END
GO

--------------- REGISTRO RESULTADO DIAGNOSTICO ---------------
GO
CREATE PROCEDURE RANDOM.TURNO_CONCRETADO(@TURNO int, @SINTOMAS nvarchar(255), @ENFERMEDAD nvarchar(255)) AS
BEGIN
	IF ( EXISTS ( SELECT * FROM RANDOM.TURNO WHERE IdTurno = @TURNO ))
	BEGIN
		UPDATE RANDOM.TURNO SET
			habilitado = 1
		WHERE IdTurno = @TURNO
		
		INSERT INTO RANDOM.RESULTADO_TURNO (IdTurno, Sintomas, Enfermedades, Fecha)
		VALUES (@TURNO, @SINTOMAS, @ENFERMEDAD, GETDATE())
	END
	ELSE
		RAISERROR ('No existe el Turno', 16, 217) WITH SETERROR
END
GO

CREATE PROCEDURE RANDOM.TURNO_SIN_CONCRETAR(@TURNO int) AS
BEGIN
	IF ( EXISTS ( SELECT * FROM RANDOM.TURNO WHERE IdTurno = @TURNO ))
	BEGIN
		UPDATE RANDOM.TURNO SET
			habilitado = 1
		WHERE IdTurno = @TURNO
		
		INSERT INTO RANDOM.RESULTADO_TURNO (IdTurno, Fecha)
		VALUES (@TURNO, GETDATE())
	END
	ELSE
		RAISERROR ('No existe el Turno', 16, 217) WITH SETERROR
END
GO



---------------DATOS PARA ESTRATEGIA-----------------

/* VER REVISAR 
1) TEMA TIPO DNI (OK):
	es necesario utilizar tipo y numero de documento? O se puede usar solo DNI ya que de los medicos y personas cargados solo tenemos dni?
	En el enunciado se pide Tipo y número de documento
HABRIA QUE CREAR LA TABLA Y PONER LOS TIPOS DE DOCUMENTOS
--> creada
2) TEMA USUARIO (OK):
	 Es obligatorio que todas las personas tengan un usuario? Y que un usuario tenga una persona asociada?
	 Todos los afiliados y profesionales tienen que tener un username y password, queda a criterio de ustedes como se hace la asignación. Los mismos son necesarios para poder acceder al sistema y realizar las acciones correspondientes a su rol como la compra de bonos o pedido de turno  en la caso del afiliado o registrar el resultado de una consulta en el caso del profesional.
--> CREAMOS SOLO USUARIO DE PRUEBAS - ADMIN Y LOS OTROS SE MIGRAN
3) AGENDA PROFESIONAL (OK):
	quien manejaria la agenda profesional? podria ser el administrador?
	si podrian considerarlo de ese modo.
--> creo que seria la mejor forma
-> LA MANEJA EL ADMIN
4) No hay bonos de farmacia ni compra de medicamentos. 
-->ok
5) TABLA MAESTRA (OK):
	donde ponemos TURNO NUMERO, TURNO FECHA en la AGENDA O TURNO?
	--> ESTO VA EN TURNO, EL NUMERO DE TURNO ES UNICO POR LO TANTO VA A SER LE ID DE LA TABLA 
6) AFILIADO (OK):
	 Estado ??
	faltan setear cosas
	--> ESTADO ES BAJA O ACTIVO
7)TANTOS INDICES HACEN FALTA? (HAY QE BORRAR O COMENTAR)
--> Emm no se, lo habiamos echo asi el año pasado, pero si se pueden sacar alguno mejor!
-> yo el año pasado hice 2 indices cuando los necesite. para mi son muchos al pedo, talvez en tablas qe ni hace falta, hace corra mas lento el script. Paz
8)CONSULTA SINTOMAS Y ENFERMEDAD SOLO DAN SINTOMA/ENFERMEDAD 1 Y DESPUES NULL (OK)
--> eso se tendra que ir completando a medida de que el paciente va poniendo el sintoma y enfermedad creeria.
9) ESPECIALIDAD POR PROFESIONAL
	el profesional no deberia tener el id de especialidad? no hay forma de joinear?
--> como puede tener muchas especialidades, va a estar en la tabla especialidad por profesional aclarada que especialidad tienen cada profesional.
-> Pero como joinea? porque pedis la especialidad y el profesional, como sabes que es de ese profesional? Paz
10) IDEA NRO AFILIADO (OK):
Para crear el numero de afiliado se me ocurrio crear 2 campos uno que sea el numero de afiliado gral y otro qe sea por familiar, es decir 00, 01 etc. 
Las fechas en cuestion las tomasmos como pensabamos. tomamos que los campos bono_consulta_fecha_impresión  y compra_bono_fecha son independientes
las horas trabajadas son las horas que estuvo atendiendo gente
TURNO FECHA ES LA FECHA EN LA QUE SE EJECUTA EL TURNO.
la matricula del profesional va a ser el id profesional
El peridodo de cancelacion de un profesional se tiene que contar en dias, y no en horas de un solo dia.
Cuando un turno es dado de baja se va a generar otro turno para suplnatar al que se dio de baja en caso de que sea necesario
Usamos una grilla para los horarios disponibles y el date box todos los días de lunes a sábados 
Los síntomas nuevos si bien se cargan una vez, va a ser un gran steing que especifique todos los síntomas que tiene la persona.
Y el síntoma u enfermedad se carga después de que se vio el médico.
No hay números de turno repetidos
Que los nombres de usuarios sean números, 8 numeros. No tienen por qué ser el número de documento de la persona nueva 
1.Que Compra_Bono_Fecha y Bono_Consulta_Fecha_Impresion tengan la misma fecha y todos los demás campos en nulos (exceptuando los datos del usuario y planes médicos)
2.Que Compra_Bono_Fecha, Bono_Consulta_Fecha_Impresion, Consulta_Sintoma y Consulta_Enfermedades sean nulos, y todo lo demás contenga datos. 
3.Que Compra_Bono_Fecha sea nulo y todos los demás campos tengan datos.
1.Se efectúa la compra del bono.
2 corresponde a la solicitud del turno.
3.se refiere a que se efectivizó la consulta, registrando la utilización del bono y el diagnóstico del médico.
Compra_Bono_Fecha es a fecha en la que se compra el bono, y Bono_Consulta_Fecha_Impresion es la fecha en la que se usa el bono.
Hay dos registros de cada persona que tienen numero de turno porque uno es cuando saco el turno, y el otro cuando se concreto el turno, por eso tiene sintomas y enfermedad
No hya numeros de bonos de consultas en mas de un usuario
Poner tipo de documento porque lo dice el enunciado, aunque sean todos dni
+++ En la maestra no hay medicos que sean usuarios -  DONDE DICE? YO CREO QE SI Y YA MIGRE ALGUNOS
Los bonos de farmacia no se compran
No hay que crear en ningun momentos funcionalidades
Si el paciente tiene el turno no nulo, pero a la vez los campos Consulta_Sintomas y Consulta_Enfermedades estan en nulo. ¿Significa que la persona cancelo el turno?
No, ese caso representa la solicitud del turno. Podrian considerar que hubo  una cancelación cuando no hay referencia de Consulta_Sintomas y Consulta_Enfermedades para un cierto número de turno.
Bono_Consulta_Fecha_Impresión se refiere a la fecha en que se compró el bono utilizado.
cuando hay un número de bono repetido en la maestra, se describen dos situaciones. Una  cuando se realiza la compra del bono y la otra cuando el paciente fue atendido utilizando el mismo. 
Hay que definir como hacemos el parentezco entre los familiares en la maestra porque no hay algun campo que nos diga que son familiares
Las 24 hs de cancelacion la podemos tomar como si fuese el dia anterior, no literal 24 hs
En agenda_horario_disponible ponemos todos los horarios que tengan los doctores (los que carguemos nosotros si es que no estan en la maestra) y si  esta disponible o no.
Todos los ID manejemoslo en INT, y los string NVARCHAR porque acepta unicode
Hacer todas las validaciones en c#
en la estrategia aclarar los comentarios que psue en la creacion de la tablas
*/