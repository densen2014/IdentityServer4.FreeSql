﻿using FreeSql.DataAnnotations;
using IdentityServer4.FreeSql.Storage.Entities;

namespace IdentityServer4.FreeSql.User.Entities
{
    public class LoginHistory : IBaseEntity
    {
        public long UserId { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        [Column(StringLength = 100, IsNullable = true)]
        public string IP { get; set; }

        /// <summary>
        /// 浏览器
        /// </summary>
        [Column(StringLength = 100, IsNullable = true)]
        public string Browser { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [Column(StringLength = 100, IsNullable = true)]
        public string Os { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        [Column(StringLength = 50, IsNullable = true)]
        public string Device { get; set; }

        /// <summary>
        /// 浏览器信息
        /// </summary>
        [Column(StringLength = -1, IsNullable = true)]
        public string BrowserInfo { get; set; }

        /// <summary>
        /// 耗时（毫秒）
        /// </summary>
        public long ElapsedMilliseconds { get; set; }

        /// <summary>
        /// 操作状态
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 操作消息
        /// </summary>
        [Column(StringLength = 300, IsNullable = true)]
        public string Message { get; set; }
    }
}
