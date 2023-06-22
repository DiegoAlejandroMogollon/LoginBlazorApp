
using Blazored.SessionStorage;
using System.Text.Json;
using System.Text;
using LoginBlazorApp.Shared;

namespace LoginBlazorApp.Client.Extensiones
    //Metodo guardar informacion
{
    public static class SesionStorageExtension
    {
        public static async Task GuardarStorage<T>(this ISessionStorageService sessionStorageService, String key, T item)
            where T : class

        {
            var itemJson = JsonSerializer.Serialize(item);
            await sessionStorageService.SetItemAsStringAsync(key, itemJson);
            
        }

        public static async Task <T?> ObtenerStorage <T>
            (this ISessionStorageService sessionStorageService, String key)
           where T : class

        {
            var itemJson = await sessionStorageService.GetItemAsStringAsync(key);
            if (itemJson != null)
            {
                var item = JsonSerializer.Deserialize<T>(itemJson);
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}
