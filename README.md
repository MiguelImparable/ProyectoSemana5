# ProyectoSemana5
Proyecto de citas medicas conforme a los requerimientos de MVC.

Para ello se va a utilizar el proyecto como una web.

Librerias instaladas:
1. dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0-preview.3.23174.2
2. dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0-preview.3.23174.2
3. dotnet add package System.Linq --version 4.3.0
4. dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0-preview.3.23174.2
5. dotnet add package Microsoft.AspNetCore.Http --version 2.2.2
6. dotnet add package Microsoft.AspNetCore.Mvc --version 2.2.0
7. dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 8.0.0-preview.3.23177.8
8. dotnet add package Microsoft.AspNetCore.Mvc.ViewFeatures --version 2.2.0
NOTA: todos intalados correctamente y sin inconvenientes.

Para su ejecucion, el siguiente comando en la consola enrutada:
- dotnet run

Migraciones:
- dotnet tool install --global dotnet-ef
- dotnet tool update --global dotnet-ef
- Install-Package Microsoft.EntityFrameworkCore.Tools
- Add-Migration InitialCreate
- dotnet ef migrations add InitialCreate 