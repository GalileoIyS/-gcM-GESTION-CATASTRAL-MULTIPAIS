Public Class cVW_CROPS
    Inherits cBase
    Implements IDisposable

#Region "Constantes Privadas"
    Private Const strConsulta = "SELECT OID, LOCAL_ID, CROP_TYPE, CROP_TYPE_DESC, AREA, " &
                                "ECONOMIC_VALUE FROM VW_CROPS " &
                                "WHERE 1=1 "
#End Region

#Region "Variables Privadas"
    Protected _OID As String
    Protected _LOCAL_ID As String
    Protected _CROP_TYPE As String
    Protected _CROP_TYPE_DESC As String
    Protected _AREA As Nullable(Of Decimal)
    Protected _ECONOMIC_VALUE As Nullable(Of Decimal)
#End Region

#Region "Propiedades Publicas"
    Public ReadOnly Property Tabla() As String
        Get
            Return "vw_crops"
        End Get
    End Property
    <Display(Name:="Oid")>
    <StringLength(48, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property oid As String
        Get
            Return _OID
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _OID = value.Trim()
            Else
                _OID = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Local_Id")>
    <StringLength(48, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property local_id As String
        Get
            Return _LOCAL_ID
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _LOCAL_ID = value.Trim()
            Else
                _LOCAL_ID = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Crop_Type")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property crop_type As String
        Get
            Return _CROP_TYPE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _CROP_TYPE = value.Trim()
            Else
                _CROP_TYPE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Crop_Type_Desc")>
    <StringLength(0, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property crop_type_desc As String
        Get
            Return _CROP_TYPE_DESC
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _CROP_TYPE_DESC = value.Trim()
            Else
                _CROP_TYPE_DESC = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Area")>
    Public Property area As Nullable(Of Decimal)
        Get
            Return _AREA
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _AREA = value
        End Set
    End Property
    <Display(Name:="Economic_Value")>
    Public Property economic_value As Nullable(Of Decimal)
        Get
            Return _ECONOMIC_VALUE
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _ECONOMIC_VALUE = value
        End Set
    End Property
#End Region

#Region "Funciones Publicas de la Clase"
    Public Sub New()
        'Realiza la generación del ejemplar estándar.
        MyBase.New()
        'Inicializa las variables privadas de la clase.
        Inicializar()
    End Sub
    Public Sub Inicializar()
        Me._OID = String.Empty
        Me._LOCAL_ID = String.Empty
        Me._CROP_TYPE = String.Empty
        Me._CROP_TYPE_DESC = String.Empty
        Me._AREA = Nothing
        Me._ECONOMIC_VALUE = Nothing
    End Sub
    Public Function bConsultar() As Boolean
        Dim bOk As Boolean = True
        Dim SqlConsulta As New NpgsqlCommand
        Dim drDATOS As NpgsqlDataReader
        Dim dbconexion As New NpgsqlConnection

        dbconexion = Me.ObtenerConexion()

        'Intentamos abrir la conexión
        Try
            dbconexion.Open()
        Catch excp As NpgsqlException
            InsertaAviso(Me.Tabla, excp.Message, 1)
            Return False
        End Try

        Try
            With SqlConsulta
                .Connection = dbconexion
                .CommandText = strConsulta
                .CommandType = CommandType.Text

                If Not String.IsNullOrEmpty(Me._OID) Then
                    .CommandText = .CommandText & " AND OID = :P_OID "
                    .Parameters.Add("P_OID", NpgsqlDbType.Varchar).Value = Me._OID
                End If
            End With
            drDATOS = SqlConsulta.ExecuteReader()
        Catch excp As NpgsqlException
            InsertaAviso(Me.Tabla, excp.Message, 2)
            dbconexion.Close()
            dbconexion.Dispose()
            Return False
        End Try

        With drDATOS
            If .Read Then
                Me.Inicializar()
                If Not .IsDBNull(.GetOrdinal("OID")) Then
                    Me._OID = .GetValue(.GetOrdinal("OID"))
                End If
                If Not .IsDBNull(.GetOrdinal("LOCAL_ID")) Then
                    Me._LOCAL_ID = .GetValue(.GetOrdinal("LOCAL_ID"))
                End If
                If Not .IsDBNull(.GetOrdinal("CROP_TYPE")) Then
                    Me._CROP_TYPE = .GetValue(.GetOrdinal("CROP_TYPE"))
                End If
                If Not .IsDBNull(.GetOrdinal("CROP_TYPE_DESC")) Then
                    Me._CROP_TYPE_DESC = .GetValue(.GetOrdinal("CROP_TYPE_DESC"))
                End If
                If Not .IsDBNull(.GetOrdinal("AREA")) Then
                    Me._AREA = Convert.ToInt32(.GetValue(.GetOrdinal("AREA")))
                End If
                If Not .IsDBNull(.GetOrdinal("ECONOMIC_VALUE")) Then
                    Me._ECONOMIC_VALUE = Convert.ToInt32(.GetValue(.GetOrdinal("ECONOMIC_VALUE")))
                End If
            Else
                bOk = False
            End If
        End With

        'Cerramos las Conexiones
        drDATOS.Close()
        dbconexion.Close()

        Return bOk

    End Function
    Public Function ObtenerTablaDatos(ByVal psFiltro As String, ByVal pageSize As Integer, ByVal currentPage As Integer, ByVal psOrderBy As String) As DataTable
        Dim dbconexion As New NpgsqlConnection
        Dim tblResultados As System.Data.DataTable = Nothing

        dbconexion = Me.ObtenerConexion()

        'Intentamos abrir la conexión
        Try
            dbconexion.Open()
        Catch excp As NpgsqlException
            InsertaAviso(Me.Tabla, excp.Message, 1)
            Return Nothing
        End Try

        Try
            Dim SqlConsulta As New NpgsqlCommand
            Dim daData As New NpgsqlDataAdapter
            Dim _dtData As New DataTable

            'Limpiamos el contenido de la Tabla de Datos
            _dtData.Clear()

            With SqlConsulta
                .Connection = dbconexion
                .CommandType = CommandType.Text
                .CommandText = strConsulta

                If Not String.IsNullOrEmpty(Me._OID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(OID) LIKE :P_OID "
                    .Parameters.Add("P_OID", NpgsqlDbType.Varchar).Value = "%" & Me._OID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._LOCAL_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(LOCAL_ID) LIKE :P_LOCAL_ID "
                    .Parameters.Add("P_LOCAL_ID", NpgsqlDbType.Varchar).Value = "%" & Me._LOCAL_ID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._CROP_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(CROP_TYPE) LIKE :P_CROP_TYPE "
                    .Parameters.Add("P_CROP_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._CROP_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._CROP_TYPE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(CROP_TYPE_DESC) LIKE :P_CROP_TYPE_DESC "
                    .Parameters.Add("P_CROP_TYPE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._CROP_TYPE_DESC.ToUpper() & "%"
                End If
                If Me._AREA.HasValue Then
                    .CommandText = .CommandText & " AND AREA = :P_AREA "
                    .Parameters.Add("P_AREA", NpgsqlDbType.Numeric).Value = Me._AREA.Value
                End If
                If Me._ECONOMIC_VALUE.HasValue Then
                    .CommandText = .CommandText & " AND ECONOMIC_VALUE = :P_ECONOMIC_VALUE "
                    .Parameters.Add("P_ECONOMIC_VALUE", NpgsqlDbType.Numeric).Value = Me._ECONOMIC_VALUE.Value
                End If
                If Not String.IsNullOrEmpty(psFiltro.Trim()) Then
                    .CommandText = .CommandText & psFiltro
                End If
                If Not String.IsNullOrEmpty(psOrderBy.Trim()) Then
                    .CommandText = .CommandText & " ORDER BY " & psOrderBy
                End If
            End With

            daData.SelectCommand = SqlConsulta
            daData.Fill(_dtData)

            If pageSize = 0 Then
                Return _dtData
            End If

            tblResultados = _dtData.Clone()
            Dim lastRows As IEnumerable(Of DataRow) = _dtData.Rows.Cast(Of DataRow).Skip((currentPage - 1) * pageSize).Take(pageSize)

            For Each Fila As System.Data.DataRow In lastRows
                tblResultados.ImportRow(Fila)
            Next

        Catch excp As NpgsqlException
            InsertaAviso(Me.Tabla, excp.Message, 6)
        Finally
            dbconexion.Close()
        End Try

        Return tblResultados

    End Function
    Public Function ObtenerListaDatos(ByRef totalrecords As Integer, ByVal psFiltro As String, ByVal pageSize As Integer, ByVal currentPage As Integer, ByVal psOrderBy As String) As List(Of cVW_CROPS)
        Dim dbconexion As New NpgsqlConnection
        Dim resultados As List(Of cVW_CROPS) = New List(Of cVW_CROPS)

        dbconexion = Me.ObtenerConexion()

        'Intentamos abrir la conexión
        Try
            dbconexion.Open()
        Catch excp As NpgsqlException
            InsertaAviso(Me.Tabla, excp.Message, 1)
            Return Nothing
        End Try

        Try
            Dim SqlConsulta As New NpgsqlCommand
            Dim daData As New NpgsqlDataAdapter
            Dim _dtData As New DataTable

            'Limpiamos el contenido de la Tabla de Datos
            _dtData.Clear()

            With SqlConsulta
                .Connection = dbconexion
                .CommandType = CommandType.Text
                .CommandText = strConsulta

                If Not String.IsNullOrEmpty(Me._OID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(OID) LIKE :P_OID "
                    .Parameters.Add("P_OID", NpgsqlDbType.Varchar).Value = "%" & Me._OID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._LOCAL_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(LOCAL_ID) LIKE :P_LOCAL_ID "
                    .Parameters.Add("P_LOCAL_ID", NpgsqlDbType.Varchar).Value = "%" & Me._LOCAL_ID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._CROP_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(CROP_TYPE) LIKE :P_CROP_TYPE "
                    .Parameters.Add("P_CROP_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._CROP_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._CROP_TYPE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(CROP_TYPE_DESC) LIKE :P_CROP_TYPE_DESC "
                    .Parameters.Add("P_CROP_TYPE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._CROP_TYPE_DESC.ToUpper() & "%"
                End If
                If Me._AREA.HasValue Then
                    .CommandText = .CommandText & " AND AREA = :P_AREA "
                    .Parameters.Add("P_AREA", NpgsqlDbType.Numeric).Value = Me._AREA.Value
                End If
                If Me._ECONOMIC_VALUE.HasValue Then
                    .CommandText = .CommandText & " AND ECONOMIC_VALUE = :P_ECONOMIC_VALUE "
                    .Parameters.Add("P_ECONOMIC_VALUE", NpgsqlDbType.Numeric).Value = Me._ECONOMIC_VALUE.Value
                End If
                If Not String.IsNullOrEmpty(psFiltro.Trim()) Then
                    .CommandText = .CommandText & psFiltro
                End If
                If Not String.IsNullOrEmpty(psOrderBy.Trim()) Then
                    .CommandText = .CommandText & " ORDER BY " & psOrderBy
                End If
            End With

            daData.SelectCommand = SqlConsulta
            daData.Fill(_dtData)

            totalrecords = _dtData.Rows.Count

            Dim oLista = From filas In _dtData.Rows Select filas

            For Each row As DataRow In oLista.Skip(currentPage).Take(If(pageSize = 0, totalrecords, pageSize))
                Dim objClase As New cVW_CROPS With {
                                  ._OID = row("OID").ToString(),
                                  ._LOCAL_ID = row("LOCAL_ID").ToString(),
                                  ._CROP_TYPE = row("CROP_TYPE").ToString(),
                                  ._CROP_TYPE_DESC = row("CROP_TYPE_DESC").ToString(),
                                  ._AREA = If((TypeOf row("AREA") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("AREA"))),
                                  ._ECONOMIC_VALUE = If((TypeOf row("ECONOMIC_VALUE") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("ECONOMIC_VALUE")))
          }

                resultados.Add(objClase)
            Next

        Catch excp As NpgsqlException
            InsertaAviso(Me.Tabla, excp.Message, 6)
        Finally
            dbconexion.Close()
            dbconexion.Dispose()
        End Try

        Return resultados

    End Function
#End Region

#Region "Soporte a la Interfaz IDisposable "
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes 

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
            End If

            ' TODO: Liberar recursos no administrados compartidos
        End If
        Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
