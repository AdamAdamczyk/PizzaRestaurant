namespace Restaurant.Web.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessege { get; set; } = "";
        public List<string> ErrorMessages { get; set; }

    }
}
