using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pato
{
         public class Pato
         {
            // Propriedades
           private String nome { get; set; }
           private ModoVoo voo;

           public Pato()
           {
              this.voo = new VoarComAsas();
           }

           public void voar() 
           {
            this.voo.voar();
           }
        }
}

