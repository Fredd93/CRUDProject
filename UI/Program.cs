using Model;
using Service;
using Service;
namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ticket> values = PopulateTickets();
            Console.WriteLine("What is your search query?");
            string query = Console.ReadLine().ToLower(); //Make the query lowercase for simplicity,
                                                         //also avoids having to look for both 'and' and 'AND'. Same with 'or' and 'OR'
            query = query.Replace(", ", " or "); //turn every , into an 'or'. Other way around would work too
            query = query.Replace(" & ", " and "); //turn every & into an 'and'. Other way around would work too
            string[] splits = query.Split(" or "); //split the query into pieces to search for the different keywords
            List<Ticket> results = new List<Ticket>();
            foreach(string s in splits)
            {
                string[] searchKeywords = s.Split(" and "); //split any keywords with an 'and' in them
                foreach (Ticket ticket in values)
                {
                    bool hasKeywords = true; 
                    foreach (string keyword in searchKeywords)
                    {
                        string trimmedKeyword = keyword.Trim(); //remove trailing whitespace that could mess up the search
                        if (!ticket.Title.ToLower().Contains(trimmedKeyword)) { hasKeywords = false; break; } //set to lowercase to avoid capitalization mistakes
                    }
                    if (hasKeywords && !results.Contains(ticket)) //if there isn't already a copy in the list,
                                                                 //because the query has 2 keywords that apply
                    {
                        results.Add(ticket);
                    }
                }
            }
            foreach (Ticket ticket in results) { Console.WriteLine(ticket.Title); }
            
        }
        static private List<Ticket> PopulateTickets()
        {
            List<Ticket> list = new List<Ticket>();
            list.Add(new Ticket()
            {
                Title = "I lost my apples"
            });
            list.Add(new Ticket()
            {
                Title = "File Recovery"
            });
            list.Add(new Ticket()
            {
                Title = "Pizza order"
            });
            list.Add(new Ticket()
            {
                Title = "Lost order"
            });
            list.Add(new Ticket()
            {
                Title = "Lost items"
            });
            list.Add(new Ticket()
            {
                Title = "Lost legendary rank item"
            });
            return list;
        }
    }
}
