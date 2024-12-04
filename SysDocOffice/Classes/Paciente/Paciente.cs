/*******************************************************************************
 *              Nome: Paciente
 *              Obs.: Esta classe representa a Entidade Paciente com atributos
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
    public class Paciente
    {
        ~Paciente()
        {
        }

        #region Atributos Privados
        private int v_Cod_Paciente = -1;
        private int v_Cod_Convenio = -1;
        private string v_Nm_Paciente = null;
        private string v_CPF_Paciente = null;
        private string v_NroConv_Paciente = null;
        #endregion

        #region Metodos Públicos

        public int Cod_Paciente
        {
            get => v_Cod_Paciente;
            set => v_Cod_Paciente = value;
        }

        public int Cod_Convenio 
        { 
            get => v_Cod_Convenio; 
            set => v_Cod_Convenio = value; 
        }

        public string Nm_Paciente 
        { 
            get => v_Nm_Paciente; 
            set => v_Nm_Paciente = value; 
        }

        public string CPF_Paciente 
        { 
            get => v_CPF_Paciente; 
            set => v_CPF_Paciente = value; 
        }

        public string NroConv_Paciente 
        { 
            get => v_NroConv_Paciente; 
            set => v_NroConv_Paciente = value; 
        }
        #endregion
    }
}
