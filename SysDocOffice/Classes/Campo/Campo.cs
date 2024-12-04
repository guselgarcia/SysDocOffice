/*******************************************************************************
*              Nome: Campo
*              Obs.: Esta classe representa a Entidade de Conexão com o Banco de 
*                    dados. 
*       Dt. Criação: 03/12/2024
*     Dt. Alteração: -
*    Obs. Alteração: -
*        Criada por: Gus
*              Obs.: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysDocOffice
{
    public class Campo
    {
        ~Campo() 
        {
        }
            #region Atributos
        private string v_Nm_Campo = "";
        private string v_Tp_Campo = "";
        private int v_Tam_Campo = 0;
        #endregion
        #region Metodos Pricado
        public string Nm_Campo 
        { get => v_Nm_Campo; 
            set => v_Nm_Campo = value; 
        }
        public string Tp_Campo 
        { 
           get => v_Tp_Campo; 
           set => v_Tp_Campo = value; 
        }
        public int Tam_Campo 
        { get => v_Tam_Campo; 
          set => v_Tam_Campo = value; 
        }
        #endregion
    }
}
