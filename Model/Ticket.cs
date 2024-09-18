using System;

public class Ticket
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int UserId { get; set; }
    public Status Status { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Ticket()
    {
    }
    public void MakeNewTicket()
    {
        StartDate = DateTime.Now;
    }
}
