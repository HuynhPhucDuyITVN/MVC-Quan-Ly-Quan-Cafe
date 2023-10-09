using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Menu_BUS
    {
        public static List<Menu_DTO> LayDSMenu(int idban)
        {
            return Menu_DAO.LayDSMenu(idban);
        }
    }
}
