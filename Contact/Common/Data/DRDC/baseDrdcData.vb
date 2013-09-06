'----------------------------------------------------------------
' Copyright (C) 2006-2016 Josco Software Corporation
' All rights reserved.
'
' This source code is intended only as a supplement to Microsoft
' Development Tools and/or on-line documentation. See these other
' materials for detailed information regarding Microsoft code samples.
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY 
' OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT 
' LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR 
' FITNESS FOR A PARTICULAR PURPOSE.
'----------------------------------------------------------------
Option Strict On
Option Explicit On 

Imports System
Imports System.Data
Imports System.Runtime.Serialization

Namespace Xydc.Platform.Common.Data

    '----------------------------------------------------------------
    ' 命名空间：Xydc.Platform.Common.Data
    ' 类名    ：DrdcData
    '
    ' 功能描述：
    '   　定义访问Excel文件有关格式
    '----------------------------------------------------------------
    <System.ComponentModel.DesignerCategory("DRDC"), SerializableAttribute()> Public Class DrdcData
        Inherits System.Data.DataSet

        '自定义报表有关参数
        Public Const MACRO_PROPSEP As String = ":"
        Public Const MACRO_ELEMSEP As String = "$"
        Public Const MACRO_FIELD As String = "FIELD"

        '定义“通用_B_导入导出_EXCEL格式数据”
        '表名称
        Public Const TABLE_TY_B_DRDC_EXCELFORMAT As String = "通用_B_导入导出_EXCEL格式数据"
        '字段序列
        '==============================================================================
        Public Const FIELD_TY_B_DRDC_EXCELFORMAT_DATASHEETNAME As String = "数据Sheet名"
        Public Const FIELD_TY_B_DRDC_EXCELFORMAT_TITLEROWS As String = "标题区行数"
        Public Const FIELD_TY_B_DRDC_EXCELFORMAT_DATACOLS As String = "数据列数"
        '==============================================================================
        '约束错误信息








        '定义初始化表类型enum
        Public Enum enumTableType
            TY_B_DRDC_EXCELFORMAT = 1
        End Enum








        '----------------------------------------------------------------
        ' 构造函数
        '----------------------------------------------------------------
        Private Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context)
        End Sub

        '----------------------------------------------------------------
        ' 构造函数
        '----------------------------------------------------------------
        Public Sub New()
            MyBase.New()
        End Sub

        '----------------------------------------------------------------
        ' 构造函数
        '----------------------------------------------------------------
        Public Sub New(ByVal objenumTableType As enumTableType)
            MyBase.New()
            Try
                Dim objDataTable As System.Data.DataTable
                Dim strErrMsg As String
                objDataTable = Me.createDataTables(strErrMsg, objenumTableType)
                If Not (objDataTable Is Nothing) Then
                    Me.Tables.Add(objDataTable)
                End If
            Catch ex As Exception
            End Try

        End Sub

        '----------------------------------------------------------------
        ' 安全释放本身资源
        '----------------------------------------------------------------
        Public Shared Sub SafeRelease(ByRef obj As Xydc.Platform.Common.Data.DrdcData)
            Try
                If Not (obj Is Nothing) Then
                    obj.Dispose()
                End If
            Catch ex As Exception
            End Try
            obj = Nothing
        End Sub









        '----------------------------------------------------------------
        '将给定DataTable加入到DataSet中
        '----------------------------------------------------------------
        Public Function appendDataTable(ByVal table As System.Data.DataTable) As String

            Dim strErrMsg As String = ""

            Try
                Me.Tables.Add(table)
            Catch ex As Exception
                strErrMsg = ex.Message
            End Try

            appendDataTable = strErrMsg

        End Function

        '----------------------------------------------------------------
        '根据指定类型创建dataTable
        '----------------------------------------------------------------
        Public Function createDataTables( _
            ByRef strErrMsg As String, _
            ByVal enumType As enumTableType) As System.Data.DataTable

            Dim table As System.Data.DataTable

            Select Case enumType
                Case enumTableType.TY_B_DRDC_EXCELFORMAT
                    table = createDataTables_EXCELFORMAT(strErrMsg)
                Case Else
                    strErrMsg = "无效的表类型！"
                    table = Nothing
            End Select

            createDataTables = table

        End Function

        '----------------------------------------------------------------
        '创建TABLE_TY_B_DRDC_EXCELFORMAT
        '----------------------------------------------------------------
        Private Function createDataTables_EXCELFORMAT(ByRef strErrMsg As String) As System.Data.DataTable

            Dim table As System.Data.DataTable

            Try
                table = New DataTable(TABLE_TY_B_DRDC_EXCELFORMAT)
                With table.Columns
                    .Add(FIELD_TY_B_DRDC_EXCELFORMAT_DATASHEETNAME, GetType(System.String))
                    .Add(FIELD_TY_B_DRDC_EXCELFORMAT_TITLEROWS, GetType(System.Int32))
                    .Add(FIELD_TY_B_DRDC_EXCELFORMAT_DATACOLS, GetType(System.Int32))
                End With
            Catch ex As Exception
                strErrMsg = ex.Message
                table = Nothing
            End Try

            createDataTables_EXCELFORMAT = table

        End Function

    End Class 'DrdcData

End Namespace 'Xydc.Platform.Common.Data
