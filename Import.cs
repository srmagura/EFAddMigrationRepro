namespace EFAddMigrationRepro;

public class Import
{
    public Import(string filename)
    {
        Filename = filename;
    }

    public Guid Id { get; set; }

    public string Filename { get; set; }

    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }
}
