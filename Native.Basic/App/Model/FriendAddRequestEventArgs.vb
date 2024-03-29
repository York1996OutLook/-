﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace App.Model
	Public Class FriendAddRequestEventArgs
		Inherits EventArgsBase

		''' <summary>
		''' 发送时间
		''' </summary>
		''' <returns></returns>
		Public Property SendTime As DateTime

		''' <summary>
		''' 附加消息
		''' </summary>
		''' <returns></returns>
		Public Property AppendMsg As String

		''' <summary>
		''' 反馈标识(处理请求时使用)
		''' </summary>
		''' <returns></returns>
		Public Property Tag As String
	End Class
End Namespace
