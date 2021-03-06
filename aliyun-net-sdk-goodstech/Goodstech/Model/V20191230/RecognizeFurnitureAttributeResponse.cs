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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.goodstech.Model.V20191230
{
	public class RecognizeFurnitureAttributeResponse : AcsResponse
	{

		private string requestId;

		private RecognizeFurnitureAttribute_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public RecognizeFurnitureAttribute_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class RecognizeFurnitureAttribute_Data
		{

			private string predStyleId;

			private string predStyle;

			private float? predProbability;

			public string PredStyleId
			{
				get
				{
					return predStyleId;
				}
				set	
				{
					predStyleId = value;
				}
			}

			public string PredStyle
			{
				get
				{
					return predStyle;
				}
				set	
				{
					predStyle = value;
				}
			}

			public float? PredProbability
			{
				get
				{
					return predProbability;
				}
				set	
				{
					predProbability = value;
				}
			}
		}
	}
}
