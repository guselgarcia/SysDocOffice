/*******************************************************************************
 *              Nome: Usuario
 *              Obs.: Esta classe representa a Entidade Usuario com atributos
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
    public class Usuario
    {
        ~Usuario()
        {
        }

        #region Atributos Privados
        private int v_Cod_Usuario = -1;
        private string v_Nm_Usuario = null;
        private string v_UNm_Usuario = null;
        private string v_PW_Usuario = null;
        #endregion

        #region Metodos Públicos
        public int Cod_Usuario
        {
            get => v_Cod_Usuario;
            set => v_Cod_Usuario = value;
        }

        public string Nm_Usuario
        {
            get => v_Nm_Usuario;
            set => v_Nm_Usuario = value;
        }

        public string UNm_Usuario 
        {
            get => v_UNm_Usuario;
            set => v_UNm_Usuario = value;
        }

        public string PW_Usuario 
        { 
            get => v_PW_Usuario; 
            set => v_PW_Usuario = value; 
        }
        #endregion
    }
}
