using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Circulo c1 = new Circulo(2.0);
    Circulo c2 = new Circulo(3.4);

    Retangulo r1 = new Retangulo(2.0, 5.0);
    Retangulo r2 = new Retangulo(4.7, 2.5);

    List<Figura> Figuras = new List<Figura>();

    Figuras.Add(c1);
    Figuras.Add(c2);
    Figuras.Add(r1);
    Figuras.Add(r2);

    foreach(Figura f in Figuras){
      Console.WriteLine("Figura: \t {0}", f);
      f.Print();
    }

    c1.Raio = 4.3;
    c2.Raio = 2.0;
    r1.Altura = 3.0;
    r1.Largura = 7.2;
    r2.Altura = 1.8;
    r2.Largura = 3.5;

    foreach(Figura f in Figuras){
      Console.WriteLine("Figura: \t {0}", f);
      f.Print();
    }
  }
}