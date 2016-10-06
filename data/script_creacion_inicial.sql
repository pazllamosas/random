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

-- DROP TRIGGERS

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
	habilitada bit DEFAULT 1	
	)

CREATE TABLE RANDOM.USUARIO(
	IdUsuario int PRIMARY KEY IDENTITY(1,1),
	Username nvarchar(255) NOT NULL UNIQUE,
	Pass nvarchar(255) NOT NULL,
	FechaCreacion datetime,
	UltimaModificacion datetime,
	IntentosFallidos int NOT NULL DEFAULT 0,
	habilitada bit DEFAULT 1
)
CREATE TABLE RANDOM.USUARIO_POR_ROL(
	IdUsuario int,
	IdRol int,
	habilitada bit DEFAULT 1
)

CREATE TABLE RANDOM.PERSONA(
	IdPersona int PRIMARY KEY IDENTITY(1,1),
	Nombre nvarchar(255),
	Apellido nvarchar(255),
	IdTipoDocumento int, 
	Dni numeric(18,0),
	Direccion nvarchar(255),
	Telefono numeric(18, 0),
	Mail nvarchar(255),
	Fecha_Nac datetime,
	Baja bit DEFAULT 0,
	IdUsuario int
)

CREATE TABLE RANDOM.TIPOS_DOCUMENTOS(
	IdTipoDocumento int PRIMARY KEY IDENTITY(1,1),
	Descripcion nvarchar(250)
)

CREATE TABLE RANDOM.AFILIADO(
	IdPersona int PRIMARY KEY,
	IdEstadoCivil int,
	CantidadACargo int DEFAULT '0',
	IdPlan int,
	NumeroAfiliadoRaiz int IDENTITY(1,1),
	NumeroAfiliadoExt int DEFAULT '00',
	Estado bit DEFAULT '1', --1 ACTIVO 0 BAJA
	NumeroUltimoBono int
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
	IdProfesional int PRIMARY KEY
	--Matricula int no va porque el id profesional seria la matricula
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
	MontoTotal int
)

CREATE TABLE RANDOM.BONO(
	IdBono int PRIMARY KEY, -- seria el numero de bono 
	IdCompra int DEFAULT NULL,
	--Estado nvarchar(255), creo que no va
	Precio int,
	FechaConsultaImpresion datetime,
	ConsultaNumero numeric(18),
	habilitado bit DEFAULT 1
)

CREATE TABLE RANDOM.AGENDA_HORARIO_DISPONIBLE(
	IdAgenda int PRIMARY KEY IDENTITY (1,1),
	IdProfesional int,
	FechaYHoraDesde datetime,
	FechaYHoraHasta datetime,
	IdEspecialidad int,
	EstadoDisponibilidad nvarchar(255)
)

CREATE TABLE RANDOM.TURNO(
	IdTurno int PRIMARY KEY,
	IdAgenda int,
	Estado nvarchar(255),
	FechaYHora datetime,
	IdBono int,
	--IdResultado int,
	habilitado bit DEFAULT 1
)

CREATE TABLE RANDOM.RESULTADO_TURNO(
	IdResultadoTurno int PRIMARY KEY IDENTITY(1,1),
	IdTurno int,
	Sintomas nvarchar(255),
	Enfermedades nvarchar(255),
	Fecha datetime
)

