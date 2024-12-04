/*******************************************************************************
 *              Nome: Item
 *              Obs.: Esta classe representa a Entidade Item com atributos
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
    public class Item
    {
        ~Item()
        {
        }

        #region Atributos Privados
        private int v_Cod_Item = -1;
        private int v_Cod_Consulta = -1;
        private int v_Cod_Exame = -1;
        #endregion





        #region Metodos Públicos

        public int Cod_Item
        {
            get => v_Cod_Item;
            set => v_Cod_Item = value;
        }

        public int Cod_Consulta 
        { 
            get => v_Cod_Consulta; 
            set => v_Cod_Consulta = value; 
        }

        public int Cod_Exame 
        { 
            get => v_Cod_Exame; 
            set => v_Cod_Exame = value; 
        }


        #endregion
    }
}
