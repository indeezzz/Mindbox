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
                    _a = value * -1;
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
                    _b = value * -1;
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
                if (value < 0)
                {
                    _c = value * -1;
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
        /// Существует ли данный треугольник 
        /// </summary>
        /// <returns>Возвращает значение true/false</returns>
        public bool validTriangle()
        {
            return A + B > C && A + C > B && C + B > A ? true : false;
        }

        /// <summary>
        /// Определение вида треугольника с параметрами по углам
        /// </summary>
        /// <returns>Возвращает название треугольника в формате string</returns>
        public string typeTriangleAtTheCorners(double a, double b, double c)
        {
            switch (validTriangle(a, b, c) && c > a && c > b)
            {
                case true when (Math.Pow(c, 2) > Math.Pow(a, 2) + Math.Pow(b, 2)):
                    return $"{FigureName} тупоугольный";
                case true when (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)):
                    return $"{FigureName} прямоугольный";
                case true when (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2)):
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
            switch (validTriangle(A, B, C) && C > A && C > B)
            {
                case true when (Math.Pow(C, 2) > Math.Pow(A, 2) + Math.Pow(B, 2)):
                    return $"{FigureName} тупоугольный";
                case true when (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)):
                    return $"{FigureName} прямоугольный";
                case true when (Math.Pow(C, 2) < Math.Pow(A, 2) + Math.Pow(B, 2)):
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
            switch (validTriangle(A, B, C))
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
            switch(validTriangle(a, b, c))
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
            A = 1;
            B = 1;
            C = 1;
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
