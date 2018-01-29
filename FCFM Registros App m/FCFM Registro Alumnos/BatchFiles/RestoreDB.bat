@echo off
Title Restaurando base de datos
rem /////////////////////////////////////////////////////////////////
rem //	Name: Lic. Josue Aaron Saenz de Leon                       //
rem //	Date: 12/1/2015                                            //
rem //	Ver: 1.0                                                   //
rem /////////////////////////////////////////////////////////////////

set DBName=%~1
set BackUpDir=%~2
set BackUpFile=%~3

set SQLInstance=(local)
set DestFile=%BackUpDir%\%BackUpFile%

set SQLFile=%BackUpDir%\RestoreSQL.sql

set PATH=%PATH%"%SystemRoot%\system32";"%SystemRoot%\SysWOW64";"%ProgramW6432%";"%ProgramFiles(x86)%";"%CommonProgramFiles%";"%ProgramData%";"%SystemRoot%\System32\Wbem";"%SystemRoot%\System32\WindowsPowerShell\v1.0\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\Tools\Binn\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\";"%ProgramW6432%\Microsoft SQL Server\100\DTS\Binn\";"%ProgramFiles(x86)%\Microsoft SQL Server\100\DTS\Binn\";"%ProgramW6432%\Microsoft Visual Studio 9.0\Common7\IDE\PrivateAssemblies\";"%ProgramFiles(x86)%\Microsoft Visual Studio 9.0\Common7\IDE\PrivateAssemblies\";"%ProgramW6432%\Microsoft SQL Server\100\Tools\Binn"

echo Restaurando Base de Datos
echo.
echo /Nombre Base de Datos: %DBName%
echo /Archivo %BackUpFile%
echo. 
echo.

for /F "usebackq tokens=1,2 delims==" %%i in (`wmic os get LocalDateTime /VALUE 2^>NUL`) do if '.%%i.'=='.LocalDateTime.' set ldt=%%j
set ldt=%ldt:~0,4%/%ldt:~4,2%/%ldt:~6,2% %ldt:~8,2%:%ldt:~10,2%:%ldt:~12,2%

:BuildRestoreScript
echo -- Restore %BUName%  > %sqlFile%
echo /****** Object:  Database [%DBName%]    Script Date: %ldt% ******/ >> %sqlFile%
echo /****** Programmer: Josue Aaron Saenz de Leon "Arseth" ******/ >> %sqlFile%
echo. >>%sqlFile%
echo USE MASTER >> %sqlFile%
echo GO >> %sqlFile%
echo.
echo --DROP DATABASE [%DBName%]                          >>"%SqlFile%"
echo.  >>"%SqlFile%"
echo.  >>"%SqlFile%"
echo /* RESTORE DB */                                        >>"%SqlFile%"
echo. >>"%SqlFile%"
echo ALTER DATABASE [%DBName%] SET SINGLE_USER WITH ROLLBACK IMMEDIATE >> %sqlFile%
echo GO >> %sqlFile%
echo RESTORE DATABASE [%DBName%] >>"%SqlFile%"
echo FROM DISK = '%DestFile%'    >>"%SqlFile%"
echo WITH REPLACE                                          >>"%SqlFile%"
echo GO >>"%SqlFile%"
echo. >>"%SqlFile%"

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

:RestoringDatabase
echo /Restaurando Archivos de la base de datos...
echo /
start osql -E -S %SQLInstance% -i  %sqlFile% -o %BackUpDir%\RestoreReport.rpt
echo /Base de Datos Restaurada Exitosamente
timeout 5
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
