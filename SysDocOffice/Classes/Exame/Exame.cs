/*******************************************************************************
 *              Nome: Exame
 *              Obs.: Esta classe representa a Entidade Exame com atributos
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
    public class Exame
    {
        ~Exame()
        {
        }

        #region Atributos Privados
        private int v_Cod_Exame = -1;
        private string v_Nm_Exame = null;
        private bool v_Jjm_Exame = false;
        #endregion

        #region Metodos Públicos
        public int Cod_Exame
        {
            get => v_Cod_Exame;
            set => v_Cod_Exame = value;
        }

        public string Nm_Exame
        {
            get => v_Nm_Exame;
            set => v_Nm_Exame = value;
        }

        public bool Jjm_Exame 
        { 
            get => v_Jjm_Exame; 
            set => v_Jjm_Exame = value; 
        }


        #endregion
    }
}
