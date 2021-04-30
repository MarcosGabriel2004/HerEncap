using System;

public class Retangulo : Figura{
  private double _altura;
  private double _largura;

  public Retangulo(double altura, double largura){
    this.Altura = altura;
    this.Largura = largura;
  }

  public double Altura{
    get{
      return this._altura;
    }

    set{
      if(value <= 0){
        Console.WriteLine("Valor inválido \n");
      }
      else{
        this._altura = value;
        this.RetArea();
        this.RetPerimetro();
      }
    }
  }

  public double Largura{
    get{
      return this._largura;
    }

    set{
      if(value <= 0){
        Console.WriteLine("Valor inválido \n");
      }
      else{
        this._largura = value;
        this.RetArea();
        this.RetPerimetro();
      }
    }
  }

  public void RetArea(){
    this._area = this._altura * this._largura;
  }

  public void RetPerimetro(){
    this._perimetro = 2 * this._altura + 2 * this._largura;
  }
}