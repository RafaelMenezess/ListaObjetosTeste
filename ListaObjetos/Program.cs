using CsvHelper;
using ListaObjetos;
using Newtonsoft.Json;
using System.Globalization;

namespace DeviceFilter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiUrl = "https://api.restful-api.dev/objects";
            var dispositivos = await GetDevicesAsync(apiUrl);

            var marca = "Apple";

            var dispositivosMarca = FilterDispositivos(dispositivos, marca);

            foreach (var dispositivo in dispositivosMarca)
            {
                Console.WriteLine(dispositivo.Id + dispositivo.Name + dispositivo.Data?.Color + dispositivo.Data?.Capacity);
                Console.WriteLine("-------------------------");
            }

            SaveToCsv(dispositivosMarca, $"{marca}_eletronicos.csv");
        }

        static async Task<List<Eletronicos>> GetDevicesAsync(string url)
        {
            using HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<Eletronicos>>(response);
        }

        static List<Eletronicos> FilterDispositivos(List<Eletronicos> dispositivos, string marca)
        {
            var dispositivosMarca = new List<Eletronicos>();

            foreach (var dispositivo in dispositivos)
            {
                if (dispositivo.Name.Contains(marca))
                {
                    dispositivosMarca.Add(dispositivo);
                }
            }
            return dispositivosMarca;
        }

        static void SaveToCsv(List<Eletronicos> dispositivos, string filePath)
        {
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(dispositivos);
        }
    }
}