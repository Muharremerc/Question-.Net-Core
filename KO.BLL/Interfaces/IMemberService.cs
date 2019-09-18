using KO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.BLL.Interfaces
{
    public interface IMemberService:IServiceInterface<Member>
    {
        bool IsContain(Member member);
    }
}
