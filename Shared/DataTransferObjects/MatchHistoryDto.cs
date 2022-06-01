using Entities.Models;

namespace SharedHelpers.DataTransferObjects;

public class MatchHistoryDto
{
    public int Id { get; set; }
    public Hamster Winner { get; set; }
    public Hamster Loser { get; set; }
}
