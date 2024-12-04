/*******************************************************************************
 *              Nome: Medico
 *              Obs.: Esta classe representa a Entidade Medico com atributos
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
    public class Medico
    {
        ~Medico()
        {
        }

        #region Atributos Privados
        private int v_Cod_Medico = -1;
        private int v_Cod_Especialidade = -1;
        private string v_Nm_Medico = null;
        private string v_CRM_Medico = null;
        #endregion

        #region Metodos Públicos

        public int Cod_Medico 
        { 
            get => v_Cod_Medico; 
            set => v_Cod_Medico = value; 
        }

        public int Cod_Especialidade 
        { 
            get => v_Cod_Especialidade; 
            set => v_Cod_Especialidade = value; 
        }

        public string Nm_Medico 
        { 
            get => v_Nm_Medico; 
            set => v_Nm_Medico = value; 
        }

        public string CRM_Medico 
        { 
            get => v_CRM_Medico; 
            set => v_CRM_Medico = value; 
        }
        #endregion
    }
}
