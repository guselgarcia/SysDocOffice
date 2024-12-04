/*******************************************************************************
*              Nome: Connection
*              Obs.: Esta classe representa a Entidade de Conexão com o Banco de 
*                    dados. 
*       Dt. Criação: 09/09/2024
*     Dt. Alteração: -
*    Obs. Alteração: -
*        Criada por: Monstro (mFacine)
*              Obs.: 
*******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysDocOffice
{
    class Connection
    {
        ~Connection()
        {

        }

        public static string Connection_Path()
        {

            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDBFilename=C:\Users\marcus.fgfacine\source\repos\SysDocOffice\SysDocOffice\BD_SysDocOffice.mdf; Integrated Security = True; Connect Timeout = 20";

        }
    }
}
