namespace Entities.Models.RequestModels
{
    public class ValidationProblemDetails : ProblemDetails
    {
        public object Errors { get; set; }
    }
}
