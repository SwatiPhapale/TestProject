using System;
using System.Collections.Generic;

namespace ParsetheParcel
{
    public class ParseTheParcel : IParseTheParcel
    {
        private Dimension _dimension;
        private decimal _cost { get; set; }
        private double _weight { get; set; }

        private readonly Dictionary<string, Dimension> _packageType = new Dictionary<string, Dimension>();
        public void InitDimention()
        {

            _packageType.Add("Small", new Dimension(200, 300, 150));
            _packageType.Add("Medium", new Dimension(300, 400, 200));
            _packageType.Add("Large", new Dimension(400, 600, 250));

        }
        //public ParseTheParcel(int Length, int Breadth, int Height, double Weight)
        //{
        //    _dimension.length = Length;
        //    _dimension.breadth = Breadth;
        //    _dimension.height = Height;
        //    _weight = Weight;
        //}

        private bool CheckOverweight()
        {
            if (_weight > 0 && _weight <= 25)
                return false;
            return true;

        }
        private bool ValidateDimention()
        {

            if (_dimension.length > 0 && _dimension.breadth > 0 && _dimension.height > 0)
            { return true; }
            return false;
        }
        public decimal CalculateParcelCost(int Length, int Breadth, int Height, double Weight)
        {
            _dimension.length = Length;
            _dimension.breadth = Breadth;
            _dimension.height = Height;
            _weight = Weight;
            return CalculateParcelCost();
        }
        private decimal CalculateParcelCost()
        {
            try
            {
                if (!CheckOverweight())
                {
                    if (ValidateDimention())
                    {
                        InitDimention();
                        _cost = Decimal.Zero;

                        if (_dimension.length <= _packageType["Small"].length &&
                          _dimension.breadth <= _packageType["Small"].breadth &&
                          _dimension.height <= _packageType["Small"].height)
                        {
                            _cost = 5.00M;
                        }
                        else if (_dimension.length <= _packageType["Medium"].length &&
                                 _dimension.breadth <= _packageType["Medium"].breadth &&
                                 _dimension.height <= _packageType["Medium"].height)
                        {
                            _cost = 7.50M;
                        }
                        else if (_dimension.length <= _packageType["Large"].length &&
                                 _dimension.breadth <= _packageType["Large"].breadth &&
                                 _dimension.height <= _packageType["Large"].height)
                        {
                            _cost = 8.50M;
                        }
                    }
                }
            }
            catch (Exception ex)
            { Console.WriteLine("Error Massage", ex.Message); }
            return _cost;
        }
    }
}
