﻿'------------------------------------------------------------------------------
' <auto-generated>
'     이 코드는 도구를 사용하여 생성되었습니다.
'     런타임 버전:4.0.30319.42000
'
'     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
'     이러한 변경 내용이 손실됩니다.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '이 클래스는 ResGen 또는 Visual Studio와 같은 도구를 통해 StronglyTypedResourceBuilder
    '클래스에서 자동으로 생성되었습니다.
    '멤버를 추가하거나 제거하려면 .ResX 파일을 편집한 다음 /str 옵션을 사용하여 ResGen을
    '다시 실행하거나 VS 프로젝트를 다시 빌드하십시오.
    '''<summary>
    '''  지역화된 문자열 등을 찾기 위한 강력한 형식의 리소스 클래스입니다.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Resource1
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  이 클래스에서 사용하는 캐시된 ResourceManager 인스턴스를 반환합니다.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MapleAlarm.Resource1", GetType(Resource1).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  이 강력한 형식의 리소스 클래스를 사용하여 모든 리소스 조회에 대한 현재 스레드의 CurrentUICulture
        '''  속성을 재정의합니다.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream과(와) 유사한 System.IO.UnmanagedMemoryStream 형식의 지역화된 리소스를 찾습니다.
        '''</summary>
        Friend Shared ReadOnly Property _in() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("_in", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream과(와) 유사한 System.IO.UnmanagedMemoryStream 형식의 지역화된 리소스를 찾습니다.
        '''</summary>
        Friend Shared ReadOnly Property dn() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("dn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream과(와) 유사한 System.IO.UnmanagedMemoryStream 형식의 지역화된 리소스를 찾습니다.
        '''</summary>
        Friend Shared ReadOnly Property trans() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("trans", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream과(와) 유사한 System.IO.UnmanagedMemoryStream 형식의 지역화된 리소스를 찾습니다.
        '''</summary>
        Friend Shared ReadOnly Property up() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("up", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
