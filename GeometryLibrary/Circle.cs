п»їnamespace GeometryLibrary
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
        protected override string FigureName => "РљСЂСѓРі";
        /// <summary>
        /// Р’С‹С‡РёСЃР»РµРЅРёРµ РїРµСЂРёРјРµС‚СЂР° РєСЂСѓРіР°
        /// </summary>
        /// <returns>Р’С‹РІРѕРґ РїРµСЂРјРёРµС‚СЂР° РІ С„РѕСЂРјР°С‚Рµ double </returns>
        public override double Perimeter()
        {
            _perimeterCircle = 2 * _pi * R;
            return _perimeterCircle;
        }
        /// <summary>
        /// Р’С‹С‡РёСЃР»РµРЅРёРµ РїР»РѕС‰Р°РґРё РєСЂСѓРіР°
        /// </summary>
        /// <returns>Р’С‹РІРѕРґ РїР»РѕС‰Р°РґРё РІ С„РѕСЂРјР°С‚Рµ double</returns>
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
