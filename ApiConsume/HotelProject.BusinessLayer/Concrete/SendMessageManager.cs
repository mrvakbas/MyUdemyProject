using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMesssageDal _sendMesssageDal;

        public SendMessageManager(ISendMesssageDal sendMesssageDal)
        {
            _sendMesssageDal = sendMesssageDal;
        }

        public void TDelete(SendMessage t)
        {
            _sendMesssageDal.Delete(t);
        }

        public SendMessage TGetByID(int id)
        {
            return _sendMesssageDal.GetByID(id);
        }

        public List<SendMessage> TGetList()
        {
            return _sendMesssageDal.GetList();
        }

        public int TGetSendMessageCount()
        {
            return _sendMesssageDal.GetSendMessageCount();
        }

        public void TInsert(SendMessage t)
        {
            _sendMesssageDal.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
            _sendMesssageDal.Update(t);
        }
    }
}
