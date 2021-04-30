using System;

public class Circulo : Figura{
  private double _raio;

  public double Raio{
    get{
      return this._raio;
    }

    set{
      if(value <=0){
        Console.WriteLine("Valor inválido \n");
      }
      else{
        this._raio = value;
        this.CArea();
        this.CPerimetro();
      }
    }
  }

  public Circulo(double raio){
    this.Raio = raio;
  }

  public void CArea(){
    this._area = Math.PI * this._raio * this._raio;
  }

  public void CPerimetro(){
    this._perimetro = 2 * Math.PI * this._raio;
  }
}