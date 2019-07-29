namespace EditorApp.API.Dtos
{
    public class UserForLoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NewswrapCode { get; set; }
        public string NewswrapDesk { get; set; }
        public int? NewswrapCenter { get; set; }

    }
}