namespace EFRepro
{
    public class Foo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Bar { get; set; } = string.Empty;

        public string Baz { get; set; } = string.Empty;
    }
}
