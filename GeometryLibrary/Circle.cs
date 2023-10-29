namespace GeometryLibrary
{
    public class Circle : Figure
    {
        private readonly double _pi = Math.PI;
        private double _r;
        private double _areaCircle;
        private double _perimeterCircle;

        public double R
        {
            get
            {
                return _r;
            }
            set
            {
                if (value < 0)
                {
                    _r = value * -1;
                }
                else
                {
                    _r = value;
                }               
            }
        }
        protected override string FigureName => "Круг";
        /// <summary>
        /// Вычисление периметра круга
        /// </summary>
        /// <returns>Вывод пермиетра в формате double</returns>
        public override double Perimeter()
        {
            _perimeterCircle = 2 * _pi * R;
            return _perimeterCircle;
        }
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>Вывод площади в формате double</returns>
        public override double Area()
        {
            _areaCircle = _pi * Math.Pow(R, 2);
            return _areaCircle;
        }
        public Circle()
        {
            _r = 1;
        }
        public Circle(double r)
        {
            R = r;
        }
    }
}
