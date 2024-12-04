/*******************************************************************************
 *              Nome: Consulta
 *              Obs.: Esta classe representa a Entidade Consulta com atributos
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
    public class Consulta
    {
        ~Consulta()
        {
        }

        #region Atributos Privados
        private int v_Cod_Consulta = -1;
        private int v_Cod_Medico = -1;
        private int v_Cod_Paciente = -1;
        private DateTime v_DH_Consulta = DateTime.MinValue;
        private string v_Desc_Consulta = null;
        #endregion





        #region Metodos Públicos

        public int Cod_Consulta
        {
            get => v_Cod_Consulta;
            set => v_Cod_Consulta = value;
        }

        public int Cod_Medico 
        { 
            get => v_Cod_Medico; 
            set => v_Cod_Medico = value; 
        }
        
        public int Cod_Paciente 
        { 
            get => v_Cod_Paciente; 
            set => v_Cod_Paciente = value; 
        }
        
        public DateTime DH_Consulta
        { 
            get => v_DH_Consulta; 
            set => v_DH_Consulta = value; 
        }
        
        public string Desc_Consulta 
        { 
            get => v_Desc_Consulta; 
            set => v_Desc_Consulta = value; 
        }
        #endregion
    }
}
