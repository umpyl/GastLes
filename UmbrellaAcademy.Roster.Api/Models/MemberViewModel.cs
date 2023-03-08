namespace UmbrellaAcademy.Roster.Api.Models
{
    public record MemberViewModel
    {
        public string? Name { get; set; }
        public string[]? Nicknames { get; set; }
        public string[]? Skills { get; set; }
        public string[]? Images { get; set; }
        public short Number { get; set; }
    }
}
