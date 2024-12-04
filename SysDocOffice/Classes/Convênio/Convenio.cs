/*******************************************************************************
 *              Nome: Convenio
 *              Obs.: Esta classe representa a Entidade Convênio com atributos
 *                    privados e metodos (Get/Set) públicos.
 *       Dt. Criação: 03/09/2024
 *     Dt. Alteração: -
 *    Obs. Alteração: -
 *        Criada por: Monstro (mFacine)
 *******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysDocOffice
{
    public class Convenio
    {
        ~Convenio()
        {
        }

        #region Atributos Privados
        private int v_Cod_Convenio = -1;
        private string v_Nm_Convenio = null;
        private int v_Mod_Convenio = 0;
        #endregion

        #region Metodos Públicos
        public int Cod_Convenio 
        { 
            get => v_Cod_Convenio; 
            set => v_Cod_Convenio = value; 
        }

        public string Nm_Convenio 
        { 
            get => v_Nm_Convenio; 
            set => v_Nm_Convenio = value; 
        }
        
        public int Mod_Convenio 
        { 
            get => v_Mod_Convenio; 
            set => v_Mod_Convenio = value; 
        }
        #endregion
    }
}
