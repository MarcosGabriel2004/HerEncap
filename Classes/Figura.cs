using System;
using System.Collections.Generic;

public class Figura{
  protected double _area;
  protected double _perimetro;

  public double Area{
    get{
      return this._area;
    }
  }

  public double Perimetro{
    get{
      return this._perimetro;
    }
  }

  public void Print(){
    Console.WriteLine("Perímetro: \t {0}", this._perimetro);
    Console.WriteLine("Área: \t\t {0}", this._area);
    Console.WriteLine("");
  }
}