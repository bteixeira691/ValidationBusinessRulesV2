namespace ChainResponsibility.Model
{
    public class ValidationRequest
    {
        public List<string> ErrorList { get; set; } = new();
        public string Name{ get; set; }
        public string Lastname{ get; set; }
        public Guid Id { get; set; }

    }
}
