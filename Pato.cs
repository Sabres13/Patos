using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pato
{
   public class Pato
   {
      String nome{get; set;}
       ModoVoo voo;
       ModoNado nado;
       ModoMergulho mergulho;

      public Pato()
      {
         this.nome = "Pato";  
         this.nado = new NadoPato();
         this.voo= new VoarComAsas();
         this.mergulho = new MergulhoTranquilo();
      }

      public void Voar()
      {
         voo.voar();
      }


      public void Nadar ()
      {
         nado.nadar();
      }

      public void Mergulhar()
      {
        mergulho.mergulhar();
      }

      public String getNome()
      {
         return this.nome;
      }
   }
}

