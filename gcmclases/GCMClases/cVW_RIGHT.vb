Public Class cVW_RIGHT
    Inherits cBase
    Implements IDisposable

#Region "Constantes Privadas"
    Private Const strConsulta = "SELECT OID, LOCAL_ID, RIGHT_TYPE, RIGHT_TYPE_DESC, SHARES, " &
                                "PARTY_LOCAL_ID, PARTY_NAME, PARTY_ROLE, PARTY_ROLE_DESC, " &
                                "PARTY_ADDRESS_ID, PARTY_STREET_NAME, PARTY_BUILDING_NAME, PARTY_BUILDING_NUMBER, " &
                                "PARTY_POSTAL_CODE, PARTY_POST_BOX, PARTY_MUN_CODE, PARTY_MUN_NAME, " &
                                "PARTY_SP_CODE, PARTY_SP_NAME, PARTY_COUNTRY_CODE, PARTY_COUNTRY_NAME " &
                                " FROM VW_RIGHT " &
                                "WHERE 1=1 "
#End Region

#Region "Variables Privadas"
    Protected _OID As String
    Protected _LOCAL_ID As String
    Protected _RIGHT_TYPE As String
    Protected _RIGHT_TYPE_DESC As String
    Protected _SHARES As Nullable(Of Decimal)
    Protected _PARTY_LOCAL_ID As String
    Protected _PARTY_NAME As String
    Protected _PARTY_ROLE As String
    Protected _PARTY_ROLE_DESC As String
    Protected _PARTY_ADDRESS_ID As String
    Protected _PARTY_STREET_NAME As String
    Protected _PARTY_BUILDING_NAME As String
    Protected _PARTY_BUILDING_NUMBER As String
    Protected _PARTY_POSTAL_CODE As String
    Protected _PARTY_POST_BOX As String
    Protected _PARTY_MUN_CODE As String
    Protected _PARTY_MUN_NAME As String
    Protected _PARTY_SP_CODE As String
    Protected _PARTY_SP_NAME As String
    Protected _PARTY_COUNTRY_CODE As String
    Protected _PARTY_COUNTRY_NAME As String
#End Region

