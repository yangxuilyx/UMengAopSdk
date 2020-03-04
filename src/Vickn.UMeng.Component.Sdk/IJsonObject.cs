/*----------------------------------------------------------------
// Copyright (C) 2016 通通优品版权所有。
// 命名空间: TEC.Public.Component.UMengAopSdk
// 接口名：IJsonObject
// 功能描述：N/A
// 
// 创建标识：Roc.Lee(李鹏鹏) 2017/3/4 11:17:47 TEC-ROCLEE Roc.Lee

// 修改标识：
// 修改描述：
// 
//
//----------------------------------------------------------------*/

using Newtonsoft.Json.Linq;

namespace Vickn.UPush.Component.Sdk
{
    public interface IJsonObject
    {
        JObject ToObject();
    }
}