CREATE TABLE RANDOM.CANCELACION(
	IdCancelacion int PRIMARY KEY IDENTITY(1,1),
	IdTipoCancelacion int,
	IdTurno int
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
ALTER TABLE RANDOM.AGENDA_HORARIO_DISPONIBLE ADD FOREIGN KEY (IdProfesional) REFERENCES RANDOM.PROFESIONAL
ALTER TABLE RANDOM.AGENDA_HORARIO_DISPONIBLE ADD FOREIGN KEY (IdEspecialidad) REFERENCES RANDOM.ESPECIALIDAD
ALTER TABLE RANDOM.TURNO ADD FOREIGN KEY (IdAgenda) REFERENCES RANDOM.AGENDA_HORARIO_DISPONIBLE
ALTER TABLE RANDOM.TURNO ADD FOREIGN KEY (IdBono) REFERENCES RANDOM.BONO
ALTER TABLE RANDOM.RESULTADO_TURNO ADD FOREIGN KEY (IdTurno) REFERENCES RANDOM.TURNO
ALTER TABLE RANDOM.CANCELACION ADD FOREIGN KEY (IdTipoCancelacion) REFERENCES RANDOM.TIPO_CANCELACION
ALTER TABLE RANDOM.CANCELACION ADD FOREIGN KEY (IdTurno) REFERENCES RANDOM.TURNO
ALTER TABLE RANDOM.PERSONA ADD FOREIGN KEY (IdTipoDocumento) REFERENCES RANDOM.TIPOS_DOCUMENTOS
ALTER TABLE RANDOM.PERSONA ADD FOREIGN KEY (IdUsuario) REFERENCES RANDOM.Usuario

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
VALUES(10,2,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(10,3,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(11,3,1)
INSERT INTO RANDOM.ROL_POR_FUNCIONALIDADES
VALUES(12,2,1)

/*USUARIO*/
INSERT INTO RANDOM.USUARIO(Username,Pass)
VALUES('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
INSERT INTO RANDOM.USUARIO(Username,Pass)
VALUES('ana','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
INSERT INTO RANDOM.USUARIO(Username,Pass)
VALUES('maria','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
INSERT INTO RANDOM.USUARIO(Username,Pass)
VALUES('jose','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
INSERT INTO RANDOM.USUARIO(Username,Pass)
VALUES('pepe','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
	
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
VALUES ('Documento Nacional de Identidad')
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('Libreta de enrolamiento')
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('Libreta Civica')
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('Cédula de Identidad')
INSERT INTO RANDOM.TIPOS_DOCUMENTOS(Descripcion)
VALUES ('Pasaporte')

/*USUARIO_POR_ROL*/
INSERT INTO RANDOM.USUARIO_POR_ROL(IdUsuario,IdRol)
SELECT U.IdUsuario, 1
FROM RANDOM.USUARIO U, RANDOM.ROL R
WHERE R.Descripcion = 'Administrador'

/*PERSONA*/ -- agregamos los afiliados nada mas aca
INSERT INTO RANDOM.PERSONA(Nombre, Apellido, IdTipoDocumento, Dni, Direccion, Telefono, Mail, Fecha_Nac) 
SELECT DISTINCT M.Paciente_Nombre, M.Paciente_Apellido, 1, M.Paciente_Dni, M.Paciente_Direccion, M.Paciente_Telefono, M.Paciente_Mail, M.Paciente_Fecha_Nac
FROM gd_esquema.Maestra M

/*PERSONA*/ -- agregamos los medicos nada mas aca
INSERT INTO RANDOM.PERSONA(Nombre, Apellido, Dni, Direccion, Telefono, Mail, Fecha_Nac) 
SELECT DISTINCT M.Medico_Nombre, M.Medico_Apellido, M.Medico_Dni, M.Medico_Direccion, M.Medico_Telefono, M.Medico_Mail, M.Medico_Fecha_Nac
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
--FALTAN numero ultimo bono que no me acuerdo de nuevo para que era. Cubi.

/*TIPO_ESPECIALIDAD*/
INSERT INTO RANDOM.TIPO_ESPECIALIDAD(Codigo,Descripcion)
SELECT DISTINCT M.Tipo_Especialidad_Codigo, M.Tipo_Especialidad_Descripcion
FROM gd_esquema.Maestra M

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
INSERT INTO RANDOM.HISTORIAL_PLAN(IdAfiliado, Fecha)
SELECT DISTINCT A.IdPersona, '1957-10-24 00:00:00.000'
FROM RANDOM.AFILIADO A

/*ESPECIALIDAD_POR_PROFESIONAL*/
INSERT RANDOM.ESPECIALIDAD_POR_PROFESIONAL (IdProfesional, IdEspecialidad)
SELECT DISTINCT P.IdPersona, E.IdEspecialidad
FROM RANDOM.PERSONA P, gd_esquema.Maestra M, RANDOM.ESPECIALIDAD E
where M.Medico_Dni = P.Dni and  E.Codigo = M.Especialidad_Codigo

/*COMPRA_BONO*/


/*BONO*/
/*INSERT RANDOM.BONO (IdCompra, Precio, FechaConsultaImpresion, ConsultaNumero)
SELECT DISTINCT 
FROM gd_esquema.Maestra M
where */

/*AGENDA_HORARIO_DISPONIBLE*/

/*TURNO*/

/*RESULTADO_TURNO*/





/* VER REVISAR 
1) TEMA TIPO DNI (OK):
	es necesario utilizar tipo y numero de documento? O se puede usar solo DNI ya que de los medicos y personas cargados solo tenemos dni?
	En el enunciado se pide Tipo y número de documento
HABRIA QUE CREAR LA TABLA Y PONER LOS TIPOS DE DOCUMENTOS
--> creada

2) TEMA USUARIO (OK):
	 Es obligatorio que todas las personas tengan un usuario? Y que un usuario tenga una persona asociada?
	 Todos los afiliados y profesionales tienen que tener un username y password, queda a criterio de ustedes como se hace la asignación. Los mismos son necesarios para poder acceder al sistema y realizar las acciones correspondientes a su rol como la compra de bonos o pedido de turno  en la caso del afiliado o registrar el resultado de una consulta en el caso del profesional.
--> CREAMOS SOLO USUARIO DE PRUEBAS

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
*/


