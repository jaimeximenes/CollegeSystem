using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Services
{
    public class ContextDefault
    {
        private EscolaEntities context;

        public EscolaEntities Context
        {
            get
            {
                if (context == null)
                    context = new EscolaEntities();

                return context;
            }
            set { context = value; }
        }
    }
}