namespace AndreasReitberger.Models
{
    public class ChartItem
    {
        #region Properties
        public string Name { get; set; }
        public double Value { get; set; }
        #endregion

        #region Constructor
        public ChartItem()
        {

        }
        public ChartItem(string name, double value)
        {
            Name = name;
            Value = value;
        }
        #endregion
    }
}
