Public Class cVW_EXT_CUR_TAXATION
    Inherits cBase
    Implements IDisposable

#Region "Constantes Privadas"
    Private Const strConsulta = "SELECT LOCAL_ID, FISCAL_PERIOD, TAX_TYPE, TAX_TYPE_DESC, TAX_DATE, " &
                                "AMOUNT, AMOUNT_PAID, PERCENT_PAID FROM VW_EXT_CUR_TAXATION " &
                                "WHERE 1=1 "
#End Region

#Region "Variables Privadas"
    Protected _LOCAL_ID As String
    Protected _FISCAL_PERIOD As String
    Protected _TAX_TYPE As String
    Protected _TAX_TYPE_DESC As String
    Protected _TAX_DATE As Nullable(Of DateTime)
    Protected _AMOUNT As Nullable(Of Decimal)
    Protected _AMOUNT_PAID As Nullable(Of Decimal)
    Protected _PERCENT_PAID As Nullable(Of Decimal)
#End Region

#Region "Propiedades Publicas"
    Public ReadOnly Property Tabla() As String
        Get
            Return "vw_ext_cur_taxation"
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
    <Display(Name:="Fiscal_Period")>
    <StringLength(12, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property fiscal_period As String
        Get
            Return _FISCAL_PERIOD
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _FISCAL_PERIOD = value.Trim()
            Else
                _FISCAL_PERIOD = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Tax_Type")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property tax_type As String
        Get
            Return _TAX_TYPE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _TAX_TYPE = value.Trim()
            Else
                _TAX_TYPE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Tax_Type_Desc")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property tax_type_desc As String
        Get
            Return _TAX_TYPE_DESC
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _TAX_TYPE_DESC = value.Trim()
            Else
                _TAX_TYPE_DESC = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Tax_Date")>
    Public Property tax_date As Nullable(Of DateTime)
        Get
            Return _TAX_DATE
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _TAX_DATE = value
        End Set
    End Property
    <Display(Name:="Amount")>
    Public Property amount As Nullable(Of Decimal)
        Get
            Return _AMOUNT
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _AMOUNT = value
        End Set
    End Property
    <Display(Name:="Amount_Paid")>
    Public Property amount_paid As Nullable(Of Decimal)
        Get
            Return _AMOUNT_PAID
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _AMOUNT_PAID = value
        End Set
    End Property
    <Display(Name:="Percent_Paid")>
    Public Property percent_paid As Nullable(Of Decimal)
        Get
            Return _PERCENT_PAID
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _PERCENT_PAID = value
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
        Me._FISCAL_PERIOD = String.Empty
        Me._TAX_TYPE = String.Empty
        Me._TAX_TYPE_DESC = String.Empty
        Me._TAX_DATE = Nothing
        Me._AMOUNT = Nothing
        Me._AMOUNT_PAID = Nothing
        Me._PERCENT_PAID = Nothing
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
                If Not .IsDBNull(.GetOrdinal("FISCAL_PERIOD")) Then
                    Me._FISCAL_PERIOD = .GetValue(.GetOrdinal("FISCAL_PERIOD"))
                End If
                If Not .IsDBNull(.GetOrdinal("TAX_TYPE")) Then
                    Me._TAX_TYPE = .GetValue(.GetOrdinal("TAX_TYPE"))
                End If
                If Not .IsDBNull(.GetOrdinal("TAX_TYPE_DESC")) Then
                    Me._TAX_TYPE_DESC = .GetValue(.GetOrdinal("TAX_TYPE_DESC"))
                End If
                If Not .IsDBNull(.GetOrdinal("TAX_DATE")) Then
                    Me._TAX_DATE = Convert.ToDateTime(.GetValue(.GetOrdinal("TAX_DATE")))
                End If
                If Not .IsDBNull(.GetOrdinal("AMOUNT")) Then
                    Me._AMOUNT = Convert.ToInt32(.GetValue(.GetOrdinal("AMOUNT")))
                End If
                If Not .IsDBNull(.GetOrdinal("AMOUNT_PAID")) Then
                    Me._AMOUNT_PAID = Convert.ToInt32(.GetValue(.GetOrdinal("AMOUNT_PAID")))
                End If
                If Not .IsDBNull(.GetOrdinal("PERCENT_PAID")) Then
                    Me._PERCENT_PAID = Convert.ToInt32(.GetValue(.GetOrdinal("PERCENT_PAID")))
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
                If Not String.IsNullOrEmpty(Me._FISCAL_PERIOD.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(FISCAL_PERIOD) LIKE :P_FISCAL_PERIOD "
                    .Parameters.Add("P_FISCAL_PERIOD", NpgsqlDbType.Varchar).Value = "%" & Me._FISCAL_PERIOD.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._TAX_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(TAX_TYPE) LIKE :P_TAX_TYPE "
                    .Parameters.Add("P_TAX_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._TAX_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._TAX_TYPE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(TAX_TYPE_DESC) LIKE :P_TAX_TYPE_DESC "
                    .Parameters.Add("P_TAX_TYPE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._TAX_TYPE_DESC.ToUpper() & "%"
                End If
                If Me._TAX_DATE.HasValue Then
                    .CommandText = .CommandText & " AND TAX_DATE = :P_TAX_DATE "
                    .Parameters.Add("P_TAX_DATE", NpgsqlDbType.Timestamp).Value = Me._TAX_DATE.Value
                End If
                If Me._AMOUNT.HasValue Then
                    .CommandText = .CommandText & " AND AMOUNT = :P_AMOUNT "
                    .Parameters.Add("P_AMOUNT", NpgsqlDbType.Numeric).Value = Me._AMOUNT.Value
                End If
                If Me._AMOUNT_PAID.HasValue Then
                    .CommandText = .CommandText & " AND AMOUNT_PAID = :P_AMOUNT_PAID "
                    .Parameters.Add("P_AMOUNT_PAID", NpgsqlDbType.Numeric).Value = Me._AMOUNT_PAID.Value
                End If
                If Me._PERCENT_PAID.HasValue Then
                    .CommandText = .CommandText & " AND PERCENT_PAID = :P_PERCENT_PAID "
                    .Parameters.Add("P_PERCENT_PAID", NpgsqlDbType.Numeric).Value = Me._PERCENT_PAID.Value
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
    Public Function ObtenerListaDatos(ByRef totalrecords As Integer, ByVal psFiltro As String, ByVal pageSize As Integer, ByVal currentPage As Integer, ByVal psOrderBy As String) As List(Of cVW_EXT_CUR_TAXATION)
        Dim dbconexion As New NpgsqlConnection
        Dim resultados As List(Of cVW_EXT_CUR_TAXATION) = New List(Of cVW_EXT_CUR_TAXATION)

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
                If Not String.IsNullOrEmpty(Me._FISCAL_PERIOD.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(FISCAL_PERIOD) LIKE :P_FISCAL_PERIOD "
                    .Parameters.Add("P_FISCAL_PERIOD", NpgsqlDbType.Varchar).Value = "%" & Me._FISCAL_PERIOD.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._TAX_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(TAX_TYPE) LIKE :P_TAX_TYPE "
                    .Parameters.Add("P_TAX_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._TAX_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._TAX_TYPE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(TAX_TYPE_DESC) LIKE :P_TAX_TYPE_DESC "
                    .Parameters.Add("P_TAX_TYPE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._TAX_TYPE_DESC.ToUpper() & "%"
                End If
                If Me._TAX_DATE.HasValue Then
                    .CommandText = .CommandText & " AND TAX_DATE = :P_TAX_DATE "
                    .Parameters.Add("P_TAX_DATE", NpgsqlDbType.Timestamp).Value = Me._TAX_DATE.Value
                End If
                If Me._AMOUNT.HasValue Then
                    .CommandText = .CommandText & " AND AMOUNT = :P_AMOUNT "
                    .Parameters.Add("P_AMOUNT", NpgsqlDbType.Numeric).Value = Me._AMOUNT.Value
                End If
                If Me._AMOUNT_PAID.HasValue Then
                    .CommandText = .CommandText & " AND AMOUNT_PAID = :P_AMOUNT_PAID "
                    .Parameters.Add("P_AMOUNT_PAID", NpgsqlDbType.Numeric).Value = Me._AMOUNT_PAID.Value
                End If
                If Me._PERCENT_PAID.HasValue Then
                    .CommandText = .CommandText & " AND PERCENT_PAID = :P_PERCENT_PAID "
                    .Parameters.Add("P_PERCENT_PAID", NpgsqlDbType.Numeric).Value = Me._PERCENT_PAID.Value
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
                Dim objClase As New cVW_EXT_CUR_TAXATION With {
                                  ._LOCAL_ID = row("LOCAL_ID").ToString(),
                                  ._FISCAL_PERIOD = row("FISCAL_PERIOD").ToString(),
                                  ._TAX_TYPE = row("TAX_TYPE").ToString(),
                                  ._TAX_TYPE_DESC = row("TAX_TYPE_DESC").ToString(),
                                  ._TAX_DATE = If((TypeOf row("TAX_DATE") Is DBNull), DirectCast(Nothing, System.Nullable(Of Date)), Convert.ToDateTime(row("TAX_DATE"))),
                                  ._AMOUNT = If((TypeOf row("AMOUNT") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("AMOUNT"))),
                                  ._AMOUNT_PAID = If((TypeOf row("AMOUNT_PAID") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("AMOUNT_PAID"))),
                                  ._PERCENT_PAID = If((TypeOf row("PERCENT_PAID") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("PERCENT_PAID")))
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
