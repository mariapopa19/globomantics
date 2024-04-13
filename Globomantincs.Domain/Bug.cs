namespace Globomantincs.Domain;

public record Bug(string Title,
    string Desciption,
    Severity Severity,
    string AffectedVersion,
    int AffectedUsers,
    User CreatedBy,
    User? AssignedTo,
    IEnumerable<byte[]> Images) : TodoTask(Title, DateTimeOffset.MinValue, CreatedBy);
