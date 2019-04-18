using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tema2ps.Models.DBModel.Repositories
{
    public class ClientInfoRepository
    {
        public clientInfo getClientInfobyID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            clientInfo u = new clientInfo();
            foreach (clientInfo uDB in entities.clientInfoes)
                if (uDB.id == id)
                    u = uDB;
            return u;
        }

        public void addClientInfo(clientInfo u)
        {
            tema2psEntities entities = new tema2psEntities();
            entities.clientInfoes.Add(u);
            entities.SaveChanges();
        }

        public void updateclientInfo(clientInfo u)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (clientInfo uDB in entities.clientInfoes)
                if (uDB.id == u.id)
                {
                    uDB.adress = u.adress;
                    uDB.CNP = u.CNP;
                    uDB.identityCardNumber = u.identityCardNumber;
                    uDB.userID = u.userID;
                    uDB.name = u.name;
                }
            entities.SaveChanges();
        }

        public void deleteclientInfoByID(int id)
        {
            tema2psEntities entities = new tema2psEntities();
            foreach (clientInfo uDB in entities.clientInfoes)
                if (uDB.id == id)
                    entities.clientInfoes.Remove(uDB);
            entities.SaveChanges();
        }

        public List<clientInfo> GetClientInfos()
        {
            tema2psEntities entities = new tema2psEntities();
            return entities.clientInfoes.ToList();
        }

        public int getMaxID()
        {
            tema2psEntities entities = new tema2psEntities();
            int id = 0;
            foreach (clientInfo u in entities.clientInfoes)
                if (u.id > id)
                    id = u.id;
            return id;
        }
    }
}