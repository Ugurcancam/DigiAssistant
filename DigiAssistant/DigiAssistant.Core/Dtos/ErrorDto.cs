namespace DigiAssistant.Core.Dtos
{
    public class ErrorDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Solution1 { get; set; }
        public byte[]? SolutionPhoto1 { get; set; }
        public int ErrorCategoryId { get; set; }
    }
}