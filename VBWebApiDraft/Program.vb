Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Hosting

Public Class Program
    Public Shared Sub Main(args As String())
        CreateHostBuilder(args).Build().Run()
    End Sub

    Public Shared Function CreateHostBuilder(args As String()) As IHostBuilder
        Return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(Function(webBuilder)
                                                                            webBuilder.UseStartup(Of Startup)()
                                                                        End Function)
    End Function
End Class
