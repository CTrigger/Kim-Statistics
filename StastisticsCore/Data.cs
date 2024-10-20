namespace StastisticsCore
{
    public class Data
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; }

        #endregion

        #region Ctor
        public Data() { }
        public Data(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion
    }
}
