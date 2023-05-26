using System;

namespace Todos
{
  public class Ex010101{
    public double Largura;
    public double Altura;

    public double Area()
    {
      return Largura * Altura;
    }

    public double Perimetro ()
    {
      return (2* Largura) + (2 * Altura) ;
    }



    public  double Diagonal()
    {
    return Math.Sqrt((Largura * Largura) + (Altura * Altura));
    }

    public override string ToString()
    {
      double area = Area();
      double perimetro = Perimetro();
      double diagonal = Diagonal();
      return ($"Area : {area}  Perimentro : {perimetro} Diagonal : {diagonal}");
    }


  }
}
