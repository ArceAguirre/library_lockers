@echo off
Title Creando base de datos
rem /////////////////////////////////////////////////////////////////
rem //	Name: Lic. Josue Aaron Saenz de Leon                       //
rem //	Date: 12/1/2015                                            //
rem //	Ver: 1.0                                                   //
rem /////////////////////////////////////////////////////////////////

set DBName=%~1
set BackUpDir=%~2

set SQLInstance=(local)
set SQLFile=%BackUpDir%\CreateDB.sql

set PATH=%PATH%"%SystemRoot%\system32";"%SystemRoot%\SysWOW64";"%ProgramW6432%";"%ProgramFiles(x86)%";"%CommonProgramFiles%";"%ProgramData%";"%SystemRoot%\System32\Wbem";"%SystemRoot%\System32\WindowsPowerShell\v1.0\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\Tools\Binn\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\";"%ProgramW6432%\Microsoft SQL Server\100\DTS\Binn\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\DTS\Binn\";"%ProgramW6432%\Microsoft Visual Studio 9.0\Common7\IDE\PrivateAssemblies\";"%ProgramFiles(x86)%\Microsoft Visual Studio 9.0\Common7\IDE\PrivateAssemblies\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn"


for /F "usebackq tokens=1,2 delims==" %%i in (`wmic os get LocalDateTime /VALUE 2^>NUL`) do if '.%%i.'=='.LocalDateTime.' set ldt=%%j
set ldt=%ldt:~0,4%/%ldt:~4,2%/%ldt:~6,2% %ldt:~8,2%:%ldt:~10,2%:%ldt:~12,2%
rem set sdt=%ldt:~0,4%-%ldt:~4,2%-%ldt:~6,2%

echo Creando Base de Datos
echo.
echo /Database [%DBName%]    
rem echo /%sdt%
echo.
echo /Eliminando Archivos sql, rpt
del %BackUpDir%\*.sql %BackUpDir%\*.rpt

if not exist %BackUpDir%\NUL echo /Creando Directorio para almacenar Archivos de Sistema...
if not exist %BackUpDir% mkdir %BackUpDir%
if exist %BackUpDir%\NUL echo /Creando Archivos sql y rpt...

:BuildCreateDBScript
echo --Create >> %sqlFile%
echo USE [master] >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo /****** Object:  Database [%DBName%]    Script Date: %ldt% ******/ >> %sqlFile%
echo /****** Programmer: Josue Aaron Saenz de Leon "Arseth" ******/ >> %sqlFile%
echo. >>%sqlFile%
echo IF  NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'%DBName%') >> %sqlFile%
echo 	CREATE DATABASE [%DBName%] >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET COMPATIBILITY_LEVEL = 100 >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled')) >> %sqlFile%
echo begin >> %sqlFile%
echo EXEC [%DBName%].[dbo].[sp_fulltext_database] @action = 'enable' >> %sqlFile%
echo end >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET ANSI_NULL_DEFAULT OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET ANSI_NULLS OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET ANSI_PADDING OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET ANSI_WARNINGS OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET ARITHABORT OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET AUTO_CLOSE OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET AUTO_CREATE_STATISTICS ON  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET AUTO_SHRINK OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET AUTO_UPDATE_STATISTICS ON  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET CURSOR_CLOSE_ON_COMMIT OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET CURSOR_DEFAULT  GLOBAL  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET CONCAT_NULL_YIELDS_NULL OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET NUMERIC_ROUNDABORT OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET QUOTED_IDENTIFIER OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET RECURSIVE_TRIGGERS OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET  DISABLE_BROKER  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET AUTO_UPDATE_STATISTICS_ASYNC OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET DATE_CORRELATION_OPTIMIZATION OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET TRUSTWORTHY OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET ALLOW_SNAPSHOT_ISOLATION OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET PARAMETERIZATION SIMPLE  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET READ_COMMITTED_SNAPSHOT OFF  >> %sqlFile%
echo GO >> %sqlFile%
echo.  >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET HONOR_BROKER_PRIORITY OFF  >> %sqlFile%
echo GO >> %sqlFile%
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
start osql -E -S %SQLInstance% -i  %sqlFile% -o %BackUpDir%\CreateDBReport.rpt
echo /Base de Datos Creada Exitosamente
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
Timeout 5
