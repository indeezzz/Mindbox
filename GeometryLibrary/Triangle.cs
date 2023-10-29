п»їnamespace GeometryLibrary
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

        protected override string FigureName => "РўСЂРµСѓРіРѕР»СЊРЅРёРє";
        /// <summary>
        /// Р’С‹С‡РёСЃР»РµРЅРёРµ РїРµСЂРёРјРµС‚СЂР° С‚СЂРµСѓРіРѕР»СЊРЅРёРєР°.
        /// </summary>
        /// <returns>Р’С‹РІРѕРґ РїРµСЂРёРјРµС‚СЂР° РІ С„РѕСЂРјР°С‚Рµ double</returns>
        public override double Perimeter()
        {
            _perimeterTriangle = (A + B + C) / 2;
            return _perimeterTriangle;
        }

        /// <summary>
        /// Р’С‹С‡РёСЃР»РµРЅРёРµ РїР»РѕС‰Р°РґРё С‚СЂРµСѓРіРѕР»СЊРЅРёРєР°.
        /// </summary>
        /// <returns>Р’С‹РІРѕРґ РїР»РѕС‰Р°РґРё РІ С„РѕСЂРјР°С‚Рµ double</returns>
        public override double Area()
        {
            _perimeterTriangle = Perimeter();
            _areaTriangle = Math.Sqrt(_perimeterTriangle * (_perimeterTriangle - A) * (_perimeterTriangle - B) * (_perimeterTriangle - C));
            return _areaTriangle;
        }

        /// <summary>
        /// РЎСѓС‰РµСЃС‚РІСѓРµС‚ Р»Рё С‚СЂРµСѓРіРѕР»СЊРЅРёРє СЃ Р·Р°РґР°РЅС‹РјРё СЃС‚РѕСЂРѕРЅР°РјРё.
        /// </summary>
        /// <param name="a">Р”Р»РёРЅР° СЃС‚РѕСЂРѕРЅС‹ РђB</param>
        /// <param name="b">Р”Р»РёРЅР° СЃС‚РѕСЂРѕРЅС‹ BC</param>
        /// <param name="c">Р”Р»РёРЅР° СЃС‚РѕСЂРѕРЅС‹ AC</param>
        /// <returns>Р’РѕР·РІСЂР°С‰Р°РµС‚ Р·РЅР°С‡РµРЅРёРµ true/false</returns>      
        public bool validTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && c + b > a ? true : false;
        }
        /// <summary>
        /// РЎСѓС‰РµСЃС‚РІСѓРµС‚ Р»Рё РґР°РЅРЅС‹Р№ С‚СЂРµСѓРіРѕР»СЊРЅРёРє 
        /// </summary>
        /// <returns>Р’РѕР·РІСЂР°С‰Р°РµС‚ Р·РЅР°С‡РµРЅРёРµ true/false</returns>
        public bool validTriangle()
        {
            return A + B > C && A + C > B && C + B > A ? true : false;
        }

        /// <summary>
        /// РћРїСЂРµРґРµР»РµРЅРёРµ РІРёРґР° С‚СЂРµСѓРіРѕР»СЊРЅРёРєР° СЃ РїР°СЂР°РјРµС‚СЂР°РјРё РїРѕ СѓРіР»Р°Рј
        /// </summary>
        /// <returns>Р’РѕР·РІСЂР°С‰Р°РµС‚ РЅР°Р·РІР°РЅРёРµ С‚СЂРµСѓРіРѕР»СЊРЅРёРєР° РІ С„РѕСЂРјР°С‚Рµ string</returns>
        public string typeTriangleAtTheCorners(double a, double b, double c)
        {
            switch (validTriangle(a, b, c) && c > a && c > b)
            {
                case true when (Math.Pow(c, 2) > Math.Pow(a, 2) + Math.Pow(b, 2)):
                    return $"{FigureName} С‚СѓРїРѕСѓРіРѕР»СЊРЅС‹Р№";
                case true when (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)):
                    return $"{FigureName} РїСЂСЏРјРѕСѓРіРѕР»СЊРЅС‹Р№";
                case true when (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2)):
                    return $"{FigureName} РѕСЃС‚СЂРѕСѓРіРѕР»СЊРЅС‹Р№";
                default:
                    return $"РўСЂРµСѓРіРѕР»СЊРЅРёРє РЅРµ РєР»Р°СЃСЃРёС„РёС†РёСЂСѓРµС‚СЃСЏ РїРѕ С‚РёРїСѓ СѓРіР»РѕРІ";
            }
        }
        /// <summary>
        /// РћРїСЂРµРґРµР»РµРЅРёРµ РІРёРґР° С‚СЂРµСѓРіРѕР»СЊРЅРёРєР° РїРѕ СѓРіР»Р°Рј
        /// </summary>
        /// <returns>Р’РѕР·РІСЂР°С‰Р°РµС‚ РЅР°Р·РІР°РЅРёРµ С‚СЂРµСѓРіРѕР»СЊРЅРёРєР° РІ С„РѕСЂРјР°С‚Рµ string</returns>
        public string typeTriangleAtTheCorners()
        {
            switch (validTriangle(A, B, C) && C > A && C > B)
            {
                case true when (Math.Pow(C, 2) > Math.Pow(A, 2) + Math.Pow(B, 2)):
                    return $"{FigureName} С‚СѓРїРѕСѓРіРѕР»СЊРЅС‹Р№";
                case true when (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)):
                    return $"{FigureName} РїСЂСЏРјРѕСѓРіРѕР»СЊРЅС‹Р№";
                case true when (Math.Pow(C, 2) < Math.Pow(A, 2) + Math.Pow(B, 2)):
                    return $"{FigureName} РѕСЃС‚СЂРѕСѓРіРѕР»СЊРЅС‹Р№";
                default:
                    return $"РўСЂРµСѓРіРѕР»СЊРЅРёРє РЅРµ РєР»Р°СЃСЃРёС„РёС†РёСЂСѓРµС‚СЃСЏ РїРѕ С‚РёРїСѓ СѓРіР»РѕРІ";
            }
        }
        /// <summary>
        /// РћРїСЂРµРґРµР»РµРЅРёРµ РІРёРґР° С‚СЂРµСѓРіРѕР»СЊРЅРёРєР° РїРѕ СЃС‚РѕСЂРѕРЅР°Рј
        /// </summary>
        /// <returns>Р’РѕР·РІСЂР°С‰Р°РµС‚ РЅР°Р·РІР°РЅРёРµ С‚СЂРµСѓРіРѕР»СЊРЅРёРєР° РІ С„РѕСЂРјР°С‚Рµ string</returns>
        public string typeTriangleOnThSides()
        {
            switch (validTriangle(A, B, C))
            {
                case true when (A == B && A == C):
                    return $"{FigureName} СЂР°РІРЅРѕСЃС‚РѕСЂРѕРЅРЅРёР№";
                case true when (A == B):
                    return $"{FigureName} СЂР°РІРЅРѕР±РµРґСЂРµРЅРЅС‹Р№";
                case true when (A != B && A != C):
                    return $"{FigureName} СЂР°Р·РЅРѕСЃС‚РѕСЂРѕРЅРЅРёР№";
                default:
                    return $"РўСЂРµСѓРіРѕР»СЊРЅРёРє СЃ С‚Р°РєРёРјРё РїР°СЂР°РјРµС‚СЂР°РјРё РЅРµ СЃСѓС‰РµСЃС‚РІСѓРµС‚";
            }
        }
        /// <summary>
        /// РћРїСЂРµРґРµР»РµРЅРёРµ РІРёРґР° С‚СЂРµСѓРіРѕР»СЊРЅРёРєР° РїРѕ СЃС‚РѕСЂРѕРЅР°Рј СЃ Р·Р°РґР°РЅС‹РјРё РїР°СЂР°РјРµС‚СЂР°РјРё
        /// </summary>
        /// <returns>Р’РѕР·РІСЂР°С‰Р°РµС‚ РЅР°Р·РІР°РЅРёРµ С‚СЂРµСѓРіРѕР»СЊРЅРёРєР° РІ С„РѕСЂРјР°С‚Рµ string</returns>
        public string typeTriangleOnThSides(double a, double b, double c)
        {
            switch(validTriangle(a, b, c))
            {
                case true when (a == b && a == c): 
                    return $"{FigureName} СЂР°РІРЅРѕСЃС‚РѕСЂРѕРЅРЅРёР№";  
                case true when (a == b):
                    return $"{FigureName} СЂР°РІРЅРѕР±РµРґСЂРµРЅРЅС‹Р№";
                case true when (a != b && a != c):
                    return $"{FigureName} СЂР°Р·РЅРѕСЃС‚РѕСЂРѕРЅРЅРёР№";
                default: 
                    return $"РўСЂРµСѓРіРѕР»СЊРЅРёРє СЃ С‚Р°РєРёРјРё РїР°СЂР°РјРµС‚СЂР°РјРё РЅРµ СЃСѓС‰РµСЃС‚РІСѓРµС‚";
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
