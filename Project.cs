namespace EFAddMigrationRepro;

public class Project
{
    public Project(string name)
    {
        Name = name;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public List<Import> Imports { get; set; } = new();
}
