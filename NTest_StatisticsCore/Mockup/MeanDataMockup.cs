using StastisticsCore;
using System.Text.Json;
namespace NTest_StatisticsCore.Mockup
{
    public static class MeanDataMockup
    {
        public static string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Mockup", "JSON");

        public static IEnumerable<TestCaseData> WeightMockup()
        {
            List<Data> t = GetData<List<Data>>(Path.Combine(FolderPath, "WeightSample.json"));
            List<string> r = GetData<List<string>>(Path.Combine(FolderPath, "WeightSample_1_Ans.json"));
            yield return new TestCaseData(t, r);
        }
        public static T GetData<T>(string path) where T : class
            //public static async Task<T> GetData<T>(string path) where T : class
        {
            if (!File.Exists(path))
                throw new FileNotFoundException(path);
            string jsonData = File.ReadAllText(path);
            //string jsonData = await File.ReadAllTextAsync(path);

            return JsonSerializer.Deserialize<T>(jsonData);

        }
    }
}
