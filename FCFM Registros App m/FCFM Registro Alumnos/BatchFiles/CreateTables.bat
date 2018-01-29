@echo off
Title Creando Tablas en Base de Datos
rem /////////////////////////////////////////////////////////////////
rem //	Name: Lic. Josue Aaron Saenz de Leon                       //
rem //	Date: 12/1/2015                                            //
rem //	Ver: 1.0                                                   //
rem /////////////////////////////////////////////////////////////////

set DBName=%~1
set BackUpDir=%~2

set SQLInstance=(local)
set SQLFile=%BackUpDir%\CreateTables.sql

set PATH=%PATH%"%SystemRoot%\system32";"%SystemRoot%\SysWOW64";"%ProgramW6432%";"%ProgramFiles(x86)%";"%CommonProgramFiles%";"%ProgramData%";"%SystemRoot%\System32\Wbem";"%SystemRoot%\System32\WindowsPowerShell\v1.0\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\Tools\Binn\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\";"%ProgramW6432%\Microsoft SQL Server\100\DTS\Binn\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\DTS\Binn\";"%ProgramW6432%\Microsoft Visual Studio 9.0\Common7\IDE\PrivateAssemblies\";"%ProgramFiles(x86)%\Microsoft Visual Studio 9.0\Common7\IDE\PrivateAssemblies\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn"


for /F "usebackq tokens=1,2 delims==" %%i in (`wmic os get LocalDateTime /VALUE 2^>NUL`) do if '.%%i.'=='.LocalDateTime.' set ldt=%%j
set ldt=%ldt:~0,4%/%ldt:~4,2%/%ldt:~6,2% %ldt:~8,2%:%ldt:~10,2%:%ldt:~12,2%

echo Creando Tablas en Base de Datos
echo.
echo /Database [%DBName%]
echo.
echo /Creando Archivos Sql y rpt

