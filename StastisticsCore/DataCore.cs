using System.Collections.Generic;
using System.Linq;

namespace StastisticsCore
{
    public class DataCore
    {
        #region Properties
        public List<Data> Dataset { get; set; }
        public double SumOfFrequencies { get => Dataset.Sum(d => d.Y); }
        #endregion

        #region Ctor
        public DataCore()
        {
            Dataset = new List<Data>();
        }
        #endregion

        #region Methods
        public void LoadData(List<Data> dataset)
        {
            Dataset = dataset;
        }

        #region Add
        public void AddItem(double y)
        {
            double x = Dataset.LastOrDefault()?.X ?? 0;
            x++;
            Dataset.Add(new Data(x, y));
        }
        public void AddItem(double x, double y)
        {
            Dataset.Add(new Data(x, y));
        }

        #endregion

        #region Remove
        public int RemoveItem(double x)
        {
            return Dataset.RemoveAll(d => d.X == x);
        }
        public int RemoveItem(double x, double y)
        {
            return Dataset.RemoveAll(d => d.X == x && d.Y == y);
        }
        #endregion

        #region Change
        public void ChangeValue(double x, double y)
        {
            int index = Dataset.FindIndex(d => d.X == x);
            if (index != -1)
                throw new System.Exception($"Index not found: {x}");

            Dataset[index].Y = y;
        }
        #endregion

        #endregion
    }
}
