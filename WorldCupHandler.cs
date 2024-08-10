using Newtonsoft.Json;
using System.Security.Permissions;
namespace WorldCupApi.Models
{
    public class WorldCupHandler
    {
        private string _filePath = "C:\\c#\\WorldCupApi\\JSONFile\\json.json";
        private readonly List<WorldCup> _WorldCupList= new List<WorldCup>();
        public WorldCupHandler()
        {
            _filePath = File.ReadAllText(_filePath);    
            _WorldCupList = JsonConvert.DeserializeObject<List<WorldCup>>(_filePath);   
        }
        public string GetTeam(int year)
        {
            WorldCup IsWin=_WorldCupList.FirstOrDefault(x => x.Year == year);   
            if(IsWin==null)
            {
                return "Enter right year";
            }
            return IsWin.Winner;
        }
    }
}
