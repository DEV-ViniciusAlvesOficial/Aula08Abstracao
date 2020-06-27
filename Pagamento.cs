using System;

namespace Aula08Abstracao
{
    public class Pagamento
    {
      public DateTime data { get; set; }
      public float valor { get; set; }
      
      public string Pagar(float valorPago){
        return "O valor pago foi de" + valorPago;
      }
      public string cancelarPagamento(){
        return "A compra foi cancelada";
      }
    }
}