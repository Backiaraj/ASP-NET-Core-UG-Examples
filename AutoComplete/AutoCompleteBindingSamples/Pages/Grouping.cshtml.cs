using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCompleteBindingSamples.Pages;

public class Grouping : PageModel
{
    public void OnGet()
    {
        
    }
}
public class GroupingRecord
{
    public string ID { get; set; }
    public string Text { get; set; }
    public string Group { get; set; }
    public List<GroupingRecord> RecordList { set; get; }
    public List<GroupingRecord> RecordModelList()
    {
        Random random = new Random();
        return Enumerable.Range(1, 150).Select(i => new GroupingRecord()
        {
            ID = i.ToString(),
            Text = "Item " + i,
            Group = GetRandomGroup(random),

        }).ToList();
    }
    public string GetRandomGroup(Random random)
    {
        // Generate a random number between 1 and 4 to determine the group
        int randomGroup = random.Next(1, 5);
        switch (randomGroup)
        {
            case 1:
                return "Group A";
            case 2:
                return "Group B";
            case 3:
                return "Group C";
            case 4:
                return "Group D";
            default:
                return string.Empty;
        }
    }
}