﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGenericDao.Domain.Entities
{
    public class Responsible
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual IList<Task> Task { get; set; }
    }
}
