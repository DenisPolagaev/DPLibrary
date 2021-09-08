using System.IO;
using System.Security.AccessControl;

public static class CreateIfNotExistsExtensions
{
   public static void CreateIfNotExist(this DirectoryInfo @this)
   {
      if (!@this.Exists)
      {
         @this.Create();
      }
   }
   
   public static void CreateIfNotExist(this DirectoryInfo @this, DirectorySecurity directorySecurity)
   {
      if (!@this.Exists)
      {
         @this.Create(directorySecurity);
      }
   }
}