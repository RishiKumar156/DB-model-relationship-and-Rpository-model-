namespace Patric_God.Models
{
    public class User
    {
        public int USerID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserDes { get; set; } = string.Empty;
        public DateTime UserCreatedTime { get; set; }

    }
}
