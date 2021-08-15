using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace DinerLibrary
{
    public static class JSerializer
    {
        /// <summary>
        /// Write JSON file
        /// </summary>
        /// <param name="diner"></param>
        public static async void WriteJSON(Diner diner)
        {
            using (FileStream fs = new FileStream("sFile.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, diner);
            }
        }
        /// <summary>
        /// Read JSON file
        /// </summary>
        /// <returns></returns>
        public static async Task<Diner> ReadJSON()
        {
            Diner newDiner = null;
            using (FileStream fs = new FileStream("sFile.json", FileMode.Open))
            {
                newDiner = await JsonSerializer.DeserializeAsync<Diner>(fs);
            }
            return newDiner;
        }
    }
}