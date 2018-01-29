using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************/
/*  Author      |   Arcelia Aguirre         */
/*  Date        |   24-01-2018              */
/*  Description |   Nueva clase para definir*/
/*                  la coneccion a la base  */
/*                  de datos                */
/********************************************/
namespace FCFM_Registro_Alumnos
{
    public class Connection
    {
        //public static string SERVER = "ISLABIBLIO-02\\SQLEXPRESS";
        //public static string SERVER = "148.234.35.153";
        //public static string SERVER = "148.234.35.153\\SQLEXPRESS,1433";
        //public static string CONNECTION_STRING = 
        //    "Database=" + DATA_BASE +
        //    ";Server= " + SERVER +
        //    ";Integrated Security=SSPI;" +
        //    "User ID=" + USER +
        //    ";Password=" + PASSWORD;

        public static string SERVER = "148.234.35.216\\SQLEXPRESS";
        public static string USER = "sa";
        public static string PASSWORD = "root";
        public static string DATA_BASE = "FCFM Registro Horas";
        
        public static string CONNECTION_STRING =    
            ";Data Source = " + SERVER +
            ";Initial Catalog =" + DATA_BASE +
            ";User ID=" + USER +
            ";Password=" + PASSWORD +
            ";Network Library=DBMSSOCN";

        public Connection(){}
    }
}