#Region "Propiedades Publicas"
    Public ReadOnly Property Tabla() As String
        Get
            Return "vw_right"
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
    <Display(Name:="Right_Type")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property right_type As String
        Get
            Return _RIGHT_TYPE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _RIGHT_TYPE = value.Trim()
            Else
                _RIGHT_TYPE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Right_Type_Desc")>
    <StringLength(80, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property right_type_desc As String
        Get
            Return _RIGHT_TYPE_DESC
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _RIGHT_TYPE_DESC = value.Trim()
            Else
                _RIGHT_TYPE_DESC = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Shares")>
    Public Property shares As Nullable(Of Decimal)
        Get
            Return _SHARES
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _SHARES = value
        End Set
    End Property
    <Display(Name:="Party_Local_Id")>
    <StringLength(48, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_local_id As String
        Get
            Return _PARTY_LOCAL_ID
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_LOCAL_ID = value.Trim()
            Else
                _PARTY_LOCAL_ID = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_name As String
        Get
            Return _PARTY_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_NAME = value.Trim()
            Else
                _PARTY_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Role")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_role As String
        Get
            Return _PARTY_ROLE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_ROLE = value.Trim()
            Else
                _PARTY_ROLE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Role_Desc")>
    <StringLength(80, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_role_desc As String
        Get
            Return _PARTY_ROLE_DESC
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_ROLE_DESC = value.Trim()
            Else
                _PARTY_ROLE_DESC = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Address_Id")>
    <StringLength(32, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_address_id As String
        Get
            Return _PARTY_ADDRESS_ID
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_ADDRESS_ID = value.Trim()
            Else
                _PARTY_ADDRESS_ID = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Street_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_street_name As String
        Get
            Return _PARTY_STREET_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_STREET_NAME = value.Trim()
            Else
                _PARTY_STREET_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Building_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_building_name As String
        Get
            Return _PARTY_BUILDING_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_BUILDING_NAME = value.Trim()
            Else
                _PARTY_BUILDING_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Building_Number")>
    <StringLength(12, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_building_number As String
        Get
            Return _PARTY_BUILDING_NUMBER
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_BUILDING_NUMBER = value.Trim()
            Else
                _PARTY_BUILDING_NUMBER = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Postal_Code")>
    <StringLength(12, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_postal_code As String
        Get
            Return _PARTY_POSTAL_CODE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_POSTAL_CODE = value.Trim()
            Else
                _PARTY_POSTAL_CODE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Post_Box")>
    <StringLength(12, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_post_box As String
        Get
            Return _PARTY_POST_BOX
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_POST_BOX = value.Trim()
            Else
                _PARTY_POST_BOX = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Mun_Code")>
    <StringLength(20, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_mun_code As String
        Get
            Return _PARTY_MUN_CODE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_MUN_CODE = value.Trim()
            Else
                _PARTY_MUN_CODE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Mun_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_mun_name As String
        Get
            Return _PARTY_MUN_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_MUN_NAME = value.Trim()
            Else
                _PARTY_MUN_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Sp_Code")>
    <StringLength(20, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_sp_code As String
        Get
            Return _PARTY_SP_CODE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_SP_CODE = value.Trim()
            Else
                _PARTY_SP_CODE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Sp_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_sp_name As String
        Get
            Return _PARTY_SP_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_SP_NAME = value.Trim()
            Else
                _PARTY_SP_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Country_Code")>
    <StringLength(2, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_country_code As String
        Get
            Return _PARTY_COUNTRY_CODE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_COUNTRY_CODE = value.Trim()
            Else
                _PARTY_COUNTRY_CODE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Party_Country_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property party_country_name As String
        Get
            Return _PARTY_COUNTRY_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PARTY_COUNTRY_NAME = value.Trim()
            Else
                _PARTY_COUNTRY_NAME = String.Empty
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
        Me._OID = String.Empty
        Me._LOCAL_ID = String.Empty
        Me._RIGHT_TYPE = String.Empty
        Me._RIGHT_TYPE_DESC = String.Empty
        Me._SHARES = Nothing
        Me._PARTY_LOCAL_ID = String.Empty
        Me._PARTY_NAME = String.Empty
        Me._PARTY_ROLE = String.Empty
        Me._PARTY_ROLE_DESC = String.Empty
        Me._PARTY_ADDRESS_ID = String.Empty
        Me._PARTY_STREET_NAME = String.Empty
        Me._PARTY_BUILDING_NAME = String.Empty
        Me._PARTY_BUILDING_NUMBER = String.Empty
        Me._PARTY_POSTAL_CODE = String.Empty
        Me._PARTY_POST_BOX = String.Empty
        Me._PARTY_MUN_CODE = String.Empty
        Me._PARTY_MUN_NAME = String.Empty
        Me._PARTY_SP_CODE = String.Empty
        Me._PARTY_SP_NAME = String.Empty
        Me._PARTY_COUNTRY_CODE = String.Empty
        Me._PARTY_COUNTRY_NAME = String.Empty
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
                If Not .IsDBNull(.GetOrdinal("RIGHT_TYPE")) Then
                    Me._RIGHT_TYPE = .GetValue(.GetOrdinal("RIGHT_TYPE"))
                End If
                If Not .IsDBNull(.GetOrdinal("RIGHT_TYPE_DESC")) Then
                    Me._RIGHT_TYPE_DESC = .GetValue(.GetOrdinal("RIGHT_TYPE_DESC"))
                End If
                If Not .IsDBNull(.GetOrdinal("SHARES")) Then
                    Me._SHARES = Convert.ToInt32(.GetValue(.GetOrdinal("SHARES")))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_LOCAL_ID")) Then
                    Me._PARTY_LOCAL_ID = .GetValue(.GetOrdinal("PARTY_LOCAL_ID"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_NAME")) Then
                    Me._PARTY_NAME = .GetValue(.GetOrdinal("PARTY_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_ROLE")) Then
                    Me._PARTY_ROLE = .GetValue(.GetOrdinal("PARTY_ROLE"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_ROLE_DESC")) Then
                    Me._PARTY_ROLE_DESC = .GetValue(.GetOrdinal("PARTY_ROLE_DESC"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_ADDRESS_ID")) Then
                    Me._PARTY_ADDRESS_ID = .GetValue(.GetOrdinal("PARTY_ADDRESS_ID"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_STREET_NAME")) Then
                    Me._PARTY_STREET_NAME = .GetValue(.GetOrdinal("PARTY_STREET_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_BUILDING_NAME")) Then
                    Me._PARTY_BUILDING_NAME = .GetValue(.GetOrdinal("PARTY_BUILDING_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_BUILDING_NUMBER")) Then
                    Me._PARTY_BUILDING_NUMBER = .GetValue(.GetOrdinal("PARTY_BUILDING_NUMBER"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_POSTAL_CODE")) Then
                    Me._PARTY_POSTAL_CODE = .GetValue(.GetOrdinal("PARTY_POSTAL_CODE"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_POST_BOX")) Then
                    Me._PARTY_POST_BOX = .GetValue(.GetOrdinal("PARTY_POST_BOX"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_MUN_CODE")) Then
                    Me._PARTY_MUN_CODE = .GetValue(.GetOrdinal("PARTY_MUN_CODE"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_MUN_NAME")) Then
                    Me._PARTY_MUN_NAME = .GetValue(.GetOrdinal("PARTY_MUN_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_SP_CODE")) Then
                    Me._PARTY_SP_CODE = .GetValue(.GetOrdinal("PARTY_SP_CODE"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_SP_NAME")) Then
                    Me._PARTY_SP_NAME = .GetValue(.GetOrdinal("PARTY_SP_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_COUNTRY_CODE")) Then
                    Me._PARTY_COUNTRY_CODE = .GetValue(.GetOrdinal("PARTY_COUNTRY_CODE"))
                End If
                If Not .IsDBNull(.GetOrdinal("PARTY_COUNTRY_NAME")) Then
                    Me._PARTY_COUNTRY_NAME = .GetValue(.GetOrdinal("PARTY_COUNTRY_NAME"))
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
                If Not String.IsNullOrEmpty(Me._RIGHT_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(RIGHT_TYPE) LIKE :P_RIGHT_TYPE "
                    .Parameters.Add("P_RIGHT_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._RIGHT_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._RIGHT_TYPE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(RIGHT_TYPE_DESC) LIKE :P_RIGHT_TYPE_DESC "
                    .Parameters.Add("P_RIGHT_TYPE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._RIGHT_TYPE_DESC.ToUpper() & "%"
                End If
                If Me._SHARES.HasValue Then
                    .CommandText = .CommandText & " AND SHARES = :P_SHARES "
                    .Parameters.Add("P_SHARES", NpgsqlDbType.Numeric).Value = Me._SHARES.Value
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_LOCAL_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_LOCAL_ID) LIKE :P_PARTY_LOCAL_ID "
                    .Parameters.Add("P_PARTY_LOCAL_ID", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_LOCAL_ID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_NAME) LIKE :P_PARTY_NAME "
                    .Parameters.Add("P_PARTY_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_ROLE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_ROLE) LIKE :P_PARTY_ROLE "
                    .Parameters.Add("P_PARTY_ROLE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_ROLE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_ROLE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_ROLE_DESC) LIKE :P_PARTY_ROLE_DESC "
                    .Parameters.Add("P_PARTY_ROLE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_ROLE_DESC.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_ADDRESS_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_ADDRESS_ID) LIKE :P_PARTY_ADDRESS_ID "
                    .Parameters.Add("P_PARTY_ADDRESS_ID", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_ADDRESS_ID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_STREET_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_STREET_NAME) LIKE :P_PARTY_STREET_NAME "
                    .Parameters.Add("P_PARTY_STREET_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_STREET_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_BUILDING_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_BUILDING_NAME) LIKE :P_PARTY_BUILDING_NAME "
                    .Parameters.Add("P_PARTY_BUILDING_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_BUILDING_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_BUILDING_NUMBER.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_BUILDING_NUMBER) LIKE :P_PARTY_BUILDING_NUMBER "
                    .Parameters.Add("P_PARTY_BUILDING_NUMBER", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_BUILDING_NUMBER.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_POSTAL_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_POSTAL_CODE) LIKE :P_PARTY_POSTAL_CODE "
                    .Parameters.Add("P_PARTY_POSTAL_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_POSTAL_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_POST_BOX.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_POST_BOX) LIKE :P_PARTY_POST_BOX "
                    .Parameters.Add("P_PARTY_POST_BOX", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_POST_BOX.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_MUN_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_MUN_CODE) LIKE :P_PARTY_MUN_CODE "
                    .Parameters.Add("P_PARTY_MUN_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_MUN_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_MUN_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_MUN_NAME) LIKE :P_PARTY_MUN_NAME "
                    .Parameters.Add("P_PARTY_MUN_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_MUN_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_SP_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_SP_CODE) LIKE :P_PARTY_SP_CODE "
                    .Parameters.Add("P_PARTY_SP_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_SP_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_SP_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_SP_NAME) LIKE :P_PARTY_SP_NAME "
                    .Parameters.Add("P_PARTY_SP_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_SP_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_COUNTRY_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_COUNTRY_CODE) LIKE :P_PARTY_COUNTRY_CODE "
                    .Parameters.Add("P_PARTY_COUNTRY_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_COUNTRY_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_COUNTRY_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_COUNTRY_NAME) LIKE :P_PARTY_COUNTRY_NAME "
                    .Parameters.Add("P_PARTY_COUNTRY_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_COUNTRY_NAME.ToUpper() & "%"
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
    Public Function ObtenerListaDatos(ByRef totalrecords As Integer, ByVal psFiltro As String, ByVal pageSize As Integer, ByVal currentPage As Integer, ByVal psOrderBy As String) As List(Of cVW_RIGHT)
        Dim dbconexion As New NpgsqlConnection
        Dim resultados As List(Of cVW_RIGHT) = New List(Of cVW_RIGHT)

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
                If Not String.IsNullOrEmpty(Me._RIGHT_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(RIGHT_TYPE) LIKE :P_RIGHT_TYPE "
                    .Parameters.Add("P_RIGHT_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._RIGHT_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._RIGHT_TYPE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(RIGHT_TYPE_DESC) LIKE :P_RIGHT_TYPE_DESC "
                    .Parameters.Add("P_RIGHT_TYPE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._RIGHT_TYPE_DESC.ToUpper() & "%"
                End If
                If Me._SHARES.HasValue Then
                    .CommandText = .CommandText & " AND SHARES = :P_SHARES "
                    .Parameters.Add("P_SHARES", NpgsqlDbType.Numeric).Value = Me._SHARES.Value
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_LOCAL_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_LOCAL_ID) LIKE :P_PARTY_LOCAL_ID "
                    .Parameters.Add("P_PARTY_LOCAL_ID", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_LOCAL_ID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_NAME) LIKE :P_PARTY_NAME "
                    .Parameters.Add("P_PARTY_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_ROLE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_ROLE) LIKE :P_PARTY_ROLE "
                    .Parameters.Add("P_PARTY_ROLE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_ROLE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_ROLE_DESC.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_ROLE_DESC) LIKE :P_PARTY_ROLE_DESC "
                    .Parameters.Add("P_PARTY_ROLE_DESC", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_ROLE_DESC.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_ADDRESS_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_ADDRESS_ID) LIKE :P_PARTY_ADDRESS_ID "
                    .Parameters.Add("P_PARTY_ADDRESS_ID", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_ADDRESS_ID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_STREET_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_STREET_NAME) LIKE :P_PARTY_STREET_NAME "
                    .Parameters.Add("P_PARTY_STREET_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_STREET_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_BUILDING_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_BUILDING_NAME) LIKE :P_PARTY_BUILDING_NAME "
                    .Parameters.Add("P_PARTY_BUILDING_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_BUILDING_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_BUILDING_NUMBER.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_BUILDING_NUMBER) LIKE :P_PARTY_BUILDING_NUMBER "
                    .Parameters.Add("P_PARTY_BUILDING_NUMBER", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_BUILDING_NUMBER.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_POSTAL_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_POSTAL_CODE) LIKE :P_PARTY_POSTAL_CODE "
                    .Parameters.Add("P_PARTY_POSTAL_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_POSTAL_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_POST_BOX.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_POST_BOX) LIKE :P_PARTY_POST_BOX "
                    .Parameters.Add("P_PARTY_POST_BOX", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_POST_BOX.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_MUN_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_MUN_CODE) LIKE :P_PARTY_MUN_CODE "
                    .Parameters.Add("P_PARTY_MUN_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_MUN_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_MUN_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_MUN_NAME) LIKE :P_PARTY_MUN_NAME "
                    .Parameters.Add("P_PARTY_MUN_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_MUN_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_SP_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_SP_CODE) LIKE :P_PARTY_SP_CODE "
                    .Parameters.Add("P_PARTY_SP_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_SP_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_SP_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_SP_NAME) LIKE :P_PARTY_SP_NAME "
                    .Parameters.Add("P_PARTY_SP_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_SP_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_COUNTRY_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_COUNTRY_CODE) LIKE :P_PARTY_COUNTRY_CODE "
                    .Parameters.Add("P_PARTY_COUNTRY_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_COUNTRY_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PARTY_COUNTRY_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PARTY_COUNTRY_NAME) LIKE :P_PARTY_COUNTRY_NAME "
                    .Parameters.Add("P_PARTY_COUNTRY_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PARTY_COUNTRY_NAME.ToUpper() & "%"
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
                Dim objClase As New cVW_RIGHT With {
                                  ._OID = row("OID").ToString(),
                                  ._LOCAL_ID = row("LOCAL_ID").ToString(),
                                  ._RIGHT_TYPE = row("RIGHT_TYPE").ToString(),
                                  ._RIGHT_TYPE_DESC = row("RIGHT_TYPE_DESC").ToString(),
                                  ._SHARES = If((TypeOf row("SHARES") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("SHARES"))),
                                  ._PARTY_LOCAL_ID = row("PARTY_LOCAL_ID").ToString(),
                                  ._PARTY_NAME = row("PARTY_NAME").ToString(),
                                  ._PARTY_ROLE = row("PARTY_ROLE").ToString(),
                                  ._PARTY_ROLE_DESC = row("PARTY_ROLE_DESC").ToString(),
                                  ._PARTY_ADDRESS_ID = row("PARTY_ADDRESS_ID").ToString(),
                                  ._PARTY_STREET_NAME = row("PARTY_STREET_NAME").ToString(),
                                  ._PARTY_BUILDING_NAME = row("PARTY_BUILDING_NAME").ToString(),
                                  ._PARTY_BUILDING_NUMBER = row("PARTY_BUILDING_NUMBER").ToString(),
                                  ._PARTY_POSTAL_CODE = row("PARTY_POSTAL_CODE").ToString(),
                                  ._PARTY_POST_BOX = row("PARTY_POST_BOX").ToString(),
                                  ._PARTY_MUN_CODE = row("PARTY_MUN_CODE").ToString(),
                                  ._PARTY_MUN_NAME = row("PARTY_MUN_NAME").ToString(),
                                  ._PARTY_SP_CODE = row("PARTY_SP_CODE").ToString(),
                                  ._PARTY_SP_NAME = row("PARTY_SP_NAME").ToString(),
                                  ._PARTY_COUNTRY_CODE = row("PARTY_COUNTRY_CODE").ToString(),
                                  ._PARTY_COUNTRY_NAME = row("PARTY_COUNTRY_NAME").ToString()
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
