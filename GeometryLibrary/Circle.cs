using System.Data;

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
                if (value <= 0)
                {
                    throw new Exception($"Радиус окружности не может быть отрицательным или равен 0");
                }
                else
                {
                    _r = value;
                }               
            }
        }
        public bool validCircle(double r)
        {
            return r > 0 ? true : false;
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
            _areaCircle = _pi * (R * R);
            return _areaCircle;
        }
        public Circle()
        {
            
        }
        public Circle(double r)
        {
            if (validCircle(r))
            {
                R = r;
            }
            else
            {
                throw new Exception($"Окружности с заданным ридусом не существует");
            }

        }
    }
}
