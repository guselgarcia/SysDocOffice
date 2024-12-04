/*******************************************************************************
 *              Nome: Especialidade
 *              Obs.: Esta classe representa a Entidade Especialidade com atributos
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
    public class Especialidade
    {
        ~Especialidade()
        {
        }

        #region Atributos Privados
        private int v_Cod_Especialidade = -1;
        private string v_Nm_Especialidade = null;
        private string v_Desc_Especialidade = null;
        #endregion

        #region Metodos Públicos
        public int Cod_Especialidade
        {
            get => v_Cod_Especialidade;
            set => v_Cod_Especialidade = value;
        }

        public string Nm_Especialidade
        {
            get => v_Nm_Especialidade;
            set => v_Nm_Especialidade = value;
        }

        public string Desc_Especialidade 
        { 
            get => v_Desc_Especialidade; 
            set => v_Desc_Especialidade = value; 
        }
        #endregion
    }
}
