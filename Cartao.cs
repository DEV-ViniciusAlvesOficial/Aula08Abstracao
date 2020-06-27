namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        public string numero { get; set; }
	    public string bandeira { get; set; }
	    private string token = "qawje891q23u";
	    protected int cvc { get; set; }
        public string titular { get; set; }
        
            private bool ValidarToken(){
             if(token != null){
             return true;
             }
             else{
             return false;    
             }

         }
        
    }
}