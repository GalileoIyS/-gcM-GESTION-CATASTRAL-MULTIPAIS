Public Class cVW_EXT_CUR_VALUATION
    Inherits cBase
    Implements IDisposable

#Region "Constantes Privadas"
    Private Const strConsulta = "SELECT LOCAL_ID, PERIOD, VALUE, VALUE_DATE, VALUE_TYPE, " &
                                "VALUE_TYPE_DESC FROM VW_EXT_CUR_VALUATION " &
                                "WHERE 1=1 "
#End Region

#Region "Variables Privadas"
    Protected _LOCAL_ID As String
    Protected _PERIOD As Nullable(Of Integer)
    Protected _VALUE As Nullable(Of Decimal)
    Protected _VALUE_DATE As Nullable(Of DateTime)
    Protected _VALUE_TYPE As String
    Protected _VALUE_TYPE_DESC As String
#End Region

#Region "Propiedades Publicas"
    Public ReadOnly Property Tabla() As String
        Get
            Return "vw_ext_cur_valuation"
        End Get
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
    <Display(Name:="Period")>
    Public Property period As Nullable(Of Integer)
        Get
            Return _PERIOD
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _PERIOD = value
        End Set
    End Property
    <Display(Name:="Value")>
    Public Property value As Nullable(Of Decimal)
        Get
            Return _VALUE
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _VALUE = value
        End Set
    End Property
    <Display(Name:="Value_Date")>
    Public Property value_date As Nullable(Of DateTime)
        Get
            Return _VALUE_DATE
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _VALUE_DATE = value
        End Set
    End Property
    <Display(Name:="Value_Type")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property value_type As String
        Get
            Return _VALUE_TYPE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _VALUE_TYPE = value.Trim()
            Else
                _VALUE_TYPE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Value_Type_Desc")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property value_type_desc As String
        Get
            Return _VALUE_TYPE_DESC
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _VALUE_TYPE_DESC = value.Trim()
            Else
                _VALUE_TYPE_DESC = String.Empty
            End If
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
        Me._LOCAL_ID = String.Empty
        Me._PERIOD = Nothing
        Me._VALUE = Nothing
        Me._VALUE_DATE = Nothing
        Me._VALUE_TYPE = String.Empty
        Me._VALUE_TYPE_DESC = String.Empty
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

                If Not String.IsNullOrEmpty(Me._LOCAL_ID) Then
                    .CommandText = .CommandText & " AND LOCAL_ID = :P_LOCAL_ID "
                    .Parameters.Add("P_LOCAL_ID", NpgsqlDbType.Varchar).Value = Me._LOCAL_ID
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
                If Not .IsDBNull(.GetOrdinal("LOCAL_ID")) Then
                    Me._LOCAL_ID = .GetValue(.GetOrdinal("LOCAL_ID"))
                End If
                If Not .IsDBNull(.GetOrdinal("PERIOD")) Then
                    Me._PERIOD = Convert.ToInt32(.GetValue(.GetOrdinal("PERIOD")))
                End If
                If Not .IsDBNull(.GetOrdinal("VALUE")) Then
                    Me._VALUE = Convert.ToInt32(.GetValue(.GetOrdinal("VALUE")))
                End If
                If Not .IsDBNull(.GetOrdinal("VALUE_DATE")) Then
                    Me._VALUE_DATE = Convert.ToDateTime(.GetValue(.GetOrdinal("VALUE_DATE")))
                End If
                If Not .IsDBNull(.GetOrdinal("VALUE_TYPE")) Then
                    Me._VALUE_TYPE = .GetValue(.GetOrdinal("VALUE_TYPE"))
                End If
                If Not .IsDBNull(.GetOrdinal("VALUE_TYPE_DESC")) Then
                    Me._VALUE_TYPE_DESC = .GetValue(.GetOrdinal("VALUE_TYPE_DESC"))
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

                If Not String.IsNullOrEmpty(Me._LOCAL_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(LOCAL_ID) LIKE :P_LOCAL_ID "
                    .Parameters.Add("P_LOCAL_ID", NpgsqlDbType.Varchar).Value = "%" & Me._LOCAL_ID.ToUpper() & "%"
                End If
                If Me._PERIOD.HasValue Then
                    .CommandText = .CommandText & " AND PERIOD = :P_PERIOD "
                    .Parameters.Add("P_PERIOD", NpgsqlDbType.Smallint).Value = Me._PERIOD.Value
                End If
                If Me._VALUE.HasValue Then
                    .CommandText = .CommandText & " AND VALUE = :P_VALUE "
                    .Parameters.Add("P_VALUE", NpgsqlDbType.Numeric).Value = Me._VALUE.Value
                End If
                If Me._VALUE_DATE.HasValue Then
                    .CommandText = .CommandText & " AND VALUE_DATE = :P_VALUE_DATE "
                    .Parameters.Add("P_VALUE_DATE", NpgsqlDbType.Timestamp).Value = Me._VALUE_DATE.Value
                End If
                If Not String.IsNullOrEmpty(Me._VALUE_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(VALUE_TYPE) LIKE :P_VALUE_TYPE "
                    .Parameters.Add("P_VALUE_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._VALUE_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._VALUE_TYPE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(VALUE_TYPE_DESC) LIKE :P_VALUE_TYPE_DESC "
                    .Parameters.Add("P_VALUE_TYPE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._VALUE_TYPE_DESC.ToUpper() & "%"
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
    Public Function ObtenerListaDatos(ByRef totalrecords As Integer, ByVal psFiltro As String, ByVal pageSize As Integer, ByVal currentPage As Integer, ByVal psOrderBy As String) As List(Of cVW_EXT_CUR_VALUATION)
        Dim dbconexion As New NpgsqlConnection
        Dim resultados As List(Of cVW_EXT_CUR_VALUATION) = New List(Of cVW_EXT_CUR_VALUATION)

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

                If Not String.IsNullOrEmpty(Me._LOCAL_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(LOCAL_ID) LIKE :P_LOCAL_ID "
                    .Parameters.Add("P_LOCAL_ID", NpgsqlDbType.Varchar).Value = "%" & Me._LOCAL_ID.ToUpper() & "%"
                End If
                If Me._PERIOD.HasValue Then
                    .CommandText = .CommandText & " AND PERIOD = :P_PERIOD "
                    .Parameters.Add("P_PERIOD", NpgsqlDbType.Smallint).Value = Me._PERIOD.Value
                End If
                If Me._VALUE.HasValue Then
                    .CommandText = .CommandText & " AND VALUE = :P_VALUE "
                    .Parameters.Add("P_VALUE", NpgsqlDbType.Numeric).Value = Me._VALUE.Value
                End If
                If Me._VALUE_DATE.HasValue Then
                    .CommandText = .CommandText & " AND VALUE_DATE = :P_VALUE_DATE "
                    .Parameters.Add("P_VALUE_DATE", NpgsqlDbType.Timestamp).Value = Me._VALUE_DATE.Value
                End If
                If Not String.IsNullOrEmpty(Me._VALUE_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(VALUE_TYPE) LIKE :P_VALUE_TYPE "
                    .Parameters.Add("P_VALUE_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._VALUE_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._VALUE_TYPE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(VALUE_TYPE_DESC) LIKE :P_VALUE_TYPE_DESC "
                    .Parameters.Add("P_VALUE_TYPE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._VALUE_TYPE_DESC.ToUpper() & "%"
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
                Dim objClase As New cVW_EXT_CUR_VALUATION With {
                                    ._LOCAL_ID = row("LOCAL_ID").ToString(),
                                    ._PERIOD = If((TypeOf row("PERIOD") Is DBNull), DirectCast(Nothing, System.Nullable(Of Integer)), Convert.ToInt32(row("PERIOD"))),
                                    ._VALUE = If((TypeOf row("VALUE") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("VALUE"))),
                                    ._VALUE_DATE = If((TypeOf row("VALUE_DATE") Is DBNull), DirectCast(Nothing, System.Nullable(Of Date)), Convert.ToDateTime(row("VALUE_DATE"))),
                                    ._VALUE_TYPE = row("VALUE_TYPE").ToString(),
                                    ._VALUE_TYPE_DESC = row("VALUE_TYPE_DESC").ToString()
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