:BuildCreateTablesScript
echo USE [%DBName%] >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo /****** Object:  Database [%DBName%]    Script Date: %ldt% ******/ >> %sqlFile%
echo /****** Programmer: Josue Aaron Saenz de Leon "Arseth" ******/ >> %sqlFile%
echo. >>%sqlFile%
echo SET ANSI_NULLS ON >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo SET QUOTED_IDENTIFIER ON >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo SET ANSI_PADDING ON >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo CREATE TABLE [dbo].[Registros] >> %sqlFile%
echo ( >> %sqlFile%
echo    [IdRegistros] [int] IDENTITY(1,1) NOT NULL, >> %sqlFile%
echo 	[Matricula] [int] NOT NULL, >> %sqlFile%
echo 	[Hora_E] [varchar](5) NULL, >> %sqlFile%
echo 	[Hora_S] [varchar](5) NULL, >> %sqlFile%
echo 	[Fecha_E] [date] NULL, >> %sqlFile%
echo 	[Fecha_S] [date] NULL, >> %sqlFile%
echo 	[Tipo_Reg] [varchar](2) NULL, >> %sqlFile%
echo 	CONSTRAINT [PK_Registros] PRIMARY KEY CLUSTERED >> %sqlFile%
echo 	(  >> %sqlFile%
echo 		[IdRegistros] ASC >> %sqlFile%
echo 	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] >> %sqlFile%
echo ) ON [PRIMARY] >> %sqlFile%
echo.  >>"%SqlFile%"
echo.  >>"%SqlFile%"
echo CREATE TABLE [dbo].[horario]( >> %sqlFile%
echo 	[IdHorario] [int] IDENTITY(1,1) NOT NULL, >> %sqlFile%
echo 	[Matricula] [int] NOT NULL, >> %sqlFile%
echo 	[Entrada] [varchar](10) NULL, >> %sqlFile%
echo 	[Salida] [varchar](10) NULL, >> %sqlFile%
echo 	[Dia] [varchar](20) NULL, >> %sqlFile%
echo  CONSTRAINT [PK_horario] PRIMARY KEY CLUSTERED >> %sqlFile%
echo ( >> %sqlFile%
echo 	[IdHorario] ASC >> %sqlFile%
echo )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] >> %sqlFile%
echo ) ON [PRIMARY] >> %sqlFile%
echo.  >>"%SqlFile%"
echo.  >>"%SqlFile%"
echo CREATE TABLE [dbo].[alumnos]( >> %sqlFile%
echo 	[matricula] [int] NOT NULL, >> %sqlFile%
echo 	[nombre] [varchar](50) NULL, >> %sqlFile%
echo 	[ap_paterno] [varchar](50) NULL, >> %sqlFile%
echo 	[ap_materno] [varchar](50) NULL, >> %sqlFile%
echo 	[carrera] [varchar](50) NULL, >> %sqlFile%
echo 	[semestre] [int] NULL, >> %sqlFile%
echo 	[tipo_servicio] [varchar](50) NULL, >> %sqlFile%
echo 	[periodo] [varchar](50) NULL, >> %sqlFile%
echo  CONSTRAINT [PK_alumos] PRIMARY KEY CLUSTERED >> %sqlFile% 
echo ( >> %sqlFile%
echo 	[matricula] ASC >> %sqlFile%
echo )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] >> %sqlFile%
echo ) ON [PRIMARY] >> %sqlFile%
echo.  >>"%SqlFile%"
echo.  >>"%SqlFile%"
echo CREATE TABLE [dbo].[LoginUsers]( >> %sqlFile%
echo 	[idUser] [int] IDENTITY(1,1) NOT NULL, >> %sqlFile%
echo 	[UserName] [varchar](50) NULL, >> %sqlFile%
echo 	[UserPassword] [varchar](500) NOT NULL, >> %sqlFile%
echo  CONSTRAINT [PK_LoginUsers] PRIMARY KEY CLUSTERED  >> %sqlFile%
echo ( >> %sqlFile%
echo 	[idUser] ASC >> %sqlFile%
echo )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] >> %sqlFile%
echo ) ON [PRIMARY] >> %sqlFile%
echo.  >>"%SqlFile%"
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo SET ANSI_PADDING OFF >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER TABLE [dbo].[horario]  WITH CHECK ADD  CONSTRAINT [FK_horario_alumnos] FOREIGN KEY([Matricula]) >> %sqlFile%
echo REFERENCES [dbo].[alumnos] ([matricula]) >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER TABLE [dbo].[horario] CHECK CONSTRAINT [FK_horario_alumnos] >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER TABLE [dbo].[Registros]  WITH CHECK ADD  CONSTRAINT [FK_Registros_alumnos] FOREIGN KEY([Matricula]) >> %sqlFile%
echo REFERENCES [dbo].[alumnos] ([matricula]) >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER TABLE [dbo].[Registros] CHECK CONSTRAINT [FK_Registros_alumnos] >> %sqlFile%
echo GO >> %sqlFile%
echo. >>"%SqlFile%"
echo INSERT INTO [LoginUsers] (UserName, UserPassword) VALUES('Manager','mlmUZMWNO9DI6uCAKmf4rzliua2gHPcdtMkca5LSa+YPFjYDHD6DFRVfaFMzwWXP0411c9PglEvMwTW96VMPADRz') >>"%SqlFile%"
echo.  >>"%SqlFile%"
GOTO StartingSQLService

:StartingSQLService
echo /Starting SQL service if not started
echo.
rem set service=%SQLInstance:(local)\=MSSQL$%
set service="SQL Server (%SQLInstance%)"
echo /%service%
if /I "%SQLInstance%"=="(Local)" ( 
set service=MSSQLSERVER 
)
echo /Starting %service%
echo.
net start %service%
GOTO RestoringDatabase

:RestoringDatabase
echo /Creando Archivos de la base de datos...
echo /
start osql -E -S %SQLInstance% -i  %sqlFile% -o %BackUpDir%\CreateTablesReport.rpt
echo /Tablas Creadas Exitosamente
GOTO EndBatch

:FileMissing
color fc
echo.
echo.
echo.
echo /Can not locate File: %sourceFile%
echo /Please verify file Exists
echo.
GOTO EndBatch


:EndBatch
echo.
echo /Eliminando Archivos Temporales
echo ....
timeout 2
echo ....
timeout 2
echo ....
echo /
echo.
del %BackUpDir%\*.sql
Timeout 5
