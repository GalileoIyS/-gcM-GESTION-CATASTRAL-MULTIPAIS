Public Class cVW_BA_UNIT
    Inherits cBase
    Implements IDisposable

#Region "Constantes Privadas"
    Private Const strConsulta = "SELECT OID, LOCAL_ID, BA_UNIT_TYPE, BA_UNIT_TYPE_DESCRIP, PLACE_NAME, " &
                                "SUNIT_LOCAL_ID, AREA, AREA_TYPE, AREA_TYPE_DESCRIP, " &
                                "DIMENSION_TYPE, DIMENSION_TYPE_DESCRIP, SPATIAL_UNIT_DESCRIP, LAND_USE, " &
                                "LAND_USE_DESCRIP, ADM_USE, ADM_USE_DESCRIP, VALUE, " &
                                "VALUE_DATE, VALUE_TYPE, VALUE_TYPE_DESC, ADDRESS_ID, " &
                                "STREET_NAME, BUILDING_NAME, BUILDING_NUMBER, POSTAL_CODE, " &
                                "POST_BOX, MUN_CODE, MUN_NAME, SP_CODE, " &
                                "SP_NAME, COUNTRY_CODE, COUNTRY_NAME FROM VW_BA_UNIT " &
                                "WHERE 1=1 "
#End Region

#Region "Variables Privadas"
    Protected _OID As String
    Protected _LOCAL_ID As String
    Protected _BA_UNIT_TYPE As String
    Protected _BA_UNIT_TYPE_DESCRIP As String
    Protected _PLACE_NAME As String
    Protected _SUNIT_LOCAL_ID As String
    Protected _AREA As Nullable(Of Decimal)
    Protected _AREA_TYPE As String
    Protected _AREA_TYPE_DESCRIP As String
    Protected _DIMENSION_TYPE As String
    Protected _DIMENSION_TYPE_DESCRIP As String
    Protected _SPATIAL_UNIT_DESCRIP As String
    Protected _LAND_USE As String
    Protected _LAND_USE_DESCRIP As String
    Protected _ADM_USE As String
    Protected _ADM_USE_DESCRIP As String
    Protected _VALUE As Nullable(Of Decimal)
    Protected _VALUE_DATE As Nullable(Of DateTime)
    Protected _VALUE_TYPE As String
    Protected _VALUE_TYPE_DESC As String
    Protected _ADDRESS_ID As String
    Protected _STREET_NAME As String
    Protected _BUILDING_NAME As String
    Protected _BUILDING_NUMBER As String
    Protected _POSTAL_CODE As String
    Protected _POST_BOX As String
    Protected _MUN_CODE As String
    Protected _MUN_NAME As String
    Protected _SP_CODE As String
    Protected _SP_NAME As String
    Protected _COUNTRY_CODE As String
    Protected _COUNTRY_NAME As String
#End Region

