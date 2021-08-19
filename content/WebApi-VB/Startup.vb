Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Public Class Startup
    Public Sub New(configuration As IConfiguration)
        Me.Configuration = configuration
    End Sub

    Public ReadOnly Property Configuration As IConfiguration

    Public Sub ConfigureServices(services As IServiceCollection)
        services.AddControllers()
    End Sub

    Public Sub Configure(app As IApplicationBuilder, env As IWebHostEnvironment)
        If env.IsDevelopment() Then
            app.UseDeveloperExceptionPage()
        End If

        app.UseHttpsRedirection()
        app.UseRouting()
        app.UseAuthorization()
        app.UseEndpoints(Function(endpoints)
                             Return endpoints.MapControllers()
                         End Function)
    End Sub
End Class
