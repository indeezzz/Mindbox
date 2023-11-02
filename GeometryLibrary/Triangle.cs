namespace GeometryLibrary
{
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _areaTriangle;
        private double _perimeterTriangle;

        public double A
        {
            get { return _a; }
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Длина стороны A треугольника не может быть отрицательна или равна 0");
                }
                else
                {
                    _a = value;
                }
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Длина стороны B треугольника не может быть отрицательна или равна 0");
                }
                else
                {
                    _b = value;
                }
            }
        }
        public double C
        {
            get { return _c; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Длина стороны C треугольника не может быть отрицательна или равна 0");
                }
                else
                {
                    _c = value;
                }
            }
        }

        protected override string FigureName => "Треугольник";
        /// <summary>
        /// Вычисление периметра треугольника
        /// </summary>
        /// <returns>Вывод периметра в формате double</returns>
        public override double Perimeter()
        {
            _perimeterTriangle = (A + B + C) / 2;
            return _perimeterTriangle;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Вывод площади в формате double</returns>
        public override double Area()
        {
            _perimeterTriangle = Perimeter();
            _areaTriangle = Math.Sqrt(_perimeterTriangle * (_perimeterTriangle - A) * (_perimeterTriangle - B) * (_perimeterTriangle - C));
            return _areaTriangle;
        }

        /// <summary>
        /// Существует ли треугольник с задаными сторонами
        /// </summary>
        /// <param name="a">Длина стороны АB</param>
        /// <param name="b">Длина стороны BC</param>
        /// <param name="c">Длина стороны AC</param>
        /// <returns>Возвращает значение true/false</returns>      
        public bool validTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && c + b > a ? true : false;
        }
        /// <summary>
        /// Определение вида треугольника с параметрами по углам
        /// </summary>
        /// <returns>Возвращает название треугольника в формате string</returns>
        public string typeTriangleAtTheCorners(double a, double b, double c)
        {
            switch (true)
            {
                case true when ((c * c) > (a * a) + (b * b)):
                    return $"{FigureName} тупоугольный";
                case true when ((c * c) == (a * a) + (b * b)):
                    return $"{FigureName} прямоугольный";
                case true when ((c * c) < (a * a) + (b * b)):
                    return $"{FigureName} остроугольный";
                default:
                    return $"Треугольник не классифицируется по типу углов";
            }
        }
        /// <summary>
        /// Определение вида треугольника по углам
        /// </summary>
        /// <returns>Возвращает название треугольника в формате string</returns>
        public string typeTriangleAtTheCorners()
        {
            switch (true)
            {
                case true when ((C * C) > (A * A) + (B * B)):
                    return $"{FigureName} тупоугольный";
                case true when ((C * C) == (A * A) + (B * B)):
                    return $"{FigureName} прямоугольный";
                case true when ((C * C) < (A * A) + (B * B)):
                    return $"{FigureName} остроугольный";
                default:
                    return $"Треугольник не классифицируется по типу углов";
            }
        }
        /// <summary>
        /// Определение вида треугольника по сторонам
        /// </summary>
        /// <returns>Возвращает название треугольника в формате string</returns>
        public string typeTriangleOnThSides()
        {
            switch (true)
            {
                case true when (A == B && A == C):
                    return $"{FigureName} равносторонний";
                case true when (A == B):
                    return $"{FigureName} равнобедренный";
                case true when (A != B && A != C):
                    return $"{FigureName} разносторонний";
                default:
                    return $"Треугольник с такими параметрами не существует";
            }
        }
        /// <summary>
        /// Определение вида треугольника по сторонам с задаными параметрами
        /// </summary>
        /// <returns>Возвращает название треугольника в формате string</returns>
        public string typeTriangleOnThSides(double a, double b, double c)
        {
            switch(true)
            {
                case true when (a == b && a == c): 
                    return $"{FigureName} равносторонний";  
                case true when (a == b):
                    return $"{FigureName} равнобедренный";
                case true when (a != b && a != c):
                    return $"{FigureName} разносторонний";
                default: 
                    return $"Треугольник с такими параметрами не существует";
            }
        }
        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            if(validTriangle(a,b,c))
            {
                _a = a;
                _b = b;
                _c = c;
            }
            else
            {
                throw new Exception("Треугольника с такими длинами не существует");
            }
        }
    }
}
