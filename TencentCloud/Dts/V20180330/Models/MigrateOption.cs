/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateOption : AbstractModel
    {
        
        /// <summary>
        /// 任务运行模式，值包括：1-立即执行，2-定时执行
        /// </summary>
        [JsonProperty("RunMode")]
        public long? RunMode{ get; set; }

        /// <summary>
        /// 期望执行时间，当runMode=2时，该字段必填，时间格式：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// 数据迁移类型，值包括：1-结构迁移,2-全量迁移,3-全量+增量迁移
        /// </summary>
        [JsonProperty("MigrateType")]
        public long? MigrateType{ get; set; }

        /// <summary>
        /// 迁移对象，1-整个实例，2-指定库表
        /// </summary>
        [JsonProperty("MigrateObject")]
        public long? MigrateObject{ get; set; }

        /// <summary>
        /// 数据对比类型，1-未配置,2-全量检测,3-抽样检测, 4-仅校验不一致表,5-不检测
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public long? ConsistencyType{ get; set; }

        /// <summary>
        /// 是否用源库Root账户覆盖目标库，值包括：0-不覆盖，1-覆盖，选择库表或者结构迁移时应该为0
        /// </summary>
        [JsonProperty("IsOverrideRoot")]
        public long? IsOverrideRoot{ get; set; }

        /// <summary>
        /// 不同数据库用到的额外参数.以JSON格式描述. 
        /// Redis可定义如下的参数: 
        /// { 
        /// 	"ClientOutputBufferHardLimit":512, 	从机缓冲区的硬性容量限制(MB) 
        /// 	"ClientOutputBufferSoftLimit":512, 	从机缓冲区的软性容量限制(MB) 
        /// 	"ClientOutputBufferPersistTime":60, 从机缓冲区的软性限制持续时间(秒) 
        /// 	"ReplBacklogSize":512, 	环形缓冲区容量限制(MB) 
        /// 	"ReplTimeout":120，		复制超时时间(秒) 
        /// }
        /// MongoDB可定义如下的参数: 
        /// {
        /// 	'SrcAuthDatabase':'admin', 
        /// 	'SrcAuthFlag': "1", 
        /// 	'SrcAuthMechanism':"SCRAM-SHA-1"
        /// }
        /// </summary>
        [JsonProperty("ExternParams")]
        public string ExternParams{ get; set; }

        /// <summary>
        /// 抽样检验时的抽样参数
        /// </summary>
        [JsonProperty("ConsistencyParams")]
        public ConsistencyParams ConsistencyParams{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "ExpectTime", this.ExpectTime);
            this.SetParamSimple(map, prefix + "MigrateType", this.MigrateType);
            this.SetParamSimple(map, prefix + "MigrateObject", this.MigrateObject);
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
            this.SetParamSimple(map, prefix + "IsOverrideRoot", this.IsOverrideRoot);
            this.SetParamSimple(map, prefix + "ExternParams", this.ExternParams);
            this.SetParamObj(map, prefix + "ConsistencyParams.", this.ConsistencyParams);
        }
    }
}