#Region "Propiedades Publicas"
    Public ReadOnly Property Tabla() As String
        Get
            Return "vw_ba_unit"
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
    <Display(Name:="Ba_Unit_Type")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property ba_unit_type As String
        Get
            Return _BA_UNIT_TYPE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _BA_UNIT_TYPE = value.Trim()
            Else
                _BA_UNIT_TYPE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Ba_Unit_Type_Descrip")>
    <StringLength(80, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property ba_unit_type_descrip As String
        Get
            Return _BA_UNIT_TYPE_DESCRIP
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _BA_UNIT_TYPE_DESCRIP = value.Trim()
            Else
                _BA_UNIT_TYPE_DESCRIP = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Place_Name")>
    <StringLength(80, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property place_name As String
        Get
            Return _PLACE_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _PLACE_NAME = value.Trim()
            Else
                _PLACE_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Sunit_Local_Id")>
    <StringLength(48, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property sunit_local_id As String
        Get
            Return _SUNIT_LOCAL_ID
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _SUNIT_LOCAL_ID = value.Trim()
            Else
                _SUNIT_LOCAL_ID = String.Empty
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
    <Display(Name:="Area_Type")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property area_type As String
        Get
            Return _AREA_TYPE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _AREA_TYPE = value.Trim()
            Else
                _AREA_TYPE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Area_Type_Descrip")>
    <StringLength(80, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property area_type_descrip As String
        Get
            Return _AREA_TYPE_DESCRIP
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _AREA_TYPE_DESCRIP = value.Trim()
            Else
                _AREA_TYPE_DESCRIP = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Dimension_Type")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property dimension_type As String
        Get
            Return _DIMENSION_TYPE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _DIMENSION_TYPE = value.Trim()
            Else
                _DIMENSION_TYPE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Dimension_Type_Descrip")>
    <StringLength(80, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property dimension_type_descrip As String
        Get
            Return _DIMENSION_TYPE_DESCRIP
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _DIMENSION_TYPE_DESCRIP = value.Trim()
            Else
                _DIMENSION_TYPE_DESCRIP = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Spatial_Unit_Descrip")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property spatial_unit_descrip As String
        Get
            Return _SPATIAL_UNIT_DESCRIP
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _SPATIAL_UNIT_DESCRIP = value.Trim()
            Else
                _SPATIAL_UNIT_DESCRIP = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Land_Use")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property land_use As String
        Get
            Return _LAND_USE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _LAND_USE = value.Trim()
            Else
                _LAND_USE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Land_Use_Descrip")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property land_use_descrip As String
        Get
            Return _LAND_USE_DESCRIP
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _LAND_USE_DESCRIP = value.Trim()
            Else
                _LAND_USE_DESCRIP = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Adm_Use")>
    <StringLength(3, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property adm_use As String
        Get
            Return _ADM_USE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _ADM_USE = value.Trim()
            Else
                _ADM_USE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Adm_Use_Descrip")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property adm_use_descrip As String
        Get
            Return _ADM_USE_DESCRIP
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _ADM_USE_DESCRIP = value.Trim()
            Else
                _ADM_USE_DESCRIP = String.Empty
            End If
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
    <Display(Name:="Address_Id")>
    <StringLength(32, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property address_id As String
        Get
            Return _ADDRESS_ID
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _ADDRESS_ID = value.Trim()
            Else
                _ADDRESS_ID = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Street_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property street_name As String
        Get
            Return _STREET_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _STREET_NAME = value.Trim()
            Else
                _STREET_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Building_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property building_name As String
        Get
            Return _BUILDING_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _BUILDING_NAME = value.Trim()
            Else
                _BUILDING_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Building_Number")>
    <StringLength(12, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property building_number As String
        Get
            Return _BUILDING_NUMBER
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _BUILDING_NUMBER = value.Trim()
            Else
                _BUILDING_NUMBER = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Postal_Code")>
    <StringLength(12, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property postal_code As String
        Get
            Return _POSTAL_CODE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _POSTAL_CODE = value.Trim()
            Else
                _POSTAL_CODE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Post_Box")>
    <StringLength(12, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property post_box As String
        Get
            Return _POST_BOX
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _POST_BOX = value.Trim()
            Else
                _POST_BOX = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Mun_Code")>
    <StringLength(20, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property mun_code As String
        Get
            Return _MUN_CODE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _MUN_CODE = value.Trim()
            Else
                _MUN_CODE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Mun_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property mun_name As String
        Get
            Return _MUN_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _MUN_NAME = value.Trim()
            Else
                _MUN_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Sp_Code")>
    <StringLength(20, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property sp_code As String
        Get
            Return _SP_CODE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _SP_CODE = value.Trim()
            Else
                _SP_CODE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Sp_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property sp_name As String
        Get
            Return _SP_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _SP_NAME = value.Trim()
            Else
                _SP_NAME = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Country_Code")>
    <StringLength(2, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property country_code As String
        Get
            Return _COUNTRY_CODE
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _COUNTRY_CODE = value.Trim()
            Else
                _COUNTRY_CODE = String.Empty
            End If
        End Set
    End Property
    <Display(Name:="Country_Name")>
    <StringLength(255, ErrorMessage:="El {0} debe tener entre {2} y {1} caracteres.", MinimumLength:=0)>
    Public Property country_name As String
        Get
            Return _COUNTRY_NAME
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _COUNTRY_NAME = value.Trim()
            Else
                _COUNTRY_NAME = String.Empty
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
        Me._BA_UNIT_TYPE = String.Empty
        Me._BA_UNIT_TYPE_DESCRIP = String.Empty
        Me._PLACE_NAME = String.Empty
        Me._SUNIT_LOCAL_ID = String.Empty
        Me._AREA = Nothing
        Me._AREA_TYPE = String.Empty
        Me._AREA_TYPE_DESCRIP = String.Empty
        Me._DIMENSION_TYPE = String.Empty
        Me._DIMENSION_TYPE_DESCRIP = String.Empty
        Me._SPATIAL_UNIT_DESCRIP = String.Empty
        Me._LAND_USE = String.Empty
        Me._LAND_USE_DESCRIP = String.Empty
        Me._ADM_USE = String.Empty
        Me._ADM_USE_DESCRIP = String.Empty
        Me._VALUE = Nothing
        Me._VALUE_DATE = Nothing
        Me._VALUE_TYPE = String.Empty
        Me._VALUE_TYPE_DESC = String.Empty
        Me._ADDRESS_ID = String.Empty
        Me._STREET_NAME = String.Empty
        Me._BUILDING_NAME = String.Empty
        Me._BUILDING_NUMBER = String.Empty
        Me._POSTAL_CODE = String.Empty
        Me._POST_BOX = String.Empty
        Me._MUN_CODE = String.Empty
        Me._MUN_NAME = String.Empty
        Me._SP_CODE = String.Empty
        Me._SP_NAME = String.Empty
        Me._COUNTRY_CODE = String.Empty
        Me._COUNTRY_NAME = String.Empty
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
                If Not .IsDBNull(.GetOrdinal("BA_UNIT_TYPE")) Then
                    Me._BA_UNIT_TYPE = .GetValue(.GetOrdinal("BA_UNIT_TYPE"))
                End If
                If Not .IsDBNull(.GetOrdinal("BA_UNIT_TYPE_DESCRIP")) Then
                    Me._BA_UNIT_TYPE_DESCRIP = .GetValue(.GetOrdinal("BA_UNIT_TYPE_DESCRIP"))
                End If
                If Not .IsDBNull(.GetOrdinal("PLACE_NAME")) Then
                    Me._PLACE_NAME = .GetValue(.GetOrdinal("PLACE_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("SUNIT_LOCAL_ID")) Then
                    Me._SUNIT_LOCAL_ID = .GetValue(.GetOrdinal("SUNIT_LOCAL_ID"))
                End If
                If Not .IsDBNull(.GetOrdinal("AREA")) Then
                    Me._AREA = Convert.ToInt32(.GetValue(.GetOrdinal("AREA")))
                End If
                If Not .IsDBNull(.GetOrdinal("AREA_TYPE")) Then
                    Me._AREA_TYPE = .GetValue(.GetOrdinal("AREA_TYPE"))
                End If
                If Not .IsDBNull(.GetOrdinal("AREA_TYPE_DESCRIP")) Then
                    Me._AREA_TYPE_DESCRIP = .GetValue(.GetOrdinal("AREA_TYPE_DESCRIP"))
                End If
                If Not .IsDBNull(.GetOrdinal("DIMENSION_TYPE")) Then
                    Me._DIMENSION_TYPE = .GetValue(.GetOrdinal("DIMENSION_TYPE"))
                End If
                If Not .IsDBNull(.GetOrdinal("DIMENSION_TYPE_DESCRIP")) Then
                    Me._DIMENSION_TYPE_DESCRIP = .GetValue(.GetOrdinal("DIMENSION_TYPE_DESCRIP"))
                End If
                If Not .IsDBNull(.GetOrdinal("SPATIAL_UNIT_DESCRIP")) Then
                    Me._SPATIAL_UNIT_DESCRIP = .GetValue(.GetOrdinal("SPATIAL_UNIT_DESCRIP"))
                End If
                If Not .IsDBNull(.GetOrdinal("LAND_USE")) Then
                    Me._LAND_USE = .GetValue(.GetOrdinal("LAND_USE"))
                End If
                If Not .IsDBNull(.GetOrdinal("LAND_USE_DESCRIP")) Then
                    Me._LAND_USE_DESCRIP = .GetValue(.GetOrdinal("LAND_USE_DESCRIP"))
                End If
                If Not .IsDBNull(.GetOrdinal("ADM_USE")) Then
                    Me._ADM_USE = .GetValue(.GetOrdinal("ADM_USE"))
                End If
                If Not .IsDBNull(.GetOrdinal("ADM_USE_DESCRIP")) Then
                    Me._ADM_USE_DESCRIP = .GetValue(.GetOrdinal("ADM_USE_DESCRIP"))
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
                If Not .IsDBNull(.GetOrdinal("ADDRESS_ID")) Then
                    Me._ADDRESS_ID = .GetValue(.GetOrdinal("ADDRESS_ID"))
                End If
                If Not .IsDBNull(.GetOrdinal("STREET_NAME")) Then
                    Me._STREET_NAME = .GetValue(.GetOrdinal("STREET_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("BUILDING_NAME")) Then
                    Me._BUILDING_NAME = .GetValue(.GetOrdinal("BUILDING_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("BUILDING_NUMBER")) Then
                    Me._BUILDING_NUMBER = .GetValue(.GetOrdinal("BUILDING_NUMBER"))
                End If
                If Not .IsDBNull(.GetOrdinal("POSTAL_CODE")) Then
                    Me._POSTAL_CODE = .GetValue(.GetOrdinal("POSTAL_CODE"))
                End If
                If Not .IsDBNull(.GetOrdinal("POST_BOX")) Then
                    Me._POST_BOX = .GetValue(.GetOrdinal("POST_BOX"))
                End If
                If Not .IsDBNull(.GetOrdinal("MUN_CODE")) Then
                    Me._MUN_CODE = .GetValue(.GetOrdinal("MUN_CODE"))
                End If
                If Not .IsDBNull(.GetOrdinal("MUN_NAME")) Then
                    Me._MUN_NAME = .GetValue(.GetOrdinal("MUN_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("SP_CODE")) Then
                    Me._SP_CODE = .GetValue(.GetOrdinal("SP_CODE"))
                End If
                If Not .IsDBNull(.GetOrdinal("SP_NAME")) Then
                    Me._SP_NAME = .GetValue(.GetOrdinal("SP_NAME"))
                End If
                If Not .IsDBNull(.GetOrdinal("COUNTRY_CODE")) Then
                    Me._COUNTRY_CODE = .GetValue(.GetOrdinal("COUNTRY_CODE"))
                End If
                If Not .IsDBNull(.GetOrdinal("COUNTRY_NAME")) Then
                    Me._COUNTRY_NAME = .GetValue(.GetOrdinal("COUNTRY_NAME"))
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
                If Not String.IsNullOrEmpty(Me._BA_UNIT_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(BA_UNIT_TYPE) LIKE :P_BA_UNIT_TYPE "
                    .Parameters.Add("P_BA_UNIT_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._BA_UNIT_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._BA_UNIT_TYPE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(BA_UNIT_TYPE_DESCRIP) LIKE :P_BA_UNIT_TYPE_DESCRIP "
                    .Parameters.Add("P_BA_UNIT_TYPE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._BA_UNIT_TYPE_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PLACE_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PLACE_NAME) LIKE :P_PLACE_NAME "
                    .Parameters.Add("P_PLACE_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PLACE_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._SUNIT_LOCAL_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(SUNIT_LOCAL_ID) LIKE :P_SUNIT_LOCAL_ID "
                    .Parameters.Add("P_SUNIT_LOCAL_ID", NpgsqlDbType.Varchar).Value = "%" & Me._SUNIT_LOCAL_ID.ToUpper() & "%"
                End If
                If Me._AREA.HasValue Then
                    .CommandText = .CommandText & " AND AREA = :P_AREA "
                    .Parameters.Add("P_AREA", NpgsqlDbType.Numeric).Value = Me._AREA.Value
                End If
                If Not String.IsNullOrEmpty(Me._AREA_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(AREA_TYPE) LIKE :P_AREA_TYPE "
                    .Parameters.Add("P_AREA_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._AREA_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._AREA_TYPE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(AREA_TYPE_DESCRIP) LIKE :P_AREA_TYPE_DESCRIP "
                    .Parameters.Add("P_AREA_TYPE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._AREA_TYPE_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._DIMENSION_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(DIMENSION_TYPE) LIKE :P_DIMENSION_TYPE "
                    .Parameters.Add("P_DIMENSION_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._DIMENSION_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._DIMENSION_TYPE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(DIMENSION_TYPE_DESCRIP) LIKE :P_DIMENSION_TYPE_DESCRIP "
                    .Parameters.Add("P_DIMENSION_TYPE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._DIMENSION_TYPE_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._SPATIAL_UNIT_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(SPATIAL_UNIT_DESCRIP) LIKE :P_SPATIAL_UNIT_DESCRIP "
                    .Parameters.Add("P_SPATIAL_UNIT_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._SPATIAL_UNIT_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._LAND_USE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(LAND_USE) LIKE :P_LAND_USE "
                    .Parameters.Add("P_LAND_USE", NpgsqlDbType.Varchar).Value = "%" & Me._LAND_USE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._LAND_USE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(LAND_USE_DESCRIP) LIKE :P_LAND_USE_DESCRIP "
                    .Parameters.Add("P_LAND_USE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._LAND_USE_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._ADM_USE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(ADM_USE) LIKE :P_ADM_USE "
                    .Parameters.Add("P_ADM_USE", NpgsqlDbType.Varchar).Value = "%" & Me._ADM_USE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._ADM_USE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(ADM_USE_DESCRIP) LIKE :P_ADM_USE_DESCRIP "
                    .Parameters.Add("P_ADM_USE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._ADM_USE_DESCRIP.ToUpper() & "%"
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
                If Not String.IsNullOrEmpty(Me._ADDRESS_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(ADDRESS_ID) LIKE :P_ADDRESS_ID "
                    .Parameters.Add("P_ADDRESS_ID", NpgsqlDbType.Varchar).Value = "%" & Me._ADDRESS_ID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._STREET_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(STREET_NAME) LIKE :P_STREET_NAME "
                    .Parameters.Add("P_STREET_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._STREET_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._BUILDING_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(BUILDING_NAME) LIKE :P_BUILDING_NAME "
                    .Parameters.Add("P_BUILDING_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._BUILDING_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._BUILDING_NUMBER.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(BUILDING_NUMBER) LIKE :P_BUILDING_NUMBER "
                    .Parameters.Add("P_BUILDING_NUMBER", NpgsqlDbType.Varchar).Value = "%" & Me._BUILDING_NUMBER.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._POSTAL_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(POSTAL_CODE) LIKE :P_POSTAL_CODE "
                    .Parameters.Add("P_POSTAL_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._POSTAL_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._POST_BOX.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(POST_BOX) LIKE :P_POST_BOX "
                    .Parameters.Add("P_POST_BOX", NpgsqlDbType.Varchar).Value = "%" & Me._POST_BOX.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._MUN_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(MUN_CODE) LIKE :P_MUN_CODE "
                    .Parameters.Add("P_MUN_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._MUN_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._MUN_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(MUN_NAME) LIKE :P_MUN_NAME "
                    .Parameters.Add("P_MUN_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._MUN_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._SP_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(SP_CODE) LIKE :P_SP_CODE "
                    .Parameters.Add("P_SP_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._SP_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._SP_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(SP_NAME) LIKE :P_SP_NAME "
                    .Parameters.Add("P_SP_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._SP_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._COUNTRY_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(COUNTRY_CODE) LIKE :P_COUNTRY_CODE "
                    .Parameters.Add("P_COUNTRY_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._COUNTRY_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._COUNTRY_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(COUNTRY_NAME) LIKE :P_COUNTRY_NAME "
                    .Parameters.Add("P_COUNTRY_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._COUNTRY_NAME.ToUpper() & "%"
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
    Public Function ObtenerListaDatos(ByRef totalrecords As Integer, ByVal psFiltro As String, ByVal pageSize As Integer, ByVal currentPage As Integer, ByVal psOrderBy As String) As List(Of cVW_BA_UNIT)
        Dim dbconexion As New NpgsqlConnection
        Dim resultados As List(Of cVW_BA_UNIT) = New List(Of cVW_BA_UNIT)

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
                If Not String.IsNullOrEmpty(Me._BA_UNIT_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(BA_UNIT_TYPE) LIKE :P_BA_UNIT_TYPE "
                    .Parameters.Add("P_BA_UNIT_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._BA_UNIT_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._BA_UNIT_TYPE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(BA_UNIT_TYPE_DESCRIP) LIKE :P_BA_UNIT_TYPE_DESCRIP "
                    .Parameters.Add("P_BA_UNIT_TYPE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._BA_UNIT_TYPE_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._PLACE_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(PLACE_NAME) LIKE :P_PLACE_NAME "
                    .Parameters.Add("P_PLACE_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._PLACE_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._SUNIT_LOCAL_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(SUNIT_LOCAL_ID) LIKE :P_SUNIT_LOCAL_ID "
                    .Parameters.Add("P_SUNIT_LOCAL_ID", NpgsqlDbType.Varchar).Value = "%" & Me._SUNIT_LOCAL_ID.ToUpper() & "%"
                End If
                If Me._AREA.HasValue Then
                    .CommandText = .CommandText & " AND AREA = :P_AREA "
                    .Parameters.Add("P_AREA", NpgsqlDbType.Numeric).Value = Me._AREA.Value
                End If
                If Not String.IsNullOrEmpty(Me._AREA_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(AREA_TYPE) LIKE :P_AREA_TYPE "
                    .Parameters.Add("P_AREA_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._AREA_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._AREA_TYPE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(AREA_TYPE_DESCRIP) LIKE :P_AREA_TYPE_DESCRIP "
                    .Parameters.Add("P_AREA_TYPE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._AREA_TYPE_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._DIMENSION_TYPE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(DIMENSION_TYPE) LIKE :P_DIMENSION_TYPE "
                    .Parameters.Add("P_DIMENSION_TYPE", NpgsqlDbType.Varchar).Value = "%" & Me._DIMENSION_TYPE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._DIMENSION_TYPE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(DIMENSION_TYPE_DESCRIP) LIKE :P_DIMENSION_TYPE_DESCRIP "
                    .Parameters.Add("P_DIMENSION_TYPE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._DIMENSION_TYPE_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._SPATIAL_UNIT_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(SPATIAL_UNIT_DESCRIP) LIKE :P_SPATIAL_UNIT_DESCRIP "
                    .Parameters.Add("P_SPATIAL_UNIT_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._SPATIAL_UNIT_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._LAND_USE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(LAND_USE) LIKE :P_LAND_USE "
                    .Parameters.Add("P_LAND_USE", NpgsqlDbType.Varchar).Value = "%" & Me._LAND_USE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._LAND_USE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(LAND_USE_DESCRIP) LIKE :P_LAND_USE_DESCRIP "
                    .Parameters.Add("P_LAND_USE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._LAND_USE_DESCRIP.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._ADM_USE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(ADM_USE) LIKE :P_ADM_USE "
                    .Parameters.Add("P_ADM_USE", NpgsqlDbType.Varchar).Value = "%" & Me._ADM_USE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._ADM_USE_DESCRIP.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(ADM_USE_DESCRIP) LIKE :P_ADM_USE_DESCRIP "
                    .Parameters.Add("P_ADM_USE_DESCRIP", NpgsqlDbType.Varchar).Value = "%" & Me._ADM_USE_DESCRIP.ToUpper() & "%"
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
                If Not String.IsNullOrEmpty(Me._ADDRESS_ID.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(ADDRESS_ID) LIKE :P_ADDRESS_ID "
                    .Parameters.Add("P_ADDRESS_ID", NpgsqlDbType.Varchar).Value = "%" & Me._ADDRESS_ID.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._STREET_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(STREET_NAME) LIKE :P_STREET_NAME "
                    .Parameters.Add("P_STREET_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._STREET_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._BUILDING_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(BUILDING_NAME) LIKE :P_BUILDING_NAME "
                    .Parameters.Add("P_BUILDING_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._BUILDING_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._BUILDING_NUMBER.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(BUILDING_NUMBER) LIKE :P_BUILDING_NUMBER "
                    .Parameters.Add("P_BUILDING_NUMBER", NpgsqlDbType.Varchar).Value = "%" & Me._BUILDING_NUMBER.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._POSTAL_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(POSTAL_CODE) LIKE :P_POSTAL_CODE "
                    .Parameters.Add("P_POSTAL_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._POSTAL_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._POST_BOX.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(POST_BOX) LIKE :P_POST_BOX "
                    .Parameters.Add("P_POST_BOX", NpgsqlDbType.Varchar).Value = "%" & Me._POST_BOX.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._MUN_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(MUN_CODE) LIKE :P_MUN_CODE "
                    .Parameters.Add("P_MUN_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._MUN_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._MUN_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(MUN_NAME) LIKE :P_MUN_NAME "
                    .Parameters.Add("P_MUN_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._MUN_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._SP_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(SP_CODE) LIKE :P_SP_CODE "
                    .Parameters.Add("P_SP_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._SP_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._SP_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(SP_NAME) LIKE :P_SP_NAME "
                    .Parameters.Add("P_SP_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._SP_NAME.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._COUNTRY_CODE.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(COUNTRY_CODE) LIKE :P_COUNTRY_CODE "
                    .Parameters.Add("P_COUNTRY_CODE", NpgsqlDbType.Varchar).Value = "%" & Me._COUNTRY_CODE.ToUpper() & "%"
                End If
                If Not String.IsNullOrEmpty(Me._COUNTRY_NAME.Trim()) Then
                    .CommandText = .CommandText & " AND UPPER(COUNTRY_NAME) LIKE :P_COUNTRY_NAME "
                    .Parameters.Add("P_COUNTRY_NAME", NpgsqlDbType.Varchar).Value = "%" & Me._COUNTRY_NAME.ToUpper() & "%"
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
                Dim objClase As New cVW_BA_UNIT With {
                                  ._OID = row("OID").ToString(),
                                  ._LOCAL_ID = row("LOCAL_ID").ToString(),
                                  ._BA_UNIT_TYPE = row("BA_UNIT_TYPE").ToString(),
                                  ._BA_UNIT_TYPE_DESCRIP = row("BA_UNIT_TYPE_DESCRIP").ToString(),
                                  ._PLACE_NAME = row("PLACE_NAME").ToString(),
                                  ._SUNIT_LOCAL_ID = row("SUNIT_LOCAL_ID").ToString(),
                                  ._AREA = If((TypeOf row("AREA") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("AREA"))),
                                  ._AREA_TYPE = row("AREA_TYPE").ToString(),
                                  ._AREA_TYPE_DESCRIP = row("AREA_TYPE_DESCRIP").ToString(),
                                  ._DIMENSION_TYPE = row("DIMENSION_TYPE").ToString(),
                                  ._DIMENSION_TYPE_DESCRIP = row("DIMENSION_TYPE_DESCRIP").ToString(),
                                  ._SPATIAL_UNIT_DESCRIP = row("SPATIAL_UNIT_DESCRIP").ToString(),
                                  ._LAND_USE = row("LAND_USE").ToString(),
                                  ._LAND_USE_DESCRIP = row("LAND_USE_DESCRIP").ToString(),
                                  ._ADM_USE = row("ADM_USE").ToString(),
                                  ._ADM_USE_DESCRIP = row("ADM_USE_DESCRIP").ToString(),
                                  ._VALUE = If((TypeOf row("VALUE") Is DBNull), DirectCast(Nothing, System.Nullable(Of Decimal)), Convert.ToDecimal(row("VALUE"))),
                                  ._VALUE_DATE = If((TypeOf row("VALUE_DATE") Is DBNull), DirectCast(Nothing, System.Nullable(Of Date)), Convert.ToDateTime(row("VALUE_DATE"))),
                                  ._VALUE_TYPE = row("VALUE_TYPE").ToString(),
                                  ._VALUE_TYPE_DESC = row("VALUE_TYPE_DESC").ToString(),
                                  ._ADDRESS_ID = row("ADDRESS_ID").ToString(),
                                  ._STREET_NAME = row("STREET_NAME").ToString(),
                                  ._BUILDING_NAME = row("BUILDING_NAME").ToString(),
                                  ._BUILDING_NUMBER = row("BUILDING_NUMBER").ToString(),
                                  ._POSTAL_CODE = row("POSTAL_CODE").ToString(),
                                  ._POST_BOX = row("POST_BOX").ToString(),
                                  ._MUN_CODE = row("MUN_CODE").ToString(),
                                  ._MUN_NAME = row("MUN_NAME").ToString(),
                                  ._SP_CODE = row("SP_CODE").ToString(),
                                  ._SP_NAME = row("SP_NAME").ToString(),
                                  ._COUNTRY_CODE = row("COUNTRY_CODE").ToString(),
                                  ._COUNTRY_NAME = row("COUNTRY_NAME").ToString()
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
