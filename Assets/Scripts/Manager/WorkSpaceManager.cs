﻿/// <copyright>(c) 2017 WyzLink Inc. All rights reserved.</copyright>
/// <author>zq</author>
/// <summary>
/// 工作区逻辑
/// </summary>
namespace WyzLink.Manager
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using WyzLink.Parts;

    public class WorkSpaceManager : MonoBehaviour
    {

        private Button _AddWorkSpaceBtn;                    //添加工作区
        private Button _DelWorkSpaceBtn;                    //删除工作区

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// 计算零件再其他工作区的坐标（相对主工作区）
        /// </summary>
        /// <param name="node">零件</param>
        /// <param name="MainWorkSpace">主工作区位置</param>
        /// <returns></returns>
        public static Vector3 GetPartsInOtherWorkSpacePosition(Node node, Vector3 mainWorkSpacePosition, Vector3 otherWorkSpacePosition)
        {
            Vector3 var;
            var = node.EndPos - mainWorkSpacePosition + otherWorkSpacePosition;
            return var;
        }

    }
}
