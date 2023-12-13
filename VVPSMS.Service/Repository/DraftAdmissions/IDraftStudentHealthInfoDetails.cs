﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPSMS.Domain.Models;

namespace VVPSMS.Service.Repository.DraftAdmissions
{
    public interface IDraftStudentHealthInfoDetails : ICommonService<ArStudentHealthInfoDetail>
    {
        void RemoveRangeofDetails();
        void RemoveRangeofDetailsById(int id);
    }
}
