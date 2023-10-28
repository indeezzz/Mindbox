п»їusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public abstract class Figure : IFigure
    {
        protected abstract string FigureName { get; }
        public abstract double Perimeter();
        public abstract double Area();
        public virtual void Print()
        {
            Console.WriteLine($"РџРµСЂРёРјРµС‚СЂ {FigureName.ToLower()}Р°: {Perimeter()}");
            Console.WriteLine($"РџР»РѕС‰Р°РґСЊ {FigureName.ToLower()}Р°: {Area()}");
        }
    }
}
