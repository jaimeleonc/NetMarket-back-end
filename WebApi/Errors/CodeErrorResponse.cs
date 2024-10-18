namespace WebApi.Errors
{
    public class CodeErrorResponse
    {
        public CodeErrorResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDeFaultMessageStatusCode(statusCode);
        }

        private string GetDeFaultMessageStatusCode(int statusCode)
        {
            return StatusCode switch
            {
                400 => "El Request enviado tiene errores",
                401 => "No tienes autorización para este recurso",
                404 => "no se encuentró el item buscado",
                500 => "Se produjeron errores en el servidor",
                _ => null
            };
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
