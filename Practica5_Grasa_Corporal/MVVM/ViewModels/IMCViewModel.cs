using Practica5_Grasa_Corporal.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practica5_Grasa_Corporal.MVVM.ViewModels
{
    public class IMCViewModel
    {
        public IMC IMC { get; set; }
       
        public IMCViewModel()
        {
            IMC = new IMC();
 
        }
    }
}
