﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.Entities
{
    public class RequestMessageText : RequestMessageBase,IRequestMessageBase
    {
        public string Content { get; set; }
    }
}
