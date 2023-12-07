using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.Services.Message
{
    public class MessageInitializeReponse : BaseResponse
    {
        public User FriendInfo { get; set; }
        public IEnumerable<Model.Message> Messages { get; set; }
    }
}
