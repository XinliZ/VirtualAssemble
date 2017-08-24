﻿/// <copyright>(c) 2017 WyzLink Inc. All rights reserved.</copyright>
/// <author>xlzou</author>
/// <summary>
/// 零件接驳方式
/// </summary>

namespace WyzLink.Parts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class 双层长孔 : ConnectorBase
    {
        public float 长度;
        public float 直径1;
        public float 直径2;
        public float 厚度1;
        public float 厚度2;

        public override string GetName()
        {
            return "双层长孔" + " Ø " + 直径1 + " Ø " + 直径2;
        }
    }
}