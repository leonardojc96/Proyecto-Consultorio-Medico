<!--Archivo de configuracion -->

<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
    <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
  </configSections>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.1" />
  </startup>
  <connectionStrings>
    <add name="Proyecto_centro_medicoEntities" connectionString="metadata=res://*/Modelo.Model1.csdl|res://*/Modelo.Model1.ssdl|res://*/Modelo.Model1.msl;provider=System.Data.SqlClient;provider connection string='data source=NombreDelUsuario;initial catalog=&quot;NombreDeLaBaseDeDatos&quot;;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework'" providerName="System.Data.EntityClient" />
  </connectionStrings>
  <entityFramework>
    <defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework" />
    <providers>
      <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
    </providers>
  </entityFramework>
</configuration>
