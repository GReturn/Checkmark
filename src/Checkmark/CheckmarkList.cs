namespace Checkmark
{
    public class CheckmarkList
    {
        public string ListTitle { get; set; }
        public string Priority { get; set; }
        public string[] Items { get; set; }
        
        /*
        TODO: Concept: Generate a new json file:
        
        my_lists.json
        {
            "ListTitleHere": {
                "Priority": "insertPriority",
                "Items": [
                    "[] DoThis1",
                    "[] Do This2"
                ]
            }
            "AnotherListHere": {}
        }
        Looks good.
        */
        
        
    }
}