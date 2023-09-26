namespace Modelo
{
    public class Promedio
    {
        public string Nombre { get; set; }
        public double Eval1 { get; set; }
        public double Eval2 { get; set; }
        public double Eval3 { get; set; }   
        public double NotaActi { get; set; }

        public  virtual double CalcularPromedio()
        {
            return Eval1 + Eval2 + Eval3 + NotaActi/4;
        }
    }
}