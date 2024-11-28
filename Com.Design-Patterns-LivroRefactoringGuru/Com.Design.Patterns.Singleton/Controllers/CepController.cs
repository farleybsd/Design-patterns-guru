using Microsoft.AspNetCore.Mvc;

namespace Com.Design.Patterns.Singleton.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CepController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly ApiSettingsSingletonViaCep _apiSettings;

        public CepController(HttpClient httpClient, ApiSettingsSingletonViaCep apiSettings)
        {
            _httpClient = httpClient;
            _apiSettings = apiSettings;
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetAddressByCep(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
                return BadRequest("O CEP não pode ser vazio ou nulo.");
            var baseUrl = _apiSettings.ViaCepBaseUrl;
            var url = $"{baseUrl}/{cep}/json/";

            try
            {
                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    return StatusCode((int)response.StatusCode, "Erro ao buscar dados do CEP.");

                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, $"Erro ao se comunicar com o serviço externo: {ex.Message}");
            }
        }
    }
}
