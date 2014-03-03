﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMAPI
{
    public class SpinnerInfo
    {
        public PointInfo Location = new PointInfo();
        public int StartTime = 0;
        public bool NewCombo = true;
        public EffectType Effect = EffectType.None;
        public int EndTime = 0;
    }
}
