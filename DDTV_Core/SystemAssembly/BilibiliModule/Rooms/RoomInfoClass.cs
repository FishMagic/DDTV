﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTV_Core.SystemAssembly.BilibiliModule.Rooms
{
    public class RoomInfoClass
    {
        /// <summary>
        /// 直播质量
        /// </summary>
        public enum PlayQuality
        {
            /// <summary>
            /// 流畅
            /// </summary>
            Fluency =80,
            /// <summary>
            /// 高清
            /// </summary>
            HighDefinition=150,
            /// <summary>
            /// 蓝光
            /// </summary>
            BluRay=400,
            /// <summary>
            /// 原画
            /// </summary>
            OriginalPainting=10000,
            /// <summary>
            /// 选择默认最高质量
            /// </summary>
            DefaultHighest=10000
        }
        public class RoomInfo
        {
            /// <summary>
            /// 标题
            /// </summary>
            public string title { get; set; } = "";
            /// <summary>
            /// 直播间房间号(直播间实际房间号)
            /// </summary>
            public int room_id { get; set; }
            /// <summary>
            /// 主播mid
            /// </summary>
            public long uid { get; set; }
            /// <summary>
            /// 直播间在线人数
            /// </summary>
            public int online { get; set; }
            /// <summary>
            /// 开播时间(未开播时为-62170012800,live_status为1时有效)
            /// </summary>
            public long live_time { get; set; }
            /// <summary>
            /// 直播状态(1为正在直播，2为轮播中)
            /// </summary>
            public int live_status { get; set; }
            /// <summary>
            /// 直播间房间号(直播间短房间号，常见于签约主播)
            /// </summary>
            public int short_id { get; set; }
            /// <summary>
            /// 直播间分区id
            /// </summary>
            public int area { get; set; }
            /// <summary>
            /// 直播间分区名
            /// </summary>
            public string area_name { get; set; } = "";
            /// <summary>
            /// 直播间新版分区id
            /// </summary>
            public int area_v2_id { get; set; }
            /// <summary>
            /// 直播间新版分区名
            /// </summary>
            public string area_v2_name { get; set; } = "";
            /// <summary>
            /// 直播间父分区名
            /// </summary>
            public string area_v2_parent_name { get; set; } = "";
            /// <summary>
            /// 直播间父分区id
            /// </summary>
            public int area_v2_parent_id { get; set; }
            /// <summary>
            /// 用户名
            /// </summary>
            public string uname { get; set; } = "";
            /// <summary>
            /// 主播头像url
            /// </summary>
            public string face { get; set; } = "";
            /// <summary>
            /// 系统tag列表(以逗号分割)
            /// </summary>
            public string tag_name { get; set; } = "";
            /// <summary>
            /// 用户自定义tag列表(以逗号分割)
            /// </summary>
            public string tags { get; set; } = "";
            /// <summary>
            /// 直播封面图
            /// </summary>
            public string cover_from_user { get; set; } = "";
            /// <summary>
            /// 直播关键帧图
            /// </summary>
            public string keyframe { get; set; } = "";
            /// <summary>
            /// 直播间封禁信息
            /// </summary>
            public string lock_till { get; set; } = "";
            /// <summary>
            /// 直播间隐藏信息
            /// </summary>
            public string hidden_till { get; set; } = "";
            /// <summary>
            /// 直播类型(0:普通直播，1：手机直播)
            /// </summary>
            public int broadcast_type { get; set; }
            /// <summary>
            /// 是否p2p
            /// </summary>
            public int need_p2p { set; get; }
            /// <summary>
            /// 是否隐藏
            /// </summary>
            public bool is_hidden { set; get; }
            /// <summary>
            /// 是否锁定
            /// </summary>
            public bool is_locked { set; get; }
            /// <summary>
            /// 是否竖屏
            /// </summary>
            public bool is_portrait { set; get; }
            /// <summary>
            /// 是否加密
            /// </summary>
            public bool encrypted { set; get; }
            /// <summary>
            /// 加密房间是否通过密码验证(encrypted=true时才有意义)
            /// </summary>
            public bool pwd_verified { set; get; }
            /// <summary>
            /// 未知
            /// </summary>
            public int room_shield { set; get; }
            /// <summary>
            /// 是否为特殊直播间(0：普通直播间 1：付费直播间)
            /// </summary>
            public int is_sp { set; get; }
            /// <summary>
            /// 特殊直播间标志(0：普通直播间 1：付费直播间 2：拜年祭直播间)
            /// </summary>
            public int special_type { set; get; }
            /// <summary>
            /// 直播间状态(0:无房间 1:有房间)
            /// </summary>
            public int roomStatus { set; get; }
            /// <summary>
            /// (废弃：请使用live_status)(该值为getRoomInfoOld接口冗余值)直播状态(1为正在直播，2为轮播中)
            /// </summary>
            internal int liveStatus { set; get; }
            /// <summary>
            /// (废弃：请使用cover_from_user(该值为getRoomInfoOld接口冗余值)直播封面图
            /// </summary>
            internal string cover { get; set; } = "";
            /// <summary>
            /// 轮播状态(0：未轮播 1：轮播)
            /// </summary>
            public int roundStatus { set; get; }
            /// <summary>
            /// 直播间网页url
            /// </summary>
            public string url { set; get; } = "";
            /// <summary>
            /// 描述(Local值)
            /// </summary>
            public string Description { get; set; } = "";
            /// <summary>
            /// 是否自动录制(Local值)
            /// </summary>
            public bool IsAutoRec { set; get; }
            /// <summary>
            /// 是否开播提醒(Local值)
            /// </summary>
            public bool IsRemind { set; get; }
            /// <summary>
            /// 特殊标记(Local值)
            /// </summary>
            public bool Like { set; get; }

        }
    }
}