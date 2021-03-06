Imports System

Namespace Xydc.Platform.BusinessFacade

    '----------------------------------------------------------------
    ' 命名空间：Xydc.Platform.BusinessFacade
    ' 类名    ：IGgxxNbltLtzyInfo
    '
    ' 功能描述： 
    '     ggxx_nblt_ltzy_info.aspx模块调用接口的定义与处理
    '----------------------------------------------------------------
    <Serializable()> Public Class IGgxxNbltLtzyInfo
        Inherits Xydc.Platform.BusinessFacade.ICallInterface

        '----------------------------------------------------------------
        'QueryString Parameters
        '----------------------------------------------------------------
        Public Const qspJLBH As String = "JLBH"

        '----------------------------------------------------------------
        '输入参数
        '----------------------------------------------------------------
        Private m_objEditMode_I As Xydc.Platform.Common.Utilities.PulicParameters.enumEditType  '编辑模式
        Private m_strJLBH_I As String                                                        '修改、拷贝时的交流编号
        Private m_strSJBH_I As String                                                        '增加、拷贝时的上级编号

        '----------------------------------------------------------------
        '输出参数
        '----------------------------------------------------------------
        Private m_blnExitMode_O As Boolean                 '返回方式：True-确定，False-取消
        Private m_strJLBH_O As String                      '返回正在处理的交流编号









        '----------------------------------------------------------------
        ' 构造函数
        '----------------------------------------------------------------
        Public Sub New()
            MyBase.New()

            '初始化父类参数
            MyBase.iInterfaceType = ICallInterface.enumInterfaceType.InputAndOutput

            '初始化输入参数
            m_objEditMode_I = Xydc.Platform.Common.Utilities.PulicParameters.enumEditType.eSelect
            m_strJLBH_I = ""
            m_strSJBH_I = ""

            '初始化输出参数
            m_blnExitMode_O = False
            m_strJLBH_O = ""

        End Sub

        '----------------------------------------------------------------
        ' 重载父类的析构函数
        '----------------------------------------------------------------
        Public Overloads Sub Dispose()
            MyBase.Dispose()
            Dispose(True)
        End Sub

        '----------------------------------------------------------------
        ' 释放本身资源
        '----------------------------------------------------------------
        Protected Overloads Sub Dispose(ByVal disposing As Boolean)
            If (Not disposing) Then
                Exit Sub
            End If
        End Sub

        '----------------------------------------------------------------
        ' 安全释放本身资源
        '----------------------------------------------------------------
        Public Overloads Shared Sub SafeRelease(ByRef obj As Xydc.Platform.BusinessFacade.IGgxxNbltLtzyInfo)
            Try
                If Not (obj Is Nothing) Then
                    obj.Dispose()
                End If
            Catch ex As Exception
            End Try
            obj = Nothing
        End Sub













        '----------------------------------------------------------------
        ' iEditMode属性
        '----------------------------------------------------------------
        Public Property iEditMode() As Xydc.Platform.Common.Utilities.PulicParameters.enumEditType
            Get
                iEditMode = m_objEditMode_I
            End Get
            Set(ByVal Value As Xydc.Platform.Common.Utilities.PulicParameters.enumEditType)
                Try
                    m_objEditMode_I = Value
                Catch ex As Exception
                    m_objEditMode_I = Xydc.Platform.Common.Utilities.PulicParameters.enumEditType.eSelect
                End Try
            End Set
        End Property

        '----------------------------------------------------------------
        ' iJLBH属性
        '----------------------------------------------------------------
        Public Property iJLBH() As String
            Get
                iJLBH = m_strJLBH_I
            End Get
            Set(ByVal Value As String)
                Try
                    m_strJLBH_I = Value
                Catch ex As Exception
                    m_strJLBH_I = ""
                End Try
            End Set
        End Property

        '----------------------------------------------------------------
        ' iSJBH属性
        '----------------------------------------------------------------
        Public Property iSJBH() As String
            Get
                iSJBH = m_strSJBH_I
            End Get
            Set(ByVal Value As String)
                Try
                    m_strSJBH_I = Value
                Catch ex As Exception
                    m_strSJBH_I = ""
                End Try
            End Set
        End Property




        '----------------------------------------------------------------
        ' oExitMode属性
        '----------------------------------------------------------------
        Public Property oExitMode() As Boolean
            Get
                oExitMode = m_blnExitMode_O
            End Get
            Set(ByVal Value As Boolean)
                Try
                    m_blnExitMode_O = Value
                Catch ex As Exception
                    m_blnExitMode_O = False
                End Try
            End Set
        End Property

        '----------------------------------------------------------------
        ' oJLBH属性
        '----------------------------------------------------------------
        Public Property oJLBH() As String
            Get
                oJLBH = m_strJLBH_O
            End Get
            Set(ByVal Value As String)
                Try
                    m_strJLBH_O = Value
                Catch ex As Exception
                    m_strJLBH_O = ""
                End Try
            End Set
        End Property

    End Class

End Namespace
