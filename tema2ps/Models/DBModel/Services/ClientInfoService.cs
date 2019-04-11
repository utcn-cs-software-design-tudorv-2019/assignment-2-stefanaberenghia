using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tema2ps.Models.DBModel.Repositories;

namespace tema2ps.Models.DBModel.Services
{
    public class ClientInfoService
    {
        public clientInfo getClientInfobyID(int id)
        {
            return new ClientInfoRepository().getClientInfobyID(id);
        }

        public void addClientInfo(clientInfo u)
        {
            new ClientInfoRepository().addClientInfo(u);
        }

        public void updateClientInfo(clientInfo u)
        {
            new ClientInfoRepository().updateclientInfo(u);
        }

        public void deleteAccount(int id)
        {
            new ClientInfoRepository().deleteclientInfoByID(id);
        }

        public List<clientInfo> GetClientInfos()
        {
            return new ClientInfoRepository().GetClientInfos();
        }
    }
}