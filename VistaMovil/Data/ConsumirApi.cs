namespace VistaMovil.Data
{
    public class ConsumirApi
    {
            private readonly HttpClient _client;

            public ConsumirApi(HttpClient client)
            {
                _client = client;
            }

            public async Task<string> ObtenerDatos()
            {
                return await _client.GetStringAsync("http://localhost:5000/Olimpiadas2023");

            }
    
    }
}
