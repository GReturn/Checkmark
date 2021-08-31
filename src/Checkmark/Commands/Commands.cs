namespace Checkmark.Commands
{
    public record Command;

    public record CreateCommand() : Command;
    public record ReadCommand() : Command;
    public record DeleteCommand() : Command;
}
