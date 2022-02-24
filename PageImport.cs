namespace EFAddMigrationRepro;

public class PageImport
{
    public PageImport(string filename)
    {
        Filename = filename;
    }

    public Guid Id { get; set; }

    public string Filename { get; set; }
}
