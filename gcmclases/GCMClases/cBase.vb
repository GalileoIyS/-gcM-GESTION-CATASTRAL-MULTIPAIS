Imports Microsoft.VisualBasic
Imports System.Configuration
Imports System.Web

'Clase Base abstracta para todas las demás
Public Class cBase

#Region "Variables Protegidas"
    Protected _CONNECTION As String
#End Region

#Region "Funciones Protegidas de la Clase"
    Protected Sub InsertaAviso(ByVal psClass As String, ByVal psError As String, ByVal pnType As Integer)

    End Sub
#End Region

#Region "Funciones Publicas de la clase"
    Public Function bPruebaConexion() As Boolean
        'Prueba la conexion con el servidor de Oracle

        Dim cnx As New NpgsqlConnection
        Dim bConecta As Boolean = True

        cnx.ConnectionString = _CONNECTION

        Try
            cnx.Open()
        Catch exp As Exception
            bConecta = False
        Finally
            cnx.Close()
            cnx.Dispose()
        End Try

        Return bConecta
    End Function
#End Region

#Region "Funciones de Conexion a la Base de Datos"
    Public Function ObtenerConexion() As Npgsql.NpgsqlConnection

        Dim customConfigFile As String = Environment.CurrentDirectory & "\\custom.config"
        If (System.IO.File.Exists(customConfigFile)) Then
            Dim fileMap As New ExeConfigurationFileMap()
            fileMap.ExeConfigFilename = customConfigFile

            Dim customConfig As Configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None)

            'Obtiene una cadena de conexion con el servidor de Oracle
            Dim connections As ConnectionStringSettingsCollection = customConfig.ConnectionStrings.ConnectionStrings

            Dim cnx As New NpgsqlConnection
            cnx.ConnectionString = connections("GCMConnection").ConnectionString

            Return cnx
        Else
            Return Nothing
        End If

    End Function
#End Region

End Class
