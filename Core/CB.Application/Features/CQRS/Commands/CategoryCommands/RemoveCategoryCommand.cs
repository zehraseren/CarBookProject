namespace CB.Application.Features.CQRS.Commands.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
