using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCompanyLibrary
{
    public abstract class BaseMediaService
    {
        public abstract void ChangeMediaFree();
        public void Withdraw(List<Media> medias)
        {
            medias.Remove((Media)this);
            
        }

    }
}
