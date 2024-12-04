using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysDocOffice
{
    internal class Quarto
    {
        #region Atributos Privados
        private int v_Cod_Quarto = -1;
        private int v_And_Quarto = 0;
        private int v_Nro_Quarto = 0;
        private int v_Tp_Quarto = 0;
        #endregion

        #region Metodos Públicos
        public int Cod_Quarto 
        { 
            get => v_Cod_Quarto; 
            set => v_Cod_Quarto = value; 
        }
        public int And_Quarto 
        { 
            get => v_And_Quarto; 
            set => v_And_Quarto = value; 
        }
        public int Nro_Quarto 
        { 
            get => v_Nro_Quarto; 
            set => v_Nro_Quarto = value; 
        }
        public int Tp_Quarto 
        { 
            get => v_Tp_Quarto; 
            set => v_Tp_Quarto = value; 
        }
        #endregion

    }
}
